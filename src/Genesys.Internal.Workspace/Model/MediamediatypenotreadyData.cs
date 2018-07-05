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
    /// MediamediatypenotreadyData
    /// </summary>
    [DataContract]
    public partial class MediamediatypenotreadyData :  IEquatable<MediamediatypenotreadyData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypenotreadyData" /> class.
        /// </summary>
        /// <param name="ReasonCode">ReasonCode.</param>
        /// <param name="Reason">A collection of key/value pairs..</param>
        /// <param name="Extension">A collection of key/value pairs..</param>
        public MediamediatypenotreadyData(string ReasonCode = default(string), IxnReasonCode Reason = default(IxnReasonCode), List<Kvpair> Extension = default(List<Kvpair>))
        {
            this.ReasonCode = ReasonCode;
            this.Reason = Reason;
            this.Extension = Extension;
        }
        
        /// <summary>
        /// Gets or Sets ReasonCode
        /// </summary>
        [DataMember(Name="reasonCode", EmitDefaultValue=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// A collection of key/value pairs.
        /// </summary>
        /// <value>A collection of key/value pairs.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public IxnReasonCode Reason { get; set; }

        /// <summary>
        /// A collection of key/value pairs.
        /// </summary>
        /// <value>A collection of key/value pairs.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public List<Kvpair> Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamediatypenotreadyData {\n");
            sb.Append("  ReasonCode: ").Append(ReasonCode).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MediamediatypenotreadyData);
        }

        /// <summary>
        /// Returns true if MediamediatypenotreadyData instances are equal
        /// </summary>
        /// <param name="other">Instance of MediamediatypenotreadyData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypenotreadyData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReasonCode == other.ReasonCode ||
                    this.ReasonCode != null &&
                    this.ReasonCode.Equals(other.ReasonCode)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.SequenceEqual(other.Extension)
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
                if (this.ReasonCode != null)
                    hash = hash * 59 + this.ReasonCode.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
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
