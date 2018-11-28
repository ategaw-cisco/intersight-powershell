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
    /// Complex type that models a trap message sent from an agent to the manager 
    /// </summary>
    [DataContract]
    public partial class SnmpTrap :  IEquatable<SnmpTrap>, IValidatableObject
    {
        /// <summary>
        /// Type of trap which decides whether to receive a notification when a trap is received at the destination  
        /// </summary>
        /// <value>Type of trap which decides whether to receive a notification when a trap is received at the destination  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Trap for "Trap"
            /// </summary>
            [EnumMember(Value = "Trap")]
            Trap,
            
            /// <summary>
            /// Enum Inform for "Inform"
            /// </summary>
            [EnumMember(Value = "Inform")]
            Inform
        }

        /// <summary>
        /// SNMP version used for the trap   
        /// </summary>
        /// <value>SNMP version used for the trap   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            
            /// <summary>
            /// Enum V3 for "V3"
            /// </summary>
            [EnumMember(Value = "V3")]
            V3,
            
            /// <summary>
            /// Enum V2 for "V2"
            /// </summary>
            [EnumMember(Value = "V2")]
            V2
        }

        /// <summary>
        /// Type of trap which decides whether to receive a notification when a trap is received at the destination  
        /// </summary>
        /// <value>Type of trap which decides whether to receive a notification when a trap is received at the destination  </value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// SNMP version used for the trap   
        /// </summary>
        /// <value>SNMP version used for the trap   </value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public VersionEnum? Version { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnmpTrap" /> class.
        /// </summary>
        /// <param name="Destination">Address to which the SNMP trap information is sent  .</param>
        /// <param name="Enabled">Enables/disables the trap on the server If enabled, trap us active on the server.  .</param>
        /// <param name="Port">Port used by the server to communicate with trap destination. Enter a value between 1-65535.  .</param>
        /// <param name="Type">Type of trap which decides whether to receive a notification when a trap is received at the destination   (default to TypeEnum.Trap).</param>
        /// <param name="User">SNMP user for the trap. Applicable only to SNMPv3  .</param>
        /// <param name="Version">SNMP version used for the trap    (default to VersionEnum.V3).</param>
        public SnmpTrap(string Destination = default(string), bool? Enabled = default(bool?), long? Port = default(long?), TypeEnum? Type = TypeEnum.Trap, string User = default(string), VersionEnum? Version = VersionEnum.V3)
        {
            this.Destination = Destination;
            this.Enabled = Enabled;
            this.Port = Port;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.Trap;
            }
            else
            {
                this.Type = Type;
            }
            this.User = User;
            // use default value if no "Version" provided
            if (Version == null)
            {
                this.Version = VersionEnum.V3;
            }
            else
            {
                this.Version = Version;
            }
        }
        
        /// <summary>
        /// Address to which the SNMP trap information is sent  
        /// </summary>
        /// <value>Address to which the SNMP trap information is sent  </value>
        [DataMember(Name="Destination", EmitDefaultValue=false)]
        public string Destination { get; set; }

        /// <summary>
        /// Enables/disables the trap on the server If enabled, trap us active on the server.  
        /// </summary>
        /// <value>Enables/disables the trap on the server If enabled, trap us active on the server.  </value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Port used by the server to communicate with trap destination. Enter a value between 1-65535.  
        /// </summary>
        /// <value>Port used by the server to communicate with trap destination. Enter a value between 1-65535.  </value>
        [DataMember(Name="Port", EmitDefaultValue=false)]
        public long? Port { get; set; }


        /// <summary>
        /// SNMP user for the trap. Applicable only to SNMPv3  
        /// </summary>
        /// <value>SNMP user for the trap. Applicable only to SNMPv3  </value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public string User { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnmpTrap {\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as SnmpTrap);
        }

        /// <summary>
        /// Returns true if SnmpTrap instances are equal
        /// </summary>
        /// <param name="other">Instance of SnmpTrap to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnmpTrap other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
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
