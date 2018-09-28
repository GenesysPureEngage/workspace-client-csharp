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
    /// MediachatinteractionsidsendmessageData
    /// </summary>
    [DataContract]
    public partial class MediachatinteractionsidsendmessageData :  IEquatable<MediachatinteractionsidsendmessageData>, IValidatableObject
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
        /// Specifies how the message should be treated.
        /// </summary>
        /// <value>Specifies how the message should be treated.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TreatAsEnum
        {
            
            /// <summary>
            /// Enum Normal for value: Normal
            /// </summary>
            [EnumMember(Value = "Normal")]
            Normal = 1,
            
            /// <summary>
            /// Enum System for value: System
            /// </summary>
            [EnumMember(Value = "System")]
            System = 2
        }

        /// <summary>
        /// Specifies how the message should be treated.
        /// </summary>
        /// <value>Specifies how the message should be treated.</value>
        [DataMember(Name="treatAs", EmitDefaultValue=false)]
        public TreatAsEnum? TreatAs { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidsendmessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediachatinteractionsidsendmessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediachatinteractionsidsendmessageData" /> class.
        /// </summary>
        /// <param name="Message">The message to send to the chat participants. (required).</param>
        /// <param name="MessageType">The type of message..</param>
        /// <param name="Visibility">Defines which participants in the chat can see the message..</param>
        /// <param name="TreatAs">Specifies how the message should be treated..</param>
        public MediachatinteractionsidsendmessageData(string Message = default(string), string MessageType = default(string), VisibilityEnum? Visibility = default(VisibilityEnum?), TreatAsEnum? TreatAs = default(TreatAsEnum?))
        {
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for MediachatinteractionsidsendmessageData and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            this.MessageType = MessageType;
            this.Visibility = Visibility;
            this.TreatAs = TreatAs;
        }
        
        /// <summary>
        /// The message to send to the chat participants.
        /// </summary>
        /// <value>The message to send to the chat participants.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The type of message.
        /// </summary>
        /// <value>The type of message.</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }



        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediachatinteractionsidsendmessageData {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  TreatAs: ").Append(TreatAs).Append("\n");
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
            return this.Equals(input as MediachatinteractionsidsendmessageData);
        }

        /// <summary>
        /// Returns true if MediachatinteractionsidsendmessageData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediachatinteractionsidsendmessageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediachatinteractionsidsendmessageData input)
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
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.Visibility == input.Visibility ||
                    (this.Visibility != null &&
                    this.Visibility.Equals(input.Visibility))
                ) && 
                (
                    this.TreatAs == input.TreatAs ||
                    (this.TreatAs != null &&
                    this.TreatAs.Equals(input.TreatAs))
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
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                if (this.Visibility != null)
                    hashCode = hashCode * 59 + this.Visibility.GetHashCode();
                if (this.TreatAs != null)
                    hashCode = hashCode * 59 + this.TreatAs.GetHashCode();
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
