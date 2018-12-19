/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-300
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
    /// driver details 
    /// </summary>
    [DataContract]
    public partial class HclDriver :  IEquatable<HclDriver>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HclDriver" /> class.
        /// </summary>
        /// <param name="IsLatest">is the driver version latest  .</param>
        /// <param name="Name">name of the driver as read by the OS  .</param>
        /// <param name="SupportedDate">date when the support was claimed  .</param>
        /// <param name="Version">version of the driver   .</param>
        public HclDriver(bool? IsLatest = default(bool?), string Name = default(string), string SupportedDate = default(string), string Version = default(string))
        {
            this.IsLatest = IsLatest;
            this.Name = Name;
            this.SupportedDate = SupportedDate;
            this.Version = Version;
        }
        
        /// <summary>
        /// is the driver version latest  
        /// </summary>
        /// <value>is the driver version latest  </value>
        [DataMember(Name="IsLatest", EmitDefaultValue=false)]
        public bool? IsLatest { get; set; }

        /// <summary>
        /// name of the driver as read by the OS  
        /// </summary>
        /// <value>name of the driver as read by the OS  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// date when the support was claimed  
        /// </summary>
        /// <value>date when the support was claimed  </value>
        [DataMember(Name="SupportedDate", EmitDefaultValue=false)]
        public string SupportedDate { get; set; }

        /// <summary>
        /// version of the driver   
        /// </summary>
        /// <value>version of the driver   </value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HclDriver {\n");
            sb.Append("  IsLatest: ").Append(IsLatest).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SupportedDate: ").Append(SupportedDate).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as HclDriver);
        }

        /// <summary>
        /// Returns true if HclDriver instances are equal
        /// </summary>
        /// <param name="other">Instance of HclDriver to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HclDriver other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsLatest == other.IsLatest ||
                    this.IsLatest != null &&
                    this.IsLatest.Equals(other.IsLatest)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SupportedDate == other.SupportedDate ||
                    this.SupportedDate != null &&
                    this.SupportedDate.Equals(other.SupportedDate)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.IsLatest != null)
                    hash = hash * 59 + this.IsLatest.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SupportedDate != null)
                    hash = hash * 59 + this.SupportedDate.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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
