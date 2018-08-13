/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: v9.0.000.20.2204
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
    /// MediachatinteractionsidacceptData
    /// </summary>
    [DataContract]
    public partial class MediachatinteractionsidacceptData :  IEquatable<MediachatinteractionsidacceptData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidacceptData" /> class.
        /// </summary>
        /// <param name="Nickname">The agent&#39;s nickname, as displayed to the chat participants..</param>
        public MediachatinteractionsidacceptData(string Nickname = default(string))
        {
            this.Nickname = Nickname;
        }
        
        /// <summary>
        /// The agent&#39;s nickname, as displayed to the chat participants.
        /// </summary>
        /// <value>The agent&#39;s nickname, as displayed to the chat participants.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediachatinteractionsidacceptData {\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
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
            return this.Equals(input as MediachatinteractionsidacceptData);
        }

        /// <summary>
        /// Returns true if MediachatinteractionsidacceptData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediachatinteractionsidacceptData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediachatinteractionsidacceptData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
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
                if (this.Nickname != null)
                    hashCode = hashCode * 59 + this.Nickname.GetHashCode();
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
