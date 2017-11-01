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
    /// StatisticValueForRegisterResponse
    /// </summary>
    [DataContract]
    public partial class StatisticValueForRegisterResponse :  IEquatable<StatisticValueForRegisterResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticValueForRegisterResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StatisticValueForRegisterResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StatisticValueForRegisterResponse" /> class.
        /// </summary>
        /// <param name="ObjectId">ID of the object to get the statistic for (required).</param>
        /// <param name="ObjectType">Type of the obejct to get the statistic for (required).</param>
        /// <param name="Name">Name of the statistic (required).</param>
        /// <param name="StatisticId">ID of the statistic (required).</param>
        public StatisticValueForRegisterResponse(string ObjectId = default(string), string ObjectType = default(string), string Name = default(string), string StatisticId = default(string))
        {
            // to ensure "ObjectId" is required (not null)
            if (ObjectId == null)
            {
                throw new InvalidDataException("ObjectId is a required property for StatisticValueForRegisterResponse and cannot be null");
            }
            else
            {
                this.ObjectId = ObjectId;
            }
            // to ensure "ObjectType" is required (not null)
            if (ObjectType == null)
            {
                throw new InvalidDataException("ObjectType is a required property for StatisticValueForRegisterResponse and cannot be null");
            }
            else
            {
                this.ObjectType = ObjectType;
            }
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for StatisticValueForRegisterResponse and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "StatisticId" is required (not null)
            if (StatisticId == null)
            {
                throw new InvalidDataException("StatisticId is a required property for StatisticValueForRegisterResponse and cannot be null");
            }
            else
            {
                this.StatisticId = StatisticId;
            }
        }
        
        /// <summary>
        /// ID of the object to get the statistic for
        /// </summary>
        /// <value>ID of the object to get the statistic for</value>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Type of the obejct to get the statistic for
        /// </summary>
        /// <value>Type of the obejct to get the statistic for</value>
        [DataMember(Name="objectType", EmitDefaultValue=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// Name of the statistic
        /// </summary>
        /// <value>Name of the statistic</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// ID of the statistic
        /// </summary>
        /// <value>ID of the statistic</value>
        [DataMember(Name="statisticId", EmitDefaultValue=false)]
        public string StatisticId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatisticValueForRegisterResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StatisticId: ").Append(StatisticId).Append("\n");
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
            return this.Equals(input as StatisticValueForRegisterResponse);
        }

        /// <summary>
        /// Returns true if StatisticValueForRegisterResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatisticValueForRegisterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatisticValueForRegisterResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StatisticId == input.StatisticId ||
                    (this.StatisticId != null &&
                    this.StatisticId.Equals(input.StatisticId))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StatisticId != null)
                    hashCode = hashCode * 59 + this.StatisticId.GetHashCode();
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
