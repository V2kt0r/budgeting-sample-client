# Org.OpenAPITools.Api.LoginApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LoginForAccessToken**](LoginApi.md#loginforaccesstoken) | **POST** /api/v1/login | Login For Access Token |
| [**LoginForAccessTokenSwagger**](LoginApi.md#loginforaccesstokenswagger) | **POST** /api/v1/login-swagger | Login For Access Token Swagger |
| [**Logout**](LoginApi.md#logout) | **POST** /api/v1/logout | Logout |
| [**RefreshAccessToken**](LoginApi.md#refreshaccesstoken) | **POST** /api/v1/refresh | Refresh Access Token |

<a id="loginforaccesstoken"></a>
# **LoginForAccessToken**
> TokenPair LoginForAccessToken (string username, string password, string? grantType = null, string? scope = null, string? clientId = null, string? clientSecret = null)

Login For Access Token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginForAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoginApi(config);
            var username = "username_example";  // string | 
            var password = "password_example";  // string | 
            var grantType = "grantType_example";  // string? |  (optional) 
            var scope = "\"\"";  // string? |  (optional)  (default to "")
            var clientId = "clientId_example";  // string? |  (optional) 
            var clientSecret = "clientSecret_example";  // string? |  (optional) 

            try
            {
                // Login For Access Token
                TokenPair result = apiInstance.LoginForAccessToken(username, password, grantType, scope, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginApi.LoginForAccessToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginForAccessTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login For Access Token
    ApiResponse<TokenPair> response = apiInstance.LoginForAccessTokenWithHttpInfo(username, password, grantType, scope, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginApi.LoginForAccessTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** |  |  |
| **password** | **string** |  |  |
| **grantType** | **string?** |  | [optional]  |
| **scope** | **string?** |  | [optional] [default to &quot;&quot;] |
| **clientId** | **string?** |  | [optional]  |
| **clientSecret** | **string?** |  | [optional]  |

### Return type

[**TokenPair**](TokenPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="loginforaccesstokenswagger"></a>
# **LoginForAccessTokenSwagger**
> Token LoginForAccessTokenSwagger (string username, string password, string? grantType = null, string? scope = null, string? clientId = null, string? clientSecret = null)

Login For Access Token Swagger

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginForAccessTokenSwaggerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoginApi(config);
            var username = "username_example";  // string | 
            var password = "password_example";  // string | 
            var grantType = "grantType_example";  // string? |  (optional) 
            var scope = "\"\"";  // string? |  (optional)  (default to "")
            var clientId = "clientId_example";  // string? |  (optional) 
            var clientSecret = "clientSecret_example";  // string? |  (optional) 

            try
            {
                // Login For Access Token Swagger
                Token result = apiInstance.LoginForAccessTokenSwagger(username, password, grantType, scope, clientId, clientSecret);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginApi.LoginForAccessTokenSwagger: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginForAccessTokenSwaggerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Login For Access Token Swagger
    ApiResponse<Token> response = apiInstance.LoginForAccessTokenSwaggerWithHttpInfo(username, password, grantType, scope, clientId, clientSecret);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginApi.LoginForAccessTokenSwaggerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** |  |  |
| **password** | **string** |  |  |
| **grantType** | **string?** |  | [optional]  |
| **scope** | **string?** |  | [optional] [default to &quot;&quot;] |
| **clientId** | **string?** |  | [optional]  |
| **clientSecret** | **string?** |  | [optional]  |

### Return type

[**Token**](Token.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="logout"></a>
# **Logout**
> Message Logout ()

Logout

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LogoutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LoginApi(config);

            try
            {
                // Logout
                Message result = apiInstance.Logout();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginApi.Logout: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LogoutWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Logout
    ApiResponse<Message> response = apiInstance.LogoutWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginApi.LogoutWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Message**](Message.md)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refreshaccesstoken"></a>
# **RefreshAccessToken**
> TokenPair RefreshAccessToken (Token token)

Refresh Access Token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RefreshAccessTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            var apiInstance = new LoginApi(config);
            var token = new Token(); // Token | 

            try
            {
                // Refresh Access Token
                TokenPair result = apiInstance.RefreshAccessToken(token);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LoginApi.RefreshAccessToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefreshAccessTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refresh Access Token
    ApiResponse<TokenPair> response = apiInstance.RefreshAccessTokenWithHttpInfo(token);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LoginApi.RefreshAccessTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **token** | [**Token**](Token.md) |  |  |

### Return type

[**TokenPair**](TokenPair.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

