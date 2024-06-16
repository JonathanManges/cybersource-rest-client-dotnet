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
    /// Boardingv1registrationsOrganizationInformation
    /// </summary>
    [DataContract]
    public partial class Boardingv1registrationsOrganizationInformation :  IEquatable<Boardingv1registrationsOrganizationInformation>, IValidatableObject
    {
        /// <summary>
        /// Determines the type of organization in the hirarchy that this registration will use to onboard this Organization Possible Values:   - &#39;TRANSACTING&#39;   - &#39;STRUCTURAL&#39;   - &#39;MERCHANT&#39; 
        /// </summary>
        /// <value>Determines the type of organization in the hirarchy that this registration will use to onboard this Organization Possible Values:   - &#39;TRANSACTING&#39;   - &#39;STRUCTURAL&#39;   - &#39;MERCHANT&#39; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum TRANSACTING for "TRANSACTING"
            /// </summary>
            [EnumMember(Value = "TRANSACTING")]
            TRANSACTING,
            
            /// <summary>
            /// Enum STRUCTURAL for "STRUCTURAL"
            /// </summary>
            [EnumMember(Value = "STRUCTURAL")]
            STRUCTURAL,
            
            /// <summary>
            /// Enum MERCHANT for "MERCHANT"
            /// </summary>
            [EnumMember(Value = "MERCHANT")]
            MERCHANT
        }
        /// <summary>
        /// Determines the status that the organization will be after being onboarded Possible Values:             - &#39;LIVE&#39;             - &#39;TEST&#39;             - &#39;DRAFT&#39; 
        /// </summary>
        /// <value>Determines the status that the organization will be after being onboarded Possible Values:             - &#39;LIVE&#39;             - &#39;TEST&#39;             - &#39;DRAFT&#39; </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum LIVE for "LIVE"
            /// </summary>
            [EnumMember(Value = "LIVE")]
            LIVE,
            
            /// <summary>
            /// Enum TEST for "TEST"
            /// </summary>
            [EnumMember(Value = "TEST")]
            TEST,
            
            /// <summary>
            /// Enum DRAFT for "DRAFT"
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT
        }
        /// <summary>
        /// Determines the type of organization in the hirarchy that this registration will use to onboard this Organization Possible Values:   - &#39;TRANSACTING&#39;   - &#39;STRUCTURAL&#39;   - &#39;MERCHANT&#39; 
        /// </summary>
        /// <value>Determines the type of organization in the hirarchy that this registration will use to onboard this Organization Possible Values:   - &#39;TRANSACTING&#39;   - &#39;STRUCTURAL&#39;   - &#39;MERCHANT&#39; </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Determines the status that the organization will be after being onboarded Possible Values:             - &#39;LIVE&#39;             - &#39;TEST&#39;             - &#39;DRAFT&#39; 
        /// </summary>
        /// <value>Determines the status that the organization will be after being onboarded Possible Values:             - &#39;LIVE&#39;             - &#39;TEST&#39;             - &#39;DRAFT&#39; </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Boardingv1registrationsOrganizationInformation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Boardingv1registrationsOrganizationInformation" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="ParentOrganizationId">This field is required for Organization Types: MERCHANT, TRANSACTING .</param>
        /// <param name="Type">Determines the type of organization in the hirarchy that this registration will use to onboard this Organization Possible Values:   - &#39;TRANSACTING&#39;   - &#39;STRUCTURAL&#39;   - &#39;MERCHANT&#39; .</param>
        /// <param name="Status">Determines the status that the organization will be after being onboarded Possible Values:             - &#39;LIVE&#39;             - &#39;TEST&#39;             - &#39;DRAFT&#39; .</param>
        /// <param name="Configurable">This denotes the one organization, with exception to the TRANSACTING types, that is allowed to be used for configuration purposes against products.  Eventually this field will be deprecated and all organizations will be allowed for product configuration. (default to false).</param>
        /// <param name="BusinessInformation">BusinessInformation (required).</param>
        /// <param name="KYC">KYC.</param>
        /// <param name="Owners">Owners.</param>
        public Boardingv1registrationsOrganizationInformation(string OrganizationId = default(string), string ParentOrganizationId = default(string), TypeEnum? Type = default(TypeEnum?), StatusEnum? Status = default(StatusEnum?), bool? Configurable = false, Boardingv1registrationsOrganizationInformationBusinessInformation BusinessInformation = default(Boardingv1registrationsOrganizationInformationBusinessInformation), Boardingv1registrationsOrganizationInformationKYC KYC = default(Boardingv1registrationsOrganizationInformationKYC), List<Boardingv1registrationsOrganizationInformationOwners> Owners = default(List<Boardingv1registrationsOrganizationInformationOwners>))
        {
            this.OrganizationId = OrganizationId;
            this.ParentOrganizationId = ParentOrganizationId;
            this.Type = Type;
            this.Status = Status;
            // use default value if no "Configurable" provided
            if (Configurable == null)
            {
                this.Configurable = false;
            }
            else
            {
                this.Configurable = Configurable;
            }
            this.BusinessInformation = BusinessInformation;
            this.KYC = KYC;
            this.Owners = Owners;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// This field is required for Organization Types: MERCHANT, TRANSACTING 
        /// </summary>
        /// <value>This field is required for Organization Types: MERCHANT, TRANSACTING </value>
        [DataMember(Name="parentOrganizationId", EmitDefaultValue=false)]
        public string ParentOrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ChildOrganizations
        /// </summary>
        [DataMember(Name="childOrganizations", EmitDefaultValue=false)]
        public List<string> ChildOrganizations { get; private set; }



        /// <summary>
        /// This denotes the one organization, with exception to the TRANSACTING types, that is allowed to be used for configuration purposes against products.  Eventually this field will be deprecated and all organizations will be allowed for product configuration.
        /// </summary>
        /// <value>This denotes the one organization, with exception to the TRANSACTING types, that is allowed to be used for configuration purposes against products.  Eventually this field will be deprecated and all organizations will be allowed for product configuration.</value>
        [DataMember(Name="configurable", EmitDefaultValue=false)]
        public bool? Configurable { get; set; }

        /// <summary>
        /// Gets or Sets BusinessInformation
        /// </summary>
        [DataMember(Name="businessInformation", EmitDefaultValue=false)]
        public Boardingv1registrationsOrganizationInformationBusinessInformation BusinessInformation { get; set; }

        /// <summary>
        /// Gets or Sets KYC
        /// </summary>
        [DataMember(Name="KYC", EmitDefaultValue=false)]
        public Boardingv1registrationsOrganizationInformationKYC KYC { get; set; }

        /// <summary>
        /// Gets or Sets Owners
        /// </summary>
        [DataMember(Name="owners", EmitDefaultValue=false)]
        public List<Boardingv1registrationsOrganizationInformationOwners> Owners { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Boardingv1registrationsOrganizationInformation {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ParentOrganizationId: ").Append(ParentOrganizationId).Append("\n");
            sb.Append("  ChildOrganizations: ").Append(ChildOrganizations).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Configurable: ").Append(Configurable).Append("\n");
            sb.Append("  BusinessInformation: ").Append(BusinessInformation).Append("\n");
            sb.Append("  KYC: ").Append(KYC).Append("\n");
            sb.Append("  Owners: ").Append(Owners).Append("\n");
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
            return this.Equals(obj as Boardingv1registrationsOrganizationInformation);
        }

        /// <summary>
        /// Returns true if Boardingv1registrationsOrganizationInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Boardingv1registrationsOrganizationInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Boardingv1registrationsOrganizationInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ParentOrganizationId == other.ParentOrganizationId ||
                    this.ParentOrganizationId != null &&
                    this.ParentOrganizationId.Equals(other.ParentOrganizationId)
                ) && 
                (
                    this.ChildOrganizations == other.ChildOrganizations ||
                    this.ChildOrganizations != null &&
                    this.ChildOrganizations.SequenceEqual(other.ChildOrganizations)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Configurable == other.Configurable ||
                    this.Configurable != null &&
                    this.Configurable.Equals(other.Configurable)
                ) && 
                (
                    this.BusinessInformation == other.BusinessInformation ||
                    this.BusinessInformation != null &&
                    this.BusinessInformation.Equals(other.BusinessInformation)
                ) && 
                (
                    this.KYC == other.KYC ||
                    this.KYC != null &&
                    this.KYC.Equals(other.KYC)
                ) && 
                (
                    this.Owners == other.Owners ||
                    this.Owners != null &&
                    this.Owners.SequenceEqual(other.Owners)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ParentOrganizationId != null)
                    hash = hash * 59 + this.ParentOrganizationId.GetHashCode();
                if (this.ChildOrganizations != null)
                    hash = hash * 59 + this.ChildOrganizations.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Configurable != null)
                    hash = hash * 59 + this.Configurable.GetHashCode();
                if (this.BusinessInformation != null)
                    hash = hash * 59 + this.BusinessInformation.GetHashCode();
                if (this.KYC != null)
                    hash = hash * 59 + this.KYC.GetHashCode();
                if (this.Owners != null)
                    hash = hash * 59 + this.Owners.GetHashCode();
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
            // OrganizationId (string) pattern
            Regex regexOrganizationId = new Regex(@"^[0-9a-zA-Z_]+$", RegexOptions.CultureInvariant);
            if (false == regexOrganizationId.Match(this.OrganizationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrganizationId, must match a pattern of " + regexOrganizationId, new [] { "OrganizationId" });
            }

            // ParentOrganizationId (string) pattern
            Regex regexParentOrganizationId = new Regex(@"^[0-9a-zA-Z_]+$", RegexOptions.CultureInvariant);
            if (false == regexParentOrganizationId.Match(this.ParentOrganizationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ParentOrganizationId, must match a pattern of " + regexParentOrganizationId, new [] { "ParentOrganizationId" });
            }

            yield break;
        }
    }

}
