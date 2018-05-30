/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 0.1.0-559
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
    /// Models a reusable RAID disk group configuration that can be applied across multiple servers. Also provides options to move JBOD disks in the disk group to Unconfigured Good state before they are used in the disk group 
    /// </summary>
    [DataContract]
    public partial class StorageDiskGroupPolicy :  IEquatable<StorageDiskGroupPolicy>, IValidatableObject
    {
        /// <summary>
        /// The supported RAID level for the disk group  
        /// </summary>
        /// <value>The supported RAID level for the disk group  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RaidLevelEnum
        {
            
            /// <summary>
            /// Enum Raid0 for "Raid0"
            /// </summary>
            [EnumMember(Value = "Raid0")]
            Raid0,
            
            /// <summary>
            /// Enum Raid1 for "Raid1"
            /// </summary>
            [EnumMember(Value = "Raid1")]
            Raid1,
            
            /// <summary>
            /// Enum Raid5 for "Raid5"
            /// </summary>
            [EnumMember(Value = "Raid5")]
            Raid5,
            
            /// <summary>
            /// Enum Raid6 for "Raid6"
            /// </summary>
            [EnumMember(Value = "Raid6")]
            Raid6,
            
            /// <summary>
            /// Enum Raid10 for "Raid10"
            /// </summary>
            [EnumMember(Value = "Raid10")]
            Raid10,
            
            /// <summary>
            /// Enum Raid50 for "Raid50"
            /// </summary>
            [EnumMember(Value = "Raid50")]
            Raid50,
            
            /// <summary>
            /// Enum Raid60 for "Raid60"
            /// </summary>
            [EnumMember(Value = "Raid60")]
            Raid60
        }

        /// <summary>
        /// The supported RAID level for the disk group  
        /// </summary>
        /// <value>The supported RAID level for the disk group  </value>
        [DataMember(Name="RaidLevel", EmitDefaultValue=false)]
        public RaidLevelEnum? RaidLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageDiskGroupPolicy" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="Description">Description of the policy.  .</param>
        /// <param name="Name">Name of the policy.   .</param>
        /// <param name="DedicatedHotSpares">A collection of disks used as hot spares for this RAID group   .</param>
        /// <param name="Organization">Organization .</param>
        /// <param name="RaidLevel">The supported RAID level for the disk group   (default to RaidLevelEnum.Raid0).</param>
        /// <param name="SpanGroups">Non spanned RAID levels like Raid0, Raid1, Raid5 and Raid6 expect a single group of disks whereas spanned RAID levels need multiple groups of disks with each group representing a span group. Non spanned RAID levels expect one span group and spanned RAID levels accept minimum 2 span groups and up to 8  .</param>
        /// <param name="StoragePolicies">StoragePolicies.</param>
        /// <param name="UseJbods">Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation   .</param>
        public StorageDiskGroupPolicy(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), string Description = default(string), string Name = default(string), List<StorageLocalDisk> DedicatedHotSpares = default(List<StorageLocalDisk>), IamAccountRef Organization = default(IamAccountRef), RaidLevelEnum? RaidLevel = RaidLevelEnum.Raid0, List<StorageSpanGroup> SpanGroups = default(List<StorageSpanGroup>), List<StorageStoragePolicyRef> StoragePolicies = default(List<StorageStoragePolicyRef>), bool? UseJbods = default(bool?))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.Description = Description;
            this.Name = Name;
            this.DedicatedHotSpares = DedicatedHotSpares;
            this.Organization = Organization;
            // use default value if no "RaidLevel" provided
            if (RaidLevel == null)
            {
                this.RaidLevel = RaidLevelEnum.Raid0;
            }
            else
            {
                this.RaidLevel = RaidLevel;
            }
            this.SpanGroups = SpanGroups;
            this.StoragePolicies = StoragePolicies;
            this.UseJbods = UseJbods;
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
        /// <value>An array of tags, which allow to add key, value meta-data to managed objects.   </value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<MoTag> Tags { get; set; }

        /// <summary>
        /// Description of the policy.  
        /// </summary>
        /// <value>Description of the policy.  </value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Name of the policy.   
        /// </summary>
        /// <value>Name of the policy.   </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A collection of disks used as hot spares for this RAID group   
        /// </summary>
        /// <value>A collection of disks used as hot spares for this RAID group   </value>
        [DataMember(Name="DedicatedHotSpares", EmitDefaultValue=false)]
        public List<StorageLocalDisk> DedicatedHotSpares { get; set; }

        /// <summary>
        /// Organization 
        /// </summary>
        /// <value>Organization </value>
        [DataMember(Name="Organization", EmitDefaultValue=false)]
        public IamAccountRef Organization { get; set; }


        /// <summary>
        /// Non spanned RAID levels like Raid0, Raid1, Raid5 and Raid6 expect a single group of disks whereas spanned RAID levels need multiple groups of disks with each group representing a span group. Non spanned RAID levels expect one span group and spanned RAID levels accept minimum 2 span groups and up to 8  
        /// </summary>
        /// <value>Non spanned RAID levels like Raid0, Raid1, Raid5 and Raid6 expect a single group of disks whereas spanned RAID levels need multiple groups of disks with each group representing a span group. Non spanned RAID levels expect one span group and spanned RAID levels accept minimum 2 span groups and up to 8  </value>
        [DataMember(Name="SpanGroups", EmitDefaultValue=false)]
        public List<StorageSpanGroup> SpanGroups { get; set; }

        /// <summary>
        /// Gets or Sets StoragePolicies
        /// </summary>
        [DataMember(Name="StoragePolicies", EmitDefaultValue=false)]
        public List<StorageStoragePolicyRef> StoragePolicies { get; set; }

        /// <summary>
        /// Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation   
        /// </summary>
        /// <value>Selected disks in the disk group in JBOD state will be set to Unconfigured Good state before they are used in virtual drive creation   </value>
        [DataMember(Name="UseJbods", EmitDefaultValue=false)]
        public bool? UseJbods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageDiskGroupPolicy {\n");
            sb.Append("  AccountMoid: ").Append(AccountMoid).Append("\n");
            sb.Append("  Ancestors: ").Append(Ancestors).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ModTime: ").Append(ModTime).Append("\n");
            sb.Append("  Moid: ").Append(Moid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DedicatedHotSpares: ").Append(DedicatedHotSpares).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  RaidLevel: ").Append(RaidLevel).Append("\n");
            sb.Append("  SpanGroups: ").Append(SpanGroups).Append("\n");
            sb.Append("  StoragePolicies: ").Append(StoragePolicies).Append("\n");
            sb.Append("  UseJbods: ").Append(UseJbods).Append("\n");
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
            return this.Equals(obj as StorageDiskGroupPolicy);
        }

        /// <summary>
        /// Returns true if StorageDiskGroupPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageDiskGroupPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageDiskGroupPolicy other)
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
                    this.DedicatedHotSpares == other.DedicatedHotSpares ||
                    this.DedicatedHotSpares != null &&
                    this.DedicatedHotSpares.SequenceEqual(other.DedicatedHotSpares)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.RaidLevel == other.RaidLevel ||
                    this.RaidLevel != null &&
                    this.RaidLevel.Equals(other.RaidLevel)
                ) && 
                (
                    this.SpanGroups == other.SpanGroups ||
                    this.SpanGroups != null &&
                    this.SpanGroups.SequenceEqual(other.SpanGroups)
                ) && 
                (
                    this.StoragePolicies == other.StoragePolicies ||
                    this.StoragePolicies != null &&
                    this.StoragePolicies.SequenceEqual(other.StoragePolicies)
                ) && 
                (
                    this.UseJbods == other.UseJbods ||
                    this.UseJbods != null &&
                    this.UseJbods.Equals(other.UseJbods)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.DedicatedHotSpares != null)
                    hash = hash * 59 + this.DedicatedHotSpares.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.RaidLevel != null)
                    hash = hash * 59 + this.RaidLevel.GetHashCode();
                if (this.SpanGroups != null)
                    hash = hash * 59 + this.SpanGroups.GetHashCode();
                if (this.StoragePolicies != null)
                    hash = hash * 59 + this.StoragePolicies.GetHashCode();
                if (this.UseJbods != null)
                    hash = hash * 59 + this.UseJbods.GetHashCode();
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
