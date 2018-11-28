/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-262
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
    /// License information for an account 
    /// </summary>
    [DataContract]
    public partial class LicenseAccountLicenseData :  IEquatable<LicenseAccountLicenseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseAccountLicenseData" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Account">Account.</param>
        /// <param name="CustomerOp">CustomerOp.</param>
        /// <param name="Licenseinfos">Licenseinfos.</param>
        /// <param name="SmartlicenseToken">SmartlicenseToken.</param>
        public LicenseAccountLicenseData(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), IamAccountRef Account = default(IamAccountRef), LicenseCustomerOpRef CustomerOp = default(LicenseCustomerOpRef), List<LicenseLicenseInfoRef> Licenseinfos = default(List<LicenseLicenseInfoRef>), LicenseSmartlicenseTokenRef SmartlicenseToken = default(LicenseSmartlicenseTokenRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Account = Account;
            this.CustomerOp = CustomerOp;
            this.Licenseinfos = Licenseinfos;
            this.SmartlicenseToken = SmartlicenseToken;
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
        /// Root user&#39;s ID of the account  
        /// </summary>
        /// <value>Root user&#39;s ID of the account  </value>
        [DataMember(Name="AccountId", EmitDefaultValue=false)]
        public string AccountId { get; private set; }

        /// <summary>
        /// Agent trusted store data  
        /// </summary>
        /// <value>Agent trusted store data  </value>
        [DataMember(Name="AgentData", EmitDefaultValue=false)]
        public string AgentData { get; private set; }

        /// <summary>
        /// Authorization expiration time  
        /// </summary>
        /// <value>Authorization expiration time  </value>
        [DataMember(Name="AuthExpireTime", EmitDefaultValue=false)]
        public string AuthExpireTime { get; private set; }

        /// <summary>
        /// Intial Authorization time  
        /// </summary>
        /// <value>Intial Authorization time  </value>
        [DataMember(Name="AuthInitialTime", EmitDefaultValue=false)]
        public string AuthInitialTime { get; private set; }

        /// <summary>
        /// Next time for Authorization  
        /// </summary>
        /// <value>Next time for Authorization  </value>
        [DataMember(Name="AuthNextTime", EmitDefaultValue=false)]
        public string AuthNextTime { get; private set; }

        /// <summary>
        /// License category  
        /// </summary>
        /// <value>License category  </value>
        [DataMember(Name="Category", EmitDefaultValue=false)]
        public string Category { get; private set; }

        /// <summary>
        /// Gets or Sets CustomerOp
        /// </summary>
        [DataMember(Name="CustomerOp", EmitDefaultValue=false)]
        public LicenseCustomerOpRef CustomerOp { get; set; }

        /// <summary>
        /// Group  
        /// </summary>
        /// <value>Group  </value>
        [DataMember(Name="Group", EmitDefaultValue=false)]
        public string Group { get; private set; }

        /// <summary>
        /// Specifies last sync time with SA  
        /// </summary>
        /// <value>Specifies last sync time with SA  </value>
        [DataMember(Name="LastSync", EmitDefaultValue=false)]
        public DateTime? LastSync { get; private set; }

        /// <summary>
        /// Last updated  
        /// </summary>
        /// <value>Last updated  </value>
        [DataMember(Name="LastUpdatedTime", EmitDefaultValue=false)]
        public DateTime? LastUpdatedTime { get; private set; }

        /// <summary>
        /// Aggregrated mode for the agent  
        /// </summary>
        /// <value>Aggregrated mode for the agent  </value>
        [DataMember(Name="LicenseState", EmitDefaultValue=false)]
        public string LicenseState { get; private set; }

        /// <summary>
        /// Tech-support info for a smart-agent  
        /// </summary>
        /// <value>Tech-support info for a smart-agent  </value>
        [DataMember(Name="LicenseTechSupportInfo", EmitDefaultValue=false)]
        public string LicenseTechSupportInfo { get; private set; }

        /// <summary>
        /// Gets or Sets Licenseinfos
        /// </summary>
        [DataMember(Name="Licenseinfos", EmitDefaultValue=false)]
        public List<LicenseLicenseInfoRef> Licenseinfos { get; set; }

        /// <summary>
        /// Registration exipiration time  
        /// </summary>
        /// <value>Registration exipiration time  </value>
        [DataMember(Name="RegisterExpireTime", EmitDefaultValue=false)]
        public string RegisterExpireTime { get; private set; }

        /// <summary>
        /// Initial time of registration  
        /// </summary>
        /// <value>Initial time of registration  </value>
        [DataMember(Name="RegisterInitialTime", EmitDefaultValue=false)]
        public string RegisterInitialTime { get; private set; }

        /// <summary>
        /// Next time for registration  
        /// </summary>
        /// <value>Next time for registration  </value>
        [DataMember(Name="RegisterNextTime", EmitDefaultValue=false)]
        public string RegisterNextTime { get; private set; }

        /// <summary>
        /// Registration status  
        /// </summary>
        /// <value>Registration status  </value>
        [DataMember(Name="RegistrationStatus", EmitDefaultValue=false)]
        public string RegistrationStatus { get; private set; }

        /// <summary>
        /// Renew failure message  
        /// </summary>
        /// <value>Renew failure message  </value>
        [DataMember(Name="RenewFailureString", EmitDefaultValue=false)]
        public string RenewFailureString { get; private set; }

        /// <summary>
        /// Name of smart account  
        /// </summary>
        /// <value>Name of smart account  </value>
        [DataMember(Name="SmartAccount", EmitDefaultValue=false)]
        public string SmartAccount { get; private set; }

        /// <summary>
        /// Gets or Sets SmartlicenseToken
        /// </summary>
        [DataMember(Name="SmartlicenseToken", EmitDefaultValue=false)]
        public LicenseSmartlicenseTokenRef SmartlicenseToken { get; set; }

        /// <summary>
        /// Current sync status for the account  
        /// </summary>
        /// <value>Current sync status for the account  </value>
        [DataMember(Name="SyncStatus", EmitDefaultValue=false)]
        public string SyncStatus { get; private set; }

        /// <summary>
        /// Name of virtual account   
        /// </summary>
        /// <value>Name of virtual account   </value>
        [DataMember(Name="VirtualAccount", EmitDefaultValue=false)]
        public string VirtualAccount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseAccountLicenseData {\n");
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
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgentData: ").Append(AgentData).Append("\n");
            sb.Append("  AuthExpireTime: ").Append(AuthExpireTime).Append("\n");
            sb.Append("  AuthInitialTime: ").Append(AuthInitialTime).Append("\n");
            sb.Append("  AuthNextTime: ").Append(AuthNextTime).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CustomerOp: ").Append(CustomerOp).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  LastSync: ").Append(LastSync).Append("\n");
            sb.Append("  LastUpdatedTime: ").Append(LastUpdatedTime).Append("\n");
            sb.Append("  LicenseState: ").Append(LicenseState).Append("\n");
            sb.Append("  LicenseTechSupportInfo: ").Append(LicenseTechSupportInfo).Append("\n");
            sb.Append("  Licenseinfos: ").Append(Licenseinfos).Append("\n");
            sb.Append("  RegisterExpireTime: ").Append(RegisterExpireTime).Append("\n");
            sb.Append("  RegisterInitialTime: ").Append(RegisterInitialTime).Append("\n");
            sb.Append("  RegisterNextTime: ").Append(RegisterNextTime).Append("\n");
            sb.Append("  RegistrationStatus: ").Append(RegistrationStatus).Append("\n");
            sb.Append("  RenewFailureString: ").Append(RenewFailureString).Append("\n");
            sb.Append("  SmartAccount: ").Append(SmartAccount).Append("\n");
            sb.Append("  SmartlicenseToken: ").Append(SmartlicenseToken).Append("\n");
            sb.Append("  SyncStatus: ").Append(SyncStatus).Append("\n");
            sb.Append("  VirtualAccount: ").Append(VirtualAccount).Append("\n");
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
            return this.Equals(obj as LicenseAccountLicenseData);
        }

        /// <summary>
        /// Returns true if LicenseAccountLicenseData instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseAccountLicenseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseAccountLicenseData other)
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
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.AgentData == other.AgentData ||
                    this.AgentData != null &&
                    this.AgentData.Equals(other.AgentData)
                ) && 
                (
                    this.AuthExpireTime == other.AuthExpireTime ||
                    this.AuthExpireTime != null &&
                    this.AuthExpireTime.Equals(other.AuthExpireTime)
                ) && 
                (
                    this.AuthInitialTime == other.AuthInitialTime ||
                    this.AuthInitialTime != null &&
                    this.AuthInitialTime.Equals(other.AuthInitialTime)
                ) && 
                (
                    this.AuthNextTime == other.AuthNextTime ||
                    this.AuthNextTime != null &&
                    this.AuthNextTime.Equals(other.AuthNextTime)
                ) && 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.CustomerOp == other.CustomerOp ||
                    this.CustomerOp != null &&
                    this.CustomerOp.Equals(other.CustomerOp)
                ) && 
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.Equals(other.Group)
                ) && 
                (
                    this.LastSync == other.LastSync ||
                    this.LastSync != null &&
                    this.LastSync.Equals(other.LastSync)
                ) && 
                (
                    this.LastUpdatedTime == other.LastUpdatedTime ||
                    this.LastUpdatedTime != null &&
                    this.LastUpdatedTime.Equals(other.LastUpdatedTime)
                ) && 
                (
                    this.LicenseState == other.LicenseState ||
                    this.LicenseState != null &&
                    this.LicenseState.Equals(other.LicenseState)
                ) && 
                (
                    this.LicenseTechSupportInfo == other.LicenseTechSupportInfo ||
                    this.LicenseTechSupportInfo != null &&
                    this.LicenseTechSupportInfo.Equals(other.LicenseTechSupportInfo)
                ) && 
                (
                    this.Licenseinfos == other.Licenseinfos ||
                    this.Licenseinfos != null &&
                    this.Licenseinfos.SequenceEqual(other.Licenseinfos)
                ) && 
                (
                    this.RegisterExpireTime == other.RegisterExpireTime ||
                    this.RegisterExpireTime != null &&
                    this.RegisterExpireTime.Equals(other.RegisterExpireTime)
                ) && 
                (
                    this.RegisterInitialTime == other.RegisterInitialTime ||
                    this.RegisterInitialTime != null &&
                    this.RegisterInitialTime.Equals(other.RegisterInitialTime)
                ) && 
                (
                    this.RegisterNextTime == other.RegisterNextTime ||
                    this.RegisterNextTime != null &&
                    this.RegisterNextTime.Equals(other.RegisterNextTime)
                ) && 
                (
                    this.RegistrationStatus == other.RegistrationStatus ||
                    this.RegistrationStatus != null &&
                    this.RegistrationStatus.Equals(other.RegistrationStatus)
                ) && 
                (
                    this.RenewFailureString == other.RenewFailureString ||
                    this.RenewFailureString != null &&
                    this.RenewFailureString.Equals(other.RenewFailureString)
                ) && 
                (
                    this.SmartAccount == other.SmartAccount ||
                    this.SmartAccount != null &&
                    this.SmartAccount.Equals(other.SmartAccount)
                ) && 
                (
                    this.SmartlicenseToken == other.SmartlicenseToken ||
                    this.SmartlicenseToken != null &&
                    this.SmartlicenseToken.Equals(other.SmartlicenseToken)
                ) && 
                (
                    this.SyncStatus == other.SyncStatus ||
                    this.SyncStatus != null &&
                    this.SyncStatus.Equals(other.SyncStatus)
                ) && 
                (
                    this.VirtualAccount == other.VirtualAccount ||
                    this.VirtualAccount != null &&
                    this.VirtualAccount.Equals(other.VirtualAccount)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.AgentData != null)
                    hash = hash * 59 + this.AgentData.GetHashCode();
                if (this.AuthExpireTime != null)
                    hash = hash * 59 + this.AuthExpireTime.GetHashCode();
                if (this.AuthInitialTime != null)
                    hash = hash * 59 + this.AuthInitialTime.GetHashCode();
                if (this.AuthNextTime != null)
                    hash = hash * 59 + this.AuthNextTime.GetHashCode();
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.CustomerOp != null)
                    hash = hash * 59 + this.CustomerOp.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.LastSync != null)
                    hash = hash * 59 + this.LastSync.GetHashCode();
                if (this.LastUpdatedTime != null)
                    hash = hash * 59 + this.LastUpdatedTime.GetHashCode();
                if (this.LicenseState != null)
                    hash = hash * 59 + this.LicenseState.GetHashCode();
                if (this.LicenseTechSupportInfo != null)
                    hash = hash * 59 + this.LicenseTechSupportInfo.GetHashCode();
                if (this.Licenseinfos != null)
                    hash = hash * 59 + this.Licenseinfos.GetHashCode();
                if (this.RegisterExpireTime != null)
                    hash = hash * 59 + this.RegisterExpireTime.GetHashCode();
                if (this.RegisterInitialTime != null)
                    hash = hash * 59 + this.RegisterInitialTime.GetHashCode();
                if (this.RegisterNextTime != null)
                    hash = hash * 59 + this.RegisterNextTime.GetHashCode();
                if (this.RegistrationStatus != null)
                    hash = hash * 59 + this.RegistrationStatus.GetHashCode();
                if (this.RenewFailureString != null)
                    hash = hash * 59 + this.RenewFailureString.GetHashCode();
                if (this.SmartAccount != null)
                    hash = hash * 59 + this.SmartAccount.GetHashCode();
                if (this.SmartlicenseToken != null)
                    hash = hash * 59 + this.SmartlicenseToken.GetHashCode();
                if (this.SyncStatus != null)
                    hash = hash * 59 + this.SyncStatus.GetHashCode();
                if (this.VirtualAccount != null)
                    hash = hash * 59 + this.VirtualAccount.GetHashCode();
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
