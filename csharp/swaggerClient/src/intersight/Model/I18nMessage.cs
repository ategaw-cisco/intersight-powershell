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
    /// An i18n message that can be translated in multiple languages to support internationalization.  An i18n message includes a unique message identifier, a text format string, a list of message parameters that can be used  to substitute parameters, and a translated string based on a user&#39;s locale. 
    /// </summary>
    [DataContract]
    public partial class I18nMessage :  IEquatable<I18nMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="I18nMessage" /> class.
        /// </summary>
        /// <param name="MessageParams">The list of message parameters.   .</param>
        public I18nMessage(List<I18nMessageParam> MessageParams = default(List<I18nMessageParam>))
        {
            this.MessageParams = MessageParams;
        }
        
        /// <summary>
        /// The default (en-US) localized message. Default localized message will be stored and directly retrieved when the user&#39;s locale setting is en-US.   
        /// </summary>
        /// <value>The default (en-US) localized message. Default localized message will be stored and directly retrieved when the user&#39;s locale setting is en-US.   </value>
        [DataMember(Name="Message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// The unique message identitifer used to lookup text templates in a multi-language message catalog.  
        /// </summary>
        /// <value>The unique message identitifer used to lookup text templates in a multi-language message catalog.  </value>
        [DataMember(Name="MessageId", EmitDefaultValue=false)]
        public string MessageId { get; private set; }

        /// <summary>
        /// The list of message parameters.   
        /// </summary>
        /// <value>The list of message parameters.   </value>
        [DataMember(Name="MessageParams", EmitDefaultValue=false)]
        public List<I18nMessageParam> MessageParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class I18nMessage {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageParams: ").Append(MessageParams).Append("\n");
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
            return this.Equals(obj as I18nMessage);
        }

        /// <summary>
        /// Returns true if I18nMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of I18nMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(I18nMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.MessageId == other.MessageId ||
                    this.MessageId != null &&
                    this.MessageId.Equals(other.MessageId)
                ) && 
                (
                    this.MessageParams == other.MessageParams ||
                    this.MessageParams != null &&
                    this.MessageParams.SequenceEqual(other.MessageParams)
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
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.MessageId != null)
                    hash = hash * 59 + this.MessageId.GetHashCode();
                if (this.MessageParams != null)
                    hash = hash * 59 + this.MessageParams.GetHashCode();
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
