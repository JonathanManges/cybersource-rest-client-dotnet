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
    /// Contains all of the amount-related fields in the invoice.
    /// </summary>
    [DataContract]
    public partial class Invoicingv2invoicesOrderInformationAmountDetails :  IEquatable<Invoicingv2invoicesOrderInformationAmountDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoicingv2invoicesOrderInformationAmountDetails" /> class.
        /// </summary>
        /// <param name="TotalAmount">Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  **Note** For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths.  If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.   #### Card Present Required to include either this field or &#x60;orderInformation.lineItems[].unitPrice&#x60; for the order.  #### Invoicing Required for creating a new invoice.  #### PIN Debit Amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount.  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request.   #### DCC for First Data Not used. .</param>
        /// <param name="Currency">Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency.  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. .</param>
        /// <param name="DiscountAmount">Total discount amount applied to the order. .</param>
        /// <param name="DiscountPercent">The total discount percentage applied to the invoice..</param>
        /// <param name="SubAmount">Sub-amount of the invoice..</param>
        /// <param name="MinimumPartialAmount">The minimum partial amount required to pay the invoice..</param>
        /// <param name="TaxDetails">TaxDetails.</param>
        /// <param name="Freight">Freight.</param>
        public Invoicingv2invoicesOrderInformationAmountDetails(string TotalAmount = default(string), string Currency = default(string), string DiscountAmount = default(string), decimal? DiscountPercent = default(decimal?), decimal? SubAmount = default(decimal?), decimal? MinimumPartialAmount = default(decimal?), Invoicingv2invoicesOrderInformationAmountDetailsTaxDetails TaxDetails = default(Invoicingv2invoicesOrderInformationAmountDetailsTaxDetails), Invoicingv2invoicesOrderInformationAmountDetailsFreight Freight = default(Invoicingv2invoicesOrderInformationAmountDetailsFreight))
        {
            this.TotalAmount = TotalAmount;
            this.Currency = Currency;
            this.DiscountAmount = DiscountAmount;
            this.DiscountPercent = DiscountPercent;
            this.SubAmount = SubAmount;
            this.MinimumPartialAmount = MinimumPartialAmount;
            this.TaxDetails = TaxDetails;
            this.Freight = Freight;
        }
        
        /// <summary>
        /// Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  **Note** For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths.  If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.   #### Card Present Required to include either this field or &#x60;orderInformation.lineItems[].unitPrice&#x60; for the order.  #### Invoicing Required for creating a new invoice.  #### PIN Debit Amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount.  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request.   #### DCC for First Data Not used. 
        /// </summary>
        /// <value>Grand total for the order. This value cannot be negative. You can include a decimal point (.), but no other special characters. CyberSource truncates the amount to the correct number of decimal places.  **Note** For CTV, FDCCompass, Paymentech processors, the maximum length for this field is 12.  **Important** Some processors have specific requirements and limitations, such as maximum amounts and maximum field lengths.  If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.   #### Card Present Required to include either this field or &#x60;orderInformation.lineItems[].unitPrice&#x60; for the order.  #### Invoicing Required for creating a new invoice.  #### PIN Debit Amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount.  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit; however, for all other processors, these fields are required.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either this field or the 1st line item in the order and the specific line-order amount in your request.   #### DCC for First Data Not used. </value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency.  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. 
        /// </summary>
        /// <value>Currency used for the order. Use the three-character [ISO Standard Currency Codes.](http://apps.cybersource.com/library/documentation/sbc/quickref/currencies.pdf)  #### Used by **Authorization** Required field.  **Authorization Reversal** For an authorization reversal (&#x60;reversalInformation&#x60;) or a capture (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60;), you must use the same currency that you used in your payment authorization request.  #### PIN Debit Currency for the amount you requested for the PIN debit purchase. This value is returned for partial authorizations. The issuing bank can approve a partial amount if the balance on the debit card is less than the requested transaction amount. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf). Returned by PIN debit purchase.  For PIN debit reversal requests, you must use the same currency that was used for the PIN debit purchase or PIN debit credit that you are reversing. For the possible values, see the [ISO Standard Currency Codes](https://developer.cybersource.com/library/documentation/sbc/quickref/currencies.pdf).  Required field for PIN Debit purchase and PIN Debit credit requests. Optional field for PIN Debit reversal requests.  #### GPX This field is optional for reversing an authorization or credit.  #### DCC for First Data Your local currency.  #### Tax Calculation Required for international tax and value added tax only. Optional for U.S. and Canadian taxes. Your local currency. </value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Total discount amount applied to the order. 
        /// </summary>
        /// <value>Total discount amount applied to the order. </value>
        [DataMember(Name="discountAmount", EmitDefaultValue=false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// The total discount percentage applied to the invoice.
        /// </summary>
        /// <value>The total discount percentage applied to the invoice.</value>
        [DataMember(Name="discountPercent", EmitDefaultValue=false)]
        public decimal? DiscountPercent { get; set; }

        /// <summary>
        /// Sub-amount of the invoice.
        /// </summary>
        /// <value>Sub-amount of the invoice.</value>
        [DataMember(Name="subAmount", EmitDefaultValue=false)]
        public decimal? SubAmount { get; set; }

        /// <summary>
        /// The minimum partial amount required to pay the invoice.
        /// </summary>
        /// <value>The minimum partial amount required to pay the invoice.</value>
        [DataMember(Name="minimumPartialAmount", EmitDefaultValue=false)]
        public decimal? MinimumPartialAmount { get; set; }

        /// <summary>
        /// Gets or Sets TaxDetails
        /// </summary>
        [DataMember(Name="taxDetails", EmitDefaultValue=false)]
        public Invoicingv2invoicesOrderInformationAmountDetailsTaxDetails TaxDetails { get; set; }

        /// <summary>
        /// Gets or Sets Freight
        /// </summary>
        [DataMember(Name="freight", EmitDefaultValue=false)]
        public Invoicingv2invoicesOrderInformationAmountDetailsFreight Freight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Invoicingv2invoicesOrderInformationAmountDetails {\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountPercent: ").Append(DiscountPercent).Append("\n");
            sb.Append("  SubAmount: ").Append(SubAmount).Append("\n");
            sb.Append("  MinimumPartialAmount: ").Append(MinimumPartialAmount).Append("\n");
            sb.Append("  TaxDetails: ").Append(TaxDetails).Append("\n");
            sb.Append("  Freight: ").Append(Freight).Append("\n");
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
            return this.Equals(obj as Invoicingv2invoicesOrderInformationAmountDetails);
        }

        /// <summary>
        /// Returns true if Invoicingv2invoicesOrderInformationAmountDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Invoicingv2invoicesOrderInformationAmountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoicingv2invoicesOrderInformationAmountDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.DiscountAmount == other.DiscountAmount ||
                    this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(other.DiscountAmount)
                ) && 
                (
                    this.DiscountPercent == other.DiscountPercent ||
                    this.DiscountPercent != null &&
                    this.DiscountPercent.Equals(other.DiscountPercent)
                ) && 
                (
                    this.SubAmount == other.SubAmount ||
                    this.SubAmount != null &&
                    this.SubAmount.Equals(other.SubAmount)
                ) && 
                (
                    this.MinimumPartialAmount == other.MinimumPartialAmount ||
                    this.MinimumPartialAmount != null &&
                    this.MinimumPartialAmount.Equals(other.MinimumPartialAmount)
                ) && 
                (
                    this.TaxDetails == other.TaxDetails ||
                    this.TaxDetails != null &&
                    this.TaxDetails.Equals(other.TaxDetails)
                ) && 
                (
                    this.Freight == other.Freight ||
                    this.Freight != null &&
                    this.Freight.Equals(other.Freight)
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
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.DiscountAmount != null)
                    hash = hash * 59 + this.DiscountAmount.GetHashCode();
                if (this.DiscountPercent != null)
                    hash = hash * 59 + this.DiscountPercent.GetHashCode();
                if (this.SubAmount != null)
                    hash = hash * 59 + this.SubAmount.GetHashCode();
                if (this.MinimumPartialAmount != null)
                    hash = hash * 59 + this.MinimumPartialAmount.GetHashCode();
                if (this.TaxDetails != null)
                    hash = hash * 59 + this.TaxDetails.GetHashCode();
                if (this.Freight != null)
                    hash = hash * 59 + this.Freight.GetHashCode();
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
