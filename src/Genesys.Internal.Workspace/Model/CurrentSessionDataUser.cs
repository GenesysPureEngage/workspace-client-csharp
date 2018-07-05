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
        /// <param name="Dbid">A unique identifier for the user..</param>
        /// <param name="FirstName">The user&#39;s first name..</param>
        /// <param name="LastName">The user&#39;s last name..</param>
        /// <param name="UserName">The username. (required).</param>
        /// <param name="EmployeeId">The unique employee ID. (required).</param>
        /// <param name="DefaultPlace">The user&#39;s default place..</param>
        /// <param name="AgentLogin">The agent&#39;s login ID..</param>
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
        /// A unique identifier for the user.
        /// </summary>
        /// <value>A unique identifier for the user.</value>
        [DataMember(Name="dbid", EmitDefaultValue=false)]
        public int? Dbid { get; set; }

        /// <summary>
        /// The user&#39;s first name.
        /// </summary>
        /// <value>The user&#39;s first name.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#39;s last name.
        /// </summary>
        /// <value>The user&#39;s last name.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The username.
        /// </summary>
        /// <value>The username.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The unique employee ID.
        /// </summary>
        /// <value>The unique employee ID.</value>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// The user&#39;s default place.
        /// </summary>
        /// <value>The user&#39;s default place.</value>
        [DataMember(Name="defaultPlace", EmitDefaultValue=false)]
        public string DefaultPlace { get; set; }

        /// <summary>
        /// The agent&#39;s login ID.
        /// </summary>
        /// <value>The agent&#39;s login ID.</value>
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CurrentSessionDataUser);
        }

        /// <summary>
        /// Returns true if CurrentSessionDataUser instances are equal
        /// </summary>
        /// <param name="input">Instance of CurrentSessionDataUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrentSessionDataUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dbid == input.Dbid ||
                    (this.Dbid != null &&
                    this.Dbid.Equals(input.Dbid))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.DefaultPlace == input.DefaultPlace ||
                    (this.DefaultPlace != null &&
                    this.DefaultPlace.Equals(input.DefaultPlace))
                ) && 
                (
                    this.AgentLogin == input.AgentLogin ||
                    (this.AgentLogin != null &&
                    this.AgentLogin.Equals(input.AgentLogin))
                ) && 
                (
                    this.UserProperties == input.UserProperties ||
                    this.UserProperties != null &&
                    this.UserProperties.SequenceEqual(input.UserProperties)
                ) && 
                (
                    this.ActiveSession == input.ActiveSession ||
                    (this.ActiveSession != null &&
                    this.ActiveSession.Equals(input.ActiveSession))
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
                if (this.Dbid != null)
                    hashCode = hashCode * 59 + this.Dbid.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.EmployeeId != null)
                    hashCode = hashCode * 59 + this.EmployeeId.GetHashCode();
                if (this.DefaultPlace != null)
                    hashCode = hashCode * 59 + this.DefaultPlace.GetHashCode();
                if (this.AgentLogin != null)
                    hashCode = hashCode * 59 + this.AgentLogin.GetHashCode();
                if (this.UserProperties != null)
                    hashCode = hashCode * 59 + this.UserProperties.GetHashCode();
                if (this.ActiveSession != null)
                    hashCode = hashCode * 59 + this.ActiveSession.GetHashCode();
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
