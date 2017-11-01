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
    /// CurrentSessionData
    /// </summary>
    [DataContract]
    public partial class CurrentSessionData :  IEquatable<CurrentSessionData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionData" /> class.
        /// </summary>
        /// <param name="PendingLoginAsync">PendingLoginAsync.</param>
        /// <param name="User">User.</param>
        public CurrentSessionData(CurrentSessionDataPendingloginasync PendingLoginAsync = default(CurrentSessionDataPendingloginasync), CurrentSessionDataUser User = default(CurrentSessionDataUser))
        {
            this.PendingLoginAsync = PendingLoginAsync;
            this.User = User;
        }
        
        /// <summary>
        /// Gets or Sets PendingLoginAsync
        /// </summary>
        [DataMember(Name="pending-login-async", EmitDefaultValue=false)]
        public CurrentSessionDataPendingloginasync PendingLoginAsync { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public CurrentSessionDataUser User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentSessionData {\n");
            sb.Append("  PendingLoginAsync: ").Append(PendingLoginAsync).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as CurrentSessionData);
        }

        /// <summary>
        /// Returns true if CurrentSessionData instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentSessionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PendingLoginAsync == input.PendingLoginAsync ||
                    (this.PendingLoginAsync != null &&
                    this.PendingLoginAsync.Equals(input.PendingLoginAsync))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                if (this.PendingLoginAsync != null)
                    hashCode = hashCode * 59 + this.PendingLoginAsync.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
