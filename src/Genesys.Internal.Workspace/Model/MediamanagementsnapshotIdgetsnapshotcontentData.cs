/* 
 * Workspace API
 *
 * Agent API
 *
 * OpenAPI spec version: 9.0.000.24.2336
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
    /// MediamanagementsnapshotIdgetsnapshotcontentData
    /// </summary>
    [DataContract]
    public partial class MediamanagementsnapshotIdgetsnapshotcontentData :  IEquatable<MediamanagementsnapshotIdgetsnapshotcontentData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediamanagementsnapshotIdgetsnapshotcontentData" /> class.
        /// </summary>
        /// <param name="StartIndex">The start index..</param>
        /// <param name="Size">The number of elements.</param>
        public MediamanagementsnapshotIdgetsnapshotcontentData(decimal? StartIndex = default(decimal?), decimal? Size = default(decimal?))
        {
            this.StartIndex = StartIndex;
            this.Size = Size;
        }
        
        /// <summary>
        /// The start index.
        /// </summary>
        /// <value>The start index.</value>
        [DataMember(Name="startIndex", EmitDefaultValue=false)]
        public decimal? StartIndex { get; set; }

        /// <summary>
        /// The number of elements
        /// </summary>
        /// <value>The number of elements</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public decimal? Size { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediamanagementsnapshotIdgetsnapshotcontentData {\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
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
            return this.Equals(input as MediamanagementsnapshotIdgetsnapshotcontentData);
        }

        /// <summary>
        /// Returns true if MediamanagementsnapshotIdgetsnapshotcontentData instances are equal
        /// </summary>
        /// <param name="input">Instance of MediamanagementsnapshotIdgetsnapshotcontentData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediamanagementsnapshotIdgetsnapshotcontentData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartIndex == input.StartIndex ||
                    (this.StartIndex != null &&
                    this.StartIndex.Equals(input.StartIndex))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.StartIndex != null)
                    hashCode = hashCode * 59 + this.StartIndex.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
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