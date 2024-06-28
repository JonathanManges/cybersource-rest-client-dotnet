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
    /// Boardingv1registrationsOrganizationInformationKYCDepositBankAccount
    /// </summary>
    [DataContract]
    public partial class Boardingv1registrationsOrganizationInformationKYCDepositBankAccount :  IEquatable<Boardingv1registrationsOrganizationInformationKYCDepositBankAccount>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            
            /// <summary>
            /// Enum Checking for "checking"
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking,
            
            /// <summary>
            /// Enum Savings for "savings"
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings,
            
            /// <summary>
            /// Enum Corporatechecking for "corporatechecking"
            /// </summary>
            [EnumMember(Value = "corporatechecking")]
            Corporatechecking,
            
            /// <summary>
            /// Enum Corporatesavings for "corporatesavings"
            /// </summary>
            [EnumMember(Value = "corporatesavings")]
            Corporatesavings
        }
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="accountType", EmitDefaultValue=false)]
        public AccountTypeEnum? AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformationKYCDepositBankAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Boardingv1registrationsOrganizationInformationKYCDepositBankAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformationKYCDepositBankAccount" /> class.
        /// </summary>
        /// <param name="AccountHolderName">AccountHolderName (required).</param>
        /// <param name="AccountType">AccountType (required).</param>
        /// <param name="AccountRoutingNumber">AccountRoutingNumber (required).</param>
        /// <param name="AccountNumber">AccountNumber (required).</param>
        public Boardingv1registrationsOrganizationInformationKYCDepositBankAccount(string AccountHolderName = default(string), AccountTypeEnum? AccountType = default(AccountTypeEnum?), string AccountRoutingNumber = default(string), string AccountNumber = default(string))
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountType = AccountType;
            this.AccountRoutingNumber = AccountRoutingNumber;
            this.AccountNumber = AccountNumber;
        }
        
        /// <summary>
        /// Gets or Sets AccountHolderName
        /// </summary>
        [DataMember(Name="accountHolderName", EmitDefaultValue=false)]
        public string AccountHolderName { get; set; }


        /// <summary>
        /// Gets or Sets AccountRoutingNumber
        /// </summary>
        [DataMember(Name="accountRoutingNumber", EmitDefaultValue=false)]
        public string AccountRoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boardingv1registrationsOrganizationInformationKYCDepositBankAccount {\n");
            sb.Append("  AccountHolderName: ").Append(AccountHolderName).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountRoutingNumber: ").Append(AccountRoutingNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
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
            return this.Equals(obj as Boardingv1registrationsOrganizationInformationKYCDepositBankAccount);
        }

        /// <summary>
        /// Returns true if Boardingv1registrationsOrganizationInformationKYCDepositBankAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of Boardingv1registrationsOrganizationInformationKYCDepositBankAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boardingv1registrationsOrganizationInformationKYCDepositBankAccount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountHolderName == other.AccountHolderName ||
                    this.AccountHolderName != null &&
                    this.AccountHolderName.Equals(other.AccountHolderName)
                ) && 
                (
                    this.AccountType == other.AccountType ||
                    this.AccountType != null &&
                    this.AccountType.Equals(other.AccountType)
                ) && 
                (
                    this.AccountRoutingNumber == other.AccountRoutingNumber ||
                    this.AccountRoutingNumber != null &&
                    this.AccountRoutingNumber.Equals(other.AccountRoutingNumber)
                ) && 
                (
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
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
                if (this.AccountHolderName != null)
                    hash = hash * 59 + this.AccountHolderName.GetHashCode();
                if (this.AccountType != null)
                    hash = hash * 59 + this.AccountType.GetHashCode();
                if (this.AccountRoutingNumber != null)
                    hash = hash * 59 + this.AccountRoutingNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
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
