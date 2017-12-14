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
    /// UcssetcallnoteData
    /// </summary>
    [DataContract]
    public partial class UcssetcallnoteData :  IEquatable<UcssetcallnoteData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcssetcallnoteData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UcssetcallnoteData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UcssetcallnoteData" /> class.
        /// </summary>
        /// <param name="InteractionId">The id of the interaction (required).</param>
        /// <param name="Note">The note to be set (required).</param>
        public UcssetcallnoteData(string InteractionId = default(string), string Note = default(string))
        {
            // to ensure "InteractionId" is required (not null)
            if (InteractionId == null)
            {
                throw new InvalidDataException("InteractionId is a required property for UcssetcallnoteData and cannot be null");
            }
            else
            {
                this.InteractionId = InteractionId;
            }
            // to ensure "Note" is required (not null)
            if (Note == null)
            {
                throw new InvalidDataException("Note is a required property for UcssetcallnoteData and cannot be null");
            }
            else
            {
                this.Note = Note;
            }
        }
        
        /// <summary>
        /// The id of the interaction
        /// </summary>
        /// <value>The id of the interaction</value>
        [DataMember(Name="interactionId", EmitDefaultValue=false)]
        public string InteractionId { get; set; }

        /// <summary>
        /// The note to be set
        /// </summary>
        /// <value>The note to be set</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcssetcallnoteData {\n");
            sb.Append("  InteractionId: ").Append(InteractionId).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
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
            return this.Equals(input as UcssetcallnoteData);
        }

        /// <summary>
        /// Returns true if UcssetcallnoteData instances are equal
        /// </summary>
        /// <param name="input">Instance of UcssetcallnoteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcssetcallnoteData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InteractionId == input.InteractionId ||
                    (this.InteractionId != null &&
                    this.InteractionId.Equals(input.InteractionId))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
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
                if (this.InteractionId != null)
                    hashCode = hashCode * 59 + this.InteractionId.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
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
