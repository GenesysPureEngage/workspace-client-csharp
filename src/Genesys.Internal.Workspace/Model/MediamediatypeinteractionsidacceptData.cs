/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.22.2269
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
    /// MediamediatypeinteractionsidacceptData
    /// </summary>
    [DataContract]
    public partial class MediamediatypeinteractionsidacceptData :  IEquatable<MediamediatypeinteractionsidacceptData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidacceptData" /> class.
        /// </summary>
        /// <param name="Extension">A collection of key/value pairs..</param>
        public MediamediatypeinteractionsidacceptData(List<Kvpair> Extension = default(List<Kvpair>))
        {
            this.Extension = Extension;
        }
        
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
            sb.Append("class MediamediatypeinteractionsidacceptData {\n");
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
            return this.Equals(input as MediamediatypeinteractionsidacceptData);
        }

        /// <summary>
        /// Returns true if MediamediatypeinteractionsidacceptData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamediatypeinteractionsidacceptData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypeinteractionsidacceptData input)
        {
            if (input == null)
                return false;

            return 
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
