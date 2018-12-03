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
    /// This MO contains a workflow definition 
    /// </summary>
    [DataContract]
    public partial class WorkflowWorkflowMeta :  IEquatable<WorkflowWorkflowMeta>, IValidatableObject
    {
        /// <summary>
        /// The type of workflow  
        /// </summary>
        /// <value>The type of workflow  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum SystemDefined for "SystemDefined"
            /// </summary>
            [EnumMember(Value = "SystemDefined")]
            SystemDefined,
            
            /// <summary>
            /// Enum UserDefined for "UserDefined"
            /// </summary>
            [EnumMember(Value = "UserDefined")]
            UserDefined,
            
            /// <summary>
            /// Enum Dynamic for "Dynamic"
            /// </summary>
            [EnumMember(Value = "Dynamic")]
            Dynamic
        }

        /// <summary>
        /// The type of workflow  
        /// </summary>
        /// <value>The type of workflow  </value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWorkflowMeta" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Account">The account creates the workflow meta .</param>
        /// <param name="Description">The workflow description  .</param>
        /// <param name="InputParameters">The workflow input parameters  .</param>
        /// <param name="Name">The workflow name  .</param>
        /// <param name="OutputParameters">The workflow output parameters  .</param>
        /// <param name="SchemaVersion">The Conductor schema version that decides what attribute can be suported  .</param>
        /// <param name="Src">The src is workflow owner service  .</param>
        /// <param name="Tasks">The tasks contained inside of the workflow  .</param>
        /// <param name="Type">The type of workflow   (default to TypeEnum.SystemDefined).</param>
        /// <param name="Version">The workflow version which indicate the workflow meta changes  .</param>
        /// <param name="WaitOnDuplicate">This parameter decides if workflows will wait for a duplicate to finish before starting a new one   .</param>
        public WorkflowWorkflowMeta(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), IamAccountRef Account = default(IamAccountRef), string Description = default(string), List<string> InputParameters = default(List<string>), string Name = default(string), Object OutputParameters = default(Object), long? SchemaVersion = default(long?), string Src = default(string), Object Tasks = default(Object), TypeEnum? Type = TypeEnum.SystemDefined, long? Version = default(long?), bool? WaitOnDuplicate = default(bool?))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Account = Account;
            this.Description = Description;
            this.InputParameters = InputParameters;
            this.Name = Name;
            this.OutputParameters = OutputParameters;
            this.SchemaVersion = SchemaVersion;
            this.Src = Src;
            this.Tasks = Tasks;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.SystemDefined;
            }
            else
            {
                this.Type = Type;
            }
            this.Version = Version;
            this.WaitOnDuplicate = WaitOnDuplicate;
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
        /// The account creates the workflow meta 
        /// </summary>
        /// <value>The account creates the workflow meta </value>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public IamAccountRef Account { get; set; }

        /// <summary>
        /// The workflow description  
        /// </summary>
        /// <value>The workflow description  </value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The workflow input parameters  
        /// </summary>
        /// <value>The workflow input parameters  </value>
        [DataMember(Name="InputParameters", EmitDefaultValue=false)]
        public List<string> InputParameters { get; set; }

        /// <summary>
        /// The workflow name  
        /// </summary>
        /// <value>The workflow name  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The workflow output parameters  
        /// </summary>
        /// <value>The workflow output parameters  </value>
        [DataMember(Name="OutputParameters", EmitDefaultValue=false)]
        public Object OutputParameters { get; set; }

        /// <summary>
        /// The Conductor schema version that decides what attribute can be suported  
        /// </summary>
        /// <value>The Conductor schema version that decides what attribute can be suported  </value>
        [DataMember(Name="SchemaVersion", EmitDefaultValue=false)]
        public long? SchemaVersion { get; set; }

        /// <summary>
        /// The src is workflow owner service  
        /// </summary>
        /// <value>The src is workflow owner service  </value>
        [DataMember(Name="Src", EmitDefaultValue=false)]
        public string Src { get; set; }

        /// <summary>
        /// The tasks contained inside of the workflow  
        /// </summary>
        /// <value>The tasks contained inside of the workflow  </value>
        [DataMember(Name="Tasks", EmitDefaultValue=false)]
        public Object Tasks { get; set; }


        /// <summary>
        /// The workflow version which indicate the workflow meta changes  
        /// </summary>
        /// <value>The workflow version which indicate the workflow meta changes  </value>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public long? Version { get; set; }

        /// <summary>
        /// This parameter decides if workflows will wait for a duplicate to finish before starting a new one   
        /// </summary>
        /// <value>This parameter decides if workflows will wait for a duplicate to finish before starting a new one   </value>
        [DataMember(Name="WaitOnDuplicate", EmitDefaultValue=false)]
        public bool? WaitOnDuplicate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowWorkflowMeta {\n");
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
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OutputParameters: ").Append(OutputParameters).Append("\n");
            sb.Append("  SchemaVersion: ").Append(SchemaVersion).Append("\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  Tasks: ").Append(Tasks).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  WaitOnDuplicate: ").Append(WaitOnDuplicate).Append("\n");
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
            return this.Equals(obj as WorkflowWorkflowMeta);
        }

        /// <summary>
        /// Returns true if WorkflowWorkflowMeta instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowWorkflowMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowWorkflowMeta other)
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
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.InputParameters == other.InputParameters ||
                    this.InputParameters != null &&
                    this.InputParameters.SequenceEqual(other.InputParameters)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.OutputParameters == other.OutputParameters ||
                    this.OutputParameters != null &&
                    this.OutputParameters.Equals(other.OutputParameters)
                ) && 
                (
                    this.SchemaVersion == other.SchemaVersion ||
                    this.SchemaVersion != null &&
                    this.SchemaVersion.Equals(other.SchemaVersion)
                ) && 
                (
                    this.Src == other.Src ||
                    this.Src != null &&
                    this.Src.Equals(other.Src)
                ) && 
                (
                    this.Tasks == other.Tasks ||
                    this.Tasks != null &&
                    this.Tasks.Equals(other.Tasks)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.WaitOnDuplicate == other.WaitOnDuplicate ||
                    this.WaitOnDuplicate != null &&
                    this.WaitOnDuplicate.Equals(other.WaitOnDuplicate)
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
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.InputParameters != null)
                    hash = hash * 59 + this.InputParameters.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OutputParameters != null)
                    hash = hash * 59 + this.OutputParameters.GetHashCode();
                if (this.SchemaVersion != null)
                    hash = hash * 59 + this.SchemaVersion.GetHashCode();
                if (this.Src != null)
                    hash = hash * 59 + this.Src.GetHashCode();
                if (this.Tasks != null)
                    hash = hash * 59 + this.Tasks.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.WaitOnDuplicate != null)
                    hash = hash * 59 + this.WaitOnDuplicate.GetHashCode();
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
