﻿/* 
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
using SwaggerDateConverter = Genesys.Workspace.Internal.Client.SwaggerDateConverter;

namespace Genesys.Workspace.Internal.Model
{
    /// <summary>
    /// ConfigResponseDataBusinessAttributes
    /// </summary>
    [DataContract]
    public partial class ConfigResponseDataBusinessAttributes :  IEquatable<ConfigResponseDataBusinessAttributes>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigResponseDataBusinessAttributes" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="DisplayName">DisplayName.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Values">Values.</param>
        /// <param name="UserProperties">UserProperties.</param>
        public ConfigResponseDataBusinessAttributes(string Name = default(string), string DisplayName = default(string), string Description = default(string), List<ConfigResponseDataValues> Values = default(List<ConfigResponseDataValues>), List<Kvpair> UserProperties = default(List<Kvpair>))
        {
            this.Name = Name;
            this.DisplayName = DisplayName;
            this.Description = Description;
            this.Values = Values;
            this.UserProperties = UserProperties;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<ConfigResponseDataValues> Values { get; set; }

        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>
        [DataMember(Name="userProperties", EmitDefaultValue=false)]
        public List<Kvpair> UserProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigResponseDataBusinessAttributes {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
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
            return this.Equals(obj as ConfigResponseDataBusinessAttributes);
        }

        /// <summary>
        /// Returns true if ConfigResponseDataBusinessAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigResponseDataBusinessAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigResponseDataBusinessAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) && 
                (
                    this.UserProperties == other.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(other.UserProperties)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                if (this.UserProperties != null)
                    hash = hash * 59 + this.UserProperties.GetHashCode();
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
