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
    /// VoicecallsidsinglestepconferenceData
    /// </summary>
    [DataContract]
    public partial class VoicecallsidsinglestepconferenceData :  IEquatable<VoicecallsidsinglestepconferenceData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidsinglestepconferenceData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VoicecallsidsinglestepconferenceData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VoicecallsidsinglestepconferenceData" /> class.
        /// </summary>
        /// <param name="Destination">Number of the party to conference. (required).</param>
        /// <param name="Location">Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string..</param>
        /// <param name="UserData">A key/value pairs list of the user data that should be attached to the call..</param>
        /// <param name="Reasons">A key/value pairs list of a data structure that provides additional information associated with this action..</param>
        /// <param name="Extensions">A key/value pairs list of additional data..</param>
        public VoicecallsidsinglestepconferenceData(string Destination = default(string), string Location = default(string), List<Kvpair> UserData = default(List<Kvpair>), List<Kvpair> Reasons = default(List<Kvpair>), List<Kvpair> Extensions = default(List<Kvpair>))
        {
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for VoicecallsidsinglestepconferenceData and cannot be null");
            }
            else
            {
                this.Destination = Destination;
            }
            this.Location = Location;
            this.UserData = UserData;
            this.Reasons = Reasons;
            this.Extensions = Extensions;
        }
        
        /// <summary>
        /// Number of the party to conference.
        /// </summary>
        /// <value>Number of the party to conference.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string.
        /// </summary>
        /// <value>Name of the remote location in the form of &lt;SwitchName&gt; or &lt;T-ServerApplicationName&gt;@&lt;SwitchName&gt;. When there is no need to specify a T-Server for location, this parameter must have the value NULL, not an empty string.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// A key/value pairs list of the user data that should be attached to the call.
        /// </summary>
        /// <value>A key/value pairs list of the user data that should be attached to the call.</value>
        [DataMember(Name="userData", EmitDefaultValue=false)]
        public List<Kvpair> UserData { get; set; }

        /// <summary>
        /// A key/value pairs list of a data structure that provides additional information associated with this action.
        /// </summary>
        /// <value>A key/value pairs list of a data structure that provides additional information associated with this action.</value>
        [DataMember(Name="reasons", EmitDefaultValue=false)]
        public List<Kvpair> Reasons { get; set; }

        /// <summary>
        /// A key/value pairs list of additional data.
        /// </summary>
        /// <value>A key/value pairs list of additional data.</value>
        [DataMember(Name="extensions", EmitDefaultValue=false)]
        public List<Kvpair> Extensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoicecallsidsinglestepconferenceData {\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Reasons: ").Append(Reasons).Append("\n");
            sb.Append("  Extensions: ").Append(Extensions).Append("\n");
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
            return this.Equals(obj as VoicecallsidsinglestepconferenceData);
        }

        /// <summary>
        /// Returns true if VoicecallsidsinglestepconferenceData instances are equal
        /// </summary>
        /// <param name="other">Instance of VoicecallsidsinglestepconferenceData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoicecallsidsinglestepconferenceData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) && 
                (
                    this.UserData == other.UserData ||
                    this.UserData != null &&
                    this.UserData.SequenceEqual(other.UserData)
                ) && 
                (
                    this.Reasons == other.Reasons ||
                    this.Reasons != null &&
                    this.Reasons.SequenceEqual(other.Reasons)
                ) && 
                (
                    this.Extensions == other.Extensions ||
                    this.Extensions != null &&
                    this.Extensions.SequenceEqual(other.Extensions)
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
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                if (this.UserData != null)
                    hash = hash * 59 + this.UserData.GetHashCode();
                if (this.Reasons != null)
                    hash = hash * 59 + this.Reasons.GetHashCode();
                if (this.Extensions != null)
                    hash = hash * 59 + this.Extensions.GetHashCode();
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
