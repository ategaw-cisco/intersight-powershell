/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-262
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
    /// Mother board of a server 
    /// </summary>
    [DataContract]
    public partial class ComputeBoard :  IEquatable<ComputeBoard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputeBoard" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="ComputeBlade">ComputeBlade.</param>
        /// <param name="ComputeRackUnit">ComputeRackUnit.</param>
        /// <param name="EquipmentTpms">EquipmentTpms.</param>
        /// <param name="GraphicsCards">GraphicsCards.</param>
        /// <param name="MemoryArrays">MemoryArrays.</param>
        /// <param name="Processors">Processors.</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        /// <param name="SecurityUnits">SecurityUnits.</param>
        /// <param name="StorageControllers">StorageControllers.</param>
        /// <param name="StorageFlexFlashControllers">StorageFlexFlashControllers.</param>
        /// <param name="StorageFlexUtilControllers">StorageFlexUtilControllers.</param>
        public ComputeBoard(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), ComputeBladeRef ComputeBlade = default(ComputeBladeRef), ComputeRackUnitRef ComputeRackUnit = default(ComputeRackUnitRef), List<EquipmentTpmRef> EquipmentTpms = default(List<EquipmentTpmRef>), List<GraphicsCardRef> GraphicsCards = default(List<GraphicsCardRef>), List<MemoryArrayRef> MemoryArrays = default(List<MemoryArrayRef>), List<ProcessorUnitRef> Processors = default(List<ProcessorUnitRef>), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef), List<SecurityUnitRef> SecurityUnits = default(List<SecurityUnitRef>), List<StorageControllerRef> StorageControllers = default(List<StorageControllerRef>), List<StorageFlexFlashControllerRef> StorageFlexFlashControllers = default(List<StorageFlexFlashControllerRef>), List<StorageFlexUtilControllerRef> StorageFlexUtilControllers = default(List<StorageFlexUtilControllerRef>))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.ComputeBlade = ComputeBlade;
            this.ComputeRackUnit = ComputeRackUnit;
            this.EquipmentTpms = EquipmentTpms;
            this.GraphicsCards = GraphicsCards;
            this.MemoryArrays = MemoryArrays;
            this.Processors = Processors;
            this.RegisteredDevice = RegisteredDevice;
            this.SecurityUnits = SecurityUnits;
            this.StorageControllers = StorageControllers;
            this.StorageFlexFlashControllers = StorageFlexFlashControllers;
            this.StorageFlexUtilControllers = StorageFlexUtilControllers;
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
        /// Gets or Sets BoardId
        /// </summary>
        [DataMember(Name="BoardId", EmitDefaultValue=false)]
        public long? BoardId { get; private set; }

        /// <summary>
        /// Gets or Sets ComputeBlade
        /// </summary>
        [DataMember(Name="ComputeBlade", EmitDefaultValue=false)]
        public ComputeBladeRef ComputeBlade { get; set; }

        /// <summary>
        /// Gets or Sets ComputeRackUnit
        /// </summary>
        [DataMember(Name="ComputeRackUnit", EmitDefaultValue=false)]
        public ComputeRackUnitRef ComputeRackUnit { get; set; }

        /// <summary>
        /// Gets or Sets CpuTypeController
        /// </summary>
        [DataMember(Name="CpuTypeController", EmitDefaultValue=false)]
        public string CpuTypeController { get; private set; }

        /// <summary>
        /// Gets or Sets EquipmentTpms
        /// </summary>
        [DataMember(Name="EquipmentTpms", EmitDefaultValue=false)]
        public List<EquipmentTpmRef> EquipmentTpms { get; set; }

        /// <summary>
        /// Gets or Sets GraphicsCards
        /// </summary>
        [DataMember(Name="GraphicsCards", EmitDefaultValue=false)]
        public List<GraphicsCardRef> GraphicsCards { get; set; }

        /// <summary>
        /// Gets or Sets MemoryArrays
        /// </summary>
        [DataMember(Name="MemoryArrays", EmitDefaultValue=false)]
        public List<MemoryArrayRef> MemoryArrays { get; set; }

        /// <summary>
        /// Gets or Sets OperPowerState
        /// </summary>
        [DataMember(Name="OperPowerState", EmitDefaultValue=false)]
        public string OperPowerState { get; private set; }

        /// <summary>
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="Presence", EmitDefaultValue=false)]
        public string Presence { get; private set; }

        /// <summary>
        /// Gets or Sets Processors
        /// </summary>
        [DataMember(Name="Processors", EmitDefaultValue=false)]
        public List<ProcessorUnitRef> Processors { get; set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Gets or Sets SecurityUnits
        /// </summary>
        [DataMember(Name="SecurityUnits", EmitDefaultValue=false)]
        public List<SecurityUnitRef> SecurityUnits { get; set; }

        /// <summary>
        /// Gets or Sets StorageControllers
        /// </summary>
        [DataMember(Name="StorageControllers", EmitDefaultValue=false)]
        public List<StorageControllerRef> StorageControllers { get; set; }

        /// <summary>
        /// Gets or Sets StorageFlexFlashControllers
        /// </summary>
        [DataMember(Name="StorageFlexFlashControllers", EmitDefaultValue=false)]
        public List<StorageFlexFlashControllerRef> StorageFlexFlashControllers { get; set; }

        /// <summary>
        /// Gets or Sets StorageFlexUtilControllers
        /// </summary>
        [DataMember(Name="StorageFlexUtilControllers", EmitDefaultValue=false)]
        public List<StorageFlexUtilControllerRef> StorageFlexUtilControllers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeBoard {\n");
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
            sb.Append("  BoardId: ").Append(BoardId).Append("\n");
            sb.Append("  ComputeBlade: ").Append(ComputeBlade).Append("\n");
            sb.Append("  ComputeRackUnit: ").Append(ComputeRackUnit).Append("\n");
            sb.Append("  CpuTypeController: ").Append(CpuTypeController).Append("\n");
            sb.Append("  EquipmentTpms: ").Append(EquipmentTpms).Append("\n");
            sb.Append("  GraphicsCards: ").Append(GraphicsCards).Append("\n");
            sb.Append("  MemoryArrays: ").Append(MemoryArrays).Append("\n");
            sb.Append("  OperPowerState: ").Append(OperPowerState).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  Processors: ").Append(Processors).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
            sb.Append("  SecurityUnits: ").Append(SecurityUnits).Append("\n");
            sb.Append("  StorageControllers: ").Append(StorageControllers).Append("\n");
            sb.Append("  StorageFlexFlashControllers: ").Append(StorageFlexFlashControllers).Append("\n");
            sb.Append("  StorageFlexUtilControllers: ").Append(StorageFlexUtilControllers).Append("\n");
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
            return this.Equals(obj as ComputeBoard);
        }

        /// <summary>
        /// Returns true if ComputeBoard instances are equal
        /// </summary>
        /// <param name="other">Instance of ComputeBoard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComputeBoard other)
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
                    this.BoardId == other.BoardId ||
                    this.BoardId != null &&
                    this.BoardId.Equals(other.BoardId)
                ) && 
                (
                    this.ComputeBlade == other.ComputeBlade ||
                    this.ComputeBlade != null &&
                    this.ComputeBlade.Equals(other.ComputeBlade)
                ) && 
                (
                    this.ComputeRackUnit == other.ComputeRackUnit ||
                    this.ComputeRackUnit != null &&
                    this.ComputeRackUnit.Equals(other.ComputeRackUnit)
                ) && 
                (
                    this.CpuTypeController == other.CpuTypeController ||
                    this.CpuTypeController != null &&
                    this.CpuTypeController.Equals(other.CpuTypeController)
                ) && 
                (
                    this.EquipmentTpms == other.EquipmentTpms ||
                    this.EquipmentTpms != null &&
                    this.EquipmentTpms.SequenceEqual(other.EquipmentTpms)
                ) && 
                (
                    this.GraphicsCards == other.GraphicsCards ||
                    this.GraphicsCards != null &&
                    this.GraphicsCards.SequenceEqual(other.GraphicsCards)
                ) && 
                (
                    this.MemoryArrays == other.MemoryArrays ||
                    this.MemoryArrays != null &&
                    this.MemoryArrays.SequenceEqual(other.MemoryArrays)
                ) && 
                (
                    this.OperPowerState == other.OperPowerState ||
                    this.OperPowerState != null &&
                    this.OperPowerState.Equals(other.OperPowerState)
                ) && 
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) && 
                (
                    this.Processors == other.Processors ||
                    this.Processors != null &&
                    this.Processors.SequenceEqual(other.Processors)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
                ) && 
                (
                    this.SecurityUnits == other.SecurityUnits ||
                    this.SecurityUnits != null &&
                    this.SecurityUnits.SequenceEqual(other.SecurityUnits)
                ) && 
                (
                    this.StorageControllers == other.StorageControllers ||
                    this.StorageControllers != null &&
                    this.StorageControllers.SequenceEqual(other.StorageControllers)
                ) && 
                (
                    this.StorageFlexFlashControllers == other.StorageFlexFlashControllers ||
                    this.StorageFlexFlashControllers != null &&
                    this.StorageFlexFlashControllers.SequenceEqual(other.StorageFlexFlashControllers)
                ) && 
                (
                    this.StorageFlexUtilControllers == other.StorageFlexUtilControllers ||
                    this.StorageFlexUtilControllers != null &&
                    this.StorageFlexUtilControllers.SequenceEqual(other.StorageFlexUtilControllers)
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
                if (this.BoardId != null)
                    hash = hash * 59 + this.BoardId.GetHashCode();
                if (this.ComputeBlade != null)
                    hash = hash * 59 + this.ComputeBlade.GetHashCode();
                if (this.ComputeRackUnit != null)
                    hash = hash * 59 + this.ComputeRackUnit.GetHashCode();
                if (this.CpuTypeController != null)
                    hash = hash * 59 + this.CpuTypeController.GetHashCode();
                if (this.EquipmentTpms != null)
                    hash = hash * 59 + this.EquipmentTpms.GetHashCode();
                if (this.GraphicsCards != null)
                    hash = hash * 59 + this.GraphicsCards.GetHashCode();
                if (this.MemoryArrays != null)
                    hash = hash * 59 + this.MemoryArrays.GetHashCode();
                if (this.OperPowerState != null)
                    hash = hash * 59 + this.OperPowerState.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
                if (this.Processors != null)
                    hash = hash * 59 + this.Processors.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
                if (this.SecurityUnits != null)
                    hash = hash * 59 + this.SecurityUnits.GetHashCode();
                if (this.StorageControllers != null)
                    hash = hash * 59 + this.StorageControllers.GetHashCode();
                if (this.StorageFlexFlashControllers != null)
                    hash = hash * 59 + this.StorageFlexFlashControllers.GetHashCode();
                if (this.StorageFlexUtilControllers != null)
                    hash = hash * 59 + this.StorageFlexUtilControllers.GetHashCode();
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
