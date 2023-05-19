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
    /// PtsV2PaymentsRefundPost201ResponseProcessorInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsRefundPost201ResponseProcessorInformation :  IEquatable<PtsV2PaymentsRefundPost201ResponseProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsRefundPost201ResponseProcessorInformation" /> class.
        /// </summary>
        /// <param name="ApprovalCode">Authorization code. Returned only when the processor returns this value.  The length of this value depends on your processor.  Returned by authorization service.  #### PIN debit Authorization code that is returned by the processor.  Returned by PIN debit credit.  #### Elavon Encrypted Account Number Program The returned value is OFFLINE.  #### TSYS Acquiring Solutions The returned value for a successful zero amount authorization is 000000. .</param>
        /// <param name="TransactionId">Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 .</param>
        /// <param name="ForwardedAcquirerCode">Name of the Japanese acquirer that processed the transaction. Returned only for JCN Gateway. Please contact the CyberSource Japan Support Group for more information. .</param>
        /// <param name="MerchantNumber">Identifier that was assigned to you by your acquirer. This value must be printed on the receipt.  #### Returned by Authorizations and Credits.  This reply field is only supported by merchants who have installed client software on their POS terminals and use these processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX .</param>
        /// <param name="ResponseCode">For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### PIN debit Response value that is returned by the processor or bank. **Important** Do not use this field to evaluate the results of the transaction request.  Returned by PIN debit credit, PIN debit purchase, and PIN debit reversal.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;processorInformation.responseCategoryCode&#x60; field. String (3) .</param>
        /// <param name="AchVerification">AchVerification.</param>
        /// <param name="NetworkTransactionId">Same value as &#x60;processorInformation.transactionId&#x60;.</param>
        /// <param name="SettlementDate">Field contains a settlement date. The date is in mmdd format, where: mm &#x3D; month and dd &#x3D; day. .</param>
        public PtsV2PaymentsRefundPost201ResponseProcessorInformation(string ApprovalCode = default(string), string TransactionId = default(string), string ForwardedAcquirerCode = default(string), string MerchantNumber = default(string), string ResponseCode = default(string), PtsV2PaymentsPost201ResponseProcessorInformationAchVerification AchVerification = default(PtsV2PaymentsPost201ResponseProcessorInformationAchVerification), string NetworkTransactionId = default(string), string SettlementDate = default(string))
        {
            this.ApprovalCode = ApprovalCode;
            this.TransactionId = TransactionId;
            this.ForwardedAcquirerCode = ForwardedAcquirerCode;
            this.MerchantNumber = MerchantNumber;
            this.ResponseCode = ResponseCode;
            this.AchVerification = AchVerification;
            this.NetworkTransactionId = NetworkTransactionId;
            this.SettlementDate = SettlementDate;
        }
        
        /// <summary>
        /// Authorization code. Returned only when the processor returns this value.  The length of this value depends on your processor.  Returned by authorization service.  #### PIN debit Authorization code that is returned by the processor.  Returned by PIN debit credit.  #### Elavon Encrypted Account Number Program The returned value is OFFLINE.  #### TSYS Acquiring Solutions The returned value for a successful zero amount authorization is 000000. 
        /// </summary>
        /// <value>Authorization code. Returned only when the processor returns this value.  The length of this value depends on your processor.  Returned by authorization service.  #### PIN debit Authorization code that is returned by the processor.  Returned by PIN debit credit.  #### Elavon Encrypted Account Number Program The returned value is OFFLINE.  #### TSYS Acquiring Solutions The returned value for a successful zero amount authorization is 000000. </value>
        [DataMember(Name="approvalCode", EmitDefaultValue=false)]
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 
        /// </summary>
        /// <value>Processor transaction ID.  This value identifies the transaction on a host system. This value is supported only for Moneris. It contains this information:   - Terminal used to process the transaction  - Shift during which the transaction took place  - Batch number  - Transaction number within the batch  You must store this value. If you give the customer a receipt, display this value on the receipt.  Example For the value 66012345001069003:   - Terminal ID &#x3D; 66012345  - Shift number &#x3D; 001  - Batch number &#x3D; 069  - Transaction number &#x3D; 003 </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Name of the Japanese acquirer that processed the transaction. Returned only for JCN Gateway. Please contact the CyberSource Japan Support Group for more information. 
        /// </summary>
        /// <value>Name of the Japanese acquirer that processed the transaction. Returned only for JCN Gateway. Please contact the CyberSource Japan Support Group for more information. </value>
        [DataMember(Name="forwardedAcquirerCode", EmitDefaultValue=false)]
        public string ForwardedAcquirerCode { get; set; }

        /// <summary>
        /// Identifier that was assigned to you by your acquirer. This value must be printed on the receipt.  #### Returned by Authorizations and Credits.  This reply field is only supported by merchants who have installed client software on their POS terminals and use these processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX 
        /// </summary>
        /// <value>Identifier that was assigned to you by your acquirer. This value must be printed on the receipt.  #### Returned by Authorizations and Credits.  This reply field is only supported by merchants who have installed client software on their POS terminals and use these processors: - American Express Direct - Credit Mutuel-CIC - FDC Nashville Global - OmniPay Direct - SIX </value>
        [DataMember(Name="merchantNumber", EmitDefaultValue=false)]
        public string MerchantNumber { get; set; }

        /// <summary>
        /// For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### PIN debit Response value that is returned by the processor or bank. **Important** Do not use this field to evaluate the results of the transaction request.  Returned by PIN debit credit, PIN debit purchase, and PIN debit reversal.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;processorInformation.responseCategoryCode&#x60; field. String (3) 
        /// </summary>
        /// <value>For most processors, this is the error message sent directly from the bank. Returned only when the processor returns this value.  **Important** Do not use this field to evaluate the result of the authorization.  #### PIN debit Response value that is returned by the processor or bank. **Important** Do not use this field to evaluate the results of the transaction request.  Returned by PIN debit credit, PIN debit purchase, and PIN debit reversal.  #### AIBMS If this value is &#x60;08&#x60;, you can accept the transaction if the customer provides you with identification.  #### Atos This value is the response code sent from Atos and it might also include the response code from the bank. Format: &#x60;aa,bb&#x60; with the two values separated by a comma and where: - &#x60;aa&#x60; is the two-digit error message from Atos. - &#x60;bb&#x60; is the optional two-digit error message from the bank.  #### Comercio Latino This value is the status code and the error or response code received from the processor separated by a colon. Format: [status code]:E[error code] or [status code]:R[response code] Example &#x60;2:R06&#x60;  #### JCN Gateway Processor-defined detail error code. The associated response category code is in the &#x60;processorInformation.responseCategoryCode&#x60; field. String (3) </value>
        [DataMember(Name="responseCode", EmitDefaultValue=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// Gets or Sets AchVerification
        /// </summary>
        [DataMember(Name="achVerification", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseProcessorInformationAchVerification AchVerification { get; set; }

        /// <summary>
        /// Same value as &#x60;processorInformation.transactionId&#x60;
        /// </summary>
        /// <value>Same value as &#x60;processorInformation.transactionId&#x60;</value>
        [DataMember(Name="networkTransactionId", EmitDefaultValue=false)]
        public string NetworkTransactionId { get; set; }

        /// <summary>
        /// Field contains a settlement date. The date is in mmdd format, where: mm &#x3D; month and dd &#x3D; day. 
        /// </summary>
        /// <value>Field contains a settlement date. The date is in mmdd format, where: mm &#x3D; month and dd &#x3D; day. </value>
        [DataMember(Name="settlementDate", EmitDefaultValue=false)]
        public string SettlementDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsRefundPost201ResponseProcessorInformation {\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  ForwardedAcquirerCode: ").Append(ForwardedAcquirerCode).Append("\n");
            sb.Append("  MerchantNumber: ").Append(MerchantNumber).Append("\n");
            sb.Append("  ResponseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  AchVerification: ").Append(AchVerification).Append("\n");
            sb.Append("  NetworkTransactionId: ").Append(NetworkTransactionId).Append("\n");
            sb.Append("  SettlementDate: ").Append(SettlementDate).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsRefundPost201ResponseProcessorInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsRefundPost201ResponseProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsRefundPost201ResponseProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsRefundPost201ResponseProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApprovalCode == other.ApprovalCode ||
                    this.ApprovalCode != null &&
                    this.ApprovalCode.Equals(other.ApprovalCode)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
                ) && 
                (
                    this.ForwardedAcquirerCode == other.ForwardedAcquirerCode ||
                    this.ForwardedAcquirerCode != null &&
                    this.ForwardedAcquirerCode.Equals(other.ForwardedAcquirerCode)
                ) && 
                (
                    this.MerchantNumber == other.MerchantNumber ||
                    this.MerchantNumber != null &&
                    this.MerchantNumber.Equals(other.MerchantNumber)
                ) && 
                (
                    this.ResponseCode == other.ResponseCode ||
                    this.ResponseCode != null &&
                    this.ResponseCode.Equals(other.ResponseCode)
                ) && 
                (
                    this.AchVerification == other.AchVerification ||
                    this.AchVerification != null &&
                    this.AchVerification.Equals(other.AchVerification)
                ) && 
                (
                    this.NetworkTransactionId == other.NetworkTransactionId ||
                    this.NetworkTransactionId != null &&
                    this.NetworkTransactionId.Equals(other.NetworkTransactionId)
                ) && 
                (
                    this.SettlementDate == other.SettlementDate ||
                    this.SettlementDate != null &&
                    this.SettlementDate.Equals(other.SettlementDate)
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
                if (this.ApprovalCode != null)
                    hash = hash * 59 + this.ApprovalCode.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
                if (this.ForwardedAcquirerCode != null)
                    hash = hash * 59 + this.ForwardedAcquirerCode.GetHashCode();
                if (this.MerchantNumber != null)
                    hash = hash * 59 + this.MerchantNumber.GetHashCode();
                if (this.ResponseCode != null)
                    hash = hash * 59 + this.ResponseCode.GetHashCode();
                if (this.AchVerification != null)
                    hash = hash * 59 + this.AchVerification.GetHashCode();
                if (this.NetworkTransactionId != null)
                    hash = hash * 59 + this.NetworkTransactionId.GetHashCode();
                if (this.SettlementDate != null)
                    hash = hash * 59 + this.SettlementDate.GetHashCode();
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
