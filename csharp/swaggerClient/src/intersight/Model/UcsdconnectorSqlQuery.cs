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
    /// SqlQuery is an object of sql query string and its params 
    /// </summary>
    [DataContract]
    public partial class UcsdconnectorSqlQuery :  IEquatable<UcsdconnectorSqlQuery>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsdconnectorSqlQuery" /> class.
        /// </summary>
        /// <param name="_Params">Parameters in query string  .</param>
        /// <param name="Query">query string   .</param>
        public UcsdconnectorSqlQuery(Object _Params = default(Object), string Query = default(string))
        {
            this._Params = _Params;
            this.Query = Query;
        }
        
        /// <summary>
        /// Parameters in query string  
        /// </summary>
        /// <value>Parameters in query string  </value>
        [DataMember(Name="Params", EmitDefaultValue=false)]
        public Object _Params { get; set; }

        /// <summary>
        /// query string   
        /// </summary>
        /// <value>query string   </value>
        [DataMember(Name="Query", EmitDefaultValue=false)]
        public string Query { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsdconnectorSqlQuery {\n");
            sb.Append("  _Params: ").Append(_Params).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
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
            return this.Equals(obj as UcsdconnectorSqlQuery);
        }

        /// <summary>
        /// Returns true if UcsdconnectorSqlQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of UcsdconnectorSqlQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsdconnectorSqlQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Params == other._Params ||
                    this._Params != null &&
                    this._Params.Equals(other._Params)
                ) && 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
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
                if (this._Params != null)
                    hash = hash * 59 + this._Params.GetHashCode();
                if (this.Query != null)
                    hash = hash * 59 + this.Query.GetHashCode();
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
