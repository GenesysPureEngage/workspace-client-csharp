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
    /// CurrentUserDataPendingloginasync
    /// </summary>
    [DataContract]
    public partial class CurrentUserDataPendingloginasync :  IEquatable<CurrentUserDataPendingloginasync>, IValidatableObject
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
            NotStarted,
            
            /// <summary>
            /// Enum Executing for "Executing"
            /// </summary>
            [EnumMember(Value = "Executing")]
            Executing,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed,
            
            /// <summary>
            /// Enum Complete for "Complete"
            /// </summary>
            [EnumMember(Value = "Complete")]
            Complete
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserDataPendingloginasync" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrentUserDataPendingloginasync() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserDataPendingloginasync" /> class.
        /// </summary>
        /// <param name="State">State (required).</param>
        /// <param name="ActualWaitTime">ActualWaitTime (required).</param>
        /// <param name="SubmittedAt">SubmittedAt (required).</param>
        /// <param name="Errors">Errors.</param>
        public CurrentUserDataPendingloginasync(StateEnum? State = default(StateEnum?), int? ActualWaitTime = default(int?), string SubmittedAt = default(string), Object Errors = default(Object))
        {
            // to ensure "State" is required (not null)
            if (State == null)
            {
                throw new InvalidDataException("State is a required property for CurrentUserDataPendingloginasync and cannot be null");
            }
            else
            {
                this.State = State;
            }
            // to ensure "ActualWaitTime" is required (not null)
            if (ActualWaitTime == null)
            {
                throw new InvalidDataException("ActualWaitTime is a required property for CurrentUserDataPendingloginasync and cannot be null");
            }
            else
            {
                this.ActualWaitTime = ActualWaitTime;
            }
            // to ensure "SubmittedAt" is required (not null)
            if (SubmittedAt == null)
            {
                throw new InvalidDataException("SubmittedAt is a required property for CurrentUserDataPendingloginasync and cannot be null");
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
        public Object Errors { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentUserDataPendingloginasync {\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CurrentUserDataPendingloginasync);
        }

        /// <summary>
        /// Returns true if CurrentUserDataPendingloginasync instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrentUserDataPendingloginasync to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentUserDataPendingloginasync other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.ActualWaitTime == other.ActualWaitTime ||
                    this.ActualWaitTime != null &&
                    this.ActualWaitTime.Equals(other.ActualWaitTime)
                ) && 
                (
                    this.SubmittedAt == other.SubmittedAt ||
                    this.SubmittedAt != null &&
                    this.SubmittedAt.Equals(other.SubmittedAt)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.Equals(other.Errors)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ActualWaitTime != null)
                    hash = hash * 59 + this.ActualWaitTime.GetHashCode();
                if (this.SubmittedAt != null)
                    hash = hash * 59 + this.SubmittedAt.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
