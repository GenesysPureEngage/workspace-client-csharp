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
    /// CurrentSessionDataUserActiveSession
    /// </summary>
    [DataContract]
    public partial class CurrentSessionDataUserActiveSession :  IEquatable<CurrentSessionDataUserActiveSession>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionDataUserActiveSession" /> class.
        /// </summary>
        /// <param name="AutoCompleteCall">AutoCompleteCall.</param>
        /// <param name="CurrentPlace">CurrentPlace.</param>
        /// <param name="Dn">Dn.</param>
        /// <param name="Calls">An array containing any active calls..</param>
        /// <param name="Media">Media.</param>
        public CurrentSessionDataUserActiveSession(bool? AutoCompleteCall = default(bool?), string CurrentPlace = default(string), Dn Dn = default(Dn), List<Call> Calls = default(List<Call>), Media Media = default(Media))
        {
            this.AutoCompleteCall = AutoCompleteCall;
            this.CurrentPlace = CurrentPlace;
            this.Dn = Dn;
            this.Calls = Calls;
            this.Media = Media;
        }
        
        /// <summary>
        /// Gets or Sets AutoCompleteCall
        /// </summary>
        [DataMember(Name="autoCompleteCall", EmitDefaultValue=false)]
        public bool? AutoCompleteCall { get; set; }

        /// <summary>
        /// Gets or Sets CurrentPlace
        /// </summary>
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
            return this.Equals(obj as CurrentSessionDataUserActiveSession);
        }

        /// <summary>
        /// Returns true if CurrentSessionDataUserActiveSession instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrentSessionDataUserActiveSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionDataUserActiveSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AutoCompleteCall == other.AutoCompleteCall ||
                    this.AutoCompleteCall != null &&
                    this.AutoCompleteCall.Equals(other.AutoCompleteCall)
                ) && 
                (
                    this.CurrentPlace == other.CurrentPlace ||
                    this.CurrentPlace != null &&
                    this.CurrentPlace.Equals(other.CurrentPlace)
                ) && 
                (
                    this.Dn == other.Dn ||
                    this.Dn != null &&
                    this.Dn.Equals(other.Dn)
                ) && 
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(other.Calls)
                ) && 
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
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
                if (this.AutoCompleteCall != null)
                    hash = hash * 59 + this.AutoCompleteCall.GetHashCode();
                if (this.CurrentPlace != null)
                    hash = hash * 59 + this.CurrentPlace.GetHashCode();
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
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
