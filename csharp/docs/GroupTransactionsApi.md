# Org.OpenAPITools.Api.GroupTransactionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGroupTransaction**](GroupTransactionsApi.md#addgrouptransaction) | **POST** /api/v1/group/{group_uuid}/transactions | Add Group Transaction |
| [**DeleteGroupTransaction**](GroupTransactionsApi.md#deletegrouptransaction) | **DELETE** /api/v1/group/{group_uuid}/transactions/{transaction_uuid} | Delete Group Transaction |
| [**GetGroupTransaction**](GroupTransactionsApi.md#getgrouptransaction) | **GET** /api/v1/group/{group_uuid}/transactions/{transaction_uuid} | Get Group Transaction |
| [**GetGroupTransactions**](GroupTransactionsApi.md#getgrouptransactions) | **GET** /api/v1/group/{group_uuid}/transactions | Get Group Transactions |
| [**UpdateGroupTransaction**](GroupTransactionsApi.md#updategrouptransaction) | **PUT** /api/v1/group/{group_uuid}/transactions/{transaction_uuid} | Update Group Transaction |

<a id="addgrouptransaction"></a>
# **AddGroupTransaction**
> TransactionRead AddGroupTransaction (Guid groupUuid, TransactionCreate transactionCreate)

Add Group Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddGroupTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupTransactionsApi(config);
            var groupUuid = "groupUuid_example";  // Guid | 
            var transactionCreate = new TransactionCreate(); // TransactionCreate | 

            try
            {
                // Add Group Transaction
                TransactionRead result = apiInstance.AddGroupTransaction(groupUuid, transactionCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupTransactionsApi.AddGroupTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Group Transaction
    ApiResponse<TransactionRead> response = apiInstance.AddGroupTransactionWithHttpInfo(groupUuid, transactionCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupTransactionsApi.AddGroupTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** |  |  |
| **transactionCreate** | [**TransactionCreate**](TransactionCreate.md) |  |  |

### Return type

[**TransactionRead**](TransactionRead.md)

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

<a id="deletegrouptransaction"></a>
# **DeleteGroupTransaction**
> Message DeleteGroupTransaction (Guid transactionUuid, Guid groupUuid)

Delete Group Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteGroupTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupTransactionsApi(config);
            var transactionUuid = "transactionUuid_example";  // Guid | UUID of the transaction
            var groupUuid = "groupUuid_example";  // Guid | 

            try
            {
                // Delete Group Transaction
                Message result = apiInstance.DeleteGroupTransaction(transactionUuid, groupUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupTransactionsApi.DeleteGroupTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group Transaction
    ApiResponse<Message> response = apiInstance.DeleteGroupTransactionWithHttpInfo(transactionUuid, groupUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupTransactionsApi.DeleteGroupTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionUuid** | **Guid** | UUID of the transaction |  |
| **groupUuid** | **Guid** |  |  |

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

<a id="getgrouptransaction"></a>
# **GetGroupTransaction**
> TransactionRead GetGroupTransaction (Guid groupUuid, Guid transactionUuid)

Get Group Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupTransactionsApi(config);
            var groupUuid = "groupUuid_example";  // Guid | 
            var transactionUuid = "transactionUuid_example";  // Guid | UUID of the transaction

            try
            {
                // Get Group Transaction
                TransactionRead result = apiInstance.GetGroupTransaction(groupUuid, transactionUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupTransactionsApi.GetGroupTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Transaction
    ApiResponse<TransactionRead> response = apiInstance.GetGroupTransactionWithHttpInfo(groupUuid, transactionUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupTransactionsApi.GetGroupTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** |  |  |
| **transactionUuid** | **Guid** | UUID of the transaction |  |

### Return type

[**TransactionRead**](TransactionRead.md)

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

<a id="getgrouptransactions"></a>
# **GetGroupTransactions**
> PaginatedListResponseTransactionRead GetGroupTransactions (Guid groupUuid, DateTime? before = null, DateTime? after = null, int? page = null, int? itemsPerPage = null)

Get Group Transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupTransactionsApi(config);
            var groupUuid = "groupUuid_example";  // Guid | 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions before this date (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions after this date (optional) 
            var page = 1;  // int? |  (optional)  (default to 1)
            var itemsPerPage = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // Get Group Transactions
                PaginatedListResponseTransactionRead result = apiInstance.GetGroupTransactions(groupUuid, before, after, page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupTransactionsApi.GetGroupTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Transactions
    ApiResponse<PaginatedListResponseTransactionRead> response = apiInstance.GetGroupTransactionsWithHttpInfo(groupUuid, before, after, page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupTransactionsApi.GetGroupTransactionsWithHttpInfo: " + e.Message);
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

### Return type

[**PaginatedListResponseTransactionRead**](PaginatedListResponseTransactionRead.md)

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

<a id="updategrouptransaction"></a>
# **UpdateGroupTransaction**
> Message UpdateGroupTransaction (Guid transactionUuid, Guid groupUuid, TransactionUpdate transactionUpdate)

Update Group Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateGroupTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupTransactionsApi(config);
            var transactionUuid = "transactionUuid_example";  // Guid | UUID of the transaction
            var groupUuid = "groupUuid_example";  // Guid | 
            var transactionUpdate = new TransactionUpdate(); // TransactionUpdate | 

            try
            {
                // Update Group Transaction
                Message result = apiInstance.UpdateGroupTransaction(transactionUuid, groupUuid, transactionUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupTransactionsApi.UpdateGroupTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group Transaction
    ApiResponse<Message> response = apiInstance.UpdateGroupTransactionWithHttpInfo(transactionUuid, groupUuid, transactionUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupTransactionsApi.UpdateGroupTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionUuid** | **Guid** | UUID of the transaction |  |
| **groupUuid** | **Guid** |  |  |
| **transactionUpdate** | [**TransactionUpdate**](TransactionUpdate.md) |  |  |

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

