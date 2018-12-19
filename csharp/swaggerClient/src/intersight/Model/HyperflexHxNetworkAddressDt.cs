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
    /// HyperflexHxNetworkAddressDt
    /// </summary>
    [DataContract]
    public partial class HyperflexHxNetworkAddressDt :  IEquatable<HyperflexHxNetworkAddressDt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexHxNetworkAddressDt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public HyperflexHxNetworkAddressDt()
        {
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public string Address { get; private set; }

        /// <summary>
        /// Gets or Sets Fqdn
        /// </summary>
        [DataMember(Name="Fqdn", EmitDefaultValue=false)]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="Ip", EmitDefaultValue=false)]
        public string Ip { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexHxNetworkAddressDt {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Fqdn: ").Append(Fqdn).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
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
            return this.Equals(obj as HyperflexHxNetworkAddressDt);
        }

        /// <summary>
        /// Returns true if HyperflexHxNetworkAddressDt instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexHxNetworkAddressDt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexHxNetworkAddressDt other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Fqdn == other.Fqdn ||
                    this.Fqdn != null &&
                    this.Fqdn.Equals(other.Fqdn)
                ) && 
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Fqdn != null)
                    hash = hash * 59 + this.Fqdn.GetHashCode();
                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();
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
