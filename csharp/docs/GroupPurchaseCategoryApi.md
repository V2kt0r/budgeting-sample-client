# Org.OpenAPITools.Api.GroupPurchaseCategoryApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateGroupPurchaseCategory**](GroupPurchaseCategoryApi.md#creategrouppurchasecategory) | **POST** /api/v1/group/{group_uuid}/purchase-category | Create Group Purchase Category |
| [**DeleteGroupPurchaseCategory**](GroupPurchaseCategoryApi.md#deletegrouppurchasecategory) | **DELETE** /api/v1/group/{group_uuid}/purchase-category/{purchase_category_uuid} | Delete Group Purchase Category |
| [**GetGroupPurchaseCategories**](GroupPurchaseCategoryApi.md#getgrouppurchasecategories) | **GET** /api/v1/group/{group_uuid}/purchase-category | Get Group Purchase Categories |
| [**UpdateGroupPurchaseCategory**](GroupPurchaseCategoryApi.md#updategrouppurchasecategory) | **PUT** /api/v1/group/{group_uuid}/purchase-category/{purchase_category_uuid} | Update Group Purchase Category |

<a id="creategrouppurchasecategory"></a>
# **CreateGroupPurchaseCategory**
> PurchaseCategoryRead CreateGroupPurchaseCategory (Guid groupUuid, PurchaseCategoryCreate purchaseCategoryCreate)

Create Group Purchase Category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateGroupPurchaseCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupPurchaseCategoryApi(config);
            var groupUuid = "groupUuid_example";  // Guid | UUID of the group to which the purchase category belongs.
            var purchaseCategoryCreate = new PurchaseCategoryCreate(); // PurchaseCategoryCreate | 

            try
            {
                // Create Group Purchase Category
                PurchaseCategoryRead result = apiInstance.CreateGroupPurchaseCategory(groupUuid, purchaseCategoryCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupPurchaseCategoryApi.CreateGroupPurchaseCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateGroupPurchaseCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Group Purchase Category
    ApiResponse<PurchaseCategoryRead> response = apiInstance.CreateGroupPurchaseCategoryWithHttpInfo(groupUuid, purchaseCategoryCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupPurchaseCategoryApi.CreateGroupPurchaseCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | UUID of the group to which the purchase category belongs. |  |
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

<a id="deletegrouppurchasecategory"></a>
# **DeleteGroupPurchaseCategory**
> Message DeleteGroupPurchaseCategory (Guid groupUuid, Guid purchaseCategoryUuid)

Delete Group Purchase Category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGroupPurchaseCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupPurchaseCategoryApi(config);
            var groupUuid = "groupUuid_example";  // Guid | UUID of the group to which the purchase category belongs.
            var purchaseCategoryUuid = "purchaseCategoryUuid_example";  // Guid | UUID of the purchase category to delete.

            try
            {
                // Delete Group Purchase Category
                Message result = apiInstance.DeleteGroupPurchaseCategory(groupUuid, purchaseCategoryUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupPurchaseCategoryApi.DeleteGroupPurchaseCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupPurchaseCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group Purchase Category
    ApiResponse<Message> response = apiInstance.DeleteGroupPurchaseCategoryWithHttpInfo(groupUuid, purchaseCategoryUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupPurchaseCategoryApi.DeleteGroupPurchaseCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | UUID of the group to which the purchase category belongs. |  |
| **purchaseCategoryUuid** | **Guid** | UUID of the purchase category to delete. |  |

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

<a id="getgrouppurchasecategories"></a>
# **GetGroupPurchaseCategories**
> PaginatedListResponsePurchaseCategoryRead GetGroupPurchaseCategories (Guid groupUuid, int? page = null, int? itemsPerPage = null)

Get Group Purchase Categories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupPurchaseCategoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupPurchaseCategoryApi(config);
            var groupUuid = "groupUuid_example";  // Guid | UUID of the group to which the purchase categories belong.
            var page = 1;  // int? |  (optional)  (default to 1)
            var itemsPerPage = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // Get Group Purchase Categories
                PaginatedListResponsePurchaseCategoryRead result = apiInstance.GetGroupPurchaseCategories(groupUuid, page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupPurchaseCategoryApi.GetGroupPurchaseCategories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupPurchaseCategoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Purchase Categories
    ApiResponse<PaginatedListResponsePurchaseCategoryRead> response = apiInstance.GetGroupPurchaseCategoriesWithHttpInfo(groupUuid, page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupPurchaseCategoryApi.GetGroupPurchaseCategoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | UUID of the group to which the purchase categories belong. |  |
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

<a id="updategrouppurchasecategory"></a>
# **UpdateGroupPurchaseCategory**
> Message UpdateGroupPurchaseCategory (Guid groupUuid, Guid purchaseCategoryUuid, PurchaseCategoryUpdate purchaseCategoryUpdate)

Update Group Purchase Category

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateGroupPurchaseCategoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupPurchaseCategoryApi(config);
            var groupUuid = "groupUuid_example";  // Guid | UUID of the group to which the purchase category belongs.
            var purchaseCategoryUuid = "purchaseCategoryUuid_example";  // Guid | UUID of the purchase category to update.
            var purchaseCategoryUpdate = new PurchaseCategoryUpdate(); // PurchaseCategoryUpdate | 

            try
            {
                // Update Group Purchase Category
                Message result = apiInstance.UpdateGroupPurchaseCategory(groupUuid, purchaseCategoryUuid, purchaseCategoryUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupPurchaseCategoryApi.UpdateGroupPurchaseCategory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupPurchaseCategoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group Purchase Category
    ApiResponse<Message> response = apiInstance.UpdateGroupPurchaseCategoryWithHttpInfo(groupUuid, purchaseCategoryUuid, purchaseCategoryUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupPurchaseCategoryApi.UpdateGroupPurchaseCategoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | UUID of the group to which the purchase category belongs. |  |
| **purchaseCategoryUuid** | **Guid** | UUID of the purchase category to update. |  |
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

