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
    /// Boardingv1registrationsIntegrationInformationTenantInformation
    /// </summary>
    [DataContract]
    public partial class Boardingv1registrationsIntegrationInformationTenantInformation :  IEquatable<Boardingv1registrationsIntegrationInformationTenantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsIntegrationInformationTenantInformation" /> class.
        /// </summary>
        /// <param name="TenantId">The TenantId is an external Solution Identifier given by Tech Partners like SAP..</param>
        public Boardingv1registrationsIntegrationInformationTenantInformation(string TenantId = default(string))
        {
            this.TenantId = TenantId;
        }
        
        /// <summary>
        /// The TenantId is an external Solution Identifier given by Tech Partners like SAP.
        /// </summary>
        /// <value>The TenantId is an external Solution Identifier given by Tech Partners like SAP.</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boardingv1registrationsIntegrationInformationTenantInformation {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(obj as Boardingv1registrationsIntegrationInformationTenantInformation);
        }

        /// <summary>
        /// Returns true if Boardingv1registrationsIntegrationInformationTenantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Boardingv1registrationsIntegrationInformationTenantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boardingv1registrationsIntegrationInformationTenantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TenantId == other.TenantId ||
                    this.TenantId != null &&
                    this.TenantId.Equals(other.TenantId)
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
                if (this.TenantId != null)
                    hash = hash * 59 + this.TenantId.GetHashCode();
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
