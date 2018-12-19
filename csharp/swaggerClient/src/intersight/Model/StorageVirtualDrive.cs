/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-300
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
    /// A Virtual Disk or LUN 
    /// </summary>
    [DataContract]
    public partial class StorageVirtualDrive :  IEquatable<StorageVirtualDrive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageVirtualDrive" /> class.
        /// </summary>
        /// <param name="Ancestors">The array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">The unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">The array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">The array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object.   .</param>
        /// <param name="PhysicalDiskUsages">PhysicalDiskUsages.</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        /// <param name="StorageController">A collection of references to the [storage.Controller](mo://storage.Controller) Managed Object.  When this managed object is deleted, the referenced [storage.Controller](mo://storage.Controller) MO unsets its reference to this deleted MO. .</param>
        /// <param name="VdMemberEps">VdMemberEps.</param>
        /// <param name="VirtualDriveExtension">A collection of references to the [storage.VirtualDriveExtension](mo://storage.VirtualDriveExtension) Managed Object.  When this managed object is deleted, the referenced [storage.VirtualDriveExtension](mo://storage.VirtualDriveExtension) MO unsets its reference to this deleted MO. .</param>
        public StorageVirtualDrive(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), List<StoragePhysicalDiskUsageRef> PhysicalDiskUsages = default(List<StoragePhysicalDiskUsageRef>), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), StorageControllerRef StorageController = default(StorageControllerRef), List<StorageVdMemberEpRef> VdMemberEps = default(List<StorageVdMemberEpRef>), StorageVirtualDriveExtensionRef VirtualDriveExtension = default(StorageVirtualDriveExtensionRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.PhysicalDiskUsages = PhysicalDiskUsages;
            this.RegisteredDevice = RegisteredDevice;
            this.StorageController = StorageController;
            this.VdMemberEps = VdMemberEps;
            this.VirtualDriveExtension = VirtualDriveExtension;
        }
        
        /// <summary>
        /// The Account ID for this managed object.  
        /// </summary>
        /// <value>The Account ID for this managed object.  </value>
        [DataMember(Name="AccountMoid", EmitDefaultValue=false)]
        public string AccountMoid { get; private set; }

        /// <summary>
        /// The array containing the MO references of the ancestors in the object containment hierarchy. 
        /// </summary>
        /// <value>The array containing the MO references of the ancestors in the object containment hierarchy. </value>
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
        /// The unique identifier of this Managed Object instance.  
        /// </summary>
        /// <value>The unique identifier of this Managed Object instance.  </value>
        [DataMember(Name="Moid", EmitDefaultValue=false)]
        public string Moid { get; set; }

        /// <summary>
        /// The fully-qualified type of this managed object, e.g. the class name.  
        /// </summary>
        /// <value>The fully-qualified type of this managed object, e.g. the class name.  </value>
        [DataMember(Name="ObjectType", EmitDefaultValue=false)]
        public string ObjectType { get; private set; }

        /// <summary>
        /// The array of owners which represent effective ownership of this object.   
        /// </summary>
        /// <value>The array of owners which represent effective ownership of this object.   </value>
        [DataMember(Name="Owners", EmitDefaultValue=false)]
        public List<string> Owners { get; set; }

        /// <summary>
        /// The direct ancestor of this managed object in the containment hierarchy. 
        /// </summary>
        /// <value>The direct ancestor of this managed object in the containment hierarchy. </value>
        [DataMember(Name="Parent", EmitDefaultValue=false)]
        public MoBaseMoRef Parent { get; set; }

        /// <summary>
        /// The array of tags, which allow to add key, value meta-data to managed objects.  
        /// </summary>
        /// <value>The array of tags, which allow to add key, value meta-data to managed objects.  </value>
        [DataMember(Name="Tags", EmitDefaultValue=false)]
        public List<MoTag> Tags { get; set; }

        /// <summary>
        /// The versioning info for this managed object.   
        /// </summary>
        /// <value>The versioning info for this managed object.   </value>
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
        /// Gets or Sets AccessPolicy
        /// </summary>
        [DataMember(Name="AccessPolicy", EmitDefaultValue=false)]
        public string AccessPolicy { get; private set; }

        /// <summary>
        /// Gets or Sets ActualWriteCachePolicy
        /// </summary>
        [DataMember(Name="ActualWriteCachePolicy", EmitDefaultValue=false)]
        public string ActualWriteCachePolicy { get; private set; }

        /// <summary>
        /// Gets or Sets AvailableSize
        /// </summary>
        [DataMember(Name="AvailableSize", EmitDefaultValue=false)]
        public string AvailableSize { get; private set; }

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
        /// Gets or Sets ConfigState
        /// </summary>
        [DataMember(Name="ConfigState", EmitDefaultValue=false)]
        public string ConfigState { get; private set; }

        /// <summary>
        /// Gets or Sets ConfiguredWriteCachePolicy
        /// </summary>
        [DataMember(Name="ConfiguredWriteCachePolicy", EmitDefaultValue=false)]
        public string ConfiguredWriteCachePolicy { get; private set; }

        /// <summary>
        /// Gets or Sets ConnectionProtocol
        /// </summary>
        [DataMember(Name="ConnectionProtocol", EmitDefaultValue=false)]
        public string ConnectionProtocol { get; private set; }

        /// <summary>
        /// Gets or Sets DriveCache
        /// </summary>
        [DataMember(Name="DriveCache", EmitDefaultValue=false)]
        public string DriveCache { get; private set; }

        /// <summary>
        /// Gets or Sets DriveSecurity
        /// </summary>
        [DataMember(Name="DriveSecurity", EmitDefaultValue=false)]
        public string DriveSecurity { get; private set; }

        /// <summary>
        /// Gets or Sets DriveState
        /// </summary>
        [DataMember(Name="DriveState", EmitDefaultValue=false)]
        public string DriveState { get; private set; }

        /// <summary>
        /// Gets or Sets IoPolicy
        /// </summary>
        [DataMember(Name="IoPolicy", EmitDefaultValue=false)]
        public string IoPolicy { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or Sets NumBlocks
        /// </summary>
        [DataMember(Name="NumBlocks", EmitDefaultValue=false)]
        public string NumBlocks { get; private set; }

        /// <summary>
        /// Gets or Sets OperState
        /// </summary>
        [DataMember(Name="OperState", EmitDefaultValue=false)]
        public string OperState { get; private set; }

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
        /// Gets or Sets PhysicalDiskUsages
        /// </summary>
        [DataMember(Name="PhysicalDiskUsages", EmitDefaultValue=false)]
        public List<StoragePhysicalDiskUsageRef> PhysicalDiskUsages { get; set; }

        /// <summary>
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="Presence", EmitDefaultValue=false)]
        public string Presence { get; private set; }

        /// <summary>
        /// Gets or Sets ReadPolicy
        /// </summary>
        [DataMember(Name="ReadPolicy", EmitDefaultValue=false)]
        public string ReadPolicy { get; private set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets SecurityFlags
        /// </summary>
        [DataMember(Name="SecurityFlags", EmitDefaultValue=false)]
        public string SecurityFlags { get; private set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public string Size { get; private set; }

        /// <summary>
        /// A collection of references to the [storage.Controller](mo://storage.Controller) Managed Object.  When this managed object is deleted, the referenced [storage.Controller](mo://storage.Controller) MO unsets its reference to this deleted MO. 
        /// </summary>
        /// <value>A collection of references to the [storage.Controller](mo://storage.Controller) Managed Object.  When this managed object is deleted, the referenced [storage.Controller](mo://storage.Controller) MO unsets its reference to this deleted MO. </value>
        [DataMember(Name="StorageController", EmitDefaultValue=false)]
        public StorageControllerRef StorageController { get; set; }

        /// <summary>
        /// Gets or Sets StripSize
        /// </summary>
        [DataMember(Name="StripSize", EmitDefaultValue=false)]
        public string StripSize { get; private set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="Uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Gets or Sets VdMemberEps
        /// </summary>
        [DataMember(Name="VdMemberEps", EmitDefaultValue=false)]
        public List<StorageVdMemberEpRef> VdMemberEps { get; set; }

        /// <summary>
        /// Gets or Sets VendorUuid
        /// </summary>
        [DataMember(Name="VendorUuid", EmitDefaultValue=false)]
        public string VendorUuid { get; private set; }

        /// <summary>
        /// A collection of references to the [storage.VirtualDriveExtension](mo://storage.VirtualDriveExtension) Managed Object.  When this managed object is deleted, the referenced [storage.VirtualDriveExtension](mo://storage.VirtualDriveExtension) MO unsets its reference to this deleted MO. 
        /// </summary>
        /// <value>A collection of references to the [storage.VirtualDriveExtension](mo://storage.VirtualDriveExtension) Managed Object.  When this managed object is deleted, the referenced [storage.VirtualDriveExtension](mo://storage.VirtualDriveExtension) MO unsets its reference to this deleted MO. </value>
        [DataMember(Name="VirtualDriveExtension", EmitDefaultValue=false)]
        public StorageVirtualDriveExtensionRef VirtualDriveExtension { get; set; }

        /// <summary>
        /// Gets or Sets VirtualDriveId
        /// </summary>
        [DataMember(Name="VirtualDriveId", EmitDefaultValue=false)]
        public string VirtualDriveId { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageVirtualDrive {\n");
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
            sb.Append("  AccessPolicy: ").Append(AccessPolicy).Append("\n");
            sb.Append("  ActualWriteCachePolicy: ").Append(ActualWriteCachePolicy).Append("\n");
            sb.Append("  AvailableSize: ").Append(AvailableSize).Append("\n");
            sb.Append("  BlockSize: ").Append(BlockSize).Append("\n");
            sb.Append("  Bootable: ").Append(Bootable).Append("\n");
            sb.Append("  ConfigState: ").Append(ConfigState).Append("\n");
            sb.Append("  ConfiguredWriteCachePolicy: ").Append(ConfiguredWriteCachePolicy).Append("\n");
            sb.Append("  ConnectionProtocol: ").Append(ConnectionProtocol).Append("\n");
            sb.Append("  DriveCache: ").Append(DriveCache).Append("\n");
            sb.Append("  DriveSecurity: ").Append(DriveSecurity).Append("\n");
            sb.Append("  DriveState: ").Append(DriveState).Append("\n");
            sb.Append("  IoPolicy: ").Append(IoPolicy).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumBlocks: ").Append(NumBlocks).Append("\n");
            sb.Append("  OperState: ").Append(OperState).Append("\n");
            sb.Append("  Operability: ").Append(Operability).Append("\n");
            sb.Append("  PhysicalBlockSize: ").Append(PhysicalBlockSize).Append("\n");
            sb.Append("  PhysicalDiskUsages: ").Append(PhysicalDiskUsages).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  ReadPolicy: ").Append(ReadPolicy).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  SecurityFlags: ").Append(SecurityFlags).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StorageController: ").Append(StorageController).Append("\n");
            sb.Append("  StripSize: ").Append(StripSize).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  VdMemberEps: ").Append(VdMemberEps).Append("\n");
            sb.Append("  VendorUuid: ").Append(VendorUuid).Append("\n");
            sb.Append("  VirtualDriveExtension: ").Append(VirtualDriveExtension).Append("\n");
            sb.Append("  VirtualDriveId: ").Append(VirtualDriveId).Append("\n");
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
            return this.Equals(obj as StorageVirtualDrive);
        }

        /// <summary>
        /// Returns true if StorageVirtualDrive instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageVirtualDrive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageVirtualDrive other)
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
                    this.AccessPolicy == other.AccessPolicy ||
                    this.AccessPolicy != null &&
                    this.AccessPolicy.Equals(other.AccessPolicy)
                ) && 
                (
                    this.ActualWriteCachePolicy == other.ActualWriteCachePolicy ||
                    this.ActualWriteCachePolicy != null &&
                    this.ActualWriteCachePolicy.Equals(other.ActualWriteCachePolicy)
                ) && 
                (
                    this.AvailableSize == other.AvailableSize ||
                    this.AvailableSize != null &&
                    this.AvailableSize.Equals(other.AvailableSize)
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
                    this.ConfigState == other.ConfigState ||
                    this.ConfigState != null &&
                    this.ConfigState.Equals(other.ConfigState)
                ) && 
                (
                    this.ConfiguredWriteCachePolicy == other.ConfiguredWriteCachePolicy ||
                    this.ConfiguredWriteCachePolicy != null &&
                    this.ConfiguredWriteCachePolicy.Equals(other.ConfiguredWriteCachePolicy)
                ) && 
                (
                    this.ConnectionProtocol == other.ConnectionProtocol ||
                    this.ConnectionProtocol != null &&
                    this.ConnectionProtocol.Equals(other.ConnectionProtocol)
                ) && 
                (
                    this.DriveCache == other.DriveCache ||
                    this.DriveCache != null &&
                    this.DriveCache.Equals(other.DriveCache)
                ) && 
                (
                    this.DriveSecurity == other.DriveSecurity ||
                    this.DriveSecurity != null &&
                    this.DriveSecurity.Equals(other.DriveSecurity)
                ) && 
                (
                    this.DriveState == other.DriveState ||
                    this.DriveState != null &&
                    this.DriveState.Equals(other.DriveState)
                ) && 
                (
                    this.IoPolicy == other.IoPolicy ||
                    this.IoPolicy != null &&
                    this.IoPolicy.Equals(other.IoPolicy)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.NumBlocks == other.NumBlocks ||
                    this.NumBlocks != null &&
                    this.NumBlocks.Equals(other.NumBlocks)
                ) && 
                (
                    this.OperState == other.OperState ||
                    this.OperState != null &&
                    this.OperState.Equals(other.OperState)
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
                    this.PhysicalDiskUsages == other.PhysicalDiskUsages ||
                    this.PhysicalDiskUsages != null &&
                    this.PhysicalDiskUsages.SequenceEqual(other.PhysicalDiskUsages)
                ) && 
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) && 
                (
                    this.ReadPolicy == other.ReadPolicy ||
                    this.ReadPolicy != null &&
                    this.ReadPolicy.Equals(other.ReadPolicy)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.SecurityFlags == other.SecurityFlags ||
                    this.SecurityFlags != null &&
                    this.SecurityFlags.Equals(other.SecurityFlags)
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
                    this.StripSize == other.StripSize ||
                    this.StripSize != null &&
                    this.StripSize.Equals(other.StripSize)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
                ) && 
                (
                    this.VdMemberEps == other.VdMemberEps ||
                    this.VdMemberEps != null &&
                    this.VdMemberEps.SequenceEqual(other.VdMemberEps)
                ) && 
                (
                    this.VendorUuid == other.VendorUuid ||
                    this.VendorUuid != null &&
                    this.VendorUuid.Equals(other.VendorUuid)
                ) && 
                (
                    this.VirtualDriveExtension == other.VirtualDriveExtension ||
                    this.VirtualDriveExtension != null &&
                    this.VirtualDriveExtension.Equals(other.VirtualDriveExtension)
                ) && 
                (
                    this.VirtualDriveId == other.VirtualDriveId ||
                    this.VirtualDriveId != null &&
                    this.VirtualDriveId.Equals(other.VirtualDriveId)
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
                if (this.AccessPolicy != null)
                    hash = hash * 59 + this.AccessPolicy.GetHashCode();
                if (this.ActualWriteCachePolicy != null)
                    hash = hash * 59 + this.ActualWriteCachePolicy.GetHashCode();
                if (this.AvailableSize != null)
                    hash = hash * 59 + this.AvailableSize.GetHashCode();
                if (this.BlockSize != null)
                    hash = hash * 59 + this.BlockSize.GetHashCode();
                if (this.Bootable != null)
                    hash = hash * 59 + this.Bootable.GetHashCode();
                if (this.ConfigState != null)
                    hash = hash * 59 + this.ConfigState.GetHashCode();
                if (this.ConfiguredWriteCachePolicy != null)
                    hash = hash * 59 + this.ConfiguredWriteCachePolicy.GetHashCode();
                if (this.ConnectionProtocol != null)
                    hash = hash * 59 + this.ConnectionProtocol.GetHashCode();
                if (this.DriveCache != null)
                    hash = hash * 59 + this.DriveCache.GetHashCode();
                if (this.DriveSecurity != null)
                    hash = hash * 59 + this.DriveSecurity.GetHashCode();
                if (this.DriveState != null)
                    hash = hash * 59 + this.DriveState.GetHashCode();
                if (this.IoPolicy != null)
                    hash = hash * 59 + this.IoPolicy.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.NumBlocks != null)
                    hash = hash * 59 + this.NumBlocks.GetHashCode();
                if (this.OperState != null)
                    hash = hash * 59 + this.OperState.GetHashCode();
                if (this.Operability != null)
                    hash = hash * 59 + this.Operability.GetHashCode();
                if (this.PhysicalBlockSize != null)
                    hash = hash * 59 + this.PhysicalBlockSize.GetHashCode();
                if (this.PhysicalDiskUsages != null)
                    hash = hash * 59 + this.PhysicalDiskUsages.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
                if (this.ReadPolicy != null)
                    hash = hash * 59 + this.ReadPolicy.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.SecurityFlags != null)
                    hash = hash * 59 + this.SecurityFlags.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.StorageController != null)
                    hash = hash * 59 + this.StorageController.GetHashCode();
                if (this.StripSize != null)
                    hash = hash * 59 + this.StripSize.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
                if (this.VdMemberEps != null)
                    hash = hash * 59 + this.VdMemberEps.GetHashCode();
                if (this.VendorUuid != null)
                    hash = hash * 59 + this.VendorUuid.GetHashCode();
                if (this.VirtualDriveExtension != null)
                    hash = hash * 59 + this.VirtualDriveExtension.GetHashCode();
                if (this.VirtualDriveId != null)
                    hash = hash * 59 + this.VirtualDriveId.GetHashCode();
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
