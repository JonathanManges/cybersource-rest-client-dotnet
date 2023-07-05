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
    /// PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING :  IEquatable<PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING" /> class.
        /// </summary>
        /// <param name="Status">The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED .</param>
        /// <param name="Reason">The reason of the status. Value can be   - &#x60;CUSTOMER_WATCHLIST_MATCH&#x60;   - &#x60;ADDRESS_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;EMAIL_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;IP_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; .</param>
        /// <param name="Message">The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match .</param>
        public PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING(string Status = default(string), string Reason = default(string), string Message = default(string))
        {
            this.Status = Status;
            this.Reason = Reason;
            this.Message = Message;
        }
        
        /// <summary>
        /// The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED 
        /// </summary>
        /// <value>The status for the call can be: - COMPLETED - INVALID_REQUEST - DECLINED </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The reason of the status. Value can be   - &#x60;CUSTOMER_WATCHLIST_MATCH&#x60;   - &#x60;ADDRESS_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;EMAIL_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;IP_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; 
        /// </summary>
        /// <value>The reason of the status. Value can be   - &#x60;CUSTOMER_WATCHLIST_MATCH&#x60;   - &#x60;ADDRESS_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;EMAIL_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;IP_COUNTRY_WATCHLIST_MATCH&#x60;   - &#x60;INVALID_MERCHANT_CONFIGURATION&#x60; </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match 
        /// </summary>
        /// <value>The message describing the reason of the status. Value can be   - The customer matched the Denied Parties List   - The Export bill_country/ship_country  match   - Export email_country match   - Export hostname_country/ip_country match </value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseEmbeddedActionsWATCHLISTSCREENING other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
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
