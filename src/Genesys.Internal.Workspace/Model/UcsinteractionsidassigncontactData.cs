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
    /// UcsinteractionsidassigncontactData
    /// </summary>
    [DataContract]
    public partial class UcsinteractionsidassigncontactData :  IEquatable<UcsinteractionsidassigncontactData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsinteractionsidassigncontactData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcsinteractionsidassigncontactData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsinteractionsidassigncontactData" /> class.
        /// </summary>
        /// <param name="ContactId">The id of the contact (required).</param>
        public UcsinteractionsidassigncontactData(string ContactId = default(string))
        {
            // to ensure "ContactId" is required (not null)
            if (ContactId == null)
            {
                throw new InvalidDataException("ContactId is a required property for UcsinteractionsidassigncontactData and cannot be null");
            }
            else
            {
                this.ContactId = ContactId;
            }
        }
        
        /// <summary>
        /// The id of the contact
        /// </summary>
        /// <value>The id of the contact</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsinteractionsidassigncontactData {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
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
            return this.Equals(input as UcsinteractionsidassigncontactData);
        }

        /// <summary>
        /// Returns true if UcsinteractionsidassigncontactData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsinteractionsidassigncontactData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsinteractionsidassigncontactData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
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
