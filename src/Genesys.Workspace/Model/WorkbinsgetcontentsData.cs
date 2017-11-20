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
    /// WorkbinsgetcontentsData
    /// </summary>
    [DataContract]
    public partial class WorkbinsgetcontentsData :  IEquatable<WorkbinsgetcontentsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinsgetcontentsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkbinsgetcontentsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinsgetcontentsData" /> class.
        /// </summary>
        /// <param name="WorkbinIds">comma-separated list of Workbin Ids (required).</param>
        /// <param name="OwnerId">Id of the owner of the workbin.</param>
        public WorkbinsgetcontentsData(string WorkbinIds = default(string), string OwnerId = default(string))
        {
            // to ensure "WorkbinIds" is required (not null)
            if (WorkbinIds == null)
            {
                throw new InvalidDataException("WorkbinIds is a required property for WorkbinsgetcontentsData and cannot be null");
            }
            else
            {
                this.WorkbinIds = WorkbinIds;
            }
            this.OwnerId = OwnerId;
        }
        
        /// <summary>
        /// comma-separated list of Workbin Ids
        /// </summary>
        /// <value>comma-separated list of Workbin Ids</value>
        [DataMember(Name="workbinIds", EmitDefaultValue=false)]
        public string WorkbinIds { get; set; }

        /// <summary>
        /// Id of the owner of the workbin
        /// </summary>
        /// <value>Id of the owner of the workbin</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkbinsgetcontentsData {\n");
            sb.Append("  WorkbinIds: ").Append(WorkbinIds).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
            return this.Equals(input as WorkbinsgetcontentsData);
        }

        /// <summary>
        /// Returns true if WorkbinsgetcontentsData instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkbinsgetcontentsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkbinsgetcontentsData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkbinIds == input.WorkbinIds ||
                    (this.WorkbinIds != null &&
                    this.WorkbinIds.Equals(input.WorkbinIds))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
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
                if (this.WorkbinIds != null)
                    hashCode = hashCode * 59 + this.WorkbinIds.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
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