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
    /// HyperflexNode
    /// </summary>
    [DataContract]
    public partial class HyperflexNode :  IEquatable<HyperflexNode>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum ONLINE for "ONLINE"
            /// </summary>
            [EnumMember(Value = "ONLINE")]
            ONLINE,
            
            /// <summary>
            /// Enum OFFLINE for "OFFLINE"
            /// </summary>
            [EnumMember(Value = "OFFLINE")]
            OFFLINE,
            
            /// <summary>
            /// Enum INMAINTENANCE for "INMAINTENANCE"
            /// </summary>
            [EnumMember(Value = "INMAINTENANCE")]
            INMAINTENANCE,
            
            /// <summary>
            /// Enum DEGRADED for "DEGRADED"
            /// </summary>
            [EnumMember(Value = "DEGRADED")]
            DEGRADED
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexNode" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Cluster">Cluster.</param>
        /// <param name="ClusterMember">A relationship to the ClusterMember that represents this node&#39;s registration to Intersight .</param>
        /// <param name="Identity">Identity.</param>
        /// <param name="Ip">Ip.</param>
        /// <param name="PhysicalServer">A relationship to the UCS server associated with this node .</param>
        public HyperflexNode(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), HyperflexClusterRef Cluster = default(HyperflexClusterRef), AssetClusterMemberRef ClusterMember = default(AssetClusterMemberRef), HyperflexHxUuIdDt Identity = default(HyperflexHxUuIdDt), HyperflexHxNetworkAddressDt Ip = default(HyperflexHxNetworkAddressDt), ComputePhysicalRef PhysicalServer = default(ComputePhysicalRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Cluster = Cluster;
            this.ClusterMember = ClusterMember;
            this.Identity = Identity;
            this.Ip = Ip;
            this.PhysicalServer = PhysicalServer;
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
        /// Gets or Sets BuildNumber
        /// </summary>
        [DataMember(Name="BuildNumber", EmitDefaultValue=false)]
        public string BuildNumber { get; private set; }

        /// <summary>
        /// Gets or Sets Cluster
        /// </summary>
        [DataMember(Name="Cluster", EmitDefaultValue=false)]
        public HyperflexClusterRef Cluster { get; set; }

        /// <summary>
        /// A relationship to the ClusterMember that represents this node&#39;s registration to Intersight 
        /// </summary>
        /// <value>A relationship to the ClusterMember that represents this node&#39;s registration to Intersight </value>
        [DataMember(Name="ClusterMember", EmitDefaultValue=false)]
        public AssetClusterMemberRef ClusterMember { get; set; }

        /// <summary>
        /// Gets or Sets DisplayVersion
        /// </summary>
        [DataMember(Name="DisplayVersion", EmitDefaultValue=false)]
        public string DisplayVersion { get; private set; }

        /// <summary>
        /// Gets or Sets HostName
        /// </summary>
        [DataMember(Name="HostName", EmitDefaultValue=false)]
        public string HostName { get; private set; }

        /// <summary>
        /// Gets or Sets Hypervisor
        /// </summary>
        [DataMember(Name="Hypervisor", EmitDefaultValue=false)]
        public string Hypervisor { get; private set; }

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [DataMember(Name="Identity", EmitDefaultValue=false)]
        public HyperflexHxUuIdDt Identity { get; set; }

        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="Ip", EmitDefaultValue=false)]
        public HyperflexHxNetworkAddressDt Ip { get; set; }

        /// <summary>
        /// Gets or Sets Lockdown
        /// </summary>
        [DataMember(Name="Lockdown", EmitDefaultValue=false)]
        public bool? Lockdown { get; private set; }

        /// <summary>
        /// Gets or Sets ModelNumber
        /// </summary>
        [DataMember(Name="ModelNumber", EmitDefaultValue=false)]
        public string ModelNumber { get; private set; }

        /// <summary>
        /// A relationship to the UCS server associated with this node 
        /// </summary>
        /// <value>A relationship to the UCS server associated with this node </value>
        [DataMember(Name="PhysicalServer", EmitDefaultValue=false)]
        public ComputePhysicalRef PhysicalServer { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        [DataMember(Name="SerialNumber", EmitDefaultValue=false)]
        public string SerialNumber { get; private set; }


        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexNode {\n");
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
            sb.Append("  BuildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  Cluster: ").Append(Cluster).Append("\n");
            sb.Append("  ClusterMember: ").Append(ClusterMember).Append("\n");
            sb.Append("  DisplayVersion: ").Append(DisplayVersion).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  Hypervisor: ").Append(Hypervisor).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Lockdown: ").Append(Lockdown).Append("\n");
            sb.Append("  ModelNumber: ").Append(ModelNumber).Append("\n");
            sb.Append("  PhysicalServer: ").Append(PhysicalServer).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as HyperflexNode);
        }

        /// <summary>
        /// Returns true if HyperflexNode instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexNode other)
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
                    this.BuildNumber == other.BuildNumber ||
                    this.BuildNumber != null &&
                    this.BuildNumber.Equals(other.BuildNumber)
                ) && 
                (
                    this.Cluster == other.Cluster ||
                    this.Cluster != null &&
                    this.Cluster.Equals(other.Cluster)
                ) && 
                (
                    this.ClusterMember == other.ClusterMember ||
                    this.ClusterMember != null &&
                    this.ClusterMember.Equals(other.ClusterMember)
                ) && 
                (
                    this.DisplayVersion == other.DisplayVersion ||
                    this.DisplayVersion != null &&
                    this.DisplayVersion.Equals(other.DisplayVersion)
                ) && 
                (
                    this.HostName == other.HostName ||
                    this.HostName != null &&
                    this.HostName.Equals(other.HostName)
                ) && 
                (
                    this.Hypervisor == other.Hypervisor ||
                    this.Hypervisor != null &&
                    this.Hypervisor.Equals(other.Hypervisor)
                ) && 
                (
                    this.Identity == other.Identity ||
                    this.Identity != null &&
                    this.Identity.Equals(other.Identity)
                ) && 
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                ) && 
                (
                    this.Lockdown == other.Lockdown ||
                    this.Lockdown != null &&
                    this.Lockdown.Equals(other.Lockdown)
                ) && 
                (
                    this.ModelNumber == other.ModelNumber ||
                    this.ModelNumber != null &&
                    this.ModelNumber.Equals(other.ModelNumber)
                ) && 
                (
                    this.PhysicalServer == other.PhysicalServer ||
                    this.PhysicalServer != null &&
                    this.PhysicalServer.Equals(other.PhysicalServer)
                ) && 
                (
                    this.SerialNumber == other.SerialNumber ||
                    this.SerialNumber != null &&
                    this.SerialNumber.Equals(other.SerialNumber)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.BuildNumber != null)
                    hash = hash * 59 + this.BuildNumber.GetHashCode();
                if (this.Cluster != null)
                    hash = hash * 59 + this.Cluster.GetHashCode();
                if (this.ClusterMember != null)
                    hash = hash * 59 + this.ClusterMember.GetHashCode();
                if (this.DisplayVersion != null)
                    hash = hash * 59 + this.DisplayVersion.GetHashCode();
                if (this.HostName != null)
                    hash = hash * 59 + this.HostName.GetHashCode();
                if (this.Hypervisor != null)
                    hash = hash * 59 + this.Hypervisor.GetHashCode();
                if (this.Identity != null)
                    hash = hash * 59 + this.Identity.GetHashCode();
                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();
                if (this.Lockdown != null)
                    hash = hash * 59 + this.Lockdown.GetHashCode();
                if (this.ModelNumber != null)
                    hash = hash * 59 + this.ModelNumber.GetHashCode();
                if (this.PhysicalServer != null)
                    hash = hash * 59 + this.PhysicalServer.GetHashCode();
                if (this.SerialNumber != null)
                    hash = hash * 59 + this.SerialNumber.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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
