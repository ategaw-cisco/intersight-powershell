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
    /// VmediaMapping
    /// </summary>
    [DataContract]
    public partial class VmediaMapping :  IEquatable<VmediaMapping>, IValidatableObject
    {
        /// <summary>
        /// Type of Authentication protocol when CIFS is used for communication with the remote server  
        /// </summary>
        /// <value>Type of Authentication protocol when CIFS is used for communication with the remote server  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticationProtocolEnum
        {
            
            /// <summary>
            /// Enum None for "none"
            /// </summary>
            [EnumMember(Value = "none")]
            None,
            
            /// <summary>
            /// Enum Ntlm for "ntlm"
            /// </summary>
            [EnumMember(Value = "ntlm")]
            Ntlm,
            
            /// <summary>
            /// Enum Ntlmi for "ntlmi"
            /// </summary>
            [EnumMember(Value = "ntlmi")]
            Ntlmi,
            
            /// <summary>
            /// Enum Ntlmv2 for "ntlmv2"
            /// </summary>
            [EnumMember(Value = "ntlmv2")]
            Ntlmv2,
            
            /// <summary>
            /// Enum Ntlmv2i for "ntlmv2i"
            /// </summary>
            [EnumMember(Value = "ntlmv2i")]
            Ntlmv2i,
            
            /// <summary>
            /// Enum Ntlmssp for "ntlmssp"
            /// </summary>
            [EnumMember(Value = "ntlmssp")]
            Ntlmssp,
            
            /// <summary>
            /// Enum Ntlmsspi for "ntlmsspi"
            /// </summary>
            [EnumMember(Value = "ntlmsspi")]
            Ntlmsspi
        }

        /// <summary>
        /// Type of remote Virtual Media device  
        /// </summary>
        /// <value>Type of remote Virtual Media device  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeEnum
        {
            
            /// <summary>
            /// Enum Cdd for "cdd"
            /// </summary>
            [EnumMember(Value = "cdd")]
            Cdd,
            
            /// <summary>
            /// Enum Hdd for "hdd"
            /// </summary>
            [EnumMember(Value = "hdd")]
            Hdd
        }

        /// <summary>
        /// Protocol to use to communicate with the remote server  
        /// </summary>
        /// <value>Protocol to use to communicate with the remote server  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MountProtocolEnum
        {
            
            /// <summary>
            /// Enum Nfs for "nfs"
            /// </summary>
            [EnumMember(Value = "nfs")]
            Nfs,
            
            /// <summary>
            /// Enum Cifs for "cifs"
            /// </summary>
            [EnumMember(Value = "cifs")]
            Cifs,
            
            /// <summary>
            /// Enum Http for "http"
            /// </summary>
            [EnumMember(Value = "http")]
            Http,
            
            /// <summary>
            /// Enum Https for "https"
            /// </summary>
            [EnumMember(Value = "https")]
            Https
        }

        /// <summary>
        /// Type of Authentication protocol when CIFS is used for communication with the remote server  
        /// </summary>
        /// <value>Type of Authentication protocol when CIFS is used for communication with the remote server  </value>
        [DataMember(Name="AuthenticationProtocol", EmitDefaultValue=false)]
        public AuthenticationProtocolEnum? AuthenticationProtocol { get; set; }
        /// <summary>
        /// Type of remote Virtual Media device  
        /// </summary>
        /// <value>Type of remote Virtual Media device  </value>
        [DataMember(Name="DeviceType", EmitDefaultValue=false)]
        public DeviceTypeEnum? DeviceType { get; set; }
        /// <summary>
        /// Protocol to use to communicate with the remote server  
        /// </summary>
        /// <value>Protocol to use to communicate with the remote server  </value>
        [DataMember(Name="MountProtocol", EmitDefaultValue=false)]
        public MountProtocolEnum? MountProtocol { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VmediaMapping" /> class.
        /// </summary>
        /// <param name="AuthenticationProtocol">Type of Authentication protocol when CIFS is used for communication with the remote server   (default to AuthenticationProtocolEnum.None).</param>
        /// <param name="DeviceType">Type of remote Virtual Media device   (default to DeviceTypeEnum.Cdd).</param>
        /// <param name="HostName">IP address or hostname of the remote server  .</param>
        /// <param name="IsPasswordSet">IsPasswordSet.</param>
        /// <param name="MountOptions">Mount options for the Virtual Media mapping. The field can be left blank or filled in a comma separated list with the following options.\\n For NFS, supported options are ro, rw, nolock, noexec, soft, port&#x3D;VALUE, timeo&#x3D;VALUE, retry&#x3D;VALUE.\\n For CIFS, supported options are soft, nounix, noserverino, guest.\\n For HTTP/HTTPS, the only supported option is noauto.  .</param>
        /// <param name="MountProtocol">Protocol to use to communicate with the remote server   (default to MountProtocolEnum.Nfs).</param>
        /// <param name="Password">Password associated with the username  .</param>
        /// <param name="RemoteFile">Name of the remote file. It should be of .img format for HDD Virtual Media mapping and .iso format for CDD Virtual Media mapping.  .</param>
        /// <param name="RemotePath">Path to the location of the image on the remote server. Preferred format is /path/.  .</param>
        /// <param name="Username">Username to log in to the remote server  .</param>
        /// <param name="VolumeName">Identity of the image for Virtual Media mapping   .</param>
        public VmediaMapping(AuthenticationProtocolEnum? AuthenticationProtocol = AuthenticationProtocolEnum.None, DeviceTypeEnum? DeviceType = DeviceTypeEnum.Cdd, string HostName = default(string), bool? IsPasswordSet = default(bool?), string MountOptions = default(string), MountProtocolEnum? MountProtocol = MountProtocolEnum.Nfs, string Password = default(string), string RemoteFile = default(string), string RemotePath = default(string), string Username = default(string), string VolumeName = default(string))
        {
            // use default value if no "AuthenticationProtocol" provided
            if (AuthenticationProtocol == null)
            {
                this.AuthenticationProtocol = AuthenticationProtocolEnum.None;
            }
            else
            {
                this.AuthenticationProtocol = AuthenticationProtocol;
            }
            // use default value if no "DeviceType" provided
            if (DeviceType == null)
            {
                this.DeviceType = DeviceTypeEnum.Cdd;
            }
            else
            {
                this.DeviceType = DeviceType;
            }
            this.HostName = HostName;
            this.IsPasswordSet = IsPasswordSet;
            this.MountOptions = MountOptions;
            // use default value if no "MountProtocol" provided
            if (MountProtocol == null)
            {
                this.MountProtocol = MountProtocolEnum.Nfs;
            }
            else
            {
                this.MountProtocol = MountProtocol;
            }
            this.Password = Password;
            this.RemoteFile = RemoteFile;
            this.RemotePath = RemotePath;
            this.Username = Username;
            this.VolumeName = VolumeName;
        }
        


        /// <summary>
        /// IP address or hostname of the remote server  
        /// </summary>
        /// <value>IP address or hostname of the remote server  </value>
        [DataMember(Name="HostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or Sets IsPasswordSet
        /// </summary>
        [DataMember(Name="IsPasswordSet", EmitDefaultValue=false)]
        public bool? IsPasswordSet { get; set; }

        /// <summary>
        /// Mount options for the Virtual Media mapping. The field can be left blank or filled in a comma separated list with the following options.\\n For NFS, supported options are ro, rw, nolock, noexec, soft, port&#x3D;VALUE, timeo&#x3D;VALUE, retry&#x3D;VALUE.\\n For CIFS, supported options are soft, nounix, noserverino, guest.\\n For HTTP/HTTPS, the only supported option is noauto.  
        /// </summary>
        /// <value>Mount options for the Virtual Media mapping. The field can be left blank or filled in a comma separated list with the following options.\\n For NFS, supported options are ro, rw, nolock, noexec, soft, port&#x3D;VALUE, timeo&#x3D;VALUE, retry&#x3D;VALUE.\\n For CIFS, supported options are soft, nounix, noserverino, guest.\\n For HTTP/HTTPS, the only supported option is noauto.  </value>
        [DataMember(Name="MountOptions", EmitDefaultValue=false)]
        public string MountOptions { get; set; }


        /// <summary>
        /// Password associated with the username  
        /// </summary>
        /// <value>Password associated with the username  </value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Name of the remote file. It should be of .img format for HDD Virtual Media mapping and .iso format for CDD Virtual Media mapping.  
        /// </summary>
        /// <value>Name of the remote file. It should be of .img format for HDD Virtual Media mapping and .iso format for CDD Virtual Media mapping.  </value>
        [DataMember(Name="RemoteFile", EmitDefaultValue=false)]
        public string RemoteFile { get; set; }

        /// <summary>
        /// Path to the location of the image on the remote server. Preferred format is /path/.  
        /// </summary>
        /// <value>Path to the location of the image on the remote server. Preferred format is /path/.  </value>
        [DataMember(Name="RemotePath", EmitDefaultValue=false)]
        public string RemotePath { get; set; }

        /// <summary>
        /// Username to log in to the remote server  
        /// </summary>
        /// <value>Username to log in to the remote server  </value>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Identity of the image for Virtual Media mapping   
        /// </summary>
        /// <value>Identity of the image for Virtual Media mapping   </value>
        [DataMember(Name="VolumeName", EmitDefaultValue=false)]
        public string VolumeName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VmediaMapping {\n");
            sb.Append("  AuthenticationProtocol: ").Append(AuthenticationProtocol).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  IsPasswordSet: ").Append(IsPasswordSet).Append("\n");
            sb.Append("  MountOptions: ").Append(MountOptions).Append("\n");
            sb.Append("  MountProtocol: ").Append(MountProtocol).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  RemoteFile: ").Append(RemoteFile).Append("\n");
            sb.Append("  RemotePath: ").Append(RemotePath).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  VolumeName: ").Append(VolumeName).Append("\n");
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
            return this.Equals(obj as VmediaMapping);
        }

        /// <summary>
        /// Returns true if VmediaMapping instances are equal
        /// </summary>
        /// <param name="other">Instance of VmediaMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VmediaMapping other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthenticationProtocol == other.AuthenticationProtocol ||
                    this.AuthenticationProtocol != null &&
                    this.AuthenticationProtocol.Equals(other.AuthenticationProtocol)
                ) && 
                (
                    this.DeviceType == other.DeviceType ||
                    this.DeviceType != null &&
                    this.DeviceType.Equals(other.DeviceType)
                ) && 
                (
                    this.HostName == other.HostName ||
                    this.HostName != null &&
                    this.HostName.Equals(other.HostName)
                ) && 
                (
                    this.IsPasswordSet == other.IsPasswordSet ||
                    this.IsPasswordSet != null &&
                    this.IsPasswordSet.Equals(other.IsPasswordSet)
                ) && 
                (
                    this.MountOptions == other.MountOptions ||
                    this.MountOptions != null &&
                    this.MountOptions.Equals(other.MountOptions)
                ) && 
                (
                    this.MountProtocol == other.MountProtocol ||
                    this.MountProtocol != null &&
                    this.MountProtocol.Equals(other.MountProtocol)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.RemoteFile == other.RemoteFile ||
                    this.RemoteFile != null &&
                    this.RemoteFile.Equals(other.RemoteFile)
                ) && 
                (
                    this.RemotePath == other.RemotePath ||
                    this.RemotePath != null &&
                    this.RemotePath.Equals(other.RemotePath)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.VolumeName == other.VolumeName ||
                    this.VolumeName != null &&
                    this.VolumeName.Equals(other.VolumeName)
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
                if (this.AuthenticationProtocol != null)
                    hash = hash * 59 + this.AuthenticationProtocol.GetHashCode();
                if (this.DeviceType != null)
                    hash = hash * 59 + this.DeviceType.GetHashCode();
                if (this.HostName != null)
                    hash = hash * 59 + this.HostName.GetHashCode();
                if (this.IsPasswordSet != null)
                    hash = hash * 59 + this.IsPasswordSet.GetHashCode();
                if (this.MountOptions != null)
                    hash = hash * 59 + this.MountOptions.GetHashCode();
                if (this.MountProtocol != null)
                    hash = hash * 59 + this.MountProtocol.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.RemoteFile != null)
                    hash = hash * 59 + this.RemoteFile.GetHashCode();
                if (this.RemotePath != null)
                    hash = hash * 59 + this.RemotePath.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.VolumeName != null)
                    hash = hash * 59 + this.VolumeName.GetHashCode();
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
