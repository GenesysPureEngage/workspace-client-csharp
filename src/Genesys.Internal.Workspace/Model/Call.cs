/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.24.2336
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Genesys.Internal.Workspace.Client.SwaggerDateConverter;

namespace Genesys.Internal.Workspace.Model
{
    /// <summary>
    /// Call
    /// </summary>
    [DataContract]
    public partial class Call :  IEquatable<Call>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Id">The unique identifier for the call..</param>
        /// <param name="PreviousConnId">The previous connection ID is present if the ID has changed, as would be the case if an agent is the target of a two-step conference or transfer..</param>
        /// <param name="ParentConnId">The parent connection ID is present on consult calls and identifies the call from which the conference or transfer was initiated..</param>
        /// <param name="PhoneNumber">The agent&#39;s phone number..</param>
        /// <param name="ConnId">The connection ID for the call. This value comes from the Tlib event..</param>
        /// <param name="CallUuid">The universally unique identifier associated with the call. This is a separate identifier that is specifically required by some requests..</param>
        /// <param name="CallType">The type of call, such as Internal, Inbound, Outbound, Consult..</param>
        /// <param name="State">The state of the call, such asRinging, Dialing, Established, Held, Released, or Completed. Unless specifically configured, calls are automatically completed upon release..</param>
        /// <param name="Capabilities">A list of capabilities for the current state. For example, if the current state is Dialing, the list might be [\&quot;HangUp\&quot;, \&quot;Hold\&quot;]..</param>
        /// <param name="Participants">A list of call participants&amp;mdash;the phone numbers of those currently on the call..</param>
        /// <param name="Dnis">The Dialed Number Identification Service from the call..</param>
        /// <param name="Ani">The Automatic Number Identification from the call..</param>
        /// <param name="RecordingState">The call recording state, one of Stopped, Recording, Paused. If the recording was never started for a call this property is absent..</param>
        /// <param name="UserData">A key/value pairs list of a data associated with the call..</param>
        /// <param name="Extensions">Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions)..</param>
        public Call(string Type = default(string), string Id = default(string), string PreviousConnId = default(string), string ParentConnId = default(string), string PhoneNumber = default(string), string ConnId = default(string), string CallUuid = default(string), string CallType = default(string), string State = default(string), List<string> Capabilities = default(List<string>), List<CallParticipants> Participants = default(List<CallParticipants>), string Dnis = default(string), string Ani = default(string), string RecordingState = default(string), List<Kvpair> UserData = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            this.Type = Type;
            this.Id = Id;
            this.PreviousConnId = PreviousConnId;
            this.ParentConnId = ParentConnId;
            this.PhoneNumber = PhoneNumber;
            this.ConnId = ConnId;
            this.CallUuid = CallUuid;
            this.CallType = CallType;
            this.State = State;
            this.Capabilities = Capabilities;
            this.Participants = Participants;
            this.Dnis = Dnis;
            this.Ani = Ani;
            this.RecordingState = RecordingState;
            this.UserData = UserData;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// The unique identifier for the call.
        /// </summary>
        /// <value>The unique identifier for the call.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The previous connection ID is present if the ID has changed, as would be the case if an agent is the target of a two-step conference or transfer.
        /// </summary>
        /// <value>The previous connection ID is present if the ID has changed, as would be the case if an agent is the target of a two-step conference or transfer.</value>
        [DataMember(Name="previousConnId", EmitDefaultValue=false)]
        public string PreviousConnId { get; set; }

        /// <summary>
        /// The parent connection ID is present on consult calls and identifies the call from which the conference or transfer was initiated.
        /// </summary>
        /// <value>The parent connection ID is present on consult calls and identifies the call from which the conference or transfer was initiated.</value>
        [DataMember(Name="parentConnId", EmitDefaultValue=false)]
        public string ParentConnId { get; set; }

        /// <summary>
        /// The agent&#39;s phone number.
        /// </summary>
        /// <value>The agent&#39;s phone number.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The connection ID for the call. This value comes from the Tlib event.
        /// </summary>
        /// <value>The connection ID for the call. This value comes from the Tlib event.</value>
        [DataMember(Name="connId", EmitDefaultValue=false)]
        public string ConnId { get; set; }

        /// <summary>
        /// The universally unique identifier associated with the call. This is a separate identifier that is specifically required by some requests.
        /// </summary>
        /// <value>The universally unique identifier associated with the call. This is a separate identifier that is specifically required by some requests.</value>
        [DataMember(Name="callUuid", EmitDefaultValue=false)]
        public string CallUuid { get; set; }

        /// <summary>
        /// The type of call, such as Internal, Inbound, Outbound, Consult.
        /// </summary>
        /// <value>The type of call, such as Internal, Inbound, Outbound, Consult.</value>
        [DataMember(Name="callType", EmitDefaultValue=false)]
        public string CallType { get; set; }

        /// <summary>
        /// The state of the call, such asRinging, Dialing, Established, Held, Released, or Completed. Unless specifically configured, calls are automatically completed upon release.
        /// </summary>
        /// <value>The state of the call, such asRinging, Dialing, Established, Held, Released, or Completed. Unless specifically configured, calls are automatically completed upon release.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// A list of capabilities for the current state. For example, if the current state is Dialing, the list might be [\&quot;HangUp\&quot;, \&quot;Hold\&quot;].
        /// </summary>
        /// <value>A list of capabilities for the current state. For example, if the current state is Dialing, the list might be [\&quot;HangUp\&quot;, \&quot;Hold\&quot;].</value>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// A list of call participants&amp;mdash;the phone numbers of those currently on the call.
        /// </summary>
        /// <value>A list of call participants&amp;mdash;the phone numbers of those currently on the call.</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<CallParticipants> Participants { get; set; }

        /// <summary>
        /// The Dialed Number Identification Service from the call.
        /// </summary>
        /// <value>The Dialed Number Identification Service from the call.</value>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }

        /// <summary>
        /// The Automatic Number Identification from the call.
        /// </summary>
        /// <value>The Automatic Number Identification from the call.</value>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }

        /// <summary>
        /// The call recording state, one of Stopped, Recording, Paused. If the recording was never started for a call this property is absent.
        /// </summary>
        /// <value>The call recording state, one of Stopped, Recording, Paused. If the recording was never started for a call this property is absent.</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public string RecordingState { get; set; }

        /// <summary>
        /// A key/value pairs list of a data associated with the call.
        /// </summary>
        /// <value>A key/value pairs list of a data associated with the call.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }

        /// <summary>
        /// Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions).
        /// </summary>
        /// <value>Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions).</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public List<Kvpair> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Call {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PreviousConnId: ").Append(PreviousConnId).Append("\n");
            sb.Append("  ParentConnId: ").Append(ParentConnId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ConnId: ").Append(ConnId).Append("\n");
            sb.Append("  CallUuid: ").Append(CallUuid).Append("\n");
            sb.Append("  CallType: ").Append(CallType).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Call);
        }

