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
    /// Customer operation object to refresh the registration or re-authenticate, pre-created 
    /// </summary>
    [DataContract]
    public partial class LicenseCustomerOp :  IEquatable<LicenseCustomerOp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseCustomerOp" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="AccountLicenseData">AccountLicenseData.</param>
        /// <param name="DeregisterDevice">Trigger de-registration/disable  .</param>
        /// <param name="RenewAuthorization">Trigger renew authorization  .</param>
        /// <param name="RenewIdCertificate">Trigger renew registration  .</param>
        /// <param name="ShowAgentTechSupport">Trigger show tech support   .</param>
        public LicenseCustomerOp(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), LicenseAccountLicenseDataRef AccountLicenseData = default(LicenseAccountLicenseDataRef), bool? DeregisterDevice = default(bool?), bool? RenewAuthorization = default(bool?), bool? RenewIdCertificate = default(bool?), bool? ShowAgentTechSupport = default(bool?))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.AccountLicenseData = AccountLicenseData;
            this.DeregisterDevice = DeregisterDevice;
            this.RenewAuthorization = RenewAuthorization;
            this.RenewIdCertificate = RenewIdCertificate;
            this.ShowAgentTechSupport = ShowAgentTechSupport;
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
        /// Gets or Sets AccountLicenseData
        /// </summary>
        [DataMember(Name="AccountLicenseData", EmitDefaultValue=false)]
        public LicenseAccountLicenseDataRef AccountLicenseData { get; set; }

        /// <summary>
        /// Trigger de-registration/disable  
        /// </summary>
        /// <value>Trigger de-registration/disable  </value>
        [DataMember(Name="DeregisterDevice", EmitDefaultValue=false)]
        public bool? DeregisterDevice { get; set; }

        /// <summary>
        /// Trigger renew authorization  
        /// </summary>
        /// <value>Trigger renew authorization  </value>
        [DataMember(Name="RenewAuthorization", EmitDefaultValue=false)]
        public bool? RenewAuthorization { get; set; }

        /// <summary>
        /// Trigger renew registration  
        /// </summary>
        /// <value>Trigger renew registration  </value>
        [DataMember(Name="RenewIdCertificate", EmitDefaultValue=false)]
        public bool? RenewIdCertificate { get; set; }

        /// <summary>
        /// Trigger show tech support   
        /// </summary>
        /// <value>Trigger show tech support   </value>
        [DataMember(Name="ShowAgentTechSupport", EmitDefaultValue=false)]
        public bool? ShowAgentTechSupport { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseCustomerOp {\n");
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
            sb.Append("  AccountLicenseData: ").Append(AccountLicenseData).Append("\n");
            sb.Append("  DeregisterDevice: ").Append(DeregisterDevice).Append("\n");
            sb.Append("  RenewAuthorization: ").Append(RenewAuthorization).Append("\n");
            sb.Append("  RenewIdCertificate: ").Append(RenewIdCertificate).Append("\n");
            sb.Append("  ShowAgentTechSupport: ").Append(ShowAgentTechSupport).Append("\n");
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
            return this.Equals(obj as LicenseCustomerOp);
        }

        /// <summary>
        /// Returns true if LicenseCustomerOp instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseCustomerOp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseCustomerOp other)
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
                    this.AccountLicenseData == other.AccountLicenseData ||
                    this.AccountLicenseData != null &&
                    this.AccountLicenseData.Equals(other.AccountLicenseData)
                ) && 
                (
                    this.DeregisterDevice == other.DeregisterDevice ||
                    this.DeregisterDevice != null &&
                    this.DeregisterDevice.Equals(other.DeregisterDevice)
                ) && 
                (
                    this.RenewAuthorization == other.RenewAuthorization ||
                    this.RenewAuthorization != null &&
                    this.RenewAuthorization.Equals(other.RenewAuthorization)
                ) && 
                (
                    this.RenewIdCertificate == other.RenewIdCertificate ||
                    this.RenewIdCertificate != null &&
                    this.RenewIdCertificate.Equals(other.RenewIdCertificate)
                ) && 
                (
                    this.ShowAgentTechSupport == other.ShowAgentTechSupport ||
                    this.ShowAgentTechSupport != null &&
                    this.ShowAgentTechSupport.Equals(other.ShowAgentTechSupport)
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
                if (this.AccountLicenseData != null)
                    hash = hash * 59 + this.AccountLicenseData.GetHashCode();
                if (this.DeregisterDevice != null)
                    hash = hash * 59 + this.DeregisterDevice.GetHashCode();
                if (this.RenewAuthorization != null)
                    hash = hash * 59 + this.RenewAuthorization.GetHashCode();
                if (this.RenewIdCertificate != null)
                    hash = hash * 59 + this.RenewIdCertificate.GetHashCode();
                if (this.ShowAgentTechSupport != null)
                    hash = hash * 59 + this.ShowAgentTechSupport.GetHashCode();
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
