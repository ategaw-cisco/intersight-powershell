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
    /// This adds and configures operating system partitions 
    /// </summary>
    [DataContract]
    public partial class SdcardPartition :  IEquatable<SdcardPartition>, IValidatableObject
    {
        /// <summary>
        /// Type of the partition  
        /// </summary>
        /// <value>Type of the partition  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum OS for "OS"
            /// </summary>
            [EnumMember(Value = "OS")]
            OS,
            
            /// <summary>
            /// Enum Utility for "Utility"
            /// </summary>
            [EnumMember(Value = "Utility")]
            Utility
        }

        /// <summary>
        /// Type of the partition  
        /// </summary>
        /// <value>Type of the partition  </value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SdcardPartition" /> class.
        /// </summary>
        /// <param name="Type">Type of the partition   (default to TypeEnum.OS).</param>
        /// <param name="VirtualDrives">Collection of available virtual drives   .</param>
        public SdcardPartition(TypeEnum? Type = TypeEnum.OS, List<SdcardVirtualDrive> VirtualDrives = default(List<SdcardVirtualDrive>))
        {
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.OS;
            }
            else
            {
                this.Type = Type;
            }
            this.VirtualDrives = VirtualDrives;
        }
        

        /// <summary>
        /// Collection of available virtual drives   
        /// </summary>
        /// <value>Collection of available virtual drives   </value>
        [DataMember(Name="VirtualDrives", EmitDefaultValue=false)]
        public List<SdcardVirtualDrive> VirtualDrives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SdcardPartition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VirtualDrives: ").Append(VirtualDrives).Append("\n");
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
            return this.Equals(obj as SdcardPartition);
        }

        /// <summary>
        /// Returns true if SdcardPartition instances are equal
        /// </summary>
        /// <param name="other">Instance of SdcardPartition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SdcardPartition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.VirtualDrives == other.VirtualDrives ||
                    this.VirtualDrives != null &&
                    this.VirtualDrives.SequenceEqual(other.VirtualDrives)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.VirtualDrives != null)
                    hash = hash * 59 + this.VirtualDrives.GetHashCode();
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
