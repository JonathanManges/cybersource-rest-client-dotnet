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
    /// PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount
    /// </summary>
    [DataContract]
    public partial class PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount :  IEquatable<PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount" /> class.
        /// </summary>
        /// <param name="OriginatorMerchantId">TBD (required).</param>
        /// <param name="OriginatorTerminalId">TBD (required).</param>
        /// <param name="SupportedCurrencies">Three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).</param>
        public PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount(string OriginatorMerchantId = default(string), List<string> OriginatorTerminalId = default(List<string>), List<string> SupportedCurrencies = default(List<string>))
        {
            // to ensure "OriginatorMerchantId" is required (not null)
            if (OriginatorMerchantId == null)
            {
                throw new InvalidDataException("OriginatorMerchantId is a required property for PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount and cannot be null");
            }
            else
            {
                this.OriginatorMerchantId = OriginatorMerchantId;
            }
            // to ensure "OriginatorTerminalId" is required (not null)
            if (OriginatorTerminalId == null)
            {
                throw new InvalidDataException("OriginatorTerminalId is a required property for PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount and cannot be null");
            }
            else
            {
                this.OriginatorTerminalId = OriginatorTerminalId;
            }
            this.SupportedCurrencies = SupportedCurrencies;
        }
        
        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="originatorMerchantId", EmitDefaultValue=false)]
        public string OriginatorMerchantId { get; set; }

        /// <summary>
        /// TBD
        /// </summary>
        /// <value>TBD</value>
        [DataMember(Name="originatorTerminalId", EmitDefaultValue=false)]
        public List<string> OriginatorTerminalId { get; set; }

        /// <summary>
        /// Three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)
        /// </summary>
        /// <value>Three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)</value>
        [DataMember(Name="supportedCurrencies", EmitDefaultValue=false)]
        public List<string> SupportedCurrencies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount {\n");
            sb.Append("  OriginatorMerchantId: ").Append(OriginatorMerchantId).Append("\n");
            sb.Append("  OriginatorTerminalId: ").Append(OriginatorTerminalId).Append("\n");
            sb.Append("  SupportedCurrencies: ").Append(SupportedCurrencies).Append("\n");
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
            return this.Equals(obj as PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount);
        }

        /// <summary>
        /// Returns true if PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductsPayoutsConfigurationInformationConfigurationsProcessorAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OriginatorMerchantId == other.OriginatorMerchantId ||
                    this.OriginatorMerchantId != null &&
                    this.OriginatorMerchantId.Equals(other.OriginatorMerchantId)
                ) && 
                (
                    this.OriginatorTerminalId == other.OriginatorTerminalId ||
                    this.OriginatorTerminalId != null &&
                    this.OriginatorTerminalId.SequenceEqual(other.OriginatorTerminalId)
                ) && 
                (
                    this.SupportedCurrencies == other.SupportedCurrencies ||
                    this.SupportedCurrencies != null &&
                    this.SupportedCurrencies.SequenceEqual(other.SupportedCurrencies)
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
                if (this.OriginatorMerchantId != null)
                    hash = hash * 59 + this.OriginatorMerchantId.GetHashCode();
                if (this.OriginatorTerminalId != null)
                    hash = hash * 59 + this.OriginatorTerminalId.GetHashCode();
                if (this.SupportedCurrencies != null)
                    hash = hash * 59 + this.SupportedCurrencies.GetHashCode();
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
