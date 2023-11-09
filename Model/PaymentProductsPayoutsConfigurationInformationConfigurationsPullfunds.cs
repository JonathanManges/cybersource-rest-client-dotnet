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
    /// Formatted as *{payoutsAcquirerName}. The property name field should be the same as the processor name for which the pull funds or push funds feature is being configured. Here is the list of valid processor names [TBD]
    /// </summary>
    [DataContract]
    public partial class PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds :  IEquatable<PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds" /> class.
        /// </summary>
        /// <param name="AcquirerOrganizationId">Valid organization in OMS with an organizationInformation.type as \&quot;acquirer\&quot;..</param>
        /// <param name="AcquiringBIN">This code identifies the financial institution acting as the acquirer of this transaction. The acquirer is the client or system user that signed the originator or installed the unattended cardholder- activated environment. When a processing center operates for multiple acquirers, this code is for the individual client or system user, not a code for the center. (required).</param>
        /// <param name="AllowCryptoCurrencyPurchase">This configuration allows a transaction to be flagged for cryptocurrency funds transfer..</param>
        /// <param name="CardAcceptorId">A unique identifier number for the originator of transfers that is unique to the processor or acquirer. (required).</param>
        /// <param name="OriginatorMvv">Merchant Verification Value (MVV) is used to identify originators that participate in a variety of programs. The MVV is unique to the merchant..</param>
        /// <param name="OriginatorNameAbbreviation">A 4 character max name abbreviation for the originator..</param>
        /// <param name="CardTerminalId">This field contains a code that identifies a terminal at the card acceptor location. This field is used in all messages related to a transaction. If sending transactions from a card not present environment, use the same value for all transactions. (required).</param>
        public PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds(string AcquirerOrganizationId = default(string), int? AcquiringBIN = default(int?), bool? AllowCryptoCurrencyPurchase = default(bool?), string CardAcceptorId = default(string), string OriginatorMvv = default(string), string OriginatorNameAbbreviation = default(string), string CardTerminalId = default(string))
        {
            // to ensure "AcquiringBIN" is required (not null)
            if (AcquiringBIN == null)
            {
                throw new InvalidDataException("AcquiringBIN is a required property for PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds and cannot be null");
            }
            else
            {
                this.AcquiringBIN = AcquiringBIN;
            }
            // to ensure "CardAcceptorId" is required (not null)
            if (CardAcceptorId == null)
            {
                throw new InvalidDataException("CardAcceptorId is a required property for PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds and cannot be null");
            }
            else
            {
                this.CardAcceptorId = CardAcceptorId;
            }
            // to ensure "CardTerminalId" is required (not null)
            if (CardTerminalId == null)
            {
                throw new InvalidDataException("CardTerminalId is a required property for PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds and cannot be null");
            }
            else
            {
                this.CardTerminalId = CardTerminalId;
            }
            this.AcquirerOrganizationId = AcquirerOrganizationId;
            this.AllowCryptoCurrencyPurchase = AllowCryptoCurrencyPurchase;
            this.OriginatorMvv = OriginatorMvv;
            this.OriginatorNameAbbreviation = OriginatorNameAbbreviation;
        }
        
        /// <summary>
        /// Valid organization in OMS with an organizationInformation.type as \&quot;acquirer\&quot;.
        /// </summary>
        /// <value>Valid organization in OMS with an organizationInformation.type as \&quot;acquirer\&quot;.</value>
        [DataMember(Name="acquirerOrganizationId", EmitDefaultValue=false)]
        public string AcquirerOrganizationId { get; set; }

        /// <summary>
        /// This code identifies the financial institution acting as the acquirer of this transaction. The acquirer is the client or system user that signed the originator or installed the unattended cardholder- activated environment. When a processing center operates for multiple acquirers, this code is for the individual client or system user, not a code for the center.
        /// </summary>
        /// <value>This code identifies the financial institution acting as the acquirer of this transaction. The acquirer is the client or system user that signed the originator or installed the unattended cardholder- activated environment. When a processing center operates for multiple acquirers, this code is for the individual client or system user, not a code for the center.</value>
        [DataMember(Name="acquiringBIN", EmitDefaultValue=false)]
        public int? AcquiringBIN { get; set; }

        /// <summary>
        /// This configuration allows a transaction to be flagged for cryptocurrency funds transfer.
        /// </summary>
        /// <value>This configuration allows a transaction to be flagged for cryptocurrency funds transfer.</value>
        [DataMember(Name="allowCryptoCurrencyPurchase", EmitDefaultValue=false)]
        public bool? AllowCryptoCurrencyPurchase { get; set; }

        /// <summary>
        /// A unique identifier number for the originator of transfers that is unique to the processor or acquirer.
        /// </summary>
        /// <value>A unique identifier number for the originator of transfers that is unique to the processor or acquirer.</value>
        [DataMember(Name="cardAcceptorId", EmitDefaultValue=false)]
        public string CardAcceptorId { get; set; }

        /// <summary>
        /// Merchant Verification Value (MVV) is used to identify originators that participate in a variety of programs. The MVV is unique to the merchant.
        /// </summary>
        /// <value>Merchant Verification Value (MVV) is used to identify originators that participate in a variety of programs. The MVV is unique to the merchant.</value>
        [DataMember(Name="originatorMvv", EmitDefaultValue=false)]
        public string OriginatorMvv { get; set; }

        /// <summary>
        /// A 4 character max name abbreviation for the originator.
        /// </summary>
        /// <value>A 4 character max name abbreviation for the originator.</value>
        [DataMember(Name="originatorNameAbbreviation", EmitDefaultValue=false)]
        public string OriginatorNameAbbreviation { get; set; }

        /// <summary>
        /// This field contains a code that identifies a terminal at the card acceptor location. This field is used in all messages related to a transaction. If sending transactions from a card not present environment, use the same value for all transactions.
        /// </summary>
        /// <value>This field contains a code that identifies a terminal at the card acceptor location. This field is used in all messages related to a transaction. If sending transactions from a card not present environment, use the same value for all transactions.</value>
        [DataMember(Name="cardTerminalId", EmitDefaultValue=false)]
        public string CardTerminalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds {\n");
            sb.Append("  AcquirerOrganizationId: ").Append(AcquirerOrganizationId).Append("\n");
            sb.Append("  AcquiringBIN: ").Append(AcquiringBIN).Append("\n");
            sb.Append("  AllowCryptoCurrencyPurchase: ").Append(AllowCryptoCurrencyPurchase).Append("\n");
            sb.Append("  CardAcceptorId: ").Append(CardAcceptorId).Append("\n");
            sb.Append("  OriginatorMvv: ").Append(OriginatorMvv).Append("\n");
            sb.Append("  OriginatorNameAbbreviation: ").Append(OriginatorNameAbbreviation).Append("\n");
            sb.Append("  CardTerminalId: ").Append(CardTerminalId).Append("\n");
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
            return this.Equals(obj as PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds);
        }

        /// <summary>
        /// Returns true if PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductsPayoutsConfigurationInformationConfigurationsPullfunds other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcquirerOrganizationId == other.AcquirerOrganizationId ||
                    this.AcquirerOrganizationId != null &&
                    this.AcquirerOrganizationId.Equals(other.AcquirerOrganizationId)
                ) && 
                (
                    this.AcquiringBIN == other.AcquiringBIN ||
                    this.AcquiringBIN != null &&
                    this.AcquiringBIN.Equals(other.AcquiringBIN)
                ) && 
                (
                    this.AllowCryptoCurrencyPurchase == other.AllowCryptoCurrencyPurchase ||
                    this.AllowCryptoCurrencyPurchase != null &&
                    this.AllowCryptoCurrencyPurchase.Equals(other.AllowCryptoCurrencyPurchase)
                ) && 
                (
                    this.CardAcceptorId == other.CardAcceptorId ||
                    this.CardAcceptorId != null &&
                    this.CardAcceptorId.Equals(other.CardAcceptorId)
                ) && 
                (
                    this.OriginatorMvv == other.OriginatorMvv ||
                    this.OriginatorMvv != null &&
                    this.OriginatorMvv.Equals(other.OriginatorMvv)
                ) && 
                (
                    this.OriginatorNameAbbreviation == other.OriginatorNameAbbreviation ||
                    this.OriginatorNameAbbreviation != null &&
                    this.OriginatorNameAbbreviation.Equals(other.OriginatorNameAbbreviation)
                ) && 
                (
                    this.CardTerminalId == other.CardTerminalId ||
                    this.CardTerminalId != null &&
                    this.CardTerminalId.Equals(other.CardTerminalId)
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
                if (this.AcquirerOrganizationId != null)
                    hash = hash * 59 + this.AcquirerOrganizationId.GetHashCode();
                if (this.AcquiringBIN != null)
                    hash = hash * 59 + this.AcquiringBIN.GetHashCode();
                if (this.AllowCryptoCurrencyPurchase != null)
                    hash = hash * 59 + this.AllowCryptoCurrencyPurchase.GetHashCode();
                if (this.CardAcceptorId != null)
                    hash = hash * 59 + this.CardAcceptorId.GetHashCode();
                if (this.OriginatorMvv != null)
                    hash = hash * 59 + this.OriginatorMvv.GetHashCode();
                if (this.OriginatorNameAbbreviation != null)
                    hash = hash * 59 + this.OriginatorNameAbbreviation.GetHashCode();
                if (this.CardTerminalId != null)
                    hash = hash * 59 + this.CardTerminalId.GetHashCode();
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
