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
    /// PaymentProductsVirtualTerminal
    /// </summary>
    [DataContract]
    public partial class PaymentProductsVirtualTerminal :  IEquatable<PaymentProductsVirtualTerminal>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsVirtualTerminal" /> class.
        /// </summary>
        /// <param name="SubscriptionInformation">SubscriptionInformation.</param>
        /// <param name="ConfigurationInformation">ConfigurationInformation.</param>
        public PaymentProductsVirtualTerminal(PaymentProductsPayerAuthenticationSubscriptionInformation SubscriptionInformation = default(PaymentProductsPayerAuthenticationSubscriptionInformation), PaymentProductsVirtualTerminalConfigurationInformation ConfigurationInformation = default(PaymentProductsVirtualTerminalConfigurationInformation))
        {
            this.SubscriptionInformation = SubscriptionInformation;
            this.ConfigurationInformation = ConfigurationInformation;
        }
        
        /// <summary>
        /// Gets or Sets SubscriptionInformation
        /// </summary>
        [DataMember(Name="subscriptionInformation", EmitDefaultValue=false)]
        public PaymentProductsPayerAuthenticationSubscriptionInformation SubscriptionInformation { get; set; }

        /// <summary>
        /// Gets or Sets ConfigurationInformation
        /// </summary>
        [DataMember(Name="configurationInformation", EmitDefaultValue=false)]
        public PaymentProductsVirtualTerminalConfigurationInformation ConfigurationInformation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductsVirtualTerminal {\n");
            sb.Append("  SubscriptionInformation: ").Append(SubscriptionInformation).Append("\n");
            sb.Append("  ConfigurationInformation: ").Append(ConfigurationInformation).Append("\n");
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
            return this.Equals(obj as PaymentProductsVirtualTerminal);
        }

        /// <summary>
        /// Returns true if PaymentProductsVirtualTerminal instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductsVirtualTerminal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductsVirtualTerminal other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SubscriptionInformation == other.SubscriptionInformation ||
                    this.SubscriptionInformation != null &&
                    this.SubscriptionInformation.Equals(other.SubscriptionInformation)
                ) && 
                (
                    this.ConfigurationInformation == other.ConfigurationInformation ||
                    this.ConfigurationInformation != null &&
                    this.ConfigurationInformation.Equals(other.ConfigurationInformation)
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
                if (this.SubscriptionInformation != null)
                    hash = hash * 59 + this.SubscriptionInformation.GetHashCode();
                if (this.ConfigurationInformation != null)
                    hash = hash * 59 + this.ConfigurationInformation.GetHashCode();
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
