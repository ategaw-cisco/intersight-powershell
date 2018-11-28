/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-264
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
    /// FirmwareNetworkShare
    /// </summary>
    [DataContract]
    public partial class FirmwareNetworkShare :  IEquatable<FirmwareNetworkShare>, IValidatableObject
    {
        /// <summary>
        /// File server protocols like CIFS, NFS, WWW for HTTP(S) that hosts the image  
        /// </summary>
        /// <value>File server protocols like CIFS, NFS, WWW for HTTP(S) that hosts the image  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MapTypeEnum
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
            /// Enum Www for "www"
            /// </summary>
            [EnumMember(Value = "www")]
            Www
        }

        /// <summary>
        /// Option to control the upgrade, e.g., 1) nw_upgrade_mount_only - mount the image from a file server and run upgrade on-next server boot 2) nw_upgrade_full - mount the image and run upgrade immediately  
        /// </summary>
        /// <value>Option to control the upgrade, e.g., 1) nw_upgrade_mount_only - mount the image from a file server and run upgrade on-next server boot 2) nw_upgrade_full - mount the image and run upgrade immediately  </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UpgradeoptionEnum
        {
            
            /// <summary>
            /// Enum Full for "nw_upgrade_full"
            /// </summary>
            [EnumMember(Value = "nw_upgrade_full")]
            Full,
            
            /// <summary>
            /// Enum Mountonly for "nw_upgrade_mount_only"
            /// </summary>
            [EnumMember(Value = "nw_upgrade_mount_only")]
            Mountonly
        }

        /// <summary>
        /// File server protocols like CIFS, NFS, WWW for HTTP(S) that hosts the image  
        /// </summary>
        /// <value>File server protocols like CIFS, NFS, WWW for HTTP(S) that hosts the image  </value>
        [DataMember(Name="MapType", EmitDefaultValue=false)]
        public MapTypeEnum? MapType { get; set; }
        /// <summary>
        /// Option to control the upgrade, e.g., 1) nw_upgrade_mount_only - mount the image from a file server and run upgrade on-next server boot 2) nw_upgrade_full - mount the image and run upgrade immediately  
        /// </summary>
        /// <value>Option to control the upgrade, e.g., 1) nw_upgrade_mount_only - mount the image from a file server and run upgrade on-next server boot 2) nw_upgrade_full - mount the image and run upgrade immediately  </value>
        [DataMember(Name="Upgradeoption", EmitDefaultValue=false)]
        public UpgradeoptionEnum? Upgradeoption { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FirmwareNetworkShare" /> class.
        /// </summary>
        /// <param name="CifsServer">CIFS file server option  .</param>
        /// <param name="HttpServer">HTTP(for WWW) file server option  .</param>
        /// <param name="IsPasswordSet">IsPasswordSet.</param>
        /// <param name="MapType">File server protocols like CIFS, NFS, WWW for HTTP(S) that hosts the image   (default to MapTypeEnum.Nfs).</param>
        /// <param name="NfsServer">NFS file server option  .</param>
        /// <param name="Password">Password as configured on the file server  .</param>
        /// <param name="Upgradeoption">Option to control the upgrade, e.g., 1) nw_upgrade_mount_only - mount the image from a file server and run upgrade on-next server boot 2) nw_upgrade_full - mount the image and run upgrade immediately   (default to UpgradeoptionEnum.Full).</param>
        /// <param name="Username">Username as configured on the file server   .</param>
        public FirmwareNetworkShare(FirmwareCifsServer CifsServer = default(FirmwareCifsServer), FirmwareHttpServer HttpServer = default(FirmwareHttpServer), bool? IsPasswordSet = default(bool?), MapTypeEnum? MapType = MapTypeEnum.Nfs, FirmwareNfsServer NfsServer = default(FirmwareNfsServer), string Password = default(string), UpgradeoptionEnum? Upgradeoption = UpgradeoptionEnum.Full, string Username = default(string))
        {
            this.CifsServer = CifsServer;
            this.HttpServer = HttpServer;
            this.IsPasswordSet = IsPasswordSet;
            // use default value if no "MapType" provided
            if (MapType == null)
            {
                this.MapType = MapTypeEnum.Nfs;
            }
            else
            {
                this.MapType = MapType;
            }
            this.NfsServer = NfsServer;
            this.Password = Password;
            // use default value if no "Upgradeoption" provided
            if (Upgradeoption == null)
            {
                this.Upgradeoption = UpgradeoptionEnum.Full;
            }
            else
            {
                this.Upgradeoption = Upgradeoption;
            }
            this.Username = Username;
        }
        
        /// <summary>
        /// CIFS file server option  
        /// </summary>
        /// <value>CIFS file server option  </value>
        [DataMember(Name="CifsServer", EmitDefaultValue=false)]
        public FirmwareCifsServer CifsServer { get; set; }

        /// <summary>
        /// HTTP(for WWW) file server option  
        /// </summary>
        /// <value>HTTP(for WWW) file server option  </value>
        [DataMember(Name="HttpServer", EmitDefaultValue=false)]
        public FirmwareHttpServer HttpServer { get; set; }

        /// <summary>
        /// Gets or Sets IsPasswordSet
        /// </summary>
        [DataMember(Name="IsPasswordSet", EmitDefaultValue=false)]
        public bool? IsPasswordSet { get; set; }


        /// <summary>
        /// NFS file server option  
        /// </summary>
        /// <value>NFS file server option  </value>
        [DataMember(Name="NfsServer", EmitDefaultValue=false)]
        public FirmwareNfsServer NfsServer { get; set; }

        /// <summary>
        /// Password as configured on the file server  
        /// </summary>
        /// <value>Password as configured on the file server  </value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }


        /// <summary>
        /// Username as configured on the file server   
        /// </summary>
        /// <value>Username as configured on the file server   </value>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirmwareNetworkShare {\n");
            sb.Append("  CifsServer: ").Append(CifsServer).Append("\n");
            sb.Append("  HttpServer: ").Append(HttpServer).Append("\n");
            sb.Append("  IsPasswordSet: ").Append(IsPasswordSet).Append("\n");
            sb.Append("  MapType: ").Append(MapType).Append("\n");
            sb.Append("  NfsServer: ").Append(NfsServer).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Upgradeoption: ").Append(Upgradeoption).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(obj as FirmwareNetworkShare);
        }

        /// <summary>
        /// Returns true if FirmwareNetworkShare instances are equal
        /// </summary>
        /// <param name="other">Instance of FirmwareNetworkShare to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FirmwareNetworkShare other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CifsServer == other.CifsServer ||
                    this.CifsServer != null &&
                    this.CifsServer.Equals(other.CifsServer)
                ) && 
                (
                    this.HttpServer == other.HttpServer ||
                    this.HttpServer != null &&
                    this.HttpServer.Equals(other.HttpServer)
                ) && 
                (
                    this.IsPasswordSet == other.IsPasswordSet ||
                    this.IsPasswordSet != null &&
                    this.IsPasswordSet.Equals(other.IsPasswordSet)
                ) && 
                (
                    this.MapType == other.MapType ||
                    this.MapType != null &&
                    this.MapType.Equals(other.MapType)
                ) && 
                (
                    this.NfsServer == other.NfsServer ||
                    this.NfsServer != null &&
                    this.NfsServer.Equals(other.NfsServer)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Upgradeoption == other.Upgradeoption ||
                    this.Upgradeoption != null &&
                    this.Upgradeoption.Equals(other.Upgradeoption)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
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
                if (this.CifsServer != null)
                    hash = hash * 59 + this.CifsServer.GetHashCode();
                if (this.HttpServer != null)
                    hash = hash * 59 + this.HttpServer.GetHashCode();
                if (this.IsPasswordSet != null)
                    hash = hash * 59 + this.IsPasswordSet.GetHashCode();
                if (this.MapType != null)
                    hash = hash * 59 + this.MapType.GetHashCode();
                if (this.NfsServer != null)
                    hash = hash * 59 + this.NfsServer.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Upgradeoption != null)
                    hash = hash * 59 + this.Upgradeoption.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
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
