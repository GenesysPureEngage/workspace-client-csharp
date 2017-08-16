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
    /// Target
    /// </summary>
    [DataContract]
    public partial class Target :  IEquatable<Target>, IValidatableObject
    {
        /// <summary>
        /// The type of the target - agent, agent-group, acd-queue, route-point, skill or custom-contact.
        /// </summary>
        /// <value>The type of the target - agent, agent-group, acd-queue, route-point, skill or custom-contact.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Agent for "agent"
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent,
            
            /// <summary>
            /// Enum Agentgroup for "agent-group"
            /// </summary>
            [EnumMember(Value = "agent-group")]
            Agentgroup,
            
            /// <summary>
            /// Enum Acdqueue for "acd-queue"
            /// </summary>
            [EnumMember(Value = "acd-queue")]
            Acdqueue,
            
            /// <summary>
            /// Enum Routepoint for "route-point"
            /// </summary>
            [EnumMember(Value = "route-point")]
            Routepoint,
            
            /// <summary>
            /// Enum Skill for "skill"
            /// </summary>
            [EnumMember(Value = "skill")]
            Skill,
            
            /// <summary>
            /// Enum Customcontact for "custom-contact"
            /// </summary>
            [EnumMember(Value = "custom-contact")]
            Customcontact
        }

        /// <summary>
        /// The type of the target - agent, agent-group, acd-queue, route-point, skill or custom-contact.
        /// </summary>
        /// <value>The type of the target - agent, agent-group, acd-queue, route-point, skill or custom-contact.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Target" /> class.
        /// </summary>
        /// <param name="UserName">Username - only applicable to agents..</param>
        /// <param name="EmployeeID">Employee id - only applicable to agents..</param>
        /// <param name="FirstName">First name - only applicable to agents..</param>
        /// <param name="DBID">DBID of the object.</param>
        /// <param name="SwitchName">Only applicable to acd-queue and route-point.</param>
        /// <param name="Number">Only applicable to acd-queue and route-point.</param>
        /// <param name="LastName">Last name - only applicable to agents..</param>
        /// <param name="Type">The type of the target - agent, agent-group, acd-queue, route-point, skill or custom-contact..</param>
        /// <param name="Availability">The structure depends on the target type. For agents, availability includes channel details. For acd-queues and route-points, waiting calls. For agent-groups, the number of ready agents..</param>
        /// <param name="Name">For agents firstname and lastname (or username if neither is defined), for other types the name field is used..</param>
        public Target(string UserName = default(string), string EmployeeID = default(string), string FirstName = default(string), int? DBID = default(int?), string SwitchName = default(string), string Number = default(string), string LastName = default(string), TypeEnum? Type = default(TypeEnum?), Object Availability = default(Object), string Name = default(string))
        {
            this.UserName = UserName;
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.DBID = DBID;
            this.SwitchName = SwitchName;
            this.Number = Number;
            this.LastName = LastName;
            this.Type = Type;
            this.Availability = Availability;
            this.Name = Name;
        }
        
        /// <summary>
        /// Username - only applicable to agents.
        /// </summary>
        /// <value>Username - only applicable to agents.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Employee id - only applicable to agents.
        /// </summary>
        /// <value>Employee id - only applicable to agents.</value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public string EmployeeID { get; set; }

        /// <summary>
        /// First name - only applicable to agents.
        /// </summary>
        /// <value>First name - only applicable to agents.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// DBID of the object
        /// </summary>
        /// <value>DBID of the object</value>
        [DataMember(Name="DBID", EmitDefaultValue=false)]
        public int? DBID { get; set; }

        /// <summary>
        /// Only applicable to acd-queue and route-point
        /// </summary>
        /// <value>Only applicable to acd-queue and route-point</value>
        [DataMember(Name="switchName", EmitDefaultValue=false)]
        public string SwitchName { get; set; }

        /// <summary>
        /// Only applicable to acd-queue and route-point
        /// </summary>
        /// <value>Only applicable to acd-queue and route-point</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Last name - only applicable to agents.
        /// </summary>
        /// <value>Last name - only applicable to agents.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }


        /// <summary>
        /// The structure depends on the target type. For agents, availability includes channel details. For acd-queues and route-points, waiting calls. For agent-groups, the number of ready agents.
        /// </summary>
        /// <value>The structure depends on the target type. For agents, availability includes channel details. For acd-queues and route-points, waiting calls. For agent-groups, the number of ready agents.</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public Object Availability { get; set; }

        /// <summary>
        /// For agents firstname and lastname (or username if neither is defined), for other types the name field is used.
        /// </summary>
        /// <value>For agents firstname and lastname (or username if neither is defined), for other types the name field is used.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Target {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  DBID: ").Append(DBID).Append("\n");
            sb.Append("  SwitchName: ").Append(SwitchName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as Target);
        }

        /// <summary>
        /// Returns true if Target instances are equal
        /// </summary>
        /// <param name="other">Instance of Target to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Target other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
                ) && 
                (
                    this.EmployeeID == other.EmployeeID ||
                    this.EmployeeID != null &&
                    this.EmployeeID.Equals(other.EmployeeID)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.DBID == other.DBID ||
                    this.DBID != null &&
                    this.DBID.Equals(other.DBID)
                ) && 
                (
                    this.SwitchName == other.SwitchName ||
                    this.SwitchName != null &&
                    this.SwitchName.Equals(other.SwitchName)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Availability == other.Availability ||
                    this.Availability != null &&
                    this.Availability.Equals(other.Availability)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                if (this.EmployeeID != null)
                    hash = hash * 59 + this.EmployeeID.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.DBID != null)
                    hash = hash * 59 + this.DBID.GetHashCode();
                if (this.SwitchName != null)
                    hash = hash * 59 + this.SwitchName.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Availability != null)
                    hash = hash * 59 + this.Availability.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
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
