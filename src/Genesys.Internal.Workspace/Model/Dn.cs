/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.23.2279
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
    /// Dn
    /// </summary>
    [DataContract]
    public partial class Dn :  IEquatable<Dn>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dn" /> class.
        /// </summary>
        /// <param name="Number">The directory number (phone number)..</param>
        /// <param name="AgentId">The agent ID used to log in..</param>
        /// <param name="AgentState">The current state. Valid values are &#x60;LoggedOut&#x60;, &#x60;LoggedIn&#x60;, &#x60;Ready&#x60;, or &#x60;NotReady&#x60;..</param>
        /// <param name="AgentWorkMode">The current workmode. This value can be either &#x60;AuxWork&#x60; or &#x60;AfterCallWork&#x60; if the agent&#39;s state is Not Ready, or &#x60;AutoIn&#x60; or &#x60;ManualIn&#x60; if the agent&#39;s state is Ready..</param>
        public Dn(string Number = default(string), string AgentId = default(string), string AgentState = default(string), string AgentWorkMode = default(string))
        {
            this.Number = Number;
            this.AgentId = AgentId;
            this.AgentState = AgentState;
            this.AgentWorkMode = AgentWorkMode;
        }
        
        /// <summary>
        /// The directory number (phone number).
        /// </summary>
        /// <value>The directory number (phone number).</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// The agent ID used to log in.
        /// </summary>
        /// <value>The agent ID used to log in.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// The current state. Valid values are &#x60;LoggedOut&#x60;, &#x60;LoggedIn&#x60;, &#x60;Ready&#x60;, or &#x60;NotReady&#x60;.
        /// </summary>
        /// <value>The current state. Valid values are &#x60;LoggedOut&#x60;, &#x60;LoggedIn&#x60;, &#x60;Ready&#x60;, or &#x60;NotReady&#x60;.</value>
        [DataMember(Name="agentState", EmitDefaultValue=false)]
        public string AgentState { get; set; }

        /// <summary>
        /// The current workmode. This value can be either &#x60;AuxWork&#x60; or &#x60;AfterCallWork&#x60; if the agent&#39;s state is Not Ready, or &#x60;AutoIn&#x60; or &#x60;ManualIn&#x60; if the agent&#39;s state is Ready.
        /// </summary>
        /// <value>The current workmode. This value can be either &#x60;AuxWork&#x60; or &#x60;AfterCallWork&#x60; if the agent&#39;s state is Not Ready, or &#x60;AutoIn&#x60; or &#x60;ManualIn&#x60; if the agent&#39;s state is Ready.</value>
        [DataMember(Name="agentWorkMode", EmitDefaultValue=false)]
        public string AgentWorkMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Dn {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AgentState: ").Append(AgentState).Append("\n");
            sb.Append("  AgentWorkMode: ").Append(AgentWorkMode).Append("\n");
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
            return this.Equals(input as Dn);
        }

        /// <summary>
        /// Returns true if Dn instances are equal
        /// </summary>
        /// <param name="input">Instance of Dn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Dn input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.AgentState == input.AgentState ||
                    (this.AgentState != null &&
                    this.AgentState.Equals(input.AgentState))
                ) && 
                (
                    this.AgentWorkMode == input.AgentWorkMode ||
                    (this.AgentWorkMode != null &&
                    this.AgentWorkMode.Equals(input.AgentWorkMode))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.AgentId != null)
                    hashCode = hashCode * 59 + this.AgentId.GetHashCode();
                if (this.AgentState != null)
                    hashCode = hashCode * 59 + this.AgentState.GetHashCode();
                if (this.AgentWorkMode != null)
                    hashCode = hashCode * 59 + this.AgentWorkMode.GetHashCode();
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
