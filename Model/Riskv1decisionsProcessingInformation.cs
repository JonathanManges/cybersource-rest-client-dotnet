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
    /// Decides whether to call Payer Authentication or Watchlist Screening service along with DM or not.
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsProcessingInformation :  IEquatable<Riskv1decisionsProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsProcessingInformation" /> class.
        /// </summary>
        /// <param name="ActionList">- Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service. .</param>
        public Riskv1decisionsProcessingInformation(List<string> ActionList = default(List<string>))
        {
            this.ActionList = ActionList;
        }
        
        /// <summary>
        /// - Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service. 
        /// </summary>
        /// <value>- Use &#x60;CONSUMER_AUTHENTICATION&#x60; to use Payer Authentication along with Decision Manager. For any other value, only Decision Manager will run. - Use &#x60;WATCHLIST_SCREENING&#x60;  when you want to call Watchlist Screening service. </value>
        [DataMember(Name="actionList", EmitDefaultValue=false)]
        public List<string> ActionList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsProcessingInformation {\n");
            sb.Append("  ActionList: ").Append(ActionList).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsProcessingInformation);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ActionList == other.ActionList ||
                    this.ActionList != null &&
                    this.ActionList.SequenceEqual(other.ActionList)
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
                if (this.ActionList != null)
                    hash = hash * 59 + this.ActionList.GetHashCode();
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
