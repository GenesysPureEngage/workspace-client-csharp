/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.24.2335
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
    /// UcscontactsidupdateData
    /// </summary>
    [DataContract]
    public partial class UcscontactsidupdateData :  IEquatable<UcscontactsidupdateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcscontactsidupdateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcscontactsidupdateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcscontactsidupdateData" /> class.
        /// </summary>
        /// <param name="ContactId">The id of the contact.</param>
        /// <param name="AddedProperties">The list of contact attributes to be added to the contact (required).</param>
        /// <param name="ChangedProperties">The list of contact attributes to be updated for the contact (required).</param>
        /// <param name="DeletedProperties">The list of contact attributes to be deleted for the contact (required).</param>
        public UcscontactsidupdateData(string ContactId = default(string), List<Object> AddedProperties = default(List<Object>), List<Object> ChangedProperties = default(List<Object>), List<string> DeletedProperties = default(List<string>))
        {
            // to ensure "AddedProperties" is required (not null)
            if (AddedProperties == null)
            {
                throw new InvalidDataException("AddedProperties is a required property for UcscontactsidupdateData and cannot be null");
            }
            else
            {
                this.AddedProperties = AddedProperties;
            }
            // to ensure "ChangedProperties" is required (not null)
            if (ChangedProperties == null)
            {
                throw new InvalidDataException("ChangedProperties is a required property for UcscontactsidupdateData and cannot be null");
            }
            else
            {
                this.ChangedProperties = ChangedProperties;
            }
            // to ensure "DeletedProperties" is required (not null)
            if (DeletedProperties == null)
            {
                throw new InvalidDataException("DeletedProperties is a required property for UcscontactsidupdateData and cannot be null");
            }
            else
            {
                this.DeletedProperties = DeletedProperties;
            }
            this.ContactId = ContactId;
        }
        
        /// <summary>
        /// The id of the contact
        /// </summary>
        /// <value>The id of the contact</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public string ContactId { get; set; }

        /// <summary>
        /// The list of contact attributes to be added to the contact
        /// </summary>
        /// <value>The list of contact attributes to be added to the contact</value>
        [DataMember(Name="addedProperties", EmitDefaultValue=false)]
        public List<Object> AddedProperties { get; set; }

        /// <summary>
        /// The list of contact attributes to be updated for the contact
        /// </summary>
        /// <value>The list of contact attributes to be updated for the contact</value>
        [DataMember(Name="changedProperties", EmitDefaultValue=false)]
        public List<Object> ChangedProperties { get; set; }

        /// <summary>
        /// The list of contact attributes to be deleted for the contact
        /// </summary>
        /// <value>The list of contact attributes to be deleted for the contact</value>
        [DataMember(Name="deletedProperties", EmitDefaultValue=false)]
        public List<string> DeletedProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcscontactsidupdateData {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  AddedProperties: ").Append(AddedProperties).Append("\n");
            sb.Append("  ChangedProperties: ").Append(ChangedProperties).Append("\n");
            sb.Append("  DeletedProperties: ").Append(DeletedProperties).Append("\n");
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
            return this.Equals(input as UcscontactsidupdateData);
        }

        /// <summary>
        /// Returns true if UcscontactsidupdateData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcscontactsidupdateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcscontactsidupdateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.AddedProperties == input.AddedProperties ||
                    this.AddedProperties != null &&
                    this.AddedProperties.SequenceEqual(input.AddedProperties)
                ) && 
                (
                    this.ChangedProperties == input.ChangedProperties ||
                    this.ChangedProperties != null &&
                    this.ChangedProperties.SequenceEqual(input.ChangedProperties)
                ) && 
                (
                    this.DeletedProperties == input.DeletedProperties ||
                    this.DeletedProperties != null &&
                    this.DeletedProperties.SequenceEqual(input.DeletedProperties)
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
                if (this.AddedProperties != null)
                    hashCode = hashCode * 59 + this.AddedProperties.GetHashCode();
                if (this.ChangedProperties != null)
                    hashCode = hashCode * 59 + this.ChangedProperties.GetHashCode();
                if (this.DeletedProperties != null)
                    hashCode = hashCode * 59 + this.DeletedProperties.GetHashCode();
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
