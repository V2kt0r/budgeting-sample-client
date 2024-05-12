# Org.OpenAPITools.Api.TransactionsApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateUserTransaction**](TransactionsApi.md#createusertransaction) | **POST** /api/v1/transaction | Create User Transaction |
| [**DeleteTransaction**](TransactionsApi.md#deletetransaction) | **DELETE** /api/v1/transaction/{transaction_uuid} | Delete Transaction |
| [**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /api/v1/transaction/{transaction_uuid} | Get Transaction |
| [**GetUserTransactions**](TransactionsApi.md#getusertransactions) | **GET** /api/v1/transaction | Get User Transactions |
| [**UpdateTransaction**](TransactionsApi.md#updatetransaction) | **PUT** /api/v1/transaction/{transaction_uuid} | Update Transaction |

<a id="createusertransaction"></a>
# **CreateUserTransaction**
> TransactionRead CreateUserTransaction (TransactionCreate transactionCreate)

Create User Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUserTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var transactionCreate = new TransactionCreate(); // TransactionCreate | 

            try
            {
                // Create User Transaction
                TransactionRead result = apiInstance.CreateUserTransaction(transactionCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.CreateUserTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create User Transaction
    ApiResponse<TransactionRead> response = apiInstance.CreateUserTransactionWithHttpInfo(transactionCreate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.CreateUserTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="deletetransaction"></a>
# **DeleteTransaction**
> Message DeleteTransaction (Guid transactionUuid)

Delete Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var transactionUuid = "transactionUuid_example";  // Guid | UUID of the transaction

            try
            {
                // Delete Transaction
                Message result = apiInstance.DeleteTransaction(transactionUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.DeleteTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Transaction
    ApiResponse<Message> response = apiInstance.DeleteTransactionWithHttpInfo(transactionUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.DeleteTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionUuid** | **Guid** | UUID of the transaction |  |

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

<a id="gettransaction"></a>
# **GetTransaction**
> TransactionRead GetTransaction (Guid transactionUuid)

Get Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var transactionUuid = "transactionUuid_example";  // Guid | UUID of the transaction

            try
            {
                // Get Transaction
                TransactionRead result = apiInstance.GetTransaction(transactionUuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Transaction
    ApiResponse<TransactionRead> response = apiInstance.GetTransactionWithHttpInfo(transactionUuid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="getusertransactions"></a>
# **GetUserTransactions**
> PaginatedListResponseTransactionRead GetUserTransactions (DateTime? before = null, DateTime? after = null, int? page = null, int? itemsPerPage = null)

Get User Transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserTransactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions before this date (optional) 
            var after = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Get transactions after this date (optional) 
            var page = 1;  // int? |  (optional)  (default to 1)
            var itemsPerPage = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // Get User Transactions
                PaginatedListResponseTransactionRead result = apiInstance.GetUserTransactions(before, after, page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetUserTransactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserTransactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get User Transactions
    ApiResponse<PaginatedListResponseTransactionRead> response = apiInstance.GetUserTransactionsWithHttpInfo(before, after, page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.GetUserTransactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

<a id="updatetransaction"></a>
# **UpdateTransaction**
> Message UpdateTransaction (Guid transactionUuid, TransactionUpdate transactionUpdate)

Update Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateTransactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TransactionsApi(config);
            var transactionUuid = "transactionUuid_example";  // Guid | UUID of the transaction
            var transactionUpdate = new TransactionUpdate(); // TransactionUpdate | 

            try
            {
                // Update Transaction
                Message result = apiInstance.UpdateTransaction(transactionUuid, transactionUpdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransactionsApi.UpdateTransaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Transaction
    ApiResponse<Message> response = apiInstance.UpdateTransactionWithHttpInfo(transactionUuid, transactionUpdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransactionsApi.UpdateTransactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionUuid** | **Guid** | UUID of the transaction |  |
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

