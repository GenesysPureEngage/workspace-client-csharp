/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.22.2269
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
    /// WorkbinsworkbinIdsubscribeData
    /// </summary>
    [DataContract]
    public partial class WorkbinsworkbinIdsubscribeData :  IEquatable<WorkbinsworkbinIdsubscribeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkbinsworkbinIdsubscribeData" /> class.
        /// </summary>
        /// <param name="OwnerId">Id of the owner of the workbin.</param>
        /// <param name="NotifyPropertyChanges">Default value false. If presente and set to true, Interaction Server will notify the subvscriber about property changes for interaction located in the workbin..</param>
        public WorkbinsworkbinIdsubscribeData(string OwnerId = default(string), bool? NotifyPropertyChanges = default(bool?))
        {
            this.OwnerId = OwnerId;
            this.NotifyPropertyChanges = NotifyPropertyChanges;
        }
        
        /// <summary>
        /// Id of the owner of the workbin
        /// </summary>
        /// <value>Id of the owner of the workbin</value>
        [DataMember(Name="ownerId", EmitDefaultValue=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Default value false. If presente and set to true, Interaction Server will notify the subvscriber about property changes for interaction located in the workbin.
        /// </summary>
        /// <value>Default value false. If presente and set to true, Interaction Server will notify the subvscriber about property changes for interaction located in the workbin.</value>
        [DataMember(Name="notifyPropertyChanges", EmitDefaultValue=false)]
        public bool? NotifyPropertyChanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkbinsworkbinIdsubscribeData {\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  NotifyPropertyChanges: ").Append(NotifyPropertyChanges).Append("\n");
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
            return this.Equals(input as WorkbinsworkbinIdsubscribeData);
        }

        /// <summary>
        /// Returns true if WorkbinsworkbinIdsubscribeData instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkbinsworkbinIdsubscribeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkbinsworkbinIdsubscribeData input)
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
                    this.NotifyPropertyChanges == input.NotifyPropertyChanges ||
                    (this.NotifyPropertyChanges != null &&
                    this.NotifyPropertyChanges.Equals(input.NotifyPropertyChanges))
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
                if (this.NotifyPropertyChanges != null)
                    hashCode = hashCode * 59 + this.NotifyPropertyChanges.GetHashCode();
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
