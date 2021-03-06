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
        /// <param name="Approved">true to get only approved categories.</param>
        public UcsresponsescategoriesidgetdetailsData(bool? ReturnChildrenCategories = default(bool?), bool? ReturnChildrenSRInfo = default(bool?), bool? Approved = default(bool?))
        {
            this.ReturnChildrenCategories = ReturnChildrenCategories;
            this.ReturnChildrenSRInfo = ReturnChildrenSRInfo;
            this.Approved = Approved;
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
        /// true to get only approved categories
        /// </summary>
        /// <value>true to get only approved categories</value>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public bool? Approved { get; set; }

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
            sb.Append("  Approved: ").Append(Approved).Append("\n");
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
            return this.Equals(input as UcsresponsescategoriesidgetdetailsData);
        }

        /// <summary>
        /// Returns true if UcsresponsescategoriesidgetdetailsData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsresponsescategoriesidgetdetailsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsresponsescategoriesidgetdetailsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnChildrenCategories == input.ReturnChildrenCategories ||
                    (this.ReturnChildrenCategories != null &&
                    this.ReturnChildrenCategories.Equals(input.ReturnChildrenCategories))
                ) && 
                (
                    this.ReturnChildrenSRInfo == input.ReturnChildrenSRInfo ||
                    (this.ReturnChildrenSRInfo != null &&
                    this.ReturnChildrenSRInfo.Equals(input.ReturnChildrenSRInfo))
                ) && 
                (
                    this.Approved == input.Approved ||
                    (this.Approved != null &&
                    this.Approved.Equals(input.Approved))
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
                if (this.ReturnChildrenCategories != null)
                    hashCode = hashCode * 59 + this.ReturnChildrenCategories.GetHashCode();
                if (this.ReturnChildrenSRInfo != null)
                    hashCode = hashCode * 59 + this.ReturnChildrenSRInfo.GetHashCode();
                if (this.Approved != null)
                    hashCode = hashCode * 59 + this.Approved.GetHashCode();
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
