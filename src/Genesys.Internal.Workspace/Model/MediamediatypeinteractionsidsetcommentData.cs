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
    /// MediamediatypeinteractionsidsetcommentData
    /// </summary>
    [DataContract]
    public partial class MediamediatypeinteractionsidsetcommentData :  IEquatable<MediamediatypeinteractionsidsetcommentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidsetcommentData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediamediatypeinteractionsidsetcommentData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidsetcommentData" /> class.
        /// </summary>
        /// <param name="Comment">The comment to add to the interaction. (required).</param>
        public MediamediatypeinteractionsidsetcommentData(string Comment = default(string))
        {
            // to ensure "Comment" is required (not null)
            if (Comment == null)
            {
                throw new InvalidDataException("Comment is a required property for MediamediatypeinteractionsidsetcommentData and cannot be null");
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
            sb.Append("class MediamediatypeinteractionsidsetcommentData {\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MediamediatypeinteractionsidsetcommentData);
        }

        /// <summary>
        /// Returns true if MediamediatypeinteractionsidsetcommentData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamediatypeinteractionsidsetcommentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypeinteractionsidsetcommentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
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