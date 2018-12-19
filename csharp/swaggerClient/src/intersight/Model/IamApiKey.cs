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
    /// API keys are used to programatically perform API calls. API keys can be created by passing purpose field, which is a description for the application using API keys. Maximum of 3 API keys per user is allowed. API key will have RSA key pair generated and as part of create request key MOID, private and public key in PEM format are returned. In Intersight only the public key is stored. Client side private key is stored and is used for signature calculation. API key requests are authenticated using RSA SHA 256 signature validations. If the incoming request for authorization has X-Starship-Token, then session based authorization is done, else API key based authorization is performed. Once User, API key and Account are found and signature verification succeeds, then the privilege validations are performed. 
    /// </summary>
    [DataContract]
    public partial class IamApiKey :  IEquatable<IamApiKey>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IamApiKey" /> class.
        /// </summary>
        /// <param name="Ancestors">The array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">The unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">The array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">The array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object.   .</param>
        /// <param name="Permission">Permissions associated with the API key. Permission provides a way to assign roles to a user or user group to perform operations on object hierarchy. .</param>
        /// <param name="PrivateKey">Holds private key for API key.   .</param>
        /// <param name="Purpose">Specifies the purpose of API Key.   .</param>
        /// <param name="User">A collection of references to the [iam.User](mo://iam.User) Managed Object.  When this managed object is deleted, the referenced [iam.User](mo://iam.User) MO unsets its reference to this deleted MO. .</param>
        public IamApiKey(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), IamPermissionRef Permission = default(IamPermissionRef), string PrivateKey = default(string), string Purpose = default(string), IamUserRef User = default(IamUserRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Permission = Permission;
            this.PrivateKey = PrivateKey;
            this.Purpose = Purpose;
            this.User = User;
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
        /// Permissions associated with the API key. Permission provides a way to assign roles to a user or user group to perform operations on object hierarchy. 
        /// </summary>
        /// <value>Permissions associated with the API key. Permission provides a way to assign roles to a user or user group to perform operations on object hierarchy. </value>
        [DataMember(Name="Permission", EmitDefaultValue=false)]
        public IamPermissionRef Permission { get; set; }

        /// <summary>
        /// Holds private key for API key.   
        /// </summary>
        /// <value>Holds private key for API key.   </value>
        [DataMember(Name="PrivateKey", EmitDefaultValue=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// Specifies the purpose of API Key.   
        /// </summary>
        /// <value>Specifies the purpose of API Key.   </value>
        [DataMember(Name="Purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }

        /// <summary>
        /// A collection of references to the [iam.User](mo://iam.User) Managed Object.  When this managed object is deleted, the referenced [iam.User](mo://iam.User) MO unsets its reference to this deleted MO. 
        /// </summary>
        /// <value>A collection of references to the [iam.User](mo://iam.User) Managed Object.  When this managed object is deleted, the referenced [iam.User](mo://iam.User) MO unsets its reference to this deleted MO. </value>
        [DataMember(Name="User", EmitDefaultValue=false)]
        public IamUserRef User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IamApiKey {\n");
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
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  PrivateKey: ").Append(PrivateKey).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(obj as IamApiKey);
        }

        /// <summary>
        /// Returns true if IamApiKey instances are equal
        /// </summary>
        /// <param name="other">Instance of IamApiKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IamApiKey other)
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
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.PrivateKey == other.PrivateKey ||
                    this.PrivateKey != null &&
                    this.PrivateKey.Equals(other.PrivateKey)
                ) && 
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
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
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.PrivateKey != null)
                    hash = hash * 59 + this.PrivateKey.GetHashCode();
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
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
