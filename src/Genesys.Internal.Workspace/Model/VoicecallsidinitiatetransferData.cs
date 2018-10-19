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
    /// VoicecallsidinitiatetransferData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidinitiatetransferData :  IEquatable<VoicecallsidinitiatetransferData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidinitiatetransferData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsidinitiatetransferData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidinitiatetransferData" /> class.
        /// </summary>
        /// <param name="Destination">The destination where the call will be transferred. (required).</param>
        /// <param name="Location">Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. This value is used by Workspace to set the location attribute for the corresponding T-Server requests. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string..</param>
        /// <param name="UserData">Key/value data to include with the call..</param>
        /// <param name="Reasons">Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons)..</param>
        /// <param name="Extensions">Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions)..</param>
        /// <param name="OutboundCallerId">The caller ID information to display on the destination party&#39;s phone. The value should be set as CPNDigits. For more information about caller ID, see the [*SIP Server Deployment Guide*](https://docs.genesys.com/Documentation/SIPS)..</param>
        public VoicecallsidinitiatetransferData(string Destination = default(string), string Location = default(string), List<Kvpair> UserData = default(List<Kvpair>), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>), string OutboundCallerId = default(string))
        {
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for VoicecallsidinitiatetransferData and cannot be null");
            }
            else
            {
                this.Destination = Destination;
            }
            this.Location = Location;
            this.UserData = UserData;
            this.Reasons = Reasons;
            this.Extensions = Extensions;
            this.OutboundCallerId = OutboundCallerId;
        }
        
        /// <summary>
        /// The destination where the call will be transferred.
        /// </summary>
        /// <value>The destination where the call will be transferred.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. This value is used by Workspace to set the location attribute for the corresponding T-Server requests. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string.
        /// </summary>
        /// <value>Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. This value is used by Workspace to set the location attribute for the corresponding T-Server requests. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Key/value data to include with the call.
        /// </summary>
        /// <value>Key/value data to include with the call.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }

        /// <summary>
        /// Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons).
        /// </summary>
        /// <value>Information on causes for, and results of, actions taken by the user of the current DN. For details about reasons, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Reasons).</value>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public List<Kvpair> Reasons { get; set; }

        /// <summary>
        /// Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions).
        /// </summary>
        /// <value>Media device/hardware reason codes and similar information. For details about extensions, refer to the [*Genesys Events and Models Reference Manual*](https://docs.genesys.com/Documentation/System/Current/GenEM/Extensions).</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public List<Kvpair> Extensions { get; set; }

        /// <summary>
        /// The caller ID information to display on the destination party&#39;s phone. The value should be set as CPNDigits. For more information about caller ID, see the [*SIP Server Deployment Guide*](https://docs.genesys.com/Documentation/SIPS).
        /// </summary>
        /// <value>The caller ID information to display on the destination party&#39;s phone. The value should be set as CPNDigits. For more information about caller ID, see the [*SIP Server Deployment Guide*](https://docs.genesys.com/Documentation/SIPS).</value>
        [DataMember(Name="outboundCallerId", EmitDefaultValue=false)]
        public string OutboundCallerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicecallsidinitiatetransferData {\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Reasons: ").Append(Reasons).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
            sb.Append("  OutboundCallerId: ").Append(OutboundCallerId).Append("\n");
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
            return this.Equals(input as VoicecallsidinitiatetransferData);
        }

        /// <summary>
        /// Returns true if VoicecallsidinitiatetransferData instances are equal
        /// </summary>
        /// <param name="input">Instance of VoicecallsidinitiatetransferData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidinitiatetransferData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.UserData == input.UserData ||
                    this.UserData != null &&
                    this.UserData.SequenceEqual(input.UserData)
                ) && 
                (
                    this.Reasons == input.Reasons ||
                    this.Reasons != null &&
                    this.Reasons.SequenceEqual(input.Reasons)
                ) && 
                (
                    this.Extensions == input.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(input.Extensions)
                ) && 
                (
                    this.OutboundCallerId == input.OutboundCallerId ||
                    (this.OutboundCallerId != null &&
                    this.OutboundCallerId.Equals(input.OutboundCallerId))
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
                if (this.Destination != null)
                    hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.UserData != null)
                    hashCode = hashCode * 59 + this.UserData.GetHashCode();
                if (this.Reasons != null)
                    hashCode = hashCode * 59 + this.Reasons.GetHashCode();
                if (this.Extensions != null)
                    hashCode = hashCode * 59 + this.Extensions.GetHashCode();
                if (this.OutboundCallerId != null)
                    hashCode = hashCode * 59 + this.OutboundCallerId.GetHashCode();
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
