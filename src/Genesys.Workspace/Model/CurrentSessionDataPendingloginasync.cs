/* 
 * Workspace API
 *
 * Agent API
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
using SwaggerDateConverter = Genesys.Workspace.Client.SwaggerDateConverter;

namespace Genesys.Workspace.Model
{
    /// <summary>
    /// CurrentSessionDataPendingloginasync
    /// </summary>
    [DataContract]
    public partial class CurrentSessionDataPendingloginasync :  IEquatable<CurrentSessionDataPendingloginasync>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum NotStarted for "NotStarted"
            /// </summary>
            [EnumMember(Value = "NotStarted")]
            NotStarted = 1,
            
            /// <summary>
            /// Enum Executing for "Executing"
            /// </summary>
            [EnumMember(Value = "Executing")]
            Executing = 2,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed = 3,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete = 4
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionDataPendingloginasync" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrentSessionDataPendingloginasync() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionDataPendingloginasync" /> class.
        /// </summary>
        /// <param name="State">State (required).</param>
        /// <param name="ActualWaitTime">ActualWaitTime (required).</param>
        /// <param name="SubmittedAt">SubmittedAt (required).</param>
        /// <param name="Errors">Errors.</param>
        public CurrentSessionDataPendingloginasync(StateEnum State = default(StateEnum), int? ActualWaitTime = default(int?), string SubmittedAt = default(string), List<Kvpair> Errors = default(List<Kvpair>))
        {
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for CurrentSessionDataPendingloginasync and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "ActualWaitTime" is required (not null)
            if (ActualWaitTime == null)
            {
                throw new InvalidDataException("ActualWaitTime is a required property for CurrentSessionDataPendingloginasync and cannot be null");
            }
            else
            {
                this.ActualWaitTime = ActualWaitTime;
            }
            // to ensure "SubmittedAt" is required (not null)
            if (SubmittedAt == null)
            {
                throw new InvalidDataException("SubmittedAt is a required property for CurrentSessionDataPendingloginasync and cannot be null");
            }
            else
            {
                this.SubmittedAt = SubmittedAt;
            }
            this.Errors = Errors;
        }
        

        /// <summary>
        /// Gets or Sets ActualWaitTime
        /// </summary>
        [DataMember(Name="actualWaitTime", EmitDefaultValue=false)]
        public int? ActualWaitTime { get; set; }

        /// <summary>
        /// Gets or Sets SubmittedAt
        /// </summary>
        [DataMember(Name="submittedAt", EmitDefaultValue=false)]
        public string SubmittedAt { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<Kvpair> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentSessionDataPendingloginasync {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ActualWaitTime: ").Append(ActualWaitTime).Append("\n");
            sb.Append("  SubmittedAt: ").Append(SubmittedAt).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as CurrentSessionDataPendingloginasync);
        }

        /// <summary>
        /// Returns true if CurrentSessionDataPendingloginasync instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentSessionDataPendingloginasync to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionDataPendingloginasync input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.ActualWaitTime == input.ActualWaitTime ||
                    (this.ActualWaitTime != null &&
                    this.ActualWaitTime.Equals(input.ActualWaitTime))
                ) && 
                (
                    this.SubmittedAt == input.SubmittedAt ||
                    (this.SubmittedAt != null &&
                    this.SubmittedAt.Equals(input.SubmittedAt))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ActualWaitTime != null)
                    hashCode = hashCode * 59 + this.ActualWaitTime.GetHashCode();
                if (this.SubmittedAt != null)
                    hashCode = hashCode * 59 + this.SubmittedAt.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
