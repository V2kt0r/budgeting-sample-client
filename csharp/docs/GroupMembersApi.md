# Org.OpenAPITools.Api.GroupMembersApi

All URIs are relative to *http://localhost*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddGroupUser**](GroupMembersApi.md#addgroupuser) | **POST** /api/v1/group/{group_uuid}/users/{username} | Add Group User |
| [**ChangeGroupUserRole**](GroupMembersApi.md#changegroupuserrole) | **PUT** /api/v1/group/{group_uuid}/users/{username} | Change Group User Role |
| [**GetGroupUsers**](GroupMembersApi.md#getgroupusers) | **GET** /api/v1/group/{group_uuid}/users | Get Group Users |
| [**RemoveGroupUser**](GroupMembersApi.md#removegroupuser) | **DELETE** /api/v1/group/{group_uuid}/users/{username} | Remove Group User |

<a id="addgroupuser"></a>
# **AddGroupUser**
> Message AddGroupUser (Guid groupUuid, string username, UserRole? userRole = null)

Add Group User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AddGroupUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupMembersApi(config);
            var groupUuid = "groupUuid_example";  // Guid | The UUID of the group
            var username = "username_example";  // string | The username of the user
            var userRole = new UserRole?(); // UserRole? | The role of the user in the group (optional) 

            try
            {
                // Add Group User
                Message result = apiInstance.AddGroupUser(groupUuid, username, userRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupMembersApi.AddGroupUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddGroupUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Group User
    ApiResponse<Message> response = apiInstance.AddGroupUserWithHttpInfo(groupUuid, username, userRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupMembersApi.AddGroupUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | The UUID of the group |  |
| **username** | **string** | The username of the user |  |
| **userRole** | [**UserRole?**](UserRole?.md) | The role of the user in the group | [optional]  |

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
| **201** | Successful Response |  -  |
| **422** | Validation Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="changegroupuserrole"></a>
# **ChangeGroupUserRole**
> Message ChangeGroupUserRole (Guid groupUuid, string username, UserRole userRole)

Change Group User Role

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ChangeGroupUserRoleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupMembersApi(config);
            var groupUuid = "groupUuid_example";  // Guid | The UUID of the group
            var username = "username_example";  // string | The username of the user
            var userRole = (UserRole) "admin";  // UserRole | The role of the user in the group

            try
            {
                // Change Group User Role
                Message result = apiInstance.ChangeGroupUserRole(groupUuid, username, userRole);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupMembersApi.ChangeGroupUserRole: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ChangeGroupUserRoleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Change Group User Role
    ApiResponse<Message> response = apiInstance.ChangeGroupUserRoleWithHttpInfo(groupUuid, username, userRole);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupMembersApi.ChangeGroupUserRoleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | The UUID of the group |  |
| **username** | **string** | The username of the user |  |
| **userRole** | **UserRole** | The role of the user in the group |  |

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

<a id="getgroupusers"></a>
# **GetGroupUsers**
> PaginatedListResponseUserReadWithUserRole GetGroupUsers (Guid groupUuid, int? page = null, int? itemsPerPage = null)

Get Group Users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGroupUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupMembersApi(config);
            var groupUuid = "groupUuid_example";  // Guid | The UUID of the group
            var page = 1;  // int? |  (optional)  (default to 1)
            var itemsPerPage = 10;  // int? |  (optional)  (default to 10)

            try
            {
                // Get Group Users
                PaginatedListResponseUserReadWithUserRole result = apiInstance.GetGroupUsers(groupUuid, page, itemsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupMembersApi.GetGroupUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group Users
    ApiResponse<PaginatedListResponseUserReadWithUserRole> response = apiInstance.GetGroupUsersWithHttpInfo(groupUuid, page, itemsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupMembersApi.GetGroupUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | The UUID of the group |  |
| **page** | **int?** |  | [optional] [default to 1] |
| **itemsPerPage** | **int?** |  | [optional] [default to 10] |

### Return type

[**PaginatedListResponseUserReadWithUserRole**](PaginatedListResponseUserReadWithUserRole.md)

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

<a id="removegroupuser"></a>
# **RemoveGroupUser**
> Message RemoveGroupUser (Guid groupUuid, string username)

Remove Group User

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RemoveGroupUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupMembersApi(config);
            var groupUuid = "groupUuid_example";  // Guid | The UUID of the group
            var username = "username_example";  // string | The username of the user

            try
            {
                // Remove Group User
                Message result = apiInstance.RemoveGroupUser(groupUuid, username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling GroupMembersApi.RemoveGroupUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveGroupUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Group User
    ApiResponse<Message> response = apiInstance.RemoveGroupUserWithHttpInfo(groupUuid, username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling GroupMembersApi.RemoveGroupUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **groupUuid** | **Guid** | The UUID of the group |  |
| **username** | **string** | The username of the user |  |

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

