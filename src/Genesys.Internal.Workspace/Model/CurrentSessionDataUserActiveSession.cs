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
    /// CurrentSessionDataUserActiveSession
    /// </summary>
    [DataContract]
    public partial class CurrentSessionDataUserActiveSession :  IEquatable<CurrentSessionDataUserActiveSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionDataUserActiveSession" /> class.
        /// </summary>
        /// <param name="AutoCompleteCall">Specifies if calls are automatically completed..</param>
        /// <param name="CurrentPlace">The user&#39;s current place..</param>
        /// <param name="Dn">Dn.</param>
        /// <param name="Calls">An array containing any active calls..</param>
        /// <param name="Media">Media.</param>
        /// <param name="Services">An array containing the current state of any initialized services.</param>
        public CurrentSessionDataUserActiveSession(bool? AutoCompleteCall = default(bool?), string CurrentPlace = default(string), Dn Dn = default(Dn), List<Call> Calls = default(List<Call>), Media Media = default(Media), List<Service> Services = default(List<Service>))
        {
            this.AutoCompleteCall = AutoCompleteCall;
            this.CurrentPlace = CurrentPlace;
            this.Dn = Dn;
            this.Calls = Calls;
            this.Media = Media;
            this.Services = Services;
        }
        
        /// <summary>
        /// Specifies if calls are automatically completed.
        /// </summary>
        /// <value>Specifies if calls are automatically completed.</value>
        [DataMember(Name="autoCompleteCall", EmitDefaultValue=false)]
        public bool? AutoCompleteCall { get; set; }

        /// <summary>
        /// The user&#39;s current place.
        /// </summary>
        /// <value>The user&#39;s current place.</value>
        [DataMember(Name="currentPlace", EmitDefaultValue=false)]
        public string CurrentPlace { get; set; }

        /// <summary>
        /// Gets or Sets Dn
        /// </summary>
        [DataMember(Name="dn", EmitDefaultValue=false)]
        public Dn Dn { get; set; }

        /// <summary>
        /// An array containing any active calls.
        /// </summary>
        /// <value>An array containing any active calls.</value>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public List<Call> Calls { get; set; }

        /// <summary>
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public Media Media { get; set; }

        /// <summary>
        /// An array containing the current state of any initialized services
        /// </summary>
        /// <value>An array containing the current state of any initialized services</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<Service> Services { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentSessionDataUserActiveSession {\n");
            sb.Append("  AutoCompleteCall: ").Append(AutoCompleteCall).Append("\n");
            sb.Append("  CurrentPlace: ").Append(CurrentPlace).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
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
            return this.Equals(input as CurrentSessionDataUserActiveSession);
        }

        /// <summary>
        /// Returns true if CurrentSessionDataUserActiveSession instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentSessionDataUserActiveSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionDataUserActiveSession input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoCompleteCall == input.AutoCompleteCall ||
                    (this.AutoCompleteCall != null &&
                    this.AutoCompleteCall.Equals(input.AutoCompleteCall))
                ) && 
                (
                    this.CurrentPlace == input.CurrentPlace ||
                    (this.CurrentPlace != null &&
                    this.CurrentPlace.Equals(input.CurrentPlace))
                ) && 
                (
                    this.Dn == input.Dn ||
                    (this.Dn != null &&
                    this.Dn.Equals(input.Dn))
                ) && 
                (
                    this.Calls == input.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(input.Calls)
                ) && 
                (
                    this.Media == input.Media ||
                    (this.Media != null &&
                    this.Media.Equals(input.Media))
                ) && 
                (
                    this.Services == input.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(input.Services)
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
                if (this.AutoCompleteCall != null)
                    hashCode = hashCode * 59 + this.AutoCompleteCall.GetHashCode();
                if (this.CurrentPlace != null)
                    hashCode = hashCode * 59 + this.CurrentPlace.GetHashCode();
                if (this.Dn != null)
                    hashCode = hashCode * 59 + this.Dn.GetHashCode();
                if (this.Calls != null)
                    hashCode = hashCode * 59 + this.Calls.GetHashCode();
                if (this.Media != null)
                    hashCode = hashCode * 59 + this.Media.GetHashCode();
                if (this.Services != null)
                    hashCode = hashCode * 59 + this.Services.GetHashCode();
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
