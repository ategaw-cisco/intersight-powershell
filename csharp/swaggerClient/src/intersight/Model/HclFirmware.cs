/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-263
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
    /// model which holds the details of firmware version and driver version 
    /// </summary>
    [DataContract]
    public partial class HclFirmware :  IEquatable<HclFirmware>, IValidatableObject
    {
        /// <summary>
        /// Error code for the support status  
        /// </summary>
        /// <value>Error code for the support status  </value>
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
        /// Error code for the support status  
        /// </summary>
        /// <value>Error code for the support status  </value>
        [DataMember(Name="ErrorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HclFirmware" /> class.
        /// </summary>
        /// <param name="DriverName">Protocol for which the driver is provided.Ex enic, fnic,lsi_mr3  .</param>
        /// <param name="DriverVersion">Version of the Driver  .</param>
        /// <param name="FirmwareVersion">firmware version of the product/adapter supported  .</param>
        /// <param name="Id">Id.</param>
        public HclFirmware(string DriverName = default(string), string DriverVersion = default(string), string FirmwareVersion = default(string), string Id = default(string))
        {
            this.DriverName = DriverName;
            this.DriverVersion = DriverVersion;
            this.FirmwareVersion = FirmwareVersion;
            this.Id = Id;
        }
        
        /// <summary>
        /// Protocol for which the driver is provided.Ex enic, fnic,lsi_mr3  
        /// </summary>
        /// <value>Protocol for which the driver is provided.Ex enic, fnic,lsi_mr3  </value>
        [DataMember(Name="DriverName", EmitDefaultValue=false)]
        public string DriverName { get; set; }

        /// <summary>
        /// Version of the Driver  
        /// </summary>
        /// <value>Version of the Driver  </value>
        [DataMember(Name="DriverVersion", EmitDefaultValue=false)]
        public string DriverVersion { get; set; }


        /// <summary>
        /// firmware version of the product/adapter supported  
        /// </summary>
        /// <value>firmware version of the product/adapter supported  </value>
        [DataMember(Name="FirmwareVersion", EmitDefaultValue=false)]
        public string FirmwareVersion { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// True if the driver is latest recommended driver   
        /// </summary>
        /// <value>True if the driver is latest recommended driver   </value>
        [DataMember(Name="LatestDriver", EmitDefaultValue=false)]
        public bool? LatestDriver { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HclFirmware {\n");
            sb.Append("  DriverName: ").Append(DriverName).Append("\n");
            sb.Append("  DriverVersion: ").Append(DriverVersion).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LatestDriver: ").Append(LatestDriver).Append("\n");
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
            return this.Equals(obj as HclFirmware);
        }

        /// <summary>
        /// Returns true if HclFirmware instances are equal
        /// </summary>
        /// <param name="other">Instance of HclFirmware to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HclFirmware other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DriverName == other.DriverName ||
                    this.DriverName != null &&
                    this.DriverName.Equals(other.DriverName)
                ) && 
                (
                    this.DriverVersion == other.DriverVersion ||
                    this.DriverVersion != null &&
                    this.DriverVersion.Equals(other.DriverVersion)
                ) && 
                (
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.FirmwareVersion == other.FirmwareVersion ||
                    this.FirmwareVersion != null &&
                    this.FirmwareVersion.Equals(other.FirmwareVersion)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.LatestDriver == other.LatestDriver ||
                    this.LatestDriver != null &&
                    this.LatestDriver.Equals(other.LatestDriver)
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
                if (this.DriverName != null)
                    hash = hash * 59 + this.DriverName.GetHashCode();
                if (this.DriverVersion != null)
                    hash = hash * 59 + this.DriverVersion.GetHashCode();
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.FirmwareVersion != null)
                    hash = hash * 59 + this.FirmwareVersion.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.LatestDriver != null)
                    hash = hash * 59 + this.LatestDriver.GetHashCode();
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
