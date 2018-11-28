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
    /// LDAP Base Settings 
    /// </summary>
    [DataContract]
    public partial class IamLdapBaseProperties :  IEquatable<IamLdapBaseProperties>, IValidatableObject
    {
        /// <summary>
        /// Authentication method to access LDAP servers  
        /// </summary>
        /// <value>Authentication method to access LDAP servers  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BindMethodEnum
        {
            
            /// <summary>
            /// Enum LoginCredentials for "LoginCredentials"
            /// </summary>
            [EnumMember(Value = "LoginCredentials")]
            LoginCredentials,
            
            /// <summary>
            /// Enum Anonymous for "Anonymous"
            /// </summary>
            [EnumMember(Value = "Anonymous")]
            Anonymous,
            
            /// <summary>
            /// Enum ConfiguredCredentials for "ConfiguredCredentials"
            /// </summary>
            [EnumMember(Value = "ConfiguredCredentials")]
            ConfiguredCredentials
        }

        /// <summary>
        /// Authentication method to access LDAP servers  
        /// </summary>
        /// <value>Authentication method to access LDAP servers  </value>
        [DataMember(Name="BindMethod", EmitDefaultValue=false)]
        public BindMethodEnum? BindMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IamLdapBaseProperties" /> class.
        /// </summary>
        /// <param name="Attribute">Role and locale information of the user  .</param>
        /// <param name="BaseDn">Base Distinguished Name(DN). Starting point from where server will search for users and groups  .</param>
        /// <param name="BindDn">Distinguished Name(DN) of the user, that is used to authenticate against LDAP servers  .</param>
        /// <param name="BindMethod">Authentication method to access LDAP servers   (default to BindMethodEnum.LoginCredentials).</param>
        /// <param name="Domain">The IPv4 domain that all users must be in  .</param>
        /// <param name="EnableEncryption">If enabled, the endpoint encrypts all information it sends to the LDAP server  .</param>
        /// <param name="EnableGroupAuthorization">If enabled, user authorization is also done at the group level for LDAP users not in the local user database  .</param>
        /// <param name="Filter">Criteria to identify entries in search requests  .</param>
        /// <param name="GroupAttribute">Groups to which an LDAP entry belongs  .</param>
        /// <param name="IsPasswordSet">IsPasswordSet.</param>
        /// <param name="NestedGroupSearchDepth">Search depth to look for a nested LDAP group in an LDAP group map  .</param>
        /// <param name="Password">Password of the user  .</param>
        /// <param name="Timeout">LDAP authentication timeout duration, in seconds   .</param>
        public IamLdapBaseProperties(string Attribute = default(string), string BaseDn = default(string), string BindDn = default(string), BindMethodEnum? BindMethod = BindMethodEnum.LoginCredentials, string Domain = default(string), bool? EnableEncryption = default(bool?), bool? EnableGroupAuthorization = default(bool?), string Filter = default(string), string GroupAttribute = default(string), bool? IsPasswordSet = default(bool?), long? NestedGroupSearchDepth = default(long?), string Password = default(string), long? Timeout = default(long?))
        {
            this.Attribute = Attribute;
            this.BaseDn = BaseDn;
            this.BindDn = BindDn;
            // use default value if no "BindMethod" provided
            if (BindMethod == null)
            {
                this.BindMethod = BindMethodEnum.LoginCredentials;
            }
            else
            {
                this.BindMethod = BindMethod;
            }
            this.Domain = Domain;
            this.EnableEncryption = EnableEncryption;
            this.EnableGroupAuthorization = EnableGroupAuthorization;
            this.Filter = Filter;
            this.GroupAttribute = GroupAttribute;
            this.IsPasswordSet = IsPasswordSet;
            this.NestedGroupSearchDepth = NestedGroupSearchDepth;
            this.Password = Password;
            this.Timeout = Timeout;
        }
        
        /// <summary>
        /// Role and locale information of the user  
        /// </summary>
        /// <value>Role and locale information of the user  </value>
        [DataMember(Name="Attribute", EmitDefaultValue=false)]
        public string Attribute { get; set; }

        /// <summary>
        /// Base Distinguished Name(DN). Starting point from where server will search for users and groups  
        /// </summary>
        /// <value>Base Distinguished Name(DN). Starting point from where server will search for users and groups  </value>
        [DataMember(Name="BaseDn", EmitDefaultValue=false)]
        public string BaseDn { get; set; }

        /// <summary>
        /// Distinguished Name(DN) of the user, that is used to authenticate against LDAP servers  
        /// </summary>
        /// <value>Distinguished Name(DN) of the user, that is used to authenticate against LDAP servers  </value>
        [DataMember(Name="BindDn", EmitDefaultValue=false)]
        public string BindDn { get; set; }


        /// <summary>
        /// The IPv4 domain that all users must be in  
        /// </summary>
        /// <value>The IPv4 domain that all users must be in  </value>
        [DataMember(Name="Domain", EmitDefaultValue=false)]
        public string Domain { get; set; }

        /// <summary>
        /// If enabled, the endpoint encrypts all information it sends to the LDAP server  
        /// </summary>
        /// <value>If enabled, the endpoint encrypts all information it sends to the LDAP server  </value>
        [DataMember(Name="EnableEncryption", EmitDefaultValue=false)]
        public bool? EnableEncryption { get; set; }

        /// <summary>
        /// If enabled, user authorization is also done at the group level for LDAP users not in the local user database  
        /// </summary>
        /// <value>If enabled, user authorization is also done at the group level for LDAP users not in the local user database  </value>
        [DataMember(Name="EnableGroupAuthorization", EmitDefaultValue=false)]
        public bool? EnableGroupAuthorization { get; set; }

        /// <summary>
        /// Criteria to identify entries in search requests  
        /// </summary>
        /// <value>Criteria to identify entries in search requests  </value>
        [DataMember(Name="Filter", EmitDefaultValue=false)]
        public string Filter { get; set; }

        /// <summary>
        /// Groups to which an LDAP entry belongs  
        /// </summary>
        /// <value>Groups to which an LDAP entry belongs  </value>
        [DataMember(Name="GroupAttribute", EmitDefaultValue=false)]
        public string GroupAttribute { get; set; }

        /// <summary>
        /// Gets or Sets IsPasswordSet
        /// </summary>
        [DataMember(Name="IsPasswordSet", EmitDefaultValue=false)]
        public bool? IsPasswordSet { get; set; }

        /// <summary>
        /// Search depth to look for a nested LDAP group in an LDAP group map  
        /// </summary>
        /// <value>Search depth to look for a nested LDAP group in an LDAP group map  </value>
        [DataMember(Name="NestedGroupSearchDepth", EmitDefaultValue=false)]
        public long? NestedGroupSearchDepth { get; set; }

        /// <summary>
        /// Password of the user  
        /// </summary>
        /// <value>Password of the user  </value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// LDAP authentication timeout duration, in seconds   
        /// </summary>
        /// <value>LDAP authentication timeout duration, in seconds   </value>
        [DataMember(Name="Timeout", EmitDefaultValue=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IamLdapBaseProperties {\n");
            sb.Append("  Attribute: ").Append(Attribute).Append("\n");
            sb.Append("  BaseDn: ").Append(BaseDn).Append("\n");
            sb.Append("  BindDn: ").Append(BindDn).Append("\n");
            sb.Append("  BindMethod: ").Append(BindMethod).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  EnableEncryption: ").Append(EnableEncryption).Append("\n");
            sb.Append("  EnableGroupAuthorization: ").Append(EnableGroupAuthorization).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  GroupAttribute: ").Append(GroupAttribute).Append("\n");
            sb.Append("  IsPasswordSet: ").Append(IsPasswordSet).Append("\n");
            sb.Append("  NestedGroupSearchDepth: ").Append(NestedGroupSearchDepth).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
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
            return this.Equals(obj as IamLdapBaseProperties);
        }

        /// <summary>
        /// Returns true if IamLdapBaseProperties instances are equal
        /// </summary>
        /// <param name="other">Instance of IamLdapBaseProperties to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IamLdapBaseProperties other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Attribute == other.Attribute ||
                    this.Attribute != null &&
                    this.Attribute.Equals(other.Attribute)
                ) && 
                (
                    this.BaseDn == other.BaseDn ||
                    this.BaseDn != null &&
                    this.BaseDn.Equals(other.BaseDn)
                ) && 
                (
                    this.BindDn == other.BindDn ||
                    this.BindDn != null &&
                    this.BindDn.Equals(other.BindDn)
                ) && 
                (
                    this.BindMethod == other.BindMethod ||
                    this.BindMethod != null &&
                    this.BindMethod.Equals(other.BindMethod)
                ) && 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.EnableEncryption == other.EnableEncryption ||
                    this.EnableEncryption != null &&
                    this.EnableEncryption.Equals(other.EnableEncryption)
                ) && 
                (
                    this.EnableGroupAuthorization == other.EnableGroupAuthorization ||
                    this.EnableGroupAuthorization != null &&
                    this.EnableGroupAuthorization.Equals(other.EnableGroupAuthorization)
                ) && 
                (
                    this.Filter == other.Filter ||
                    this.Filter != null &&
                    this.Filter.Equals(other.Filter)
                ) && 
                (
                    this.GroupAttribute == other.GroupAttribute ||
                    this.GroupAttribute != null &&
                    this.GroupAttribute.Equals(other.GroupAttribute)
                ) && 
                (
                    this.IsPasswordSet == other.IsPasswordSet ||
                    this.IsPasswordSet != null &&
                    this.IsPasswordSet.Equals(other.IsPasswordSet)
                ) && 
                (
                    this.NestedGroupSearchDepth == other.NestedGroupSearchDepth ||
                    this.NestedGroupSearchDepth != null &&
                    this.NestedGroupSearchDepth.Equals(other.NestedGroupSearchDepth)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Timeout == other.Timeout ||
                    this.Timeout != null &&
                    this.Timeout.Equals(other.Timeout)
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
                if (this.Attribute != null)
                    hash = hash * 59 + this.Attribute.GetHashCode();
                if (this.BaseDn != null)
                    hash = hash * 59 + this.BaseDn.GetHashCode();
                if (this.BindDn != null)
                    hash = hash * 59 + this.BindDn.GetHashCode();
                if (this.BindMethod != null)
                    hash = hash * 59 + this.BindMethod.GetHashCode();
                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();
                if (this.EnableEncryption != null)
                    hash = hash * 59 + this.EnableEncryption.GetHashCode();
                if (this.EnableGroupAuthorization != null)
                    hash = hash * 59 + this.EnableGroupAuthorization.GetHashCode();
                if (this.Filter != null)
                    hash = hash * 59 + this.Filter.GetHashCode();
                if (this.GroupAttribute != null)
                    hash = hash * 59 + this.GroupAttribute.GetHashCode();
                if (this.IsPasswordSet != null)
                    hash = hash * 59 + this.IsPasswordSet.GetHashCode();
                if (this.NestedGroupSearchDepth != null)
                    hash = hash * 59 + this.NestedGroupSearchDepth.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Timeout != null)
                    hash = hash * 59 + this.Timeout.GetHashCode();
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
