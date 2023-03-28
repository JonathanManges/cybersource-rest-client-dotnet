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
    /// InlineResponse2006Links
    /// </summary>
    [DataContract]
    public partial class InlineResponse2006Links :  IEquatable<InlineResponse2006Links>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2006Links" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Cancel">Cancel.</param>
        /// <param name="Suspend">Suspend.</param>
        /// <param name="Activate">Activate.</param>
        public InlineResponse2006Links(PtsV2PaymentsPost201ResponseLinksSelf Self = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf Cancel = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf Suspend = default(PtsV2PaymentsPost201ResponseLinksSelf), PtsV2PaymentsPost201ResponseLinksSelf Activate = default(PtsV2PaymentsPost201ResponseLinksSelf))
        {
            this.Self = Self;
            this.Cancel = Cancel;
            this.Suspend = Suspend;
            this.Activate = Activate;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Cancel
        /// </summary>
        [DataMember(Name="cancel", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Cancel { get; set; }

        /// <summary>
        /// Gets or Sets Suspend
        /// </summary>
        [DataMember(Name="suspend", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Suspend { get; set; }

        /// <summary>
        /// Gets or Sets Activate
        /// </summary>
        [DataMember(Name="activate", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseLinksSelf Activate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2006Links {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Cancel: ").Append(Cancel).Append("\n");
            sb.Append("  Suspend: ").Append(Suspend).Append("\n");
            sb.Append("  Activate: ").Append(Activate).Append("\n");
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
            return this.Equals(obj as InlineResponse2006Links);
        }

        /// <summary>
        /// Returns true if InlineResponse2006Links instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2006Links to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2006Links other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Cancel == other.Cancel ||
                    this.Cancel != null &&
                    this.Cancel.Equals(other.Cancel)
                ) && 
                (
                    this.Suspend == other.Suspend ||
                    this.Suspend != null &&
                    this.Suspend.Equals(other.Suspend)
                ) && 
                (
                    this.Activate == other.Activate ||
                    this.Activate != null &&
                    this.Activate.Equals(other.Activate)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Cancel != null)
                    hash = hash * 59 + this.Cancel.GetHashCode();
                if (this.Suspend != null)
                    hash = hash * 59 + this.Suspend.GetHashCode();
                if (this.Activate != null)
                    hash = hash * 59 + this.Activate.GetHashCode();
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
