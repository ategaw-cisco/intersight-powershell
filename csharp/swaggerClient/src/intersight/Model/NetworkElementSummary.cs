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
    /// View MO which aggregates information pertaining to a network element from mutiple MOs 
    /// </summary>
    [DataContract]
    public partial class NetworkElementSummary :  IEquatable<NetworkElementSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkElementSummary" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        public NetworkElementSummary(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.RegisteredDevice = RegisteredDevice;
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
        /// Gets or Sets AdminInbandInterfaceState
        /// </summary>
        [DataMember(Name="AdminInbandInterfaceState", EmitDefaultValue=false)]
        public string AdminInbandInterfaceState { get; private set; }

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
        /// Gets or Sets FaultSummary
        /// </summary>
        [DataMember(Name="FaultSummary", EmitDefaultValue=false)]
        public long? FaultSummary { get; private set; }

        /// <summary>
        /// Running firmware information  
        /// </summary>
        /// <value>Running firmware information  </value>
        [DataMember(Name="Firmware", EmitDefaultValue=false)]
        public string Firmware { get; private set; }

        /// <summary>
        /// Gets or Sets InbandIpAddress
        /// </summary>
        [DataMember(Name="InbandIpAddress", EmitDefaultValue=false)]
        public string InbandIpAddress { get; private set; }

        /// <summary>
        /// Gets or Sets InbandIpGateway
        /// </summary>
        [DataMember(Name="InbandIpGateway", EmitDefaultValue=false)]
        public string InbandIpGateway { get; private set; }

        /// <summary>
        /// Gets or Sets InbandIpMask
        /// </summary>
        [DataMember(Name="InbandIpMask", EmitDefaultValue=false)]
        public string InbandIpMask { get; private set; }

        /// <summary>
        /// Gets or Sets InbandVlan
        /// </summary>
        [DataMember(Name="InbandVlan", EmitDefaultValue=false)]
        public long? InbandVlan { get; private set; }

        /// <summary>
        /// Gets or Sets Ipv4Address
        /// </summary>
        [DataMember(Name="Ipv4Address", EmitDefaultValue=false)]
        public string Ipv4Address { get; private set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="Model", EmitDefaultValue=false)]
        public string Model { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Total number of Ether ports  
        /// </summary>
        /// <value>Total number of Ether ports  </value>
        [DataMember(Name="NumEtherPorts", EmitDefaultValue=false)]
        public long? NumEtherPorts { get; private set; }

        /// <summary>
        /// Total number of configured Ether ports  
        /// </summary>
        /// <value>Total number of configured Ether ports  </value>
        [DataMember(Name="NumEtherPortsConfigured", EmitDefaultValue=false)]
        public long? NumEtherPortsConfigured { get; private set; }

        /// <summary>
        /// Total number of Ether ports which are UP  
        /// </summary>
        /// <value>Total number of Ether ports which are UP  </value>
        [DataMember(Name="NumEtherPortsLinkUp", EmitDefaultValue=false)]
        public long? NumEtherPortsLinkUp { get; private set; }

        /// <summary>
        /// Total number of expansion modules  
        /// </summary>
        /// <value>Total number of expansion modules  </value>
        [DataMember(Name="NumExpansionModules", EmitDefaultValue=false)]
        public long? NumExpansionModules { get; private set; }

        /// <summary>
        /// Total number of FC ports  
        /// </summary>
        /// <value>Total number of FC ports  </value>
        [DataMember(Name="NumFcPorts", EmitDefaultValue=false)]
        public long? NumFcPorts { get; private set; }

        /// <summary>
        /// Total number of configured FC ports  
        /// </summary>
        /// <value>Total number of configured FC ports  </value>
        [DataMember(Name="NumFcPortsConfigured", EmitDefaultValue=false)]
        public long? NumFcPortsConfigured { get; private set; }

        /// <summary>
        /// Total number of FC ports which are UP  
        /// </summary>
        /// <value>Total number of FC ports which are UP  </value>
        [DataMember(Name="NumFcPortsLinkUp", EmitDefaultValue=false)]
        public long? NumFcPortsLinkUp { get; private set; }

        /// <summary>
        /// Gets or Sets OutOfBandIpAddress
        /// </summary>
        [DataMember(Name="OutOfBandIpAddress", EmitDefaultValue=false)]
        public string OutOfBandIpAddress { get; private set; }

        /// <summary>
        /// Gets or Sets OutOfBandIpGateway
        /// </summary>
        [DataMember(Name="OutOfBandIpGateway", EmitDefaultValue=false)]
        public string OutOfBandIpGateway { get; private set; }

        /// <summary>
        /// Gets or Sets OutOfBandIpMask
        /// </summary>
        [DataMember(Name="OutOfBandIpMask", EmitDefaultValue=false)]
        public string OutOfBandIpMask { get; private set; }

        /// <summary>
        /// Gets or Sets OutOfBandMac
        /// </summary>
        [DataMember(Name="OutOfBandMac", EmitDefaultValue=false)]
        public string OutOfBandMac { get; private set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="Revision", EmitDefaultValue=false)]
        public string Revision { get; private set; }

        /// <summary>
        /// Gets or Sets Rn
        /// </summary>
        [DataMember(Name="Rn", EmitDefaultValue=false)]
        public string Rn { get; private set; }

        /// <summary>
        /// Gets or Sets Serial
        /// </summary>
        [DataMember(Name="Serial", EmitDefaultValue=false)]
        public string Serial { get; private set; }

        /// <summary>
        /// Specifies the source object type for View MO  
        /// </summary>
        /// <value>Specifies the source object type for View MO  </value>
        [DataMember(Name="SourceObjectType", EmitDefaultValue=false)]
        public string SourceObjectType { get; private set; }

        /// <summary>
        /// Gets or Sets SwitchId
        /// </summary>
        [DataMember(Name="SwitchId", EmitDefaultValue=false)]
        public string SwitchId { get; private set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="Vendor", EmitDefaultValue=false)]
        public string Vendor { get; private set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="Version", EmitDefaultValue=false)]
        public string Version { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkElementSummary {\n");
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
            sb.Append("  AdminInbandInterfaceState: ").Append(AdminInbandInterfaceState).Append("\n");
            sb.Append("  DeviceMoId: ").Append(DeviceMoId).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  FaultSummary: ").Append(FaultSummary).Append("\n");
            sb.Append("  Firmware: ").Append(Firmware).Append("\n");
            sb.Append("  InbandIpAddress: ").Append(InbandIpAddress).Append("\n");
            sb.Append("  InbandIpGateway: ").Append(InbandIpGateway).Append("\n");
            sb.Append("  InbandIpMask: ").Append(InbandIpMask).Append("\n");
            sb.Append("  InbandVlan: ").Append(InbandVlan).Append("\n");
            sb.Append("  Ipv4Address: ").Append(Ipv4Address).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumEtherPorts: ").Append(NumEtherPorts).Append("\n");
            sb.Append("  NumEtherPortsConfigured: ").Append(NumEtherPortsConfigured).Append("\n");
            sb.Append("  NumEtherPortsLinkUp: ").Append(NumEtherPortsLinkUp).Append("\n");
            sb.Append("  NumExpansionModules: ").Append(NumExpansionModules).Append("\n");
            sb.Append("  NumFcPorts: ").Append(NumFcPorts).Append("\n");
            sb.Append("  NumFcPortsConfigured: ").Append(NumFcPortsConfigured).Append("\n");
            sb.Append("  NumFcPortsLinkUp: ").Append(NumFcPortsLinkUp).Append("\n");
            sb.Append("  OutOfBandIpAddress: ").Append(OutOfBandIpAddress).Append("\n");
            sb.Append("  OutOfBandIpGateway: ").Append(OutOfBandIpGateway).Append("\n");
            sb.Append("  OutOfBandIpMask: ").Append(OutOfBandIpMask).Append("\n");
            sb.Append("  OutOfBandMac: ").Append(OutOfBandMac).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Rn: ").Append(Rn).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  SourceObjectType: ").Append(SourceObjectType).Append("\n");
            sb.Append("  SwitchId: ").Append(SwitchId).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(obj as NetworkElementSummary);
        }

        /// <summary>
        /// Returns true if NetworkElementSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of NetworkElementSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkElementSummary other)
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
                    this.AdminInbandInterfaceState == other.AdminInbandInterfaceState ||
                    this.AdminInbandInterfaceState != null &&
                    this.AdminInbandInterfaceState.Equals(other.AdminInbandInterfaceState)
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
                    this.FaultSummary == other.FaultSummary ||
                    this.FaultSummary != null &&
                    this.FaultSummary.Equals(other.FaultSummary)
                ) && 
                (
                    this.Firmware == other.Firmware ||
                    this.Firmware != null &&
                    this.Firmware.Equals(other.Firmware)
                ) && 
                (
                    this.InbandIpAddress == other.InbandIpAddress ||
                    this.InbandIpAddress != null &&
                    this.InbandIpAddress.Equals(other.InbandIpAddress)
                ) && 
                (
                    this.InbandIpGateway == other.InbandIpGateway ||
                    this.InbandIpGateway != null &&
                    this.InbandIpGateway.Equals(other.InbandIpGateway)
                ) && 
                (
                    this.InbandIpMask == other.InbandIpMask ||
                    this.InbandIpMask != null &&
                    this.InbandIpMask.Equals(other.InbandIpMask)
                ) && 
                (
                    this.InbandVlan == other.InbandVlan ||
                    this.InbandVlan != null &&
                    this.InbandVlan.Equals(other.InbandVlan)
                ) && 
                (
                    this.Ipv4Address == other.Ipv4Address ||
                    this.Ipv4Address != null &&
                    this.Ipv4Address.Equals(other.Ipv4Address)
                ) && 
                (
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NumEtherPorts == other.NumEtherPorts ||
                    this.NumEtherPorts != null &&
                    this.NumEtherPorts.Equals(other.NumEtherPorts)
                ) && 
                (
                    this.NumEtherPortsConfigured == other.NumEtherPortsConfigured ||
                    this.NumEtherPortsConfigured != null &&
                    this.NumEtherPortsConfigured.Equals(other.NumEtherPortsConfigured)
                ) && 
                (
                    this.NumEtherPortsLinkUp == other.NumEtherPortsLinkUp ||
                    this.NumEtherPortsLinkUp != null &&
                    this.NumEtherPortsLinkUp.Equals(other.NumEtherPortsLinkUp)
                ) && 
                (
                    this.NumExpansionModules == other.NumExpansionModules ||
                    this.NumExpansionModules != null &&
                    this.NumExpansionModules.Equals(other.NumExpansionModules)
                ) && 
                (
                    this.NumFcPorts == other.NumFcPorts ||
                    this.NumFcPorts != null &&
                    this.NumFcPorts.Equals(other.NumFcPorts)
                ) && 
                (
                    this.NumFcPortsConfigured == other.NumFcPortsConfigured ||
                    this.NumFcPortsConfigured != null &&
                    this.NumFcPortsConfigured.Equals(other.NumFcPortsConfigured)
                ) && 
                (
                    this.NumFcPortsLinkUp == other.NumFcPortsLinkUp ||
                    this.NumFcPortsLinkUp != null &&
                    this.NumFcPortsLinkUp.Equals(other.NumFcPortsLinkUp)
                ) && 
                (
                    this.OutOfBandIpAddress == other.OutOfBandIpAddress ||
                    this.OutOfBandIpAddress != null &&
                    this.OutOfBandIpAddress.Equals(other.OutOfBandIpAddress)
                ) && 
                (
                    this.OutOfBandIpGateway == other.OutOfBandIpGateway ||
                    this.OutOfBandIpGateway != null &&
                    this.OutOfBandIpGateway.Equals(other.OutOfBandIpGateway)
                ) && 
                (
                    this.OutOfBandIpMask == other.OutOfBandIpMask ||
                    this.OutOfBandIpMask != null &&
                    this.OutOfBandIpMask.Equals(other.OutOfBandIpMask)
                ) && 
                (
                    this.OutOfBandMac == other.OutOfBandMac ||
                    this.OutOfBandMac != null &&
                    this.OutOfBandMac.Equals(other.OutOfBandMac)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) && 
                (
                    this.Rn == other.Rn ||
                    this.Rn != null &&
                    this.Rn.Equals(other.Rn)
                ) && 
                (
                    this.Serial == other.Serial ||
                    this.Serial != null &&
                    this.Serial.Equals(other.Serial)
                ) && 
                (
                    this.SourceObjectType == other.SourceObjectType ||
                    this.SourceObjectType != null &&
                    this.SourceObjectType.Equals(other.SourceObjectType)
                ) && 
                (
                    this.SwitchId == other.SwitchId ||
                    this.SwitchId != null &&
                    this.SwitchId.Equals(other.SwitchId)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                ) && 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
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
                if (this.AdminInbandInterfaceState != null)
                    hash = hash * 59 + this.AdminInbandInterfaceState.GetHashCode();
                if (this.DeviceMoId != null)
                    hash = hash * 59 + this.DeviceMoId.GetHashCode();
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                if (this.FaultSummary != null)
                    hash = hash * 59 + this.FaultSummary.GetHashCode();
                if (this.Firmware != null)
                    hash = hash * 59 + this.Firmware.GetHashCode();
                if (this.InbandIpAddress != null)
                    hash = hash * 59 + this.InbandIpAddress.GetHashCode();
                if (this.InbandIpGateway != null)
                    hash = hash * 59 + this.InbandIpGateway.GetHashCode();
                if (this.InbandIpMask != null)
                    hash = hash * 59 + this.InbandIpMask.GetHashCode();
                if (this.InbandVlan != null)
                    hash = hash * 59 + this.InbandVlan.GetHashCode();
                if (this.Ipv4Address != null)
                    hash = hash * 59 + this.Ipv4Address.GetHashCode();
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NumEtherPorts != null)
                    hash = hash * 59 + this.NumEtherPorts.GetHashCode();
                if (this.NumEtherPortsConfigured != null)
                    hash = hash * 59 + this.NumEtherPortsConfigured.GetHashCode();
                if (this.NumEtherPortsLinkUp != null)
                    hash = hash * 59 + this.NumEtherPortsLinkUp.GetHashCode();
                if (this.NumExpansionModules != null)
                    hash = hash * 59 + this.NumExpansionModules.GetHashCode();
                if (this.NumFcPorts != null)
                    hash = hash * 59 + this.NumFcPorts.GetHashCode();
                if (this.NumFcPortsConfigured != null)
                    hash = hash * 59 + this.NumFcPortsConfigured.GetHashCode();
                if (this.NumFcPortsLinkUp != null)
                    hash = hash * 59 + this.NumFcPortsLinkUp.GetHashCode();
                if (this.OutOfBandIpAddress != null)
                    hash = hash * 59 + this.OutOfBandIpAddress.GetHashCode();
                if (this.OutOfBandIpGateway != null)
                    hash = hash * 59 + this.OutOfBandIpGateway.GetHashCode();
                if (this.OutOfBandIpMask != null)
                    hash = hash * 59 + this.OutOfBandIpMask.GetHashCode();
                if (this.OutOfBandMac != null)
                    hash = hash * 59 + this.OutOfBandMac.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.Rn != null)
                    hash = hash * 59 + this.Rn.GetHashCode();
                if (this.Serial != null)
                    hash = hash * 59 + this.Serial.GetHashCode();
                if (this.SourceObjectType != null)
                    hash = hash * 59 + this.SourceObjectType.GetHashCode();
                if (this.SwitchId != null)
                    hash = hash * 59 + this.SwitchId.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
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
