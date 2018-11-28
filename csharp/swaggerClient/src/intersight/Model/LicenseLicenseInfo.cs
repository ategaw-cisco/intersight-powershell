/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-264
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
    /// License state information for a specific license entitlement. Essentials license entitlement is supported currently. licenseState attribute is used for license enforcement. When license state is one of TrialPeriod, Compliance, or OutOfCompliance, the feature set defined for the license entitlement is granted to the customer. 
    /// </summary>
    [DataContract]
    public partial class LicenseLicenseInfo :  IEquatable<LicenseLicenseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseLicenseInfo" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="AccountLicenseData">AccountLicenseData.</param>
        /// <param name="ActiveAdmin">the customer needs to set this attribute to activate license entitlement  .</param>
        /// <param name="EvaluationPeriod">Default Trial or Grace period customer is entitled to.  .</param>
        /// <param name="ExtraEvaluation">one time extend Trial or Grace period customer is entitled to.  .</param>
        /// <param name="TrialAdmin">when LicenseState is in NotLicensed, the customer can set trialAdmin to be true to start the trial period, i.e. licenseState is set to be TrialPeriod   .</param>
        public LicenseLicenseInfo(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), LicenseAccountLicenseDataRef AccountLicenseData = default(LicenseAccountLicenseDataRef), bool? ActiveAdmin = default(bool?), long? EvaluationPeriod = default(long?), long? ExtraEvaluation = default(long?), bool? TrialAdmin = default(bool?))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.AccountLicenseData = AccountLicenseData;
            this.ActiveAdmin = ActiveAdmin;
            this.EvaluationPeriod = EvaluationPeriod;
            this.ExtraEvaluation = ExtraEvaluation;
            this.TrialAdmin = TrialAdmin;
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
        /// the customer needs to set this attribute to activate license entitlement  
        /// </summary>
        /// <value>the customer needs to set this attribute to activate license entitlement  </value>
        [DataMember(Name="ActiveAdmin", EmitDefaultValue=false)]
        public bool? ActiveAdmin { get; set; }

        /// <summary>
        /// this attribute indicates the number of days left for licenseState to stay in TrialPeriod or OutOfCompliance state.  
        /// </summary>
        /// <value>this attribute indicates the number of days left for licenseState to stay in TrialPeriod or OutOfCompliance state.  </value>
        [DataMember(Name="DaysLeft", EmitDefaultValue=false)]
        public long? DaysLeft { get; private set; }

        /// <summary>
        /// when startTime is set, the system updates endTime to reflect when licenseState is going to move out of TrialPeriod or OutOfCompliance.  
        /// </summary>
        /// <value>when startTime is set, the system updates endTime to reflect when licenseState is going to move out of TrialPeriod or OutOfCompliance.  </value>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// the entitlement mode reported by Cisco Smart Software Manager.  
        /// </summary>
        /// <value>the entitlement mode reported by Cisco Smart Software Manager.  </value>
        [DataMember(Name="EnforceMode", EmitDefaultValue=false)]
        public string EnforceMode { get; private set; }

        /// <summary>
        /// it provides the detailed error message when there is any error related to this entitlement  
        /// </summary>
        /// <value>it provides the detailed error message when there is any error related to this entitlement  </value>
        [DataMember(Name="ErrorDesc", EmitDefaultValue=false)]
        public string ErrorDesc { get; private set; }

        /// <summary>
        /// Default Trial or Grace period customer is entitled to.  
        /// </summary>
        /// <value>Default Trial or Grace period customer is entitled to.  </value>
        [DataMember(Name="EvaluationPeriod", EmitDefaultValue=false)]
        public long? EvaluationPeriod { get; set; }

        /// <summary>
        /// one time extend Trial or Grace period customer is entitled to.  
        /// </summary>
        /// <value>one time extend Trial or Grace period customer is entitled to.  </value>
        [DataMember(Name="ExtraEvaluation", EmitDefaultValue=false)]
        public long? ExtraEvaluation { get; set; }

        /// <summary>
        /// the total number of servers claimed by the account  
        /// </summary>
        /// <value>the total number of servers claimed by the account  </value>
        [DataMember(Name="LicenseCount", EmitDefaultValue=false)]
        public long? LicenseCount { get; private set; }

        /// <summary>
        /// the license state defined by Starship. Can be one of NotLicensed, TrialPeriod, OutOfCompliance, Compliance,GraceExpired,TrialExpired.  
        /// </summary>
        /// <value>the license state defined by Starship. Can be one of NotLicensed, TrialPeriod, OutOfCompliance, Compliance,GraceExpired,TrialExpired.  </value>
        [DataMember(Name="LicenseState", EmitDefaultValue=false)]
        public string LicenseState { get; private set; }

        /// <summary>
        /// Starship license entitlement name. It is set to be Essentials.  
        /// </summary>
        /// <value>Starship license entitlement name. It is set to be Essentials.  </value>
        [DataMember(Name="LicenseType", EmitDefaultValue=false)]
        public string LicenseType { get; private set; }

        /// <summary>
        /// when licenseState enters TrialPeriod or OutOfCompliance, startTime is set to current system time.  
        /// </summary>
        /// <value>when licenseState enters TrialPeriod or OutOfCompliance, startTime is set to current system time.  </value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// when LicenseState is in NotLicensed, the customer can set trialAdmin to be true to start the trial period, i.e. licenseState is set to be TrialPeriod   
        /// </summary>
        /// <value>when LicenseState is in NotLicensed, the customer can set trialAdmin to be true to start the trial period, i.e. licenseState is set to be TrialPeriod   </value>
        [DataMember(Name="TrialAdmin", EmitDefaultValue=false)]
        public bool? TrialAdmin { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LicenseLicenseInfo {\n");
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
            sb.Append("  ActiveAdmin: ").Append(ActiveAdmin).Append("\n");
            sb.Append("  DaysLeft: ").Append(DaysLeft).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  EnforceMode: ").Append(EnforceMode).Append("\n");
            sb.Append("  ErrorDesc: ").Append(ErrorDesc).Append("\n");
            sb.Append("  EvaluationPeriod: ").Append(EvaluationPeriod).Append("\n");
            sb.Append("  ExtraEvaluation: ").Append(ExtraEvaluation).Append("\n");
            sb.Append("  LicenseCount: ").Append(LicenseCount).Append("\n");
            sb.Append("  LicenseState: ").Append(LicenseState).Append("\n");
            sb.Append("  LicenseType: ").Append(LicenseType).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TrialAdmin: ").Append(TrialAdmin).Append("\n");
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
            return this.Equals(obj as LicenseLicenseInfo);
        }

        /// <summary>
        /// Returns true if LicenseLicenseInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of LicenseLicenseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LicenseLicenseInfo other)
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
                    this.ActiveAdmin == other.ActiveAdmin ||
                    this.ActiveAdmin != null &&
                    this.ActiveAdmin.Equals(other.ActiveAdmin)
                ) && 
                (
                    this.DaysLeft == other.DaysLeft ||
                    this.DaysLeft != null &&
                    this.DaysLeft.Equals(other.DaysLeft)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.EnforceMode == other.EnforceMode ||
                    this.EnforceMode != null &&
                    this.EnforceMode.Equals(other.EnforceMode)
                ) && 
                (
                    this.ErrorDesc == other.ErrorDesc ||
                    this.ErrorDesc != null &&
                    this.ErrorDesc.Equals(other.ErrorDesc)
                ) && 
                (
                    this.EvaluationPeriod == other.EvaluationPeriod ||
                    this.EvaluationPeriod != null &&
                    this.EvaluationPeriod.Equals(other.EvaluationPeriod)
                ) && 
                (
                    this.ExtraEvaluation == other.ExtraEvaluation ||
                    this.ExtraEvaluation != null &&
                    this.ExtraEvaluation.Equals(other.ExtraEvaluation)
                ) && 
                (
                    this.LicenseCount == other.LicenseCount ||
                    this.LicenseCount != null &&
                    this.LicenseCount.Equals(other.LicenseCount)
                ) && 
                (
                    this.LicenseState == other.LicenseState ||
                    this.LicenseState != null &&
                    this.LicenseState.Equals(other.LicenseState)
                ) && 
                (
                    this.LicenseType == other.LicenseType ||
                    this.LicenseType != null &&
                    this.LicenseType.Equals(other.LicenseType)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.TrialAdmin == other.TrialAdmin ||
                    this.TrialAdmin != null &&
                    this.TrialAdmin.Equals(other.TrialAdmin)
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
                if (this.ActiveAdmin != null)
                    hash = hash * 59 + this.ActiveAdmin.GetHashCode();
                if (this.DaysLeft != null)
                    hash = hash * 59 + this.DaysLeft.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.EnforceMode != null)
                    hash = hash * 59 + this.EnforceMode.GetHashCode();
                if (this.ErrorDesc != null)
                    hash = hash * 59 + this.ErrorDesc.GetHashCode();
                if (this.EvaluationPeriod != null)
                    hash = hash * 59 + this.EvaluationPeriod.GetHashCode();
                if (this.ExtraEvaluation != null)
                    hash = hash * 59 + this.ExtraEvaluation.GetHashCode();
                if (this.LicenseCount != null)
                    hash = hash * 59 + this.LicenseCount.GetHashCode();
                if (this.LicenseState != null)
                    hash = hash * 59 + this.LicenseState.GetHashCode();
                if (this.LicenseType != null)
                    hash = hash * 59 + this.LicenseType.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.TrialAdmin != null)
                    hash = hash * 59 + this.TrialAdmin.GetHashCode();
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
