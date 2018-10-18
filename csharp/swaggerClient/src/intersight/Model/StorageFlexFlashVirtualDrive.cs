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
    /// Virtual Drive repersenting a SD Card 
    /// </summary>
    [DataContract]
    public partial class StorageFlexFlashVirtualDrive :  IEquatable<StorageFlexFlashVirtualDrive>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageFlexFlashVirtualDrive" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.   .</param>
        /// <param name="DriveScope">DriveScope.</param>
        /// <param name="DriveStatus">DriveStatus.</param>
        /// <param name="PartitionId">PartitionId.</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        /// <param name="ResidentImage">ResidentImage.</param>
        /// <param name="Size">Size.</param>
        /// <param name="StorageFlexFlashController">StorageFlexFlashController.</param>
        /// <param name="VirtualDrive">VirtualDrive.</param>
        public StorageFlexFlashVirtualDrive(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), string DriveScope = default(string), string DriveStatus = default(string), string PartitionId = default(string), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), string ResidentImage = default(string), string Size = default(string), StorageFlexFlashControllerRef StorageFlexFlashController = default(StorageFlexFlashControllerRef), string VirtualDrive = default(string))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.DriveScope = DriveScope;
            this.DriveStatus = DriveStatus;
            this.PartitionId = PartitionId;
            this.RegisteredDevice = RegisteredDevice;
            this.ResidentImage = ResidentImage;
            this.Size = Size;
            this.StorageFlexFlashController = StorageFlexFlashController;
            this.VirtualDrive = VirtualDrive;
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
        /// Gets or Sets DriveScope
        /// </summary>
        [DataMember(Name="DriveScope", EmitDefaultValue=false)]
        public string DriveScope { get; set; }

        /// <summary>
        /// Gets or Sets DriveStatus
        /// </summary>
        [DataMember(Name="DriveStatus", EmitDefaultValue=false)]
        public string DriveStatus { get; set; }

        /// <summary>
        /// Gets or Sets PartitionId
        /// </summary>
        [DataMember(Name="PartitionId", EmitDefaultValue=false)]
        public string PartitionId { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets ResidentImage
        /// </summary>
        [DataMember(Name="ResidentImage", EmitDefaultValue=false)]
        public string ResidentImage { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="Size", EmitDefaultValue=false)]
        public string Size { get; set; }

        /// <summary>
        /// Gets or Sets StorageFlexFlashController
        /// </summary>
        [DataMember(Name="StorageFlexFlashController", EmitDefaultValue=false)]
        public StorageFlexFlashControllerRef StorageFlexFlashController { get; set; }

        /// <summary>
        /// Gets or Sets VirtualDrive
        /// </summary>
        [DataMember(Name="VirtualDrive", EmitDefaultValue=false)]
        public string VirtualDrive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageFlexFlashVirtualDrive {\n");
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
            sb.Append("  DriveScope: ").Append(DriveScope).Append("\n");
            sb.Append("  DriveStatus: ").Append(DriveStatus).Append("\n");
            sb.Append("  PartitionId: ").Append(PartitionId).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  ResidentImage: ").Append(ResidentImage).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  StorageFlexFlashController: ").Append(StorageFlexFlashController).Append("\n");
            sb.Append("  VirtualDrive: ").Append(VirtualDrive).Append("\n");
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
            return this.Equals(obj as StorageFlexFlashVirtualDrive);
        }

        /// <summary>
        /// Returns true if StorageFlexFlashVirtualDrive instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageFlexFlashVirtualDrive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageFlexFlashVirtualDrive other)
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
                    this.DriveScope == other.DriveScope ||
                    this.DriveScope != null &&
                    this.DriveScope.Equals(other.DriveScope)
                ) && 
                (
                    this.DriveStatus == other.DriveStatus ||
                    this.DriveStatus != null &&
                    this.DriveStatus.Equals(other.DriveStatus)
                ) && 
                (
                    this.PartitionId == other.PartitionId ||
                    this.PartitionId != null &&
                    this.PartitionId.Equals(other.PartitionId)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.ResidentImage == other.ResidentImage ||
                    this.ResidentImage != null &&
                    this.ResidentImage.Equals(other.ResidentImage)
                ) && 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.StorageFlexFlashController == other.StorageFlexFlashController ||
                    this.StorageFlexFlashController != null &&
                    this.StorageFlexFlashController.Equals(other.StorageFlexFlashController)
                ) && 
                (
                    this.VirtualDrive == other.VirtualDrive ||
                    this.VirtualDrive != null &&
                    this.VirtualDrive.Equals(other.VirtualDrive)
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
                if (this.DriveScope != null)
                    hash = hash * 59 + this.DriveScope.GetHashCode();
                if (this.DriveStatus != null)
                    hash = hash * 59 + this.DriveStatus.GetHashCode();
                if (this.PartitionId != null)
                    hash = hash * 59 + this.PartitionId.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.ResidentImage != null)
                    hash = hash * 59 + this.ResidentImage.GetHashCode();
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.StorageFlexFlashController != null)
                    hash = hash * 59 + this.StorageFlexFlashController.GetHashCode();
                if (this.VirtualDrive != null)
                    hash = hash * 59 + this.VirtualDrive.GetHashCode();
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
