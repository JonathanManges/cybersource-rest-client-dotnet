/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// InlineResponse2022
    /// </summary>
    [DataContract]
    public partial class InlineResponse2022 :  IEquatable<InlineResponse2022>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2022" /> class.
        /// </summary>
        /// <param name="Links">Links.</param>
        /// <param name="BatchId">Unique identification number assigned to the submitted request..</param>
        /// <param name="BatchItemCount">BatchItemCount.</param>
        public InlineResponse2022(InlineResponse2022Links Links = default(InlineResponse2022Links), string BatchId = default(string), int? BatchItemCount = default(int?))
        {
            this.Links = Links;
            this.BatchId = BatchId;
            this.BatchItemCount = BatchItemCount;
        }
        
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="_links", EmitDefaultValue=false)]
        public InlineResponse2022Links Links { get; set; }

        /// <summary>
        /// Unique identification number assigned to the submitted request.
        /// </summary>
        /// <value>Unique identification number assigned to the submitted request.</value>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or Sets BatchItemCount
        /// </summary>
        [DataMember(Name="batchItemCount", EmitDefaultValue=false)]
        public int? BatchItemCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2022 {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BatchItemCount: ").Append(BatchItemCount).Append("\n");
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
            return this.Equals(obj as InlineResponse2022);
        }

        /// <summary>
        /// Returns true if InlineResponse2022 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2022 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2022 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.BatchItemCount == other.BatchItemCount ||
                    this.BatchItemCount != null &&
                    this.BatchItemCount.Equals(other.BatchItemCount)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.BatchItemCount != null)
                    hash = hash * 59 + this.BatchItemCount.GetHashCode();
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