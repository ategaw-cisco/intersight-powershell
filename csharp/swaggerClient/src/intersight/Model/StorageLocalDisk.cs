/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-221
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
    /// This models disks in the disk group 
    /// </summary>
    [DataContract]
    public partial class StorageLocalDisk :  IEquatable<StorageLocalDisk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageLocalDisk" /> class.
        /// </summary>
        /// <param name="SlotNumber">Specifies the slot number of the disk to be referenced. As this is a policy object, this slot number may or may not be valid depending on the number of disks in the associated server   .</param>
        public StorageLocalDisk(long? SlotNumber = default(long?))
        {
            this.SlotNumber = SlotNumber;
        }
        
        /// <summary>
        /// Specifies the slot number of the disk to be referenced. As this is a policy object, this slot number may or may not be valid depending on the number of disks in the associated server   
        /// </summary>
        /// <value>Specifies the slot number of the disk to be referenced. As this is a policy object, this slot number may or may not be valid depending on the number of disks in the associated server   </value>
        [DataMember(Name="SlotNumber", EmitDefaultValue=false)]
        public long? SlotNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageLocalDisk {\n");
            sb.Append("  SlotNumber: ").Append(SlotNumber).Append("\n");
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
            return this.Equals(obj as StorageLocalDisk);
        }

        /// <summary>
        /// Returns true if StorageLocalDisk instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageLocalDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageLocalDisk other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SlotNumber == other.SlotNumber ||
                    this.SlotNumber != null &&
                    this.SlotNumber.Equals(other.SlotNumber)
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
                if (this.SlotNumber != null)
                    hash = hash * 59 + this.SlotNumber.GetHashCode();
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
