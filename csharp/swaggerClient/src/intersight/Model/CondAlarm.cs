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
    /// A state-full entity representing a found problem. Alarms can be reported by the managed system itself or can be determined by Starship. 
    /// </summary>
    [DataContract]
    public partial class CondAlarm :  IEquatable<CondAlarm>, IValidatableObject
    {
        /// <summary>
        /// Indicates the original severity when the alarm was first created.  
        /// </summary>
        /// <value>Indicates the original severity when the alarm was first created.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OrigSeverityEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Info for "Info"
            /// </summary>
            [EnumMember(Value = "Info")]
            Info,
            
            /// <summary>
            /// Enum Critical for "Critical"
            /// </summary>
            [EnumMember(Value = "Critical")]
            Critical,
            
            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning,
            
            /// <summary>
            /// Enum Cleared for "Cleared"
            /// </summary>
            [EnumMember(Value = "Cleared")]
            Cleared
        }

        /// <summary>
        /// Indicates the severity of the alarm. Valid values are Critical, Warning, Info, and Cleared.   
        /// </summary>
        /// <value>Indicates the severity of the alarm. Valid values are Critical, Warning, Info, and Cleared.   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Info for "Info"
            /// </summary>
            [EnumMember(Value = "Info")]
            Info,
            
            /// <summary>
            /// Enum Critical for "Critical"
            /// </summary>
            [EnumMember(Value = "Critical")]
            Critical,
            
            /// <summary>
            /// Enum Warning for "Warning"
            /// </summary>
            [EnumMember(Value = "Warning")]
            Warning,
            
            /// <summary>
            /// Enum Cleared for "Cleared"
            /// </summary>
            [EnumMember(Value = "Cleared")]
            Cleared
        }

        /// <summary>
        /// Indicates the original severity when the alarm was first created.  
        /// </summary>
        /// <value>Indicates the original severity when the alarm was first created.  </value>
        [DataMember(Name="OrigSeverity", EmitDefaultValue=false)]
        public OrigSeverityEnum? OrigSeverity { get; set; }
        /// <summary>
        /// Indicates the severity of the alarm. Valid values are Critical, Warning, Info, and Cleared.   
        /// </summary>
        /// <value>Indicates the severity of the alarm. Valid values are Critical, Warning, Info, and Cleared.   </value>
        [DataMember(Name="Severity", EmitDefaultValue=false)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CondAlarm" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="AffectedMoId">MoId of the affected object from the managed system&#39;s point of view.  .</param>
        /// <param name="AffectedMoType">Managed system affected object type. For example Adaptor, FI, CIMC.  .</param>
        /// <param name="AffectedObject">A unique key for an alarm instance. This is a combination of a unique system name and msAffectedObject  .</param>
        /// <param name="AncestorMoId">Parent MoId of the fault from managed system. For example, Blade moid for adaptor fault.  .</param>
        /// <param name="AncestorMoType">Parent MO type of the fault from managed system. For example, Blade for adaptor fault.  .</param>
        /// <param name="Code">A unique alarm code. For alarms mapped from UCS faults, this will be the same as the UCS fault code.  .</param>
        /// <param name="CreationTime">The time the alarm was created.  .</param>
        /// <param name="Description">A longer description of the alarm than the name. The description contains details of the component reporting the issue.  .</param>
        /// <param name="LastTransitionTime">The time the alarm last had a change in severity.  .</param>
        /// <param name="MsAffectedObject">A unique key for the alarm from the managed system&#39;s point of view. For example, in the case of UCS, this is the fault&#39;s dn.  .</param>
        /// <param name="Name">Uniquely identifies the type of alarm. For alarms originating from Starship, this will be a descriptive name. For alarms that are mapped from faults, the name will be derived from fault properties. For example, alarms mapped from UCS faults will use a prefix of UCS and appended with the fault code.  .</param>
        /// <param name="OrigSeverity">Indicates the original severity when the alarm was first created.   (default to OrigSeverityEnum.None).</param>
        /// <param name="RegisteredDevice">Relationship to set accountMoid on Alarms. With \&quot;onpeerdelete\&quot; set to \&quot;cascade\&quot;, Alarms get deleted when the associated registered device is deleted. .</param>
        /// <param name="Severity">Indicates the severity of the alarm. Valid values are Critical, Warning, Info, and Cleared.    (default to SeverityEnum.None).</param>
        public CondAlarm(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string AffectedMoId = default(string), string AffectedMoType = default(string), string AffectedObject = default(string), string AncestorMoId = default(string), string AncestorMoType = default(string), string Code = default(string), DateTime? CreationTime = default(DateTime?), string Description = default(string), DateTime? LastTransitionTime = default(DateTime?), string MsAffectedObject = default(string), string Name = default(string), OrigSeverityEnum? OrigSeverity = OrigSeverityEnum.None, AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), SeverityEnum? Severity = SeverityEnum.None)
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.AffectedMoId = AffectedMoId;
            this.AffectedMoType = AffectedMoType;
            this.AffectedObject = AffectedObject;
            this.AncestorMoId = AncestorMoId;
            this.AncestorMoType = AncestorMoType;
            this.Code = Code;
            this.CreationTime = CreationTime;
            this.Description = Description;
            this.LastTransitionTime = LastTransitionTime;
            this.MsAffectedObject = MsAffectedObject;
            this.Name = Name;
            // use default value if no "OrigSeverity" provided
            if (OrigSeverity == null)
            {
                this.OrigSeverity = OrigSeverityEnum.None;
            }
            else
            {
                this.OrigSeverity = OrigSeverity;
            }
            this.RegisteredDevice = RegisteredDevice;
            // use default value if no "Severity" provided
            if (Severity == null)
            {
                this.Severity = SeverityEnum.None;
            }
            else
            {
                this.Severity = Severity;
            }
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
        /// MoId of the affected object from the managed system&#39;s point of view.  
        /// </summary>
        /// <value>MoId of the affected object from the managed system&#39;s point of view.  </value>
        [DataMember(Name="AffectedMoId", EmitDefaultValue=false)]
        public string AffectedMoId { get; set; }

        /// <summary>
        /// Managed system affected object type. For example Adaptor, FI, CIMC.  
        /// </summary>
        /// <value>Managed system affected object type. For example Adaptor, FI, CIMC.  </value>
        [DataMember(Name="AffectedMoType", EmitDefaultValue=false)]
        public string AffectedMoType { get; set; }

        /// <summary>
        /// A unique key for an alarm instance. This is a combination of a unique system name and msAffectedObject  
        /// </summary>
        /// <value>A unique key for an alarm instance. This is a combination of a unique system name and msAffectedObject  </value>
        [DataMember(Name="AffectedObject", EmitDefaultValue=false)]
        public string AffectedObject { get; set; }

        /// <summary>
        /// Parent MoId of the fault from managed system. For example, Blade moid for adaptor fault.  
        /// </summary>
        /// <value>Parent MoId of the fault from managed system. For example, Blade moid for adaptor fault.  </value>
        [DataMember(Name="AncestorMoId", EmitDefaultValue=false)]
        public string AncestorMoId { get; set; }

        /// <summary>
        /// Parent MO type of the fault from managed system. For example, Blade for adaptor fault.  
        /// </summary>
        /// <value>Parent MO type of the fault from managed system. For example, Blade for adaptor fault.  </value>
        [DataMember(Name="AncestorMoType", EmitDefaultValue=false)]
        public string AncestorMoType { get; set; }

        /// <summary>
        /// A unique alarm code. For alarms mapped from UCS faults, this will be the same as the UCS fault code.  
        /// </summary>
        /// <value>A unique alarm code. For alarms mapped from UCS faults, this will be the same as the UCS fault code.  </value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The time the alarm was created.  
        /// </summary>
        /// <value>The time the alarm was created.  </value>
        [DataMember(Name="CreationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// A longer description of the alarm than the name. The description contains details of the component reporting the issue.  
        /// </summary>
        /// <value>A longer description of the alarm than the name. The description contains details of the component reporting the issue.  </value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The time the alarm last had a change in severity.  
        /// </summary>
        /// <value>The time the alarm last had a change in severity.  </value>
        [DataMember(Name="LastTransitionTime", EmitDefaultValue=false)]
        public DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// A unique key for the alarm from the managed system&#39;s point of view. For example, in the case of UCS, this is the fault&#39;s dn.  
        /// </summary>
        /// <value>A unique key for the alarm from the managed system&#39;s point of view. For example, in the case of UCS, this is the fault&#39;s dn.  </value>
        [DataMember(Name="MsAffectedObject", EmitDefaultValue=false)]
        public string MsAffectedObject { get; set; }

        /// <summary>
        /// Uniquely identifies the type of alarm. For alarms originating from Starship, this will be a descriptive name. For alarms that are mapped from faults, the name will be derived from fault properties. For example, alarms mapped from UCS faults will use a prefix of UCS and appended with the fault code.  
        /// </summary>
        /// <value>Uniquely identifies the type of alarm. For alarms originating from Starship, this will be a descriptive name. For alarms that are mapped from faults, the name will be derived from fault properties. For example, alarms mapped from UCS faults will use a prefix of UCS and appended with the fault code.  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Relationship to set accountMoid on Alarms. With \&quot;onpeerdelete\&quot; set to \&quot;cascade\&quot;, Alarms get deleted when the associated registered device is deleted. 
        /// </summary>
        /// <value>Relationship to set accountMoid on Alarms. With \&quot;onpeerdelete\&quot; set to \&quot;cascade\&quot;, Alarms get deleted when the associated registered device is deleted. </value>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CondAlarm {\n");
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
            sb.Append("  AffectedMoId: ").Append(AffectedMoId).Append("\n");
            sb.Append("  AffectedMoType: ").Append(AffectedMoType).Append("\n");
            sb.Append("  AffectedObject: ").Append(AffectedObject).Append("\n");
            sb.Append("  AncestorMoId: ").Append(AncestorMoId).Append("\n");
            sb.Append("  AncestorMoType: ").Append(AncestorMoType).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  LastTransitionTime: ").Append(LastTransitionTime).Append("\n");
            sb.Append("  MsAffectedObject: ").Append(MsAffectedObject).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrigSeverity: ").Append(OrigSeverity).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
            return this.Equals(obj as CondAlarm);
        }

        /// <summary>
        /// Returns true if CondAlarm instances are equal
        /// </summary>
        /// <param name="other">Instance of CondAlarm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CondAlarm other)
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
                    this.AffectedMoId == other.AffectedMoId ||
                    this.AffectedMoId != null &&
                    this.AffectedMoId.Equals(other.AffectedMoId)
                ) && 
                (
                    this.AffectedMoType == other.AffectedMoType ||
                    this.AffectedMoType != null &&
                    this.AffectedMoType.Equals(other.AffectedMoType)
                ) && 
                (
                    this.AffectedObject == other.AffectedObject ||
                    this.AffectedObject != null &&
                    this.AffectedObject.Equals(other.AffectedObject)
                ) && 
                (
                    this.AncestorMoId == other.AncestorMoId ||
                    this.AncestorMoId != null &&
                    this.AncestorMoId.Equals(other.AncestorMoId)
                ) && 
                (
                    this.AncestorMoType == other.AncestorMoType ||
                    this.AncestorMoType != null &&
                    this.AncestorMoType.Equals(other.AncestorMoType)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.LastTransitionTime == other.LastTransitionTime ||
                    this.LastTransitionTime != null &&
                    this.LastTransitionTime.Equals(other.LastTransitionTime)
                ) && 
                (
                    this.MsAffectedObject == other.MsAffectedObject ||
                    this.MsAffectedObject != null &&
                    this.MsAffectedObject.Equals(other.MsAffectedObject)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OrigSeverity == other.OrigSeverity ||
                    this.OrigSeverity != null &&
                    this.OrigSeverity.Equals(other.OrigSeverity)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.Severity == other.Severity ||
                    this.Severity != null &&
                    this.Severity.Equals(other.Severity)
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
                if (this.AffectedMoId != null)
                    hash = hash * 59 + this.AffectedMoId.GetHashCode();
                if (this.AffectedMoType != null)
                    hash = hash * 59 + this.AffectedMoType.GetHashCode();
                if (this.AffectedObject != null)
                    hash = hash * 59 + this.AffectedObject.GetHashCode();
                if (this.AncestorMoId != null)
                    hash = hash * 59 + this.AncestorMoId.GetHashCode();
                if (this.AncestorMoType != null)
                    hash = hash * 59 + this.AncestorMoType.GetHashCode();
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.LastTransitionTime != null)
                    hash = hash * 59 + this.LastTransitionTime.GetHashCode();
                if (this.MsAffectedObject != null)
                    hash = hash * 59 + this.MsAffectedObject.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OrigSeverity != null)
                    hash = hash * 59 + this.OrigSeverity.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.Severity != null)
                    hash = hash * 59 + this.Severity.GetHashCode();
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
