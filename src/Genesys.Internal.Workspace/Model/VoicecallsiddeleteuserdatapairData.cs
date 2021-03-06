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
    /// VoicecallsiddeleteuserdatapairData
    /// </summary>
    [DataContract]
    public partial class VoicecallsiddeleteuserdatapairData :  IEquatable<VoicecallsiddeleteuserdatapairData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsiddeleteuserdatapairData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsiddeleteuserdatapairData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsiddeleteuserdatapairData" /> class.
        /// </summary>
        /// <param name="Key">The key of the data to remove. (required).</param>
        public VoicecallsiddeleteuserdatapairData(string Key = default(string))
        {
            // to ensure "Key" is required (not null)
            if (Key == null)
            {
                throw new InvalidDataException("Key is a required property for VoicecallsiddeleteuserdatapairData and cannot be null");
            }
            else
            {
                this.Key = Key;
            }
        }
        
        /// <summary>
        /// The key of the data to remove.
        /// </summary>
        /// <value>The key of the data to remove.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicecallsiddeleteuserdatapairData {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as VoicecallsiddeleteuserdatapairData);
        }

        /// <summary>
        /// Returns true if VoicecallsiddeleteuserdatapairData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicecallsiddeleteuserdatapairData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsiddeleteuserdatapairData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
