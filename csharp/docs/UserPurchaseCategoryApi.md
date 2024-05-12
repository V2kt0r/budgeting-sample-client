# Org.OpenAPITools.Api.UserPurchaseCategoryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreatePurchaseCategory**](UserPurchaseCategoryApi.md#createpurchasecategory) | **POST** /api/v1/purchase-category | Create Purchase Category |
| [**DeletePurchaseCategory**](UserPurchaseCategoryApi.md#deletepurchasecategory) | **DELETE** /api/v1/purchase-category/{purchase_category_uuid} | Delete Purchase Category |
| [**GetPurchaseCategories**](UserPurchaseCategoryApi.md#getpurchasecategories) | **GET** /api/v1/purchase-category | Get Purchase Categories |
| [**UpdatePurchaseCategory**](UserPurchaseCategoryApi.md#updatepurchasecategory) | **PUT** /api/v1/purchase-category/{purchase_category_uuid} | Update Purchase Category |

<a id="createpurchasecategory"></a>
# **CreatePurchaseCategory**
> PurchaseCategoryRead CreatePurchaseCategory (PurchaseCategoryCreate purchaseCategoryCreate)

Create Purchase Category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreatePurchaseCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserPurchaseCategoryApi(config);
            var purchaseCategoryCreate = new PurchaseCategoryCreate(); // PurchaseCategoryCreate | 

            try
            {
                // Create Purchase Category
                PurchaseCategoryRead result = apiInstance.CreatePurchaseCategory(purchaseCategoryCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPurchaseCategoryApi.CreatePurchaseCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreatePurchaseCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Purchase Category
    ApiResponse<PurchaseCategoryRead> response = apiInstance.CreatePurchaseCategoryWithHttpInfo(purchaseCategoryCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPurchaseCategoryApi.CreatePurchaseCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **purchaseCategoryCreate** | [**PurchaseCategoryCreate**](PurchaseCategoryCreate.md) |  |  |

### Return type

[**PurchaseCategoryRead**](PurchaseCategoryRead.md)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletepurchasecategory"></a>
# **DeletePurchaseCategory**
> Message DeletePurchaseCategory (Guid purchaseCategoryUuid)

Delete Purchase Category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeletePurchaseCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserPurchaseCategoryApi(config);
            var purchaseCategoryUuid = "purchaseCategoryUuid_example";  // Guid | The UUID of the purchase category to delete.

            try
            {
                // Delete Purchase Category
                Message result = apiInstance.DeletePurchaseCategory(purchaseCategoryUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPurchaseCategoryApi.DeletePurchaseCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePurchaseCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Purchase Category
    ApiResponse<Message> response = apiInstance.DeletePurchaseCategoryWithHttpInfo(purchaseCategoryUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPurchaseCategoryApi.DeletePurchaseCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **purchaseCategoryUuid** | **Guid** | The UUID of the purchase category to delete. |  |

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
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpurchasecategories"></a>
# **GetPurchaseCategories**
> PaginatedListResponsePurchaseCategoryRead GetPurchaseCategories (int? page = null, int? itemsPerPage = null)

Get Purchase Categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetPurchaseCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserPurchaseCategoryApi(config);
            var page = 1;  // int? |  (optional)  (default to 1)
            var itemsPerPage = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // Get Purchase Categories
                PaginatedListResponsePurchaseCategoryRead result = apiInstance.GetPurchaseCategories(page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPurchaseCategoryApi.GetPurchaseCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPurchaseCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Purchase Categories
    ApiResponse<PaginatedListResponsePurchaseCategoryRead> response = apiInstance.GetPurchaseCategoriesWithHttpInfo(page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPurchaseCategoryApi.GetPurchaseCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** |  | [optional] [default to 1] |
| **itemsPerPage** | **int?** |  | [optional] [default to 10] |

### Return type

[**PaginatedListResponsePurchaseCategoryRead**](PaginatedListResponsePurchaseCategoryRead.md)

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

<a id="updatepurchasecategory"></a>
# **UpdatePurchaseCategory**
> Message UpdatePurchaseCategory (Guid purchaseCategoryUuid, PurchaseCategoryUpdate purchaseCategoryUpdate)

Update Purchase Category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdatePurchaseCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserPurchaseCategoryApi(config);
            var purchaseCategoryUuid = "purchaseCategoryUuid_example";  // Guid | The UUID of the purchase category to update.
            var purchaseCategoryUpdate = new PurchaseCategoryUpdate(); // PurchaseCategoryUpdate | 

            try
            {
                // Update Purchase Category
                Message result = apiInstance.UpdatePurchaseCategory(purchaseCategoryUuid, purchaseCategoryUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPurchaseCategoryApi.UpdatePurchaseCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdatePurchaseCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Purchase Category
    ApiResponse<Message> response = apiInstance.UpdatePurchaseCategoryWithHttpInfo(purchaseCategoryUuid, purchaseCategoryUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserPurchaseCategoryApi.UpdatePurchaseCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **purchaseCategoryUuid** | **Guid** | The UUID of the purchase category to update. |  |
| **purchaseCategoryUpdate** | [**PurchaseCategoryUpdate**](PurchaseCategoryUpdate.md) |  |  |

### Return type

[**Message**](Message.md)

### Authorization

[OAuth2PasswordBearer](../README.md#OAuth2PasswordBearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

