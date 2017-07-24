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

namespace Genesys.Workspace.Model
{
    /// <summary>
    /// CurrentSessionDataUser
    /// </summary>
    [DataContract]
    public partial class CurrentSessionDataUser :  IEquatable<CurrentSessionDataUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionDataUser" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CurrentSessionDataUser() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentSessionDataUser" /> class.
        /// </summary>
        /// <param name="Dbid">Dbid.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="UserName">UserName (required).</param>
        /// <param name="EmployeeId">EmployeeId (required).</param>
        /// <param name="DefaultPlace">DefaultPlace.</param>
        /// <param name="AgentLogin">AgentLogin.</param>
        /// <param name="UserProperties">UserProperties.</param>
        /// <param name="ActiveSession">ActiveSession.</param>
        public CurrentSessionDataUser(int? Dbid = default(int?), string FirstName = default(string), string LastName = default(string), string UserName = default(string), string EmployeeId = default(string), string DefaultPlace = default(string), string AgentLogin = default(string), List<Kvpair> UserProperties = default(List<Kvpair>), CurrentSessionDataUserActiveSession ActiveSession = default(CurrentSessionDataUserActiveSession))
        {
            // to ensure "UserName" is required (not null)
            if (UserName == null)
            {
                throw new InvalidDataException("UserName is a required property for CurrentSessionDataUser and cannot be null");
            }
            else
            {
                this.UserName = UserName;
            }
            // to ensure "EmployeeId" is required (not null)
            if (EmployeeId == null)
            {
                throw new InvalidDataException("EmployeeId is a required property for CurrentSessionDataUser and cannot be null");
            }
            else
            {
                this.EmployeeId = EmployeeId;
            }
            this.Dbid = Dbid;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.DefaultPlace = DefaultPlace;
            this.AgentLogin = AgentLogin;
            this.UserProperties = UserProperties;
            this.ActiveSession = ActiveSession;
        }
        
        /// <summary>
        /// Gets or Sets Dbid
        /// </summary>
        [DataMember(Name="dbid", EmitDefaultValue=false)]
        public int? Dbid { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Gets or Sets EmployeeId
        /// </summary>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// Gets or Sets DefaultPlace
        /// </summary>
        [DataMember(Name="defaultPlace", EmitDefaultValue=false)]
        public string DefaultPlace { get; set; }
        /// <summary>
        /// Gets or Sets AgentLogin
        /// </summary>
        [DataMember(Name="agentLogin", EmitDefaultValue=false)]
        public string AgentLogin { get; set; }
        /// <summary>
        /// Gets or Sets UserProperties
        /// </summary>
        [DataMember(Name="userProperties", EmitDefaultValue=false)]
        public List<Kvpair> UserProperties { get; set; }
        /// <summary>
        /// Gets or Sets ActiveSession
        /// </summary>
        [DataMember(Name="activeSession", EmitDefaultValue=false)]
        public CurrentSessionDataUserActiveSession ActiveSession { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrentSessionDataUser {\n");
            sb.Append("  Dbid: ").Append(Dbid).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  DefaultPlace: ").Append(DefaultPlace).Append("\n");
            sb.Append("  AgentLogin: ").Append(AgentLogin).Append("\n");
            sb.Append("  UserProperties: ").Append(UserProperties).Append("\n");
            sb.Append("  ActiveSession: ").Append(ActiveSession).Append("\n");
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
            return this.Equals(obj as CurrentSessionDataUser);
        }

        /// <summary>
        /// Returns true if CurrentSessionDataUser instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrentSessionDataUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionDataUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Dbid == other.Dbid ||
                    this.Dbid != null &&
                    this.Dbid.Equals(other.Dbid)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.EmployeeId == other.EmployeeId ||
                    this.EmployeeId != null &&
                    this.EmployeeId.Equals(other.EmployeeId)
                ) && 
                (
                    this.DefaultPlace == other.DefaultPlace ||
                    this.DefaultPlace != null &&
                    this.DefaultPlace.Equals(other.DefaultPlace)
                ) && 
                (
                    this.AgentLogin == other.AgentLogin ||
                    this.AgentLogin != null &&
                    this.AgentLogin.Equals(other.AgentLogin)
                ) && 
                (
                    this.UserProperties == other.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(other.UserProperties)
                ) && 
                (
                    this.ActiveSession == other.ActiveSession ||
                    this.ActiveSession != null &&
                    this.ActiveSession.Equals(other.ActiveSession)
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
                if (this.Dbid != null)
                    hash = hash * 59 + this.Dbid.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.EmployeeId != null)
                    hash = hash * 59 + this.EmployeeId.GetHashCode();
                if (this.DefaultPlace != null)
                    hash = hash * 59 + this.DefaultPlace.GetHashCode();
                if (this.AgentLogin != null)
                    hash = hash * 59 + this.AgentLogin.GetHashCode();
                if (this.UserProperties != null)
                    hash = hash * 59 + this.UserProperties.GetHashCode();
                if (this.ActiveSession != null)
                    hash = hash * 59 + this.ActiveSession.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}