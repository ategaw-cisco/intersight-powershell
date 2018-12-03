/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-265
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
    /// Abstract class for all physical servers 
    /// </summary>
    [DataContract]
    public partial class ComputePhysical :  IEquatable<ComputePhysical>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComputePhysical" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="FaultSummary">FaultSummary.</param>
        /// <param name="KvmIpAddresses">KvmIpAddresses.</param>
        /// <param name="PlatformType">PlatformType.</param>
        public ComputePhysical(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), long? FaultSummary = default(long?), List<ComputeIpAddress> KvmIpAddresses = default(List<ComputeIpAddress>), string PlatformType = default(string))
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.FaultSummary = FaultSummary;
            this.KvmIpAddresses = KvmIpAddresses;
            this.PlatformType = PlatformType;
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
        /// Gets or Sets AdminPowerState
        /// </summary>
        [DataMember(Name="AdminPowerState", EmitDefaultValue=false)]
        public string AdminPowerState { get; private set; }

        /// <summary>
        /// Gets or Sets AssetTag
        /// </summary>
        [DataMember(Name="AssetTag", EmitDefaultValue=false)]
        public string AssetTag { get; private set; }

        /// <summary>
        /// Gets or Sets AvailableMemory
        /// </summary>
        [DataMember(Name="AvailableMemory", EmitDefaultValue=false)]
        public long? AvailableMemory { get; private set; }

        /// <summary>
        /// Gets or Sets FaultSummary
        /// </summary>
        [DataMember(Name="FaultSummary", EmitDefaultValue=false)]
        public long? FaultSummary { get; set; }

        /// <summary>
        /// Gets or Sets KvmIpAddresses
        /// </summary>
        [DataMember(Name="KvmIpAddresses", EmitDefaultValue=false)]
        public List<ComputeIpAddress> KvmIpAddresses { get; set; }

        /// <summary>
        /// Gets or Sets MemorySpeed
        /// </summary>
        [DataMember(Name="MemorySpeed", EmitDefaultValue=false)]
        public string MemorySpeed { get; private set; }

        /// <summary>
        /// Gets or Sets NumAdaptors
        /// </summary>
        [DataMember(Name="NumAdaptors", EmitDefaultValue=false)]
        public long? NumAdaptors { get; private set; }

        /// <summary>
        /// Gets or Sets NumCpuCores
        /// </summary>
        [DataMember(Name="NumCpuCores", EmitDefaultValue=false)]
        public long? NumCpuCores { get; private set; }

        /// <summary>
        /// Gets or Sets NumCpuCoresEnabled
        /// </summary>
        [DataMember(Name="NumCpuCoresEnabled", EmitDefaultValue=false)]
        public long? NumCpuCoresEnabled { get; private set; }

        /// <summary>
        /// Gets or Sets NumCpus
        /// </summary>
        [DataMember(Name="NumCpus", EmitDefaultValue=false)]
        public long? NumCpus { get; private set; }

        /// <summary>
        /// Gets or Sets NumEthHostInterfaces
        /// </summary>
        [DataMember(Name="NumEthHostInterfaces", EmitDefaultValue=false)]
        public long? NumEthHostInterfaces { get; private set; }

        /// <summary>
        /// Gets or Sets NumFcHostInterfaces
        /// </summary>
        [DataMember(Name="NumFcHostInterfaces", EmitDefaultValue=false)]
        public long? NumFcHostInterfaces { get; private set; }

        /// <summary>
        /// Gets or Sets NumThreads
        /// </summary>
        [DataMember(Name="NumThreads", EmitDefaultValue=false)]
        public long? NumThreads { get; private set; }

        /// <summary>
        /// Gets or Sets OperPowerState
        /// </summary>
        [DataMember(Name="OperPowerState", EmitDefaultValue=false)]
        public string OperPowerState { get; private set; }

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
        /// Gets or Sets PlatformType
        /// </summary>
        [DataMember(Name="PlatformType", EmitDefaultValue=false)]
        public string PlatformType { get; set; }

        /// <summary>
        /// Gets or Sets Presence
        /// </summary>
        [DataMember(Name="Presence", EmitDefaultValue=false)]
        public string Presence { get; private set; }

        /// <summary>
        /// Gets or Sets ServiceProfile
        /// </summary>
        [DataMember(Name="ServiceProfile", EmitDefaultValue=false)]
        public string ServiceProfile { get; private set; }

        /// <summary>
        /// Gets or Sets TotalMemory
        /// </summary>
        [DataMember(Name="TotalMemory", EmitDefaultValue=false)]
        public long? TotalMemory { get; private set; }

        /// <summary>
        /// Gets or Sets UserLabel
        /// </summary>
        [DataMember(Name="UserLabel", EmitDefaultValue=false)]
        public string UserLabel { get; private set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [DataMember(Name="Uuid", EmitDefaultValue=false)]
        public string Uuid { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputePhysical {\n");
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
            sb.Append("  AdminPowerState: ").Append(AdminPowerState).Append("\n");
            sb.Append("  AssetTag: ").Append(AssetTag).Append("\n");
            sb.Append("  AvailableMemory: ").Append(AvailableMemory).Append("\n");
            sb.Append("  FaultSummary: ").Append(FaultSummary).Append("\n");
            sb.Append("  KvmIpAddresses: ").Append(KvmIpAddresses).Append("\n");
            sb.Append("  MemorySpeed: ").Append(MemorySpeed).Append("\n");
            sb.Append("  NumAdaptors: ").Append(NumAdaptors).Append("\n");
            sb.Append("  NumCpuCores: ").Append(NumCpuCores).Append("\n");
            sb.Append("  NumCpuCoresEnabled: ").Append(NumCpuCoresEnabled).Append("\n");
            sb.Append("  NumCpus: ").Append(NumCpus).Append("\n");
            sb.Append("  NumEthHostInterfaces: ").Append(NumEthHostInterfaces).Append("\n");
            sb.Append("  NumFcHostInterfaces: ").Append(NumFcHostInterfaces).Append("\n");
            sb.Append("  NumThreads: ").Append(NumThreads).Append("\n");
            sb.Append("  OperPowerState: ").Append(OperPowerState).Append("\n");
            sb.Append("  OperState: ").Append(OperState).Append("\n");
            sb.Append("  Operability: ").Append(Operability).Append("\n");
            sb.Append("  PlatformType: ").Append(PlatformType).Append("\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  ServiceProfile: ").Append(ServiceProfile).Append("\n");
            sb.Append("  TotalMemory: ").Append(TotalMemory).Append("\n");
            sb.Append("  UserLabel: ").Append(UserLabel).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
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
            return this.Equals(obj as ComputePhysical);
        }

        /// <summary>
        /// Returns true if ComputePhysical instances are equal
        /// </summary>
        /// <param name="other">Instance of ComputePhysical to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComputePhysical other)
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
                    this.AdminPowerState == other.AdminPowerState ||
                    this.AdminPowerState != null &&
                    this.AdminPowerState.Equals(other.AdminPowerState)
                ) && 
                (
                    this.AssetTag == other.AssetTag ||
                    this.AssetTag != null &&
                    this.AssetTag.Equals(other.AssetTag)
                ) && 
                (
                    this.AvailableMemory == other.AvailableMemory ||
                    this.AvailableMemory != null &&
                    this.AvailableMemory.Equals(other.AvailableMemory)
                ) && 
                (
                    this.FaultSummary == other.FaultSummary ||
                    this.FaultSummary != null &&
                    this.FaultSummary.Equals(other.FaultSummary)
                ) && 
                (
                    this.KvmIpAddresses == other.KvmIpAddresses ||
                    this.KvmIpAddresses != null &&
                    this.KvmIpAddresses.SequenceEqual(other.KvmIpAddresses)
                ) && 
                (
                    this.MemorySpeed == other.MemorySpeed ||
                    this.MemorySpeed != null &&
                    this.MemorySpeed.Equals(other.MemorySpeed)
                ) && 
                (
                    this.NumAdaptors == other.NumAdaptors ||
                    this.NumAdaptors != null &&
                    this.NumAdaptors.Equals(other.NumAdaptors)
                ) && 
                (
                    this.NumCpuCores == other.NumCpuCores ||
                    this.NumCpuCores != null &&
                    this.NumCpuCores.Equals(other.NumCpuCores)
                ) && 
                (
                    this.NumCpuCoresEnabled == other.NumCpuCoresEnabled ||
                    this.NumCpuCoresEnabled != null &&
                    this.NumCpuCoresEnabled.Equals(other.NumCpuCoresEnabled)
                ) && 
                (
                    this.NumCpus == other.NumCpus ||
                    this.NumCpus != null &&
                    this.NumCpus.Equals(other.NumCpus)
                ) && 
                (
                    this.NumEthHostInterfaces == other.NumEthHostInterfaces ||
                    this.NumEthHostInterfaces != null &&
                    this.NumEthHostInterfaces.Equals(other.NumEthHostInterfaces)
                ) && 
                (
                    this.NumFcHostInterfaces == other.NumFcHostInterfaces ||
                    this.NumFcHostInterfaces != null &&
                    this.NumFcHostInterfaces.Equals(other.NumFcHostInterfaces)
                ) && 
                (
                    this.NumThreads == other.NumThreads ||
                    this.NumThreads != null &&
                    this.NumThreads.Equals(other.NumThreads)
                ) && 
                (
                    this.OperPowerState == other.OperPowerState ||
                    this.OperPowerState != null &&
                    this.OperPowerState.Equals(other.OperPowerState)
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
                    this.PlatformType == other.PlatformType ||
                    this.PlatformType != null &&
                    this.PlatformType.Equals(other.PlatformType)
                ) && 
                (
                    this.Presence == other.Presence ||
                    this.Presence != null &&
                    this.Presence.Equals(other.Presence)
                ) && 
                (
                    this.ServiceProfile == other.ServiceProfile ||
                    this.ServiceProfile != null &&
                    this.ServiceProfile.Equals(other.ServiceProfile)
                ) && 
                (
                    this.TotalMemory == other.TotalMemory ||
                    this.TotalMemory != null &&
                    this.TotalMemory.Equals(other.TotalMemory)
                ) && 
                (
                    this.UserLabel == other.UserLabel ||
                    this.UserLabel != null &&
                    this.UserLabel.Equals(other.UserLabel)
                ) && 
                (
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
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
                if (this.AdminPowerState != null)
                    hash = hash * 59 + this.AdminPowerState.GetHashCode();
                if (this.AssetTag != null)
                    hash = hash * 59 + this.AssetTag.GetHashCode();
                if (this.AvailableMemory != null)
                    hash = hash * 59 + this.AvailableMemory.GetHashCode();
                if (this.FaultSummary != null)
                    hash = hash * 59 + this.FaultSummary.GetHashCode();
                if (this.KvmIpAddresses != null)
                    hash = hash * 59 + this.KvmIpAddresses.GetHashCode();
                if (this.MemorySpeed != null)
                    hash = hash * 59 + this.MemorySpeed.GetHashCode();
                if (this.NumAdaptors != null)
                    hash = hash * 59 + this.NumAdaptors.GetHashCode();
                if (this.NumCpuCores != null)
                    hash = hash * 59 + this.NumCpuCores.GetHashCode();
                if (this.NumCpuCoresEnabled != null)
                    hash = hash * 59 + this.NumCpuCoresEnabled.GetHashCode();
                if (this.NumCpus != null)
                    hash = hash * 59 + this.NumCpus.GetHashCode();
                if (this.NumEthHostInterfaces != null)
                    hash = hash * 59 + this.NumEthHostInterfaces.GetHashCode();
                if (this.NumFcHostInterfaces != null)
                    hash = hash * 59 + this.NumFcHostInterfaces.GetHashCode();
                if (this.NumThreads != null)
                    hash = hash * 59 + this.NumThreads.GetHashCode();
                if (this.OperPowerState != null)
                    hash = hash * 59 + this.OperPowerState.GetHashCode();
                if (this.OperState != null)
                    hash = hash * 59 + this.OperState.GetHashCode();
                if (this.Operability != null)
                    hash = hash * 59 + this.Operability.GetHashCode();
                if (this.PlatformType != null)
                    hash = hash * 59 + this.PlatformType.GetHashCode();
                if (this.Presence != null)
                    hash = hash * 59 + this.Presence.GetHashCode();
                if (this.ServiceProfile != null)
                    hash = hash * 59 + this.ServiceProfile.GetHashCode();
                if (this.TotalMemory != null)
                    hash = hash * 59 + this.TotalMemory.GetHashCode();
                if (this.UserLabel != null)
                    hash = hash * 59 + this.UserLabel.GetHashCode();
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
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
