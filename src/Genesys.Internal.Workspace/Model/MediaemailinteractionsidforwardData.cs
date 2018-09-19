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
    /// MediaemailinteractionsidforwardData
    /// </summary>
    [DataContract]
    public partial class MediaemailinteractionsidforwardData :  IEquatable<MediaemailinteractionsidforwardData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaemailinteractionsidforwardData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaemailinteractionsidforwardData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaemailinteractionsidforwardData" /> class.
        /// </summary>
        /// <param name="Queue">the name of the queue to submit the forward email (required).</param>
        /// <param name="From">the address mail of from. (required).</param>
        /// <param name="To">The addresses mail of to..</param>
        /// <param name="Cc">cc addresses.</param>
        /// <param name="Bcc">bcc addresses.</param>
        /// <param name="Body">The message to send. Html body.</param>
        /// <param name="BodyAsPlainText">The message to send. Plain text body.</param>
        /// <param name="Mime">Multipurpose internet mail extensions of email.</param>
        /// <param name="Subject">The subject value.</param>
        /// <param name="UserData">A key/value pairs list of user data..</param>
        public MediaemailinteractionsidforwardData(string Queue = default(string), string From = default(string), List<string> To = default(List<string>), List<string> Cc = default(List<string>), List<string> Bcc = default(List<string>), string Body = default(string), string BodyAsPlainText = default(string), string Mime = default(string), string Subject = default(string), List<Kvpair> UserData = default(List<Kvpair>))
        {
            // to ensure "Queue" is required (not null)
            if (Queue == null)
            {
                throw new InvalidDataException("Queue is a required property for MediaemailinteractionsidforwardData and cannot be null");
            }
            else
            {
                this.Queue = Queue;
            }
            // to ensure "From" is required (not null)
            if (From == null)
            {
                throw new InvalidDataException("From is a required property for MediaemailinteractionsidforwardData and cannot be null");
            }
            else
            {
                this.From = From;
            }
            this.To = To;
            this.Cc = Cc;
            this.Bcc = Bcc;
            this.Body = Body;
            this.BodyAsPlainText = BodyAsPlainText;
            this.Mime = Mime;
            this.Subject = Subject;
            this.UserData = UserData;
        }
        
        /// <summary>
        /// the name of the queue to submit the forward email
        /// </summary>
        /// <value>the name of the queue to submit the forward email</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public string Queue { get; set; }

        /// <summary>
        /// the address mail of from.
        /// </summary>
        /// <value>the address mail of from.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// The addresses mail of to.
        /// </summary>
        /// <value>The addresses mail of to.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public List<string> To { get; set; }

        /// <summary>
        /// cc addresses
        /// </summary>
        /// <value>cc addresses</value>
        [DataMember(Name="cc", EmitDefaultValue=false)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// bcc addresses
        /// </summary>
        /// <value>bcc addresses</value>
        [DataMember(Name="bcc", EmitDefaultValue=false)]
        public List<string> Bcc { get; set; }

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
            sb.Append("class MediaemailinteractionsidforwardData {\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
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
            return this.Equals(input as MediaemailinteractionsidforwardData);
        }

        /// <summary>
        /// Returns true if MediaemailinteractionsidforwardData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaemailinteractionsidforwardData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaemailinteractionsidforwardData input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
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
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
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
