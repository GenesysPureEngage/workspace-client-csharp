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
    /// VoicecallsidcompletetransferData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidcompletetransferData :  IEquatable<VoicecallsidcompletetransferData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidcompletetransferData" /> class.
        /// </summary>
        /// <param name="ParentConnId">The connId of the parent call can optionally be specified. In most cases this is not required..</param>
        /// <param name="Reasons">A key/value pairs list of a data structure that provides additional information associated with this action..</param>
        /// <param name="Extensions">A key/value pairs list of additional data..</param>
        public VoicecallsidcompletetransferData(string ParentConnId = default(string), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            this.ParentConnId = ParentConnId;
            this.Reasons = Reasons;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// The connId of the parent call can optionally be specified. In most cases this is not required.
        /// </summary>
        /// <value>The connId of the parent call can optionally be specified. In most cases this is not required.</value>
        [DataMember(Name="parentConnId", EmitDefaultValue=false)]
        public string ParentConnId { get; set; }

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
            sb.Append("class VoicecallsidcompletetransferData {\n");
            sb.Append("  ParentConnId: ").Append(ParentConnId).Append("\n");
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
            return this.Equals(obj as VoicecallsidcompletetransferData);
        }

        /// <summary>
        /// Returns true if VoicecallsidcompletetransferData instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicecallsidcompletetransferData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidcompletetransferData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ParentConnId == other.ParentConnId ||
                    this.ParentConnId != null &&
                    this.ParentConnId.Equals(other.ParentConnId)
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
                if (this.ParentConnId != null)
                    hash = hash * 59 + this.ParentConnId.GetHashCode();
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
