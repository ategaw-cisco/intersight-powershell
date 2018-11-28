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
    /// Specifies server firmware bundle versions used for server components such as CIMC, adapters, BIOS, etc. 
    /// </summary>
    [DataContract]
    public partial class HyperflexServerFirmwareVersionEntry :  IEquatable<HyperflexServerFirmwareVersionEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexServerFirmwareVersionEntry" /> class.
        /// </summary>
        /// <param name="Name">Application setting identifier  .</param>
        /// <param name="Value">Application setting value   .</param>
        /// <param name="Constraint">Conditions to be met to apply the AppSetting  .</param>
        /// <param name="Label">Display name for server firmware bundle version in UI   .</param>
        public HyperflexServerFirmwareVersionEntry(string Name = default(string), string Value = default(string), HyperflexAppSettingConstraint Constraint = default(HyperflexAppSettingConstraint), string Label = default(string))
        {
            this.Name = Name;
            this.Value = Value;
            this.Constraint = Constraint;
            this.Label = Label;
        }
        
        /// <summary>
        /// Application setting identifier  
        /// </summary>
        /// <value>Application setting identifier  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Application setting value   
        /// </summary>
        /// <value>Application setting value   </value>
        [DataMember(Name="Value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Conditions to be met to apply the AppSetting  
        /// </summary>
        /// <value>Conditions to be met to apply the AppSetting  </value>
        [DataMember(Name="Constraint", EmitDefaultValue=false)]
        public HyperflexAppSettingConstraint Constraint { get; set; }

        /// <summary>
        /// Display name for server firmware bundle version in UI   
        /// </summary>
        /// <value>Display name for server firmware bundle version in UI   </value>
        [DataMember(Name="Label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexServerFirmwareVersionEntry {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Constraint: ").Append(Constraint).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
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
            return this.Equals(obj as HyperflexServerFirmwareVersionEntry);
        }

        /// <summary>
        /// Returns true if HyperflexServerFirmwareVersionEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexServerFirmwareVersionEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexServerFirmwareVersionEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) && 
                (
                    this.Constraint == other.Constraint ||
                    this.Constraint != null &&
                    this.Constraint.Equals(other.Constraint)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this.Constraint != null)
                    hash = hash * 59 + this.Constraint.GetHashCode();
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
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
