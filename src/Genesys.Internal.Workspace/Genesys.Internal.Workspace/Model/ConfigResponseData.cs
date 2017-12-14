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
    /// ConfigResponseData
    /// </summary>
    [DataContract]
    public partial class ConfigResponseData :  IEquatable<ConfigResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigResponseData" /> class.
        /// </summary>
        /// <param name="ActionCodes">ActionCodes.</param>
        /// <param name="Transactions">Transactions.</param>
        /// <param name="BusinessAttributes">BusinessAttributes.</param>
        public ConfigResponseData(List<ConfigResponseDataActionCodes> ActionCodes = default(List<ConfigResponseDataActionCodes>), List<ConfigResponseDataTransactions> Transactions = default(List<ConfigResponseDataTransactions>), List<ConfigResponseDataBusinessAttributes> BusinessAttributes = default(List<ConfigResponseDataBusinessAttributes>))
        {
            this.ActionCodes = ActionCodes;
            this.Transactions = Transactions;
            this.BusinessAttributes = BusinessAttributes;
        }
        
        /// <summary>
        /// Gets or Sets ActionCodes
        /// </summary>
        [DataMember(Name="actionCodes", EmitDefaultValue=false)]
        public List<ConfigResponseDataActionCodes> ActionCodes { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<ConfigResponseDataTransactions> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets BusinessAttributes
        /// </summary>
        [DataMember(Name="businessAttributes", EmitDefaultValue=false)]
        public List<ConfigResponseDataBusinessAttributes> BusinessAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigResponseData {\n");
            sb.Append("  ActionCodes: ").Append(ActionCodes).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  BusinessAttributes: ").Append(BusinessAttributes).Append("\n");
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
            return this.Equals(input as ConfigResponseData);
        }

        /// <summary>
        /// Returns true if ConfigResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActionCodes == input.ActionCodes ||
                    this.ActionCodes != null &&
                    this.ActionCodes.SequenceEqual(input.ActionCodes)
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.BusinessAttributes == input.BusinessAttributes ||
                    this.BusinessAttributes != null &&
                    this.BusinessAttributes.SequenceEqual(input.BusinessAttributes)
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
                if (this.ActionCodes != null)
                    hashCode = hashCode * 59 + this.ActionCodes.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.BusinessAttributes != null)
                    hashCode = hashCode * 59 + this.BusinessAttributes.GetHashCode();
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
