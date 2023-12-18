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
    /// Ptsv1pushfundstransferSenderInformationAccount
    /// </summary>
    [DataContract]
    public partial class Ptsv1pushfundstransferSenderInformationAccount :  IEquatable<Ptsv1pushfundstransferSenderInformationAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv1pushfundstransferSenderInformationAccount" /> class.
        /// </summary>
        /// <param name="FundsSource">Source of funds. Possible values:  Chase Paymentech, FDC Compass, Visa Platform Connect:  - &#x60;01&#x60;: Credit card - &#x60;02&#x60;: Debit card - &#x60;03&#x60;: Prepaid card  Chase Paymentech, Visa Platform Connect:  - &#x60;04&#x60;: Cash - &#x60;05&#x60;: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings accounts, and proprietary debit or ATM cards. - &#x60;06&#x60;: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines of credit.  FDC Compass: - &#x60;04&#x60;: Deposit Account  Funds Disbursement This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  Credit Card Bill Payment This value must be 02, 03, 04, or 05. .</param>
        /// <param name="Number">The account number of the entity funding the transaction. It is the sender&#39;s account number. It can be a debit/credit card account number or bank account number.  Funds disbursements  This field is optional.  All other transactions  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length:  FDC Compass (&lt;&#x3D; 19) Chase Paymentech (&lt;&#x3D; 16) .</param>
        public Ptsv1pushfundstransferSenderInformationAccount(string FundsSource = default(string), string Number = default(string))
        {
            this.FundsSource = FundsSource;
            this.Number = Number;
        }
        
        /// <summary>
        /// Source of funds. Possible values:  Chase Paymentech, FDC Compass, Visa Platform Connect:  - &#x60;01&#x60;: Credit card - &#x60;02&#x60;: Debit card - &#x60;03&#x60;: Prepaid card  Chase Paymentech, Visa Platform Connect:  - &#x60;04&#x60;: Cash - &#x60;05&#x60;: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings accounts, and proprietary debit or ATM cards. - &#x60;06&#x60;: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines of credit.  FDC Compass: - &#x60;04&#x60;: Deposit Account  Funds Disbursement This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  Credit Card Bill Payment This value must be 02, 03, 04, or 05. 
        /// </summary>
        /// <value>Source of funds. Possible values:  Chase Paymentech, FDC Compass, Visa Platform Connect:  - &#x60;01&#x60;: Credit card - &#x60;02&#x60;: Debit card - &#x60;03&#x60;: Prepaid card  Chase Paymentech, Visa Platform Connect:  - &#x60;04&#x60;: Cash - &#x60;05&#x60;: Debit or deposit account that is not linked to a Visa card. Includes checking accounts, savings accounts, and proprietary debit or ATM cards. - &#x60;06&#x60;: Credit account that is not linked to a Visa card. Includes credit cards and proprietary lines of credit.  FDC Compass: - &#x60;04&#x60;: Deposit Account  Funds Disbursement This value is most likely 05 to identify that the originator used a deposit account to fund the disbursement.  Credit Card Bill Payment This value must be 02, 03, 04, or 05. </value>
        [DataMember(Name="fundsSource", EmitDefaultValue=false)]
        public string FundsSource { get; set; }

        /// <summary>
        /// The account number of the entity funding the transaction. It is the sender&#39;s account number. It can be a debit/credit card account number or bank account number.  Funds disbursements  This field is optional.  All other transactions  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length:  FDC Compass (&lt;&#x3D; 19) Chase Paymentech (&lt;&#x3D; 16) 
        /// </summary>
        /// <value>The account number of the entity funding the transaction. It is the sender&#39;s account number. It can be a debit/credit card account number or bank account number.  Funds disbursements  This field is optional.  All other transactions  This field is required when the sender funds the transaction with a financial instrument, for example debit card. Length:  FDC Compass (&lt;&#x3D; 19) Chase Paymentech (&lt;&#x3D; 16) </value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv1pushfundstransferSenderInformationAccount {\n");
            sb.Append("  FundsSource: ").Append(FundsSource).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(obj as Ptsv1pushfundstransferSenderInformationAccount);
        }

        /// <summary>
        /// Returns true if Ptsv1pushfundstransferSenderInformationAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv1pushfundstransferSenderInformationAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv1pushfundstransferSenderInformationAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FundsSource == other.FundsSource ||
                    this.FundsSource != null &&
                    this.FundsSource.Equals(other.FundsSource)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
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
                if (this.FundsSource != null)
                    hash = hash * 59 + this.FundsSource.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
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
