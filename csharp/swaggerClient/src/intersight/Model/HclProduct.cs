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
    /// model giving the details of product 
    /// </summary>
    [DataContract]
    public partial class HclProduct :  IEquatable<HclProduct>, IValidatableObject
    {
        /// <summary>
        /// Error code indicating the support status  
        /// </summary>
        /// <value>Error code indicating the support status  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success,
            
            /// <summary>
            /// Enum Unknown for "Unknown"
            /// </summary>
            [EnumMember(Value = "Unknown")]
            Unknown,
            
            /// <summary>
            /// Enum UnknownServer for "UnknownServer"
            /// </summary>
            [EnumMember(Value = "UnknownServer")]
            UnknownServer,
            
            /// <summary>
            /// Enum InvalidUcsVersion for "InvalidUcsVersion"
            /// </summary>
            [EnumMember(Value = "InvalidUcsVersion")]
            InvalidUcsVersion,
            
            /// <summary>
            /// Enum ProcessorNotSupported for "ProcessorNotSupported"
            /// </summary>
            [EnumMember(Value = "ProcessorNotSupported")]
            ProcessorNotSupported,
            
            /// <summary>
            /// Enum OSNotSupported for "OSNotSupported"
            /// </summary>
            [EnumMember(Value = "OSNotSupported")]
            OSNotSupported,
            
            /// <summary>
            /// Enum UCSVersionNotSupported for "UCSVersionNotSupported"
            /// </summary>
            [EnumMember(Value = "UCSVersionNotSupported")]
            UCSVersionNotSupported,
            
            /// <summary>
            /// Enum UcsVersionServerOSCombinationNotSupported for "UcsVersionServerOSCombinationNotSupported"
            /// </summary>
            [EnumMember(Value = "UcsVersionServerOSCombinationNotSupported")]
            UcsVersionServerOSCombinationNotSupported,
            
            /// <summary>
            /// Enum ProductUnknown for "ProductUnknown"
            /// </summary>
            [EnumMember(Value = "ProductUnknown")]
            ProductUnknown,
            
            /// <summary>
            /// Enum ProductNotSupported for "ProductNotSupported"
            /// </summary>
            [EnumMember(Value = "ProductNotSupported")]
            ProductNotSupported,
            
            /// <summary>
            /// Enum DriverNameNotSupported for "DriverNameNotSupported"
            /// </summary>
            [EnumMember(Value = "DriverNameNotSupported")]
            DriverNameNotSupported,
            
            /// <summary>
            /// Enum FirmwareVersionNotSupported for "FirmwareVersionNotSupported"
            /// </summary>
            [EnumMember(Value = "FirmwareVersionNotSupported")]
            FirmwareVersionNotSupported,
            
            /// <summary>
            /// Enum DriverVersionNotSupported for "DriverVersionNotSupported"
            /// </summary>
            [EnumMember(Value = "DriverVersionNotSupported")]
            DriverVersionNotSupported,
            
            /// <summary>
            /// Enum FirmwareVersionDriverVersionCombinationNotSupported for "FirmwareVersionDriverVersionCombinationNotSupported"
            /// </summary>
            [EnumMember(Value = "FirmwareVersionDriverVersionCombinationNotSupported")]
            FirmwareVersionDriverVersionCombinationNotSupported,
            
            /// <summary>
            /// Enum FirmwareVersionAndDriverVersionNotSupported for "FirmwareVersionAndDriverVersionNotSupported"
            /// </summary>
            [EnumMember(Value = "FirmwareVersionAndDriverVersionNotSupported")]
            FirmwareVersionAndDriverVersionNotSupported,
            
            /// <summary>
            /// Enum FirmwareVersionAndDriverNameNotSupported for "FirmwareVersionAndDriverNameNotSupported"
            /// </summary>
            [EnumMember(Value = "FirmwareVersionAndDriverNameNotSupported")]
            FirmwareVersionAndDriverNameNotSupported,
            
            /// <summary>
            /// Enum InternalError for "InternalError"
            /// </summary>
            [EnumMember(Value = "InternalError")]
            InternalError,
            
            /// <summary>
            /// Enum MarshallingError for "MarshallingError"
            /// </summary>
            [EnumMember(Value = "MarshallingError")]
            MarshallingError
        }

        /// <summary>
        /// Error code indicating the support status  
        /// </summary>
        /// <value>Error code indicating the support status  </value>
        [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HclProduct" /> class.
        /// </summary>
        /// <param name="DriverNames">supported driver names  .</param>
        /// <param name="Firmwares">supported firmware list  .</param>
        /// <param name="Id">Id.</param>
        /// <param name="Model">Model/PID of the product/adapter  .</param>
        /// <param name="Revision">revision of the adapter model  .</param>
        /// <param name="Vendor">Vendor of the adapter   .</param>
        public HclProduct(List<string> DriverNames = default(List<string>), List<HclFirmware> Firmwares = default(List<HclFirmware>), string Id = default(string), string Model = default(string), string Revision = default(string), string Vendor = default(string))
        {
            this.DriverNames = DriverNames;
            this.Firmwares = Firmwares;
            this.Id = Id;
            this.Model = Model;
            this.Revision = Revision;
            this.Vendor = Vendor;
        }
        
        /// <summary>
        /// supported driver names  
        /// </summary>
        /// <value>supported driver names  </value>
        [DataMember(Name="DriverNames", EmitDefaultValue=false)]
        public List<string> DriverNames { get; set; }


        /// <summary>
        /// supported firmware list  
        /// </summary>
        /// <value>supported firmware list  </value>
        [DataMember(Name="Firmwares", EmitDefaultValue=false)]
        public List<HclFirmware> Firmwares { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Model/PID of the product/adapter  
        /// </summary>
        /// <value>Model/PID of the product/adapter  </value>
        [DataMember(Name="Model", EmitDefaultValue=false)]
        public string Model { get; set; }

        /// <summary>
        /// revision of the adapter model  
        /// </summary>
        /// <value>revision of the adapter model  </value>
        [DataMember(Name="Revision", EmitDefaultValue=false)]
        public string Revision { get; set; }

        /// <summary>
        /// Vendor of the adapter   
        /// </summary>
        /// <value>Vendor of the adapter   </value>
        [DataMember(Name="Vendor", EmitDefaultValue=false)]
        public string Vendor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HclProduct {\n");
            sb.Append("  DriverNames: ").Append(DriverNames).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Firmwares: ").Append(Firmwares).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
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
            return this.Equals(obj as HclProduct);
        }

        /// <summary>
        /// Returns true if HclProduct instances are equal
        /// </summary>
        /// <param name="other">Instance of HclProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HclProduct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DriverNames == other.DriverNames ||
                    this.DriverNames != null &&
                    this.DriverNames.SequenceEqual(other.DriverNames)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.Firmwares == other.Firmwares ||
                    this.Firmwares != null &&
                    this.Firmwares.SequenceEqual(other.Firmwares)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
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
                if (this.DriverNames != null)
                    hash = hash * 59 + this.DriverNames.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.Firmwares != null)
                    hash = hash * 59 + this.Firmwares.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
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
