# Org.OpenAPITools.Api.UserStatisticsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetPurchaseCategoryStatistics**](UserStatisticsApi.md#getpurchasecategorystatistics) | **GET** /api/v1/stats/by-purchase-category | Get Purchase Category Statistics |

<a id="getpurchasecategorystatistics"></a>
# **GetPurchaseCategoryStatistics**
> PurchaseCategoryStatistics GetPurchaseCategoryStatistics (Currency? currency = null, DateTime? before = null, DateTime? after = null)

Get Purchase Category Statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseCategoryStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserStatisticsApi(config);
            var currency = new Currency?(); // Currency? | Currency to use for the statistics (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions before this date (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions after this date (optional) 

            try
            {
                // Get Purchase Category Statistics
                PurchaseCategoryStatistics result = apiInstance.GetPurchaseCategoryStatistics(currency, before, after);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserStatisticsApi.GetPurchaseCategoryStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseCategoryStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Purchase Category Statistics
    ApiResponse<PurchaseCategoryStatistics> response = apiInstance.GetPurchaseCategoryStatisticsWithHttpInfo(currency, before, after);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserStatisticsApi.GetPurchaseCategoryStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **currency** | [**Currency?**](Currency?.md) | Currency to use for the statistics | [optional]  |
| **before** | **DateTime?** | Get transactions before this date | [optional]  |
| **after** | **DateTime?** | Get transactions after this date | [optional]  |

### Return type

[**PurchaseCategoryStatistics**](PurchaseCategoryStatistics.md)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

