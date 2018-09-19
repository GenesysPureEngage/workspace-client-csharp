/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.22.2269
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
    /// SupervisorvoiceoperationNameData
    /// </summary>
    [DataContract]
    public partial class SupervisorvoiceoperationNameData :  IEquatable<SupervisorvoiceoperationNameData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorvoiceoperationNameData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SupervisorvoiceoperationNameData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SupervisorvoiceoperationNameData" /> class.
        /// </summary>
        /// <param name="UserName">userName of the user to logout (required).</param>
        /// <param name="Dn">DN of the user to logout (required).</param>
        public SupervisorvoiceoperationNameData(string UserName = default(string), string Dn = default(string))
        {
            // to ensure "UserName" is required (not null)
            if (UserName == null)
            {
                throw new InvalidDataException("UserName is a required property for SupervisorvoiceoperationNameData and cannot be null");
            }
            else
            {
                this.UserName = UserName;
            }
            // to ensure "Dn" is required (not null)
            if (Dn == null)
            {
                throw new InvalidDataException("Dn is a required property for SupervisorvoiceoperationNameData and cannot be null");
            }
            else
            {
                this.Dn = Dn;
            }
        }
        
        /// <summary>
        /// userName of the user to logout
        /// </summary>
        /// <value>userName of the user to logout</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// DN of the user to logout
        /// </summary>
        /// <value>DN of the user to logout</value>
        [DataMember(Name="dn", EmitDefaultValue=false)]
        public string Dn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupervisorvoiceoperationNameData {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
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
            return this.Equals(input as SupervisorvoiceoperationNameData);
        }

        /// <summary>
        /// Returns true if SupervisorvoiceoperationNameData instances are equal
        /// </summary>
        /// <param name="input">Instance of SupervisorvoiceoperationNameData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SupervisorvoiceoperationNameData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Dn == input.Dn ||
                    (this.Dn != null &&
                    this.Dn.Equals(input.Dn))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Dn != null)
                    hashCode = hashCode * 59 + this.Dn.GetHashCode();
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
