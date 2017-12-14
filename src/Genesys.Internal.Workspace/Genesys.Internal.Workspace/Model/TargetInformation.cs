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
    /// TargetInformation
    /// </summary>
    [DataContract]
    public partial class TargetInformation :  IEquatable<TargetInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetInformation" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Id">Id.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="EmailAddresses">EmailAddresses.</param>
        /// <param name="Numbers">Numbers.</param>
        public TargetInformation(string Type = default(string), string Id = default(string), string FirstName = default(string), string LastName = default(string), List<string> EmailAddresses = default(List<string>), List<string> Numbers = default(List<string>))
        {
            this.Type = Type;
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddresses = EmailAddresses;
            this.Numbers = Numbers;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name="emailAddresses", EmitDefaultValue=false)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets Numbers
        /// </summary>
        [DataMember(Name="numbers", EmitDefaultValue=false)]
        public List<string> Numbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetInformation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  Numbers: ").Append(Numbers).Append("\n");
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
            return this.Equals(input as TargetInformation);
        }

        /// <summary>
        /// Returns true if TargetInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetInformation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.Numbers == input.Numbers ||
                    this.Numbers != null &&
                    this.Numbers.SequenceEqual(input.Numbers)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailAddresses != null)
                    hashCode = hashCode * 59 + this.EmailAddresses.GetHashCode();
                if (this.Numbers != null)
                    hashCode = hashCode * 59 + this.Numbers.GetHashCode();
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
