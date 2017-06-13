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
    /// CurrentUserDataUserActiveSession
    /// </summary>
    [DataContract]
    public partial class CurrentUserDataUserActiveSession :  IEquatable<CurrentUserDataUserActiveSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentUserDataUserActiveSession" /> class.
        /// </summary>
        /// <param name="Dn">Dn.</param>
        public CurrentUserDataUserActiveSession(CurrentUserDataUserActiveSessionDn Dn = default(CurrentUserDataUserActiveSessionDn))
        {
            this.Dn = Dn;
        }
        
        /// <summary>
        /// Gets or Sets Dn
        /// </summary>
        [DataMember(Name="dn", EmitDefaultValue=false)]
        public CurrentUserDataUserActiveSessionDn Dn { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentUserDataUserActiveSession {\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CurrentUserDataUserActiveSession);
        }

        /// <summary>
        /// Returns true if CurrentUserDataUserActiveSession instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrentUserDataUserActiveSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentUserDataUserActiveSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dn == other.Dn ||
                    this.Dn != null &&
                    this.Dn.Equals(other.Dn)
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
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
