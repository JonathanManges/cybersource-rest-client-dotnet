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
    /// InlineResponse2011
    /// </summary>
    [DataContract]
    public partial class InlineResponse2011 :  IEquatable<InlineResponse2011>, IValidatableObject
    {
        /// <summary>
        /// The status of Registration request Possible Values:   - &#39;INITIALIZED&#39;   - &#39;RECEIVED&#39;   - &#39;PROCESSING&#39;   - &#39;SUCCESS&#39;   - &#39;FAILURE&#39;   - &#39;PARTIAL&#39; 
        /// </summary>
        /// <value>The status of Registration request Possible Values:   - &#39;INITIALIZED&#39;   - &#39;RECEIVED&#39;   - &#39;PROCESSING&#39;   - &#39;SUCCESS&#39;   - &#39;FAILURE&#39;   - &#39;PARTIAL&#39; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum INITIALIZED for "INITIALIZED"
            /// </summary>
            [EnumMember(Value = "INITIALIZED")]
            INITIALIZED,
            
            /// <summary>
            /// Enum RECEIVED for "RECEIVED"
            /// </summary>
            [EnumMember(Value = "RECEIVED")]
            RECEIVED,
            
            /// <summary>
            /// Enum PROCESSING for "PROCESSING"
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING,
            
            /// <summary>
            /// Enum SUCCESS for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS,
            
            /// <summary>
            /// Enum FAILURE for "FAILURE"
            /// </summary>
            [EnumMember(Value = "FAILURE")]
            FAILURE,
            
            /// <summary>
            /// Enum PARTIAL for "PARTIAL"
            /// </summary>
            [EnumMember(Value = "PARTIAL")]
            PARTIAL
        }

        /// <summary>
        /// The status of Registration request Possible Values:   - &#39;INITIALIZED&#39;   - &#39;RECEIVED&#39;   - &#39;PROCESSING&#39;   - &#39;SUCCESS&#39;   - &#39;FAILURE&#39;   - &#39;PARTIAL&#39; 
        /// </summary>
        /// <value>The status of Registration request Possible Values:   - &#39;INITIALIZED&#39;   - &#39;RECEIVED&#39;   - &#39;PROCESSING&#39;   - &#39;SUCCESS&#39;   - &#39;FAILURE&#39;   - &#39;PARTIAL&#39; </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2011" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SubmitTimeUtc">Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. .</param>
        /// <param name="RegistrationInformation">RegistrationInformation.</param>
        /// <param name="IntegrationInformation">IntegrationInformation.</param>
        /// <param name="OrganizationInformation">OrganizationInformation.</param>
        /// <param name="ProductInformationSetups">ProductInformationSetups.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Details">Details.</param>
        public InlineResponse2011(string Id = default(string), DateTime? SubmitTimeUtc = default(DateTime?), InlineResponse2011RegistrationInformation RegistrationInformation = default(InlineResponse2011RegistrationInformation), InlineResponse2011IntegrationInformation IntegrationInformation = default(InlineResponse2011IntegrationInformation), InlineResponse2011OrganizationInformation OrganizationInformation = default(InlineResponse2011OrganizationInformation), List<InlineResponse2011ProductInformationSetups> ProductInformationSetups = default(List<InlineResponse2011ProductInformationSetups>), string Message = default(string), Dictionary<string, List<Object>> Details = default(Dictionary<string, List<Object>>))
        {
            this.Id = Id;
            this.SubmitTimeUtc = SubmitTimeUtc;
            this.RegistrationInformation = RegistrationInformation;
            this.IntegrationInformation = IntegrationInformation;
            this.OrganizationInformation = OrganizationInformation;
            this.ProductInformationSetups = ProductInformationSetups;
            this.Message = Message;
            this.Details = Details;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. 
        /// </summary>
        /// <value>Time of request in UTC. &#x60;Format: YYYY-MM-DDThh:mm:ssZ&#x60;  Example 2016-08-11T22:47:57Z equals August 11, 2016, at 22:47:57 (10:47:57 p.m.). The T separates the date and the time. The Z indicates UTC. </value>
        [DataMember(Name="submitTimeUtc", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? SubmitTimeUtc { get; set; }


        /// <summary>
        /// Gets or Sets RegistrationInformation
        /// </summary>
        [DataMember(Name="registrationInformation", EmitDefaultValue=false)]
        public InlineResponse2011RegistrationInformation RegistrationInformation { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationInformation
        /// </summary>
        [DataMember(Name="integrationInformation", EmitDefaultValue=false)]
        public InlineResponse2011IntegrationInformation IntegrationInformation { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationInformation
        /// </summary>
        [DataMember(Name="organizationInformation", EmitDefaultValue=false)]
        public InlineResponse2011OrganizationInformation OrganizationInformation { get; set; }

        /// <summary>
        /// Gets or Sets ProductInformationSetups
        /// </summary>
        [DataMember(Name="productInformationSetups", EmitDefaultValue=false)]
        public List<InlineResponse2011ProductInformationSetups> ProductInformationSetups { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public Dictionary<string, List<Object>> Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2011 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SubmitTimeUtc: ").Append(SubmitTimeUtc).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  RegistrationInformation: ").Append(RegistrationInformation).Append("\n");
            sb.Append("  IntegrationInformation: ").Append(IntegrationInformation).Append("\n");
            sb.Append("  OrganizationInformation: ").Append(OrganizationInformation).Append("\n");
            sb.Append("  ProductInformationSetups: ").Append(ProductInformationSetups).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(obj as InlineResponse2011);
        }

        /// <summary>
        /// Returns true if InlineResponse2011 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2011 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2011 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SubmitTimeUtc == other.SubmitTimeUtc ||
                    this.SubmitTimeUtc != null &&
                    this.SubmitTimeUtc.Equals(other.SubmitTimeUtc)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.RegistrationInformation == other.RegistrationInformation ||
                    this.RegistrationInformation != null &&
                    this.RegistrationInformation.Equals(other.RegistrationInformation)
                ) && 
                (
                    this.IntegrationInformation == other.IntegrationInformation ||
                    this.IntegrationInformation != null &&
                    this.IntegrationInformation.Equals(other.IntegrationInformation)
                ) && 
                (
                    this.OrganizationInformation == other.OrganizationInformation ||
                    this.OrganizationInformation != null &&
                    this.OrganizationInformation.Equals(other.OrganizationInformation)
                ) && 
                (
                    this.ProductInformationSetups == other.ProductInformationSetups ||
                    this.ProductInformationSetups != null &&
                    this.ProductInformationSetups.SequenceEqual(other.ProductInformationSetups)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Details == other.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(other.Details)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SubmitTimeUtc != null)
                    hash = hash * 59 + this.SubmitTimeUtc.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.RegistrationInformation != null)
                    hash = hash * 59 + this.RegistrationInformation.GetHashCode();
                if (this.IntegrationInformation != null)
                    hash = hash * 59 + this.IntegrationInformation.GetHashCode();
                if (this.OrganizationInformation != null)
                    hash = hash * 59 + this.OrganizationInformation.GetHashCode();
                if (this.ProductInformationSetups != null)
                    hash = hash * 59 + this.ProductInformationSetups.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Details != null)
                    hash = hash * 59 + this.Details.GetHashCode();
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
