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
    /// Describes a condition under which a Mo Change Notification should be sent. The changeType, filter and changeSet conditions must all evaluate to True for a notification to be sent. 
    /// </summary>
    [DataContract]
    public partial class NotifsCondition :  IEquatable<NotifsCondition>, IValidatableObject
    {
        /// <summary>
        /// Indicates the type of change (create, update, delete) performed on the MO. 
        /// </summary>
        /// <value>Indicates the type of change (create, update, delete) performed on the MO. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChangeTypeEnum
        {
            
            /// <summary>
            /// Enum Update for "Update"
            /// </summary>
            [EnumMember(Value = "Update")]
            Update,
            
            /// <summary>
            /// Enum Create for "Create"
            /// </summary>
            [EnumMember(Value = "Create")]
            Create,
            
            /// <summary>
            /// Enum Delete for "Delete"
            /// </summary>
            [EnumMember(Value = "Delete")]
            Delete
        }

        /// <summary>
        /// Indicates the type of change (create, update, delete) performed on the MO. 
        /// </summary>
        /// <value>Indicates the type of change (create, update, delete) performed on the MO. </value>
        [DataMember(Name="ChangeType", EmitDefaultValue=false)]
        public ChangeTypeEnum? ChangeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifsCondition" /> class.
        /// </summary>
        /// <param name="ChangeSet">A list of properties which have been modified on an MO in a transaction. Applicable only for MO updates, ignored for creation/deletion. Evaluates to True if any of the listed properties has changed or if the list is empty. Eg: ConnectorStatus,ConnectorVersion .</param>
        /// <param name="ChangeType">Indicates the type of change (create, update, delete) performed on the MO.  (default to ChangeTypeEnum.Update).</param>
        /// <param name="Filter">An Odata-style filter which is evaluated against the state of an MO at the time of transaction commit. An empty filter string evaluates to True. Eg: ConnectionStatus eq &#39;Connected&#39; .</param>
        public NotifsCondition(List<string> ChangeSet = default(List<string>), ChangeTypeEnum? ChangeType = ChangeTypeEnum.Update, string Filter = default(string))
        {
            this.ChangeSet = ChangeSet;
            // use default value if no "ChangeType" provided
            if (ChangeType == null)
            {
                this.ChangeType = ChangeTypeEnum.Update;
            }
            else
            {
                this.ChangeType = ChangeType;
            }
            this.Filter = Filter;
        }
        
        /// <summary>
        /// A list of properties which have been modified on an MO in a transaction. Applicable only for MO updates, ignored for creation/deletion. Evaluates to True if any of the listed properties has changed or if the list is empty. Eg: ConnectorStatus,ConnectorVersion 
        /// </summary>
        /// <value>A list of properties which have been modified on an MO in a transaction. Applicable only for MO updates, ignored for creation/deletion. Evaluates to True if any of the listed properties has changed or if the list is empty. Eg: ConnectorStatus,ConnectorVersion </value>
        [DataMember(Name="ChangeSet", EmitDefaultValue=false)]
        public List<string> ChangeSet { get; set; }


        /// <summary>
        /// An Odata-style filter which is evaluated against the state of an MO at the time of transaction commit. An empty filter string evaluates to True. Eg: ConnectionStatus eq &#39;Connected&#39; 
        /// </summary>
        /// <value>An Odata-style filter which is evaluated against the state of an MO at the time of transaction commit. An empty filter string evaluates to True. Eg: ConnectionStatus eq &#39;Connected&#39; </value>
        [DataMember(Name="Filter", EmitDefaultValue=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifsCondition {\n");
            sb.Append("  ChangeSet: ").Append(ChangeSet).Append("\n");
            sb.Append("  ChangeType: ").Append(ChangeType).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(obj as NotifsCondition);
        }

        /// <summary>
        /// Returns true if NotifsCondition instances are equal
        /// </summary>
        /// <param name="other">Instance of NotifsCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifsCondition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChangeSet == other.ChangeSet ||
                    this.ChangeSet != null &&
                    this.ChangeSet.SequenceEqual(other.ChangeSet)
                ) && 
                (
                    this.ChangeType == other.ChangeType ||
                    this.ChangeType != null &&
                    this.ChangeType.Equals(other.ChangeType)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
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
                if (this.ChangeSet != null)
                    hash = hash * 59 + this.ChangeSet.GetHashCode();
                if (this.ChangeType != null)
                    hash = hash * 59 + this.ChangeType.GetHashCode();
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
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
