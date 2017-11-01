﻿/* 
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
using SwaggerDateConverter = Genesys.Workspace.Internal.Client.SwaggerDateConverter;

namespace Genesys.Workspace.Internal.Model
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CurrentSessionData);
        }

        /// <summary>
        /// Returns true if CurrentSessionData instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrentSessionData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PendingLoginAsync == other.PendingLoginAsync ||
                    this.PendingLoginAsync != null &&
                    this.PendingLoginAsync.Equals(other.PendingLoginAsync)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.PendingLoginAsync != null)
                    hash = hash * 59 + this.PendingLoginAsync.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
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
