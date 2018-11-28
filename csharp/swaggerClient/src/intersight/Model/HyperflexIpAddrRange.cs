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
    /// IP address range, netmask, and gateway 
    /// </summary>
    [DataContract]
    public partial class HyperflexIpAddrRange :  IEquatable<HyperflexIpAddrRange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexIpAddrRange" /> class.
        /// </summary>
        /// <param name="EndAddr">End address  .</param>
        /// <param name="Gateway">Gateway  .</param>
        /// <param name="Netmask">Netmask  .</param>
        /// <param name="StartAddr">Start address   .</param>
        public HyperflexIpAddrRange(string EndAddr = default(string), string Gateway = default(string), string Netmask = default(string), string StartAddr = default(string))
        {
            this.EndAddr = EndAddr;
            this.Gateway = Gateway;
            this.Netmask = Netmask;
            this.StartAddr = StartAddr;
        }
        
        /// <summary>
        /// End address  
        /// </summary>
        /// <value>End address  </value>
        [DataMember(Name="EndAddr", EmitDefaultValue=false)]
        public string EndAddr { get; set; }

        /// <summary>
        /// Gateway  
        /// </summary>
        /// <value>Gateway  </value>
        [DataMember(Name="Gateway", EmitDefaultValue=false)]
        public string Gateway { get; set; }

        /// <summary>
        /// Netmask  
        /// </summary>
        /// <value>Netmask  </value>
        [DataMember(Name="Netmask", EmitDefaultValue=false)]
        public string Netmask { get; set; }

        /// <summary>
        /// Start address   
        /// </summary>
        /// <value>Start address   </value>
        [DataMember(Name="StartAddr", EmitDefaultValue=false)]
        public string StartAddr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexIpAddrRange {\n");
            sb.Append("  EndAddr: ").Append(EndAddr).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  Netmask: ").Append(Netmask).Append("\n");
            sb.Append("  StartAddr: ").Append(StartAddr).Append("\n");
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
            return this.Equals(obj as HyperflexIpAddrRange);
        }

        /// <summary>
        /// Returns true if HyperflexIpAddrRange instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexIpAddrRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexIpAddrRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EndAddr == other.EndAddr ||
                    this.EndAddr != null &&
                    this.EndAddr.Equals(other.EndAddr)
                ) && 
                (
                    this.Gateway == other.Gateway ||
                    this.Gateway != null &&
                    this.Gateway.Equals(other.Gateway)
                ) && 
                (
                    this.Netmask == other.Netmask ||
                    this.Netmask != null &&
                    this.Netmask.Equals(other.Netmask)
                ) && 
                (
                    this.StartAddr == other.StartAddr ||
                    this.StartAddr != null &&
                    this.StartAddr.Equals(other.StartAddr)
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
                if (this.EndAddr != null)
                    hash = hash * 59 + this.EndAddr.GetHashCode();
                if (this.Gateway != null)
                    hash = hash * 59 + this.Gateway.GetHashCode();
                if (this.Netmask != null)
                    hash = hash * 59 + this.Netmask.GetHashCode();
                if (this.StartAddr != null)
                    hash = hash * 59 + this.StartAddr.GetHashCode();
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
