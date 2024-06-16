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
    /// PredefinedSubscriptionRequestBean
    /// </summary>
    [DataContract]
    public partial class PredefinedSubscriptionRequestBean :  IEquatable<PredefinedSubscriptionRequestBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedSubscriptionRequestBean" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PredefinedSubscriptionRequestBean() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedSubscriptionRequestBean" /> class.
        /// </summary>
        /// <param name="ReportDefinitionName">Valid Report Definition Name (required).</param>
        /// <param name="SubscriptionType">The subscription type for which report definition is required. Valid values are CLASSIC and STANDARD. Valid Values:   - CLASSIC   - STANDARD  (required).</param>
        /// <param name="ReportName">ReportName.</param>
        /// <param name="ReportMimeType">Report Format             Valid Values:   - application/xml   - text/csv .</param>
        /// <param name="ReportFrequency">&#39;The frequency for which subscription is created. For Standard we can have DAILY, WEEKLY and MONTHLY. But for Classic we will have only DAILY.&#39; **NOTE: Do not document USER_DEFINED Frequency field in developer center** Valid Values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;USER_DEFINED&#39; .</param>
        /// <param name="ReportInterval">If the reportFrequency is User-defined, reportInterval should be in **ISO 8601 time format** Please refer the following link to know more about ISO 8601 format.[Rfc Time Format](https://en.wikipedia.org/wiki/ISO_8601#Durations)  **Example time format for 2 hours and 30 Mins:**   - PT2H30M **NOTE: Do not document reportInterval field in developer center** .</param>
        /// <param name="Timezone">By Default the timezone for Standard subscription is PST. And for Classic subscription it will be GMT. If user provides any other time zone apart from PST for Standard subscription api should error out..</param>
        /// <param name="StartTime">The hour at which the report generation should start. It should be in hhmm format. By Default it will be 0000. The format is 24 hours format..</param>
        /// <param name="StartDay">This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1..</param>
        /// <param name="SubscriptionStatus">The status for subscription which is either created or updated. By default it is ACTIVE. Valid Values:   - ACTIVE   - INACTIVE .</param>
        public PredefinedSubscriptionRequestBean(string ReportDefinitionName = default(string), string SubscriptionType = default(string), string ReportName = default(string), string ReportMimeType = default(string), string ReportFrequency = default(string), string ReportInterval = default(string), string Timezone = default(string), string StartTime = default(string), int? StartDay = default(int?), string SubscriptionStatus = default(string))
        {
            this.ReportDefinitionName = ReportDefinitionName;
            this.SubscriptionType = SubscriptionType;
            this.ReportName = ReportName;
            this.ReportMimeType = ReportMimeType;
            this.ReportFrequency = ReportFrequency;
            this.ReportInterval = ReportInterval;
            this.Timezone = Timezone;
            this.StartTime = StartTime;
            this.StartDay = StartDay;
            this.SubscriptionStatus = SubscriptionStatus;
        }
        
        /// <summary>
        /// Valid Report Definition Name
        /// </summary>
        /// <value>Valid Report Definition Name</value>
        [DataMember(Name="reportDefinitionName", EmitDefaultValue=false)]
        public string ReportDefinitionName { get; set; }

        /// <summary>
        /// The subscription type for which report definition is required. Valid values are CLASSIC and STANDARD. Valid Values:   - CLASSIC   - STANDARD 
        /// </summary>
        /// <value>The subscription type for which report definition is required. Valid values are CLASSIC and STANDARD. Valid Values:   - CLASSIC   - STANDARD </value>
        [DataMember(Name="subscriptionType", EmitDefaultValue=false)]
        public string SubscriptionType { get; set; }

        /// <summary>
        /// Gets or Sets ReportName
        /// </summary>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }

        /// <summary>
        /// Report Format             Valid Values:   - application/xml   - text/csv 
        /// </summary>
        /// <value>Report Format             Valid Values:   - application/xml   - text/csv </value>
        [DataMember(Name="reportMimeType", EmitDefaultValue=false)]
        public string ReportMimeType { get; set; }

        /// <summary>
        /// &#39;The frequency for which subscription is created. For Standard we can have DAILY, WEEKLY and MONTHLY. But for Classic we will have only DAILY.&#39; **NOTE: Do not document USER_DEFINED Frequency field in developer center** Valid Values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;USER_DEFINED&#39; 
        /// </summary>
        /// <value>&#39;The frequency for which subscription is created. For Standard we can have DAILY, WEEKLY and MONTHLY. But for Classic we will have only DAILY.&#39; **NOTE: Do not document USER_DEFINED Frequency field in developer center** Valid Values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;USER_DEFINED&#39; </value>
        [DataMember(Name="reportFrequency", EmitDefaultValue=false)]
        public string ReportFrequency { get; set; }

        /// <summary>
        /// If the reportFrequency is User-defined, reportInterval should be in **ISO 8601 time format** Please refer the following link to know more about ISO 8601 format.[Rfc Time Format](https://en.wikipedia.org/wiki/ISO_8601#Durations)  **Example time format for 2 hours and 30 Mins:**   - PT2H30M **NOTE: Do not document reportInterval field in developer center** 
        /// </summary>
        /// <value>If the reportFrequency is User-defined, reportInterval should be in **ISO 8601 time format** Please refer the following link to know more about ISO 8601 format.[Rfc Time Format](https://en.wikipedia.org/wiki/ISO_8601#Durations)  **Example time format for 2 hours and 30 Mins:**   - PT2H30M **NOTE: Do not document reportInterval field in developer center** </value>
        [DataMember(Name="reportInterval", EmitDefaultValue=false)]
        public string ReportInterval { get; set; }

        /// <summary>
        /// By Default the timezone for Standard subscription is PST. And for Classic subscription it will be GMT. If user provides any other time zone apart from PST for Standard subscription api should error out.
        /// </summary>
        /// <value>By Default the timezone for Standard subscription is PST. And for Classic subscription it will be GMT. If user provides any other time zone apart from PST for Standard subscription api should error out.</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// The hour at which the report generation should start. It should be in hhmm format. By Default it will be 0000. The format is 24 hours format.
        /// </summary>
        /// <value>The hour at which the report generation should start. It should be in hhmm format. By Default it will be 0000. The format is 24 hours format.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1.
        /// </summary>
        /// <value>This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1.</value>
        [DataMember(Name="startDay", EmitDefaultValue=false)]
        public int? StartDay { get; set; }

        /// <summary>
        /// The status for subscription which is either created or updated. By default it is ACTIVE. Valid Values:   - ACTIVE   - INACTIVE 
        /// </summary>
        /// <value>The status for subscription which is either created or updated. By default it is ACTIVE. Valid Values:   - ACTIVE   - INACTIVE </value>
        [DataMember(Name="subscriptionStatus", EmitDefaultValue=false)]
        public string SubscriptionStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PredefinedSubscriptionRequestBean {\n");
            sb.Append("  ReportDefinitionName: ").Append(ReportDefinitionName).Append("\n");
            sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportMimeType: ").Append(ReportMimeType).Append("\n");
            sb.Append("  ReportFrequency: ").Append(ReportFrequency).Append("\n");
            sb.Append("  ReportInterval: ").Append(ReportInterval).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartDay: ").Append(StartDay).Append("\n");
            sb.Append("  SubscriptionStatus: ").Append(SubscriptionStatus).Append("\n");
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
            return this.Equals(obj as PredefinedSubscriptionRequestBean);
        }

        /// <summary>
        /// Returns true if PredefinedSubscriptionRequestBean instances are equal
        /// </summary>
        /// <param name="other">Instance of PredefinedSubscriptionRequestBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PredefinedSubscriptionRequestBean other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportDefinitionName == other.ReportDefinitionName ||
                    this.ReportDefinitionName != null &&
                    this.ReportDefinitionName.Equals(other.ReportDefinitionName)
                ) && 
                (
                    this.SubscriptionType == other.SubscriptionType ||
                    this.SubscriptionType != null &&
                    this.SubscriptionType.Equals(other.SubscriptionType)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.ReportMimeType == other.ReportMimeType ||
                    this.ReportMimeType != null &&
                    this.ReportMimeType.Equals(other.ReportMimeType)
                ) && 
                (
                    this.ReportFrequency == other.ReportFrequency ||
                    this.ReportFrequency != null &&
                    this.ReportFrequency.Equals(other.ReportFrequency)
                ) && 
                (
                    this.ReportInterval == other.ReportInterval ||
                    this.ReportInterval != null &&
                    this.ReportInterval.Equals(other.ReportInterval)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.StartDay == other.StartDay ||
                    this.StartDay != null &&
                    this.StartDay.Equals(other.StartDay)
                ) && 
                (
                    this.SubscriptionStatus == other.SubscriptionStatus ||
                    this.SubscriptionStatus != null &&
                    this.SubscriptionStatus.Equals(other.SubscriptionStatus)
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
                if (this.ReportDefinitionName != null)
                    hash = hash * 59 + this.ReportDefinitionName.GetHashCode();
                if (this.SubscriptionType != null)
                    hash = hash * 59 + this.SubscriptionType.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.ReportMimeType != null)
                    hash = hash * 59 + this.ReportMimeType.GetHashCode();
                if (this.ReportFrequency != null)
                    hash = hash * 59 + this.ReportFrequency.GetHashCode();
                if (this.ReportInterval != null)
                    hash = hash * 59 + this.ReportInterval.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.StartDay != null)
                    hash = hash * 59 + this.StartDay.GetHashCode();
                if (this.SubscriptionStatus != null)
                    hash = hash * 59 + this.SubscriptionStatus.GetHashCode();
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
            // ReportDefinitionName (string) pattern
            Regex regexReportDefinitionName = new Regex(@"[a-zA-Z]+", RegexOptions.CultureInvariant);
            if (false == regexReportDefinitionName.Match(this.ReportDefinitionName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, must match a pattern of " + regexReportDefinitionName, new [] { "ReportDefinitionName" });
            }

            // ReportName (string) pattern
            Regex regexReportName = new Regex(@"[a-zA-Z0-9-_ ]+", RegexOptions.CultureInvariant);
            if (false == regexReportName.Match(this.ReportName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, must match a pattern of " + regexReportName, new [] { "ReportName" });
            }

            // ReportInterval (string) pattern
            Regex regexReportInterval = new Regex(@"^PT((([1-9]|1[0-9]|2[0-3])H(([1-9]|[1-4][0-9]|5[0-9])M)?)|((([1-9]|1[0-9]|2[0-3])H)?([1-9]|[1-4][0-9]|5[0-9])M))$", RegexOptions.CultureInvariant);
            if (false == regexReportInterval.Match(this.ReportInterval).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportInterval, must match a pattern of " + regexReportInterval, new [] { "ReportInterval" });
            }

            // StartDay (int?) maximum
            if(this.StartDay >= (int?)31)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDay, must be a value less than or equal to 31.", new [] { "StartDay" });
            }

            // StartDay (int?) minimum
            if(this.StartDay <= (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDay, must be a value greater than or equal to 1.", new [] { "StartDay" });
            }

            yield break;
        }
    }

}
