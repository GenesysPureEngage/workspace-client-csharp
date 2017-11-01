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
    /// MonitoringScopeDataData
    /// </summary>
    [DataContract]
    public partial class MonitoringScopeDataData :  IEquatable<MonitoringScopeDataData>, IValidatableObject
    {
        /// <summary>
        /// The monitoring scope (Call/Agent).
        /// </summary>
        /// <value>The monitoring scope (Call/Agent).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MonitoringScopeEnum
        {
            
            /// <summary>
            /// Enum Call for "Call"
            /// </summary>
            [EnumMember(Value = "Call")]
            Call,
            
            /// <summary>
            /// Enum Agent for "Agent"
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent
        }

        /// <summary>
        /// The monitoring scope (Call/Agent).
        /// </summary>
        /// <value>The monitoring scope (Call/Agent).</value>
        [DataMember(Name="monitoringScope", EmitDefaultValue=false)]
        public MonitoringScopeEnum? MonitoringScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MonitoringScopeDataData" /> class.
        /// </summary>
        /// <param name="MonitoringScope">The monitoring scope (Call/Agent)..</param>
        public MonitoringScopeDataData(MonitoringScopeEnum? MonitoringScope = default(MonitoringScopeEnum?))
        {
            this.MonitoringScope = MonitoringScope;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MonitoringScopeDataData {\n");
            sb.Append("  MonitoringScope: ").Append(MonitoringScope).Append("\n");
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
            return this.Equals(input as MonitoringScopeDataData);
        }

        /// <summary>
        /// Returns true if MonitoringScopeDataData instances are equal
        /// </summary>
        /// <param name="input">Instance of MonitoringScopeDataData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonitoringScopeDataData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MonitoringScope == input.MonitoringScope ||
                    (this.MonitoringScope != null &&
                    this.MonitoringScope.Equals(input.MonitoringScope))
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
                if (this.MonitoringScope != null)
                    hashCode = hashCode * 59 + this.MonitoringScope.GetHashCode();
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
