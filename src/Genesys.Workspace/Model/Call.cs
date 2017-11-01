using System;
using System.Collections.Generic;
using Genesys.Workspace.Common;
using Genesys.Workspace.Model;

namespace Genesys.Workspace.Model
{
    public class Call
    {
        public string id { get; set; }
        public string callUuid { get; set; }
        public CallState state { get; set; }
        public string parentConnId { get; set; }
        public string previousConnId { get; set; }
        public string callType { get; set; }
        public string ani { get; set; }
        public string dnis { get; set; }
        public string recordingState { get; set; }
        public string[] participants { get; set; }
        public KeyValueCollection userData { get; set; }
        public CallCapability[] capabilities { get; set; }

        public override string ToString()
        {
            return string.Format("[Call: id={0}, callUuid={1}, state={2}, parentConnId={3}, previousConnId={4}, callType={5}, ani={6}, dnis={7}, recordingState={8}, participants={9}, userData={10}, capabilities={11}]", id, callUuid, state, parentConnId, previousConnId, callType, ani, dnis, recordingState, this.ParticipantsAsString(participants), userData, this.CapabilitiesAsString(capabilities));
        }

        public string ParticipantsAsString(string[] participants)
        {
            String temp = "";

            if (participants != null)
            {
                temp = String.Join(",", participants);
            }

            return "[" + temp + "]";
        }

        public string CapabilitiesAsString(CallCapability[] caps)
        {
            List<string> capabilities = new List<string>();

            if (caps != null)
            {
                foreach (CallCapability c in caps)
                {
                    capabilities.Add(c.ToString());
                }
            }

            return "[" + String.Join(",", capabilities) + "]";
        }
    }
}
