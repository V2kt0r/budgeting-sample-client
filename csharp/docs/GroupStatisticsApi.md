# Org.OpenAPITools.Api.GroupStatisticsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGroupPurchaseCategoryStatistics**](GroupStatisticsApi.md#getgrouppurchasecategorystatistics) | **GET** /api/v1/group/{group_uuid}/stats/by-purchase-category | Get Group Purchase Category Statistics |

<a id="getgrouppurchasecategorystatistics"></a>
# **GetGroupPurchaseCategoryStatistics**
> PurchaseCategoryStatistics GetGroupPurchaseCategoryStatistics (Guid groupUuid, Currency? currency = null, DateTime? before = null, DateTime? after = null)

Get Group Purchase Category Statistics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupPurchaseCategoryStatisticsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupStatisticsApi(config);
            var groupUuid = "groupUuid_example";  // Guid | 
            var currency = new Currency?(); // Currency? | Currency to use for the statistics (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions before this date (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions after this date (optional) 

            try
            {
                // Get Group Purchase Category Statistics
                PurchaseCategoryStatistics result = apiInstance.GetGroupPurchaseCategoryStatistics(groupUuid, currency, before, after);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupStatisticsApi.GetGroupPurchaseCategoryStatistics: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupPurchaseCategoryStatisticsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Purchase Category Statistics
    ApiResponse<PurchaseCategoryStatistics> response = apiInstance.GetGroupPurchaseCategoryStatisticsWithHttpInfo(groupUuid, currency, before, after);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupStatisticsApi.GetGroupPurchaseCategoryStatisticsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** |  |  |
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

