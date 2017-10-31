/* 
 * Workspace API
 *
 * Agent API
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
using SwaggerDateConverter = Genesys.Workspace.Client.SwaggerDateConverter;

namespace Genesys.Workspace.Model
{
    /// <summary>
    /// UcsresponsescategoriesidgetdetailsData
    /// </summary>
    [DataContract]
    public partial class UcsresponsescategoriesidgetdetailsData :  IEquatable<UcsresponsescategoriesidgetdetailsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsresponsescategoriesidgetdetailsData" /> class.
        /// </summary>
        /// <param name="ReturnChildrenCategories">true to get children categories.</param>
        /// <param name="ReturnChildrenSRInfo">true to get children standard responses.</param>
        public UcsresponsescategoriesidgetdetailsData(bool? ReturnChildrenCategories = default(bool?), bool? ReturnChildrenSRInfo = default(bool?))
        {
            this.ReturnChildrenCategories = ReturnChildrenCategories;
            this.ReturnChildrenSRInfo = ReturnChildrenSRInfo;
        }
        
        /// <summary>
        /// true to get children categories
        /// </summary>
        /// <value>true to get children categories</value>
        [DataMember(Name="returnChildrenCategories", EmitDefaultValue=false)]
        public bool? ReturnChildrenCategories { get; set; }

        /// <summary>
        /// true to get children standard responses
        /// </summary>
        /// <value>true to get children standard responses</value>
        [DataMember(Name="returnChildrenSRInfo", EmitDefaultValue=false)]
        public bool? ReturnChildrenSRInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsresponsescategoriesidgetdetailsData {\n");
            sb.Append("  ReturnChildrenCategories: ").Append(ReturnChildrenCategories).Append("\n");
            sb.Append("  ReturnChildrenSRInfo: ").Append(ReturnChildrenSRInfo).Append("\n");
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
            return this.Equals(obj as UcsresponsescategoriesidgetdetailsData);
        }

        /// <summary>
        /// Returns true if UcsresponsescategoriesidgetdetailsData instances are equal
        /// </summary>
        /// <param name="other">Instance of UcsresponsescategoriesidgetdetailsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsresponsescategoriesidgetdetailsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReturnChildrenCategories == other.ReturnChildrenCategories ||
                    this.ReturnChildrenCategories != null &&
                    this.ReturnChildrenCategories.Equals(other.ReturnChildrenCategories)
                ) && 
                (
                    this.ReturnChildrenSRInfo == other.ReturnChildrenSRInfo ||
                    this.ReturnChildrenSRInfo != null &&
                    this.ReturnChildrenSRInfo.Equals(other.ReturnChildrenSRInfo)
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
                if (this.ReturnChildrenCategories != null)
                    hash = hash * 59 + this.ReturnChildrenCategories.GetHashCode();
                if (this.ReturnChildrenSRInfo != null)
                    hash = hash * 59 + this.ReturnChildrenSRInfo.GetHashCode();
                return hash;
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
