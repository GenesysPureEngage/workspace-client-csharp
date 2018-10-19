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
    /// MediamediatypeinteractionsidpullData
    /// </summary>
    [DataContract]
    public partial class MediamediatypeinteractionsidpullData :  IEquatable<MediamediatypeinteractionsidpullData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamediatypeinteractionsidpullData" /> class.
        /// </summary>
        /// <param name="OwnerId">Id of the owner of the workbin.</param>
        /// <param name="WorkbinId">Id of the workbin.</param>
        /// <param name="Reason">Reason.</param>
        /// <param name="Extension">A key/value pairs list of additional data..</param>
        public MediamediatypeinteractionsidpullData(string OwnerId = default(string), string WorkbinId = default(string), IxnReasonCode Reason = default(IxnReasonCode), List<Kvpair> Extension = default(List<Kvpair>))
        {
            this.OwnerId = OwnerId;
            this.WorkbinId = WorkbinId;
            this.Reason = Reason;
            this.Extension = Extension;
        }
        
        /// <summary>
        /// Id of the owner of the workbin
        /// </summary>
        /// <value>Id of the owner of the workbin</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Id of the workbin
        /// </summary>
        /// <value>Id of the workbin</value>
        [DataMember(Name="workbinId", EmitDefaultValue=false)]
        public string WorkbinId { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public IxnReasonCode Reason { get; set; }

        /// <summary>
        /// A key/value pairs list of additional data.
        /// </summary>
        /// <value>A key/value pairs list of additional data.</value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public List<Kvpair> Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamediatypeinteractionsidpullData {\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  WorkbinId: ").Append(WorkbinId).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
            return this.Equals(input as MediamediatypeinteractionsidpullData);
        }

        /// <summary>
        /// Returns true if MediamediatypeinteractionsidpullData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamediatypeinteractionsidpullData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamediatypeinteractionsidpullData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.WorkbinId == input.WorkbinId ||
                    (this.WorkbinId != null &&
                    this.WorkbinId.Equals(input.WorkbinId))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Extension == input.Extension ||
                    this.Extension != null &&
                    this.Extension.SequenceEqual(input.Extension)
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
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.WorkbinId != null)
                    hashCode = hashCode * 59 + this.WorkbinId.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.Extension != null)
                    hashCode = hashCode * 59 + this.Extension.GetHashCode();
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
