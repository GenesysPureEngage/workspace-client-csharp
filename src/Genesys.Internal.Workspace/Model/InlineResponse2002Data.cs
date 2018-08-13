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
    /// InlineResponse2002Data
    /// </summary>
    [DataContract]
    public partial class InlineResponse2002Data :  IEquatable<InlineResponse2002Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2002Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002Data" /> class.
        /// </summary>
        /// <param name="SubscriptionId">The ID used to fetch statistics values from &#x60;/reporting/subscriptions/{subscriptionId}&#x60;. (required).</param>
        /// <param name="Statistics">The list of all the subscribed statistics with the assigned ids. (required).</param>
        public InlineResponse2002Data(string SubscriptionId = default(string), List<StatisticValue> Statistics = default(List<StatisticValue>))
        {
            // to ensure "SubscriptionId" is required (not null)
            if (SubscriptionId == null)
            {
                throw new InvalidDataException("SubscriptionId is a required property for InlineResponse2002Data and cannot be null");
            }
            else
            {
                this.SubscriptionId = SubscriptionId;
            }
            // to ensure "Statistics" is required (not null)
            if (Statistics == null)
            {
                throw new InvalidDataException("Statistics is a required property for InlineResponse2002Data and cannot be null");
            }
            else
            {
                this.Statistics = Statistics;
            }
        }
        
        /// <summary>
        /// The ID used to fetch statistics values from &#x60;/reporting/subscriptions/{subscriptionId}&#x60;.
        /// </summary>
        /// <value>The ID used to fetch statistics values from &#x60;/reporting/subscriptions/{subscriptionId}&#x60;.</value>
        [DataMember(Name="subscriptionId", EmitDefaultValue=false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// The list of all the subscribed statistics with the assigned ids.
        /// </summary>
        /// <value>The list of all the subscribed statistics with the assigned ids.</value>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public List<StatisticValue> Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002Data {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  Statistics: ").Append(Statistics).Append("\n");
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
            return this.Equals(input as InlineResponse2002Data);
        }

        /// <summary>
        /// Returns true if InlineResponse2002Data instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2002Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.Statistics == input.Statistics ||
                    this.Statistics != null &&
                    this.Statistics.SequenceEqual(input.Statistics)
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
                if (this.SubscriptionId != null)
                    hashCode = hashCode * 59 + this.SubscriptionId.GetHashCode();
                if (this.Statistics != null)
                    hashCode = hashCode * 59 + this.Statistics.GetHashCode();
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
