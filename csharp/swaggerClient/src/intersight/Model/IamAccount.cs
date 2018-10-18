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
    /// This object represents an Intersight Account. An account provides personalized access to Intersight. 
    /// </summary>
    [DataContract]
    public partial class IamAccount :  IEquatable<IamAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IamAccount" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="DomainGroups">DomainGroups.</param>
        /// <param name="EndPointRoles">User defined end point roles. These roles are assigned to Intersight users to perform end point operations such as GUI/CLI cross launch. .</param>
        /// <param name="Idpreferences">System created IdPs configured for authentication in an account. By default Cisco IdP is created upon account creation. .</param>
        /// <param name="Idps">IdPs configured for authentication in an account. .</param>
        /// <param name="Name">Name of the account. By default, name is same as the MoID of the account.  .</param>
        /// <param name="Permissions">System defined permissions within an account. Permission provides a way to assign roles to a user or user group to perform operations on object hierarchy. .</param>
        /// <param name="PrivilegeSets">User defined privilege sets. Privilege set is a collection of privileges. Privilege sets are assigned to a user using roles. .</param>
        /// <param name="Privileges">Account specific privileges. Privilege represents an action which can be performed in Intersight such as creating server profile, deleting a user etc. Privileges are assigned to a user using privilege sets and roles. .</param>
        /// <param name="ResourceLimits">Represents user and user group related configuration limits. .</param>
        /// <param name="Roles">User defined roles created within an account. Role is a collection of privilege sets. Roles are assigned to user using permission object. .</param>
        /// <param name="SessionLimits">Represents session related configuration limits. .</param>
        public IamAccount(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), List<IamDomainGroupRef> DomainGroups = default(List<IamDomainGroupRef>), List<IamEndPointRoleRef> EndPointRoles = default(List<IamEndPointRoleRef>), List<IamIdpReferenceRef> Idpreferences = default(List<IamIdpReferenceRef>), List<IamIdpRef> Idps = default(List<IamIdpRef>), string Name = default(string), List<IamPermissionRef> Permissions = default(List<IamPermissionRef>), List<IamPrivilegeSetRef> PrivilegeSets = default(List<IamPrivilegeSetRef>), List<IamPrivilegeRef> Privileges = default(List<IamPrivilegeRef>), IamResourceLimitsRef ResourceLimits = default(IamResourceLimitsRef), List<IamRoleRef> Roles = default(List<IamRoleRef>), IamSessionLimitsRef SessionLimits = default(IamSessionLimitsRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.DomainGroups = DomainGroups;
            this.EndPointRoles = EndPointRoles;
            this.Idpreferences = Idpreferences;
            this.Idps = Idps;
            this.Name = Name;
            this.Permissions = Permissions;
            this.PrivilegeSets = PrivilegeSets;
            this.Privileges = Privileges;
            this.ResourceLimits = ResourceLimits;
            this.Roles = Roles;
            this.SessionLimits = SessionLimits;
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
        /// Gets or Sets DomainGroups
        /// </summary>
        [DataMember(Name="DomainGroups", EmitDefaultValue=false)]
        public List<IamDomainGroupRef> DomainGroups { get; set; }

        /// <summary>
        /// User defined end point roles. These roles are assigned to Intersight users to perform end point operations such as GUI/CLI cross launch. 
        /// </summary>
        /// <value>User defined end point roles. These roles are assigned to Intersight users to perform end point operations such as GUI/CLI cross launch. </value>
        [DataMember(Name="EndPointRoles", EmitDefaultValue=false)]
        public List<IamEndPointRoleRef> EndPointRoles { get; set; }

        /// <summary>
        /// System created IdPs configured for authentication in an account. By default Cisco IdP is created upon account creation. 
        /// </summary>
        /// <value>System created IdPs configured for authentication in an account. By default Cisco IdP is created upon account creation. </value>
        [DataMember(Name="Idpreferences", EmitDefaultValue=false)]
        public List<IamIdpReferenceRef> Idpreferences { get; set; }

        /// <summary>
        /// IdPs configured for authentication in an account. 
        /// </summary>
        /// <value>IdPs configured for authentication in an account. </value>
        [DataMember(Name="Idps", EmitDefaultValue=false)]
        public List<IamIdpRef> Idps { get; set; }

        /// <summary>
        /// Name of the account. By default, name is same as the MoID of the account.  
        /// </summary>
        /// <value>Name of the account. By default, name is same as the MoID of the account.  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// System defined permissions within an account. Permission provides a way to assign roles to a user or user group to perform operations on object hierarchy. 
        /// </summary>
        /// <value>System defined permissions within an account. Permission provides a way to assign roles to a user or user group to perform operations on object hierarchy. </value>
        [DataMember(Name="Permissions", EmitDefaultValue=false)]
        public List<IamPermissionRef> Permissions { get; set; }

        /// <summary>
        /// User defined privilege sets. Privilege set is a collection of privileges. Privilege sets are assigned to a user using roles. 
        /// </summary>
        /// <value>User defined privilege sets. Privilege set is a collection of privileges. Privilege sets are assigned to a user using roles. </value>
        [DataMember(Name="PrivilegeSets", EmitDefaultValue=false)]
        public List<IamPrivilegeSetRef> PrivilegeSets { get; set; }

        /// <summary>
        /// Account specific privileges. Privilege represents an action which can be performed in Intersight such as creating server profile, deleting a user etc. Privileges are assigned to a user using privilege sets and roles. 
        /// </summary>
        /// <value>Account specific privileges. Privilege represents an action which can be performed in Intersight such as creating server profile, deleting a user etc. Privileges are assigned to a user using privilege sets and roles. </value>
        [DataMember(Name="Privileges", EmitDefaultValue=false)]
        public List<IamPrivilegeRef> Privileges { get; set; }

        /// <summary>
        /// Represents user and user group related configuration limits. 
        /// </summary>
        /// <value>Represents user and user group related configuration limits. </value>
        [DataMember(Name="ResourceLimits", EmitDefaultValue=false)]
        public IamResourceLimitsRef ResourceLimits { get; set; }

        /// <summary>
        /// User defined roles created within an account. Role is a collection of privilege sets. Roles are assigned to user using permission object. 
        /// </summary>
        /// <value>User defined roles created within an account. Role is a collection of privilege sets. Roles are assigned to user using permission object. </value>
        [DataMember(Name="Roles", EmitDefaultValue=false)]
        public List<IamRoleRef> Roles { get; set; }

        /// <summary>
        /// Represents session related configuration limits. 
        /// </summary>
        /// <value>Represents session related configuration limits. </value>
        [DataMember(Name="SessionLimits", EmitDefaultValue=false)]
        public IamSessionLimitsRef SessionLimits { get; set; }

        /// <summary>
        /// Status of the account. This account remains inactive until a device is claimed to the account.   
        /// </summary>
        /// <value>Status of the account. This account remains inactive until a device is claimed to the account.   </value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IamAccount {\n");
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
            sb.Append("  DomainGroups: ").Append(DomainGroups).Append("\n");
            sb.Append("  EndPointRoles: ").Append(EndPointRoles).Append("\n");
            sb.Append("  Idpreferences: ").Append(Idpreferences).Append("\n");
            sb.Append("  Idps: ").Append(Idps).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  PrivilegeSets: ").Append(PrivilegeSets).Append("\n");
            sb.Append("  Privileges: ").Append(Privileges).Append("\n");
            sb.Append("  ResourceLimits: ").Append(ResourceLimits).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  SessionLimits: ").Append(SessionLimits).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as IamAccount);
        }

        /// <summary>
        /// Returns true if IamAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of IamAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IamAccount other)
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
                    this.DomainGroups == other.DomainGroups ||
                    this.DomainGroups != null &&
                    this.DomainGroups.SequenceEqual(other.DomainGroups)
                ) && 
                (
                    this.EndPointRoles == other.EndPointRoles ||
                    this.EndPointRoles != null &&
                    this.EndPointRoles.SequenceEqual(other.EndPointRoles)
                ) && 
                (
                    this.Idpreferences == other.Idpreferences ||
                    this.Idpreferences != null &&
                    this.Idpreferences.SequenceEqual(other.Idpreferences)
                ) && 
                (
                    this.Idps == other.Idps ||
                    this.Idps != null &&
                    this.Idps.SequenceEqual(other.Idps)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.PrivilegeSets == other.PrivilegeSets ||
                    this.PrivilegeSets != null &&
                    this.PrivilegeSets.SequenceEqual(other.PrivilegeSets)
                ) && 
                (
                    this.Privileges == other.Privileges ||
                    this.Privileges != null &&
                    this.Privileges.SequenceEqual(other.Privileges)
                ) && 
                (
                    this.ResourceLimits == other.ResourceLimits ||
                    this.ResourceLimits != null &&
                    this.ResourceLimits.Equals(other.ResourceLimits)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.SequenceEqual(other.Roles)
                ) && 
                (
                    this.SessionLimits == other.SessionLimits ||
                    this.SessionLimits != null &&
                    this.SessionLimits.Equals(other.SessionLimits)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.DomainGroups != null)
                    hash = hash * 59 + this.DomainGroups.GetHashCode();
                if (this.EndPointRoles != null)
                    hash = hash * 59 + this.EndPointRoles.GetHashCode();
                if (this.Idpreferences != null)
                    hash = hash * 59 + this.Idpreferences.GetHashCode();
                if (this.Idps != null)
                    hash = hash * 59 + this.Idps.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Permissions != null)
                    hash = hash * 59 + this.Permissions.GetHashCode();
                if (this.PrivilegeSets != null)
                    hash = hash * 59 + this.PrivilegeSets.GetHashCode();
                if (this.Privileges != null)
                    hash = hash * 59 + this.Privileges.GetHashCode();
                if (this.ResourceLimits != null)
                    hash = hash * 59 + this.ResourceLimits.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.SessionLimits != null)
                    hash = hash * 59 + this.SessionLimits.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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