        /// <summary>
        /// Returns true if Call instances are equal
        /// </summary>
        /// <param name="input">Instance of Call to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Call input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PreviousConnId == input.PreviousConnId ||
                    (this.PreviousConnId != null &&
                    this.PreviousConnId.Equals(input.PreviousConnId))
                ) && 
                (
                    this.ParentConnId == input.ParentConnId ||
                    (this.ParentConnId != null &&
                    this.ParentConnId.Equals(input.ParentConnId))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ConnId == input.ConnId ||
                    (this.ConnId != null &&
                    this.ConnId.Equals(input.ConnId))
                ) && 
                (
                    this.CallUuid == input.CallUuid ||
                    (this.CallUuid != null &&
                    this.CallUuid.Equals(input.CallUuid))
                ) && 
                (
                    this.CallType == input.CallType ||
                    (this.CallType != null &&
                    this.CallType.Equals(input.CallType))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Capabilities == input.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(input.Capabilities)
                ) && 
                (
                    this.Participants == input.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(input.Participants)
                ) && 
                (
                    this.Dnis == input.Dnis ||
                    (this.Dnis != null &&
                    this.Dnis.Equals(input.Dnis))
                ) && 
                (
                    this.Ani == input.Ani ||
                    (this.Ani != null &&
                    this.Ani.Equals(input.Ani))
                ) && 
                (
                    this.RecordingState == input.RecordingState ||
                    (this.RecordingState != null &&
                    this.RecordingState.Equals(input.RecordingState))
                ) && 
                (
                    this.UserData == input.UserData ||
                    this.UserData != null &&
                    this.UserData.SequenceEqual(input.UserData)
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PreviousConnId != null)
                    hashCode = hashCode * 59 + this.PreviousConnId.GetHashCode();
                if (this.ParentConnId != null)
                    hashCode = hashCode * 59 + this.ParentConnId.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.ConnId != null)
                    hashCode = hashCode * 59 + this.ConnId.GetHashCode();
                if (this.CallUuid != null)
                    hashCode = hashCode * 59 + this.CallUuid.GetHashCode();
                if (this.CallType != null)
                    hashCode = hashCode * 59 + this.CallType.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Capabilities != null)
                    hashCode = hashCode * 59 + this.Capabilities.GetHashCode();
                if (this.Participants != null)
                    hashCode = hashCode * 59 + this.Participants.GetHashCode();
                if (this.Dnis != null)
                    hashCode = hashCode * 59 + this.Dnis.GetHashCode();
                if (this.Ani != null)
                    hashCode = hashCode * 59 + this.Ani.GetHashCode();
                if (this.RecordingState != null)
                    hashCode = hashCode * 59 + this.RecordingState.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
