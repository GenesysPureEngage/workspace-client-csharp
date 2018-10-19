/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.24.2335
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
    /// VoicestartmonitoringData
    /// </summary>
    [DataContract]
    public partial class VoicestartmonitoringData :  IEquatable<VoicestartmonitoringData>, IValidatableObject
    {
        /// <summary>
        /// The monitoring mode.
        /// </summary>
        /// <value>The monitoring mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MonitoringModeEnum
        {
            
            /// <summary>
            /// Enum Mute for value: Mute
            /// </summary>
            [EnumMember(Value = "Mute")]
            Mute = 1,
            
            /// <summary>
            /// Enum Coach for value: Coach
            /// </summary>
            [EnumMember(Value = "Coach")]
            Coach = 2,
            
            /// <summary>
            /// Enum Connect for value: Connect
            /// </summary>
            [EnumMember(Value = "Connect")]
            Connect = 3
        }

        /// <summary>
        /// The monitoring mode.
        /// </summary>
        /// <value>The monitoring mode.</value>
        [DataMember(Name="monitoringMode", EmitDefaultValue=false)]
        public MonitoringModeEnum? MonitoringMode { get; set; }
        /// <summary>
        /// The monitoring call type.
        /// </summary>
        /// <value>The monitoring call type.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MonitoringNextCallTypeEnum
        {
            
            /// <summary>
            /// Enum OneCall for value: OneCall
            /// </summary>
            [EnumMember(Value = "OneCall")]
            OneCall = 1,
            
            /// <summary>
            /// Enum AllCalls for value: AllCalls
            /// </summary>
            [EnumMember(Value = "AllCalls")]
            AllCalls = 2
        }

        /// <summary>
        /// The monitoring call type.
        /// </summary>
        /// <value>The monitoring call type.</value>
        [DataMember(Name="monitoringNextCallType", EmitDefaultValue=false)]
        public MonitoringNextCallTypeEnum? MonitoringNextCallType { get; set; }
        /// <summary>
        /// The monitoring scope.
        /// </summary>
        /// <value>The monitoring scope.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MonitoringScopeEnum
        {
            
            /// <summary>
            /// Enum Call for value: Call
            /// </summary>
            [EnumMember(Value = "Call")]
            Call = 1,
            
            /// <summary>
            /// Enum Agent for value: Agent
            /// </summary>
            [EnumMember(Value = "Agent")]
            Agent = 2
        }

        /// <summary>
        /// The monitoring scope.
        /// </summary>
        /// <value>The monitoring scope.</value>
        [DataMember(Name="monitoringScope", EmitDefaultValue=false)]
        public MonitoringScopeEnum? MonitoringScope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicestartmonitoringData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicestartmonitoringData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicestartmonitoringData" /> class.
        /// </summary>
        /// <param name="PhoneNumberToMonitor">The phone number that should be monitored. (required).</param>
        /// <param name="MonitoringMode">The monitoring mode..</param>
        /// <param name="MonitoringNextCallType">The monitoring call type..</param>
        /// <param name="MonitoringScope">The monitoring scope..</param>
        /// <param name="Location">Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. This value is used by Workspace to set the location attribute for the corresponding T-Server requests. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string..</param>
        public VoicestartmonitoringData(string PhoneNumberToMonitor = default(string), MonitoringModeEnum? MonitoringMode = default(MonitoringModeEnum?), MonitoringNextCallTypeEnum? MonitoringNextCallType = default(MonitoringNextCallTypeEnum?), MonitoringScopeEnum? MonitoringScope = default(MonitoringScopeEnum?), string Location = default(string))
        {
            // to ensure "PhoneNumberToMonitor" is required (not null)
            if (PhoneNumberToMonitor == null)
            {
                throw new InvalidDataException("PhoneNumberToMonitor is a required property for VoicestartmonitoringData and cannot be null");
            }
            else
            {
                this.PhoneNumberToMonitor = PhoneNumberToMonitor;
            }
            this.MonitoringMode = MonitoringMode;
            this.MonitoringNextCallType = MonitoringNextCallType;
            this.MonitoringScope = MonitoringScope;
            this.Location = Location;
        }
        
        /// <summary>
        /// The phone number that should be monitored.
        /// </summary>
        /// <value>The phone number that should be monitored.</value>
        [DataMember(Name="phoneNumberToMonitor", EmitDefaultValue=false)]
        public string PhoneNumberToMonitor { get; set; }




        /// <summary>
        /// Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. This value is used by Workspace to set the location attribute for the corresponding T-Server requests. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string.
        /// </summary>
        /// <value>Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. This value is used by Workspace to set the location attribute for the corresponding T-Server requests. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicestartmonitoringData {\n");
            sb.Append("  PhoneNumberToMonitor: ").Append(PhoneNumberToMonitor).Append("\n");
            sb.Append("  MonitoringMode: ").Append(MonitoringMode).Append("\n");
            sb.Append("  MonitoringNextCallType: ").Append(MonitoringNextCallType).Append("\n");
            sb.Append("  MonitoringScope: ").Append(MonitoringScope).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as VoicestartmonitoringData);
        }

        /// <summary>
        /// Returns true if VoicestartmonitoringData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicestartmonitoringData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicestartmonitoringData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumberToMonitor == input.PhoneNumberToMonitor ||
                    (this.PhoneNumberToMonitor != null &&
                    this.PhoneNumberToMonitor.Equals(input.PhoneNumberToMonitor))
                ) && 
                (
                    this.MonitoringMode == input.MonitoringMode ||
                    (this.MonitoringMode != null &&
                    this.MonitoringMode.Equals(input.MonitoringMode))
                ) && 
                (
                    this.MonitoringNextCallType == input.MonitoringNextCallType ||
                    (this.MonitoringNextCallType != null &&
                    this.MonitoringNextCallType.Equals(input.MonitoringNextCallType))
                ) && 
                (
                    this.MonitoringScope == input.MonitoringScope ||
                    (this.MonitoringScope != null &&
                    this.MonitoringScope.Equals(input.MonitoringScope))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.PhoneNumberToMonitor != null)
                    hashCode = hashCode * 59 + this.PhoneNumberToMonitor.GetHashCode();
                if (this.MonitoringMode != null)
                    hashCode = hashCode * 59 + this.MonitoringMode.GetHashCode();
                if (this.MonitoringNextCallType != null)
                    hashCode = hashCode * 59 + this.MonitoringNextCallType.GetHashCode();
                if (this.MonitoringScope != null)
                    hashCode = hashCode * 59 + this.MonitoringScope.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
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
