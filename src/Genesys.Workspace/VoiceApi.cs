using System;
using System.Collections;
using System.Collections.Generic;
using CometD.Bayeux;
using CometD.Bayeux.Client;
using CometD.Client;
using Genesys.Workspace.Client;
using Genesys.Workspace.Model;
using RestSharp;

namespace Genesys.Workspace
{
    public class VoiceApi
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public delegate void DnStateChangedEventHandler(Dn dn, IMessage message);
        public event DnStateChangedEventHandler DnStateChanged;

        public delegate void CallStateChangedEventHandler(Call call, IMessage message);
        public event CallStateChangedEventHandler CallStateChanged;

        public delegate void VoiceErrorEventHandler(string msg, string code, IMessage message);
        public event VoiceErrorEventHandler VoiceErrorReceived;

        private Genesys.Workspace.Api.VoiceApi voiceApi;
        public Dn Dn { get; protected set; }
        public Dictionary<string, Call> Calls { get; protected set; }

        public VoiceApi()
        {
            Calls = new Dictionary<string, Call>();
        }

        public void Initialize(ApiClient apiClient)
        {
            this.voiceApi = new Api.VoiceApi(apiClient.RestClient.BaseUrl.ToString());
            voiceApi.Configuration.ApiClient = apiClient;
        }

        public void OnVoiceMessage(IClientSessionChannel channel, IMessage message, BayeuxClient client)
        {
            try
            {
                IDictionary<string, object> data = message.DataAsDictionary;

                string messageType = (string)data.GetValue("messageType");

                switch (messageType)
                {
                    case "DnStateChanged":
                        this.onDnStateChanged(channel, message, client);
                        break;

                    case "CallStateChanged":
                        this.onCallStateChanged(channel, message, client);
                        break;

                    case "EventError":
                        this.onEventError(channel, message, client);
                        break;

                    default:
                        log.Debug("Unexpected messageType: " + messageType);
                        break;
                }
            }
            catch(Exception exc)
            {
                log.Error("Error handling OnVoiceMessage", exc);
            }
        }

        public void onDnStateChanged(IClientSessionChannel channel, IMessage message, BayeuxClient client)
        {
            if (this.Dn == null)
            {
                this.Dn = new Dn();
            }

            IDictionary<string, object> data = message.DataAsDictionary;

            Dictionary<string, object> dnData = (Dictionary<string, object>)data.GetValue("dn");

            this.Dn.number = (string)dnData.GetValue("number");
            this.Dn.switchName = (string)dnData.GetValue("switchName");
            this.Dn.agentId = (string)dnData.GetValue("agentId");

            AgentState agentState;
            agentState = (Enum.TryParse<AgentState>((string)dnData.GetValue("agentState"), out agentState) == true) ? agentState : AgentState.Unknown;
            this.Dn.agentState = agentState;

            AgentWorkMode workMode;
            workMode = (Enum.TryParse<AgentWorkMode>((string)dnData.GetValue("agentWorkMode"), out workMode) == true) ? workMode: AgentWorkMode.Unknown;
            this.Dn.workMode = workMode;

            this.Dn.telephonyNetwork = (string)dnData.GetValue("telephonyNetwork");

            this.Dn.forwardTo = (string)dnData.GetValue("forwardTo");
            this.Dn.dnd = "on".Equals((string)dnData.GetValue("dnd"));

            ArrayList capabilities = (ArrayList)dnData.GetValue("capabilities");
            List<DnCapability> caps = new List<DnCapability>();

            foreach (string c in capabilities)
            {
                DnCapability cap;

                if ( Enum.TryParse<DnCapability>(c.Replace('-', '_'), out cap) )
                {
                    caps.Add(cap);
                }
            }
            this.Dn.capabilities = caps.ToArray();

            log.Debug("Dn updated: " + Dn.ToString());

            DnStateChanged?.Invoke(this.Dn, message);
        }

        private void onCallStateChanged(IClientSessionChannel channel, IMessage message, BayeuxClient client)
        {
            IDictionary<string, object> data = message.DataAsDictionary;

            Dictionary<string, object> callData = (Dictionary<string, object>)data.GetValue("call");
            NotificationType notificationType = Util.parseNotificationType((string)data.GetValue("notificationType"));

            string id = (string)callData.GetValue("id");
            string callUuid = (string)callData.GetValue("callUuid");
            CallState state = Util.parseCallState((string)callData.GetValue("state"));
            string parentConnId = (string)callData.GetValue("parentConnId");
            string previousConnId = (string)callData.GetValue("previousConnId");
            string ani = (string)callData.GetValue("ani");
            string dnis = (string)callData.GetValue("dnis");
            object[] participantData = (object[])callData.GetValue("participants");
            KeyValueCollection userData = new KeyValueCollection();
            Util.extractKeyValueData(userData, (ArrayList)callData.GetValue("userData"));

            String[] participants = Util.extractParticipants(participantData);

            bool connIdChanged = false;
            String callType = (string)callData.GetValue("callType");

            Call call = this.Calls[id];
            if (call == null)
            {
                call = new Call()
                {
                    id = id,
                    callType = callType,
                    parentConnId = parentConnId
                };

                this.Calls.Add(id, call);
                log.Debug("Added call:  " + call.ToString());
            }

            if (previousConnId != null && this.Calls.ContainsKey(previousConnId))
            {
                call = this.Calls[previousConnId];
                this.Calls.Remove(previousConnId);
                call.id = id;
                call.previousConnId = previousConnId;
                this.Calls.Add(id, call);
                connIdChanged = true;
            }
            else if (state == CallState.RELEASED)
            {
                this.Calls.Remove(id);
                log.Debug("Removed call " + id + "(" + state + ")");
            }

            call.state = state;
            call.ani = ani;
            call.dnis = dnis;
            call.callUuid = callUuid;
            call.participants = participants;
            call.userData = userData;

            ArrayList capabilities = (ArrayList)callData.GetValue("capabilities");
            List<CallCapability> caps = new List<CallCapability>();

            foreach (string c in capabilities)
            {
                CallCapability cap;

                if (Enum.TryParse<CallCapability>(c.Replace('-', '_'), out cap))
                {
                    caps.Add(cap);
                }
            }
            call.capabilities = caps.ToArray();

            CallStateChanged?.Invoke(call, message);
        }

