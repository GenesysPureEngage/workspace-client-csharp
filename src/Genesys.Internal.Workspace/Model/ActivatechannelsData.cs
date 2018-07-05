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
using SwaggerDateConverter = Genesys.Internal.Workspace.Client.SwaggerDateConverter;

namespace Genesys.Internal.Workspace.Model
{
    /// <summary>
    /// ActivatechannelsData
    /// </summary>
    [DataContract]
    public partial class ActivatechannelsData :  IEquatable<ActivatechannelsData>, IValidatableObject
    {
        /// <summary>
        /// The workmode.
        /// </summary>
        /// <value>The workmode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AgentWorkModeEnum
        {
            
            /// <summary>
            /// Enum AutoIn for "AutoIn"
            /// </summary>
            [EnumMember(Value = "AutoIn")]
            AutoIn,
            
            /// <summary>
            /// Enum ManualIn for "ManualIn"
            /// </summary>
            [EnumMember(Value = "ManualIn")]
            ManualIn
        }

        /// <summary>
        /// The workmode.
        /// </summary>
        /// <value>The workmode.</value>
        [DataMember(Name="agentWorkMode", EmitDefaultValue=false)]
        public AgentWorkModeEnum? AgentWorkMode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivatechannelsData" /> class.
        /// </summary>
        /// <param name="AgentId">The unique ID of the agent..</param>
        /// <param name="PlaceName">The name of the place to use for the agent. You must provide either the place name or DN..</param>
        /// <param name="Dn">The DN (number) to use for the agent. You must provide either the place name or DN..</param>
        /// <param name="QueueName">The queue name..</param>
        /// <param name="AgentWorkMode">The workmode..</param>
        /// <param name="DynamicPhoneNumber">An optional dynamic phone number to use for the agent..</param>
        /// <param name="AutoCompleteCall">Specifies if calls should automatically be completed for the session. Defaults to true if not provided..</param>
        /// <param name="Channels">An array of strings that correspond to the channels you want to activate..</param>
        public ActivatechannelsData(string AgentId = default(string), string PlaceName = default(string), string Dn = default(string), string QueueName = default(string), AgentWorkModeEnum? AgentWorkMode = default(AgentWorkModeEnum?), string DynamicPhoneNumber = default(string), bool? AutoCompleteCall = default(bool?), List<string> Channels = default(List<string>))
        {
            this.AgentId = AgentId;
            this.PlaceName = PlaceName;
            this.Dn = Dn;
            this.QueueName = QueueName;
            this.AgentWorkMode = AgentWorkMode;
            this.DynamicPhoneNumber = DynamicPhoneNumber;
            this.AutoCompleteCall = AutoCompleteCall;
            this.Channels = Channels;
        }
        
        /// <summary>
        /// The unique ID of the agent.
        /// </summary>
        /// <value>The unique ID of the agent.</value>
        [DataMember(Name="agentId", EmitDefaultValue=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// The name of the place to use for the agent. You must provide either the place name or DN.
        /// </summary>
        /// <value>The name of the place to use for the agent. You must provide either the place name or DN.</value>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

        /// <summary>
        /// The DN (number) to use for the agent. You must provide either the place name or DN.
        /// </summary>
        /// <value>The DN (number) to use for the agent. You must provide either the place name or DN.</value>
        [DataMember(Name="dn", EmitDefaultValue=false)]
        public string Dn { get; set; }

        /// <summary>
        /// The queue name.
        /// </summary>
        /// <value>The queue name.</value>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }


        /// <summary>
        /// An optional dynamic phone number to use for the agent.
        /// </summary>
        /// <value>An optional dynamic phone number to use for the agent.</value>
        [DataMember(Name="dynamicPhoneNumber", EmitDefaultValue=false)]
        public string DynamicPhoneNumber { get; set; }

        /// <summary>
        /// Specifies if calls should automatically be completed for the session. Defaults to true if not provided.
        /// </summary>
        /// <value>Specifies if calls should automatically be completed for the session. Defaults to true if not provided.</value>
        [DataMember(Name="autoCompleteCall", EmitDefaultValue=false)]
        public bool? AutoCompleteCall { get; set; }

        /// <summary>
        /// An array of strings that correspond to the channels you want to activate.
        /// </summary>
        /// <value>An array of strings that correspond to the channels you want to activate.</value>
        [DataMember(Name="channels", EmitDefaultValue=false)]
        public List<string> Channels { get; set; }

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
            sb.Append("  AgentWorkMode: ").Append(AgentWorkMode).Append("\n");
            sb.Append("  DynamicPhoneNumber: ").Append(DynamicPhoneNumber).Append("\n");
            sb.Append("  AutoCompleteCall: ").Append(AutoCompleteCall).Append("\n");
            sb.Append("  Channels: ").Append(Channels).Append("\n");
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
                ) && 
                (
                    this.AgentWorkMode == other.AgentWorkMode ||
                    this.AgentWorkMode != null &&
                    this.AgentWorkMode.Equals(other.AgentWorkMode)
                ) && 
                (
                    this.DynamicPhoneNumber == other.DynamicPhoneNumber ||
                    this.DynamicPhoneNumber != null &&
                    this.DynamicPhoneNumber.Equals(other.DynamicPhoneNumber)
                ) && 
                (
                    this.AutoCompleteCall == other.AutoCompleteCall ||
                    this.AutoCompleteCall != null &&
                    this.AutoCompleteCall.Equals(other.AutoCompleteCall)
                ) && 
                (
                    this.Channels == other.Channels ||
                    this.Channels != null &&
                    this.Channels.SequenceEqual(other.Channels)
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
                if (this.AgentWorkMode != null)
                    hash = hash * 59 + this.AgentWorkMode.GetHashCode();
                if (this.DynamicPhoneNumber != null)
                    hash = hash * 59 + this.DynamicPhoneNumber.GetHashCode();
                if (this.AutoCompleteCall != null)
                    hash = hash * 59 + this.AutoCompleteCall.GetHashCode();
                if (this.Channels != null)
                    hash = hash * 59 + this.Channels.GetHashCode();
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
