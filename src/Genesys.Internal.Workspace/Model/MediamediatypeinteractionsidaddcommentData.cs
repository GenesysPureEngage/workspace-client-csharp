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
    /// MediamediatypeinteractionsidaddcommentData
    /// </summary>
    [DataContract]
    public partial class MediamediatypeinteractionsidaddcommentData :  IEquatable<MediamediatypeinteractionsidaddcommentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidaddcommentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediamediatypeinteractionsidaddcommentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidaddcommentData" /> class.
        /// </summary>
        /// <param name="Comment">The comment to add to the interaction. (required).</param>
        public MediamediatypeinteractionsidaddcommentData(string Comment = default(string))
        {
            // to ensure "Comment" is required (not null)
            if (Comment == null)
            {
                throw new InvalidDataException("Comment is a required property for MediamediatypeinteractionsidaddcommentData and cannot be null");
            }
            else
            {
                this.Comment = Comment;
            }
        }
        
        /// <summary>
        /// The comment to add to the interaction.
        /// </summary>
        /// <value>The comment to add to the interaction.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamediatypeinteractionsidaddcommentData {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
            return this.Equals(obj as MediamediatypeinteractionsidaddcommentData);
        }

        /// <summary>
        /// Returns true if MediamediatypeinteractionsidaddcommentData instances are equal
        /// </summary>
        /// <param name="other">Instance of MediamediatypeinteractionsidaddcommentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypeinteractionsidaddcommentData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
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
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
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
