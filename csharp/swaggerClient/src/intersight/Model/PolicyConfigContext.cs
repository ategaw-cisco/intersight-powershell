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
    /// Configuration related state and results 
    /// </summary>
    [DataContract]
    public partial class PolicyConfigContext :  IEquatable<PolicyConfigContext>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConfigContext" /> class.
        /// </summary>
        /// <param name="ControlAction">System action to trigger the appropriate workflow. Values - - No_op, ConfigChange, Deploy, Unbind  .</param>
        /// <param name="ErrorState">Indicates a profile&#39;s error state. Values - - Validation-error (Static validation error), Pre-config-error (Runtime validation error), Config-error (Runtime configuration error)  .</param>
        public PolicyConfigContext(string ControlAction = default(string), string ErrorState = default(string))
        {
            this.ControlAction = ControlAction;
            this.ErrorState = ErrorState;
        }
        
        /// <summary>
        /// Indicates a profile&#39;s configuration deploying state Values - - Assigned, Not-assigned, Associated, Pending-changes, Validating, Configuring, Failed  
        /// </summary>
        /// <value>Indicates a profile&#39;s configuration deploying state Values - - Assigned, Not-assigned, Associated, Pending-changes, Validating, Configuring, Failed  </value>
        [DataMember(Name="ConfigState", EmitDefaultValue=false)]
        public string ConfigState { get; private set; }

        /// <summary>
        /// System action to trigger the appropriate workflow. Values - - No_op, ConfigChange, Deploy, Unbind  
        /// </summary>
        /// <value>System action to trigger the appropriate workflow. Values - - No_op, ConfigChange, Deploy, Unbind  </value>
        [DataMember(Name="ControlAction", EmitDefaultValue=false)]
        public string ControlAction { get; set; }

        /// <summary>
        /// Indicates a profile&#39;s error state. Values - - Validation-error (Static validation error), Pre-config-error (Runtime validation error), Config-error (Runtime configuration error)  
        /// </summary>
        /// <value>Indicates a profile&#39;s error state. Values - - Validation-error (Static validation error), Pre-config-error (Runtime validation error), Config-error (Runtime configuration error)  </value>
        [DataMember(Name="ErrorState", EmitDefaultValue=false)]
        public string ErrorState { get; set; }

        /// <summary>
        /// Combined state (configState, and operational state of the associated physical resource) to indicate the current state of the profile. Values - - n/a, Power-off, Pending-changes, Configuring, Ok, Failed   
        /// </summary>
        /// <value>Combined state (configState, and operational state of the associated physical resource) to indicate the current state of the profile. Values - - n/a, Power-off, Pending-changes, Configuring, Ok, Failed   </value>
        [DataMember(Name="OperState", EmitDefaultValue=false)]
        public string OperState { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyConfigContext {\n");
            sb.Append("  ConfigState: ").Append(ConfigState).Append("\n");
            sb.Append("  ControlAction: ").Append(ControlAction).Append("\n");
            sb.Append("  ErrorState: ").Append(ErrorState).Append("\n");
            sb.Append("  OperState: ").Append(OperState).Append("\n");
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
            return this.Equals(obj as PolicyConfigContext);
        }

        /// <summary>
        /// Returns true if PolicyConfigContext instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyConfigContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyConfigContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConfigState == other.ConfigState ||
                    this.ConfigState != null &&
                    this.ConfigState.Equals(other.ConfigState)
                ) && 
                (
                    this.ControlAction == other.ControlAction ||
                    this.ControlAction != null &&
                    this.ControlAction.Equals(other.ControlAction)
                ) && 
                (
                    this.ErrorState == other.ErrorState ||
                    this.ErrorState != null &&
                    this.ErrorState.Equals(other.ErrorState)
                ) && 
                (
                    this.OperState == other.OperState ||
                    this.OperState != null &&
                    this.OperState.Equals(other.OperState)
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
                if (this.ConfigState != null)
                    hash = hash * 59 + this.ConfigState.GetHashCode();
                if (this.ControlAction != null)
                    hash = hash * 59 + this.ControlAction.GetHashCode();
                if (this.ErrorState != null)
                    hash = hash * 59 + this.ErrorState.GetHashCode();
                if (this.OperState != null)
                    hash = hash * 59 + this.OperState.GetHashCode();
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
