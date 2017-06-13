/* 
 * Workspace Application API
 *
 * Application API used by Workspace Web Edition
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

namespace IO.Swagger.Model
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
        /// <param name="PhoneNumber">The phone number currently monitored, for which the monitoring should be stopped (required).</param>
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
        /// The phone number currently monitored, for which the monitoring should be stopped
        /// </summary>
        /// <value>The phone number currently monitored, for which the monitoring should be stopped</value>
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as VoicestopmonitoringData);
        }

        /// <summary>
        /// Returns true if VoicestopmonitoringData instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicestopmonitoringData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicestopmonitoringData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PhoneNumber == other.PhoneNumber ||
                    this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(other.PhoneNumber)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PhoneNumber != null)
                    hash = hash * 59 + this.PhoneNumber.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
