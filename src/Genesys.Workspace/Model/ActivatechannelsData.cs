/* 
 * Workspace API
 *
 * Application API used by Workspace Web Edition
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
    /// ActivatechannelsData
    /// </summary>
    [DataContract]
    public partial class ActivatechannelsData :  IEquatable<ActivatechannelsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivatechannelsData" /> class.
        /// </summary>
        /// <param name="AgentId">agentId (switch login code) that should be used to log the agent in.</param>
        /// <param name="PlaceName">The name of the place that should be used to log the agent in. Either placeName or dn must be provided..</param>
        /// <param name="Dn">The dn (number) that should be used to login the agent..</param>
        /// <param name="QueueName">The queue name that should be used to login the agent..</param>
        public ActivatechannelsData(string AgentId = default(string), string PlaceName = default(string), string Dn = default(string), string QueueName = default(string))
        {
            this.AgentId = AgentId;
            this.PlaceName = PlaceName;
            this.Dn = Dn;
            this.QueueName = QueueName;
        }
        
        /// <summary>
        /// agentId (switch login code) that should be used to log the agent in
        /// </summary>
        /// <value>agentId (switch login code) that should be used to log the agent in</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// The name of the place that should be used to log the agent in. Either placeName or dn must be provided.
        /// </summary>
        /// <value>The name of the place that should be used to log the agent in. Either placeName or dn must be provided.</value>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

        /// <summary>
        /// The dn (number) that should be used to login the agent.
        /// </summary>
        /// <value>The dn (number) that should be used to login the agent.</value>
        [DataMember(Name="dn", EmitDefaultValue=false)]
        public string Dn { get; set; }

        /// <summary>
        /// The queue name that should be used to login the agent.
        /// </summary>
        /// <value>The queue name that should be used to login the agent.</value>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActivatechannelsData {\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
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
            return this.Equals(obj as ActivatechannelsData);
        }

        /// <summary>
        /// Returns true if ActivatechannelsData instances are equal
        /// </summary>
        /// <param name="other">Instance of ActivatechannelsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivatechannelsData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AgentId == other.AgentId ||
                    this.AgentId != null &&
                    this.AgentId.Equals(other.AgentId)
                ) && 
                (
                    this.PlaceName == other.PlaceName ||
                    this.PlaceName != null &&
                    this.PlaceName.Equals(other.PlaceName)
                ) && 
                (
                    this.Dn == other.Dn ||
                    this.Dn != null &&
                    this.Dn.Equals(other.Dn)
                ) && 
                (
                    this.QueueName == other.QueueName ||
                    this.QueueName != null &&
                    this.QueueName.Equals(other.QueueName)
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
                if (this.AgentId != null)
                    hash = hash * 59 + this.AgentId.GetHashCode();
                if (this.PlaceName != null)
                    hash = hash * 59 + this.PlaceName.GetHashCode();
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                if (this.QueueName != null)
                    hash = hash * 59 + this.QueueName.GetHashCode();
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
