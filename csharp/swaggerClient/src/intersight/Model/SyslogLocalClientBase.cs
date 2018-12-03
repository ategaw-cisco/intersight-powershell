/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-265
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
    /// Lists properties that are common to all local logging clients. It serves as base class for all local logging clients. 
    /// </summary>
    [DataContract]
    public partial class SyslogLocalClientBase :  IEquatable<SyslogLocalClientBase>, IValidatableObject
    {
        /// <summary>
        /// Lowest level of messages to be included in the local log   
        /// </summary>
        /// <value>Lowest level of messages to be included in the local log   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MinSeverityEnum
        {
            
            /// <summary>
            /// Enum Warning for "warning"
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning,
            
            /// <summary>
            /// Enum Emergency for "emergency"
            /// </summary>
            [EnumMember(Value = "emergency")]
            Emergency,
            
            /// <summary>
            /// Enum Alert for "alert"
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert,
            
            /// <summary>
            /// Enum Critical for "critical"
            /// </summary>
            [EnumMember(Value = "critical")]
            Critical,
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Notice for "notice"
            /// </summary>
            [EnumMember(Value = "notice")]
            Notice,
            
            /// <summary>
            /// Enum Informational for "informational"
            /// </summary>
            [EnumMember(Value = "informational")]
            Informational,
            
            /// <summary>
            /// Enum Debug for "debug"
            /// </summary>
            [EnumMember(Value = "debug")]
            Debug
        }

        /// <summary>
        /// Lowest level of messages to be included in the local log   
        /// </summary>
        /// <value>Lowest level of messages to be included in the local log   </value>
        [DataMember(Name="MinSeverity", EmitDefaultValue=false)]
        public MinSeverityEnum? MinSeverity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SyslogLocalClientBase" /> class.
        /// </summary>
        /// <param name="MinSeverity">Lowest level of messages to be included in the local log    (default to MinSeverityEnum.Warning).</param>
        public SyslogLocalClientBase(MinSeverityEnum? MinSeverity = MinSeverityEnum.Warning)
        {
            // use default value if no "MinSeverity" provided
            if (MinSeverity == null)
            {
                this.MinSeverity = MinSeverityEnum.Warning;
            }
            else
            {
                this.MinSeverity = MinSeverity;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SyslogLocalClientBase {\n");
            sb.Append("  MinSeverity: ").Append(MinSeverity).Append("\n");
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
            return this.Equals(obj as SyslogLocalClientBase);
        }

        /// <summary>
        /// Returns true if SyslogLocalClientBase instances are equal
        /// </summary>
        /// <param name="other">Instance of SyslogLocalClientBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SyslogLocalClientBase other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinSeverity == other.MinSeverity ||
                    this.MinSeverity != null &&
                    this.MinSeverity.Equals(other.MinSeverity)
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
                if (this.MinSeverity != null)
                    hash = hash * 59 + this.MinSeverity.GetHashCode();
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
