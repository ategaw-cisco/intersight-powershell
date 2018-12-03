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
    /// Describes about license info currently available in UCSD 
    /// </summary>
    [DataContract]
    public partial class IaasLicenseInfo :  IEquatable<IaasLicenseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IaasLicenseInfo" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Guid">Guid.</param>
        /// <param name="LicenseKeysInfo">License keys info for UCSD  .</param>
        /// <param name="LicenseUtilizationInfo">List of license utilization info for UCSD   .</param>
        public IaasLicenseInfo(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), IaasUcsdInfoRef Guid = default(IaasUcsdInfoRef), List<IaasLicenseKeysInfo> LicenseKeysInfo = default(List<IaasLicenseKeysInfo>), List<IaasLicenseUtilizationInfo> LicenseUtilizationInfo = default(List<IaasLicenseUtilizationInfo>))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Guid = Guid;
            this.LicenseKeysInfo = LicenseKeysInfo;
            this.LicenseUtilizationInfo = LicenseUtilizationInfo;
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
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name="Guid", EmitDefaultValue=false)]
        public IaasUcsdInfoRef Guid { get; set; }

        /// <summary>
        /// Licese expiration date  
        /// </summary>
        /// <value>Licese expiration date  </value>
        [DataMember(Name="LicenseExpirationDate", EmitDefaultValue=false)]
        public string LicenseExpirationDate { get; private set; }

        /// <summary>
        /// License keys info for UCSD  
        /// </summary>
        /// <value>License keys info for UCSD  </value>
        [DataMember(Name="LicenseKeysInfo", EmitDefaultValue=false)]
        public List<IaasLicenseKeysInfo> LicenseKeysInfo { get; set; }

        /// <summary>
        /// License type of UCSD whether it is EVAL/Permanent/Subscription.  
        /// </summary>
        /// <value>License type of UCSD whether it is EVAL/Permanent/Subscription.  </value>
        [DataMember(Name="LicenseType", EmitDefaultValue=false)]
        public string LicenseType { get; private set; }

        /// <summary>
        /// List of license utilization info for UCSD   
        /// </summary>
        /// <value>List of license utilization info for UCSD   </value>
        [DataMember(Name="LicenseUtilizationInfo", EmitDefaultValue=false)]
        public List<IaasLicenseUtilizationInfo> LicenseUtilizationInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IaasLicenseInfo {\n");
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
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  LicenseExpirationDate: ").Append(LicenseExpirationDate).Append("\n");
            sb.Append("  LicenseKeysInfo: ").Append(LicenseKeysInfo).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  LicenseUtilizationInfo: ").Append(LicenseUtilizationInfo).Append("\n");
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
            return this.Equals(obj as IaasLicenseInfo);
        }

        /// <summary>
        /// Returns true if IaasLicenseInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of IaasLicenseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IaasLicenseInfo other)
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
                    this.Guid == other.Guid ||
                    this.Guid != null &&
                    this.Guid.Equals(other.Guid)
                ) && 
                (
                    this.LicenseExpirationDate == other.LicenseExpirationDate ||
                    this.LicenseExpirationDate != null &&
                    this.LicenseExpirationDate.Equals(other.LicenseExpirationDate)
                ) && 
                (
                    this.LicenseKeysInfo == other.LicenseKeysInfo ||
                    this.LicenseKeysInfo != null &&
                    this.LicenseKeysInfo.SequenceEqual(other.LicenseKeysInfo)
                ) && 
                (
                    this.LicenseType == other.LicenseType ||
                    this.LicenseType != null &&
                    this.LicenseType.Equals(other.LicenseType)
                ) && 
                (
                    this.LicenseUtilizationInfo == other.LicenseUtilizationInfo ||
                    this.LicenseUtilizationInfo != null &&
                    this.LicenseUtilizationInfo.SequenceEqual(other.LicenseUtilizationInfo)
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
                if (this.Guid != null)
                    hash = hash * 59 + this.Guid.GetHashCode();
                if (this.LicenseExpirationDate != null)
                    hash = hash * 59 + this.LicenseExpirationDate.GetHashCode();
                if (this.LicenseKeysInfo != null)
                    hash = hash * 59 + this.LicenseKeysInfo.GetHashCode();
                if (this.LicenseType != null)
                    hash = hash * 59 + this.LicenseType.GetHashCode();
                if (this.LicenseUtilizationInfo != null)
                    hash = hash * 59 + this.LicenseUtilizationInfo.GetHashCode();
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
