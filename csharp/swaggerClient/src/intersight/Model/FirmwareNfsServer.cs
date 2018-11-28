/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-263
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
    /// FirmwareNfsServer
    /// </summary>
    [DataContract]
    public partial class FirmwareNfsServer :  IEquatable<FirmwareNfsServer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareNfsServer" /> class.
        /// </summary>
        /// <param name="MountOptions">Mount option as configured on the NFS Server. Example:nolock.  .</param>
        /// <param name="RemoteFile">Filename of the image in the remote share location. Example:ucs-c220m5-huu-3.1.2c.iso.  .</param>
        /// <param name="RemoteIp">NFS Server Hostname or IP Address. Example:nfs-server-hostname or 10.10.8.7.  .</param>
        /// <param name="RemoteShare">Directory where the image is stored. Example:/share/subfolder.   .</param>
        public FirmwareNfsServer(string MountOptions = default(string), string RemoteFile = default(string), string RemoteIp = default(string), string RemoteShare = default(string))
        {
            this.MountOptions = MountOptions;
            this.RemoteFile = RemoteFile;
            this.RemoteIp = RemoteIp;
            this.RemoteShare = RemoteShare;
        }
        
        /// <summary>
        /// Mount option as configured on the NFS Server. Example:nolock.  
        /// </summary>
        /// <value>Mount option as configured on the NFS Server. Example:nolock.  </value>
        [DataMember(Name="MountOptions", EmitDefaultValue=false)]
        public string MountOptions { get; set; }

        /// <summary>
        /// Filename of the image in the remote share location. Example:ucs-c220m5-huu-3.1.2c.iso.  
        /// </summary>
        /// <value>Filename of the image in the remote share location. Example:ucs-c220m5-huu-3.1.2c.iso.  </value>
        [DataMember(Name="RemoteFile", EmitDefaultValue=false)]
        public string RemoteFile { get; set; }

        /// <summary>
        /// NFS Server Hostname or IP Address. Example:nfs-server-hostname or 10.10.8.7.  
        /// </summary>
        /// <value>NFS Server Hostname or IP Address. Example:nfs-server-hostname or 10.10.8.7.  </value>
        [DataMember(Name="RemoteIp", EmitDefaultValue=false)]
        public string RemoteIp { get; set; }

        /// <summary>
        /// Directory where the image is stored. Example:/share/subfolder.   
        /// </summary>
        /// <value>Directory where the image is stored. Example:/share/subfolder.   </value>
        [DataMember(Name="RemoteShare", EmitDefaultValue=false)]
        public string RemoteShare { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareNfsServer {\n");
            sb.Append("  MountOptions: ").Append(MountOptions).Append("\n");
            sb.Append("  RemoteFile: ").Append(RemoteFile).Append("\n");
            sb.Append("  RemoteIp: ").Append(RemoteIp).Append("\n");
            sb.Append("  RemoteShare: ").Append(RemoteShare).Append("\n");
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
            return this.Equals(obj as FirmwareNfsServer);
        }

        /// <summary>
        /// Returns true if FirmwareNfsServer instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareNfsServer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareNfsServer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MountOptions == other.MountOptions ||
                    this.MountOptions != null &&
                    this.MountOptions.Equals(other.MountOptions)
                ) && 
                (
                    this.RemoteFile == other.RemoteFile ||
                    this.RemoteFile != null &&
                    this.RemoteFile.Equals(other.RemoteFile)
                ) && 
                (
                    this.RemoteIp == other.RemoteIp ||
                    this.RemoteIp != null &&
                    this.RemoteIp.Equals(other.RemoteIp)
                ) && 
                (
                    this.RemoteShare == other.RemoteShare ||
                    this.RemoteShare != null &&
                    this.RemoteShare.Equals(other.RemoteShare)
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
                if (this.MountOptions != null)
                    hash = hash * 59 + this.MountOptions.GetHashCode();
                if (this.RemoteFile != null)
                    hash = hash * 59 + this.RemoteFile.GetHashCode();
                if (this.RemoteIp != null)
                    hash = hash * 59 + this.RemoteIp.GetHashCode();
                if (this.RemoteShare != null)
                    hash = hash * 59 + this.RemoteShare.GetHashCode();
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
