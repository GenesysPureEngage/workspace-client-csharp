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
using SwaggerDateConverter = Genesys.Internal.Workspace.Client.SwaggerDateConverter;

namespace Genesys.Internal.Workspace.Model
{
    /// <summary>
    /// VoicecallsidalternateData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidalternateData :  IEquatable<VoicecallsidalternateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidalternateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsidalternateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidalternateData" /> class.
        /// </summary>
        /// <param name="HeldConnId">The connection ID of the held call that should be retrieved. (required).</param>
        /// <param name="Reasons">Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons)..</param>
        /// <param name="Extensions">Media device/hardware reason codes and similar information. For details about extensions, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions)..</param>
        public VoicecallsidalternateData(string HeldConnId = default(string), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            // to ensure "HeldConnId" is required (not null)
            if (HeldConnId == null)
            {
                throw new InvalidDataException("HeldConnId is a required property for VoicecallsidalternateData and cannot be null");
            }
            else
            {
                this.HeldConnId = HeldConnId;
            }
            this.Reasons = Reasons;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// The connection ID of the held call that should be retrieved.
        /// </summary>
        /// <value>The connection ID of the held call that should be retrieved.</value>
        [DataMember(Name="heldConnId", EmitDefaultValue=false)]
        public string HeldConnId { get; set; }

        /// <summary>
        /// Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons).
        /// </summary>
        /// <value>Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons).</value>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public List<Kvpair> Reasons { get; set; }

        /// <summary>
        /// Media device/hardware reason codes and similar information. For details about extensions, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions).
        /// </summary>
        /// <value>Media device/hardware reason codes and similar information. For details about extensions, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions).</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public List<Kvpair> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicecallsidalternateData {\n");
            sb.Append("  HeldConnId: ").Append(HeldConnId).Append("\n");
            sb.Append("  Reasons: ").Append(Reasons).Append("\n");
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
            return this.Equals(input as VoicecallsidalternateData);
        }

        /// <summary>
        /// Returns true if VoicecallsidalternateData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicecallsidalternateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidalternateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeldConnId == input.HeldConnId ||
                    (this.HeldConnId != null &&
                    this.HeldConnId.Equals(input.HeldConnId))
                ) && 
                (
                    this.Reasons == input.Reasons ||
                    this.Reasons != null &&
                    this.Reasons.SequenceEqual(input.Reasons)
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
                if (this.HeldConnId != null)
                    hashCode = hashCode * 59 + this.HeldConnId.GetHashCode();
                if (this.Reasons != null)
                    hashCode = hashCode * 59 + this.Reasons.GetHashCode();
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
