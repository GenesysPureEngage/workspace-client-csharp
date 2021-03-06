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
    /// MediamanagementmovetoqueueData
    /// </summary>
    [DataContract]
    public partial class MediamanagementmovetoqueueData :  IEquatable<MediamanagementmovetoqueueData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamanagementmovetoqueueData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MediamanagementmovetoqueueData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamanagementmovetoqueueData" /> class.
        /// </summary>
        /// <param name="Queue">The destination queue. (required).</param>
        /// <param name="Interactions">List of interactions to move. (required).</param>
        public MediamanagementmovetoqueueData(string Queue = default(string), List<string> Interactions = default(List<string>))
        {
            // to ensure "Queue" is required (not null)
            if (Queue == null)
            {
                throw new InvalidDataException("Queue is a required property for MediamanagementmovetoqueueData and cannot be null");
            }
            else
            {
                this.Queue = Queue;
            }
            // to ensure "Interactions" is required (not null)
            if (Interactions == null)
            {
                throw new InvalidDataException("Interactions is a required property for MediamanagementmovetoqueueData and cannot be null");
            }
            else
            {
                this.Interactions = Interactions;
            }
        }
        
        /// <summary>
        /// The destination queue.
        /// </summary>
        /// <value>The destination queue.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public string Queue { get; set; }

        /// <summary>
        /// List of interactions to move.
        /// </summary>
        /// <value>List of interactions to move.</value>
        [DataMember(Name="interactions", EmitDefaultValue=false)]
        public List<string> Interactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamanagementmovetoqueueData {\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
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
            return this.Equals(input as MediamanagementmovetoqueueData);
        }

        /// <summary>
        /// Returns true if MediamanagementmovetoqueueData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamanagementmovetoqueueData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamanagementmovetoqueueData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Queue == input.Queue ||
                    (this.Queue != null &&
                    this.Queue.Equals(input.Queue))
                ) && 
                (
                    this.Interactions == input.Interactions ||
                    this.Interactions != null &&
                    this.Interactions.SequenceEqual(input.Interactions)
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
                if (this.Queue != null)
                    hashCode = hashCode * 59 + this.Queue.GetHashCode();
                if (this.Interactions != null)
                    hashCode = hashCode * 59 + this.Interactions.GetHashCode();
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
