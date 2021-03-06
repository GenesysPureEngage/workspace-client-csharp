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
    /// UcsixnsearchData
    /// </summary>
    [DataContract]
    public partial class UcsixnsearchData :  IEquatable<UcsixnsearchData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsixnsearchData" /> class.
        /// </summary>
        /// <param name="MaxResults">The maximum number of contacts to be returned.</param>
        /// <param name="Owner">The list of agent username for which the search refers to..</param>
        /// <param name="Query">The query to do the lucene search for contacts.</param>
        /// <param name="ReturnedAttributes">The list of contact attributes to be returned for each contact in response.</param>
        public UcsixnsearchData(int? MaxResults = default(int?), List<string> Owner = default(List<string>), string Query = default(string), List<string> ReturnedAttributes = default(List<string>))
        {
            this.MaxResults = MaxResults;
            this.Owner = Owner;
            this.Query = Query;
            this.ReturnedAttributes = ReturnedAttributes;
        }
        
        /// <summary>
        /// The maximum number of contacts to be returned
        /// </summary>
        /// <value>The maximum number of contacts to be returned</value>
        [DataMember(Name="maxResults", EmitDefaultValue=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The list of agent username for which the search refers to.
        /// </summary>
        /// <value>The list of agent username for which the search refers to.</value>
        [DataMember(Name="owner", EmitDefaultValue=false)]
        public List<string> Owner { get; set; }

        /// <summary>
        /// The query to do the lucene search for contacts
        /// </summary>
        /// <value>The query to do the lucene search for contacts</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// The list of contact attributes to be returned for each contact in response
        /// </summary>
        /// <value>The list of contact attributes to be returned for each contact in response</value>
        [DataMember(Name="returnedAttributes", EmitDefaultValue=false)]
        public List<string> ReturnedAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsixnsearchData {\n");
            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(input as UcsixnsearchData);
        }

        /// <summary>
        /// Returns true if UcsixnsearchData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsixnsearchData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsixnsearchData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxResults == input.MaxResults ||
                    (this.MaxResults != null &&
                    this.MaxResults.Equals(input.MaxResults))
                ) && 
                (
                    this.Owner == input.Owner ||
                    this.Owner != null &&
                    this.Owner.SequenceEqual(input.Owner)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
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
                if (this.MaxResults != null)
                    hashCode = hashCode * 59 + this.MaxResults.GetHashCode();
                if (this.Owner != null)
                    hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Query != null)
                    hashCode = hashCode * 59 + this.Query.GetHashCode();
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
