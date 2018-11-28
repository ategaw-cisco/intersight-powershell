/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-261
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
    /// HyperflexStPlatformClusterResiliencyInfo
    /// </summary>
    [DataContract]
    public partial class HyperflexStPlatformClusterResiliencyInfo :  IEquatable<HyperflexStPlatformClusterResiliencyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexStPlatformClusterResiliencyInfo" /> class.
        /// </summary>
        /// <param name="Messages">Messages.</param>
        /// <param name="MessagesIterator">MessagesIterator.</param>
        public HyperflexStPlatformClusterResiliencyInfo(List<string> Messages = default(List<string>), Object MessagesIterator = default(Object))
        {
            this.Messages = Messages;
            this.MessagesIterator = MessagesIterator;
        }
        
        /// <summary>
        /// Gets or Sets HddFailuresTolerable
        /// </summary>
        [DataMember(Name="HddFailuresTolerable", EmitDefaultValue=false)]
        public long? HddFailuresTolerable { get; private set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name="Messages", EmitDefaultValue=false)]
        public List<string> Messages { get; set; }

        /// <summary>
        /// Gets or Sets MessagesIterator
        /// </summary>
        [DataMember(Name="MessagesIterator", EmitDefaultValue=false)]
        public Object MessagesIterator { get; set; }

        /// <summary>
        /// Gets or Sets MessagesSize
        /// </summary>
        [DataMember(Name="MessagesSize", EmitDefaultValue=false)]
        public long? MessagesSize { get; private set; }

        /// <summary>
        /// Gets or Sets NodeFailuresTolerable
        /// </summary>
        [DataMember(Name="NodeFailuresTolerable", EmitDefaultValue=false)]
        public long? NodeFailuresTolerable { get; private set; }

        /// <summary>
        /// Gets or Sets SsdFailuresTolerable
        /// </summary>
        [DataMember(Name="SsdFailuresTolerable", EmitDefaultValue=false)]
        public long? SsdFailuresTolerable { get; private set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="State", EmitDefaultValue=false)]
        public string State { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexStPlatformClusterResiliencyInfo {\n");
            sb.Append("  HddFailuresTolerable: ").Append(HddFailuresTolerable).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  MessagesIterator: ").Append(MessagesIterator).Append("\n");
            sb.Append("  MessagesSize: ").Append(MessagesSize).Append("\n");
            sb.Append("  NodeFailuresTolerable: ").Append(NodeFailuresTolerable).Append("\n");
            sb.Append("  SsdFailuresTolerable: ").Append(SsdFailuresTolerable).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as HyperflexStPlatformClusterResiliencyInfo);
        }

        /// <summary>
        /// Returns true if HyperflexStPlatformClusterResiliencyInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexStPlatformClusterResiliencyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexStPlatformClusterResiliencyInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HddFailuresTolerable == other.HddFailuresTolerable ||
                    this.HddFailuresTolerable != null &&
                    this.HddFailuresTolerable.Equals(other.HddFailuresTolerable)
                ) && 
                (
                    this.Messages == other.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(other.Messages)
                ) && 
                (
                    this.MessagesIterator == other.MessagesIterator ||
                    this.MessagesIterator != null &&
                    this.MessagesIterator.Equals(other.MessagesIterator)
                ) && 
                (
                    this.MessagesSize == other.MessagesSize ||
                    this.MessagesSize != null &&
                    this.MessagesSize.Equals(other.MessagesSize)
                ) && 
                (
                    this.NodeFailuresTolerable == other.NodeFailuresTolerable ||
                    this.NodeFailuresTolerable != null &&
                    this.NodeFailuresTolerable.Equals(other.NodeFailuresTolerable)
                ) && 
                (
                    this.SsdFailuresTolerable == other.SsdFailuresTolerable ||
                    this.SsdFailuresTolerable != null &&
                    this.SsdFailuresTolerable.Equals(other.SsdFailuresTolerable)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                if (this.HddFailuresTolerable != null)
                    hash = hash * 59 + this.HddFailuresTolerable.GetHashCode();
                if (this.Messages != null)
                    hash = hash * 59 + this.Messages.GetHashCode();
                if (this.MessagesIterator != null)
                    hash = hash * 59 + this.MessagesIterator.GetHashCode();
                if (this.MessagesSize != null)
                    hash = hash * 59 + this.MessagesSize.GetHashCode();
                if (this.NodeFailuresTolerable != null)
                    hash = hash * 59 + this.NodeFailuresTolerable.GetHashCode();
                if (this.SsdFailuresTolerable != null)
                    hash = hash * 59 + this.SsdFailuresTolerable.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
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
