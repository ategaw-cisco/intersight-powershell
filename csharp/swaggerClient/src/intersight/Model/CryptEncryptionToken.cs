/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-261
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
    /// This is the token used by any service to authenticate with encryption service to encrypt or decrypt secure Mo properties.  The lifetime of the token is generally tied to lifetime of user session or device connection  However, in case of user triggers workflows, the token would be needed even after the user logs off. The encryption token is created by Encryption service when (user or device) session is created  (i.e user logon or device connects to Intersight) or when user triggers a workflow.   Once created, the token is valid for duration of 1 hour and will expire if not renewed. To avoid expiry, token needs to be renewed. The renewal is done by the encryption service for user, device  and workflows based on notifications from the respective services (i.e Barracuda, Astro and Fusion) When user logs off or user session times out (i.e. session is deleted), the token associated with  the (user) session is also deleted. Similarly, when a device disconnects from Intersight, the  token is deleted. However, any token created due to user triggering a workflow stays as long as workflow completes. The token is added to the security context at Barracuda (user sessions), Astro (devices) and  Fusion (workflows) and passed to downstream services. These services invoke encryption service  APIs such as encrypt or decrypt with this token along with data (like password). When user saves a secure property (e.g password), the service owning this MO (and property) invokes the encryption service with the token (passed through security context) &amp; (cleartext)  password it received through the security context. The encryption service uses Hashicorp Vault&#39;s transit  backend to encrypt/decrypt property using a Key derived from Account Key (each account has a Key)  and Master Key (Intersight). The ciphertext returned by encryption service is persisted to database. When workflows are scheduled to run, the requests are sent to the service owning the MO, which invokes the encryption service with the token (passed through security context) and  encrypted password it read from the database. The encryption service decrypt it with a key derived from Account Key (each account has a Key) and Master Key (Intersight). The cleartext data is  returned which is used by the service to provision the devices. If workflows are scheduled in  the future or take a long time to complete, Encryption service will renew the token as long as Fusion notifies that the token needs to be kept alive. This is similar to what Barracuda or Astro need to do for user and device sessions respectively. 
    /// </summary>
    [DataContract]
    public partial class CryptEncryptionToken :  IEquatable<CryptEncryptionToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CryptEncryptionToken" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="AccountKey">AccountKey.</param>
        /// <param name="Wrapped">This indicates whether token is wrapped or not. When token is wrapped, it needs to be unwrapped before use   .</param>
        public CryptEncryptionToken(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), CryptAccountKeyRef AccountKey = default(CryptAccountKeyRef), bool? Wrapped = default(bool?))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.AccountKey = AccountKey;
            this.Wrapped = Wrapped;
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
        /// Gets or Sets AccountKey
        /// </summary>
        [DataMember(Name="AccountKey", EmitDefaultValue=false)]
        public CryptAccountKeyRef AccountKey { get; set; }

        /// <summary>
        /// The encryption token is created for every user session (web or API), workflow or device connection. This field uniquely identifies the session  
        /// </summary>
        /// <value>The encryption token is created for every user session (web or API), workflow or device connection. This field uniquely identifies the session  </value>
        [DataMember(Name="SessionId", EmitDefaultValue=false)]
        public string SessionId { get; private set; }

        /// <summary>
        /// The Session Type indicates the type of session the encryption token is created for. Tokens are created for Web, ApiKeys, Workflow, etc  
        /// </summary>
        /// <value>The Session Type indicates the type of session the encryption token is created for. Tokens are created for Web, ApiKeys, Workflow, etc  </value>
        [DataMember(Name="SessionType", EmitDefaultValue=false)]
        public long? SessionType { get; private set; }

        /// <summary>
        /// The token to authenticate (user) session or device for encrypting/decrypting sensitive information.  
        /// </summary>
        /// <value>The token to authenticate (user) session or device for encrypting/decrypting sensitive information.  </value>
        [DataMember(Name="Token", EmitDefaultValue=false)]
        public string Token { get; private set; }

        /// <summary>
        /// The token accessor within the vault. Used to identify the token within vault.  
        /// </summary>
        /// <value>The token accessor within the vault. Used to identify the token within vault.  </value>
        [DataMember(Name="TokenAccessor", EmitDefaultValue=false)]
        public string TokenAccessor { get; private set; }

        /// <summary>
        /// This indicates whether token is wrapped or not. When token is wrapped, it needs to be unwrapped before use   
        /// </summary>
        /// <value>This indicates whether token is wrapped or not. When token is wrapped, it needs to be unwrapped before use   </value>
        [DataMember(Name="Wrapped", EmitDefaultValue=false)]
        public bool? Wrapped { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CryptEncryptionToken {\n");
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
            sb.Append("  AccountKey: ").Append(AccountKey).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SessionType: ").Append(SessionType).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenAccessor: ").Append(TokenAccessor).Append("\n");
            sb.Append("  Wrapped: ").Append(Wrapped).Append("\n");
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
            return this.Equals(obj as CryptEncryptionToken);
        }

        /// <summary>
        /// Returns true if CryptEncryptionToken instances are equal
        /// </summary>
        /// <param name="other">Instance of CryptEncryptionToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CryptEncryptionToken other)
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
                    this.AccountKey == other.AccountKey ||
                    this.AccountKey != null &&
                    this.AccountKey.Equals(other.AccountKey)
                ) && 
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) && 
                (
                    this.SessionType == other.SessionType ||
                    this.SessionType != null &&
                    this.SessionType.Equals(other.SessionType)
                ) && 
                (
                    this.Token == other.Token ||
                    this.Token != null &&
                    this.Token.Equals(other.Token)
                ) && 
                (
                    this.TokenAccessor == other.TokenAccessor ||
                    this.TokenAccessor != null &&
                    this.TokenAccessor.Equals(other.TokenAccessor)
                ) && 
                (
                    this.Wrapped == other.Wrapped ||
                    this.Wrapped != null &&
                    this.Wrapped.Equals(other.Wrapped)
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
                if (this.AccountKey != null)
                    hash = hash * 59 + this.AccountKey.GetHashCode();
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                if (this.SessionType != null)
                    hash = hash * 59 + this.SessionType.GetHashCode();
                if (this.Token != null)
                    hash = hash * 59 + this.Token.GetHashCode();
                if (this.TokenAccessor != null)
                    hash = hash * 59 + this.TokenAccessor.GetHashCode();
                if (this.Wrapped != null)
                    hash = hash * 59 + this.Wrapped.GetHashCode();
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
