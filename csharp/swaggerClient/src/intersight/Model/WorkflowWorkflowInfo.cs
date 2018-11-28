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
    /// This MO contains information for a workflow instance 
    /// </summary>
    [DataContract]
    public partial class WorkflowWorkflowInfo :  IEquatable<WorkflowWorkflowInfo>, IValidatableObject
    {
        /// <summary>
        /// The action of the workflow such as start, cancel, retry, pause  
        /// </summary>
        /// <value>The action of the workflow such as start, cancel, retry, pause  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            
            /// <summary>
            /// Enum Start for "Start"
            /// </summary>
            [EnumMember(Value = "Start")]
            Start,
            
            /// <summary>
            /// Enum Pause for "Pause"
            /// </summary>
            [EnumMember(Value = "Pause")]
            Pause,
            
            /// <summary>
            /// Enum Resume for "Resume"
            /// </summary>
            [EnumMember(Value = "Resume")]
            Resume,
            
            /// <summary>
            /// Enum Retry for "Retry"
            /// </summary>
            [EnumMember(Value = "Retry")]
            Retry,
            
            /// <summary>
            /// Enum Cancel for "Cancel"
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel
        }

        /// <summary>
        /// Denotes the reason workflow is in waiting status  
        /// </summary>
        /// <value>Denotes the reason workflow is in waiting status  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WaitReasonEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum GatherTasks for "GatherTasks"
            /// </summary>
            [EnumMember(Value = "GatherTasks")]
            GatherTasks
        }

        /// <summary>
        /// The type of workflow met.  This is derived from the workflow meta this WorkflowInfo refers to  
        /// </summary>
        /// <value>The type of workflow met.  This is derived from the workflow meta this WorkflowInfo refers to  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WorkflowMetaTypeEnum
        {
            
            /// <summary>
            /// Enum SystemDefined for "SystemDefined"
            /// </summary>
            [EnumMember(Value = "SystemDefined")]
            SystemDefined,
            
            /// <summary>
            /// Enum UserDefined for "UserDefined"
            /// </summary>
            [EnumMember(Value = "UserDefined")]
            UserDefined,
            
            /// <summary>
            /// Enum Dynamic for "Dynamic"
            /// </summary>
            [EnumMember(Value = "Dynamic")]
            Dynamic
        }

        /// <summary>
        /// The action of the workflow such as start, cancel, retry, pause  
        /// </summary>
        /// <value>The action of the workflow such as start, cancel, retry, pause  </value>
        [DataMember(Name="Action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
        /// <summary>
        /// Denotes the reason workflow is in waiting status  
        /// </summary>
        /// <value>Denotes the reason workflow is in waiting status  </value>
        [DataMember(Name="WaitReason", EmitDefaultValue=false)]
        public WaitReasonEnum? WaitReason { get; set; }
        /// <summary>
        /// The type of workflow met.  This is derived from the workflow meta this WorkflowInfo refers to  
        /// </summary>
        /// <value>The type of workflow met.  This is derived from the workflow meta this WorkflowInfo refers to  </value>
        [DataMember(Name="WorkflowMetaType", EmitDefaultValue=false)]
        public WorkflowMetaTypeEnum? WorkflowMetaType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowWorkflowInfo" /> class.
        /// </summary>
        /// <param name="Ancestors">Ancestors is an array containing the MO references of the ancestors in the object containment hierarchy. .</param>
        /// <param name="Moid">A unique identifier of this Managed Object instance.  .</param>
        /// <param name="Owners">An array of owners which represent effective ownership of this object.   .</param>
        /// <param name="Parent">The direct ancestor of this managed object in the containment hierarchy. .</param>
        /// <param name="Tags">An array of tags, which allow to add key, value meta-data to managed objects.  .</param>
        /// <param name="VersionContext">The versioning info for this managed object   .</param>
        /// <param name="Account">An account owns the workflow instance .</param>
        /// <param name="Action">The action of the workflow such as start, cancel, retry, pause   (default to ActionEnum.Start).</param>
        /// <param name="Input">An input of the workflow  .</param>
        /// <param name="_Internal">Denotes if this workflow is internal and should be hidden from user view  .</param>
        /// <param name="MetaVersion">This is version of the workflow metadata  .</param>
        /// <param name="Name">A name of the workflow  .</param>
        /// <param name="Output">An output of the workflow  .</param>
        /// <param name="PendingDynamicWorkflowInfo">PendingDynamicWorkflowInfo.</param>
        /// <param name="TaskInfos">TaskInfos.</param>
        /// <param name="WaitReason">Denotes the reason workflow is in waiting status   (default to WaitReasonEnum.None).</param>
        /// <param name="WorkflowCtx">The workflow workflow context which contains initiator and target information  .</param>
        /// <param name="WorkflowMetaType">The type of workflow met.  This is derived from the workflow meta this WorkflowInfo refers to   (default to WorkflowMetaTypeEnum.SystemDefined).</param>
        public WorkflowWorkflowInfo(List<MoBaseMoRef> Ancestors = default(List<MoBaseMoRef>), string Moid = default(string), List<string> Owners = default(List<string>), MoBaseMoRef Parent = default(MoBaseMoRef), List<MoTag> Tags = default(List<MoTag>), MoVersionContext VersionContext = default(MoVersionContext), IamAccountRef Account = default(IamAccountRef), ActionEnum? Action = ActionEnum.Start, Object Input = default(Object), bool? _Internal = default(bool?), long? MetaVersion = default(long?), string Name = default(string), Object Output = default(Object), WorkflowPendingDynamicWorkflowInfoRef PendingDynamicWorkflowInfo = default(WorkflowPendingDynamicWorkflowInfoRef), List<WorkflowTaskInfoRef> TaskInfos = default(List<WorkflowTaskInfoRef>), WaitReasonEnum? WaitReason = WaitReasonEnum.None, Object WorkflowCtx = default(Object), WorkflowMetaTypeEnum? WorkflowMetaType = WorkflowMetaTypeEnum.SystemDefined)
        {
            this.Ancestors = Ancestors;
            this.Moid = Moid;
            this.Owners = Owners;
            this.Parent = Parent;
            this.Tags = Tags;
            this.VersionContext = VersionContext;
            this.Account = Account;
            // use default value if no "Action" provided
            if (Action == null)
            {
                this.Action = ActionEnum.Start;
            }
            else
            {
                this.Action = Action;
            }
            this.Input = Input;
            this._Internal = _Internal;
            this.MetaVersion = MetaVersion;
            this.Name = Name;
            this.Output = Output;
            this.PendingDynamicWorkflowInfo = PendingDynamicWorkflowInfo;
            this.TaskInfos = TaskInfos;
            // use default value if no "WaitReason" provided
            if (WaitReason == null)
            {
                this.WaitReason = WaitReasonEnum.None;
            }
            else
            {
                this.WaitReason = WaitReason;
            }
            this.WorkflowCtx = WorkflowCtx;
            // use default value if no "WorkflowMetaType" provided
            if (WorkflowMetaType == null)
            {
                this.WorkflowMetaType = WorkflowMetaTypeEnum.SystemDefined;
            }
            else
            {
                this.WorkflowMetaType = WorkflowMetaType;
            }
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
        /// An account owns the workflow instance 
        /// </summary>
        /// <value>An account owns the workflow instance </value>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public IamAccountRef Account { get; set; }


        /// <summary>
        /// The time on which the workflow is ended.  
        /// </summary>
        /// <value>The time on which the workflow is ended.  </value>
        [DataMember(Name="EndTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; private set; }

        /// <summary>
        /// An input of the workflow  
        /// </summary>
        /// <value>An input of the workflow  </value>
        [DataMember(Name="Input", EmitDefaultValue=false)]
        public Object Input { get; set; }

        /// <summary>
        /// A workflow instance Id  
        /// </summary>
        /// <value>A workflow instance Id  </value>
        [DataMember(Name="InstId", EmitDefaultValue=false)]
        public string InstId { get; private set; }

        /// <summary>
        /// Denotes if this workflow is internal and should be hidden from user view  
        /// </summary>
        /// <value>Denotes if this workflow is internal and should be hidden from user view  </value>
        [DataMember(Name="Internal", EmitDefaultValue=false)]
        public bool? _Internal { get; set; }

        /// <summary>
        /// This is version of the workflow metadata  
        /// </summary>
        /// <value>This is version of the workflow metadata  </value>
        [DataMember(Name="MetaVersion", EmitDefaultValue=false)]
        public long? MetaVersion { get; set; }

        /// <summary>
        /// A name of the workflow  
        /// </summary>
        /// <value>A name of the workflow  </value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// An output of the workflow  
        /// </summary>
        /// <value>An output of the workflow  </value>
        [DataMember(Name="Output", EmitDefaultValue=false)]
        public Object Output { get; set; }

        /// <summary>
        /// Gets or Sets PendingDynamicWorkflowInfo
        /// </summary>
        [DataMember(Name="PendingDynamicWorkflowInfo", EmitDefaultValue=false)]
        public WorkflowPendingDynamicWorkflowInfoRef PendingDynamicWorkflowInfo { get; set; }

        /// <summary>
        /// This field indicates percetage of workflow task execution   
        /// </summary>
        /// <value>This field indicates percetage of workflow task execution   </value>
        [DataMember(Name="Progress", EmitDefaultValue=false)]
        public float? Progress { get; private set; }

        /// <summary>
        /// The source microservice name  
        /// </summary>
        /// <value>The source microservice name  </value>
        [DataMember(Name="Src", EmitDefaultValue=false)]
        public string Src { get; private set; }

        /// <summary>
        /// The time on which the workflow is started.  
        /// </summary>
        /// <value>The time on which the workflow is started.  </value>
        [DataMember(Name="StartTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; private set; }

        /// <summary>
        /// A status of the workflow (RUNNING, WAITING, COMPLETED, TIME_OUT, FAILED)  
        /// </summary>
        /// <value>A status of the workflow (RUNNING, WAITING, COMPLETED, TIME_OUT, FAILED)  </value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or Sets TaskInfos
        /// </summary>
        [DataMember(Name="TaskInfos", EmitDefaultValue=false)]
        public List<WorkflowTaskInfoRef> TaskInfos { get; set; }

        /// <summary>
        /// A type of the workflow (serverconfig, ansible_monitoring)  
        /// </summary>
        /// <value>A type of the workflow (serverconfig, ansible_monitoring)  </value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="UserId", EmitDefaultValue=false)]
        public string UserId { get; private set; }


        /// <summary>
        /// The workflow workflow context which contains initiator and target information  
        /// </summary>
        /// <value>The workflow workflow context which contains initiator and target information  </value>
        [DataMember(Name="WorkflowCtx", EmitDefaultValue=false)]
        public Object WorkflowCtx { get; set; }

        /// <summary>
        /// This key contains workflow, initiator and target name. Fusion uses the key to do workflow dedup  
        /// </summary>
        /// <value>This key contains workflow, initiator and target name. Fusion uses the key to do workflow dedup  </value>
        [DataMember(Name="WorkflowKey", EmitDefaultValue=false)]
        public string WorkflowKey { get; private set; }


        /// <summary>
        /// This attribute captures total workflow tasks   
        /// </summary>
        /// <value>This attribute captures total workflow tasks   </value>
        [DataMember(Name="WorkflowTaskCount", EmitDefaultValue=false)]
        public long? WorkflowTaskCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowWorkflowInfo {\n");
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
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  InstId: ").Append(InstId).Append("\n");
            sb.Append("  _Internal: ").Append(_Internal).Append("\n");
            sb.Append("  MetaVersion: ").Append(MetaVersion).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("  PendingDynamicWorkflowInfo: ").Append(PendingDynamicWorkflowInfo).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Src: ").Append(Src).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaskInfos: ").Append(TaskInfos).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  WaitReason: ").Append(WaitReason).Append("\n");
            sb.Append("  WorkflowCtx: ").Append(WorkflowCtx).Append("\n");
            sb.Append("  WorkflowKey: ").Append(WorkflowKey).Append("\n");
            sb.Append("  WorkflowMetaType: ").Append(WorkflowMetaType).Append("\n");
            sb.Append("  WorkflowTaskCount: ").Append(WorkflowTaskCount).Append("\n");
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
            return this.Equals(obj as WorkflowWorkflowInfo);
        }

        /// <summary>
        /// Returns true if WorkflowWorkflowInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowWorkflowInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowWorkflowInfo other)
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
                    this.Account == other.Account ||
                    this.Account != null &&
                    this.Account.Equals(other.Account)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) && 
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
                ) && 
                (
                    this.InstId == other.InstId ||
                    this.InstId != null &&
                    this.InstId.Equals(other.InstId)
                ) && 
                (
                    this._Internal == other._Internal ||
                    this._Internal != null &&
                    this._Internal.Equals(other._Internal)
                ) && 
                (
                    this.MetaVersion == other.MetaVersion ||
                    this.MetaVersion != null &&
                    this.MetaVersion.Equals(other.MetaVersion)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Output == other.Output ||
                    this.Output != null &&
                    this.Output.Equals(other.Output)
                ) && 
                (
                    this.PendingDynamicWorkflowInfo == other.PendingDynamicWorkflowInfo ||
                    this.PendingDynamicWorkflowInfo != null &&
                    this.PendingDynamicWorkflowInfo.Equals(other.PendingDynamicWorkflowInfo)
                ) && 
                (
                    this.Progress == other.Progress ||
                    this.Progress != null &&
                    this.Progress.Equals(other.Progress)
                ) && 
                (
                    this.Src == other.Src ||
                    this.Src != null &&
                    this.Src.Equals(other.Src)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.TaskInfos == other.TaskInfos ||
                    this.TaskInfos != null &&
                    this.TaskInfos.SequenceEqual(other.TaskInfos)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.WaitReason == other.WaitReason ||
                    this.WaitReason != null &&
                    this.WaitReason.Equals(other.WaitReason)
                ) && 
                (
                    this.WorkflowCtx == other.WorkflowCtx ||
                    this.WorkflowCtx != null &&
                    this.WorkflowCtx.Equals(other.WorkflowCtx)
                ) && 
                (
                    this.WorkflowKey == other.WorkflowKey ||
                    this.WorkflowKey != null &&
                    this.WorkflowKey.Equals(other.WorkflowKey)
                ) && 
                (
                    this.WorkflowMetaType == other.WorkflowMetaType ||
                    this.WorkflowMetaType != null &&
                    this.WorkflowMetaType.Equals(other.WorkflowMetaType)
                ) && 
                (
                    this.WorkflowTaskCount == other.WorkflowTaskCount ||
                    this.WorkflowTaskCount != null &&
                    this.WorkflowTaskCount.Equals(other.WorkflowTaskCount)
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
                if (this.Account != null)
                    hash = hash * 59 + this.Account.GetHashCode();
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                if (this.InstId != null)
                    hash = hash * 59 + this.InstId.GetHashCode();
                if (this._Internal != null)
                    hash = hash * 59 + this._Internal.GetHashCode();
                if (this.MetaVersion != null)
                    hash = hash * 59 + this.MetaVersion.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Output != null)
                    hash = hash * 59 + this.Output.GetHashCode();
                if (this.PendingDynamicWorkflowInfo != null)
                    hash = hash * 59 + this.PendingDynamicWorkflowInfo.GetHashCode();
                if (this.Progress != null)
                    hash = hash * 59 + this.Progress.GetHashCode();
                if (this.Src != null)
                    hash = hash * 59 + this.Src.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.TaskInfos != null)
                    hash = hash * 59 + this.TaskInfos.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.WaitReason != null)
                    hash = hash * 59 + this.WaitReason.GetHashCode();
                if (this.WorkflowCtx != null)
                    hash = hash * 59 + this.WorkflowCtx.GetHashCode();
                if (this.WorkflowKey != null)
                    hash = hash * 59 + this.WorkflowKey.GetHashCode();
                if (this.WorkflowMetaType != null)
                    hash = hash * 59 + this.WorkflowMetaType.GetHashCode();
                if (this.WorkflowTaskCount != null)
                    hash = hash * 59 + this.WorkflowTaskCount.GetHashCode();
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