        private void onEventError(IClientSessionChannel channel, IMessage message, BayeuxClient client)
        {
            IDictionary<string, object> data = message.DataAsDictionary;

            Dictionary<string, object> errorDetails = (Dictionary<string, object>)data.GetValue("error");
            string msg = (string)errorDetails.GetValue("errorMessage");
            string code = errorDetails.GetValue("errorCode") == null ? "" : errorDetails.GetValue("errorCode").ToString();

            VoiceErrorReceived?.Invoke(msg, code, message);
        }

        /**
         * Set the agent state to ready.
         */
        public void SetAgentReady()
        {
            this.SetAgentReady(null, null);
        }

        /**
         * Set the agent state to ready.
         * @param reasons reasons
         * @param extensions extensions
         */
        public void SetAgentReady(
                KeyValueCollection reasons,
                KeyValueCollection extensions
        )
        {
            try {
                VoicereadyData readyData = new VoicereadyData();
                readyData.Reasons = null;
                readyData.Extensions = null;
                ReadyData data = new ReadyData();
                data.Data = readyData;

                ApiSuccessResponse response = this.voiceApi.SetAgentStateReady(data);
                Util.ThrowIfNotOk("SetAgentReady", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("SetAgentReady failed.", e);
            }
        }

        /**
         * Set the agent state to not ready.
         */
        public void SetAgentNotReady()
        {
            this.SetAgentNotReady(null, null, null, null);
        }

        /**
         * Set the agent state to not ready.
         * @param workMode optional workMode to use in the request.
         * @param reasonCode optional reasonCode to use in the request.
         */
        public void SetAgentNotReady(String workMode, String reasonCode)
        {
            this.SetAgentNotReady(workMode, reasonCode, null, null);
        }

        /**
         * Set the agent state to not ready.
         * @param workMode optional workMode to use in the request.
         * @param reasonCode optional reasonCode to use in the request.
         * @param reasons reasons
         * @param extensions extensions
         */
        public void SetAgentNotReady(
                String workMode,
                String reasonCode,
                KeyValueCollection reasons,
                KeyValueCollection extensions
        )
        {
            try {
                NotReadyData data = new NotReadyData();

                VoicenotreadyData notReadyData = new VoicenotreadyData();
                notReadyData.ReasonCode = reasonCode;
                notReadyData.Reasons = null;
                notReadyData.Extensions = null;

                if (workMode != null)
                {
                    notReadyData.AgentWorkMode = (VoicenotreadyData.AgentWorkModeEnum)Enum.Parse(typeof(VoicenotreadyData.AgentWorkModeEnum), workMode);
                }

                data.Data = notReadyData;

                ApiSuccessResponse response = this.voiceApi.SetAgentStateNotReady(data);
                Util.ThrowIfNotOk("SetAgentNotReady", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("SetAgentReady failed.", e);
            }
        }

        /**
         * Set do-not-disturb on for voice.
         */
        public void DndOn()
        {
            try {
                ApiSuccessResponse response = this.voiceApi.SetDNDOn();
                Util.ThrowIfNotOk("DndOn", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("DndOn failed.", e);
            }
        }

        /**
         * Set do-not-disturb off for voice.
         */
        public void DndOff()
        {
            try {
                ApiSuccessResponse response = this.voiceApi.SetDNDOff();
                Util.ThrowIfNotOk("DndOff", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("DndOff failed.", e);
            }
        }

        /**
         * Login the voice channel.
         */
        public void Login()
        {
            try {
                ApiSuccessResponse response = this.voiceApi.LoginVoice();
                Util.ThrowIfNotOk("VoiceLogin", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("VoiceLogin failed", e);
            }
        }

        /**
         * Logout the voice channel.
         */
        public void Logout()
        {
            try {
                ApiSuccessResponse response = this.voiceApi.LogoutVoice();
                Util.ThrowIfNotOk("VoiceLogout", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("VoiceLogout failed", e);
            }
        }

        /**
         * Set call forwarding to the specififed destination.
         * @param destination - destination to forward calls to.
         */
        public void SetForward(String destination)
        {
            try {
                VoicesetforwardData forwardData = new VoicesetforwardData();
                forwardData.ForwardTo = destination;

                ForwardData data = new ForwardData();
                data.Data = forwardData;

                ApiSuccessResponse response = this.voiceApi.Forward(data);
                Util.ThrowIfNotOk("SetForward", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("SetForward failed.", e);
            }
        }

        /**
         * Cancel call forwarding.
         */
        public void CancelForward()
        {
            try {
                ApiSuccessResponse response = this.voiceApi.CancelForward();
                Util.ThrowIfNotOk("CancelForward", response);
            } catch (ApiException e) {
                throw new WorkspaceApiException("CancelForward failed.", e);
            }
        }
    }
}
