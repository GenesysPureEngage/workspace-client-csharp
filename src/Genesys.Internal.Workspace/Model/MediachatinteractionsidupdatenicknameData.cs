/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.23.2279
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
    /// MediachatinteractionsidupdatenicknameData
    /// </summary>
    [DataContract]
    public partial class MediachatinteractionsidupdatenicknameData :  IEquatable<MediachatinteractionsidupdatenicknameData>, IValidatableObject
    {
        /// <summary>
        /// Defines which participants in the chat can see the message.
        /// </summary>
        /// <value>Defines which participants in the chat can see the message.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VisibilityEnum
        {
            
            /// <summary>
            /// Enum All for value: All
            /// </summary>
            [EnumMember(Value = "All")]
            All = 1,
            
            /// <summary>
            /// Enum Agent for value: Agent
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent = 2,
            
            /// <summary>
            /// Enum Supervisor for value: Supervisor
            /// </summary>
            [EnumMember(Value = "Supervisor")]
            Supervisor = 3
        }

        /// <summary>
        /// Defines which participants in the chat can see the message.
        /// </summary>
        /// <value>Defines which participants in the chat can see the message.</value>
        [DataMember(Name="visibility", EmitDefaultValue=false)]
        public VisibilityEnum? Visibility { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidupdatenicknameData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediachatinteractionsidupdatenicknameData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidupdatenicknameData" /> class.
        /// </summary>
        /// <param name="Nickname">The new nickname. (required).</param>
        /// <param name="Visibility">Defines which participants in the chat can see the message..</param>
        public MediachatinteractionsidupdatenicknameData(string Nickname = default(string), VisibilityEnum? Visibility = default(VisibilityEnum?))
        {
            // to ensure "Nickname" is required (not null)
            if (Nickname == null)
            {
                throw new InvalidDataException("Nickname is a required property for MediachatinteractionsidupdatenicknameData and cannot be null");
            }
            else
            {
                this.Nickname = Nickname;
            }
            this.Visibility = Visibility;
        }
        
        /// <summary>
        /// The new nickname.
        /// </summary>
        /// <value>The new nickname.</value>
        [DataMember(Name="nickname", EmitDefaultValue=false)]
        public string Nickname { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediachatinteractionsidupdatenicknameData {\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
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
            return this.Equals(input as MediachatinteractionsidupdatenicknameData);
        }

        /// <summary>
        /// Returns true if MediachatinteractionsidupdatenicknameData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediachatinteractionsidupdatenicknameData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediachatinteractionsidupdatenicknameData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
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
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
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
