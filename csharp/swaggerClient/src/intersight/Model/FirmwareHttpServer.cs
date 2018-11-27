/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-260
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
    /// FirmwareHttpServer
    /// </summary>
    [DataContract]
    public partial class FirmwareHttpServer :  IEquatable<FirmwareHttpServer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareHttpServer" /> class.
        /// </summary>
        /// <param name="LocationLink">HTTP/HTTPS link to the image. Accepted formats http[s]://server-hostname/share/image or http[s]://serverip/share/image.  .</param>
        /// <param name="MountOptions">Mount option as configured on the HTTP server. Empty if nothing is configured.   .</param>
        public FirmwareHttpServer(string LocationLink = default(string), string MountOptions = default(string))
        {
            this.LocationLink = LocationLink;
            this.MountOptions = MountOptions;
        }
        
        /// <summary>
        /// HTTP/HTTPS link to the image. Accepted formats http[s]://server-hostname/share/image or http[s]://serverip/share/image.  
        /// </summary>
        /// <value>HTTP/HTTPS link to the image. Accepted formats http[s]://server-hostname/share/image or http[s]://serverip/share/image.  </value>
        [DataMember(Name="LocationLink", EmitDefaultValue=false)]
        public string LocationLink { get; set; }

        /// <summary>
        /// Mount option as configured on the HTTP server. Empty if nothing is configured.   
        /// </summary>
        /// <value>Mount option as configured on the HTTP server. Empty if nothing is configured.   </value>
        [DataMember(Name="MountOptions", EmitDefaultValue=false)]
        public string MountOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareHttpServer {\n");
            sb.Append("  LocationLink: ").Append(LocationLink).Append("\n");
            sb.Append("  MountOptions: ").Append(MountOptions).Append("\n");
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
            return this.Equals(obj as FirmwareHttpServer);
        }

        /// <summary>
        /// Returns true if FirmwareHttpServer instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareHttpServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareHttpServer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LocationLink == other.LocationLink ||
                    this.LocationLink != null &&
                    this.LocationLink.Equals(other.LocationLink)
                ) && 
                (
                    this.MountOptions == other.MountOptions ||
                    this.MountOptions != null &&
                    this.MountOptions.Equals(other.MountOptions)
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
                if (this.LocationLink != null)
                    hash = hash * 59 + this.LocationLink.GetHashCode();
                if (this.MountOptions != null)
                    hash = hash * 59 + this.MountOptions.GetHashCode();
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
