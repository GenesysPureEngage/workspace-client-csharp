/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.23.2279
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
    /// WorkbinsworkbinIdunsubscribeData
    /// </summary>
    [DataContract]
    public partial class WorkbinsworkbinIdunsubscribeData :  IEquatable<WorkbinsworkbinIdunsubscribeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinsworkbinIdunsubscribeData" /> class.
        /// </summary>
        /// <param name="OwnerId">Id of the owner of the workbin.</param>
        public WorkbinsworkbinIdunsubscribeData(string OwnerId = default(string))
        {
            this.OwnerId = OwnerId;
        }
        
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
            sb.Append("class WorkbinsworkbinIdunsubscribeData {\n");
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
            return this.Equals(input as WorkbinsworkbinIdunsubscribeData);
        }

        /// <summary>
        /// Returns true if WorkbinsworkbinIdunsubscribeData instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkbinsworkbinIdunsubscribeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkbinsworkbinIdunsubscribeData input)
        {
            if (input == null)
                return false;

            return 
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
