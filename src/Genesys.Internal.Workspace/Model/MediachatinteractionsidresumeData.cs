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
    /// MediachatinteractionsidresumeData
    /// </summary>
    [DataContract]
    public partial class MediachatinteractionsidresumeData :  IEquatable<MediachatinteractionsidresumeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidresumeData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediachatinteractionsidresumeData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidresumeData" /> class.
        /// </summary>
        /// <param name="Nickname">The nickname. (required).</param>
        public MediachatinteractionsidresumeData(string Nickname = default(string))
        {
            // to ensure "Nickname" is required (not null)
            if (Nickname == null)
            {
                throw new InvalidDataException("Nickname is a required property for MediachatinteractionsidresumeData and cannot be null");
            }
            else
            {
                this.Nickname = Nickname;
            }
        }
        
        /// <summary>
        /// The nickname.
        /// </summary>
        /// <value>The nickname.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediachatinteractionsidresumeData {\n");
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
            return this.Equals(input as MediachatinteractionsidresumeData);
        }

        /// <summary>
        /// Returns true if MediachatinteractionsidresumeData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediachatinteractionsidresumeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediachatinteractionsidresumeData input)
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
