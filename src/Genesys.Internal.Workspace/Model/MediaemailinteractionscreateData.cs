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
    /// MediaemailinteractionscreateData
    /// </summary>
    [DataContract]
    public partial class MediaemailinteractionscreateData :  IEquatable<MediaemailinteractionscreateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaemailinteractionscreateData" /> class.
        /// </summary>
        /// <param name="Queue">the name of the queue to submit the new email.</param>
        /// <param name="ThreadId">specify the ThreadId of UCS interaction.</param>
        /// <param name="ContactId">id of the contact.</param>
        /// <param name="To">the address mail of to.</param>
        /// <param name="Body">The message to send. Html body.</param>
        /// <param name="BodyAsPlainText">The message to send. Plain text body.</param>
        /// <param name="Mime">Multipurpose internet mail extensions of email.</param>
        /// <param name="Subject">The subject value.</param>
        /// <param name="UserData">A key/value pairs list of user data..</param>
        public MediaemailinteractionscreateData(string Queue = default(string), string ThreadId = default(string), string ContactId = default(string), string To = default(string), string Body = default(string), string BodyAsPlainText = default(string), string Mime = default(string), string Subject = default(string), List<Kvpair> UserData = default(List<Kvpair>))
        {
            this.Queue = Queue;
            this.ThreadId = ThreadId;
            this.ContactId = ContactId;
            this.To = To;
            this.Body = Body;
            this.BodyAsPlainText = BodyAsPlainText;
            this.Mime = Mime;
            this.Subject = Subject;
            this.UserData = UserData;
        }
        
        /// <summary>
        /// the name of the queue to submit the new email
        /// </summary>
        /// <value>the name of the queue to submit the new email</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public string Queue { get; set; }

        /// <summary>
        /// specify the ThreadId of UCS interaction
        /// </summary>
        /// <value>specify the ThreadId of UCS interaction</value>
        [DataMember(Name="threadId", EmitDefaultValue=false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// id of the contact
        /// </summary>
        /// <value>id of the contact</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// the address mail of to
        /// </summary>
        /// <value>the address mail of to</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// The message to send. Html body
        /// </summary>
        /// <value>The message to send. Html body</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// The message to send. Plain text body
        /// </summary>
        /// <value>The message to send. Plain text body</value>
        [DataMember(Name="bodyAsPlainText", EmitDefaultValue=false)]
        public string BodyAsPlainText { get; set; }

        /// <summary>
        /// Multipurpose internet mail extensions of email
        /// </summary>
        /// <value>Multipurpose internet mail extensions of email</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }

        /// <summary>
        /// The subject value
        /// </summary>
        /// <value>The subject value</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// A key/value pairs list of user data.
        /// </summary>
        /// <value>A key/value pairs list of user data.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaemailinteractionscreateData {\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyAsPlainText: ").Append(BodyAsPlainText).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
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
            return this.Equals(input as MediaemailinteractionscreateData);
        }

        /// <summary>
        /// Returns true if MediaemailinteractionscreateData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaemailinteractionscreateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaemailinteractionscreateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Queue == input.Queue ||
                    (this.Queue != null &&
                    this.Queue.Equals(input.Queue))
                ) && 
                (
                    this.ThreadId == input.ThreadId ||
                    (this.ThreadId != null &&
                    this.ThreadId.Equals(input.ThreadId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BodyAsPlainText == input.BodyAsPlainText ||
                    (this.BodyAsPlainText != null &&
                    this.BodyAsPlainText.Equals(input.BodyAsPlainText))
                ) && 
                (
                    this.Mime == input.Mime ||
                    (this.Mime != null &&
                    this.Mime.Equals(input.Mime))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.UserData == input.UserData ||
                    this.UserData != null &&
                    this.UserData.SequenceEqual(input.UserData)
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
                if (this.Queue != null)
                    hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.ThreadId != null)
                    hashCode = hashCode * 59 + this.ThreadId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.BodyAsPlainText != null)
                    hashCode = hashCode * 59 + this.BodyAsPlainText.GetHashCode();
                if (this.Mime != null)
                    hashCode = hashCode * 59 + this.Mime.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
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
