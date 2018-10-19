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
    /// UcscontactscreateData
    /// </summary>
    [DataContract]
    public partial class UcscontactscreateData :  IEquatable<UcscontactscreateData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcscontactscreateData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcscontactscreateData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcscontactscreateData" /> class.
        /// </summary>
        /// <param name="Properties">The list of contact attributes to be added to the contact (required).</param>
        public UcscontactscreateData(List<Object> Properties = default(List<Object>))
        {
            // to ensure "Properties" is required (not null)
            if (Properties == null)
            {
                throw new InvalidDataException("Properties is a required property for UcscontactscreateData and cannot be null");
            }
            else
            {
                this.Properties = Properties;
            }
        }
        
        /// <summary>
        /// The list of contact attributes to be added to the contact
        /// </summary>
        /// <value>The list of contact attributes to be added to the contact</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        public List<Object> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcscontactscreateData {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
            return this.Equals(input as UcscontactscreateData);
        }

        /// <summary>
        /// Returns true if UcscontactscreateData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcscontactscreateData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcscontactscreateData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Properties == input.Properties ||
                    this.Properties != null &&
                    this.Properties.SequenceEqual(input.Properties)
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
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
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
