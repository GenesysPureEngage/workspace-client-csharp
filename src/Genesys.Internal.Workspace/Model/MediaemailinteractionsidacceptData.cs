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
    /// MediaemailinteractionsidacceptData
    /// </summary>
    [DataContract]
    public partial class MediaemailinteractionsidacceptData :  IEquatable<MediaemailinteractionsidacceptData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaemailinteractionsidacceptData" /> class.
        /// </summary>
        /// <param name="UseReviewer">Indicate the agent is reviewer..</param>
        /// <param name="Extension">A key/value pairs list of additional data..</param>
        public MediaemailinteractionsidacceptData(bool? UseReviewer = default(bool?), List<Kvpair> Extension = default(List<Kvpair>))
        {
            this.UseReviewer = UseReviewer;
            this.Extension = Extension;
        }
        
        /// <summary>
        /// Indicate the agent is reviewer.
        /// </summary>
        /// <value>Indicate the agent is reviewer.</value>
        [DataMember(Name="useReviewer", EmitDefaultValue=false)]
        public bool? UseReviewer { get; set; }

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
            sb.Append("class MediaemailinteractionsidacceptData {\n");
            sb.Append("  UseReviewer: ").Append(UseReviewer).Append("\n");
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
            return this.Equals(input as MediaemailinteractionsidacceptData);
        }

        /// <summary>
        /// Returns true if MediaemailinteractionsidacceptData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaemailinteractionsidacceptData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaemailinteractionsidacceptData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UseReviewer == input.UseReviewer ||
                    (this.UseReviewer != null &&
                    this.UseReviewer.Equals(input.UseReviewer))
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
                if (this.UseReviewer != null)
                    hashCode = hashCode * 59 + this.UseReviewer.GetHashCode();
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
