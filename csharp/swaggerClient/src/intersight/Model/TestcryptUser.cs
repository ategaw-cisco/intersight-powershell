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
    /// User information 
    /// </summary>
    [DataContract]
    public partial class TestcryptUser :  IEquatable<TestcryptUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestcryptUser" /> class.
        /// </summary>
        /// <param name="IsPasswordSet">IsPasswordSet.</param>
        /// <param name="Password">Password.</param>
        /// <param name="Username">Username.</param>
        public TestcryptUser(bool? IsPasswordSet = default(bool?), string Password = default(string), string Username = default(string))
        {
            this.IsPasswordSet = IsPasswordSet;
            this.Password = Password;
            this.Username = Username;
        }
        
        /// <summary>
        /// Gets or Sets IsPasswordSet
        /// </summary>
        [DataMember(Name="IsPasswordSet", EmitDefaultValue=false)]
        public bool? IsPasswordSet { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="Password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="Username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestcryptUser {\n");
            sb.Append("  IsPasswordSet: ").Append(IsPasswordSet).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
            return this.Equals(obj as TestcryptUser);
        }

        /// <summary>
        /// Returns true if TestcryptUser instances are equal
        /// </summary>
        /// <param name="other">Instance of TestcryptUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestcryptUser other)
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
