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
    /// UcsresponsescategoriesgetrootData
    /// </summary>
    [DataContract]
    public partial class UcsresponsescategoriesgetrootData :  IEquatable<UcsresponsescategoriesgetrootData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsresponsescategoriesgetrootData" /> class.
        /// </summary>
        /// <param name="Approved">true to get only approved categories.</param>
        /// <param name="Language">CME configured Language.</param>
        public UcsresponsescategoriesgetrootData(bool? Approved = default(bool?), string Language = default(string))
        {
            this.Approved = Approved;
            this.Language = Language;
        }
        
        /// <summary>
        /// true to get only approved categories
        /// </summary>
        /// <value>true to get only approved categories</value>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public bool? Approved { get; set; }

        /// <summary>
        /// CME configured Language
        /// </summary>
        /// <value>CME configured Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsresponsescategoriesgetrootData {\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as UcsresponsescategoriesgetrootData);
        }

        /// <summary>
        /// Returns true if UcsresponsescategoriesgetrootData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsresponsescategoriesgetrootData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsresponsescategoriesgetrootData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Approved == input.Approved ||
                    (this.Approved != null &&
                    this.Approved.Equals(input.Approved))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.Approved != null)
                    hashCode = hashCode * 59 + this.Approved.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
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
