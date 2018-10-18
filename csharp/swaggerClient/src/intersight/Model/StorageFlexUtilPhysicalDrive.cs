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
    /// Storage Flex Util Physical Drive 
    /// </summary>
    [DataContract]
    public partial class StorageFlexUtilPhysicalDrive :  IEquatable<StorageFlexUtilPhysicalDrive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFlexUtilPhysicalDrive" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="BlockSize">BlockSize.</param>
        /// <param name="Capacity">Capacity.</param>
        /// <param name="Controller">Controller.</param>
        /// <param name="DrivesEnabled">DrivesEnabled.</param>
        /// <param name="Health">Health.</param>
        /// <param name="ManufacturerDate">ManufacturerDate.</param>
        /// <param name="ManufacturerId">ManufacturerId.</param>
        /// <param name="OemId">OemId.</param>
        /// <param name="PartitionCount">PartitionCount.</param>
        /// <param name="PdStatus">PdStatus.</param>
        /// <param name="PhysicalDrive">PhysicalDrive.</param>
        /// <param name="ProductName">ProductName.</param>
        /// <param name="ProductRevision">ProductRevision.</param>
        /// <param name="ReadErrorCount">ReadErrorCount.</param>
        /// <param name="ReadErrorThreshold">ReadErrorThreshold.</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        /// <param name="StorageFlexUtilController">StorageFlexUtilController.</param>
        /// <param name="WriteEnabled">WriteEnabled.</param>
        /// <param name="WriteErrorCount">WriteErrorCount.</param>
        /// <param name="WriteErrorThreshold">WriteErrorThreshold.</param>
        public StorageFlexUtilPhysicalDrive(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), string BlockSize = default(string), string Capacity = default(string), string Controller = default(string), string DrivesEnabled = default(string), string Health = default(string), string ManufacturerDate = default(string), string ManufacturerId = default(string), string OemId = default(string), string PartitionCount = default(string), string PdStatus = default(string), string PhysicalDrive = default(string), string ProductName = default(string), string ProductRevision = default(string), string ReadErrorCount = default(string), string ReadErrorThreshold = default(string), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), StorageFlexUtilControllerRef StorageFlexUtilController = default(StorageFlexUtilControllerRef), string WriteEnabled = default(string), string WriteErrorCount = default(string), string WriteErrorThreshold = default(string))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.BlockSize = BlockSize;
            this.Capacity = Capacity;
            this.Controller = Controller;
            this.DrivesEnabled = DrivesEnabled;
            this.Health = Health;
            this.ManufacturerDate = ManufacturerDate;
            this.ManufacturerId = ManufacturerId;
            this.OemId = OemId;
            this.PartitionCount = PartitionCount;
            this.PdStatus = PdStatus;
            this.PhysicalDrive = PhysicalDrive;
            this.ProductName = ProductName;
            this.ProductRevision = ProductRevision;
            this.ReadErrorCount = ReadErrorCount;
            this.ReadErrorThreshold = ReadErrorThreshold;
            this.RegisteredDevice = RegisteredDevice;
            this.StorageFlexUtilController = StorageFlexUtilController;
            this.WriteEnabled = WriteEnabled;
            this.WriteErrorCount = WriteErrorCount;
            this.WriteErrorThreshold = WriteErrorThreshold;
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
        public string BlockSize { get; set; }

        /// <summary>
        /// Gets or Sets Capacity
        /// </summary>
        [DataMember(Name="Capacity", EmitDefaultValue=false)]
        public string Capacity { get; set; }

        /// <summary>
        /// Gets or Sets Controller
        /// </summary>
        [DataMember(Name="Controller", EmitDefaultValue=false)]
        public string Controller { get; set; }

        /// <summary>
        /// Gets or Sets DrivesEnabled
        /// </summary>
        [DataMember(Name="DrivesEnabled", EmitDefaultValue=false)]
        public string DrivesEnabled { get; set; }

        /// <summary>
        /// Gets or Sets Health
        /// </summary>
        [DataMember(Name="Health", EmitDefaultValue=false)]
        public string Health { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerDate
        /// </summary>
        [DataMember(Name="ManufacturerDate", EmitDefaultValue=false)]
        public string ManufacturerDate { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerId
        /// </summary>
        [DataMember(Name="ManufacturerId", EmitDefaultValue=false)]
        public string ManufacturerId { get; set; }

        /// <summary>
        /// Gets or Sets OemId
        /// </summary>
        [DataMember(Name="OemId", EmitDefaultValue=false)]
        public string OemId { get; set; }

        /// <summary>
        /// Gets or Sets PartitionCount
        /// </summary>
        [DataMember(Name="PartitionCount", EmitDefaultValue=false)]
        public string PartitionCount { get; set; }

        /// <summary>
        /// Gets or Sets PdStatus
        /// </summary>
        [DataMember(Name="PdStatus", EmitDefaultValue=false)]
        public string PdStatus { get; set; }

        /// <summary>
        /// Gets or Sets PhysicalDrive
        /// </summary>
        [DataMember(Name="PhysicalDrive", EmitDefaultValue=false)]
        public string PhysicalDrive { get; set; }

        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name="ProductName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductRevision
        /// </summary>
        [DataMember(Name="ProductRevision", EmitDefaultValue=false)]
        public string ProductRevision { get; set; }

        /// <summary>
        /// Gets or Sets ReadErrorCount
        /// </summary>
        [DataMember(Name="ReadErrorCount", EmitDefaultValue=false)]
        public string ReadErrorCount { get; set; }

        /// <summary>
        /// Gets or Sets ReadErrorThreshold
        /// </summary>
        [DataMember(Name="ReadErrorThreshold", EmitDefaultValue=false)]
        public string ReadErrorThreshold { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets StorageFlexUtilController
        /// </summary>
        [DataMember(Name="StorageFlexUtilController", EmitDefaultValue=false)]
        public StorageFlexUtilControllerRef StorageFlexUtilController { get; set; }

        /// <summary>
        /// Gets or Sets WriteEnabled
        /// </summary>
        [DataMember(Name="WriteEnabled", EmitDefaultValue=false)]
        public string WriteEnabled { get; set; }

        /// <summary>
        /// Gets or Sets WriteErrorCount
        /// </summary>
        [DataMember(Name="WriteErrorCount", EmitDefaultValue=false)]
        public string WriteErrorCount { get; set; }

        /// <summary>
        /// Gets or Sets WriteErrorThreshold
        /// </summary>
        [DataMember(Name="WriteErrorThreshold", EmitDefaultValue=false)]
        public string WriteErrorThreshold { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageFlexUtilPhysicalDrive {\n");
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
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Serial: ").Append(Serial).Append("\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  BlockSize: ").Append(BlockSize).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  Controller: ").Append(Controller).Append("\n");
            sb.Append("  DrivesEnabled: ").Append(DrivesEnabled).Append("\n");
            sb.Append("  Health: ").Append(Health).Append("\n");
            sb.Append("  ManufacturerDate: ").Append(ManufacturerDate).Append("\n");
            sb.Append("  ManufacturerId: ").Append(ManufacturerId).Append("\n");
            sb.Append("  OemId: ").Append(OemId).Append("\n");
            sb.Append("  PartitionCount: ").Append(PartitionCount).Append("\n");
            sb.Append("  PdStatus: ").Append(PdStatus).Append("\n");
            sb.Append("  PhysicalDrive: ").Append(PhysicalDrive).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductRevision: ").Append(ProductRevision).Append("\n");
            sb.Append("  ReadErrorCount: ").Append(ReadErrorCount).Append("\n");
            sb.Append("  ReadErrorThreshold: ").Append(ReadErrorThreshold).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  StorageFlexUtilController: ").Append(StorageFlexUtilController).Append("\n");
            sb.Append("  WriteEnabled: ").Append(WriteEnabled).Append("\n");
            sb.Append("  WriteErrorCount: ").Append(WriteErrorCount).Append("\n");
            sb.Append("  WriteErrorThreshold: ").Append(WriteErrorThreshold).Append("\n");
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
            return this.Equals(obj as StorageFlexUtilPhysicalDrive);
        }

        /// <summary>
        /// Returns true if StorageFlexUtilPhysicalDrive instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageFlexUtilPhysicalDrive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageFlexUtilPhysicalDrive other)
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
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.Equals(other.Capacity)
                ) && 
                (
                    this.Controller == other.Controller ||
                    this.Controller != null &&
                    this.Controller.Equals(other.Controller)
                ) && 
                (
                    this.DrivesEnabled == other.DrivesEnabled ||
                    this.DrivesEnabled != null &&
                    this.DrivesEnabled.Equals(other.DrivesEnabled)
                ) && 
                (
                    this.Health == other.Health ||
                    this.Health != null &&
                    this.Health.Equals(other.Health)
                ) && 
                (
                    this.ManufacturerDate == other.ManufacturerDate ||
                    this.ManufacturerDate != null &&
                    this.ManufacturerDate.Equals(other.ManufacturerDate)
                ) && 
                (
                    this.ManufacturerId == other.ManufacturerId ||
                    this.ManufacturerId != null &&
                    this.ManufacturerId.Equals(other.ManufacturerId)
                ) && 
                (
                    this.OemId == other.OemId ||
                    this.OemId != null &&
                    this.OemId.Equals(other.OemId)
                ) && 
                (
                    this.PartitionCount == other.PartitionCount ||
                    this.PartitionCount != null &&
                    this.PartitionCount.Equals(other.PartitionCount)
                ) && 
                (
                    this.PdStatus == other.PdStatus ||
                    this.PdStatus != null &&
                    this.PdStatus.Equals(other.PdStatus)
                ) && 
                (
                    this.PhysicalDrive == other.PhysicalDrive ||
                    this.PhysicalDrive != null &&
                    this.PhysicalDrive.Equals(other.PhysicalDrive)
                ) && 
                (
                    this.ProductName == other.ProductName ||
                    this.ProductName != null &&
                    this.ProductName.Equals(other.ProductName)
                ) && 
                (
                    this.ProductRevision == other.ProductRevision ||
                    this.ProductRevision != null &&
                    this.ProductRevision.Equals(other.ProductRevision)
                ) && 
                (
                    this.ReadErrorCount == other.ReadErrorCount ||
                    this.ReadErrorCount != null &&
                    this.ReadErrorCount.Equals(other.ReadErrorCount)
                ) && 
                (
                    this.ReadErrorThreshold == other.ReadErrorThreshold ||
                    this.ReadErrorThreshold != null &&
                    this.ReadErrorThreshold.Equals(other.ReadErrorThreshold)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.StorageFlexUtilController == other.StorageFlexUtilController ||
                    this.StorageFlexUtilController != null &&
                    this.StorageFlexUtilController.Equals(other.StorageFlexUtilController)
                ) && 
                (
                    this.WriteEnabled == other.WriteEnabled ||
                    this.WriteEnabled != null &&
                    this.WriteEnabled.Equals(other.WriteEnabled)
                ) && 
                (
                    this.WriteErrorCount == other.WriteErrorCount ||
                    this.WriteErrorCount != null &&
                    this.WriteErrorCount.Equals(other.WriteErrorCount)
                ) && 
                (
                    this.WriteErrorThreshold == other.WriteErrorThreshold ||
                    this.WriteErrorThreshold != null &&
                    this.WriteErrorThreshold.Equals(other.WriteErrorThreshold)
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
                if (this.Capacity != null)
                    hash = hash * 59 + this.Capacity.GetHashCode();
                if (this.Controller != null)
                    hash = hash * 59 + this.Controller.GetHashCode();
                if (this.DrivesEnabled != null)
                    hash = hash * 59 + this.DrivesEnabled.GetHashCode();
                if (this.Health != null)
                    hash = hash * 59 + this.Health.GetHashCode();
                if (this.ManufacturerDate != null)
                    hash = hash * 59 + this.ManufacturerDate.GetHashCode();
                if (this.ManufacturerId != null)
                    hash = hash * 59 + this.ManufacturerId.GetHashCode();
                if (this.OemId != null)
                    hash = hash * 59 + this.OemId.GetHashCode();
                if (this.PartitionCount != null)
                    hash = hash * 59 + this.PartitionCount.GetHashCode();
                if (this.PdStatus != null)
                    hash = hash * 59 + this.PdStatus.GetHashCode();
                if (this.PhysicalDrive != null)
                    hash = hash * 59 + this.PhysicalDrive.GetHashCode();
                if (this.ProductName != null)
                    hash = hash * 59 + this.ProductName.GetHashCode();
                if (this.ProductRevision != null)
                    hash = hash * 59 + this.ProductRevision.GetHashCode();
                if (this.ReadErrorCount != null)
                    hash = hash * 59 + this.ReadErrorCount.GetHashCode();
                if (this.ReadErrorThreshold != null)
                    hash = hash * 59 + this.ReadErrorThreshold.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.StorageFlexUtilController != null)
                    hash = hash * 59 + this.StorageFlexUtilController.GetHashCode();
                if (this.WriteEnabled != null)
                    hash = hash * 59 + this.WriteEnabled.GetHashCode();
                if (this.WriteErrorCount != null)
                    hash = hash * 59 + this.WriteErrorCount.GetHashCode();
                if (this.WriteErrorThreshold != null)
                    hash = hash * 59 + this.WriteErrorThreshold.GetHashCode();
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
