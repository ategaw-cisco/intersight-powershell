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
    /// Specifies credentials for HyperFlex cluster such as controller VM password, hypervisor username, and password 
    /// </summary>
    [DataContract]
    public partial class HyperflexLocalCredentialPolicy :  IEquatable<HyperflexLocalCredentialPolicy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HyperflexLocalCredentialPolicy" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Description">Description of the policy.  .</param>
        /// <param name="Name">Name of the policy.   .</param>
        /// <param name="ClusterProfiles">List of cluster profiles using this policy .</param>
        /// <param name="FactoryHypervisorPassword">Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment.  .</param>
        /// <param name="HxdpRootPwd">HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these special characters - !@#$%^&amp;*  .</param>
        /// <param name="HypervisorAdmin">Hypervisor administrator username must contain only alphanumeric characters. Use the root account for ESXi deployments.  .</param>
        /// <param name="HypervisorAdminPwd">Specifies the ESXi root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \&quot;Cisco123\&quot; for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment.  .</param>
        /// <param name="Organization">Organization .</param>
        public HyperflexLocalCredentialPolicy(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string Description = default(string), string Name = default(string), List<HyperflexClusterProfileRef> ClusterProfiles = default(List<HyperflexClusterProfileRef>), bool? FactoryHypervisorPassword = default(bool?), string HxdpRootPwd = default(string), string HypervisorAdmin = default(string), string HypervisorAdminPwd = default(string), IamAccountRef Organization = default(IamAccountRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Description = Description;
            this.Name = Name;
            this.ClusterProfiles = ClusterProfiles;
            this.FactoryHypervisorPassword = FactoryHypervisorPassword;
            this.HxdpRootPwd = HxdpRootPwd;
            this.HypervisorAdmin = HypervisorAdmin;
            this.HypervisorAdminPwd = HypervisorAdminPwd;
            this.Organization = Organization;
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
        /// List of cluster profiles using this policy 
        /// </summary>
        /// <value>List of cluster profiles using this policy </value>
        [DataMember(Name="ClusterProfiles", EmitDefaultValue=false)]
        public List<HyperflexClusterProfileRef> ClusterProfiles { get; set; }

        /// <summary>
        /// Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment.  
        /// </summary>
        /// <value>Indicates if Hypervisor password is the factory set default password. For HyperFlex Data Platform versions 3.0 or higher, enable this if the default password was not changed on the Hypervisor. It is required to supply a new custom Hypervisor password that will be applied to the Hypervisor during deployment. For HyperFlex Data Platform versions prior to 3.0 release, this setting has no effect and the default password will be used for initial install. The Hypervisor password should be changed after deployment.  </value>
        [DataMember(Name="FactoryHypervisorPassword", EmitDefaultValue=false)]
        public bool? FactoryHypervisorPassword { get; set; }

        /// <summary>
        /// HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these special characters - !@#$%^&amp;*  
        /// </summary>
        /// <value>HyperFlex storage controller VM password must contain a minimum of 10 characters, with at least 1 lowercase, 1 uppercase, 1 numeric, and 1 of these special characters - !@#$%^&amp;*  </value>
        [DataMember(Name="HxdpRootPwd", EmitDefaultValue=false)]
        public string HxdpRootPwd { get; set; }

        /// <summary>
        /// Hypervisor administrator username must contain only alphanumeric characters. Use the root account for ESXi deployments.  
        /// </summary>
        /// <value>Hypervisor administrator username must contain only alphanumeric characters. Use the root account for ESXi deployments.  </value>
        [DataMember(Name="HypervisorAdmin", EmitDefaultValue=false)]
        public string HypervisorAdmin { get; set; }

        /// <summary>
        /// Specifies the ESXi root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \&quot;Cisco123\&quot; for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment.  
        /// </summary>
        /// <value>Specifies the ESXi root password. For HyperFlex Data Platform 3.0 or later, if the factory default password was not manually changed, you must set a new custom password. If the password was manually changed, you must not enable the factory default password property and provide the current hypervisor password. Note - All HyperFlex nodes require the same hypervisor password for installation. For HyperFlex Data Platform prior to 3.0, use the default password \&quot;Cisco123\&quot; for newly manufactured HyperFlex servers. A custom password should only be entered if hypervisor credentials were manually changed prior to deployment.  </value>
        [DataMember(Name="HypervisorAdminPwd", EmitDefaultValue=false)]
        public string HypervisorAdminPwd { get; set; }

        /// <summary>
        /// Gets or Sets IsHxdpRootPwdSet
        /// </summary>
        [DataMember(Name="IsHxdpRootPwdSet", EmitDefaultValue=false)]
        public bool? IsHxdpRootPwdSet { get; private set; }

        /// <summary>
        /// Gets or Sets IsHypervisorAdminPwdSet
        /// </summary>
        [DataMember(Name="IsHypervisorAdminPwdSet", EmitDefaultValue=false)]
        public bool? IsHypervisorAdminPwdSet { get; private set; }

        /// <summary>
        /// Organization 
        /// </summary>
        /// <value>Organization </value>
        [DataMember(Name="Organization", EmitDefaultValue=false)]
        public IamAccountRef Organization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperflexLocalCredentialPolicy {\n");
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
            sb.Append("  ClusterProfiles: ").Append(ClusterProfiles).Append("\n");
            sb.Append("  FactoryHypervisorPassword: ").Append(FactoryHypervisorPassword).Append("\n");
            sb.Append("  HxdpRootPwd: ").Append(HxdpRootPwd).Append("\n");
            sb.Append("  HypervisorAdmin: ").Append(HypervisorAdmin).Append("\n");
            sb.Append("  HypervisorAdminPwd: ").Append(HypervisorAdminPwd).Append("\n");
            sb.Append("  IsHxdpRootPwdSet: ").Append(IsHxdpRootPwdSet).Append("\n");
            sb.Append("  IsHypervisorAdminPwdSet: ").Append(IsHypervisorAdminPwdSet).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
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
            return this.Equals(obj as HyperflexLocalCredentialPolicy);
        }

        /// <summary>
        /// Returns true if HyperflexLocalCredentialPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of HyperflexLocalCredentialPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HyperflexLocalCredentialPolicy other)
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
                    this.ClusterProfiles == other.ClusterProfiles ||
                    this.ClusterProfiles != null &&
                    this.ClusterProfiles.SequenceEqual(other.ClusterProfiles)
                ) && 
                (
                    this.FactoryHypervisorPassword == other.FactoryHypervisorPassword ||
                    this.FactoryHypervisorPassword != null &&
                    this.FactoryHypervisorPassword.Equals(other.FactoryHypervisorPassword)
                ) && 
                (
                    this.HxdpRootPwd == other.HxdpRootPwd ||
                    this.HxdpRootPwd != null &&
                    this.HxdpRootPwd.Equals(other.HxdpRootPwd)
                ) && 
                (
                    this.HypervisorAdmin == other.HypervisorAdmin ||
                    this.HypervisorAdmin != null &&
                    this.HypervisorAdmin.Equals(other.HypervisorAdmin)
                ) && 
                (
                    this.HypervisorAdminPwd == other.HypervisorAdminPwd ||
                    this.HypervisorAdminPwd != null &&
                    this.HypervisorAdminPwd.Equals(other.HypervisorAdminPwd)
                ) && 
                (
                    this.IsHxdpRootPwdSet == other.IsHxdpRootPwdSet ||
                    this.IsHxdpRootPwdSet != null &&
                    this.IsHxdpRootPwdSet.Equals(other.IsHxdpRootPwdSet)
                ) && 
                (
                    this.IsHypervisorAdminPwdSet == other.IsHypervisorAdminPwdSet ||
                    this.IsHypervisorAdminPwdSet != null &&
                    this.IsHypervisorAdminPwdSet.Equals(other.IsHypervisorAdminPwdSet)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
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
                if (this.ClusterProfiles != null)
                    hash = hash * 59 + this.ClusterProfiles.GetHashCode();
                if (this.FactoryHypervisorPassword != null)
                    hash = hash * 59 + this.FactoryHypervisorPassword.GetHashCode();
                if (this.HxdpRootPwd != null)
                    hash = hash * 59 + this.HxdpRootPwd.GetHashCode();
                if (this.HypervisorAdmin != null)
                    hash = hash * 59 + this.HypervisorAdmin.GetHashCode();
                if (this.HypervisorAdminPwd != null)
                    hash = hash * 59 + this.HypervisorAdminPwd.GetHashCode();
                if (this.IsHxdpRootPwdSet != null)
                    hash = hash * 59 + this.IsHxdpRootPwdSet.GetHashCode();
                if (this.IsHypervisorAdminPwdSet != null)
                    hash = hash * 59 + this.IsHypervisorAdminPwdSet.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
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
