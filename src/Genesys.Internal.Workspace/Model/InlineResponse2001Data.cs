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
    /// InlineResponse2001Data
    /// </summary>
    [DataContract]
    public partial class InlineResponse2001Data :  IEquatable<InlineResponse2001Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse2001Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2001Data" /> class.
        /// </summary>
        /// <param name="Subscriptions">Subscriptions (required).</param>
        public InlineResponse2001Data(List<Subscription> Subscriptions = default(List<Subscription>))
        {
            // to ensure "Subscriptions" is required (not null)
            if (Subscriptions == null)
            {
                throw new InvalidDataException("Subscriptions is a required property for InlineResponse2001Data and cannot be null");
            }
            else
            {
                this.Subscriptions = Subscriptions;
            }
        }
        
        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name="subscriptions", EmitDefaultValue=false)]
        public List<Subscription> Subscriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2001Data {\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
            return this.Equals(input as InlineResponse2001Data);
        }

        /// <summary>
        /// Returns true if InlineResponse2001Data instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse2001Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2001Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
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
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
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
