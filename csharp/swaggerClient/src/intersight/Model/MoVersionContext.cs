/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-228
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
    /// VersionContext contains the versioning info for an object 
    /// </summary>
    [DataContract]
    public partial class MoVersionContext :  IEquatable<MoVersionContext>, IValidatableObject
    {
        /// <summary>
        /// Specifies type of version. Currently the only supported value is ”Configured\&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. 
        /// </summary>
        /// <value>Specifies type of version. Currently the only supported value is ”Configured\&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionTypeEnum
        {
            
            /// <summary>
            /// Enum Modified for "Modified"
            /// </summary>
            [EnumMember(Value = "Modified")]
            Modified,
            
            /// <summary>
            /// Enum Configured for "Configured"
            /// </summary>
            [EnumMember(Value = "Configured")]
            Configured,
            
            /// <summary>
            /// Enum Deployed for "Deployed"
            /// </summary>
            [EnumMember(Value = "Deployed")]
            Deployed
        }

        /// <summary>
        /// Specifies type of version. Currently the only supported value is ”Configured\&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. 
        /// </summary>
        /// <value>Specifies type of version. Currently the only supported value is ”Configured\&quot; that is used to keep track of snapshots of policies and profiles that are intended to be configured to target endpoints. </value>
        [DataMember(Name="VersionType", EmitDefaultValue=false)]
        public VersionTypeEnum? VersionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoVersionContext" /> class.
        /// </summary>
        /// <param name="InterestedMos">A collection of objects that have reference to this versioned object. The lifecycle of the versioned object is based on the interestedMos list; the versioned object will be purged when interestedMos is empty. .</param>
        /// <param name="RefMo">A reference to the original mo.  .</param>
        public MoVersionContext(List<MoMoRef> InterestedMos = default(List<MoMoRef>), MoMoRef RefMo = default(MoMoRef))
        {
            this.InterestedMos = InterestedMos;
            this.RefMo = RefMo;
        }
        
        /// <summary>
        /// A collection of objects that have reference to this versioned object. The lifecycle of the versioned object is based on the interestedMos list; the versioned object will be purged when interestedMos is empty. 
        /// </summary>
        /// <value>A collection of objects that have reference to this versioned object. The lifecycle of the versioned object is based on the interestedMos list; the versioned object will be purged when interestedMos is empty. </value>
        [DataMember(Name="InterestedMos", EmitDefaultValue=false)]
        public List<MoMoRef> InterestedMos { get; set; }

        /// <summary>
        /// A reference to the original mo.  
        /// </summary>
        /// <value>A reference to the original mo.  </value>
        [DataMember(Name="RefMo", EmitDefaultValue=false)]
        public MoMoRef RefMo { get; set; }

        /// <summary>
        /// The time this versioned mo was created.  
        /// </summary>
        /// <value>The time this versioned mo was created.  </value>
        [DataMember(Name="Timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; private set; }

        /// <summary>
        /// The version of the mo, eg an incrementing number or a hash id.  
        /// </summary>
        /// <value>The version of the mo, eg an incrementing number or a hash id.  </value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; private set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MoVersionContext {\n");
            sb.Append("  InterestedMos: ").Append(InterestedMos).Append("\n");
            sb.Append("  RefMo: ").Append(RefMo).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  VersionType: ").Append(VersionType).Append("\n");
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
            return this.Equals(obj as MoVersionContext);
        }

        /// <summary>
        /// Returns true if MoVersionContext instances are equal
        /// </summary>
        /// <param name="other">Instance of MoVersionContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MoVersionContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InterestedMos == other.InterestedMos ||
                    this.InterestedMos != null &&
                    this.InterestedMos.SequenceEqual(other.InterestedMos)
                ) && 
                (
                    this.RefMo == other.RefMo ||
                    this.RefMo != null &&
                    this.RefMo.Equals(other.RefMo)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.VersionType == other.VersionType ||
                    this.VersionType != null &&
                    this.VersionType.Equals(other.VersionType)
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
                if (this.InterestedMos != null)
                    hash = hash * 59 + this.InterestedMos.GetHashCode();
                if (this.RefMo != null)
                    hash = hash * 59 + this.RefMo.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.VersionType != null)
                    hash = hash * 59 + this.VersionType.GetHashCode();
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
