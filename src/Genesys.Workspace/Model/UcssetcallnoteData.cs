/* 
 * Workspace API
 *
 * Application API used by Workspace Web Edition
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UcssetcallnoteData);
        }

        /// <summary>
        /// Returns true if UcssetcallnoteData instances are equal
        /// </summary>
        /// <param name="other">Instance of UcssetcallnoteData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcssetcallnoteData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InteractionId == other.InteractionId ||
                    this.InteractionId != null &&
                    this.InteractionId.Equals(other.InteractionId)
                ) && 
                (
                    this.Note == other.Note ||
                    this.Note != null &&
                    this.Note.Equals(other.Note)
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
                if (this.InteractionId != null)
                    hash = hash * 59 + this.InteractionId.GetHashCode();
                if (this.Note != null)
                    hash = hash * 59 + this.Note.GetHashCode();
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
