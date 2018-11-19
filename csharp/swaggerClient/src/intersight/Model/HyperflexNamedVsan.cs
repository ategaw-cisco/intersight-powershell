/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-255
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
    /// VSAN name and ID 
    /// </summary>
    [DataContract]
    public partial class HyperflexNamedVsan :  IEquatable<HyperflexNamedVsan>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexNamedVsan" /> class.
        /// </summary>
        /// <param name="Name">VSAN name  .</param>
        /// <param name="VsanId">VSAN ID   .</param>
        public HyperflexNamedVsan(string Name = default(string), long? VsanId = default(long?))
        {
            this.Name = Name;
            this.VsanId = VsanId;
        }
        
        /// <summary>
        /// VSAN name  
        /// </summary>
        /// <value>VSAN name  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// VSAN ID   
        /// </summary>
        /// <value>VSAN ID   </value>
        [DataMember(Name="VsanId", EmitDefaultValue=false)]
        public long? VsanId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexNamedVsan {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VsanId: ").Append(VsanId).Append("\n");
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
            return this.Equals(obj as HyperflexNamedVsan);
        }

        /// <summary>
        /// Returns true if HyperflexNamedVsan instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexNamedVsan to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexNamedVsan other)
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
                    this.VsanId == other.VsanId ||
                    this.VsanId != null &&
                    this.VsanId.Equals(other.VsanId)
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
                if (this.VsanId != null)
                    hash = hash * 59 + this.VsanId.GetHashCode();
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
