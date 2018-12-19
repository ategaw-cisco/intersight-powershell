/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-300
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
    /// Specifies external storage connectivity information via Fabric attached FC storage 
    /// </summary>
    [DataContract]
    public partial class HyperflexExtFcStoragePolicy :  IEquatable<HyperflexExtFcStoragePolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexExtFcStoragePolicy" /> class.
        /// </summary>
        /// <param name="Ancestors">The array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">The unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">The array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">The array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object.   .</param>
        /// <param name="Description">Description of the policy.  .</param>
        /// <param name="Name">Name of the policy.   .</param>
        /// <param name="AdminState">Enables or disables external FC storage configuration  .</param>
        /// <param name="ClusterProfiles">List of cluster profiles using this policy .</param>
        /// <param name="ExtaTraffic">VSAN for the primary Fabric Interconnect external FC storage traffic  .</param>
        /// <param name="ExtbTraffic">VSAN for the secondary Fabric Interconnect external FC storage traffic  .</param>
        /// <param name="Organization">Organization .</param>
        /// <param name="WwxnPrefixRange">WWxN range   .</param>
        public HyperflexExtFcStoragePolicy(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string Description = default(string), string Name = default(string), bool? AdminState = default(bool?), List<HyperflexClusterProfileRef> ClusterProfiles = default(List<HyperflexClusterProfileRef>), HyperflexNamedVsan ExtaTraffic = default(HyperflexNamedVsan), HyperflexNamedVsan ExtbTraffic = default(HyperflexNamedVsan), IamAccountRef Organization = default(IamAccountRef), HyperflexWwxnPrefixRange WwxnPrefixRange = default(HyperflexWwxnPrefixRange))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Description = Description;
            this.Name = Name;
            this.AdminState = AdminState;
            this.ClusterProfiles = ClusterProfiles;
            this.ExtaTraffic = ExtaTraffic;
            this.ExtbTraffic = ExtbTraffic;
            this.Organization = Organization;
            this.WwxnPrefixRange = WwxnPrefixRange;
        }
        
        /// <summary>
        /// The Account ID for this managed object.  
        /// </summary>
        /// <value>The Account ID for this managed object.  </value>
        [DataMember(Name="AccountMoid", EmitDefaultValue=false)]
        public string AccountMoid { get; private set; }

        /// <summary>
        /// The array containing the MO references of the ancestors in the object containment hierarchy. 
        /// </summary>
        /// <value>The array containing the MO references of the ancestors in the object containment hierarchy. </value>
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
        /// The unique identifier of this Managed Object instance.  
        /// </summary>
        /// <value>The unique identifier of this Managed Object instance.  </value>
        [DataMember(Name="Moid", EmitDefaultValue=false)]
        public string Moid { get; set; }

        /// <summary>
        /// The fully-qualified type of this managed object, e.g. the class name.  
        /// </summary>
        /// <value>The fully-qualified type of this managed object, e.g. the class name.  </value>
        [DataMember(Name="ObjectType", EmitDefaultValue=false)]
        public string ObjectType { get; private set; }

        /// <summary>
        /// The array of owners which represent effective ownership of this object.   
        /// </summary>
        /// <value>The array of owners which represent effective ownership of this object.   </value>
        [DataMember(Name="Owners", EmitDefaultValue=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// The direct ancestor of this managed object in the containment hierarchy. 
        /// </summary>
        /// <value>The direct ancestor of this managed object in the containment hierarchy. </value>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public MoBaseMoRef Parent { get; set; }

        /// <summary>
        /// The array of tags, which allow to add key, value meta-data to managed objects.  
        /// </summary>
        /// <value>The array of tags, which allow to add key, value meta-data to managed objects.  </value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<MoTag> Tags { get; set; }

        /// <summary>
        /// The versioning info for this managed object.   
        /// </summary>
        /// <value>The versioning info for this managed object.   </value>
        [DataMember(Name="VersionContext", EmitDefaultValue=false)]
        public MoVersionContext VersionContext { get; set; }

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
        /// Enables or disables external FC storage configuration  
        /// </summary>
        /// <value>Enables or disables external FC storage configuration  </value>
        [DataMember(Name="AdminState", EmitDefaultValue=false)]
        public bool? AdminState { get; set; }

        /// <summary>
        /// List of cluster profiles using this policy 
        /// </summary>
        /// <value>List of cluster profiles using this policy </value>
        [DataMember(Name="ClusterProfiles", EmitDefaultValue=false)]
        public List<HyperflexClusterProfileRef> ClusterProfiles { get; set; }

        /// <summary>
        /// VSAN for the primary Fabric Interconnect external FC storage traffic  
        /// </summary>
        /// <value>VSAN for the primary Fabric Interconnect external FC storage traffic  </value>
        [DataMember(Name="ExtaTraffic", EmitDefaultValue=false)]
        public HyperflexNamedVsan ExtaTraffic { get; set; }

        /// <summary>
        /// VSAN for the secondary Fabric Interconnect external FC storage traffic  
        /// </summary>
        /// <value>VSAN for the secondary Fabric Interconnect external FC storage traffic  </value>
        [DataMember(Name="ExtbTraffic", EmitDefaultValue=false)]
        public HyperflexNamedVsan ExtbTraffic { get; set; }

        /// <summary>
        /// Organization 
        /// </summary>
        /// <value>Organization </value>
        [DataMember(Name="Organization", EmitDefaultValue=false)]
        public IamAccountRef Organization { get; set; }

        /// <summary>
        /// WWxN range   
        /// </summary>
        /// <value>WWxN range   </value>
        [DataMember(Name="WwxnPrefixRange", EmitDefaultValue=false)]
        public HyperflexWwxnPrefixRange WwxnPrefixRange { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexExtFcStoragePolicy {\n");
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
            sb.Append("  AdminState: ").Append(AdminState).Append("\n");
            sb.Append("  ClusterProfiles: ").Append(ClusterProfiles).Append("\n");
            sb.Append("  ExtaTraffic: ").Append(ExtaTraffic).Append("\n");
            sb.Append("  ExtbTraffic: ").Append(ExtbTraffic).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  WwxnPrefixRange: ").Append(WwxnPrefixRange).Append("\n");
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
            return this.Equals(obj as HyperflexExtFcStoragePolicy);
        }

        /// <summary>
        /// Returns true if HyperflexExtFcStoragePolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexExtFcStoragePolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexExtFcStoragePolicy other)
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
                    this.AdminState == other.AdminState ||
                    this.AdminState != null &&
                    this.AdminState.Equals(other.AdminState)
                ) && 
                (
                    this.ClusterProfiles == other.ClusterProfiles ||
                    this.ClusterProfiles != null &&
                    this.ClusterProfiles.SequenceEqual(other.ClusterProfiles)
                ) && 
                (
                    this.ExtaTraffic == other.ExtaTraffic ||
                    this.ExtaTraffic != null &&
                    this.ExtaTraffic.Equals(other.ExtaTraffic)
                ) && 
                (
                    this.ExtbTraffic == other.ExtbTraffic ||
                    this.ExtbTraffic != null &&
                    this.ExtbTraffic.Equals(other.ExtbTraffic)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.WwxnPrefixRange == other.WwxnPrefixRange ||
                    this.WwxnPrefixRange != null &&
                    this.WwxnPrefixRange.Equals(other.WwxnPrefixRange)
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
                if (this.AdminState != null)
                    hash = hash * 59 + this.AdminState.GetHashCode();
                if (this.ClusterProfiles != null)
                    hash = hash * 59 + this.ClusterProfiles.GetHashCode();
                if (this.ExtaTraffic != null)
                    hash = hash * 59 + this.ExtaTraffic.GetHashCode();
                if (this.ExtbTraffic != null)
                    hash = hash * 59 + this.ExtbTraffic.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.WwxnPrefixRange != null)
                    hash = hash * 59 + this.WwxnPrefixRange.GetHashCode();
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
