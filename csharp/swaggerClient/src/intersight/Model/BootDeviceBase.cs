/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-264
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
    /// Lists properties that are common to all device types. It serves as base class for other device types. 
    /// </summary>
    [DataContract]
    public partial class BootDeviceBase :  IEquatable<BootDeviceBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BootDeviceBase" /> class.
        /// </summary>
        /// <param name="Enabled">Specifies if the boot device is enabled or disabled  .</param>
        /// <param name="Name">Specifies the name of the boot device. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters.   .</param>
        public BootDeviceBase(bool? Enabled = default(bool?), string Name = default(string))
        {
            this.Enabled = Enabled;
            this.Name = Name;
        }
        
        /// <summary>
        /// Specifies if the boot device is enabled or disabled  
        /// </summary>
        /// <value>Specifies if the boot device is enabled or disabled  </value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Specifies the name of the boot device. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters.   
        /// </summary>
        /// <value>Specifies the name of the boot device. It should start and end with an alphanumeric character. It can have underscores and hyphens. It cannot be more than 30 characters.   </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BootDeviceBase {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            return this.Equals(obj as BootDeviceBase);
        }

        /// <summary>
        /// Returns true if BootDeviceBase instances are equal
        /// </summary>
        /// <param name="other">Instance of BootDeviceBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BootDeviceBase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
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
