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
    /// HyperflexHxLinkDt
    /// </summary>
    [DataContract]
    public partial class HyperflexHxLinkDt :  IEquatable<HyperflexHxLinkDt>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            
            /// <summary>
            /// Enum POST for "POST"
            /// </summary>
            [EnumMember(Value = "POST")]
            POST,
            
            /// <summary>
            /// Enum GET for "GET"
            /// </summary>
            [EnumMember(Value = "GET")]
            GET,
            
            /// <summary>
            /// Enum PUT for "PUT"
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUT,
            
            /// <summary>
            /// Enum DELETE for "DELETE"
            /// </summary>
            [EnumMember(Value = "DELETE")]
            DELETE
        }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="Method", EmitDefaultValue=false)]
        public MethodEnum? Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexHxLinkDt" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public HyperflexHxLinkDt()
        {
        }
        
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public string Comments { get; private set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name="Href", EmitDefaultValue=false)]
        public string Href { get; private set; }


        /// <summary>
        /// Gets or Sets Rel
        /// </summary>
        [DataMember(Name="Rel", EmitDefaultValue=false)]
        public string Rel { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexHxLinkDt {\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Rel: ").Append(Rel).Append("\n");
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
            return this.Equals(obj as HyperflexHxLinkDt);
        }

        /// <summary>
        /// Returns true if HyperflexHxLinkDt instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexHxLinkDt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexHxLinkDt other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.Href == other.Href ||
                    this.Href != null &&
                    this.Href.Equals(other.Href)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.Rel == other.Rel ||
                    this.Rel != null &&
                    this.Rel.Equals(other.Rel)
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
                if (this.Comments != null)
                    hash = hash * 59 + this.Comments.GetHashCode();
                if (this.Href != null)
                    hash = hash * 59 + this.Href.GetHashCode();
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                if (this.Rel != null)
                    hash = hash * 59 + this.Rel.GetHashCode();
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
