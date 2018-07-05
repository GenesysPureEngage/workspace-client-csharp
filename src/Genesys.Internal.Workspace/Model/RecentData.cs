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
    /// This includes the media channel where the target was recently used and the timestamp for when the target was used.
    /// </summary>
    [DataContract]
    public partial class RecentData :  IEquatable<RecentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentData" /> class.
        /// </summary>
        /// <param name="Media">The media channel where the target was recently used..</param>
        /// <param name="TimeStamp">The date and time when the target was used..</param>
        public RecentData(string Media = default(string), decimal? TimeStamp = default(decimal?))
        {
            this.Media = Media;
            this.TimeStamp = TimeStamp;
        }
        
        /// <summary>
        /// The media channel where the target was recently used.
        /// </summary>
        /// <value>The media channel where the target was recently used.</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public string Media { get; set; }

        /// <summary>
        /// The date and time when the target was used.
        /// </summary>
        /// <value>The date and time when the target was used.</value>
        [DataMember(Name="timeStamp", EmitDefaultValue=false)]
        public decimal? TimeStamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecentData {\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
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
            return this.Equals(obj as RecentData);
        }

        /// <summary>
        /// Returns true if RecentData instances are equal
        /// </summary>
        /// <param name="other">Instance of RecentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecentData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) && 
                (
                    this.TimeStamp == other.TimeStamp ||
                    this.TimeStamp != null &&
                    this.TimeStamp.Equals(other.TimeStamp)
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
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
                if (this.TimeStamp != null)
                    hash = hash * 59 + this.TimeStamp.GetHashCode();
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
