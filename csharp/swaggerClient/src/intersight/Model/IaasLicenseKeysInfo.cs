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
    /// License list with the utilization info for UCSD 
    /// </summary>
    [DataContract]
    public partial class IaasLicenseKeysInfo :  IEquatable<IaasLicenseKeysInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IaasLicenseKeysInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public IaasLicenseKeysInfo()
        {
        }
        
        /// <summary>
        /// Number of licenses available for the UCSD PID(Product ID)  
        /// </summary>
        /// <value>Number of licenses available for the UCSD PID(Product ID)  </value>
        [DataMember(Name="Count", EmitDefaultValue=false)]
        public long? Count { get; private set; }

        /// <summary>
        /// Expiration date for the license  
        /// </summary>
        /// <value>Expiration date for the license  </value>
        [DataMember(Name="ExpirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; private set; }

        /// <summary>
        /// Unique license ID  
        /// </summary>
        /// <value>Unique license ID  </value>
        [DataMember(Name="LicenseId", EmitDefaultValue=false)]
        public string LicenseId { get; private set; }

        /// <summary>
        /// PID(Product ID) for UCSD License   
        /// </summary>
        /// <value>PID(Product ID) for UCSD License   </value>
        [DataMember(Name="Pid", EmitDefaultValue=false)]
        public string Pid { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IaasLicenseKeysInfo {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  LicenseId: ").Append(LicenseId).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
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
            return this.Equals(obj as IaasLicenseKeysInfo);
        }

        /// <summary>
        /// Returns true if IaasLicenseKeysInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of IaasLicenseKeysInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IaasLicenseKeysInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.LicenseId == other.LicenseId ||
                    this.LicenseId != null &&
                    this.LicenseId.Equals(other.LicenseId)
                ) && 
                (
                    this.Pid == other.Pid ||
                    this.Pid != null &&
                    this.Pid.Equals(other.Pid)
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
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.LicenseId != null)
                    hash = hash * 59 + this.LicenseId.GetHashCode();
                if (this.Pid != null)
                    hash = hash * 59 + this.Pid.GetHashCode();
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
