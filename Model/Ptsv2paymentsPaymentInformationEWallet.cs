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
    /// Ptsv2paymentsPaymentInformationEWallet
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsPaymentInformationEWallet :  IEquatable<Ptsv2paymentsPaymentInformationEWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsPaymentInformationEWallet" /> class.
        /// </summary>
        /// <param name="AccountId">The ID of the customer, passed in the return_url field by PayPal after customer approval..</param>
        /// <param name="FundingSource">Payment method for the unit purchase. Possible values: - &#x60;UNRESTRICTED (default)—this value is only available if configured by PayPal for the merchant.&#x60; - &#x60;INSTANT&#x60; .</param>
        public Ptsv2paymentsPaymentInformationEWallet(string AccountId = default(string), string FundingSource = default(string))
        {
            this.AccountId = AccountId;
            this.FundingSource = FundingSource;
        }
        
        /// <summary>
        /// The ID of the customer, passed in the return_url field by PayPal after customer approval.
        /// </summary>
        /// <value>The ID of the customer, passed in the return_url field by PayPal after customer approval.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Payment method for the unit purchase. Possible values: - &#x60;UNRESTRICTED (default)—this value is only available if configured by PayPal for the merchant.&#x60; - &#x60;INSTANT&#x60; 
        /// </summary>
        /// <value>Payment method for the unit purchase. Possible values: - &#x60;UNRESTRICTED (default)—this value is only available if configured by PayPal for the merchant.&#x60; - &#x60;INSTANT&#x60; </value>
        [DataMember(Name="fundingSource", EmitDefaultValue=false)]
        public string FundingSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsPaymentInformationEWallet {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  FundingSource: ").Append(FundingSource).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsPaymentInformationEWallet);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsPaymentInformationEWallet instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsPaymentInformationEWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsPaymentInformationEWallet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.FundingSource == other.FundingSource ||
                    this.FundingSource != null &&
                    this.FundingSource.Equals(other.FundingSource)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.FundingSource != null)
                    hash = hash * 59 + this.FundingSource.GetHashCode();
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
