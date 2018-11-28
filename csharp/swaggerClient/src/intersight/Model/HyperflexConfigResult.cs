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
    /// Represents the profile configuration (deploy, validation) results with the overall state and detailed result messages. 
    /// </summary>
    [DataContract]
    public partial class HyperflexConfigResult :  IEquatable<HyperflexConfigResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexConfigResult" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="ConfigStage">The current running stage of the configuration or workflow.  .</param>
        /// <param name="ConfigState">Indicates overall configuration state for applying the configuration to the end point Values  - - ok, ok-with-warning, errored  .</param>
        /// <param name="ValidationState">Indicates overall state for logical model validation Values  - - ok, ok-with-warning, errored   .</param>
        /// <param name="ClusterProfile">ClusterProfile.</param>
        /// <param name="ConfigProgress">The progress percentage of the running configuration or workflow  .</param>
        /// <param name="Duration">The duration of the running configuration or workflow  .</param>
        /// <param name="ResultEntries">Detailed result entries for both validation &amp; configration. Each result entry can be error/warning/info messages and the context. .</param>
        /// <param name="StartTime">The start time of the configuration or workflow   .</param>
        public HyperflexConfigResult(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string ConfigStage = default(string), string ConfigState = default(string), string ValidationState = default(string), HyperflexClusterProfileRef ClusterProfile = default(HyperflexClusterProfileRef), string ConfigProgress = default(string), string Duration = default(string), List<HyperflexConfigResultEntryRef> ResultEntries = default(List<HyperflexConfigResultEntryRef>), string StartTime = default(string))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.ConfigStage = ConfigStage;
            this.ConfigState = ConfigState;
            this.ValidationState = ValidationState;
            this.ClusterProfile = ClusterProfile;
            this.ConfigProgress = ConfigProgress;
            this.Duration = Duration;
            this.ResultEntries = ResultEntries;
            this.StartTime = StartTime;
        }
        
        /// <summary>
        /// The Account ID for this managed object.  
        /// </summary>
        /// <value>The Account ID for this managed object.  </value>
        [DataMember(Name="AccountMoid", EmitDefaultValue=false)]
        public string AccountMoid { get; private set; }

        /// <summary>
        /// Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. 
        /// </summary>
        /// <value>Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. </value>
        [DataMember(Name="Ancestors", EmitDefaultValue=false)]
        public List<MoBaseMoRef> Ancestors { get; set; }

        /// <summary>
        /// The time when this managed object was created.  
        /// </summary>
        /// <value>The time when this managed object was created.  </value>
        [DataMember(Name="CreateTime", EmitDefaultValue=false)]
        public DateTime? CreateTime { get; private set; }

        /// <summary>
        /// The time when this managed object was last modified.  
        /// </summary>
        /// <value>The time when this managed object was last modified.  </value>
        [DataMember(Name="ModTime", EmitDefaultValue=false)]
        public DateTime? ModTime { get; private set; }

        /// <summary>
        /// A unique identifier of this Managed Object instance.  
        /// </summary>
        /// <value>A unique identifier of this Managed Object instance.  </value>
        [DataMember(Name="Moid", EmitDefaultValue=false)]
        public string Moid { get; set; }

        /// <summary>
        /// The fully-qualified type of this managed object, e.g. the class name.  
        /// </summary>
        /// <value>The fully-qualified type of this managed object, e.g. the class name.  </value>
        [DataMember(Name="ObjectType", EmitDefaultValue=false)]
        public string ObjectType { get; private set; }

        /// <summary>
        /// An array of owners which represent effective ownership of this object.   
        /// </summary>
        /// <value>An array of owners which represent effective ownership of this object.   </value>
        [DataMember(Name="Owners", EmitDefaultValue=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// The direct ancestor of this managed object in the containment hierarchy. 
        /// </summary>
        /// <value>The direct ancestor of this managed object in the containment hierarchy. </value>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public MoBaseMoRef Parent { get; set; }

        /// <summary>
        /// An array of tags, which allow to add key, value meta-data to managed objects.  
        /// </summary>
        /// <value>An array of tags, which allow to add key, value meta-data to managed objects.  </value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<MoTag> Tags { get; set; }

        /// <summary>
        /// The versioning info for this managed object   
        /// </summary>
        /// <value>The versioning info for this managed object   </value>
        [DataMember(Name="VersionContext", EmitDefaultValue=false)]
        public MoVersionContext VersionContext { get; set; }

        /// <summary>
        /// The current running stage of the configuration or workflow.  
        /// </summary>
        /// <value>The current running stage of the configuration or workflow.  </value>
        [DataMember(Name="ConfigStage", EmitDefaultValue=false)]
        public string ConfigStage { get; set; }

        /// <summary>
        /// Indicates overall configuration state for applying the configuration to the end point Values  - - ok, ok-with-warning, errored  
        /// </summary>
        /// <value>Indicates overall configuration state for applying the configuration to the end point Values  - - ok, ok-with-warning, errored  </value>
        [DataMember(Name="ConfigState", EmitDefaultValue=false)]
        public string ConfigState { get; set; }

        /// <summary>
        /// Indicates overall state for logical model validation Values  - - ok, ok-with-warning, errored   
        /// </summary>
        /// <value>Indicates overall state for logical model validation Values  - - ok, ok-with-warning, errored   </value>
        [DataMember(Name="ValidationState", EmitDefaultValue=false)]
        public string ValidationState { get; set; }

        /// <summary>
        /// Gets or Sets ClusterProfile
        /// </summary>
        [DataMember(Name="ClusterProfile", EmitDefaultValue=false)]
        public HyperflexClusterProfileRef ClusterProfile { get; set; }

        /// <summary>
        /// The progress percentage of the running configuration or workflow  
        /// </summary>
        /// <value>The progress percentage of the running configuration or workflow  </value>
        [DataMember(Name="ConfigProgress", EmitDefaultValue=false)]
        public string ConfigProgress { get; set; }

        /// <summary>
        /// The duration of the running configuration or workflow  
        /// </summary>
        /// <value>The duration of the running configuration or workflow  </value>
        [DataMember(Name="Duration", EmitDefaultValue=false)]
        public string Duration { get; set; }

        /// <summary>
        /// Detailed result entries for both validation &amp; configration. Each result entry can be error/warning/info messages and the context. 
        /// </summary>
        /// <value>Detailed result entries for both validation &amp; configration. Each result entry can be error/warning/info messages and the context. </value>
        [DataMember(Name="ResultEntries", EmitDefaultValue=false)]
        public List<HyperflexConfigResultEntryRef> ResultEntries { get; set; }

        /// <summary>
        /// The start time of the configuration or workflow   
        /// </summary>
        /// <value>The start time of the configuration or workflow   </value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexConfigResult {\n");
            sb.Append("  AccountMoid: ").Append(AccountMoid).Append("\n");
            sb.Append("  Ancestors: ").Append(Ancestors).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ModTime: ").Append(ModTime).Append("\n");
            sb.Append("  Moid: ").Append(Moid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  VersionContext: ").Append(VersionContext).Append("\n");
            sb.Append("  ConfigStage: ").Append(ConfigStage).Append("\n");
            sb.Append("  ConfigState: ").Append(ConfigState).Append("\n");
            sb.Append("  ValidationState: ").Append(ValidationState).Append("\n");
            sb.Append("  ClusterProfile: ").Append(ClusterProfile).Append("\n");
            sb.Append("  ConfigProgress: ").Append(ConfigProgress).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  ResultEntries: ").Append(ResultEntries).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(obj as HyperflexConfigResult);
        }

        /// <summary>
        /// Returns true if HyperflexConfigResult instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexConfigResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexConfigResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountMoid == other.AccountMoid ||
                    this.AccountMoid != null &&
                    this.AccountMoid.Equals(other.AccountMoid)
                ) && 
                (
                    this.Ancestors == other.Ancestors ||
                    this.Ancestors != null &&
                    this.Ancestors.SequenceEqual(other.Ancestors)
                ) && 
                (
                    this.CreateTime == other.CreateTime ||
                    this.CreateTime != null &&
                    this.CreateTime.Equals(other.CreateTime)
                ) && 
                (
                    this.ModTime == other.ModTime ||
                    this.ModTime != null &&
                    this.ModTime.Equals(other.ModTime)
                ) && 
                (
                    this.Moid == other.Moid ||
                    this.Moid != null &&
                    this.Moid.Equals(other.Moid)
                ) && 
                (
                    this.ObjectType == other.ObjectType ||
                    this.ObjectType != null &&
                    this.ObjectType.Equals(other.ObjectType)
                ) && 
                (
                    this.Owners == other.Owners ||
                    this.Owners != null &&
                    this.Owners.SequenceEqual(other.Owners)
                ) && 
                (
                    this.Parent == other.Parent ||
                    this.Parent != null &&
                    this.Parent.Equals(other.Parent)
                ) && 
                (
                    this.Tags == other.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    this.VersionContext == other.VersionContext ||
                    this.VersionContext != null &&
                    this.VersionContext.Equals(other.VersionContext)
                ) && 
                (
                    this.ConfigStage == other.ConfigStage ||
                    this.ConfigStage != null &&
                    this.ConfigStage.Equals(other.ConfigStage)
                ) && 
                (
                    this.ConfigState == other.ConfigState ||
                    this.ConfigState != null &&
                    this.ConfigState.Equals(other.ConfigState)
                ) && 
                (
                    this.ValidationState == other.ValidationState ||
                    this.ValidationState != null &&
                    this.ValidationState.Equals(other.ValidationState)
                ) && 
                (
                    this.ClusterProfile == other.ClusterProfile ||
                    this.ClusterProfile != null &&
                    this.ClusterProfile.Equals(other.ClusterProfile)
                ) && 
                (
                    this.ConfigProgress == other.ConfigProgress ||
                    this.ConfigProgress != null &&
                    this.ConfigProgress.Equals(other.ConfigProgress)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.ResultEntries == other.ResultEntries ||
                    this.ResultEntries != null &&
                    this.ResultEntries.SequenceEqual(other.ResultEntries)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
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
                if (this.AccountMoid != null)
                    hash = hash * 59 + this.AccountMoid.GetHashCode();
                if (this.Ancestors != null)
                    hash = hash * 59 + this.Ancestors.GetHashCode();
                if (this.CreateTime != null)
                    hash = hash * 59 + this.CreateTime.GetHashCode();
                if (this.ModTime != null)
                    hash = hash * 59 + this.ModTime.GetHashCode();
                if (this.Moid != null)
                    hash = hash * 59 + this.Moid.GetHashCode();
                if (this.ObjectType != null)
                    hash = hash * 59 + this.ObjectType.GetHashCode();
                if (this.Owners != null)
                    hash = hash * 59 + this.Owners.GetHashCode();
                if (this.Parent != null)
                    hash = hash * 59 + this.Parent.GetHashCode();
                if (this.Tags != null)
                    hash = hash * 59 + this.Tags.GetHashCode();
                if (this.VersionContext != null)
                    hash = hash * 59 + this.VersionContext.GetHashCode();
                if (this.ConfigStage != null)
                    hash = hash * 59 + this.ConfigStage.GetHashCode();
                if (this.ConfigState != null)
                    hash = hash * 59 + this.ConfigState.GetHashCode();
                if (this.ValidationState != null)
                    hash = hash * 59 + this.ValidationState.GetHashCode();
                if (this.ClusterProfile != null)
                    hash = hash * 59 + this.ClusterProfile.GetHashCode();
                if (this.ConfigProgress != null)
                    hash = hash * 59 + this.ConfigProgress.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                if (this.ResultEntries != null)
                    hash = hash * 59 + this.ResultEntries.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
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
