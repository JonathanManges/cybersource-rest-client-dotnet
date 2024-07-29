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
    /// Riskv1exportcomplianceinquiriesOrderInformationLineItems
    /// </summary>
    [DataContract]
    public partial class Riskv1exportcomplianceinquiriesOrderInformationLineItems :  IEquatable<Riskv1exportcomplianceinquiriesOrderInformationLineItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1exportcomplianceinquiriesOrderInformationLineItems" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Riskv1exportcomplianceinquiriesOrderInformationLineItems() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1exportcomplianceinquiriesOrderInformationLineItems" /> class.
        /// </summary>
        /// <param name="UnitPrice">Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15)  (required).</param>
        /// <param name="AllowedExportCountries">AllowedExportCountries.</param>
        /// <param name="RestrictedExportCountries">RestrictedExportCountries.</param>
        /// <param name="Quantity">Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. .</param>
        /// <param name="ProductSKU">Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling. .</param>
        /// <param name="ProductRisk">Indicates the level of risk for the product. This field can contain one of the following values: - &#x60;low&#x60;: The product is associated with few chargebacks. - &#x60;normal&#x60;: The product is associated with a normal number of chargebacks. - &#x60;high&#x60;: The product is associated with many chargebacks. .</param>
        /// <param name="ProductName">For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. .</param>
        /// <param name="ProductCode">Type of product. The value for this field is used to identify the product category (electronic, handling, physical, service, or shipping). The default value is &#x60;default&#x60;.  If you are performing an authorization transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;false&#x60;), and you set this field to a value other than &#x60;default&#x60; or one of the values related to shipping and/or handling, then &#x60;orderInformation.lineItems[].quantity&#x60;, &#x60;orderInformation.lineItems[].productName&#x60;, and &#x60;orderInformation.lineItems[].productSku&#x60; fields are required.  Optional field.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don&#39;t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you&#39;ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields]. .</param>
        public Riskv1exportcomplianceinquiriesOrderInformationLineItems(string UnitPrice = default(string), List<string> AllowedExportCountries = default(List<string>), List<string> RestrictedExportCountries = default(List<string>), int? Quantity = default(int?), string ProductSKU = default(string), string ProductRisk = default(string), string ProductName = default(string), string ProductCode = default(string))
        {
            this.UnitPrice = UnitPrice;
            this.AllowedExportCountries = AllowedExportCountries;
            this.RestrictedExportCountries = RestrictedExportCountries;
            this.Quantity = Quantity;
            this.ProductSKU = ProductSKU;
            this.ProductRisk = ProductRisk;
            this.ProductName = ProductName;
            this.ProductCode = ProductCode;
        }
        
        /// <summary>
        /// Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15) 
        /// </summary>
        /// <value>Per-item price of the product. This value for this field cannot be negative.  You must include either this field or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  You can include a decimal point (.), but you cannot include any other special characters. The value is truncated to the correct number of decimal places.  #### DCC with a Third-Party Provider Set this field to the converted amount that was returned by the DCC provider. You must include either the 1st line item in the order and this field, or the request-level field &#x60;orderInformation.amountDetails.totalAmount&#x60; in your request.  #### Tax Calculation Required field for U.S., Canadian, international and value added taxes.  #### Zero Amount Authorizations If your processor supports zero amount authorizations, you can set this field to 0 for the authorization to check if the card is lost or stolen.  #### Maximum Field Lengths For GPN and JCN Gateway: Decimal (10) All other processors: Decimal (15) </value>
        [DataMember(Name="unitPrice", EmitDefaultValue=false)]
        public string UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets AllowedExportCountries
        /// </summary>
        [DataMember(Name="allowedExportCountries", EmitDefaultValue=false)]
        public List<string> AllowedExportCountries { get; set; }

        /// <summary>
        /// Gets or Sets RestrictedExportCountries
        /// </summary>
        [DataMember(Name="restrictedExportCountries", EmitDefaultValue=false)]
        public List<string> RestrictedExportCountries { get; set; }

        /// <summary>
        /// Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. 
        /// </summary>
        /// <value>Number of units for this order. Must be a non-negative integer.  The default is &#x60;1&#x60;. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. </value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling. 
        /// </summary>
        /// <value>Product identifier code. Also known as the Stock Keeping Unit (SKU) code for the product.  For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not set to **default** or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S. and Canadian taxes. Not applicable to international and value added taxes. For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the values related to shipping and/or handling. </value>
        [DataMember(Name="productSKU", EmitDefaultValue=false)]
        public string ProductSKU { get; set; }

        /// <summary>
        /// Indicates the level of risk for the product. This field can contain one of the following values: - &#x60;low&#x60;: The product is associated with few chargebacks. - &#x60;normal&#x60;: The product is associated with a normal number of chargebacks. - &#x60;high&#x60;: The product is associated with many chargebacks. 
        /// </summary>
        /// <value>Indicates the level of risk for the product. This field can contain one of the following values: - &#x60;low&#x60;: The product is associated with few chargebacks. - &#x60;normal&#x60;: The product is associated with a normal number of chargebacks. - &#x60;high&#x60;: The product is associated with many chargebacks. </value>
        [DataMember(Name="productRisk", EmitDefaultValue=false)]
        public string ProductRisk { get; set; }

        /// <summary>
        /// For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. 
        /// </summary>
        /// <value>For an authorization or capture transaction (&#x60;processingOptions.capture&#x60; is &#x60;true&#x60; or &#x60;false&#x60;), this field is required when &#x60;orderInformation.lineItems[].productCode&#x60; is not &#x60;default&#x60; or one of the other values that are related to shipping and/or handling.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. </value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Type of product. The value for this field is used to identify the product category (electronic, handling, physical, service, or shipping). The default value is &#x60;default&#x60;.  If you are performing an authorization transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;false&#x60;), and you set this field to a value other than &#x60;default&#x60; or one of the values related to shipping and/or handling, then &#x60;orderInformation.lineItems[].quantity&#x60;, &#x60;orderInformation.lineItems[].productName&#x60;, and &#x60;orderInformation.lineItems[].productSku&#x60; fields are required.  Optional field.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don&#39;t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you&#39;ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields]. 
        /// </summary>
        /// <value>Type of product. The value for this field is used to identify the product category (electronic, handling, physical, service, or shipping). The default value is &#x60;default&#x60;.  If you are performing an authorization transaction (&#x60;processingOptions.capture&#x60; is set to &#x60;false&#x60;), and you set this field to a value other than &#x60;default&#x60; or one of the values related to shipping and/or handling, then &#x60;orderInformation.lineItems[].quantity&#x60;, &#x60;orderInformation.lineItems[].productName&#x60;, and &#x60;orderInformation.lineItems[].productSku&#x60; fields are required.  Optional field.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes.  The Product Codes for the tax service are located in the Cybersource Tax Codes guide. Contact Customer Support to request the guide. If you don&#39;t send a tax service Product Code in your tax request, product-based rules or exemptions will not be applied and the transaction will default to fully taxable in the locations where you&#39;ve indicated you need to collect tax [by way of nexus, no nexus, or seller registration number fields]. </value>
        [DataMember(Name="productCode", EmitDefaultValue=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1exportcomplianceinquiriesOrderInformationLineItems {\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  AllowedExportCountries: ").Append(AllowedExportCountries).Append("\n");
            sb.Append("  RestrictedExportCountries: ").Append(RestrictedExportCountries).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ProductSKU: ").Append(ProductSKU).Append("\n");
            sb.Append("  ProductRisk: ").Append(ProductRisk).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(obj as Riskv1exportcomplianceinquiriesOrderInformationLineItems);
        }

        /// <summary>
        /// Returns true if Riskv1exportcomplianceinquiriesOrderInformationLineItems instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1exportcomplianceinquiriesOrderInformationLineItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1exportcomplianceinquiriesOrderInformationLineItems other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnitPrice == other.UnitPrice ||
                    this.UnitPrice != null &&
                    this.UnitPrice.Equals(other.UnitPrice)
                ) && 
                (
                    this.AllowedExportCountries == other.AllowedExportCountries ||
                    this.AllowedExportCountries != null &&
                    this.AllowedExportCountries.SequenceEqual(other.AllowedExportCountries)
                ) && 
                (
                    this.RestrictedExportCountries == other.RestrictedExportCountries ||
                    this.RestrictedExportCountries != null &&
                    this.RestrictedExportCountries.SequenceEqual(other.RestrictedExportCountries)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
                ) && 
                (
                    this.ProductSKU == other.ProductSKU ||
                    this.ProductSKU != null &&
                    this.ProductSKU.Equals(other.ProductSKU)
                ) && 
                (
                    this.ProductRisk == other.ProductRisk ||
                    this.ProductRisk != null &&
                    this.ProductRisk.Equals(other.ProductRisk)
                ) && 
                (
                    this.ProductName == other.ProductName ||
                    this.ProductName != null &&
                    this.ProductName.Equals(other.ProductName)
                ) && 
                (
                    this.ProductCode == other.ProductCode ||
                    this.ProductCode != null &&
                    this.ProductCode.Equals(other.ProductCode)
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
                if (this.UnitPrice != null)
                    hash = hash * 59 + this.UnitPrice.GetHashCode();
                if (this.AllowedExportCountries != null)
                    hash = hash * 59 + this.AllowedExportCountries.GetHashCode();
                if (this.RestrictedExportCountries != null)
                    hash = hash * 59 + this.RestrictedExportCountries.GetHashCode();
                if (this.Quantity != null)
                    hash = hash * 59 + this.Quantity.GetHashCode();
                if (this.ProductSKU != null)
                    hash = hash * 59 + this.ProductSKU.GetHashCode();
                if (this.ProductRisk != null)
                    hash = hash * 59 + this.ProductRisk.GetHashCode();
                if (this.ProductName != null)
                    hash = hash * 59 + this.ProductName.GetHashCode();
                if (this.ProductCode != null)
                    hash = hash * 59 + this.ProductCode.GetHashCode();
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
