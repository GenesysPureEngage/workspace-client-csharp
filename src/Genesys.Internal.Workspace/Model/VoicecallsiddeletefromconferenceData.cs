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
    /// VoicecallsiddeletefromconferenceData
    /// </summary>
    [DataContract]
    public partial class VoicecallsiddeletefromconferenceData :  IEquatable<VoicecallsiddeletefromconferenceData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsiddeletefromconferenceData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsiddeletefromconferenceData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsiddeletefromconferenceData" /> class.
        /// </summary>
        /// <param name="DnToDrop">The DN of the party to drop from the conference. (required).</param>
        /// <param name="Reasons">Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons)..</param>
        /// <param name="Extensions">Media device/hardware reason codes and similar information. For details about extensions, refer to the [Genesys Events and Models Reference Manual](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions)..</param>
        public VoicecallsiddeletefromconferenceData(string DnToDrop = default(string), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            // to ensure "DnToDrop" is required (not null)
            if (DnToDrop == null)
            {
                throw new InvalidDataException("DnToDrop is a required property for VoicecallsiddeletefromconferenceData and cannot be null");
            }
            else
            {
                this.DnToDrop = DnToDrop;
            }
            this.Reasons = Reasons;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// The DN of the party to drop from the conference.
        /// </summary>
        /// <value>The DN of the party to drop from the conference.</value>
        [DataMember(Name="dnToDrop", EmitDefaultValue=false)]
        public string DnToDrop { get; set; }

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
            sb.Append("class VoicecallsiddeletefromconferenceData {\n");
            sb.Append("  DnToDrop: ").Append(DnToDrop).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VoicecallsiddeletefromconferenceData);
        }

        /// <summary>
        /// Returns true if VoicecallsiddeletefromconferenceData instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicecallsiddeletefromconferenceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsiddeletefromconferenceData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DnToDrop == other.DnToDrop ||
                    this.DnToDrop != null &&
                    this.DnToDrop.Equals(other.DnToDrop)
                ) && 
                (
                    this.Reasons == other.Reasons ||
                    this.Reasons != null &&
                    this.Reasons.SequenceEqual(other.Reasons)
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
                if (this.DnToDrop != null)
                    hash = hash * 59 + this.DnToDrop.GetHashCode();
                if (this.Reasons != null)
                    hash = hash * 59 + this.Reasons.GetHashCode();
                if (this.Extensions != null)
                    hash = hash * 59 + this.Extensions.GetHashCode();
                return hash;
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
