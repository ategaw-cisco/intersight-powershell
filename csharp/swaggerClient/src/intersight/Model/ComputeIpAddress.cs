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
    /// Complex type representing an ip address in UCSM 
    /// </summary>
    [DataContract]
    public partial class ComputeIpAddress :  IEquatable<ComputeIpAddress>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            
            /// <summary>
            /// Enum Equipment for "Equipment"
            /// </summary>
            [EnumMember(Value = "Equipment")]
            Equipment,
            
            /// <summary>
            /// Enum ServiceProfile for "ServiceProfile"
            /// </summary>
            [EnumMember(Value = "ServiceProfile")]
            ServiceProfile
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NameEnum
        {
            
            /// <summary>
            /// Enum Outband for "Outband"
            /// </summary>
            [EnumMember(Value = "Outband")]
            Outband,
            
            /// <summary>
            /// Enum Inband for "Inband"
            /// </summary>
            [EnumMember(Value = "Inband")]
            Inband
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum MgmtInterface for "MgmtInterface"
            /// </summary>
            [EnumMember(Value = "MgmtInterface")]
            MgmtInterface,
            
            /// <summary>
            /// Enum VnicIpV4StaticAddr for "VnicIpV4StaticAddr"
            /// </summary>
            [EnumMember(Value = "VnicIpV4StaticAddr")]
            VnicIpV4StaticAddr,
            
            /// <summary>
            /// Enum VnicIpV4PooledAddr for "VnicIpV4PooledAddr"
            /// </summary>
            [EnumMember(Value = "VnicIpV4PooledAddr")]
            VnicIpV4PooledAddr,
            
            /// <summary>
            /// Enum VnicIpV4MgmtPooledAddr for "VnicIpV4MgmtPooledAddr"
            /// </summary>
            [EnumMember(Value = "VnicIpV4MgmtPooledAddr")]
            VnicIpV4MgmtPooledAddr,
            
            /// <summary>
            /// Enum VnicIpV6StaticAddr for "VnicIpV6StaticAddr"
            /// </summary>
            [EnumMember(Value = "VnicIpV6StaticAddr")]
            VnicIpV6StaticAddr,
            
            /// <summary>
            /// Enum VnicIpV6MgmtPooledAddr for "VnicIpV6MgmtPooledAddr"
            /// </summary>
            [EnumMember(Value = "VnicIpV6MgmtPooledAddr")]
            VnicIpV6MgmtPooledAddr,
            
            /// <summary>
            /// Enum VnicIpV4ProfDerivedAddr for "VnicIpV4ProfDerivedAddr"
            /// </summary>
            [EnumMember(Value = "VnicIpV4ProfDerivedAddr")]
            VnicIpV4ProfDerivedAddr
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public CategoryEnum? Category { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public NameEnum? Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeIpAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ComputeIpAddress()
        {
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="Address", EmitDefaultValue=false)]
        public string Address { get; private set; }


        /// <summary>
        /// Gets or Sets DefaultGateway
        /// </summary>
        [DataMember(Name="DefaultGateway", EmitDefaultValue=false)]
        public string DefaultGateway { get; private set; }

        /// <summary>
        /// Gets or Sets Dn
        /// </summary>
        [DataMember(Name="Dn", EmitDefaultValue=false)]
        public string Dn { get; private set; }

        /// <summary>
        /// Gets or Sets HttpPort
        /// </summary>
        [DataMember(Name="HttpPort", EmitDefaultValue=false)]
        public long? HttpPort { get; private set; }

        /// <summary>
        /// Gets or Sets HttpsPort
        /// </summary>
        [DataMember(Name="HttpsPort", EmitDefaultValue=false)]
        public long? HttpsPort { get; private set; }

        /// <summary>
        /// Gets or Sets KvmPort
        /// </summary>
        [DataMember(Name="KvmPort", EmitDefaultValue=false)]
        public long? KvmPort { get; private set; }


        /// <summary>
        /// Gets or Sets Subnet
        /// </summary>
        [DataMember(Name="Subnet", EmitDefaultValue=false)]
        public string Subnet { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeIpAddress {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  DefaultGateway: ").Append(DefaultGateway).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  HttpPort: ").Append(HttpPort).Append("\n");
            sb.Append("  HttpsPort: ").Append(HttpsPort).Append("\n");
            sb.Append("  KvmPort: ").Append(KvmPort).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subnet: ").Append(Subnet).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as ComputeIpAddress);
        }

        /// <summary>
        /// Returns true if ComputeIpAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of ComputeIpAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComputeIpAddress other)
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
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.DefaultGateway == other.DefaultGateway ||
                    this.DefaultGateway != null &&
                    this.DefaultGateway.Equals(other.DefaultGateway)
                ) && 
                (
                    this.Dn == other.Dn ||
                    this.Dn != null &&
                    this.Dn.Equals(other.Dn)
                ) && 
                (
                    this.HttpPort == other.HttpPort ||
                    this.HttpPort != null &&
                    this.HttpPort.Equals(other.HttpPort)
                ) && 
                (
                    this.HttpsPort == other.HttpsPort ||
                    this.HttpsPort != null &&
                    this.HttpsPort.Equals(other.HttpsPort)
                ) && 
                (
                    this.KvmPort == other.KvmPort ||
                    this.KvmPort != null &&
                    this.KvmPort.Equals(other.KvmPort)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Subnet == other.Subnet ||
                    this.Subnet != null &&
                    this.Subnet.Equals(other.Subnet)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.DefaultGateway != null)
                    hash = hash * 59 + this.DefaultGateway.GetHashCode();
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                if (this.HttpPort != null)
                    hash = hash * 59 + this.HttpPort.GetHashCode();
                if (this.HttpsPort != null)
                    hash = hash * 59 + this.HttpsPort.GetHashCode();
                if (this.KvmPort != null)
                    hash = hash * 59 + this.KvmPort.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Subnet != null)
                    hash = hash * 59 + this.Subnet.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
