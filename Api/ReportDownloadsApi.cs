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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;
using NLog;
using AuthenticationSdk.util;
using CyberSource.Utilities.Tracking;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportDownloadsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Download a Report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns></returns>
        void DownloadReport (DateTime? reportDate, string reportName, string organizationId = null);

        /// <summary>
        /// Download a Report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DownloadReportWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download a Report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DownloadReportAsync (DateTime? reportDate, string reportName, string organizationId = null);

        /// <summary>
        /// Download a Report
        /// </summary>
        /// <remarks>
        /// Download a report using the unique report name and date. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DownloadReportAsyncWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportDownloadsApi : IReportDownloadsApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDownloadsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportDownloadsApi(string basePath)
        {
            Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                Configuration.ApiClient.Configuration = Configuration;
            }

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportDownloadsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReportDownloadsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                Configuration = Configuration.Default;
            else
                Configuration = configuration;

            ExceptionFactory = Configuration.DefaultExceptionFactory;

            Configuration.ApiClient.Configuration = Configuration;

            if (logger == null)
            {
                logger = LogManager.GetCurrentClassLogger();
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.Options.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    logger.Error("InvalidOperationException : Multicast delegate for ExceptionFactory is unsupported.");
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<string, string> DefaultHeader()
        {
            return Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieves the status code being set for the most recently executed API request.
        /// </summary>
        /// <returns>Status Code of previous request</returns>
        public int GetStatusCode()
        {
            return this._statusCode == null ? 0 : (int) this._statusCode;
        }

        /// <summary>
        /// Sets the value of status code for the most recently executed API request, in order to be retrieved later.
        /// </summary>
        /// <param name="statusCode">Status Code to be set</param>
        /// <returns></returns>
        public void SetStatusCode(int? statusCode)
        {
            this._statusCode = statusCode;
        }

        /// <summary>
        /// Download a Report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns></returns>
        public void DownloadReport (DateTime? reportDate, string reportName, string organizationId = null)
        {
            logger.Debug("CALLING API \"DownloadReport\" STARTED");
            this.SetStatusCode(null);
            DownloadReportWithHttpInfo(reportDate, reportName, organizationId);
        }

        /// <summary>
        /// Download a Report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DownloadReportWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'reportDate' is set
            if (reportDate == null)
            {
                logger.Error("ApiException : Missing required parameter 'reportDate' when calling ReportDownloadsApi->DownloadReport");
                throw new ApiException(400, "Missing required parameter 'reportDate' when calling ReportDownloadsApi->DownloadReport");
            }
            // verify the required parameter 'reportName' is set
            if (reportName == null)
            {
                logger.Error("ApiException : Missing required parameter 'reportName' when calling ReportDownloadsApi->DownloadReport");
                throw new ApiException(400, "Missing required parameter 'reportName' when calling ReportDownloadsApi->DownloadReport");
            }

            var localVarPath = $"/reporting/v3/report-downloads";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/xml",
                "text/csv"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            if (reportDate != null)
            {
                localVarQueryParams.Add("reportDate", Configuration.ApiClient.ParameterToString(reportDate)); // query parameter
            }
            if (reportName != null)
            {
                localVarQueryParams.Add("reportName", Configuration.ApiClient.ParameterToString(reportName)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DownloadReport", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            this.SetStatusCode(localVarStatusCode);
            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content); // Return statement
        }

        /// <summary>
        /// Download a Report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DownloadReportAsync (DateTime? reportDate, string reportName, string organizationId = null)
        {
            logger.Debug("CALLING API \"DownloadReportAsync\" STARTED");
            this.SetStatusCode(null);
            await DownloadReportAsyncWithHttpInfo(reportDate, reportName, organizationId);

        }

        /// <summary>
        /// Download a Report Download a report using the unique report name and date. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportDate">Valid date on which to download the report in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format.[Rfc Date Format](https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14)  **Example date format:**  yyyy-mm-dd For reports that span multiple days, this value would be the end date of the report in the time zone of the report subscription. Example 1: If your report start date is 2020-03-06 and the end date is 2020-03-09, the reportDate passed in the query is 2020-03-09. Example 2: If your report runs from midnight to midnight on 2020-03-09, the reportDate passed in the query is 2020-03-10 </param>
        /// <param name="reportName">Name of the report to download</param>
        /// <param name="organizationId">Valid Organization Id (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DownloadReportAsyncWithHttpInfo (DateTime? reportDate, string reportName, string organizationId = null)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'reportDate' is set
            if (reportDate == null)
            {
                logger.Error("ApiException : Missing required parameter 'reportDate' when calling ReportDownloadsApi->DownloadReport");
                throw new ApiException(400, "Missing required parameter 'reportDate' when calling ReportDownloadsApi->DownloadReport");
            }
            // verify the required parameter 'reportName' is set
            if (reportName == null)
            {
                logger.Error("ApiException : Missing required parameter 'reportName' when calling ReportDownloadsApi->DownloadReport");
                throw new ApiException(400, "Missing required parameter 'reportName' when calling ReportDownloadsApi->DownloadReport");
            }

            var localVarPath = $"/reporting/v3/report-downloads";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json;charset=utf-8"
            };
            string localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/xml",
                "text/csv"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (organizationId != null)
            {
                localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            }
            if (reportDate != null)
            {
                localVarQueryParams.Add("reportDate", Configuration.ApiClient.ParameterToString(reportDate)); // query parameter
            }
            if (reportName != null)
            {
                localVarQueryParams.Add("reportName", Configuration.ApiClient.ParameterToString(reportName)); // query parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarQueryParams)}");
            if (Method.Get == Method.Post)
            {
                localVarPostBody = "{}";
            }
            else
            {
                localVarPostBody = null;
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DownloadReport", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            this.SetStatusCode(localVarStatusCode);
            return new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                localVarResponse.Content); // Return statement
        }
    }
}
