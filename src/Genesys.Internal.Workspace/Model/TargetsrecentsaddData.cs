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
    /// TargetsrecentsaddData
    /// </summary>
    [DataContract]
    public partial class TargetsrecentsaddData :  IEquatable<TargetsrecentsaddData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetsrecentsaddData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TargetsrecentsaddData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetsrecentsaddData" /> class.
        /// </summary>
        /// <param name="Target">Target (required).</param>
        /// <param name="RecentInformation">RecentInformation (required).</param>
        public TargetsrecentsaddData(TargetInformation Target = default(TargetInformation), RecentData RecentInformation = default(RecentData))
        {
            // to ensure "Target" is required (not null)
            if (Target == null)
            {
                throw new InvalidDataException("Target is a required property for TargetsrecentsaddData and cannot be null");
            }
            else
            {
                this.Target = Target;
            }
            // to ensure "RecentInformation" is required (not null)
            if (RecentInformation == null)
            {
                throw new InvalidDataException("RecentInformation is a required property for TargetsrecentsaddData and cannot be null");
            }
            else
            {
                this.RecentInformation = RecentInformation;
            }
        }
        
        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name="target", EmitDefaultValue=false)]
        public TargetInformation Target { get; set; }

        /// <summary>
        /// Gets or Sets RecentInformation
        /// </summary>
        [DataMember(Name="recentInformation", EmitDefaultValue=false)]
        public RecentData RecentInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TargetsrecentsaddData {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  RecentInformation: ").Append(RecentInformation).Append("\n");
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
            return this.Equals(input as TargetsrecentsaddData);
        }

        /// <summary>
        /// Returns true if TargetsrecentsaddData instances are equal
        /// </summary>
        /// <param name="input">Instance of TargetsrecentsaddData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TargetsrecentsaddData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
                ) && 
                (
                    this.RecentInformation == input.RecentInformation ||
                    (this.RecentInformation != null &&
                    this.RecentInformation.Equals(input.RecentInformation))
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
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
                if (this.RecentInformation != null)
                    hashCode = hashCode * 59 + this.RecentInformation.GetHashCode();
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
