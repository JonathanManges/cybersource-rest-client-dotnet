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
    /// PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment
    /// </summary>
    [DataContract]
    public partial class PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment :  IEquatable<PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment" /> class.
        /// </summary>
        /// <param name="EnableInstallment">This flag is to enable for installment plan programs. Applicable for Fiserv (fiserv), Vero (vero) and American Express Direct (amexdirect) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; .</param>
        /// <param name="InstallmentPlan">This indicates the type of funding for the installment plan associated with the payment.  Valid values: \&quot;merchant\&quot; - Merchant-funded installment plan \&quot;issuer\&quot; - Issuer-funded installment plan  Applicable for Fiserv (fiserv), American Express Direct (amexdirect) and Vero (vero) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; .</param>
        public PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment(bool? EnableInstallment = default(bool?), string InstallmentPlan = default(string))
        {
            this.EnableInstallment = EnableInstallment;
            this.InstallmentPlan = InstallmentPlan;
        }
        
        /// <summary>
        /// This flag is to enable for installment plan programs. Applicable for Fiserv (fiserv), Vero (vero) and American Express Direct (amexdirect) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>This flag is to enable for installment plan programs. Applicable for Fiserv (fiserv), Vero (vero) and American Express Direct (amexdirect) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;th&gt;Default Value&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name="enableInstallment", EmitDefaultValue=false)]
        public bool? EnableInstallment { get; set; }

        /// <summary>
        /// This indicates the type of funding for the installment plan associated with the payment.  Valid values: \&quot;merchant\&quot; - Merchant-funded installment plan \&quot;issuer\&quot; - Issuer-funded installment plan  Applicable for Fiserv (fiserv), American Express Direct (amexdirect) and Vero (vero) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; 
        /// </summary>
        /// <value>This indicates the type of funding for the installment plan associated with the payment.  Valid values: \&quot;merchant\&quot; - Merchant-funded installment plan \&quot;issuer\&quot; - Issuer-funded installment plan  Applicable for Fiserv (fiserv), American Express Direct (amexdirect) and Vero (vero) processors.  Validation details (for selected processors)...  &lt;table&gt; &lt;thead&gt;&lt;tr&gt;&lt;th&gt;Processor&lt;/th&gt;&lt;th&gt;Acceptance Type&lt;/th&gt;&lt;th&gt;Required&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt; &lt;tr&gt;&lt;td&gt;American Express Direct&lt;/td&gt;&lt;td&gt;cnp&lt;/td&gt;&lt;td&gt;No&lt;/td&gt;&lt;/tr&gt; &lt;/table&gt; </value>
        [DataMember(Name="installmentPlan", EmitDefaultValue=false)]
        public string InstallmentPlan { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment {\n");
            sb.Append("  EnableInstallment: ").Append(EnableInstallment).Append("\n");
            sb.Append("  InstallmentPlan: ").Append(InstallmentPlan).Append("\n");
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
            return this.Equals(obj as PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment);
        }

        /// <summary>
        /// Returns true if PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentProductsCardProcessingConfigurationInformationConfigurationsFeaturesCardNotPresentInstallment other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EnableInstallment == other.EnableInstallment ||
                    this.EnableInstallment != null &&
                    this.EnableInstallment.Equals(other.EnableInstallment)
                ) && 
                (
                    this.InstallmentPlan == other.InstallmentPlan ||
                    this.InstallmentPlan != null &&
                    this.InstallmentPlan.Equals(other.InstallmentPlan)
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
                if (this.EnableInstallment != null)
                    hash = hash * 59 + this.EnableInstallment.GetHashCode();
                if (this.InstallmentPlan != null)
                    hash = hash * 59 + this.InstallmentPlan.GetHashCode();
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
