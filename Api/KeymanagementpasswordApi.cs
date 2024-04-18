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
    public interface IKeyManagementPasswordApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Activate or De-activate Password
        /// </summary>
        /// <remarks>
        /// Activate or De-activate key of type password 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>Object</returns>
        Object UpdatePassword (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest);

        /// <summary>
        /// Activate or De-activate Password
        /// </summary>
        /// <remarks>
        /// Activate or De-activate key of type password 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> UpdatePasswordWithHttpInfo (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Activate or De-activate Password
        /// </summary>
        /// <remarks>
        /// Activate or De-activate key of type password 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> UpdatePasswordAsync (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest);

        /// <summary>
        /// Activate or De-activate Password
        /// </summary>
        /// <remarks>
        /// Activate or De-activate key of type password 
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePasswordAsyncWithHttpInfo (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class KeyManagementPasswordApi : IKeyManagementPasswordApi
    {
        private static Logger logger;
        private ExceptionFactory _exceptionFactory = (name, response) => null;
        private int? _statusCode;

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyManagementPasswordApi"/> class.
        /// </summary>
        /// <returns></returns>
        public KeyManagementPasswordApi(string basePath)
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
        /// Initializes a new instance of the <see cref="KeyManagementPasswordApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public KeyManagementPasswordApi(Configuration configuration = null)
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
        /// Activate or De-activate Password Activate or De-activate key of type password 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>Object</returns>
        public Object UpdatePassword (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest)
        {
            logger.Debug("CALLING API \"UpdatePassword\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<Object> localVarResponse = UpdatePasswordWithHttpInfo(keyId, updatePasswordKeysRequest);
            logger.Debug("CALLING API \"UpdatePassword\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Activate or De-activate Password Activate or De-activate key of type password 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > UpdatePasswordWithHttpInfo (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'keyId' is set
            if (keyId == null)
            {
                logger.Error("ApiException : Missing required parameter 'keyId' when calling KeyManagementPasswordApi->UpdatePassword");
                throw new ApiException(400, "Missing required parameter 'keyId' when calling KeyManagementPasswordApi->UpdatePassword");
            }
            // verify the required parameter 'updatePasswordKeysRequest' is set
            if (updatePasswordKeysRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'updatePasswordKeysRequest' when calling KeyManagementPasswordApi->UpdatePassword");
                throw new ApiException(400, "Missing required parameter 'updatePasswordKeysRequest' when calling KeyManagementPasswordApi->UpdatePassword");
            }

            var localVarPath = $"/kms/v2/keys-password/{keyId}";
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

            if (keyId != null)
            {
                localVarPathParams.Add("keyId", Configuration.ApiClient.ParameterToString(keyId)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (updatePasswordKeysRequest != null && updatePasswordKeysRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                updatePasswordKeysRequest = (UpdatePasswordKeysRequest)sdkTracker.InsertDeveloperIdTracker(updatePasswordKeysRequest, updatePasswordKeysRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(updatePasswordKeysRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updatePasswordKeysRequest; // byte array
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePassword", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object))); // Return statement
        }

        /// <summary>
        /// Activate or De-activate Password Activate or De-activate key of type password 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> UpdatePasswordAsync (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest)
        {
            logger.Debug("CALLING API \"UpdatePasswordAsync\" STARTED");
            this.SetStatusCode(null);
            ApiResponse<Object> localVarResponse = await UpdatePasswordAsyncWithHttpInfo(keyId, updatePasswordKeysRequest);
            logger.Debug("CALLING API \"UpdatePasswordAsync\" ENDED");
            this.SetStatusCode(localVarResponse.StatusCode);
            return localVarResponse.Data;

        }

        /// <summary>
        /// Activate or De-activate Password Activate or De-activate key of type password 
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="keyId">Key ID. </param>
        /// <param name="updatePasswordKeysRequest"></param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdatePasswordAsyncWithHttpInfo (string keyId, UpdatePasswordKeysRequest updatePasswordKeysRequest)
        {
            LogUtility logUtility = new LogUtility();

            // verify the required parameter 'keyId' is set
            if (keyId == null)
            {
                logger.Error("ApiException : Missing required parameter 'keyId' when calling KeyManagementPasswordApi->UpdatePassword");
                throw new ApiException(400, "Missing required parameter 'keyId' when calling KeyManagementPasswordApi->UpdatePassword");
            }
            // verify the required parameter 'updatePasswordKeysRequest' is set
            if (updatePasswordKeysRequest == null)
            {
                logger.Error("ApiException : Missing required parameter 'updatePasswordKeysRequest' when calling KeyManagementPasswordApi->UpdatePassword");
                throw new ApiException(400, "Missing required parameter 'updatePasswordKeysRequest' when calling KeyManagementPasswordApi->UpdatePassword");
            }

            var localVarPath = $"/kms/v2/keys-password/{keyId}";
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

            if (keyId != null)
            {
                localVarPathParams.Add("keyId", Configuration.ApiClient.ParameterToString(keyId)); // path parameter
            }
            logger.Debug($"HTTP Request Body :\n{logUtility.ConvertDictionaryToString(localVarPathParams)}");
            if (updatePasswordKeysRequest != null && updatePasswordKeysRequest.GetType() != typeof(byte[]))
            {
                SdkTracker sdkTracker = new SdkTracker();
                updatePasswordKeysRequest = (UpdatePasswordKeysRequest)sdkTracker.InsertDeveloperIdTracker(updatePasswordKeysRequest, updatePasswordKeysRequest.GetType().Name, Configuration.ApiClient.Configuration.MerchantConfigDictionaryObj["runEnvironment"]);
                localVarPostBody = Configuration.ApiClient.Serialize(updatePasswordKeysRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updatePasswordKeysRequest; // byte array
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
                Method.Patch, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdatePassword", localVarResponse);
                if (exception != null)
                {
                    logger.Error($"Exception : {exception.Message}");
                    throw exception;
                }
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Object) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object))); // Return statement
        }
    }
}
