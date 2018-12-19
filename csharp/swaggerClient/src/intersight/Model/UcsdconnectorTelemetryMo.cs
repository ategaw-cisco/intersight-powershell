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
    /// It represents Mo name, Field names and corresponding queries 
    /// </summary>
    [DataContract]
    public partial class UcsdconnectorTelemetryMo :  IEquatable<UcsdconnectorTelemetryMo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UcsdconnectorTelemetryMo" /> class.
        /// </summary>
        /// <param name="FieldQueries">Its a collection of FieldQuery objects  .</param>
        /// <param name="MoName">MoName corresponds to Fanwood telemetry Mo  .</param>
        /// <param name="ObjectQuery">It contains a single SQL Query that collects all the properties of a Mo   .</param>
        public UcsdconnectorTelemetryMo(List<UcsdconnectorFieldQuery> FieldQueries = default(List<UcsdconnectorFieldQuery>), string MoName = default(string), UcsdconnectorSqlQuery ObjectQuery = default(UcsdconnectorSqlQuery))
        {
            this.FieldQueries = FieldQueries;
            this.MoName = MoName;
            this.ObjectQuery = ObjectQuery;
        }
        
        /// <summary>
        /// Its a collection of FieldQuery objects  
        /// </summary>
        /// <value>Its a collection of FieldQuery objects  </value>
        [DataMember(Name="FieldQueries", EmitDefaultValue=false)]
        public List<UcsdconnectorFieldQuery> FieldQueries { get; set; }

        /// <summary>
        /// MoName corresponds to Fanwood telemetry Mo  
        /// </summary>
        /// <value>MoName corresponds to Fanwood telemetry Mo  </value>
        [DataMember(Name="MoName", EmitDefaultValue=false)]
        public string MoName { get; set; }

        /// <summary>
        /// It contains a single SQL Query that collects all the properties of a Mo   
        /// </summary>
        /// <value>It contains a single SQL Query that collects all the properties of a Mo   </value>
        [DataMember(Name="ObjectQuery", EmitDefaultValue=false)]
        public UcsdconnectorSqlQuery ObjectQuery { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UcsdconnectorTelemetryMo {\n");
            sb.Append("  FieldQueries: ").Append(FieldQueries).Append("\n");
            sb.Append("  MoName: ").Append(MoName).Append("\n");
            sb.Append("  ObjectQuery: ").Append(ObjectQuery).Append("\n");
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
            return this.Equals(obj as UcsdconnectorTelemetryMo);
        }

        /// <summary>
        /// Returns true if UcsdconnectorTelemetryMo instances are equal
        /// </summary>
        /// <param name="other">Instance of UcsdconnectorTelemetryMo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UcsdconnectorTelemetryMo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldQueries == other.FieldQueries ||
                    this.FieldQueries != null &&
                    this.FieldQueries.SequenceEqual(other.FieldQueries)
                ) && 
                (
                    this.MoName == other.MoName ||
                    this.MoName != null &&
                    this.MoName.Equals(other.MoName)
                ) && 
                (
                    this.ObjectQuery == other.ObjectQuery ||
                    this.ObjectQuery != null &&
                    this.ObjectQuery.Equals(other.ObjectQuery)
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
                if (this.FieldQueries != null)
                    hash = hash * 59 + this.FieldQueries.GetHashCode();
                if (this.MoName != null)
                    hash = hash * 59 + this.MoName.GetHashCode();
                if (this.ObjectQuery != null)
                    hash = hash * 59 + this.ObjectQuery.GetHashCode();
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
