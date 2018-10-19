/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.24.2335
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
    /// WorkbinsworkbinIdaddinteractionData
    /// </summary>
    [DataContract]
    public partial class WorkbinsworkbinIdaddinteractionData :  IEquatable<WorkbinsworkbinIdaddinteractionData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinsworkbinIdaddinteractionData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkbinsworkbinIdaddinteractionData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinsworkbinIdaddinteractionData" /> class.
        /// </summary>
        /// <param name="OwnerId">Id of the owner of the workbin.</param>
        /// <param name="InteractionId">Id of the interaction (required).</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Extension">A key/value pairs list of additional data..</param>
        public WorkbinsworkbinIdaddinteractionData(string OwnerId = default(string), string InteractionId = default(string), IxnReasonCode Reason = default(IxnReasonCode), List<Kvpair> Extension = default(List<Kvpair>))
        {
            // to ensure "InteractionId" is required (not null)
            if (InteractionId == null)
            {
                throw new InvalidDataException("InteractionId is a required property for WorkbinsworkbinIdaddinteractionData and cannot be null");
            }
            else
            {
                this.InteractionId = InteractionId;
            }
            this.OwnerId = OwnerId;
            this.Reason = Reason;
            this.Extension = Extension;
        }
        
        /// <summary>
        /// Id of the owner of the workbin
        /// </summary>
        /// <value>Id of the owner of the workbin</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Id of the interaction
        /// </summary>
        /// <value>Id of the interaction</value>
        [DataMember(Name="interactionId", EmitDefaultValue=false)]
        public string InteractionId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public IxnReasonCode Reason { get; set; }

        /// <summary>
        /// A key/value pairs list of additional data.
        /// </summary>
        /// <value>A key/value pairs list of additional data.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public List<Kvpair> Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkbinsworkbinIdaddinteractionData {\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  InteractionId: ").Append(InteractionId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as WorkbinsworkbinIdaddinteractionData);
        }

        /// <summary>
        /// Returns true if WorkbinsworkbinIdaddinteractionData instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkbinsworkbinIdaddinteractionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkbinsworkbinIdaddinteractionData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.InteractionId == input.InteractionId ||
                    (this.InteractionId != null &&
                    this.InteractionId.Equals(input.InteractionId))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Extension == input.Extension ||
                    this.Extension != null &&
                    this.Extension.SequenceEqual(input.Extension)
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
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.InteractionId != null)
                    hashCode = hashCode * 59 + this.InteractionId.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
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
