/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-262
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
    /// Defines the configuration changes at the summary level including configuration changes and disruptions. 
    /// </summary>
    [DataContract]
    public partial class PolicyConfigChange :  IEquatable<PolicyConfigChange>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConfigChange" /> class.
        /// </summary>
        /// <param name="Changes">Configuration changes  .</param>
        /// <param name="Disruptions">Configuration disruptions   .</param>
        public PolicyConfigChange(List<string> Changes = default(List<string>), List<string> Disruptions = default(List<string>))
        {
            this.Changes = Changes;
            this.Disruptions = Disruptions;
        }
        
        /// <summary>
        /// Configuration changes  
        /// </summary>
        /// <value>Configuration changes  </value>
        [DataMember(Name="Changes", EmitDefaultValue=false)]
        public List<string> Changes { get; set; }

        /// <summary>
        /// Configuration disruptions   
        /// </summary>
        /// <value>Configuration disruptions   </value>
        [DataMember(Name="Disruptions", EmitDefaultValue=false)]
        public List<string> Disruptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyConfigChange {\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  Disruptions: ").Append(Disruptions).Append("\n");
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
            return this.Equals(obj as PolicyConfigChange);
        }

        /// <summary>
        /// Returns true if PolicyConfigChange instances are equal
        /// </summary>
        /// <param name="other">Instance of PolicyConfigChange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyConfigChange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) && 
                (
                    this.Disruptions == other.Disruptions ||
                    this.Disruptions != null &&
                    this.Disruptions.SequenceEqual(other.Disruptions)
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
                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();
                if (this.Disruptions != null)
                    hash = hash * 59 + this.Disruptions.GetHashCode();
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
