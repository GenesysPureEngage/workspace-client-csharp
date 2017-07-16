/* 
 * Workspace API
 *
 * Application API used by Workspace Web Edition
 *
 * OpenAPI spec version: 1.0.0
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

namespace Genesys.Workspace.Model
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
        /// <param name="Id">Id.</param>
        /// <param name="PreviousConnId">PreviousConnId.</param>
        /// <param name="ParentConnId">ParentConnId.</param>
        /// <param name="PhoneNumber">PhoneNumber.</param>
        /// <param name="ConnId">ConnId.</param>
        /// <param name="CallUuid">CallUuid.</param>
        /// <param name="CallType">CallType.</param>
        /// <param name="State">State.</param>
        /// <param name="Capabilities">Capabilities.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="Dnis">Dnis.</param>
        /// <param name="Ani">Ani.</param>
        /// <param name="RecordingState">RecordingState.</param>
        /// <param name="UserData">A key/value pairs list of a data structure that provides additional information associated with this action..</param>
        /// <param name="Extensions">A key/value pairs list of a data structure that provides additional information associated with this action..</param>
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets PreviousConnId
        /// </summary>
        [DataMember(Name="previousConnId", EmitDefaultValue=false)]
        public string PreviousConnId { get; set; }
        /// <summary>
        /// Gets or Sets ParentConnId
        /// </summary>
        [DataMember(Name="parentConnId", EmitDefaultValue=false)]
        public string ParentConnId { get; set; }
        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Gets or Sets ConnId
        /// </summary>
        [DataMember(Name="connId", EmitDefaultValue=false)]
        public string ConnId { get; set; }
        /// <summary>
        /// Gets or Sets CallUuid
        /// </summary>
        [DataMember(Name="callUuid", EmitDefaultValue=false)]
        public string CallUuid { get; set; }
        /// <summary>
        /// Gets or Sets CallType
        /// </summary>
        [DataMember(Name="callType", EmitDefaultValue=false)]
        public string CallType { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name="capabilities", EmitDefaultValue=false)]
        public List<string> Capabilities { get; set; }
        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<CallParticipants> Participants { get; set; }
        /// <summary>
        /// Gets or Sets Dnis
        /// </summary>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }
        /// <summary>
        /// Gets or Sets Ani
        /// </summary>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }
        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public string RecordingState { get; set; }
        /// <summary>
        /// A key/value pairs list of a data structure that provides additional information associated with this action.
        /// </summary>
        /// <value>A key/value pairs list of a data structure that provides additional information associated with this action.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }
        /// <summary>
        /// A key/value pairs list of a data structure that provides additional information associated with this action.
        /// </summary>
        /// <value>A key/value pairs list of a data structure that provides additional information associated with this action.</value>
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Call);
        }

        /// <summary>
        /// Returns true if Call instances are equal
        /// </summary>
        /// <param name="other">Instance of Call to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Call other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.PreviousConnId == other.PreviousConnId ||
                    this.PreviousConnId != null &&
                    this.PreviousConnId.Equals(other.PreviousConnId)
                ) && 
                (
                    this.ParentConnId == other.ParentConnId ||
                    this.ParentConnId != null &&
                    this.ParentConnId.Equals(other.ParentConnId)
                ) && 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                ) && 
                (
                    this.ConnId == other.ConnId ||
                    this.ConnId != null &&
                    this.ConnId.Equals(other.ConnId)
                ) && 
                (
                    this.CallUuid == other.CallUuid ||
                    this.CallUuid != null &&
                    this.CallUuid.Equals(other.CallUuid)
                ) && 
                (
                    this.CallType == other.CallType ||
                    this.CallType != null &&
                    this.CallType.Equals(other.CallType)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Capabilities == other.Capabilities ||
                    this.Capabilities != null &&
                    this.Capabilities.SequenceEqual(other.Capabilities)
                ) && 
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) && 
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) && 
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) && 
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
                ) && 
                (
                    this.UserData == other.UserData ||
                    this.UserData != null &&
                    this.UserData.SequenceEqual(other.UserData)
                ) && 
                (
                    this.Extensions == other.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(other.Extensions)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.PreviousConnId != null)
                    hash = hash * 59 + this.PreviousConnId.GetHashCode();
                if (this.ParentConnId != null)
                    hash = hash * 59 + this.ParentConnId.GetHashCode();
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                if (this.ConnId != null)
                    hash = hash * 59 + this.ConnId.GetHashCode();
                if (this.CallUuid != null)
                    hash = hash * 59 + this.CallUuid.GetHashCode();
                if (this.CallType != null)
                    hash = hash * 59 + this.CallType.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Capabilities != null)
                    hash = hash * 59 + this.Capabilities.GetHashCode();
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();
                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();
                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();
                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();
                if (this.Extensions != null)
                    hash = hash * 59 + this.Extensions.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
