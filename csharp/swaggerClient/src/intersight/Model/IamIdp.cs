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
    /// IdP represents the SAML identity provider such as Cisco, that has been used to log in to Intersight. 
    /// </summary>
    [DataContract]
    public partial class IamIdp :  IEquatable<IamIdp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IamIdp" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Account">Account.</param>
        /// <param name="DomainName">User&#39;s email domain name for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication.  .</param>
        /// <param name="Metadata">SAML metadata of the IdP.  .</param>
        /// <param name="Name">Name of the IdP.   .</param>
        /// <param name="System">System.</param>
        /// <param name="UserLoginTime">Represents the last login session details for each logged in user of this IdP. .</param>
        /// <param name="UserPreferences">Represents the UI preference object for each user logged in through this IdP. .</param>
        /// <param name="Usergroups">User groups added in an IdP. User group provides a way to configure permission assignment for a group of users based on IdP attributes received after authentication. .</param>
        /// <param name="Users">Added or logged in users of an IdP who can access an Intersight account. .</param>
        public IamIdp(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), IamAccountRef Account = default(IamAccountRef), string DomainName = default(string), string Metadata = default(string), string Name = default(string), IamSystemRef System = default(IamSystemRef), List<IamUserLoginTimeRef> UserLoginTime = default(List<IamUserLoginTimeRef>), List<IamUserPreferenceRef> UserPreferences = default(List<IamUserPreferenceRef>), List<IamUserGroupRef> Usergroups = default(List<IamUserGroupRef>), List<IamUserRef> Users = default(List<IamUserRef>))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Account = Account;
            this.DomainName = DomainName;
            this.Metadata = Metadata;
            this.Name = Name;
            this.System = System;
            this.UserLoginTime = UserLoginTime;
            this.UserPreferences = UserPreferences;
            this.Usergroups = Usergroups;
            this.Users = Users;
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
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public IamAccountRef Account { get; set; }

        /// <summary>
        /// User&#39;s email domain name for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication.  
        /// </summary>
        /// <value>User&#39;s email domain name for this IdP. When a user enters an email during login in the Intersight home page, the IdP is picked by matching this domain name with the email domain name for authentication.  </value>
        [DataMember(Name="DomainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// Entity ID of the IdP. In SAML, the entity ID uniquely identifies IdP/Service Provider.  
        /// </summary>
        /// <value>Entity ID of the IdP. In SAML, the entity ID uniquely identifies IdP/Service Provider.  </value>
        [DataMember(Name="IdpEntityId", EmitDefaultValue=false)]
        public string IdpEntityId { get; private set; }

        /// <summary>
        /// SAML metadata of the IdP.  
        /// </summary>
        /// <value>SAML metadata of the IdP.  </value>
        [DataMember(Name="Metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Name of the IdP.   
        /// </summary>
        /// <value>Name of the IdP.   </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="System", EmitDefaultValue=false)]
        public IamSystemRef System { get; set; }

        /// <summary>
        /// Represents the last login session details for each logged in user of this IdP. 
        /// </summary>
        /// <value>Represents the last login session details for each logged in user of this IdP. </value>
        [DataMember(Name="UserLoginTime", EmitDefaultValue=false)]
        public List<IamUserLoginTimeRef> UserLoginTime { get; set; }

        /// <summary>
        /// Represents the UI preference object for each user logged in through this IdP. 
        /// </summary>
        /// <value>Represents the UI preference object for each user logged in through this IdP. </value>
        [DataMember(Name="UserPreferences", EmitDefaultValue=false)]
        public List<IamUserPreferenceRef> UserPreferences { get; set; }

        /// <summary>
        /// User groups added in an IdP. User group provides a way to configure permission assignment for a group of users based on IdP attributes received after authentication. 
        /// </summary>
        /// <value>User groups added in an IdP. User group provides a way to configure permission assignment for a group of users based on IdP attributes received after authentication. </value>
        [DataMember(Name="Usergroups", EmitDefaultValue=false)]
        public List<IamUserGroupRef> Usergroups { get; set; }

        /// <summary>
        /// Added or logged in users of an IdP who can access an Intersight account. 
        /// </summary>
        /// <value>Added or logged in users of an IdP who can access an Intersight account. </value>
        [DataMember(Name="Users", EmitDefaultValue=false)]
        public List<IamUserRef> Users { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IamIdp {\n");
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
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  IdpEntityId: ").Append(IdpEntityId).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  UserLoginTime: ").Append(UserLoginTime).Append("\n");
            sb.Append("  UserPreferences: ").Append(UserPreferences).Append("\n");
            sb.Append("  Usergroups: ").Append(Usergroups).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
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
            return this.Equals(obj as IamIdp);
        }

        /// <summary>
        /// Returns true if IamIdp instances are equal
        /// </summary>
        /// <param name="other">Instance of IamIdp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IamIdp other)
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
                    this.DomainName == other.DomainName ||
                    this.DomainName != null &&
                    this.DomainName.Equals(other.DomainName)
                ) && 
                (
                    this.IdpEntityId == other.IdpEntityId ||
                    this.IdpEntityId != null &&
                    this.IdpEntityId.Equals(other.IdpEntityId)
                ) && 
                (
                    this.Metadata == other.Metadata ||
                    this.Metadata != null &&
                    this.Metadata.Equals(other.Metadata)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.System == other.System ||
                    this.System != null &&
                    this.System.Equals(other.System)
                ) && 
                (
                    this.UserLoginTime == other.UserLoginTime ||
                    this.UserLoginTime != null &&
                    this.UserLoginTime.SequenceEqual(other.UserLoginTime)
                ) && 
                (
                    this.UserPreferences == other.UserPreferences ||
                    this.UserPreferences != null &&
                    this.UserPreferences.SequenceEqual(other.UserPreferences)
                ) && 
                (
                    this.Usergroups == other.Usergroups ||
                    this.Usergroups != null &&
                    this.Usergroups.SequenceEqual(other.Usergroups)
                ) && 
                (
                    this.Users == other.Users ||
                    this.Users != null &&
                    this.Users.SequenceEqual(other.Users)
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
                if (this.DomainName != null)
                    hash = hash * 59 + this.DomainName.GetHashCode();
                if (this.IdpEntityId != null)
                    hash = hash * 59 + this.IdpEntityId.GetHashCode();
                if (this.Metadata != null)
                    hash = hash * 59 + this.Metadata.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.System != null)
                    hash = hash * 59 + this.System.GetHashCode();
                if (this.UserLoginTime != null)
                    hash = hash * 59 + this.UserLoginTime.GetHashCode();
                if (this.UserPreferences != null)
                    hash = hash * 59 + this.UserPreferences.GetHashCode();
                if (this.Usergroups != null)
                    hash = hash * 59 + this.Usergroups.GetHashCode();
                if (this.Users != null)
                    hash = hash * 59 + this.Users.GetHashCode();
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
