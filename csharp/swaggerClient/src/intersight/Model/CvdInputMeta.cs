/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-262
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
    /// CvdInputMeta
    /// </summary>
    [DataContract]
    public partial class CvdInputMeta :  IEquatable<CvdInputMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CvdInputMeta" /> class.
        /// </summary>
        /// <param name="FieldFilter">Input field filter(REST API path with filter which will return the list of applicable values for this field)  .</param>
        /// <param name="FieldLabel">Input field label(for GUI use)  .</param>
        /// <param name="FieldName">Input field name  .</param>
        /// <param name="FieldValue">Input field value   .</param>
        public CvdInputMeta(string FieldFilter = default(string), string FieldLabel = default(string), string FieldName = default(string), string FieldValue = default(string))
        {
            this.FieldFilter = FieldFilter;
            this.FieldLabel = FieldLabel;
            this.FieldName = FieldName;
            this.FieldValue = FieldValue;
        }
        
        /// <summary>
        /// Input field filter(REST API path with filter which will return the list of applicable values for this field)  
        /// </summary>
        /// <value>Input field filter(REST API path with filter which will return the list of applicable values for this field)  </value>
        [DataMember(Name="FieldFilter", EmitDefaultValue=false)]
        public string FieldFilter { get; set; }

        /// <summary>
        /// Input field label(for GUI use)  
        /// </summary>
        /// <value>Input field label(for GUI use)  </value>
        [DataMember(Name="FieldLabel", EmitDefaultValue=false)]
        public string FieldLabel { get; set; }

        /// <summary>
        /// Input field name  
        /// </summary>
        /// <value>Input field name  </value>
        [DataMember(Name="FieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Input field value   
        /// </summary>
        /// <value>Input field value   </value>
        [DataMember(Name="FieldValue", EmitDefaultValue=false)]
        public string FieldValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CvdInputMeta {\n");
            sb.Append("  FieldFilter: ").Append(FieldFilter).Append("\n");
            sb.Append("  FieldLabel: ").Append(FieldLabel).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
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
            return this.Equals(obj as CvdInputMeta);
        }

        /// <summary>
        /// Returns true if CvdInputMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of CvdInputMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CvdInputMeta other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldFilter == other.FieldFilter ||
                    this.FieldFilter != null &&
                    this.FieldFilter.Equals(other.FieldFilter)
                ) && 
                (
                    this.FieldLabel == other.FieldLabel ||
                    this.FieldLabel != null &&
                    this.FieldLabel.Equals(other.FieldLabel)
                ) && 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.FieldValue == other.FieldValue ||
                    this.FieldValue != null &&
                    this.FieldValue.Equals(other.FieldValue)
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
                if (this.FieldFilter != null)
                    hash = hash * 59 + this.FieldFilter.GetHashCode();
                if (this.FieldLabel != null)
                    hash = hash * 59 + this.FieldLabel.GetHashCode();
                if (this.FieldName != null)
                    hash = hash * 59 + this.FieldName.GetHashCode();
                if (this.FieldValue != null)
                    hash = hash * 59 + this.FieldValue.GetHashCode();
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
