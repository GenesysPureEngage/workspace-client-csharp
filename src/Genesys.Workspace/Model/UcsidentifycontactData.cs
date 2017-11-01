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
using SwaggerDateConverter = Genesys.Workspace.Client.SwaggerDateConverter;

namespace Genesys.Workspace.Model
{
    /// <summary>
    /// UcsidentifycontactData
    /// </summary>
    [DataContract]
    public partial class UcsidentifycontactData :  IEquatable<UcsidentifycontactData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsidentifycontactData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcsidentifycontactData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsidentifycontactData" /> class.
        /// </summary>
        /// <param name="CreateContactEnabled">Indicates if a contact should be created if no matching contact found.</param>
        /// <param name="MediaType">The media type of the interaction (required).</param>
        /// <param name="PhoneNumber">The phone number of the interaction, if interaction is a voice call.</param>
        /// <param name="EmailAddress">The email address of the interaction, if interaction is an email.</param>
        /// <param name="UserData">A key/value pairs list of the user data of the call. (required).</param>
        public UcsidentifycontactData(bool? CreateContactEnabled = default(bool?), string MediaType = default(string), string PhoneNumber = default(string), string EmailAddress = default(string), List<Kvpair> UserData = default(List<Kvpair>))
        {
            // to ensure "MediaType" is required (not null)
            if (MediaType == null)
            {
                throw new InvalidDataException("MediaType is a required property for UcsidentifycontactData and cannot be null");
            }
            else
            {
                this.MediaType = MediaType;
            }
            // to ensure "UserData" is required (not null)
            if (UserData == null)
            {
                throw new InvalidDataException("UserData is a required property for UcsidentifycontactData and cannot be null");
            }
            else
            {
                this.UserData = UserData;
            }
            this.CreateContactEnabled = CreateContactEnabled;
            this.PhoneNumber = PhoneNumber;
            this.EmailAddress = EmailAddress;
        }
        
        /// <summary>
        /// Indicates if a contact should be created if no matching contact found
        /// </summary>
        /// <value>Indicates if a contact should be created if no matching contact found</value>
        [DataMember(Name="createContactEnabled", EmitDefaultValue=false)]
        public bool? CreateContactEnabled { get; set; }

        /// <summary>
        /// The media type of the interaction
        /// </summary>
        /// <value>The media type of the interaction</value>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// The phone number of the interaction, if interaction is a voice call
        /// </summary>
        /// <value>The phone number of the interaction, if interaction is a voice call</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The email address of the interaction, if interaction is an email
        /// </summary>
        /// <value>The email address of the interaction, if interaction is an email</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// A key/value pairs list of the user data of the call.
        /// </summary>
        /// <value>A key/value pairs list of the user data of the call.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsidentifycontactData {\n");
            sb.Append("  CreateContactEnabled: ").Append(CreateContactEnabled).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
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
            return this.Equals(input as UcsidentifycontactData);
        }

        /// <summary>
        /// Returns true if UcsidentifycontactData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsidentifycontactData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsidentifycontactData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreateContactEnabled == input.CreateContactEnabled ||
                    (this.CreateContactEnabled != null &&
                    this.CreateContactEnabled.Equals(input.CreateContactEnabled))
                ) && 
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
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
                if (this.CreateContactEnabled != null)
                    hashCode = hashCode * 59 + this.CreateContactEnabled.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
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
