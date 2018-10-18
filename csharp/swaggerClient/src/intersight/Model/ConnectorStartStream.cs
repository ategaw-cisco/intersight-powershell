/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-228
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
    /// Start a stream. Cloud services sends the configuration for a stream to be opened within this message. If there already exists a stream with the given ID the connector will return its current sequence number, or if the cloud requests the stream can be rebuilt from scratch. 
    /// </summary>
    [DataContract]
    public partial class ConnectorStartStream :  IEquatable<ConnectorStartStream>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorStartStream" /> class.
        /// </summary>
        /// <param name="StreamName">The requested stream name. Stream names are unique per device endpoint.   .</param>
        /// <param name="BatchSize">The number of outputs from a plugin to collect into a single message. Applicable only to streams that involve polling plugins and plugins which support emitting batchable data. Default value of zero indicates no batching.  .</param>
        /// <param name="ForceRebuild">Flag to force a rebuild of an existing stream. To be used if a stream is unable to recover itself in response to dropped messages.  .</param>
        /// <param name="Input">Input to the plugin to start the start the stream or collect stream messages.  .</param>
        /// <param name="PluginName">The plugin to run the stream on  .</param>
        /// <param name="PollInterval">The desired interval to emit messages from this stream. The stream plugin will poll plugins at this interval to create a stream event.  .</param>
        /// <param name="Priority">The priority level to apply to messages emitted by this stream  .</param>
        /// <param name="ResponseTopic">The topic for the device connector to publish messages to.   .</param>
        public ConnectorStartStream(string StreamName = default(string), long? BatchSize = default(long?), bool? ForceRebuild = default(bool?), byte[] Input = default(byte[]), string PluginName = default(string), long? PollInterval = default(long?), long? Priority = default(long?), string ResponseTopic = default(string))
        {
            this.StreamName = StreamName;
            this.BatchSize = BatchSize;
            this.ForceRebuild = ForceRebuild;
            this.Input = Input;
            this.PluginName = PluginName;
            this.PollInterval = PollInterval;
            this.Priority = Priority;
            this.ResponseTopic = ResponseTopic;
        }
        
        /// <summary>
        /// The requested stream name. Stream names are unique per device endpoint.   
        /// </summary>
        /// <value>The requested stream name. Stream names are unique per device endpoint.   </value>
        [DataMember(Name="StreamName", EmitDefaultValue=false)]
        public string StreamName { get; set; }

        /// <summary>
        /// The number of outputs from a plugin to collect into a single message. Applicable only to streams that involve polling plugins and plugins which support emitting batchable data. Default value of zero indicates no batching.  
        /// </summary>
        /// <value>The number of outputs from a plugin to collect into a single message. Applicable only to streams that involve polling plugins and plugins which support emitting batchable data. Default value of zero indicates no batching.  </value>
        [DataMember(Name="BatchSize", EmitDefaultValue=false)]
        public long? BatchSize { get; set; }

        /// <summary>
        /// Flag to force a rebuild of an existing stream. To be used if a stream is unable to recover itself in response to dropped messages.  
        /// </summary>
        /// <value>Flag to force a rebuild of an existing stream. To be used if a stream is unable to recover itself in response to dropped messages.  </value>
        [DataMember(Name="ForceRebuild", EmitDefaultValue=false)]
        public bool? ForceRebuild { get; set; }

        /// <summary>
        /// Input to the plugin to start the start the stream or collect stream messages.  
        /// </summary>
        /// <value>Input to the plugin to start the start the stream or collect stream messages.  </value>
        [DataMember(Name="Input", EmitDefaultValue=false)]
        public byte[] Input { get; set; }

        /// <summary>
        /// The plugin to run the stream on  
        /// </summary>
        /// <value>The plugin to run the stream on  </value>
        [DataMember(Name="PluginName", EmitDefaultValue=false)]
        public string PluginName { get; set; }

        /// <summary>
        /// The desired interval to emit messages from this stream. The stream plugin will poll plugins at this interval to create a stream event.  
        /// </summary>
        /// <value>The desired interval to emit messages from this stream. The stream plugin will poll plugins at this interval to create a stream event.  </value>
        [DataMember(Name="PollInterval", EmitDefaultValue=false)]
        public long? PollInterval { get; set; }

        /// <summary>
        /// The priority level to apply to messages emitted by this stream  
        /// </summary>
        /// <value>The priority level to apply to messages emitted by this stream  </value>
        [DataMember(Name="Priority", EmitDefaultValue=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// The topic for the device connector to publish messages to.   
        /// </summary>
        /// <value>The topic for the device connector to publish messages to.   </value>
        [DataMember(Name="ResponseTopic", EmitDefaultValue=false)]
        public string ResponseTopic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectorStartStream {\n");
            sb.Append("  StreamName: ").Append(StreamName).Append("\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  ForceRebuild: ").Append(ForceRebuild).Append("\n");
            sb.Append("  Input: ").Append(Input).Append("\n");
            sb.Append("  PluginName: ").Append(PluginName).Append("\n");
            sb.Append("  PollInterval: ").Append(PollInterval).Append("\n");
            sb.Append("  Priority: ").Append(Priority).Append("\n");
            sb.Append("  ResponseTopic: ").Append(ResponseTopic).Append("\n");
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
            return this.Equals(obj as ConnectorStartStream);
        }

        /// <summary>
        /// Returns true if ConnectorStartStream instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectorStartStream to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorStartStream other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StreamName == other.StreamName ||
                    this.StreamName != null &&
                    this.StreamName.Equals(other.StreamName)
                ) && 
                (
                    this.BatchSize == other.BatchSize ||
                    this.BatchSize != null &&
                    this.BatchSize.Equals(other.BatchSize)
                ) && 
                (
                    this.ForceRebuild == other.ForceRebuild ||
                    this.ForceRebuild != null &&
                    this.ForceRebuild.Equals(other.ForceRebuild)
                ) && 
                (
                    this.Input == other.Input ||
                    this.Input != null &&
                    this.Input.Equals(other.Input)
                ) && 
                (
                    this.PluginName == other.PluginName ||
                    this.PluginName != null &&
                    this.PluginName.Equals(other.PluginName)
                ) && 
                (
                    this.PollInterval == other.PollInterval ||
                    this.PollInterval != null &&
                    this.PollInterval.Equals(other.PollInterval)
                ) && 
                (
                    this.Priority == other.Priority ||
                    this.Priority != null &&
                    this.Priority.Equals(other.Priority)
                ) && 
                (
                    this.ResponseTopic == other.ResponseTopic ||
                    this.ResponseTopic != null &&
                    this.ResponseTopic.Equals(other.ResponseTopic)
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
                if (this.StreamName != null)
                    hash = hash * 59 + this.StreamName.GetHashCode();
                if (this.BatchSize != null)
                    hash = hash * 59 + this.BatchSize.GetHashCode();
                if (this.ForceRebuild != null)
                    hash = hash * 59 + this.ForceRebuild.GetHashCode();
                if (this.Input != null)
                    hash = hash * 59 + this.Input.GetHashCode();
                if (this.PluginName != null)
                    hash = hash * 59 + this.PluginName.GetHashCode();
                if (this.PollInterval != null)
                    hash = hash * 59 + this.PollInterval.GetHashCode();
                if (this.Priority != null)
                    hash = hash * 59 + this.Priority.GetHashCode();
                if (this.ResponseTopic != null)
                    hash = hash * 59 + this.ResponseTopic.GetHashCode();
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
