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
    /// StatisticsSubscribeDataData
    /// </summary>
    [DataContract]
    public partial class StatisticsSubscribeDataData :  IEquatable<StatisticsSubscribeDataData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsSubscribeDataData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatisticsSubscribeDataData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticsSubscribeDataData" /> class.
        /// </summary>
        /// <param name="Statistics">Statistics (required).</param>
        public StatisticsSubscribeDataData(List<Statistic> Statistics = default(List<Statistic>))
        {
            // to ensure "Statistics" is required (not null)
            if (Statistics == null)
            {
                throw new InvalidDataException("Statistics is a required property for StatisticsSubscribeDataData and cannot be null");
            }
            else
            {
                this.Statistics = Statistics;
            }
        }
        
        /// <summary>
        /// Gets or Sets Statistics
        /// </summary>
        [DataMember(Name="statistics", EmitDefaultValue=false)]
        public List<Statistic> Statistics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticsSubscribeDataData {\n");
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
            return this.Equals(input as StatisticsSubscribeDataData);
        }

        /// <summary>
        /// Returns true if StatisticsSubscribeDataData instances are equal
        /// </summary>
        /// <param name="input">Instance of StatisticsSubscribeDataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticsSubscribeDataData input)
        {
            if (input == null)
                return false;

            return 
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
