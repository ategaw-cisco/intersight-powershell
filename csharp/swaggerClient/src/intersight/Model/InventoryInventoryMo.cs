/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-260
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
    /// Complex type representing the inventory MO 
    /// </summary>
    [DataContract]
    public partial class InventoryInventoryMo :  IEquatable<InventoryInventoryMo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InventoryInventoryMo" /> class.
        /// </summary>
        /// <param name="MoDn">The UCS DN of the MO for which the latest inventory to be fetched. If this property is empty and moId property has the Moid of the MO to be updated, the Moid will be used. If this property is empty and moId is also empty, all the MOs of the given moType will be updated  .</param>
        /// <param name="MoId">The MO id of an MO for which the latest inventory to be fetched. If this property is empty and moDn property has the UCS DN of the MO to be updated, the DN will be used. If this property is empty and moDn is also empty, all the MOs of the given moType will be updated  .</param>
        /// <param name="MoType">The type of the MO for which the latest inventory to be fetched   .</param>
        public InventoryInventoryMo(string MoDn = default(string), string MoId = default(string), string MoType = default(string))
        {
            this.MoDn = MoDn;
            this.MoId = MoId;
            this.MoType = MoType;
        }
        
        /// <summary>
        /// The UCS DN of the MO for which the latest inventory to be fetched. If this property is empty and moId property has the Moid of the MO to be updated, the Moid will be used. If this property is empty and moId is also empty, all the MOs of the given moType will be updated  
        /// </summary>
        /// <value>The UCS DN of the MO for which the latest inventory to be fetched. If this property is empty and moId property has the Moid of the MO to be updated, the Moid will be used. If this property is empty and moId is also empty, all the MOs of the given moType will be updated  </value>
        [DataMember(Name="MoDn", EmitDefaultValue=false)]
        public string MoDn { get; set; }

        /// <summary>
        /// The MO id of an MO for which the latest inventory to be fetched. If this property is empty and moDn property has the UCS DN of the MO to be updated, the DN will be used. If this property is empty and moDn is also empty, all the MOs of the given moType will be updated  
        /// </summary>
        /// <value>The MO id of an MO for which the latest inventory to be fetched. If this property is empty and moDn property has the UCS DN of the MO to be updated, the DN will be used. If this property is empty and moDn is also empty, all the MOs of the given moType will be updated  </value>
        [DataMember(Name="MoId", EmitDefaultValue=false)]
        public string MoId { get; set; }

        /// <summary>
        /// The type of the MO for which the latest inventory to be fetched   
        /// </summary>
        /// <value>The type of the MO for which the latest inventory to be fetched   </value>
        [DataMember(Name="MoType", EmitDefaultValue=false)]
        public string MoType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InventoryInventoryMo {\n");
            sb.Append("  MoDn: ").Append(MoDn).Append("\n");
            sb.Append("  MoId: ").Append(MoId).Append("\n");
            sb.Append("  MoType: ").Append(MoType).Append("\n");
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
            return this.Equals(obj as InventoryInventoryMo);
        }

        /// <summary>
        /// Returns true if InventoryInventoryMo instances are equal
        /// </summary>
        /// <param name="other">Instance of InventoryInventoryMo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InventoryInventoryMo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MoDn == other.MoDn ||
                    this.MoDn != null &&
                    this.MoDn.Equals(other.MoDn)
                ) && 
                (
                    this.MoId == other.MoId ||
                    this.MoId != null &&
                    this.MoId.Equals(other.MoId)
                ) && 
                (
                    this.MoType == other.MoType ||
                    this.MoType != null &&
                    this.MoType.Equals(other.MoType)
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
                if (this.MoDn != null)
                    hash = hash * 59 + this.MoDn.GetHashCode();
                if (this.MoId != null)
                    hash = hash * 59 + this.MoId.GetHashCode();
                if (this.MoType != null)
                    hash = hash * 59 + this.MoType.GetHashCode();
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
