/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-221
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
    /// FirmwareUpgradeStatus
    /// </summary>
    [DataContract]
    public partial class FirmwareUpgradeStatus :  IEquatable<FirmwareUpgradeStatus>, IValidatableObject
    {
        /// <summary>
        /// Provides the server power status at the end of upgrade  
        /// </summary>
        /// <value>Provides the server power status at the end of upgrade  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EpPowerStatusEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Poweredon for "powered on"
            /// </summary>
            [EnumMember(Value = "powered on")]
            Poweredon,
            
            /// <summary>
            /// Enum Poweredoff for "powered off"
            /// </summary>
            [EnumMember(Value = "powered off")]
            Poweredoff
        }

        /// <summary>
        /// Provides the overall status, e.g., downloading, upgrading, successful, failure and pending-for-reboot  
        /// </summary>
        /// <value>Provides the overall status, e.g., downloading, upgrading, successful, failure and pending-for-reboot  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OverallstatusEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Started for "started"
            /// </summary>
            [EnumMember(Value = "started")]
            Started,
            
            /// <summary>
            /// Enum Downloadinitiating for "download initiating"
            /// </summary>
            [EnumMember(Value = "download initiating")]
            Downloadinitiating,
            
            /// <summary>
            /// Enum Downloadinitiated for "download initiated"
            /// </summary>
            [EnumMember(Value = "download initiated")]
            Downloadinitiated,
            
            /// <summary>
            /// Enum Downloading for "downloading"
            /// </summary>
            [EnumMember(Value = "downloading")]
            Downloading,
            
            /// <summary>
            /// Enum Downloaded for "downloaded"
            /// </summary>
            [EnumMember(Value = "downloaded")]
            Downloaded,
            
            /// <summary>
            /// Enum Upgradeinitiating for "upgrade initiating"
            /// </summary>
            [EnumMember(Value = "upgrade initiating")]
            Upgradeinitiating,
            
            /// <summary>
            /// Enum Upgradeinitiated for "upgrade initiated"
            /// </summary>
            [EnumMember(Value = "upgrade initiated")]
            Upgradeinitiated,
            
            /// <summary>
            /// Enum Upgrading for "upgrading"
            /// </summary>
            [EnumMember(Value = "upgrading")]
            Upgrading,
            
            /// <summary>
            /// Enum Upgraded for "upgraded"
            /// </summary>
            [EnumMember(Value = "upgraded")]
            Upgraded,
            
            /// <summary>
            /// Enum Success for "success"
            /// </summary>
            [EnumMember(Value = "success")]
            Success,
            
            /// <summary>
            /// Enum Failed for "failed"
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed,
            
            /// <summary>
            /// Enum Pending for "pending"
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending
        }

        /// <summary>
        /// Provides the current pending upgrade status for the on-next boot based upgrades   
        /// </summary>
        /// <value>Provides the current pending upgrade status for the on-next boot based upgrades   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PendingTypeEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Pendingfornextreboot for "pending for next reboot"
            /// </summary>
            [EnumMember(Value = "pending for next reboot")]
            Pendingfornextreboot
        }

        /// <summary>
        /// Provides the server power status at the end of upgrade  
        /// </summary>
        /// <value>Provides the server power status at the end of upgrade  </value>
        [DataMember(Name="EpPowerStatus", EmitDefaultValue=false)]
        public EpPowerStatusEnum? EpPowerStatus { get; set; }
        /// <summary>
        /// Provides the overall status, e.g., downloading, upgrading, successful, failure and pending-for-reboot  
        /// </summary>
        /// <value>Provides the overall status, e.g., downloading, upgrading, successful, failure and pending-for-reboot  </value>
        [DataMember(Name="Overallstatus", EmitDefaultValue=false)]
        public OverallstatusEnum? Overallstatus { get; set; }
        /// <summary>
        /// Provides the current pending upgrade status for the on-next boot based upgrades   
        /// </summary>
        /// <value>Provides the current pending upgrade status for the on-next boot based upgrades   </value>
        [DataMember(Name="PendingType", EmitDefaultValue=false)]
        public PendingTypeEnum? PendingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareUpgradeStatus" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="DownloadError">Provides the download failure message  .</param>
        /// <param name="DownloadPercentage">Provides the image downloaded percentage from image source  .</param>
        /// <param name="DownloadStage">Provides the latest download phase like downloading, flashing, downloaded  .</param>
        /// <param name="DownloadStatus">Provides the download status like downloading, downloaded or failed  .</param>
        /// <param name="EpPowerStatus">Provides the server power status at the end of upgrade   (default to EpPowerStatusEnum.None).</param>
        /// <param name="OverallError">Provides the failure message when download or upgrade fails  .</param>
        /// <param name="OverallPercentage">Provides the overall percentage of the upgrade inclusive of download  .</param>
        /// <param name="Overallstatus">Provides the overall status, e.g., downloading, upgrading, successful, failure and pending-for-reboot   (default to OverallstatusEnum.None).</param>
        /// <param name="PendingType">Provides the current pending upgrade status for the on-next boot based upgrades    (default to PendingTypeEnum.None).</param>
        /// <param name="Upgrade">Upgrade.</param>
        public FirmwareUpgradeStatus(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), string DownloadError = default(string), long? DownloadPercentage = default(long?), string DownloadStage = default(string), string DownloadStatus = default(string), EpPowerStatusEnum? EpPowerStatus = EpPowerStatusEnum.None, string OverallError = default(string), long? OverallPercentage = default(long?), OverallstatusEnum? Overallstatus = OverallstatusEnum.None, PendingTypeEnum? PendingType = PendingTypeEnum.None, FirmwareUpgradeRef Upgrade = default(FirmwareUpgradeRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.DownloadError = DownloadError;
            this.DownloadPercentage = DownloadPercentage;
            this.DownloadStage = DownloadStage;
            this.DownloadStatus = DownloadStatus;
            // use default value if no "EpPowerStatus" provided
            if (EpPowerStatus == null)
            {
                this.EpPowerStatus = EpPowerStatusEnum.None;
            }
            else
            {
                this.EpPowerStatus = EpPowerStatus;
            }
            this.OverallError = OverallError;
            this.OverallPercentage = OverallPercentage;
            // use default value if no "Overallstatus" provided
            if (Overallstatus == null)
            {
                this.Overallstatus = OverallstatusEnum.None;
            }
            else
            {
                this.Overallstatus = Overallstatus;
            }
            // use default value if no "PendingType" provided
            if (PendingType == null)
            {
                this.PendingType = PendingTypeEnum.None;
            }
            else
            {
                this.PendingType = PendingType;
            }
            this.Upgrade = Upgrade;
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
        /// <value>An array of tags, which allow to add key, value meta-data to managed objects.   </value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<MoTag> Tags { get; set; }

        /// <summary>
        /// Provides the download failure message  
        /// </summary>
        /// <value>Provides the download failure message  </value>
        [DataMember(Name="DownloadError", EmitDefaultValue=false)]
        public string DownloadError { get; set; }

        /// <summary>
        /// Provides the image downloaded percentage from image source  
        /// </summary>
        /// <value>Provides the image downloaded percentage from image source  </value>
        [DataMember(Name="DownloadPercentage", EmitDefaultValue=false)]
        public long? DownloadPercentage { get; set; }

        /// <summary>
        /// Provides the latest download phase like downloading, flashing, downloaded  
        /// </summary>
        /// <value>Provides the latest download phase like downloading, flashing, downloaded  </value>
        [DataMember(Name="DownloadStage", EmitDefaultValue=false)]
        public string DownloadStage { get; set; }

        /// <summary>
        /// Provides the download status like downloading, downloaded or failed  
        /// </summary>
        /// <value>Provides the download status like downloading, downloaded or failed  </value>
        [DataMember(Name="DownloadStatus", EmitDefaultValue=false)]
        public string DownloadStatus { get; set; }


        /// <summary>
        /// Provides the failure message when download or upgrade fails  
        /// </summary>
        /// <value>Provides the failure message when download or upgrade fails  </value>
        [DataMember(Name="OverallError", EmitDefaultValue=false)]
        public string OverallError { get; set; }

        /// <summary>
        /// Provides the overall percentage of the upgrade inclusive of download  
        /// </summary>
        /// <value>Provides the overall percentage of the upgrade inclusive of download  </value>
        [DataMember(Name="OverallPercentage", EmitDefaultValue=false)]
        public long? OverallPercentage { get; set; }



        /// <summary>
        /// Gets or Sets Upgrade
        /// </summary>
        [DataMember(Name="Upgrade", EmitDefaultValue=false)]
        public FirmwareUpgradeRef Upgrade { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareUpgradeStatus {\n");
            sb.Append("  AccountMoid: ").Append(AccountMoid).Append("\n");
            sb.Append("  Ancestors: ").Append(Ancestors).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ModTime: ").Append(ModTime).Append("\n");
            sb.Append("  Moid: ").Append(Moid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DownloadError: ").Append(DownloadError).Append("\n");
            sb.Append("  DownloadPercentage: ").Append(DownloadPercentage).Append("\n");
            sb.Append("  DownloadStage: ").Append(DownloadStage).Append("\n");
            sb.Append("  DownloadStatus: ").Append(DownloadStatus).Append("\n");
            sb.Append("  EpPowerStatus: ").Append(EpPowerStatus).Append("\n");
            sb.Append("  OverallError: ").Append(OverallError).Append("\n");
            sb.Append("  OverallPercentage: ").Append(OverallPercentage).Append("\n");
            sb.Append("  Overallstatus: ").Append(Overallstatus).Append("\n");
            sb.Append("  PendingType: ").Append(PendingType).Append("\n");
            sb.Append("  Upgrade: ").Append(Upgrade).Append("\n");
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
            return this.Equals(obj as FirmwareUpgradeStatus);
        }

        /// <summary>
        /// Returns true if FirmwareUpgradeStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareUpgradeStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareUpgradeStatus other)
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
                    this.DownloadError == other.DownloadError ||
                    this.DownloadError != null &&
                    this.DownloadError.Equals(other.DownloadError)
                ) && 
                (
                    this.DownloadPercentage == other.DownloadPercentage ||
                    this.DownloadPercentage != null &&
                    this.DownloadPercentage.Equals(other.DownloadPercentage)
                ) && 
                (
                    this.DownloadStage == other.DownloadStage ||
                    this.DownloadStage != null &&
                    this.DownloadStage.Equals(other.DownloadStage)
                ) && 
                (
                    this.DownloadStatus == other.DownloadStatus ||
                    this.DownloadStatus != null &&
                    this.DownloadStatus.Equals(other.DownloadStatus)
                ) && 
                (
                    this.EpPowerStatus == other.EpPowerStatus ||
                    this.EpPowerStatus != null &&
                    this.EpPowerStatus.Equals(other.EpPowerStatus)
                ) && 
                (
                    this.OverallError == other.OverallError ||
                    this.OverallError != null &&
                    this.OverallError.Equals(other.OverallError)
                ) && 
                (
                    this.OverallPercentage == other.OverallPercentage ||
                    this.OverallPercentage != null &&
                    this.OverallPercentage.Equals(other.OverallPercentage)
                ) && 
                (
                    this.Overallstatus == other.Overallstatus ||
                    this.Overallstatus != null &&
                    this.Overallstatus.Equals(other.Overallstatus)
                ) && 
                (
                    this.PendingType == other.PendingType ||
                    this.PendingType != null &&
                    this.PendingType.Equals(other.PendingType)
                ) && 
                (
                    this.Upgrade == other.Upgrade ||
                    this.Upgrade != null &&
                    this.Upgrade.Equals(other.Upgrade)
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
                if (this.DownloadError != null)
                    hash = hash * 59 + this.DownloadError.GetHashCode();
                if (this.DownloadPercentage != null)
                    hash = hash * 59 + this.DownloadPercentage.GetHashCode();
                if (this.DownloadStage != null)
                    hash = hash * 59 + this.DownloadStage.GetHashCode();
                if (this.DownloadStatus != null)
                    hash = hash * 59 + this.DownloadStatus.GetHashCode();
                if (this.EpPowerStatus != null)
                    hash = hash * 59 + this.EpPowerStatus.GetHashCode();
                if (this.OverallError != null)
                    hash = hash * 59 + this.OverallError.GetHashCode();
                if (this.OverallPercentage != null)
                    hash = hash * 59 + this.OverallPercentage.GetHashCode();
                if (this.Overallstatus != null)
                    hash = hash * 59 + this.Overallstatus.GetHashCode();
                if (this.PendingType != null)
                    hash = hash * 59 + this.PendingType.GetHashCode();
                if (this.Upgrade != null)
                    hash = hash * 59 + this.Upgrade.GetHashCode();
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
