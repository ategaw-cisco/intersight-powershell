/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-263
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
    /// Configuration per node in the HyperFlex cluster. Specifies node settings such as IP address configuration for hypervisor management network, storage data network, HyperFlex management network, and the assigned physical server 
    /// </summary>
    [DataContract]
    public partial class HyperflexNodeProfile :  IEquatable<HyperflexNodeProfile>, IValidatableObject
    {
        /// <summary>
        /// Defines the type of the profile. Accepted value is instance.   
        /// </summary>
        /// <value>Defines the type of the profile. Accepted value is instance.   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Instance for "instance"
            /// </summary>
            [EnumMember(Value = "instance")]
            Instance
        }

        /// <summary>
        /// Defines the type of the profile. Accepted value is instance.   
        /// </summary>
        /// <value>Defines the type of the profile. Accepted value is instance.   </value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexNodeProfile" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Description">Description of the profile.  .</param>
        /// <param name="Name">Name of the profile.  .</param>
        /// <param name="SrcTemplate">SrcTemplate.</param>
        /// <param name="Type">Defines the type of the profile. Accepted value is instance.    (default to TypeEnum.Instance).</param>
        /// <param name="AssignedServer">The physical server assigned to this node profile .</param>
        /// <param name="ClusterProfile">ClusterProfile.</param>
        /// <param name="HxdpDataIp">IP address for storage data network (Controller VM interface)  .</param>
        /// <param name="HxdpMgmtIp">IP address for HyperFlex management network  .</param>
        /// <param name="HypervisorDataIp">IP address for storage data network (Hypervisor interface)  .</param>
        /// <param name="HypervisorMgmtIp">IP address for Hypervisor management network   .</param>
        public HyperflexNodeProfile(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string Description = default(string), string Name = default(string), PolicyAbstractProfileRef SrcTemplate = default(PolicyAbstractProfileRef), TypeEnum? Type = TypeEnum.Instance, ComputeRackUnitRef AssignedServer = default(ComputeRackUnitRef), HyperflexClusterProfileRef ClusterProfile = default(HyperflexClusterProfileRef), string HxdpDataIp = default(string), string HxdpMgmtIp = default(string), string HypervisorDataIp = default(string), string HypervisorMgmtIp = default(string))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Description = Description;
            this.Name = Name;
            this.SrcTemplate = SrcTemplate;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.Instance;
            }
            else
            {
                this.Type = Type;
            }
            this.AssignedServer = AssignedServer;
            this.ClusterProfile = ClusterProfile;
            this.HxdpDataIp = HxdpDataIp;
            this.HxdpMgmtIp = HxdpMgmtIp;
            this.HypervisorDataIp = HypervisorDataIp;
            this.HypervisorMgmtIp = HypervisorMgmtIp;
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
        /// Description of the profile.  
        /// </summary>
        /// <value>Description of the profile.  </value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the profile.  
        /// </summary>
        /// <value>Name of the profile.  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SrcTemplate
        /// </summary>
        [DataMember(Name="SrcTemplate", EmitDefaultValue=false)]
        public PolicyAbstractProfileRef SrcTemplate { get; set; }


        /// <summary>
        /// The physical server assigned to this node profile 
        /// </summary>
        /// <value>The physical server assigned to this node profile </value>
        [DataMember(Name="AssignedServer", EmitDefaultValue=false)]
        public ComputeRackUnitRef AssignedServer { get; set; }

        /// <summary>
        /// Gets or Sets ClusterProfile
        /// </summary>
        [DataMember(Name="ClusterProfile", EmitDefaultValue=false)]
        public HyperflexClusterProfileRef ClusterProfile { get; set; }

        /// <summary>
        /// IP address for storage data network (Controller VM interface)  
        /// </summary>
        /// <value>IP address for storage data network (Controller VM interface)  </value>
        [DataMember(Name="HxdpDataIp", EmitDefaultValue=false)]
        public string HxdpDataIp { get; set; }

        /// <summary>
        /// IP address for HyperFlex management network  
        /// </summary>
        /// <value>IP address for HyperFlex management network  </value>
        [DataMember(Name="HxdpMgmtIp", EmitDefaultValue=false)]
        public string HxdpMgmtIp { get; set; }

        /// <summary>
        /// IP address for storage data network (Hypervisor interface)  
        /// </summary>
        /// <value>IP address for storage data network (Hypervisor interface)  </value>
        [DataMember(Name="HypervisorDataIp", EmitDefaultValue=false)]
        public string HypervisorDataIp { get; set; }

        /// <summary>
        /// IP address for Hypervisor management network   
        /// </summary>
        /// <value>IP address for Hypervisor management network   </value>
        [DataMember(Name="HypervisorMgmtIp", EmitDefaultValue=false)]
        public string HypervisorMgmtIp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexNodeProfile {\n");
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
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SrcTemplate: ").Append(SrcTemplate).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AssignedServer: ").Append(AssignedServer).Append("\n");
            sb.Append("  ClusterProfile: ").Append(ClusterProfile).Append("\n");
            sb.Append("  HxdpDataIp: ").Append(HxdpDataIp).Append("\n");
            sb.Append("  HxdpMgmtIp: ").Append(HxdpMgmtIp).Append("\n");
            sb.Append("  HypervisorDataIp: ").Append(HypervisorDataIp).Append("\n");
            sb.Append("  HypervisorMgmtIp: ").Append(HypervisorMgmtIp).Append("\n");
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
            return this.Equals(obj as HyperflexNodeProfile);
        }

        /// <summary>
        /// Returns true if HyperflexNodeProfile instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexNodeProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexNodeProfile other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.SrcTemplate == other.SrcTemplate ||
                    this.SrcTemplate != null &&
                    this.SrcTemplate.Equals(other.SrcTemplate)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.AssignedServer == other.AssignedServer ||
                    this.AssignedServer != null &&
                    this.AssignedServer.Equals(other.AssignedServer)
                ) && 
                (
                    this.ClusterProfile == other.ClusterProfile ||
                    this.ClusterProfile != null &&
                    this.ClusterProfile.Equals(other.ClusterProfile)
                ) && 
                (
                    this.HxdpDataIp == other.HxdpDataIp ||
                    this.HxdpDataIp != null &&
                    this.HxdpDataIp.Equals(other.HxdpDataIp)
                ) && 
                (
                    this.HxdpMgmtIp == other.HxdpMgmtIp ||
                    this.HxdpMgmtIp != null &&
                    this.HxdpMgmtIp.Equals(other.HxdpMgmtIp)
                ) && 
                (
                    this.HypervisorDataIp == other.HypervisorDataIp ||
                    this.HypervisorDataIp != null &&
                    this.HypervisorDataIp.Equals(other.HypervisorDataIp)
                ) && 
                (
                    this.HypervisorMgmtIp == other.HypervisorMgmtIp ||
                    this.HypervisorMgmtIp != null &&
                    this.HypervisorMgmtIp.Equals(other.HypervisorMgmtIp)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.SrcTemplate != null)
                    hash = hash * 59 + this.SrcTemplate.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.AssignedServer != null)
                    hash = hash * 59 + this.AssignedServer.GetHashCode();
                if (this.ClusterProfile != null)
                    hash = hash * 59 + this.ClusterProfile.GetHashCode();
                if (this.HxdpDataIp != null)
                    hash = hash * 59 + this.HxdpDataIp.GetHashCode();
                if (this.HxdpMgmtIp != null)
                    hash = hash * 59 + this.HxdpMgmtIp.GetHashCode();
                if (this.HypervisorDataIp != null)
                    hash = hash * 59 + this.HypervisorDataIp.GetHashCode();
                if (this.HypervisorMgmtIp != null)
                    hash = hash * 59 + this.HypervisorMgmtIp.GetHashCode();
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
