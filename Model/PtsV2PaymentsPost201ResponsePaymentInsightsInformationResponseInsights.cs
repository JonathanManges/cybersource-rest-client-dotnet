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
    /// PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights :  IEquatable<PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights" /> class.
        /// </summary>
        /// <param name="Category">Categorization of response message from processor  Possible Values: - &#x60;APPROVED&#x60; - &#x60;ISSUER_WILL_NEVER_APPROVE&#x60; - &#x60;ISSUER_CANT_APPROVE_AT_THIS_TIME&#x60; - &#x60;ISSUER_CANT_APPROVE_WITH_THESE_DETAILS&#x60; - &#x60;GENERIC_ERROR&#x60; - &#x60;OTHERS&#x60; - &#x60;MATCH_NOT_FOUND&#x60; .</param>
        /// <param name="CategoryCode">Categorization Code of response message from processor  Possible Values: - &#x60;01&#x60; : Issuer Will Never Approve - &#x60;02&#x60; : Issuer Can&#39;t Approve at this Time - &#x60;03&#x60; : Issuer Can&#39;t Approve with these Details - &#x60;04&#x60; : Generic Error - &#x60;98&#x60; : Others - &#x60;99&#x60; : Payment Insights Response Category Match Not Found .</param>
        /// <param name="ProcessorRawName">Raw name of the processor used for the transaction processing, especially useful during acquirer swing to see which processor transaction settled with .</param>
        public PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights(string Category = default(string), string CategoryCode = default(string), string ProcessorRawName = default(string))
        {
            this.Category = Category;
            this.CategoryCode = CategoryCode;
            this.ProcessorRawName = ProcessorRawName;
        }
        
        /// <summary>
        /// Categorization of response message from processor  Possible Values: - &#x60;APPROVED&#x60; - &#x60;ISSUER_WILL_NEVER_APPROVE&#x60; - &#x60;ISSUER_CANT_APPROVE_AT_THIS_TIME&#x60; - &#x60;ISSUER_CANT_APPROVE_WITH_THESE_DETAILS&#x60; - &#x60;GENERIC_ERROR&#x60; - &#x60;OTHERS&#x60; - &#x60;MATCH_NOT_FOUND&#x60; 
        /// </summary>
        /// <value>Categorization of response message from processor  Possible Values: - &#x60;APPROVED&#x60; - &#x60;ISSUER_WILL_NEVER_APPROVE&#x60; - &#x60;ISSUER_CANT_APPROVE_AT_THIS_TIME&#x60; - &#x60;ISSUER_CANT_APPROVE_WITH_THESE_DETAILS&#x60; - &#x60;GENERIC_ERROR&#x60; - &#x60;OTHERS&#x60; - &#x60;MATCH_NOT_FOUND&#x60; </value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        /// <summary>
        /// Categorization Code of response message from processor  Possible Values: - &#x60;01&#x60; : Issuer Will Never Approve - &#x60;02&#x60; : Issuer Can&#39;t Approve at this Time - &#x60;03&#x60; : Issuer Can&#39;t Approve with these Details - &#x60;04&#x60; : Generic Error - &#x60;98&#x60; : Others - &#x60;99&#x60; : Payment Insights Response Category Match Not Found 
        /// </summary>
        /// <value>Categorization Code of response message from processor  Possible Values: - &#x60;01&#x60; : Issuer Will Never Approve - &#x60;02&#x60; : Issuer Can&#39;t Approve at this Time - &#x60;03&#x60; : Issuer Can&#39;t Approve with these Details - &#x60;04&#x60; : Generic Error - &#x60;98&#x60; : Others - &#x60;99&#x60; : Payment Insights Response Category Match Not Found </value>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Raw name of the processor used for the transaction processing, especially useful during acquirer swing to see which processor transaction settled with 
        /// </summary>
        /// <value>Raw name of the processor used for the transaction processing, especially useful during acquirer swing to see which processor transaction settled with </value>
        [DataMember(Name="processorRawName", EmitDefaultValue=false)]
        public string ProcessorRawName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  ProcessorRawName: ").Append(ProcessorRawName).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponsePaymentInsightsInformationResponseInsights other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Category == other.Category ||
                    this.Category != null &&
                    this.Category.Equals(other.Category)
                ) && 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
                ) && 
                (
                    this.ProcessorRawName == other.ProcessorRawName ||
                    this.ProcessorRawName != null &&
                    this.ProcessorRawName.Equals(other.ProcessorRawName)
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
                if (this.Category != null)
                    hash = hash * 59 + this.Category.GetHashCode();
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                if (this.ProcessorRawName != null)
                    hash = hash * 59 + this.ProcessorRawName.GetHashCode();
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
