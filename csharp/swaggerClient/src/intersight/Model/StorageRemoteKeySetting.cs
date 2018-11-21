/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-255
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
    /// This type models the remote key configurarion required for disks encryptions. KMIP is the only remote key protocol supported in the policy 
    /// </summary>
    [DataContract]
    public partial class StorageRemoteKeySetting :  IEquatable<StorageRemoteKeySetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRemoteKeySetting" /> class.
        /// </summary>
        /// <param name="IsPasswordSet">IsPasswordSet.</param>
        /// <param name="Password">This property is used to specify password for the KMIP server login  .</param>
        /// <param name="Port">This property is used to port to which the KMIP client should connect  .</param>
        /// <param name="PrimaryServer">This property is used to store the address of the KMIP server. It could be an IPv4 address or an IPv6 address or hostname. Hostnames are valid only when Inband is configured for the CIMC address  .</param>
        /// <param name="SecondaryServer">This property is used to store the address of the KMIP server. It could be an IPv4 address or an IPv6 address or hostname. Hostnames are valid only when Inband is configured for the CIMC address  .</param>
        /// <param name="ServerCertificate">This property is used to store the certificate/ public key of the KMIP server This is required for initiating secure communication with the server  .</param>
        /// <param name="Username">This property is used to specify user name for the KMIP server login   .</param>
        public StorageRemoteKeySetting(bool? IsPasswordSet = default(bool?), string Password = default(string), long? Port = default(long?), string PrimaryServer = default(string), string SecondaryServer = default(string), string ServerCertificate = default(string), string Username = default(string))
        {
            this.IsPasswordSet = IsPasswordSet;
            this.Password = Password;
            this.Port = Port;
            this.PrimaryServer = PrimaryServer;
            this.SecondaryServer = SecondaryServer;
            this.ServerCertificate = ServerCertificate;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets IsPasswordSet
        /// </summary>
        [DataMember(Name="IsPasswordSet", EmitDefaultValue=false)]
        public bool? IsPasswordSet { get; set; }

        /// <summary>
        /// This property is used to specify password for the KMIP server login  
        /// </summary>
        /// <value>This property is used to specify password for the KMIP server login  </value>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// This property is used to port to which the KMIP client should connect  
        /// </summary>
        /// <value>This property is used to port to which the KMIP client should connect  </value>
        [DataMember(Name="Port", EmitDefaultValue=false)]
        public long? Port { get; set; }

        /// <summary>
        /// This property is used to store the address of the KMIP server. It could be an IPv4 address or an IPv6 address or hostname. Hostnames are valid only when Inband is configured for the CIMC address  
        /// </summary>
        /// <value>This property is used to store the address of the KMIP server. It could be an IPv4 address or an IPv6 address or hostname. Hostnames are valid only when Inband is configured for the CIMC address  </value>
        [DataMember(Name="PrimaryServer", EmitDefaultValue=false)]
        public string PrimaryServer { get; set; }

        /// <summary>
        /// This property is used to store the address of the KMIP server. It could be an IPv4 address or an IPv6 address or hostname. Hostnames are valid only when Inband is configured for the CIMC address  
        /// </summary>
        /// <value>This property is used to store the address of the KMIP server. It could be an IPv4 address or an IPv6 address or hostname. Hostnames are valid only when Inband is configured for the CIMC address  </value>
        [DataMember(Name="SecondaryServer", EmitDefaultValue=false)]
        public string SecondaryServer { get; set; }

        /// <summary>
        /// This property is used to store the certificate/ public key of the KMIP server This is required for initiating secure communication with the server  
        /// </summary>
        /// <value>This property is used to store the certificate/ public key of the KMIP server This is required for initiating secure communication with the server  </value>
        [DataMember(Name="ServerCertificate", EmitDefaultValue=false)]
        public string ServerCertificate { get; set; }

        /// <summary>
        /// This property is used to specify user name for the KMIP server login   
        /// </summary>
        /// <value>This property is used to specify user name for the KMIP server login   </value>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageRemoteKeySetting {\n");
            sb.Append("  IsPasswordSet: ").Append(IsPasswordSet).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  PrimaryServer: ").Append(PrimaryServer).Append("\n");
            sb.Append("  SecondaryServer: ").Append(SecondaryServer).Append("\n");
            sb.Append("  ServerCertificate: ").Append(ServerCertificate).Append("\n");
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
            return this.Equals(obj as StorageRemoteKeySetting);
        }

        /// <summary>
        /// Returns true if StorageRemoteKeySetting instances are equal
        /// </summary>
        /// <param name="other">Instance of StorageRemoteKeySetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StorageRemoteKeySetting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsPasswordSet == other.IsPasswordSet ||
                    this.IsPasswordSet != null &&
                    this.IsPasswordSet.Equals(other.IsPasswordSet)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.Port == other.Port ||
                    this.Port != null &&
                    this.Port.Equals(other.Port)
                ) && 
                (
                    this.PrimaryServer == other.PrimaryServer ||
                    this.PrimaryServer != null &&
                    this.PrimaryServer.Equals(other.PrimaryServer)
                ) && 
                (
                    this.SecondaryServer == other.SecondaryServer ||
                    this.SecondaryServer != null &&
                    this.SecondaryServer.Equals(other.SecondaryServer)
                ) && 
                (
                    this.ServerCertificate == other.ServerCertificate ||
                    this.ServerCertificate != null &&
                    this.ServerCertificate.Equals(other.ServerCertificate)
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
                if (this.IsPasswordSet != null)
                    hash = hash * 59 + this.IsPasswordSet.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.Port != null)
                    hash = hash * 59 + this.Port.GetHashCode();
                if (this.PrimaryServer != null)
                    hash = hash * 59 + this.PrimaryServer.GetHashCode();
                if (this.SecondaryServer != null)
                    hash = hash * 59 + this.SecondaryServer.GetHashCode();
                if (this.ServerCertificate != null)
                    hash = hash * 59 + this.ServerCertificate.GetHashCode();
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
