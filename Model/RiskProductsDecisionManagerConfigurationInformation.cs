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
    /// RiskProductsDecisionManagerConfigurationInformation
    /// </summary>
    [DataContract]
    public partial class RiskProductsDecisionManagerConfigurationInformation :  IEquatable<RiskProductsDecisionManagerConfigurationInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskProductsDecisionManagerConfigurationInformation" /> class.
        /// </summary>
        /// <param name="TemplateId">TemplateId.</param>
        /// <param name="Configurations">Configurations.</param>
        public RiskProductsDecisionManagerConfigurationInformation(Guid? TemplateId = default(Guid?), RiskProductsDecisionManagerConfigurationInformationConfigurations Configurations = default(RiskProductsDecisionManagerConfigurationInformationConfigurations))
        {
            this.TemplateId = TemplateId;
            this.Configurations = Configurations;
        }
        
        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets Configurations
        /// </summary>
        [DataMember(Name="configurations", EmitDefaultValue=false)]
        public RiskProductsDecisionManagerConfigurationInformationConfigurations Configurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskProductsDecisionManagerConfigurationInformation {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Configurations: ").Append(Configurations).Append("\n");
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
            return this.Equals(obj as RiskProductsDecisionManagerConfigurationInformation);
        }

        /// <summary>
        /// Returns true if RiskProductsDecisionManagerConfigurationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskProductsDecisionManagerConfigurationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskProductsDecisionManagerConfigurationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.Configurations == other.Configurations ||
                    this.Configurations != null &&
                    this.Configurations.Equals(other.Configurations)
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
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.Configurations != null)
                    hash = hash * 59 + this.Configurations.GetHashCode();
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
