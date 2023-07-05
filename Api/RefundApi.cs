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
    public interface IRefundApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        PtsV2PaymentsRefundPost201Response RefundCapture (RefundCaptureRequest refundCaptureRequest, string id);

        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        ApiResponse<PtsV2PaymentsRefundPost201Response> RefundCaptureWithHttpInfo (RefundCaptureRequest refundCaptureRequest, string id);
        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        PtsV2PaymentsRefundPost201Response RefundPayment (RefundPaymentRequest refundPaymentRequest, string id);

        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        ApiResponse<PtsV2PaymentsRefundPost201Response> RefundPaymentWithHttpInfo (RefundPaymentRequest refundPaymentRequest, string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsRefundPost201Response> RefundCaptureAsync (RefundCaptureRequest refundCaptureRequest, string id);

        /// <summary>
        /// Refund a Capture
        /// </summary>
        /// <remarks>
        /// Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundCaptureAsyncWithHttpInfo (RefundCaptureRequest refundCaptureRequest, string id);
        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        System.Threading.Tasks.Task<PtsV2PaymentsRefundPost201Response> RefundPaymentAsync (RefundPaymentRequest refundPaymentRequest, string id);

        /// <summary>
        /// Refund a Payment
        /// </summary>
        /// <remarks>
        /// Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundPaymentAsyncWithHttpInfo (RefundPaymentRequest refundPaymentRequest, string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RefundApi : IRefundApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefundApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RefundApi(string basePath)
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
        /// Initializes a new instance of the <see cref="RefundApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RefundApi(Configuration configuration = null)
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
        /// Refund a Capture Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        public PtsV2PaymentsRefundPost201Response RefundCapture (RefundCaptureRequest refundCaptureRequest, string id)
        {
            logger.Debug("CALLING API \"RefundCapture\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = RefundCaptureWithHttpInfo(refundCaptureRequest, id);
            logger.Debug("CALLING API \"RefundCapture\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Refund a Capture Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        public ApiResponse< PtsV2PaymentsRefundPost201Response > RefundCaptureWithHttpInfo (RefundCaptureRequest refundCaptureRequest, string id)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'refundCaptureRequest' is set
            if (refundCaptureRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'refundCaptureRequest' when calling RefundApi->RefundCapture");
                throw new ApiException(400, "Missing required parameter 'refundCaptureRequest' when calling RefundApi->RefundCapture");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling RefundApi->RefundCapture");
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundCapture");
            }

            var localVarPath = $"/pts/v2/captures/{id}/refunds";
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
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (refundCaptureRequest != null && refundCaptureRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                refundCaptureRequest = (RefundCaptureRequest)sdkTracker.InsertDeveloperIdTracker(refundCaptureRequest, refundCaptureRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(refundCaptureRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundCaptureRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundCapture", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response))); // Return statement
        }

        /// <summary>
        /// Refund a Capture Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsRefundPost201Response> RefundCaptureAsync (RefundCaptureRequest refundCaptureRequest, string id)
        {
            logger.Debug("CALLING API \"RefundCaptureAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = await RefundCaptureAsyncWithHttpInfo(refundCaptureRequest, id);
            logger.Debug("CALLING API \"RefundCaptureAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Refund a Capture Refund a capture API is only used, if you have requested Capture independenlty using [/pts/v2/payments/{id}/captures](https://developer.cybersource.com/api-reference-assets/index.html#payments_capture) API call. Include the capture ID in the POST request to refund the captured amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundCaptureRequest"></param>
        /// <param name="id">The capture ID. This ID is returned from a previous capture request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundCaptureAsyncWithHttpInfo (RefundCaptureRequest refundCaptureRequest, string id)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'refundCaptureRequest' is set
            if (refundCaptureRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'refundCaptureRequest' when calling RefundApi->RefundCapture");
                throw new ApiException(400, "Missing required parameter 'refundCaptureRequest' when calling RefundApi->RefundCapture");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling RefundApi->RefundCapture");
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundCapture");
            }

            var localVarPath = $"/pts/v2/captures/{id}/refunds";
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
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (refundCaptureRequest != null && refundCaptureRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                refundCaptureRequest = (RefundCaptureRequest)sdkTracker.InsertDeveloperIdTracker(refundCaptureRequest, refundCaptureRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(refundCaptureRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundCaptureRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundCapture", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response))); // Return statement
        }
        /// <summary>
        /// Refund a Payment Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>PtsV2PaymentsRefundPost201Response</returns>
        public PtsV2PaymentsRefundPost201Response RefundPayment (RefundPaymentRequest refundPaymentRequest, string id)
        {
            logger.Debug("CALLING API \"RefundPayment\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = RefundPaymentWithHttpInfo(refundPaymentRequest, id);
            logger.Debug("CALLING API \"RefundPayment\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Refund a Payment Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>ApiResponse of PtsV2PaymentsRefundPost201Response</returns>
        public ApiResponse< PtsV2PaymentsRefundPost201Response > RefundPaymentWithHttpInfo (RefundPaymentRequest refundPaymentRequest, string id)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'refundPaymentRequest' is set
            if (refundPaymentRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'refundPaymentRequest' when calling RefundApi->RefundPayment");
                throw new ApiException(400, "Missing required parameter 'refundPaymentRequest' when calling RefundApi->RefundPayment");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling RefundApi->RefundPayment");
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundPayment");
            }

            var localVarPath = $"/pts/v2/payments/{id}/refunds";
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
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (refundPaymentRequest != null && refundPaymentRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                refundPaymentRequest = (RefundPaymentRequest)sdkTracker.InsertDeveloperIdTracker(refundPaymentRequest, refundPaymentRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(refundPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundPaymentRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundPayment", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response))); // Return statement
        }

        /// <summary>
        /// Refund a Payment Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of PtsV2PaymentsRefundPost201Response</returns>
        public async System.Threading.Tasks.Task<PtsV2PaymentsRefundPost201Response> RefundPaymentAsync (RefundPaymentRequest refundPaymentRequest, string id)
        {
            logger.Debug("CALLING API \"RefundPaymentAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<PtsV2PaymentsRefundPost201Response> localVarResponse = await RefundPaymentAsyncWithHttpInfo(refundPaymentRequest, id);
            logger.Debug("CALLING API \"RefundPaymentAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Refund a Payment Refund a Payment API is only used, if you have requested Authorization and Capture together in [/pts/v2/payments](https://developer.cybersource.com/api-reference-assets/index.html#payments_payments) API call. Include the payment ID in the POST request to refund the payment amount. 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="refundPaymentRequest"></param>
        /// <param name="id">The payment ID. This ID is returned from a previous payment request.</param>
        /// <returns>Task of ApiResponse (PtsV2PaymentsRefundPost201Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PtsV2PaymentsRefundPost201Response>> RefundPaymentAsyncWithHttpInfo (RefundPaymentRequest refundPaymentRequest, string id)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'refundPaymentRequest' is set
            if (refundPaymentRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'refundPaymentRequest' when calling RefundApi->RefundPayment");
                throw new ApiException(400, "Missing required parameter 'refundPaymentRequest' when calling RefundApi->RefundPayment");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                logger.Error("ApiException : Missing required parameter 'id' when calling RefundApi->RefundPayment");
                throw new ApiException(400, "Missing required parameter 'id' when calling RefundApi->RefundPayment");
            }

            var localVarPath = $"/pts/v2/payments/{id}/refunds";
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
                "application/hal+json;charset=utf-8"
            };
            string localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (id != null)
            {
                localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (refundPaymentRequest != null && refundPaymentRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                refundPaymentRequest = (RefundPaymentRequest)sdkTracker.InsertDeveloperIdTracker(refundPaymentRequest, refundPaymentRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(refundPaymentRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = refundPaymentRequest; // byte array
            }

            if (logUtility.IsMaskingEnabled(logger))
            {
                logger.Debug($"HTTP Request Body :\n{logUtility.MaskSensitiveData(localVarPostBody.ToString())}");
            }
            else
            {
                logger.Debug($"HTTP Request Body :\n{localVarPostBody}");
            }


            // make the HTTP request
            RestResponse localVarResponse = (RestResponse)await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RefundPayment", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<PtsV2PaymentsRefundPost201Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PtsV2PaymentsRefundPost201Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PtsV2PaymentsRefundPost201Response))); // Return statement
        }
    }
}
