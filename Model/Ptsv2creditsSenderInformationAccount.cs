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
    /// Ptsv2creditsSenderInformationAccount
    /// </summary>
    [DataContract]
    public partial class Ptsv2creditsSenderInformationAccount :  IEquatable<Ptsv2creditsSenderInformationAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2creditsSenderInformationAccount" /> class.
        /// </summary>
        /// <param name="Number">Account number of the sender of the funds. For Gaming Payment of Winnings transactions this is the merchant account number. * Required for Mastercard Payment of Winnings (POW) transactions. * Must contain only ASCII characters in range 32-122. * Must not be greater than 50 characters. * Required for POW on Barclays. .</param>
        /// <param name="FundsSource">Source of funds for the sender. For Gaming Payment of Winnings transactions this is the merchant account type. * Required for Mastercard Payment of Winnings (POW) transactions. * Valid values:   * 00 - Other   * 01 - RTN + Bank Account   * 02 - IBAN   * 03 - Card Account   * 04 - Email   * 05 - PhoneNumber   * 06 - Bank account number (BAN) + Bank Identification Code (BIC)   * 07 - Wallet ID   * 08 - Social Network ID .</param>
        public Ptsv2creditsSenderInformationAccount(string Number = default(string), string FundsSource = default(string))
        {
            this.Number = Number;
            this.FundsSource = FundsSource;
        }
        
        /// <summary>
        /// Account number of the sender of the funds. For Gaming Payment of Winnings transactions this is the merchant account number. * Required for Mastercard Payment of Winnings (POW) transactions. * Must contain only ASCII characters in range 32-122. * Must not be greater than 50 characters. * Required for POW on Barclays. 
        /// </summary>
        /// <value>Account number of the sender of the funds. For Gaming Payment of Winnings transactions this is the merchant account number. * Required for Mastercard Payment of Winnings (POW) transactions. * Must contain only ASCII characters in range 32-122. * Must not be greater than 50 characters. * Required for POW on Barclays. </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Source of funds for the sender. For Gaming Payment of Winnings transactions this is the merchant account type. * Required for Mastercard Payment of Winnings (POW) transactions. * Valid values:   * 00 - Other   * 01 - RTN + Bank Account   * 02 - IBAN   * 03 - Card Account   * 04 - Email   * 05 - PhoneNumber   * 06 - Bank account number (BAN) + Bank Identification Code (BIC)   * 07 - Wallet ID   * 08 - Social Network ID 
        /// </summary>
        /// <value>Source of funds for the sender. For Gaming Payment of Winnings transactions this is the merchant account type. * Required for Mastercard Payment of Winnings (POW) transactions. * Valid values:   * 00 - Other   * 01 - RTN + Bank Account   * 02 - IBAN   * 03 - Card Account   * 04 - Email   * 05 - PhoneNumber   * 06 - Bank account number (BAN) + Bank Identification Code (BIC)   * 07 - Wallet ID   * 08 - Social Network ID </value>
        [DataMember(Name="fundsSource", EmitDefaultValue=false)]
        public string FundsSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2creditsSenderInformationAccount {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  FundsSource: ").Append(FundsSource).Append("\n");
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
            return this.Equals(obj as Ptsv2creditsSenderInformationAccount);
        }

        /// <summary>
        /// Returns true if Ptsv2creditsSenderInformationAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2creditsSenderInformationAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2creditsSenderInformationAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.FundsSource == other.FundsSource ||
                    this.FundsSource != null &&
                    this.FundsSource.Equals(other.FundsSource)
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
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.FundsSource != null)
                    hash = hash * 59 + this.FundsSource.GetHashCode();
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
