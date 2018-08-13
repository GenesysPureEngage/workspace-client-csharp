/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: v9.0.000.20.2204
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
    /// UcsresponsessearchData
    /// </summary>
    [DataContract]
    public partial class UcsresponsessearchData :  IEquatable<UcsresponsessearchData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsresponsessearchData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcsresponsessearchData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsresponsessearchData" /> class.
        /// </summary>
        /// <param name="Query">The query to do the lucene search for standard responses (required).</param>
        /// <param name="ReturnedAttributes">The list of standard responses attributes to be returned for each standard response in request response.</param>
        /// <param name="MaxResults">The maximum number of standard responses to be returned.</param>
        public UcsresponsessearchData(string Query = default(string), List<string> ReturnedAttributes = default(List<string>), int? MaxResults = default(int?))
        {
            // to ensure "Query" is required (not null)
            if (Query == null)
            {
                throw new InvalidDataException("Query is a required property for UcsresponsessearchData and cannot be null");
            }
            else
            {
                this.Query = Query;
            }
            this.ReturnedAttributes = ReturnedAttributes;
            this.MaxResults = MaxResults;
        }
        
        /// <summary>
        /// The query to do the lucene search for standard responses
        /// </summary>
        /// <value>The query to do the lucene search for standard responses</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// The list of standard responses attributes to be returned for each standard response in request response
        /// </summary>
        /// <value>The list of standard responses attributes to be returned for each standard response in request response</value>
        [DataMember(Name="returnedAttributes", EmitDefaultValue=false)]
        public List<string> ReturnedAttributes { get; set; }

        /// <summary>
        /// The maximum number of standard responses to be returned
        /// </summary>
        /// <value>The maximum number of standard responses to be returned</value>
        [DataMember(Name="maxResults", EmitDefaultValue=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsresponsessearchData {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  ReturnedAttributes: ").Append(ReturnedAttributes).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
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
            return this.Equals(input as UcsresponsessearchData);
        }

        /// <summary>
        /// Returns true if UcsresponsessearchData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsresponsessearchData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsresponsessearchData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.ReturnedAttributes == input.ReturnedAttributes ||
                    this.ReturnedAttributes != null &&
                    this.ReturnedAttributes.SequenceEqual(input.ReturnedAttributes)
                ) && 
                (
                    this.MaxResults == input.MaxResults ||
                    (this.MaxResults != null &&
                    this.MaxResults.Equals(input.MaxResults))
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
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.ReturnedAttributes != null)
                    hashCode = hashCode * 59 + this.ReturnedAttributes.GetHashCode();
                if (this.MaxResults != null)
                    hashCode = hashCode * 59 + this.MaxResults.GetHashCode();
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
