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
    /// MediachatinteractionsidsendtypingstoppedData
    /// </summary>
    [DataContract]
    public partial class MediachatinteractionsidsendtypingstoppedData :  IEquatable<MediachatinteractionsidsendtypingstoppedData>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="MediachatinteractionsidsendtypingstoppedData" /> class.
        /// </summary>
        /// <param name="Message">The message to send to the chat participants. For example, \&quot;Agent stopped typing\&quot;..</param>
        /// <param name="Visibility">Defines which participants in the chat can see the message..</param>
        public MediachatinteractionsidsendtypingstoppedData(string Message = default(string), VisibilityEnum? Visibility = default(VisibilityEnum?))
        {
            this.Message = Message;
            this.Visibility = Visibility;
        }
        
        /// <summary>
        /// The message to send to the chat participants. For example, \&quot;Agent stopped typing\&quot;.
        /// </summary>
        /// <value>The message to send to the chat participants. For example, \&quot;Agent stopped typing\&quot;.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediachatinteractionsidsendtypingstoppedData {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as MediachatinteractionsidsendtypingstoppedData);
        }

        /// <summary>
        /// Returns true if MediachatinteractionsidsendtypingstoppedData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediachatinteractionsidsendtypingstoppedData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediachatinteractionsidsendtypingstoppedData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
