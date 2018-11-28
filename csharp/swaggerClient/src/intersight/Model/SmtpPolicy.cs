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
    /// Name of the SMTP Policy 
    /// </summary>
    [DataContract]
    public partial class SmtpPolicy :  IEquatable<SmtpPolicy>, IValidatableObject
    {
        /// <summary>
        /// Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.  
        /// </summary>
        /// <value>Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MinSeverityEnum
        {
            
            /// <summary>
            /// Enum Critical for "critical"
            /// </summary>
            [EnumMember(Value = "critical")]
            Critical,
            
            /// <summary>
            /// Enum Condition for "condition"
            /// </summary>
            [EnumMember(Value = "condition")]
            Condition,
            
            /// <summary>
            /// Enum Warning for "warning"
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning,
            
            /// <summary>
            /// Enum Minor for "minor"
            /// </summary>
            [EnumMember(Value = "minor")]
            Minor,
            
            /// <summary>
            /// Enum Major for "major"
            /// </summary>
            [EnumMember(Value = "major")]
            Major
        }

        /// <summary>
        /// Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.  
        /// </summary>
        /// <value>Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.  </value>
        [DataMember(Name="MinSeverity", EmitDefaultValue=false)]
        public MinSeverityEnum? MinSeverity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpPolicy" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Description">Description of the policy.  .</param>
        /// <param name="Name">Name of the policy.   .</param>
        /// <param name="Enabled">If enabled, controls the state of the SMTP client service on the managed device  .</param>
        /// <param name="MinSeverity">Minimum fault severity level to receive email notifications. Email notifications are sent for all faults whose severity is equal to or greater than the chosen level.   (default to MinSeverityEnum.Critical).</param>
        /// <param name="Organization">Organization .</param>
        /// <param name="Profiles">Relationship to the profile object .</param>
        /// <param name="SenderEmail">The email address entered here will be displayed as the from address(mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field.  .</param>
        /// <param name="SmtpPort">Port number used by the SMTP server for outgoing SMTP communication  .</param>
        /// <param name="SmtpRecipients">List of email addresses that will receive notifications for faults  .</param>
        /// <param name="SmtpServer">IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications.   .</param>
        public SmtpPolicy(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string Description = default(string), string Name = default(string), bool? Enabled = default(bool?), MinSeverityEnum? MinSeverity = MinSeverityEnum.Critical, IamAccountRef Organization = default(IamAccountRef), List<PolicyAbstractConfigProfileRef> Profiles = default(List<PolicyAbstractConfigProfileRef>), string SenderEmail = default(string), long? SmtpPort = default(long?), List<string> SmtpRecipients = default(List<string>), string SmtpServer = default(string))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Description = Description;
            this.Name = Name;
            this.Enabled = Enabled;
            // use default value if no "MinSeverity" provided
            if (MinSeverity == null)
            {
                this.MinSeverity = MinSeverityEnum.Critical;
            }
            else
            {
                this.MinSeverity = MinSeverity;
            }
            this.Organization = Organization;
            this.Profiles = Profiles;
            this.SenderEmail = SenderEmail;
            this.SmtpPort = SmtpPort;
            this.SmtpRecipients = SmtpRecipients;
            this.SmtpServer = SmtpServer;
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
        /// If enabled, controls the state of the SMTP client service on the managed device  
        /// </summary>
        /// <value>If enabled, controls the state of the SMTP client service on the managed device  </value>
        [DataMember(Name="Enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }


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
        /// The email address entered here will be displayed as the from address(mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field.  
        /// </summary>
        /// <value>The email address entered here will be displayed as the from address(mail received from address) of all the SMTP mail alerts that are received. If not configured, the hostname of the server is used in the from address field.  </value>
        [DataMember(Name="SenderEmail", EmitDefaultValue=false)]
        public string SenderEmail { get; set; }

        /// <summary>
        /// Port number used by the SMTP server for outgoing SMTP communication  
        /// </summary>
        /// <value>Port number used by the SMTP server for outgoing SMTP communication  </value>
        [DataMember(Name="SmtpPort", EmitDefaultValue=false)]
        public long? SmtpPort { get; set; }

        /// <summary>
        /// List of email addresses that will receive notifications for faults  
        /// </summary>
        /// <value>List of email addresses that will receive notifications for faults  </value>
        [DataMember(Name="SmtpRecipients", EmitDefaultValue=false)]
        public List<string> SmtpRecipients { get; set; }

        /// <summary>
        /// IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications.   
        /// </summary>
        /// <value>IP address or hostname of the SMTP server. The SMTP server is used by the managed device to send email notifications.   </value>
        [DataMember(Name="SmtpServer", EmitDefaultValue=false)]
        public string SmtpServer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmtpPolicy {\n");
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
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MinSeverity: ").Append(MinSeverity).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  SenderEmail: ").Append(SenderEmail).Append("\n");
            sb.Append("  SmtpPort: ").Append(SmtpPort).Append("\n");
            sb.Append("  SmtpRecipients: ").Append(SmtpRecipients).Append("\n");
            sb.Append("  SmtpServer: ").Append(SmtpServer).Append("\n");
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
            return this.Equals(obj as SmtpPolicy);
        }

        /// <summary>
        /// Returns true if SmtpPolicy instances are equal
        /// </summary>
        /// <param name="other">Instance of SmtpPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmtpPolicy other)
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
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.MinSeverity == other.MinSeverity ||
                    this.MinSeverity != null &&
                    this.MinSeverity.Equals(other.MinSeverity)
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
                    this.SenderEmail == other.SenderEmail ||
                    this.SenderEmail != null &&
                    this.SenderEmail.Equals(other.SenderEmail)
                ) && 
                (
                    this.SmtpPort == other.SmtpPort ||
                    this.SmtpPort != null &&
                    this.SmtpPort.Equals(other.SmtpPort)
                ) && 
                (
                    this.SmtpRecipients == other.SmtpRecipients ||
                    this.SmtpRecipients != null &&
                    this.SmtpRecipients.SequenceEqual(other.SmtpRecipients)
                ) && 
                (
                    this.SmtpServer == other.SmtpServer ||
                    this.SmtpServer != null &&
                    this.SmtpServer.Equals(other.SmtpServer)
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
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.MinSeverity != null)
                    hash = hash * 59 + this.MinSeverity.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.Profiles != null)
                    hash = hash * 59 + this.Profiles.GetHashCode();
                if (this.SenderEmail != null)
                    hash = hash * 59 + this.SenderEmail.GetHashCode();
                if (this.SmtpPort != null)
                    hash = hash * 59 + this.SmtpPort.GetHashCode();
                if (this.SmtpRecipients != null)
                    hash = hash * 59 + this.SmtpRecipients.GetHashCode();
                if (this.SmtpServer != null)
                    hash = hash * 59 + this.SmtpServer.GetHashCode();
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
