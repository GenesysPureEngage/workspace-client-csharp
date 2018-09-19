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
    /// Target
    /// </summary>
    [DataContract]
    public partial class Target :  IEquatable<Target>, IValidatableObject
    {
        /// <summary>
        /// The type of target.
        /// </summary>
        /// <value>The type of target.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Agent for value: agent
            /// </summary>
            [EnumMember(Value = "agent")]
            Agent = 1,
            
            /// <summary>
            /// Enum AgentGroup for value: agent-group
            /// </summary>
            [EnumMember(Value = "agent-group")]
            AgentGroup = 2,
            
            /// <summary>
            /// Enum AcdQueue for value: acd-queue
            /// </summary>
            [EnumMember(Value = "acd-queue")]
            AcdQueue = 3,
            
            /// <summary>
            /// Enum RoutePoint for value: route-point
            /// </summary>
            [EnumMember(Value = "route-point")]
            RoutePoint = 4,
            
            /// <summary>
            /// Enum Skill for value: skill
            /// </summary>
            [EnumMember(Value = "skill")]
            Skill = 5,
            
            /// <summary>
            /// Enum CustomContact for value: custom-contact
            /// </summary>
            [EnumMember(Value = "custom-contact")]
            CustomContact = 6,
            
            /// <summary>
            /// Enum Contact for value: contact
            /// </summary>
            [EnumMember(Value = "contact")]
            Contact = 7
        }

        /// <summary>
        /// The type of target.
        /// </summary>
        /// <value>The type of target.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Target" /> class.
        /// </summary>
        /// <param name="DBID">The unique database identifier..</param>
        /// <param name="Name">If the target is not **agent**, this property has a value. For example, the name of the agent group. If the target is **agent**, then the firstName and lastName fields are returned instead (or the username if neither is defined)..</param>
        /// <param name="Type">The type of target..</param>
        /// <param name="FirstName">The agent&#39;s first name..</param>
        /// <param name="LastName">The agent&#39;s last name..</param>
        /// <param name="EmployeeId">The agent&#39;s employee ID..</param>
        /// <param name="UserName">The agent&#39;s username..</param>
        /// <param name="Number">The number associated with either an **acd-queue** or a **route-point**..</param>
        /// <param name="SwitchName">The name of the switch associated with either an **acd-queue** or a **route-point**..</param>
        /// <param name="Availability">The structure of this object depends on the target type. For **agent**, availability includes channel details. For **acd-queue** and **route-point**, it includes waiting calls. For **agent-groups**, availability includes the number of ready agents..</param>
        public Target(int? DBID = default(int?), string Name = default(string), TypeEnum? Type = default(TypeEnum?), string FirstName = default(string), string LastName = default(string), string EmployeeId = default(string), string UserName = default(string), string Number = default(string), string SwitchName = default(string), Object Availability = default(Object))
        {
            this.DBID = DBID;
            this.Name = Name;
            this.Type = Type;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmployeeId = EmployeeId;
            this.UserName = UserName;
            this.Number = Number;
            this.SwitchName = SwitchName;
            this.Availability = Availability;
        }
        
        /// <summary>
        /// The unique database identifier.
        /// </summary>
        /// <value>The unique database identifier.</value>
        [DataMember(Name="DBID", EmitDefaultValue=false)]
        public int? DBID { get; set; }

        /// <summary>
        /// If the target is not **agent**, this property has a value. For example, the name of the agent group. If the target is **agent**, then the firstName and lastName fields are returned instead (or the username if neither is defined).
        /// </summary>
        /// <value>If the target is not **agent**, this property has a value. For example, the name of the agent group. If the target is **agent**, then the firstName and lastName fields are returned instead (or the username if neither is defined).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// The agent&#39;s first name.
        /// </summary>
        /// <value>The agent&#39;s first name.</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The agent&#39;s last name.
        /// </summary>
        /// <value>The agent&#39;s last name.</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The agent&#39;s employee ID.
        /// </summary>
        /// <value>The agent&#39;s employee ID.</value>
        [DataMember(Name="employeeId", EmitDefaultValue=false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// The agent&#39;s username.
        /// </summary>
        /// <value>The agent&#39;s username.</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The number associated with either an **acd-queue** or a **route-point**.
        /// </summary>
        /// <value>The number associated with either an **acd-queue** or a **route-point**.</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// The name of the switch associated with either an **acd-queue** or a **route-point**.
        /// </summary>
        /// <value>The name of the switch associated with either an **acd-queue** or a **route-point**.</value>
        [DataMember(Name="switchName", EmitDefaultValue=false)]
        public string SwitchName { get; set; }

        /// <summary>
        /// The structure of this object depends on the target type. For **agent**, availability includes channel details. For **acd-queue** and **route-point**, it includes waiting calls. For **agent-groups**, availability includes the number of ready agents.
        /// </summary>
        /// <value>The structure of this object depends on the target type. For **agent**, availability includes channel details. For **acd-queue** and **route-point**, it includes waiting calls. For **agent-groups**, availability includes the number of ready agents.</value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public Object Availability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Target {\n");
            sb.Append("  DBID: ").Append(DBID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  SwitchName: ").Append(SwitchName).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
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
            return this.Equals(input as Target);
        }

        /// <summary>
        /// Returns true if Target instances are equal
        /// </summary>
        /// <param name="input">Instance of Target to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Target input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DBID == input.DBID ||
                    (this.DBID != null &&
                    this.DBID.Equals(input.DBID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.SwitchName == input.SwitchName ||
                    (this.SwitchName != null &&
                    this.SwitchName.Equals(input.SwitchName))
                ) && 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
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
                if (this.DBID != null)
                    hashCode = hashCode * 59 + this.DBID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmployeeId != null)
                    hashCode = hashCode * 59 + this.EmployeeId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.SwitchName != null)
                    hashCode = hashCode * 59 + this.SwitchName.GetHashCode();
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
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
