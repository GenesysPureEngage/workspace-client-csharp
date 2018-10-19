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
    /// MediamediatypestopmonitoringData
    /// </summary>
    [DataContract]
    public partial class MediamediatypestopmonitoringData :  IEquatable<MediamediatypestopmonitoringData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypestopmonitoringData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediamediatypestopmonitoringData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypestopmonitoringData" /> class.
        /// </summary>
        /// <param name="AgentId">The unique ID of the agent to stop monitoring. (required).</param>
        public MediamediatypestopmonitoringData(string AgentId = default(string))
        {
            // to ensure "AgentId" is required (not null)
            if (AgentId == null)
            {
                throw new InvalidDataException("AgentId is a required property for MediamediatypestopmonitoringData and cannot be null");
            }
            else
            {
                this.AgentId = AgentId;
            }
        }
        
        /// <summary>
        /// The unique ID of the agent to stop monitoring.
        /// </summary>
        /// <value>The unique ID of the agent to stop monitoring.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamediatypestopmonitoringData {\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
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
            return this.Equals(input as MediamediatypestopmonitoringData);
        }

        /// <summary>
        /// Returns true if MediamediatypestopmonitoringData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamediatypestopmonitoringData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypestopmonitoringData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
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
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
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
