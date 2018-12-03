/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-265
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
using SwaggerDateConverter = intersight.Client.SwaggerDateConverter;

namespace intersight.Model
{
    /// <summary>
    /// The context for a validation/config result such as the related entity&#39;s name, type, MOID etc. 
    /// </summary>
    [DataContract]
    public partial class PolicyConfigResultContext :  IEquatable<PolicyConfigResultContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConfigResultContext" /> class.
        /// </summary>
        /// <param name="EntityData">EntityData.</param>
        /// <param name="EntityMoid">EntityMoid.</param>
        /// <param name="EntityName">EntityName.</param>
        /// <param name="EntityType">EntityType.</param>
        public PolicyConfigResultContext(Object EntityData = default(Object), string EntityMoid = default(string), string EntityName = default(string), string EntityType = default(string))
        {
            this.EntityData = EntityData;
            this.EntityMoid = EntityMoid;
            this.EntityName = EntityName;
            this.EntityType = EntityType;
        }
        
        /// <summary>
        /// Gets or Sets EntityData
        /// </summary>
        [DataMember(Name="EntityData", EmitDefaultValue=false)]
        public Object EntityData { get; set; }

        /// <summary>
        /// Gets or Sets EntityMoid
        /// </summary>
        [DataMember(Name="EntityMoid", EmitDefaultValue=false)]
        public string EntityMoid { get; set; }

        /// <summary>
        /// Gets or Sets EntityName
        /// </summary>
        [DataMember(Name="EntityName", EmitDefaultValue=false)]
        public string EntityName { get; set; }

        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="EntityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyConfigResultContext {\n");
            sb.Append("  EntityData: ").Append(EntityData).Append("\n");
            sb.Append("  EntityMoid: ").Append(EntityMoid).Append("\n");
            sb.Append("  EntityName: ").Append(EntityName).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return this.Equals(obj as PolicyConfigResultContext);
        }

        /// <summary>
        /// Returns true if PolicyConfigResultContext instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyConfigResultContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyConfigResultContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EntityData == other.EntityData ||
                    this.EntityData != null &&
                    this.EntityData.Equals(other.EntityData)
                ) && 
                (
                    this.EntityMoid == other.EntityMoid ||
                    this.EntityMoid != null &&
                    this.EntityMoid.Equals(other.EntityMoid)
                ) && 
                (
                    this.EntityName == other.EntityName ||
                    this.EntityName != null &&
                    this.EntityName.Equals(other.EntityName)
                ) && 
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
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
                if (this.EntityData != null)
                    hash = hash * 59 + this.EntityData.GetHashCode();
                if (this.EntityMoid != null)
                    hash = hash * 59 + this.EntityMoid.GetHashCode();
                if (this.EntityName != null)
                    hash = hash * 59 + this.EntityName.GetHashCode();
                if (this.EntityType != null)
                    hash = hash * 59 + this.EntityType.GetHashCode();
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
