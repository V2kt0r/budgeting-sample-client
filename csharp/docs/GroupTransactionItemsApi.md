# Org.OpenAPITools.Api.GroupTransactionItemsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGroupTransactionItems**](GroupTransactionItemsApi.md#getgrouptransactionitems) | **GET** /api/v1/group/{group_uuid/transaction-items | Get Group Transaction Items |

<a id="getgrouptransactionitems"></a>
# **GetGroupTransactionItems**
> PaginatedListResponseTransactionItemReadWithTransactionData GetGroupTransactionItems (Guid groupUuid, DateTime? before = null, DateTime? after = null, int? page = null, int? itemsPerPage = null, List<string>? tagNames = null, Guid? purchaseCategoryUuid = null)

Get Group Transaction Items

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupTransactionItemsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupTransactionItemsApi(config);
            var groupUuid = "groupUuid_example";  // Guid | 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions before this date (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions after this date (optional) 
            var page = 1;  // int? |  (optional)  (default to 1)
            var itemsPerPage = 10;  // int? |  (optional)  (default to 10)
            var tagNames = new List<string>?(); // List<string>? | List of tag names to filter transactions by (optional) 
            var purchaseCategoryUuid = "purchaseCategoryUuid_example";  // Guid? |  (optional) 

            try
            {
                // Get Group Transaction Items
                PaginatedListResponseTransactionItemReadWithTransactionData result = apiInstance.GetGroupTransactionItems(groupUuid, before, after, page, itemsPerPage, tagNames, purchaseCategoryUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupTransactionItemsApi.GetGroupTransactionItems: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupTransactionItemsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Transaction Items
    ApiResponse<PaginatedListResponseTransactionItemReadWithTransactionData> response = apiInstance.GetGroupTransactionItemsWithHttpInfo(groupUuid, before, after, page, itemsPerPage, tagNames, purchaseCategoryUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupTransactionItemsApi.GetGroupTransactionItemsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** |  |  |
| **before** | **DateTime?** | Get transactions before this date | [optional]  |
| **after** | **DateTime?** | Get transactions after this date | [optional]  |
| **page** | **int?** |  | [optional] [default to 1] |
| **itemsPerPage** | **int?** |  | [optional] [default to 10] |
| **tagNames** | [**List&lt;string&gt;?**](string.md) | List of tag names to filter transactions by | [optional]  |
| **purchaseCategoryUuid** | **Guid?** |  | [optional]  |

### Return type

[**PaginatedListResponseTransactionItemReadWithTransactionData**](PaginatedListResponseTransactionItemReadWithTransactionData.md)

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

