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
    /// MediamediatypeinteractionsidaddcontentData
    /// </summary>
    [DataContract]
    public partial class MediamediatypeinteractionsidaddcontentData :  IEquatable<MediamediatypeinteractionsidaddcontentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidaddcontentData" /> class.
        /// </summary>
        /// <param name="Comment">The comment to be set.</param>
        /// <param name="ThreadId">ThreadId.</param>
        /// <param name="ParentId">UCS id of parent interaction.</param>
        /// <param name="ContactId">id of contact.</param>
        public MediamediatypeinteractionsidaddcontentData(string Comment = default(string), string ThreadId = default(string), string ParentId = default(string), string ContactId = default(string))
        {
            this.Comment = Comment;
            this.ThreadId = ThreadId;
            this.ParentId = ParentId;
            this.ContactId = ContactId;
        }
        
        /// <summary>
        /// The comment to be set
        /// </summary>
        /// <value>The comment to be set</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// ThreadId
        /// </summary>
        /// <value>ThreadId</value>
        [DataMember(Name="threadId", EmitDefaultValue=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// UCS id of parent interaction
        /// </summary>
        /// <value>UCS id of parent interaction</value>
        [DataMember(Name="parentId", EmitDefaultValue=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// id of contact
        /// </summary>
        /// <value>id of contact</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamediatypeinteractionsidaddcontentData {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
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
            return this.Equals(input as MediamediatypeinteractionsidaddcontentData);
        }

        /// <summary>
        /// Returns true if MediamediatypeinteractionsidaddcontentData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamediatypeinteractionsidaddcontentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypeinteractionsidaddcontentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    (this.ThreadId != null &&
                    this.ThreadId.Equals(input.ThreadId))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
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
                if (this.ThreadId != null)
                    hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
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
