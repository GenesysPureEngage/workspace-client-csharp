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
    /// MediaemailinteractionsidsaveData
    /// </summary>
    [DataContract]
    public partial class MediaemailinteractionsidsaveData :  IEquatable<MediaemailinteractionsidsaveData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaemailinteractionsidsaveData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediaemailinteractionsidsaveData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaemailinteractionsidsaveData" /> class.
        /// </summary>
        /// <param name="Body">HTML body of email..</param>
        /// <param name="BodyAsPlaintText">Plain text body of email..</param>
        /// <param name="Mime">Multipurpose internet mail extensions of email..</param>
        /// <param name="Subject">Subject of email..</param>
        /// <param name="Comment">Subject of email..</param>
        /// <param name="From">from address. (required).</param>
        /// <param name="To">to addresses (required).</param>
        /// <param name="Cc">cc addresses.</param>
        /// <param name="Bcc">bcc addresses.</param>
        public MediaemailinteractionsidsaveData(string Body = default(string), string BodyAsPlaintText = default(string), string Mime = default(string), string Subject = default(string), string Comment = default(string), string From = default(string), List<string> To = default(List<string>), List<string> Cc = default(List<string>), List<string> Bcc = default(List<string>))
        {
            // to ensure "From" is required (not null)
            if (From == null)
            {
                throw new InvalidDataException("From is a required property for MediaemailinteractionsidsaveData and cannot be null");
            }
            else
            {
                this.From = From;
            }
            // to ensure "To" is required (not null)
            if (To == null)
            {
                throw new InvalidDataException("To is a required property for MediaemailinteractionsidsaveData and cannot be null");
            }
            else
            {
                this.To = To;
            }
            this.Body = Body;
            this.BodyAsPlaintText = BodyAsPlaintText;
            this.Mime = Mime;
            this.Subject = Subject;
            this.Comment = Comment;
            this.Cc = Cc;
            this.Bcc = Bcc;
        }
        
        /// <summary>
        /// HTML body of email.
        /// </summary>
        /// <value>HTML body of email.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Plain text body of email.
        /// </summary>
        /// <value>Plain text body of email.</value>
        [DataMember(Name="bodyAsPlaintText", EmitDefaultValue=false)]
        public string BodyAsPlaintText { get; set; }

        /// <summary>
        /// Multipurpose internet mail extensions of email.
        /// </summary>
        /// <value>Multipurpose internet mail extensions of email.</value>
        [DataMember(Name="mime", EmitDefaultValue=false)]
        public string Mime { get; set; }

        /// <summary>
        /// Subject of email.
        /// </summary>
        /// <value>Subject of email.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Subject of email.
        /// </summary>
        /// <value>Subject of email.</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// from address.
        /// </summary>
        /// <value>from address.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public string From { get; set; }

        /// <summary>
        /// to addresses
        /// </summary>
        /// <value>to addresses</value>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaemailinteractionsidsaveData {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyAsPlaintText: ").Append(BodyAsPlaintText).Append("\n");
            sb.Append("  Mime: ").Append(Mime).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
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
            return this.Equals(input as MediaemailinteractionsidsaveData);
        }

        /// <summary>
        /// Returns true if MediaemailinteractionsidsaveData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediaemailinteractionsidsaveData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaemailinteractionsidsaveData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BodyAsPlaintText == input.BodyAsPlaintText ||
                    (this.BodyAsPlaintText != null &&
                    this.BodyAsPlaintText.Equals(input.BodyAsPlaintText))
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
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
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
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.BodyAsPlaintText != null)
                    hashCode = hashCode * 59 + this.BodyAsPlaintText.GetHashCode();
                if (this.Mime != null)
                    hashCode = hashCode * 59 + this.Mime.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
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