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
    /// UcscontactssearchData
    /// </summary>
    [DataContract]
    public partial class UcscontactssearchData :  IEquatable<UcscontactssearchData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcscontactssearchData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcscontactssearchData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcscontactssearchData" /> class.
        /// </summary>
        /// <param name="Query">The query to do the lucene search for contacts (required).</param>
        /// <param name="ReturnedAttributes">The list of custom contact attributes to be returned for each contact in response (required).</param>
        /// <param name="StartIndex">The start index.</param>
        /// <param name="MaxResults">The maximum number of contacts to be returned.</param>
        /// <param name="SortCriteria">The list of sorting criterias which contains the \&quot;attributeName\&quot; and \&quot;mode\&quot; (&#39;asc&#39; / &#39;desc&#39;) parameters.</param>
        public UcscontactssearchData(string Query = default(string), List<string> ReturnedAttributes = default(List<string>), int? StartIndex = default(int?), int? MaxResults = default(int?), List<Object> SortCriteria = default(List<Object>))
        {
            // to ensure "Query" is required (not null)
            if (Query == null)
            {
                throw new InvalidDataException("Query is a required property for UcscontactssearchData and cannot be null");
            }
            else
            {
                this.Query = Query;
            }
            // to ensure "ReturnedAttributes" is required (not null)
            if (ReturnedAttributes == null)
            {
                throw new InvalidDataException("ReturnedAttributes is a required property for UcscontactssearchData and cannot be null");
            }
            else
            {
                this.ReturnedAttributes = ReturnedAttributes;
            }
            this.StartIndex = StartIndex;
            this.MaxResults = MaxResults;
            this.SortCriteria = SortCriteria;
        }
        
        /// <summary>
        /// The query to do the lucene search for contacts
        /// </summary>
        /// <value>The query to do the lucene search for contacts</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// The list of custom contact attributes to be returned for each contact in response
        /// </summary>
        /// <value>The list of custom contact attributes to be returned for each contact in response</value>
        [DataMember(Name="returnedAttributes", EmitDefaultValue=false)]
        public List<string> ReturnedAttributes { get; set; }

        /// <summary>
        /// The start index
        /// </summary>
        /// <value>The start index</value>
        [DataMember(Name="startIndex", EmitDefaultValue=false)]
        public int? StartIndex { get; set; }

        /// <summary>
        /// The maximum number of contacts to be returned
        /// </summary>
        /// <value>The maximum number of contacts to be returned</value>
        [DataMember(Name="maxResults", EmitDefaultValue=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The list of sorting criterias which contains the \&quot;attributeName\&quot; and \&quot;mode\&quot; (&#39;asc&#39; / &#39;desc&#39;) parameters
        /// </summary>
        /// <value>The list of sorting criterias which contains the \&quot;attributeName\&quot; and \&quot;mode\&quot; (&#39;asc&#39; / &#39;desc&#39;) parameters</value>
        [DataMember(Name="sortCriteria", EmitDefaultValue=false)]
        public List<Object> SortCriteria { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcscontactssearchData {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  ReturnedAttributes: ").Append(ReturnedAttributes).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  SortCriteria: ").Append(SortCriteria).Append("\n");
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
            return this.Equals(input as UcscontactssearchData);
        }

        /// <summary>
        /// Returns true if UcscontactssearchData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcscontactssearchData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcscontactssearchData input)
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
                    this.StartIndex == input.StartIndex ||
                    (this.StartIndex != null &&
                    this.StartIndex.Equals(input.StartIndex))
                ) && 
                (
                    this.MaxResults == input.MaxResults ||
                    (this.MaxResults != null &&
                    this.MaxResults.Equals(input.MaxResults))
                ) && 
                (
                    this.SortCriteria == input.SortCriteria ||
                    this.SortCriteria != null &&
                    this.SortCriteria.SequenceEqual(input.SortCriteria)
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
                if (this.StartIndex != null)
                    hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.MaxResults != null)
                    hashCode = hashCode * 59 + this.MaxResults.GetHashCode();
                if (this.SortCriteria != null)
                    hashCode = hashCode * 59 + this.SortCriteria.GetHashCode();
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
