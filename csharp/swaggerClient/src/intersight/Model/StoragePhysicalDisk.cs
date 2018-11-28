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
    /// Physical Disk on a server 
    /// </summary>
    [DataContract]
    public partial class StoragePhysicalDisk :  IEquatable<StoragePhysicalDisk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoragePhysicalDisk" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="DriveFirmware">DriveFirmware.</param>
        /// <param name="FdeCapable">FdeCapable.</param>
        /// <param name="LocatorLed">LocatorLed.</param>
        /// <param name="PhysicalDiskExtension">PhysicalDiskExtension.</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        /// <param name="RunningFirmware">RunningFirmware.</param>
        /// <param name="StorageController">StorageController.</param>
        /// <param name="StorageEnclosure">StorageEnclosure.</param>
        public StoragePhysicalDisk(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), string DriveFirmware = default(string), string FdeCapable = default(string), EquipmentLocatorLedRef LocatorLed = default(EquipmentLocatorLedRef), StoragePhysicalDiskExtensionRef PhysicalDiskExtension = default(StoragePhysicalDiskExtensionRef), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), List<FirmwareRunningFirmwareRef> RunningFirmware = default(List<FirmwareRunningFirmwareRef>), StorageControllerRef StorageController = default(StorageControllerRef), StorageEnclosureRef StorageEnclosure = default(StorageEnclosureRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.DriveFirmware = DriveFirmware;
            this.FdeCapable = FdeCapable;
            this.LocatorLed = LocatorLed;
            this.PhysicalDiskExtension = PhysicalDiskExtension;
            this.RegisteredDevice = RegisteredDevice;
            this.RunningFirmware = RunningFirmware;
            this.StorageController = StorageController;
            this.StorageEnclosure = StorageEnclosure;
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
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name="Model", EmitDefaultValue=false)]
        public string Model { get; private set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="Revision", EmitDefaultValue=false)]
        public string Revision { get; private set; }

        /// <summary>
        /// Gets or Sets Serial
        /// </summary>
        [DataMember(Name="Serial", EmitDefaultValue=false)]
        public string Serial { get; private set; }

        /// <summary>
        /// Gets or Sets Vendor
        /// </summary>
        [DataMember(Name="Vendor", EmitDefaultValue=false)]
        public string Vendor { get; private set; }

        /// <summary>
        /// Gets or Sets BlockSize
        /// </summary>
        [DataMember(Name="BlockSize", EmitDefaultValue=false)]
        public string BlockSize { get; private set; }

        /// <summary>
        /// Gets or Sets Bootable
        /// </summary>
        [DataMember(Name="Bootable", EmitDefaultValue=false)]
        public string Bootable { get; private set; }

        /// <summary>
        /// Gets or Sets ConfigurationCheckpoint
        /// </summary>
        [DataMember(Name="ConfigurationCheckpoint", EmitDefaultValue=false)]
        public string ConfigurationCheckpoint { get; private set; }

        /// <summary>
        /// Gets or Sets ConfigurationState
        /// </summary>
        [DataMember(Name="ConfigurationState", EmitDefaultValue=false)]
        public string ConfigurationState { get; private set; }

        /// <summary>
        /// Gets or Sets DiscoveredPath
        /// </summary>
        [DataMember(Name="DiscoveredPath", EmitDefaultValue=false)]
        public string DiscoveredPath { get; private set; }

        /// <summary>
        /// Gets or Sets DiskId
        /// </summary>
        [DataMember(Name="DiskId", EmitDefaultValue=false)]
        public string DiskId { get; private set; }

        /// <summary>
        /// Gets or Sets DiskState
        /// </summary>
        [DataMember(Name="DiskState", EmitDefaultValue=false)]
        public string DiskState { get; private set; }

        /// <summary>
        /// Gets or Sets DriveFirmware
        /// </summary>
        [DataMember(Name="DriveFirmware", EmitDefaultValue=false)]
        public string DriveFirmware { get; set; }

        /// <summary>
        /// Gets or Sets DriveState
        /// </summary>
        [DataMember(Name="DriveState", EmitDefaultValue=false)]
        public string DriveState { get; private set; }

        /// <summary>
        /// Gets or Sets FdeCapable
        /// </summary>
        [DataMember(Name="FdeCapable", EmitDefaultValue=false)]
        public string FdeCapable { get; set; }

        /// <summary>
        /// Gets or Sets LinkSpeed
        /// </summary>
        [DataMember(Name="LinkSpeed", EmitDefaultValue=false)]
        public string LinkSpeed { get; private set; }

        /// <summary>
        /// Gets or Sets LinkState
        /// </summary>
        [DataMember(Name="LinkState", EmitDefaultValue=false)]
        public string LinkState { get; private set; }

        /// <summary>
        /// Gets or Sets LocatorLed
        /// </summary>
        [DataMember(Name="LocatorLed", EmitDefaultValue=false)]
        public EquipmentLocatorLedRef LocatorLed { get; set; }

        /// <summary>
        /// Gets or Sets NumBlocks
        /// </summary>
        [DataMember(Name="NumBlocks", EmitDefaultValue=false)]
        public string NumBlocks { get; private set; }

        /// <summary>
        /// Gets or Sets OperPowerState
        /// </summary>
        [DataMember(Name="OperPowerState", EmitDefaultValue=false)]
        public string OperPowerState { get; private set; }

        /// <summary>
        /// Gets or Sets OperQualifierReason
        /// </summary>
        [DataMember(Name="OperQualifierReason", EmitDefaultValue=false)]
        public string OperQualifierReason { get; private set; }

        /// <summary>
        /// Gets or Sets Operability
        /// </summary>
        [DataMember(Name="Operability", EmitDefaultValue=false)]
        public string Operability { get; private set; }

        /// <summary>
        /// Gets or Sets PhysicalBlockSize
        /// </summary>
        [DataMember(Name="PhysicalBlockSize", EmitDefaultValue=false)]
        public string PhysicalBlockSize { get; private set; }

        /// <summary>
        /// Gets or Sets PhysicalDiskExtension
        /// </summary>
        [DataMember(Name="PhysicalDiskExtension", EmitDefaultValue=false)]
        public StoragePhysicalDiskExtensionRef PhysicalDiskExtension { get; set; }

        /// <summary>
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="Presence", EmitDefaultValue=false)]
        public string Presence { get; private set; }

        /// <summary>
        /// Gets or Sets Protocol
        /// </summary>
        [DataMember(Name="Protocol", EmitDefaultValue=false)]
        public string Protocol { get; private set; }

        /// <summary>
        /// Gets or Sets RawSize
        /// </summary>
        [DataMember(Name="RawSize", EmitDefaultValue=false)]
        public string RawSize { get; private set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets RunningFirmware
        /// </summary>
        [DataMember(Name="RunningFirmware", EmitDefaultValue=false)]
        public List<FirmwareRunningFirmwareRef> RunningFirmware { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public string Size { get; private set; }

        /// <summary>
        /// Gets or Sets StorageController
        /// </summary>
        [DataMember(Name="StorageController", EmitDefaultValue=false)]
        public StorageControllerRef StorageController { get; set; }

        /// <summary>
        /// Gets or Sets StorageEnclosure
        /// </summary>
        [DataMember(Name="StorageEnclosure", EmitDefaultValue=false)]
        public StorageEnclosureRef StorageEnclosure { get; set; }

        /// <summary>
        /// Gets or Sets Thermal
        /// </summary>
        [DataMember(Name="Thermal", EmitDefaultValue=false)]
        public string Thermal { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets VariantType
        /// </summary>
        [DataMember(Name="VariantType", EmitDefaultValue=false)]
        public string VariantType { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoragePhysicalDisk {\n");
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
            sb.Append("  DeviceMoId: ").Append(DeviceMoId).Append("\n");
            sb.Append("  Dn: ").Append(Dn).Append("\n");
            sb.Append("  Rn: ").Append(Rn).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  BlockSize: ").Append(BlockSize).Append("\n");
            sb.Append("  Bootable: ").Append(Bootable).Append("\n");
            sb.Append("  ConfigurationCheckpoint: ").Append(ConfigurationCheckpoint).Append("\n");
            sb.Append("  ConfigurationState: ").Append(ConfigurationState).Append("\n");
            sb.Append("  DiscoveredPath: ").Append(DiscoveredPath).Append("\n");
            sb.Append("  DiskId: ").Append(DiskId).Append("\n");
            sb.Append("  DiskState: ").Append(DiskState).Append("\n");
            sb.Append("  DriveFirmware: ").Append(DriveFirmware).Append("\n");
            sb.Append("  DriveState: ").Append(DriveState).Append("\n");
            sb.Append("  FdeCapable: ").Append(FdeCapable).Append("\n");
            sb.Append("  LinkSpeed: ").Append(LinkSpeed).Append("\n");
            sb.Append("  LinkState: ").Append(LinkState).Append("\n");
            sb.Append("  LocatorLed: ").Append(LocatorLed).Append("\n");
            sb.Append("  NumBlocks: ").Append(NumBlocks).Append("\n");
            sb.Append("  OperPowerState: ").Append(OperPowerState).Append("\n");
            sb.Append("  OperQualifierReason: ").Append(OperQualifierReason).Append("\n");
            sb.Append("  Operability: ").Append(Operability).Append("\n");
            sb.Append("  PhysicalBlockSize: ").Append(PhysicalBlockSize).Append("\n");
            sb.Append("  PhysicalDiskExtension: ").Append(PhysicalDiskExtension).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  Protocol: ").Append(Protocol).Append("\n");
            sb.Append("  RawSize: ").Append(RawSize).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  RunningFirmware: ").Append(RunningFirmware).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StorageController: ").Append(StorageController).Append("\n");
            sb.Append("  StorageEnclosure: ").Append(StorageEnclosure).Append("\n");
            sb.Append("  Thermal: ").Append(Thermal).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VariantType: ").Append(VariantType).Append("\n");
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
            return this.Equals(obj as StoragePhysicalDisk);
        }

        /// <summary>
        /// Returns true if StoragePhysicalDisk instances are equal
        /// </summary>
        /// <param name="other">Instance of StoragePhysicalDisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoragePhysicalDisk other)
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
                    this.Model == other.Model ||
                    this.Model != null &&
                    this.Model.Equals(other.Model)
                ) && 
                (
                    this.Revision == other.Revision ||
                    this.Revision != null &&
                    this.Revision.Equals(other.Revision)
                ) && 
                (
                    this.Serial == other.Serial ||
                    this.Serial != null &&
                    this.Serial.Equals(other.Serial)
                ) && 
                (
                    this.Vendor == other.Vendor ||
                    this.Vendor != null &&
                    this.Vendor.Equals(other.Vendor)
                ) && 
                (
                    this.BlockSize == other.BlockSize ||
                    this.BlockSize != null &&
                    this.BlockSize.Equals(other.BlockSize)
                ) && 
                (
                    this.Bootable == other.Bootable ||
                    this.Bootable != null &&
                    this.Bootable.Equals(other.Bootable)
                ) && 
                (
                    this.ConfigurationCheckpoint == other.ConfigurationCheckpoint ||
                    this.ConfigurationCheckpoint != null &&
                    this.ConfigurationCheckpoint.Equals(other.ConfigurationCheckpoint)
                ) && 
                (
                    this.ConfigurationState == other.ConfigurationState ||
                    this.ConfigurationState != null &&
                    this.ConfigurationState.Equals(other.ConfigurationState)
                ) && 
                (
                    this.DiscoveredPath == other.DiscoveredPath ||
                    this.DiscoveredPath != null &&
                    this.DiscoveredPath.Equals(other.DiscoveredPath)
                ) && 
                (
                    this.DiskId == other.DiskId ||
                    this.DiskId != null &&
                    this.DiskId.Equals(other.DiskId)
                ) && 
                (
                    this.DiskState == other.DiskState ||
                    this.DiskState != null &&
                    this.DiskState.Equals(other.DiskState)
                ) && 
                (
                    this.DriveFirmware == other.DriveFirmware ||
                    this.DriveFirmware != null &&
                    this.DriveFirmware.Equals(other.DriveFirmware)
                ) && 
                (
                    this.DriveState == other.DriveState ||
                    this.DriveState != null &&
                    this.DriveState.Equals(other.DriveState)
                ) && 
                (
                    this.FdeCapable == other.FdeCapable ||
                    this.FdeCapable != null &&
                    this.FdeCapable.Equals(other.FdeCapable)
                ) && 
                (
                    this.LinkSpeed == other.LinkSpeed ||
                    this.LinkSpeed != null &&
                    this.LinkSpeed.Equals(other.LinkSpeed)
                ) && 
                (
                    this.LinkState == other.LinkState ||
                    this.LinkState != null &&
                    this.LinkState.Equals(other.LinkState)
                ) && 
                (
                    this.LocatorLed == other.LocatorLed ||
                    this.LocatorLed != null &&
                    this.LocatorLed.Equals(other.LocatorLed)
                ) && 
                (
                    this.NumBlocks == other.NumBlocks ||
                    this.NumBlocks != null &&
                    this.NumBlocks.Equals(other.NumBlocks)
                ) && 
                (
                    this.OperPowerState == other.OperPowerState ||
                    this.OperPowerState != null &&
                    this.OperPowerState.Equals(other.OperPowerState)
                ) && 
                (
                    this.OperQualifierReason == other.OperQualifierReason ||
                    this.OperQualifierReason != null &&
                    this.OperQualifierReason.Equals(other.OperQualifierReason)
                ) && 
                (
                    this.Operability == other.Operability ||
                    this.Operability != null &&
                    this.Operability.Equals(other.Operability)
                ) && 
                (
                    this.PhysicalBlockSize == other.PhysicalBlockSize ||
                    this.PhysicalBlockSize != null &&
                    this.PhysicalBlockSize.Equals(other.PhysicalBlockSize)
                ) && 
                (
                    this.PhysicalDiskExtension == other.PhysicalDiskExtension ||
                    this.PhysicalDiskExtension != null &&
                    this.PhysicalDiskExtension.Equals(other.PhysicalDiskExtension)
                ) && 
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) && 
                (
                    this.Protocol == other.Protocol ||
                    this.Protocol != null &&
                    this.Protocol.Equals(other.Protocol)
                ) && 
                (
                    this.RawSize == other.RawSize ||
                    this.RawSize != null &&
                    this.RawSize.Equals(other.RawSize)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.RunningFirmware == other.RunningFirmware ||
                    this.RunningFirmware != null &&
                    this.RunningFirmware.SequenceEqual(other.RunningFirmware)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.StorageController == other.StorageController ||
                    this.StorageController != null &&
                    this.StorageController.Equals(other.StorageController)
                ) && 
                (
                    this.StorageEnclosure == other.StorageEnclosure ||
                    this.StorageEnclosure != null &&
                    this.StorageEnclosure.Equals(other.StorageEnclosure)
                ) && 
                (
                    this.Thermal == other.Thermal ||
                    this.Thermal != null &&
                    this.Thermal.Equals(other.Thermal)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.VariantType == other.VariantType ||
                    this.VariantType != null &&
                    this.VariantType.Equals(other.VariantType)
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
                if (this.DeviceMoId != null)
                    hash = hash * 59 + this.DeviceMoId.GetHashCode();
                if (this.Dn != null)
                    hash = hash * 59 + this.Dn.GetHashCode();
                if (this.Rn != null)
                    hash = hash * 59 + this.Rn.GetHashCode();
                if (this.Model != null)
                    hash = hash * 59 + this.Model.GetHashCode();
                if (this.Revision != null)
                    hash = hash * 59 + this.Revision.GetHashCode();
                if (this.Serial != null)
                    hash = hash * 59 + this.Serial.GetHashCode();
                if (this.Vendor != null)
                    hash = hash * 59 + this.Vendor.GetHashCode();
                if (this.BlockSize != null)
                    hash = hash * 59 + this.BlockSize.GetHashCode();
                if (this.Bootable != null)
                    hash = hash * 59 + this.Bootable.GetHashCode();
                if (this.ConfigurationCheckpoint != null)
                    hash = hash * 59 + this.ConfigurationCheckpoint.GetHashCode();
                if (this.ConfigurationState != null)
                    hash = hash * 59 + this.ConfigurationState.GetHashCode();
                if (this.DiscoveredPath != null)
                    hash = hash * 59 + this.DiscoveredPath.GetHashCode();
                if (this.DiskId != null)
                    hash = hash * 59 + this.DiskId.GetHashCode();
                if (this.DiskState != null)
                    hash = hash * 59 + this.DiskState.GetHashCode();
                if (this.DriveFirmware != null)
                    hash = hash * 59 + this.DriveFirmware.GetHashCode();
                if (this.DriveState != null)
                    hash = hash * 59 + this.DriveState.GetHashCode();
                if (this.FdeCapable != null)
                    hash = hash * 59 + this.FdeCapable.GetHashCode();
                if (this.LinkSpeed != null)
                    hash = hash * 59 + this.LinkSpeed.GetHashCode();
                if (this.LinkState != null)
                    hash = hash * 59 + this.LinkState.GetHashCode();
                if (this.LocatorLed != null)
                    hash = hash * 59 + this.LocatorLed.GetHashCode();
                if (this.NumBlocks != null)
                    hash = hash * 59 + this.NumBlocks.GetHashCode();
                if (this.OperPowerState != null)
                    hash = hash * 59 + this.OperPowerState.GetHashCode();
                if (this.OperQualifierReason != null)
                    hash = hash * 59 + this.OperQualifierReason.GetHashCode();
                if (this.Operability != null)
                    hash = hash * 59 + this.Operability.GetHashCode();
                if (this.PhysicalBlockSize != null)
                    hash = hash * 59 + this.PhysicalBlockSize.GetHashCode();
                if (this.PhysicalDiskExtension != null)
                    hash = hash * 59 + this.PhysicalDiskExtension.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
                if (this.Protocol != null)
                    hash = hash * 59 + this.Protocol.GetHashCode();
                if (this.RawSize != null)
                    hash = hash * 59 + this.RawSize.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.RunningFirmware != null)
                    hash = hash * 59 + this.RunningFirmware.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.StorageController != null)
                    hash = hash * 59 + this.StorageController.GetHashCode();
                if (this.StorageEnclosure != null)
                    hash = hash * 59 + this.StorageEnclosure.GetHashCode();
                if (this.Thermal != null)
                    hash = hash * 59 + this.Thermal.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.VariantType != null)
                    hash = hash * 59 + this.VariantType.GetHashCode();
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
