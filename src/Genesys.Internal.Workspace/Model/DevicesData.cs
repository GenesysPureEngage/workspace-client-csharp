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
    /// DevicesData
    /// </summary>
    [DataContract]
    public partial class DevicesData :  IEquatable<DevicesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevicesData" /> class.
        /// </summary>
        /// <param name="Devices">An array containing devices..</param>
        public DevicesData(List<Dn> Devices = default(List<Dn>))
        {
            this.Devices = Devices;
        }
        
        /// <summary>
        /// An array containing devices.
        /// </summary>
        /// <value>An array containing devices.</value>
        [DataMember(Name="devices", EmitDefaultValue=false)]
        public List<Dn> Devices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DevicesData {\n");
            sb.Append("  Devices: ").Append(Devices).Append("\n");
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
            return this.Equals(input as DevicesData);
        }

        /// <summary>
        /// Returns true if DevicesData instances are equal
        /// </summary>
        /// <param name="input">Instance of DevicesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DevicesData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Devices == input.Devices ||
                    this.Devices != null &&
                    this.Devices.SequenceEqual(input.Devices)
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
                if (this.Devices != null)
                    hashCode = hashCode * 59 + this.Devices.GetHashCode();
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
