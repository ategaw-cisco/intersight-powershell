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
    /// Represents the configuration change details. 
    /// </summary>
    [DataContract]
    public partial class ServerConfigChangeDetail :  IEquatable<ServerConfigChangeDetail>, IValidatableObject
    {
        /// <summary>
        /// Modification status of the mo in this config change   
        /// </summary>
        /// <value>Modification status of the mo in this config change   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModStatusEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Created for "Created"
            /// </summary>
            [EnumMember(Value = "Created")]
            Created,
            
            /// <summary>
            /// Enum Modified for "Modified"
            /// </summary>
            [EnumMember(Value = "Modified")]
            Modified,
            
            /// <summary>
            /// Enum Deleted for "Deleted"
            /// </summary>
            [EnumMember(Value = "Deleted")]
            Deleted
        }

        /// <summary>
        /// Modification status of the mo in this config change   
        /// </summary>
        /// <value>Modification status of the mo in this config change   </value>
        [DataMember(Name="ModStatus", EmitDefaultValue=false)]
        public ModStatusEnum? ModStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServerConfigChangeDetail" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Changes">Type of the configuration change  .</param>
        /// <param name="ConfigChangeContext">Context information on the change.  .</param>
        /// <param name="Disruptions">Possible discrution the configuration change might cause  .</param>
        /// <param name="Message">Detailed description of the config change  .</param>
        /// <param name="ModStatus">Modification status of the mo in this config change    (default to ModStatusEnum.None).</param>
        /// <param name="Profile">Profile.</param>
        public ServerConfigChangeDetail(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), List<string> Changes = default(List<string>), PolicyConfigResultContext ConfigChangeContext = default(PolicyConfigResultContext), List<string> Disruptions = default(List<string>), string Message = default(string), ModStatusEnum? ModStatus = ModStatusEnum.None, ServerProfileRef Profile = default(ServerProfileRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Changes = Changes;
            this.ConfigChangeContext = ConfigChangeContext;
            this.Disruptions = Disruptions;
            this.Message = Message;
            // use default value if no "ModStatus" provided
            if (ModStatus == null)
            {
                this.ModStatus = ModStatusEnum.None;
            }
            else
            {
                this.ModStatus = ModStatus;
            }
            this.Profile = Profile;
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
        /// Type of the configuration change  
        /// </summary>
        /// <value>Type of the configuration change  </value>
        [DataMember(Name="Changes", EmitDefaultValue=false)]
        public List<string> Changes { get; set; }

        /// <summary>
        /// Context information on the change.  
        /// </summary>
        /// <value>Context information on the change.  </value>
        [DataMember(Name="ConfigChangeContext", EmitDefaultValue=false)]
        public PolicyConfigResultContext ConfigChangeContext { get; set; }

        /// <summary>
        /// Possible discrution the configuration change might cause  
        /// </summary>
        /// <value>Possible discrution the configuration change might cause  </value>
        [DataMember(Name="Disruptions", EmitDefaultValue=false)]
        public List<string> Disruptions { get; set; }

        /// <summary>
        /// Detailed description of the config change  
        /// </summary>
        /// <value>Detailed description of the config change  </value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; set; }


        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name="Profile", EmitDefaultValue=false)]
        public ServerProfileRef Profile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerConfigChangeDetail {\n");
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
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  ConfigChangeContext: ").Append(ConfigChangeContext).Append("\n");
            sb.Append("  Disruptions: ").Append(Disruptions).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  ModStatus: ").Append(ModStatus).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
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
            return this.Equals(obj as ServerConfigChangeDetail);
        }

        /// <summary>
        /// Returns true if ServerConfigChangeDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of ServerConfigChangeDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServerConfigChangeDetail other)
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
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) && 
                (
                    this.ConfigChangeContext == other.ConfigChangeContext ||
                    this.ConfigChangeContext != null &&
                    this.ConfigChangeContext.Equals(other.ConfigChangeContext)
                ) && 
                (
                    this.Disruptions == other.Disruptions ||
                    this.Disruptions != null &&
                    this.Disruptions.SequenceEqual(other.Disruptions)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.ModStatus == other.ModStatus ||
                    this.ModStatus != null &&
                    this.ModStatus.Equals(other.ModStatus)
                ) && 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
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
                if (this.Changes != null)
                    hash = hash * 59 + this.Changes.GetHashCode();
                if (this.ConfigChangeContext != null)
                    hash = hash * 59 + this.ConfigChangeContext.GetHashCode();
                if (this.Disruptions != null)
                    hash = hash * 59 + this.Disruptions.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.ModStatus != null)
                    hash = hash * 59 + this.ModStatus.GetHashCode();
                if (this.Profile != null)
                    hash = hash * 59 + this.Profile.GetHashCode();
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
