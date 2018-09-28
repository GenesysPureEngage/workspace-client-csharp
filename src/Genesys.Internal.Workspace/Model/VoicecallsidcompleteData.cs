/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.23.2279
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
    /// VoicecallsidcompleteData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidcompleteData :  IEquatable<VoicecallsidcompleteData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidcompleteData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsidcompleteData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidcompleteData" /> class.
        /// </summary>
        /// <param name="UserData">UserData (required).</param>
        public VoicecallsidcompleteData(List<Kvpair> UserData = default(List<Kvpair>))
        {
            // to ensure "UserData" is required (not null)
            if (UserData == null)
            {
                throw new InvalidDataException("UserData is a required property for VoicecallsidcompleteData and cannot be null");
            }
            else
            {
                this.UserData = UserData;
            }
        }
        
        /// <summary>
        /// Gets or Sets UserData
        /// </summary>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicecallsidcompleteData {\n");
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
            return this.Equals(input as VoicecallsidcompleteData);
        }

        /// <summary>
        /// Returns true if VoicecallsidcompleteData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicecallsidcompleteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidcompleteData input)
        {
            if (input == null)
                return false;

            return 
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
