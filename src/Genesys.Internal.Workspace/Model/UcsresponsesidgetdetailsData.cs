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
    /// UcsresponsesidgetdetailsData
    /// </summary>
    [DataContract]
    public partial class UcsresponsesidgetdetailsData :  IEquatable<UcsresponsesidgetdetailsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsresponsesidgetdetailsData" /> class.
        /// </summary>
        /// <param name="Version">Standard Response version number.</param>
        /// <param name="Attachments">true to get attachments.</param>
        public UcsresponsesidgetdetailsData(decimal? Version = default(decimal?), bool? Attachments = default(bool?))
        {
            this.Version = Version;
            this.Attachments = Attachments;
        }
        
        /// <summary>
        /// Standard Response version number
        /// </summary>
        /// <value>Standard Response version number</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public decimal? Version { get; set; }

        /// <summary>
        /// true to get attachments
        /// </summary>
        /// <value>true to get attachments</value>
        [DataMember(Name="attachments", EmitDefaultValue=false)]
        public bool? Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsresponsesidgetdetailsData {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as UcsresponsesidgetdetailsData);
        }

        /// <summary>
        /// Returns true if UcsresponsesidgetdetailsData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcsresponsesidgetdetailsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsresponsesidgetdetailsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    (this.Attachments != null &&
                    this.Attachments.Equals(input.Attachments))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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