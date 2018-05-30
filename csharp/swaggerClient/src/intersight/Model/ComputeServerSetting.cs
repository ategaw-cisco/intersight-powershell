/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 0.1.0-559
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
    /// This abstract MO models the configurable properties of a server in Intersight. 
    /// </summary>
    [DataContract]
    public partial class ComputeServerSetting :  IEquatable<ComputeServerSetting>, IValidatableObject
    {
        /// <summary>
        /// User configured state of the locator LED for the server  
        /// </summary>
        /// <value>User configured state of the locator LED for the server  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdminLocatorLedStateEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum On for "On"
            /// </summary>
            [EnumMember(Value = "On")]
            On,
            
            /// <summary>
            /// Enum Off for "Off"
            /// </summary>
            [EnumMember(Value = "Off")]
            Off
        }

        /// <summary>
        /// User configured power state of the server  
        /// </summary>
        /// <value>User configured power state of the server  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdminPowerStateEnum
        {
            
            /// <summary>
            /// Enum Policy for "Policy"
            /// </summary>
            [EnumMember(Value = "Policy")]
            Policy,
            
            /// <summary>
            /// Enum PowerOn for "PowerOn"
            /// </summary>
            [EnumMember(Value = "PowerOn")]
            PowerOn,
            
            /// <summary>
            /// Enum PowerOff for "PowerOff"
            /// </summary>
            [EnumMember(Value = "PowerOff")]
            PowerOff,
            
            /// <summary>
            /// Enum PowerCycle for "PowerCycle"
            /// </summary>
            [EnumMember(Value = "PowerCycle")]
            PowerCycle,
            
            /// <summary>
            /// Enum HardReset for "HardReset"
            /// </summary>
            [EnumMember(Value = "HardReset")]
            HardReset,
            
            /// <summary>
            /// Enum Shutdown for "Shutdown"
            /// </summary>
            [EnumMember(Value = "Shutdown")]
            Shutdown,
            
            /// <summary>
            /// Enum Reboot for "Reboot"
            /// </summary>
            [EnumMember(Value = "Reboot")]
            Reboot
        }

        /// <summary>
        /// The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server Applying - This state denotes that the settings are being applied in the target server Failed - This state denotes that the settings could not be applied in the target server  
        /// </summary>
        /// <value>The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server Applying - This state denotes that the settings are being applied in the target server Failed - This state denotes that the settings could not be applied in the target server  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConfigStateEnum
        {
            
            /// <summary>
            /// Enum Applied for "Applied"
            /// </summary>
            [EnumMember(Value = "Applied")]
            Applied,
            
            /// <summary>
            /// Enum Applying for "Applying"
            /// </summary>
            [EnumMember(Value = "Applying")]
            Applying,
            
            /// <summary>
            /// Enum Failed for "Failed"
            /// </summary>
            [EnumMember(Value = "Failed")]
            Failed
        }

        /// <summary>
        /// User configured state of the locator LED for the server  
        /// </summary>
        /// <value>User configured state of the locator LED for the server  </value>
        [DataMember(Name="AdminLocatorLedState", EmitDefaultValue=false)]
        public AdminLocatorLedStateEnum? AdminLocatorLedState { get; set; }
        /// <summary>
        /// User configured power state of the server  
        /// </summary>
        /// <value>User configured power state of the server  </value>
        [DataMember(Name="AdminPowerState", EmitDefaultValue=false)]
        public AdminPowerStateEnum? AdminPowerState { get; set; }
        /// <summary>
        /// The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server Applying - This state denotes that the settings are being applied in the target server Failed - This state denotes that the settings could not be applied in the target server  
        /// </summary>
        /// <value>The configured state of these settings in the target server. The value is any one of Applied, Applying, Failed. Applied - This state denotes that the settings are applied successfully in the target server Applying - This state denotes that the settings are being applied in the target server Failed - This state denotes that the settings could not be applied in the target server  </value>
        [DataMember(Name="ConfigState", EmitDefaultValue=false)]
        public ConfigStateEnum? ConfigState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeServerSetting" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="AdminLocatorLedState">User configured state of the locator LED for the server   (default to AdminLocatorLedStateEnum.None).</param>
        /// <param name="AdminPowerState">User configured power state of the server   (default to AdminPowerStateEnum.Policy).</param>
        /// <param name="LocatorLed">This relation stores a reference to locator LED MO of this server .</param>
        /// <param name="RegisteredDevice">This relation stores the device end point from which this server was discovered .</param>
        /// <param name="Server">Server.</param>
        /// <param name="ServerConfig">The common server configurable properties between a server and a server profile   .</param>
        public ComputeServerSetting(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), AdminLocatorLedStateEnum? AdminLocatorLedState = AdminLocatorLedStateEnum.None, AdminPowerStateEnum? AdminPowerState = AdminPowerStateEnum.Policy, EquipmentLocatorLedRef LocatorLed = default(EquipmentLocatorLedRef), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), ComputeRackUnitRef Server = default(ComputeRackUnitRef), ComputeServerConfig ServerConfig = default(ComputeServerConfig))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            // use default value if no "AdminLocatorLedState" provided
            if (AdminLocatorLedState == null)
            {
                this.AdminLocatorLedState = AdminLocatorLedStateEnum.None;
            }
            else
            {
                this.AdminLocatorLedState = AdminLocatorLedState;
            }
            // use default value if no "AdminPowerState" provided
            if (AdminPowerState == null)
            {
                this.AdminPowerState = AdminPowerStateEnum.Policy;
            }
            else
            {
                this.AdminPowerState = AdminPowerState;
            }
            this.LocatorLed = LocatorLed;
            this.RegisteredDevice = RegisteredDevice;
            this.Server = Server;
            this.ServerConfig = ServerConfig;
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
        /// Gets or Sets DeviceMoId
        /// </summary>
        [DataMember(Name="DeviceMoId", EmitDefaultValue=false)]
        public string DeviceMoId { get; private set; }

        /// <summary>
        /// Gets or Sets Dn
        /// </summary>
        [DataMember(Name="Dn", EmitDefaultValue=false)]
        public string Dn { get; private set; }

        /// <summary>
        /// Gets or Sets Rn
        /// </summary>
        [DataMember(Name="Rn", EmitDefaultValue=false)]
        public string Rn { get; private set; }




        /// <summary>
        /// This relation stores a reference to locator LED MO of this server 
        /// </summary>
        /// <value>This relation stores a reference to locator LED MO of this server </value>
        [DataMember(Name="LocatorLed", EmitDefaultValue=false)]
        public EquipmentLocatorLedRef LocatorLed { get; set; }

        /// <summary>
        /// This relation stores the device end point from which this server was discovered 
        /// </summary>
        /// <value>This relation stores the device end point from which this server was discovered </value>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets Server
        /// </summary>
        [DataMember(Name="Server", EmitDefaultValue=false)]
        public ComputeRackUnitRef Server { get; set; }

        /// <summary>
        /// The common server configurable properties between a server and a server profile   
        /// </summary>
        /// <value>The common server configurable properties between a server and a server profile   </value>
        [DataMember(Name="ServerConfig", EmitDefaultValue=false)]
        public ComputeServerConfig ServerConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeServerSetting {\n");
            sb.Append("  AccountMoid: ").Append(AccountMoid).Append("\n");
            sb.Append("  Ancestors: ").Append(Ancestors).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  ModTime: ").Append(ModTime).Append("\n");
            sb.Append("  Moid: ").Append(Moid).Append("\n");
            sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  DeviceMoId: ").Append(DeviceMoId).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  Rn: ").Append(Rn).Append("\n");
            sb.Append("  AdminLocatorLedState: ").Append(AdminLocatorLedState).Append("\n");
            sb.Append("  AdminPowerState: ").Append(AdminPowerState).Append("\n");
            sb.Append("  ConfigState: ").Append(ConfigState).Append("\n");
            sb.Append("  LocatorLed: ").Append(LocatorLed).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  ServerConfig: ").Append(ServerConfig).Append("\n");
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
            return this.Equals(obj as ComputeServerSetting);
        }

        /// <summary>
        /// Returns true if ComputeServerSetting instances are equal
        /// </summary>
        /// <param name="other">Instance of ComputeServerSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComputeServerSetting other)
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
                    this.DeviceMoId == other.DeviceMoId ||
                    this.DeviceMoId != null &&
                    this.DeviceMoId.Equals(other.DeviceMoId)
                ) && 
                (
                    this.Dn == other.Dn ||
                    this.Dn != null &&
                    this.Dn.Equals(other.Dn)
                ) && 
                (
                    this.Rn == other.Rn ||
                    this.Rn != null &&
                    this.Rn.Equals(other.Rn)
                ) && 
                (
                    this.AdminLocatorLedState == other.AdminLocatorLedState ||
                    this.AdminLocatorLedState != null &&
                    this.AdminLocatorLedState.Equals(other.AdminLocatorLedState)
                ) && 
                (
                    this.AdminPowerState == other.AdminPowerState ||
                    this.AdminPowerState != null &&
                    this.AdminPowerState.Equals(other.AdminPowerState)
                ) && 
                (
                    this.ConfigState == other.ConfigState ||
                    this.ConfigState != null &&
                    this.ConfigState.Equals(other.ConfigState)
                ) && 
                (
                    this.LocatorLed == other.LocatorLed ||
                    this.LocatorLed != null &&
                    this.LocatorLed.Equals(other.LocatorLed)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.Server == other.Server ||
                    this.Server != null &&
                    this.Server.Equals(other.Server)
                ) && 
                (
                    this.ServerConfig == other.ServerConfig ||
                    this.ServerConfig != null &&
                    this.ServerConfig.Equals(other.ServerConfig)
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
                if (this.DeviceMoId != null)
                    hash = hash * 59 + this.DeviceMoId.GetHashCode();
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                if (this.Rn != null)
                    hash = hash * 59 + this.Rn.GetHashCode();
                if (this.AdminLocatorLedState != null)
                    hash = hash * 59 + this.AdminLocatorLedState.GetHashCode();
                if (this.AdminPowerState != null)
                    hash = hash * 59 + this.AdminPowerState.GetHashCode();
                if (this.ConfigState != null)
                    hash = hash * 59 + this.ConfigState.GetHashCode();
                if (this.LocatorLed != null)
                    hash = hash * 59 + this.LocatorLed.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.Server != null)
                    hash = hash * 59 + this.Server.GetHashCode();
                if (this.ServerConfig != null)
                    hash = hash * 59 + this.ServerConfig.GetHashCode();
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
