/* 
 * Intersight REST API
 *
 * This is Intersight REST API 
 *
 * OpenAPI spec version: 1.0.9-221
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using intersight.Client;
using intersight.Model;

namespace intersight.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITelemetryTimeSeriesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns></returns>
        void TelemetryTimeSeriesPost (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9);

        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> TelemetryTimeSeriesPostWithHttpInfo (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task TelemetryTimeSeriesPostAsync (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9);

        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39;
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> TelemetryTimeSeriesPostAsyncWithHttpInfo (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TelemetryTimeSeriesApi : ITelemetryTimeSeriesApi
    {
        private intersight.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryTimeSeriesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TelemetryTimeSeriesApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = intersight.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryTimeSeriesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TelemetryTimeSeriesApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = intersight.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public intersight.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns></returns>
        public void TelemetryTimeSeriesPost (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9)
        {
             TelemetryTimeSeriesPostWithHttpInfo(body, body2, body3, body4, body5, body6, body7, body8, body9);
        }

        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> TelemetryTimeSeriesPostWithHttpInfo (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body2' is set
            if (body2 == null)
                throw new ApiException(400, "Missing required parameter 'body2' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body3' is set
            if (body3 == null)
                throw new ApiException(400, "Missing required parameter 'body3' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body4' is set
            if (body4 == null)
                throw new ApiException(400, "Missing required parameter 'body4' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body5' is set
            if (body5 == null)
                throw new ApiException(400, "Missing required parameter 'body5' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body6' is set
            if (body6 == null)
                throw new ApiException(400, "Missing required parameter 'body6' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body7' is set
            if (body7 == null)
                throw new ApiException(400, "Missing required parameter 'body7' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body8' is set
            if (body8 == null)
                throw new ApiException(400, "Missing required parameter 'body8' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body9' is set
            if (body9 == null)
                throw new ApiException(400, "Missing required parameter 'body9' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");

            var localVarPath = "/telemetry/TimeSeries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body9 != null && body9.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body9); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body9; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TelemetryTimeSeriesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task TelemetryTimeSeriesPostAsync (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9)
        {
             await TelemetryTimeSeriesPostAsyncWithHttpInfo(body, body2, body3, body4, body5, body6, body7, body8, body9);

        }

        /// <summary>
        /// Create an instance of &#39;telemetryTimeSeries&#39; 
        /// </summary>
        /// <exception cref="intersight.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">telemetryTimeSeries to add</param>
        /// <param name="body2">telemetryTimeSeries to add</param>
        /// <param name="body3">telemetryTimeSeries to add</param>
        /// <param name="body4">telemetryTimeSeries to add</param>
        /// <param name="body5">telemetryTimeSeries to add</param>
        /// <param name="body6">telemetryTimeSeries to add</param>
        /// <param name="body7">telemetryTimeSeries to add</param>
        /// <param name="body8">telemetryTimeSeries to add</param>
        /// <param name="body9">telemetryTimeSeries to add</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> TelemetryTimeSeriesPostAsyncWithHttpInfo (TelemetryTimeSeries body, TelemetryTimeSeries body2, TelemetryTimeSeries body3, TelemetryTimeSeries body4, TelemetryTimeSeries body5, TelemetryTimeSeries body6, TelemetryTimeSeries body7, TelemetryTimeSeries body8, TelemetryTimeSeries body9)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body2' is set
            if (body2 == null)
                throw new ApiException(400, "Missing required parameter 'body2' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body3' is set
            if (body3 == null)
                throw new ApiException(400, "Missing required parameter 'body3' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body4' is set
            if (body4 == null)
                throw new ApiException(400, "Missing required parameter 'body4' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body5' is set
            if (body5 == null)
                throw new ApiException(400, "Missing required parameter 'body5' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body6' is set
            if (body6 == null)
                throw new ApiException(400, "Missing required parameter 'body6' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body7' is set
            if (body7 == null)
                throw new ApiException(400, "Missing required parameter 'body7' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body8' is set
            if (body8 == null)
                throw new ApiException(400, "Missing required parameter 'body8' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");
            // verify the required parameter 'body9' is set
            if (body9 == null)
                throw new ApiException(400, "Missing required parameter 'body9' when calling TelemetryTimeSeriesApi->TelemetryTimeSeriesPost");

            var localVarPath = "/telemetry/TimeSeries";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body9 != null && body9.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body9); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body9; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TelemetryTimeSeriesPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
