/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: v9.0.000.20.2204
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
    /// VoicestopmonitoringData
    /// </summary>
    [DataContract]
    public partial class VoicestopmonitoringData :  IEquatable<VoicestopmonitoringData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicestopmonitoringData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicestopmonitoringData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicestopmonitoringData" /> class.
        /// </summary>
        /// <param name="PhoneNumber">The phone number currently being monitored. (required).</param>
        public VoicestopmonitoringData(string PhoneNumber = default(string))
        {
            // to ensure "PhoneNumber" is required (not null)
            if (PhoneNumber == null)
            {
                throw new InvalidDataException("PhoneNumber is a required property for VoicestopmonitoringData and cannot be null");
            }
            else
            {
                this.PhoneNumber = PhoneNumber;
            }
        }
        
        /// <summary>
        /// The phone number currently being monitored.
        /// </summary>
        /// <value>The phone number currently being monitored.</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicestopmonitoringData {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as VoicestopmonitoringData);
        }

        /// <summary>
        /// Returns true if VoicestopmonitoringData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicestopmonitoringData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicestopmonitoringData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
