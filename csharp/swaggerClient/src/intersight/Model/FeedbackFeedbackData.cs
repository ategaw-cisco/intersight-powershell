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
    /// Feedback data that collected on the ui from user 
    /// </summary>
    [DataContract]
    public partial class FeedbackFeedbackData :  IEquatable<FeedbackFeedbackData>, IValidatableObject
    {
        /// <summary>
        /// evaluation type  
        /// </summary>
        /// <value>evaluation type  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EvaluationEnum
        {
            
            /// <summary>
            /// Enum Excellent for "Excellent"
            /// </summary>
            [EnumMember(Value = "Excellent")]
            Excellent,
            
            /// <summary>
            /// Enum Poor for "Poor"
            /// </summary>
            [EnumMember(Value = "Poor")]
            Poor,
            
            /// <summary>
            /// Enum Fair for "Fair"
            /// </summary>
            [EnumMember(Value = "Fair")]
            Fair,
            
            /// <summary>
            /// Enum Good for "Good"
            /// </summary>
            [EnumMember(Value = "Good")]
            Good
        }

        /// <summary>
        /// Type from user   
        /// </summary>
        /// <value>Type from user   </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Evaluation for "Evaluation"
            /// </summary>
            [EnumMember(Value = "Evaluation")]
            Evaluation,
            
            /// <summary>
            /// Enum Bug for "Bug"
            /// </summary>
            [EnumMember(Value = "Bug")]
            Bug
        }

        /// <summary>
        /// evaluation type  
        /// </summary>
        /// <value>evaluation type  </value>
        [DataMember(Name="Evaluation", EmitDefaultValue=false)]
        public EvaluationEnum? Evaluation { get; set; }
        /// <summary>
        /// Type from user   
        /// </summary>
        /// <value>Type from user   </value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFeedbackData" /> class.
        /// </summary>
        /// <param name="Comment">Text of the feedback  .</param>
        /// <param name="Email">user email  .</param>
        /// <param name="Evaluation">evaluation type   (default to EvaluationEnum.Excellent).</param>
        /// <param name="FollowUp">if user open for follow-up or not  .</param>
        /// <param name="TraceIds">Bunch of last traceId for reproducing user last activity  .</param>
        /// <param name="Type">Type from user    (default to TypeEnum.Evaluation).</param>
        public FeedbackFeedbackData(string Comment = default(string), string Email = default(string), EvaluationEnum? Evaluation = EvaluationEnum.Excellent, bool? FollowUp = default(bool?), Object TraceIds = default(Object), TypeEnum? Type = TypeEnum.Evaluation)
        {
            this.Comment = Comment;
            this.Email = Email;
            // use default value if no "Evaluation" provided
            if (Evaluation == null)
            {
                this.Evaluation = EvaluationEnum.Excellent;
            }
            else
            {
                this.Evaluation = Evaluation;
            }
            this.FollowUp = FollowUp;
            this.TraceIds = TraceIds;
            // use default value if no "Type" provided
            if (Type == null)
            {
                this.Type = TypeEnum.Evaluation;
            }
            else
            {
                this.Type = Type;
            }
        }
        
        /// <summary>
        /// Text of the feedback  
        /// </summary>
        /// <value>Text of the feedback  </value>
        [DataMember(Name="Comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// user email  
        /// </summary>
        /// <value>user email  </value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }


        /// <summary>
        /// if user open for follow-up or not  
        /// </summary>
        /// <value>if user open for follow-up or not  </value>
        [DataMember(Name="FollowUp", EmitDefaultValue=false)]
        public bool? FollowUp { get; set; }

        /// <summary>
        /// Bunch of last traceId for reproducing user last activity  
        /// </summary>
        /// <value>Bunch of last traceId for reproducing user last activity  </value>
        [DataMember(Name="TraceIds", EmitDefaultValue=false)]
        public Object TraceIds { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeedbackFeedbackData {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Evaluation: ").Append(Evaluation).Append("\n");
            sb.Append("  FollowUp: ").Append(FollowUp).Append("\n");
            sb.Append("  TraceIds: ").Append(TraceIds).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as FeedbackFeedbackData);
        }

        /// <summary>
        /// Returns true if FeedbackFeedbackData instances are equal
        /// </summary>
        /// <param name="other">Instance of FeedbackFeedbackData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FeedbackFeedbackData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Comment == other.Comment ||
                    this.Comment != null &&
                    this.Comment.Equals(other.Comment)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Evaluation == other.Evaluation ||
                    this.Evaluation != null &&
                    this.Evaluation.Equals(other.Evaluation)
                ) && 
                (
                    this.FollowUp == other.FollowUp ||
                    this.FollowUp != null &&
                    this.FollowUp.Equals(other.FollowUp)
                ) && 
                (
                    this.TraceIds == other.TraceIds ||
                    this.TraceIds != null &&
                    this.TraceIds.Equals(other.TraceIds)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.Comment != null)
                    hash = hash * 59 + this.Comment.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Evaluation != null)
                    hash = hash * 59 + this.Evaluation.GetHashCode();
                if (this.FollowUp != null)
                    hash = hash * 59 + this.FollowUp.GetHashCode();
                if (this.TraceIds != null)
                    hash = hash * 59 + this.TraceIds.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
