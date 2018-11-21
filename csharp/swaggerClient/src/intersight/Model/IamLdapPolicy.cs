/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-255
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
    /// LDAP Policy 
    /// </summary>
    [DataContract]
    public partial class IamLdapPolicy :  IEquatable<IamLdapPolicy>, IValidatableObject
    {
        /// <summary>
        /// Search precedence between local user database and LDAP user database   
        /// </summary>
        /// <value>Search precedence between local user database and LDAP user database   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UserSearchPrecedenceEnum
        {
            
            /// <summary>
            /// Enum LocalUserDb for "LocalUserDb"
            /// </summary>
            [EnumMember(Value = "LocalUserDb")]
            LocalUserDb,
            
            /// <summary>
            /// Enum LDAPUserDb for "LDAPUserDb"
            /// </summary>
            [EnumMember(Value = "LDAPUserDb")]
            LDAPUserDb
        }

        /// <summary>
        /// Search precedence between local user database and LDAP user database   
        /// </summary>
        /// <value>Search precedence between local user database and LDAP user database   </value>
        [DataMember(Name="UserSearchPrecedence", EmitDefaultValue=false)]
        public UserSearchPrecedenceEnum? UserSearchPrecedence { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IamLdapPolicy" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Description">Description of the policy.  .</param>
        /// <param name="Name">Name of the policy.   .</param>
        /// <param name="BaseProperties">set LDAP base properties for the policy  .</param>
        /// <param name="DnsParameters">Configuration settings to resolve LDAP servers, when DNS is enabled  .</param>
        /// <param name="EnableDns">If enabled, DNS can be configured to access LDAP servers  .</param>
        /// <param name="Enabled">If enabled, authentication is performed by the LDAP servers mentioned in the policy  .</param>
        /// <param name="Groups">Relationship to collection of LDAP Groups .</param>
        /// <param name="Organization">Organization .</param>
        /// <param name="Profiles">Relationship to the profile object .</param>
        /// <param name="Providers">Relationship to collection of LDAP Providers .</param>
        /// <param name="UserSearchPrecedence">Search precedence between local user database and LDAP user database    (default to UserSearchPrecedenceEnum.LocalUserDb).</param>
        public IamLdapPolicy(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string Description = default(string), string Name = default(string), IamLdapBaseProperties BaseProperties = default(IamLdapBaseProperties), IamLdapDnsParameters DnsParameters = default(IamLdapDnsParameters), bool? EnableDns = default(bool?), bool? Enabled = default(bool?), List<IamLdapGroupRef> Groups = default(List<IamLdapGroupRef>), IamAccountRef Organization = default(IamAccountRef), List<PolicyAbstractConfigProfileRef> Profiles = default(List<PolicyAbstractConfigProfileRef>), List<IamLdapProviderRef> Providers = default(List<IamLdapProviderRef>), UserSearchPrecedenceEnum? UserSearchPrecedence = UserSearchPrecedenceEnum.LocalUserDb)
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Description = Description;
            this.Name = Name;
            this.BaseProperties = BaseProperties;
            this.DnsParameters = DnsParameters;
            this.EnableDns = EnableDns;
            this.Enabled = Enabled;
            this.Groups = Groups;
            this.Organization = Organization;
            this.Profiles = Profiles;
            this.Providers = Providers;
            // use default value if no "UserSearchPrecedence" provided
            if (UserSearchPrecedence == null)
            {
                this.UserSearchPrecedence = UserSearchPrecedenceEnum.LocalUserDb;
            }
            else
            {
                this.UserSearchPrecedence = UserSearchPrecedence;
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
        /// set LDAP base properties for the policy  
        /// </summary>
        /// <value>set LDAP base properties for the policy  </value>
        [DataMember(Name="BaseProperties", EmitDefaultValue=false)]
        public IamLdapBaseProperties BaseProperties { get; set; }

        /// <summary>
        /// Configuration settings to resolve LDAP servers, when DNS is enabled  
        /// </summary>
        /// <value>Configuration settings to resolve LDAP servers, when DNS is enabled  </value>
        [DataMember(Name="DnsParameters", EmitDefaultValue=false)]
        public IamLdapDnsParameters DnsParameters { get; set; }

        /// <summary>
        /// If enabled, DNS can be configured to access LDAP servers  
        /// </summary>
        /// <value>If enabled, DNS can be configured to access LDAP servers  </value>
        [DataMember(Name="EnableDns", EmitDefaultValue=false)]
        public bool? EnableDns { get; set; }

        /// <summary>
        /// If enabled, authentication is performed by the LDAP servers mentioned in the policy  
        /// </summary>
        /// <value>If enabled, authentication is performed by the LDAP servers mentioned in the policy  </value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Relationship to collection of LDAP Groups 
        /// </summary>
        /// <value>Relationship to collection of LDAP Groups </value>
        [DataMember(Name="Groups", EmitDefaultValue=false)]
        public List<IamLdapGroupRef> Groups { get; set; }

        /// <summary>
        /// Organization 
        /// </summary>
        /// <value>Organization </value>
        [DataMember(Name="Organization", EmitDefaultValue=false)]
        public IamAccountRef Organization { get; set; }

        /// <summary>
        /// Relationship to the profile object 
        /// </summary>
        /// <value>Relationship to the profile object </value>
        [DataMember(Name="Profiles", EmitDefaultValue=false)]
        public List<PolicyAbstractConfigProfileRef> Profiles { get; set; }

        /// <summary>
        /// Relationship to collection of LDAP Providers 
        /// </summary>
        /// <value>Relationship to collection of LDAP Providers </value>
        [DataMember(Name="Providers", EmitDefaultValue=false)]
        public List<IamLdapProviderRef> Providers { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IamLdapPolicy {\n");
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
            sb.Append("  BaseProperties: ").Append(BaseProperties).Append("\n");
            sb.Append("  DnsParameters: ").Append(DnsParameters).Append("\n");
            sb.Append("  EnableDns: ").Append(EnableDns).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  UserSearchPrecedence: ").Append(UserSearchPrecedence).Append("\n");
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
            return this.Equals(obj as IamLdapPolicy);
        }

        /// <summary>
        /// Returns true if IamLdapPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of IamLdapPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IamLdapPolicy other)
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
                    this.BaseProperties == other.BaseProperties ||
                    this.BaseProperties != null &&
                    this.BaseProperties.Equals(other.BaseProperties)
                ) && 
                (
                    this.DnsParameters == other.DnsParameters ||
                    this.DnsParameters != null &&
                    this.DnsParameters.Equals(other.DnsParameters)
                ) && 
                (
                    this.EnableDns == other.EnableDns ||
                    this.EnableDns != null &&
                    this.EnableDns.Equals(other.EnableDns)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Groups == other.Groups ||
                    this.Groups != null &&
                    this.Groups.SequenceEqual(other.Groups)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.Profiles == other.Profiles ||
                    this.Profiles != null &&
                    this.Profiles.SequenceEqual(other.Profiles)
                ) && 
                (
                    this.Providers == other.Providers ||
                    this.Providers != null &&
                    this.Providers.SequenceEqual(other.Providers)
                ) && 
                (
                    this.UserSearchPrecedence == other.UserSearchPrecedence ||
                    this.UserSearchPrecedence != null &&
                    this.UserSearchPrecedence.Equals(other.UserSearchPrecedence)
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
                if (this.BaseProperties != null)
                    hash = hash * 59 + this.BaseProperties.GetHashCode();
                if (this.DnsParameters != null)
                    hash = hash * 59 + this.DnsParameters.GetHashCode();
                if (this.EnableDns != null)
                    hash = hash * 59 + this.EnableDns.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Groups != null)
                    hash = hash * 59 + this.Groups.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.Profiles != null)
                    hash = hash * 59 + this.Profiles.GetHashCode();
                if (this.Providers != null)
                    hash = hash * 59 + this.Providers.GetHashCode();
                if (this.UserSearchPrecedence != null)
                    hash = hash * 59 + this.UserSearchPrecedence.GetHashCode();
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
