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
    /// VoicecallsidmergeData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidmergeData :  IEquatable<VoicecallsidmergeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidmergeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsidmergeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidmergeData" /> class.
        /// </summary>
        /// <param name="OtherConnId">The connection ID of the second call to be merged. (required).</param>
        /// <param name="Reasons">Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons)..</param>
        /// <param name="Extensions">Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions)..</param>
        public VoicecallsidmergeData(string OtherConnId = default(string), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            // to ensure "OtherConnId" is required (not null)
            if (OtherConnId == null)
            {
                throw new InvalidDataException("OtherConnId is a required property for VoicecallsidmergeData and cannot be null");
            }
            else
            {
                this.OtherConnId = OtherConnId;
            }
            this.Reasons = Reasons;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// The connection ID of the second call to be merged.
        /// </summary>
        /// <value>The connection ID of the second call to be merged.</value>
        [DataMember(Name="otherConnId", EmitDefaultValue=false)]
        public string OtherConnId { get; set; }

        /// <summary>
        /// Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons).
        /// </summary>
        /// <value>Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons).</value>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public List<Kvpair> Reasons { get; set; }

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
            sb.Append("class VoicecallsidmergeData {\n");
            sb.Append("  OtherConnId: ").Append(OtherConnId).Append("\n");
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
            return this.Equals(input as VoicecallsidmergeData);
        }

        /// <summary>
        /// Returns true if VoicecallsidmergeData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicecallsidmergeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidmergeData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OtherConnId == input.OtherConnId ||
                    (this.OtherConnId != null &&
                    this.OtherConnId.Equals(input.OtherConnId))
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
                if (this.OtherConnId != null)
                    hashCode = hashCode * 59 + this.OtherConnId.GetHashCode();
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
