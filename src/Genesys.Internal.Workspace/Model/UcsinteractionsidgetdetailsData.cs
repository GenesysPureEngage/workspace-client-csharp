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
    /// UcsinteractionsidgetdetailsData
    /// </summary>
    [DataContract]
    public partial class UcsinteractionsidgetdetailsData :  IEquatable<UcsinteractionsidgetdetailsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsinteractionsidgetdetailsData" /> class.
        /// </summary>
        /// <param name="ReturnedAttributes">The list of interaction attributes to be returned.</param>
        public UcsinteractionsidgetdetailsData(List<string> ReturnedAttributes = default(List<string>))
        {
            this.ReturnedAttributes = ReturnedAttributes;
        }
        
        /// <summary>
        /// The list of interaction attributes to be returned
        /// </summary>
        /// <value>The list of interaction attributes to be returned</value>
        [DataMember(Name="returnedAttributes", EmitDefaultValue=false)]
        public List<string> ReturnedAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsinteractionsidgetdetailsData {\n");
            sb.Append("  ReturnedAttributes: ").Append(ReturnedAttributes).Append("\n");
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
            return this.Equals(input as UcsinteractionsidgetdetailsData);
        }

        /// <summary>
        /// Returns true if UcsinteractionsidgetdetailsData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsinteractionsidgetdetailsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsinteractionsidgetdetailsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnedAttributes == input.ReturnedAttributes ||
                    this.ReturnedAttributes != null &&
                    this.ReturnedAttributes.SequenceEqual(input.ReturnedAttributes)
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
                if (this.ReturnedAttributes != null)
                    hashCode = hashCode * 59 + this.ReturnedAttributes.GetHashCode();
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
