/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-261
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
    /// Represents IPv4 interface configuration with ip, netmask, and gateway 
    /// </summary>
    [DataContract]
    public partial class CommIpV4Interface :  IEquatable<CommIpV4Interface>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommIpV4Interface" /> class.
        /// </summary>
        /// <param name="Gateway">IP Gateway  .</param>
        /// <param name="IpAddress">IP Address  .</param>
        /// <param name="Netmask">IP Netmask   .</param>
        public CommIpV4Interface(string Gateway = default(string), string IpAddress = default(string), string Netmask = default(string))
        {
            this.Gateway = Gateway;
            this.IpAddress = IpAddress;
            this.Netmask = Netmask;
        }
        
        /// <summary>
        /// IP Gateway  
        /// </summary>
        /// <value>IP Gateway  </value>
        [DataMember(Name="Gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// IP Address  
        /// </summary>
        /// <value>IP Address  </value>
        [DataMember(Name="IpAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// IP Netmask   
        /// </summary>
        /// <value>IP Netmask   </value>
        [DataMember(Name="Netmask", EmitDefaultValue=false)]
        public string Netmask { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommIpV4Interface {\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Netmask: ").Append(Netmask).Append("\n");
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
            return this.Equals(obj as CommIpV4Interface);
        }

        /// <summary>
        /// Returns true if CommIpV4Interface instances are equal
        /// </summary>
        /// <param name="other">Instance of CommIpV4Interface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommIpV4Interface other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Gateway == other.Gateway ||
                    this.Gateway != null &&
                    this.Gateway.Equals(other.Gateway)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.Netmask == other.Netmask ||
                    this.Netmask != null &&
                    this.Netmask.Equals(other.Netmask)
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
                if (this.Gateway != null)
                    hash = hash * 59 + this.Gateway.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.Netmask != null)
                    hash = hash * 59 + this.Netmask.GetHashCode();
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
