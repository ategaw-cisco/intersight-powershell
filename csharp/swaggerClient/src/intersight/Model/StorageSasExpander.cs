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
    /// SAS Expander 
    /// </summary>
    [DataContract]
    public partial class StorageSasExpander :  IEquatable<StorageSasExpander>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageSasExpander" /> class.
        /// </summary>
        /// <param name="Ancestors">The array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">The unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">The array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">The array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object.   .</param>
        /// <param name="Controller">Controller.</param>
        /// <param name="EquipmentChassis">A collection of references to the [equipment.Chassis](mo://equipment.Chassis) Managed Object.  When this managed object is deleted, the referenced [equipment.Chassis](mo://equipment.Chassis) MO unsets its reference to this deleted MO. .</param>
        /// <param name="Name">Name.</param>
        /// <param name="RegisteredDevice">RegisteredDevice.</param>
        public StorageSasExpander(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), ManagementControllerRef Controller = default(ManagementControllerRef), EquipmentChassisRef EquipmentChassis = default(EquipmentChassisRef), string Name = default(string), AssetDeviceRegistrationRef RegisteredDevice = default(AssetDeviceRegistrationRef))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Controller = Controller;
            this.EquipmentChassis = EquipmentChassis;
            this.Name = Name;
            this.RegisteredDevice = RegisteredDevice;
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
        /// Gets or Sets Controller
        /// </summary>
        [DataMember(Name="Controller", EmitDefaultValue=false)]
        public ManagementControllerRef Controller { get; set; }

        /// <summary>
        /// A collection of references to the [equipment.Chassis](mo://equipment.Chassis) Managed Object.  When this managed object is deleted, the referenced [equipment.Chassis](mo://equipment.Chassis) MO unsets its reference to this deleted MO. 
        /// </summary>
        /// <value>A collection of references to the [equipment.Chassis](mo://equipment.Chassis) Managed Object.  When this managed object is deleted, the referenced [equipment.Chassis](mo://equipment.Chassis) MO unsets its reference to this deleted MO. </value>
        [DataMember(Name="EquipmentChassis", EmitDefaultValue=false)]
        public EquipmentChassisRef EquipmentChassis { get; set; }

        /// <summary>
        /// Gets or Sets ExpanderId
        /// </summary>
        [DataMember(Name="ExpanderId", EmitDefaultValue=false)]
        public long? ExpanderId { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="Presence", EmitDefaultValue=false)]
        public string Presence { get; private set; }

        /// <summary>
        /// Gets or Sets RegisteredDevice
        /// </summary>
        [DataMember(Name="RegisteredDevice", EmitDefaultValue=false)]
        public AssetDeviceRegistrationRef RegisteredDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageSasExpander {\n");
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
            sb.Append("  Controller: ").Append(Controller).Append("\n");
            sb.Append("  EquipmentChassis: ").Append(EquipmentChassis).Append("\n");
            sb.Append("  ExpanderId: ").Append(ExpanderId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OperState: ").Append(OperState).Append("\n");
            sb.Append("  Operability: ").Append(Operability).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  RegisteredDevice: ").Append(RegisteredDevice).Append("\n");
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
            return this.Equals(obj as StorageSasExpander);
        }

        /// <summary>
        /// Returns true if StorageSasExpander instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageSasExpander to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageSasExpander other)
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
                    this.Controller == other.Controller ||
                    this.Controller != null &&
                    this.Controller.Equals(other.Controller)
                ) && 
                (
                    this.EquipmentChassis == other.EquipmentChassis ||
                    this.EquipmentChassis != null &&
                    this.EquipmentChassis.Equals(other.EquipmentChassis)
                ) && 
                (
                    this.ExpanderId == other.ExpanderId ||
                    this.ExpanderId != null &&
                    this.ExpanderId.Equals(other.ExpanderId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) && 
                (
                    this.RegisteredDevice == other.RegisteredDevice ||
                    this.RegisteredDevice != null &&
                    this.RegisteredDevice.Equals(other.RegisteredDevice)
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
                if (this.Controller != null)
                    hash = hash * 59 + this.Controller.GetHashCode();
                if (this.EquipmentChassis != null)
                    hash = hash * 59 + this.EquipmentChassis.GetHashCode();
                if (this.ExpanderId != null)
                    hash = hash * 59 + this.ExpanderId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.OperState != null)
                    hash = hash * 59 + this.OperState.GetHashCode();
                if (this.Operability != null)
                    hash = hash * 59 + this.Operability.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
                if (this.RegisteredDevice != null)
                    hash = hash * 59 + this.RegisteredDevice.GetHashCode();
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
