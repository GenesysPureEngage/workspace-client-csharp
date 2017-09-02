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
    /// VoicecallsidsenddtmfData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidsenddtmfData :  IEquatable<VoicecallsidsenddtmfData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidsenddtmfData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsidsenddtmfData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidsenddtmfData" /> class.
        /// </summary>
        /// <param name="DtmfDigits">The digits that should be sent. (required).</param>
        /// <param name="Reasons">A key/value pairs list of a data structure that provides additional information associated with this action..</param>
        /// <param name="Extensions">A key/value pairs list of additional data..</param>
        public VoicecallsidsenddtmfData(string DtmfDigits = default(string), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            // to ensure "DtmfDigits" is required (not null)
            if (DtmfDigits == null)
            {
                throw new InvalidDataException("DtmfDigits is a required property for VoicecallsidsenddtmfData and cannot be null");
            }
            else
            {
                this.DtmfDigits = DtmfDigits;
            }
            this.Reasons = Reasons;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// The digits that should be sent.
        /// </summary>
        /// <value>The digits that should be sent.</value>
        [DataMember(Name="dtmfDigits", EmitDefaultValue=false)]
        public string DtmfDigits { get; set; }

        /// <summary>
        /// A key/value pairs list of a data structure that provides additional information associated with this action.
        /// </summary>
        /// <value>A key/value pairs list of a data structure that provides additional information associated with this action.</value>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public List<Kvpair> Reasons { get; set; }

        /// <summary>
        /// A key/value pairs list of additional data.
        /// </summary>
        /// <value>A key/value pairs list of additional data.</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public List<Kvpair> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicecallsidsenddtmfData {\n");
            sb.Append("  DtmfDigits: ").Append(DtmfDigits).Append("\n");
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
            return this.Equals(obj as VoicecallsidsenddtmfData);
        }

        /// <summary>
        /// Returns true if VoicecallsidsenddtmfData instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicecallsidsenddtmfData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidsenddtmfData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DtmfDigits == other.DtmfDigits ||
                    this.DtmfDigits != null &&
                    this.DtmfDigits.Equals(other.DtmfDigits)
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
                if (this.DtmfDigits != null)
                    hash = hash * 59 + this.DtmfDigits.GetHashCode();
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
