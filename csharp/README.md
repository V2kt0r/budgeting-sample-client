# Org.OpenAPITools - the C# library for the Budgeting Server

No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 0.1.1
- SDK version: 1.0.0
- Generator version: 7.6.0-SNAPSHOT
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: OAuth2PasswordBearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new GroupApi(config);
            var groupCreate = new GroupCreate(); // GroupCreate | 

            try
            {
                // Create Group
                GroupRead result = apiInstance.CreateGroup(groupCreate);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling GroupApi.CreateGroup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*GroupApi* | [**CreateGroup**](docs/GroupApi.md#creategroup) | **POST** /api/v1/group | Create Group
*GroupApi* | [**DeleteGroup**](docs/GroupApi.md#deletegroup) | **DELETE** /api/v1/group/{group_uuid} | Delete Group
*GroupApi* | [**GetGroup**](docs/GroupApi.md#getgroup) | **GET** /api/v1/group/{group_uuid} | Get Group
*GroupApi* | [**GetGroups**](docs/GroupApi.md#getgroups) | **GET** /api/v1/group | Get Groups
*GroupApi* | [**UpdateGroup**](docs/GroupApi.md#updategroup) | **PUT** /api/v1/group/{group_uuid} | Update Group
*GroupMembersApi* | [**AddGroupUser**](docs/GroupMembersApi.md#addgroupuser) | **POST** /api/v1/group/{group_uuid}/users/{username} | Add Group User
*GroupMembersApi* | [**ChangeGroupUserRole**](docs/GroupMembersApi.md#changegroupuserrole) | **PUT** /api/v1/group/{group_uuid}/users/{username} | Change Group User Role
*GroupMembersApi* | [**GetGroupUsers**](docs/GroupMembersApi.md#getgroupusers) | **GET** /api/v1/group/{group_uuid}/users | Get Group Users
*GroupMembersApi* | [**RemoveGroupUser**](docs/GroupMembersApi.md#removegroupuser) | **DELETE** /api/v1/group/{group_uuid}/users/{username} | Remove Group User
*GroupPurchaseCategoryApi* | [**CreateGroupPurchaseCategory**](docs/GroupPurchaseCategoryApi.md#creategrouppurchasecategory) | **POST** /api/v1/group/{group_uuid}/purchase-category | Create Group Purchase Category
*GroupPurchaseCategoryApi* | [**DeleteGroupPurchaseCategory**](docs/GroupPurchaseCategoryApi.md#deletegrouppurchasecategory) | **DELETE** /api/v1/group/{group_uuid}/purchase-category/{purchase_category_uuid} | Delete Group Purchase Category
*GroupPurchaseCategoryApi* | [**GetGroupPurchaseCategories**](docs/GroupPurchaseCategoryApi.md#getgrouppurchasecategories) | **GET** /api/v1/group/{group_uuid}/purchase-category | Get Group Purchase Categories
*GroupPurchaseCategoryApi* | [**UpdateGroupPurchaseCategory**](docs/GroupPurchaseCategoryApi.md#updategrouppurchasecategory) | **PUT** /api/v1/group/{group_uuid}/purchase-category/{purchase_category_uuid} | Update Group Purchase Category
*GroupTransactionItemsApi* | [**GetGroupTransactionItems**](docs/GroupTransactionItemsApi.md#getgrouptransactionitems) | **GET** /api/v1/group/{group_uuid/transaction-items | Get Group Transaction Items
*GroupTransactionsApi* | [**AddGroupTransaction**](docs/GroupTransactionsApi.md#addgrouptransaction) | **POST** /api/v1/group/{group_uuid}/transactions | Add Group Transaction
*GroupTransactionsApi* | [**DeleteGroupTransaction**](docs/GroupTransactionsApi.md#deletegrouptransaction) | **DELETE** /api/v1/group/{group_uuid}/transactions/{transaction_uuid} | Delete Group Transaction
*GroupTransactionsApi* | [**GetGroupTransaction**](docs/GroupTransactionsApi.md#getgrouptransaction) | **GET** /api/v1/group/{group_uuid}/transactions/{transaction_uuid} | Get Group Transaction
*GroupTransactionsApi* | [**GetGroupTransactions**](docs/GroupTransactionsApi.md#getgrouptransactions) | **GET** /api/v1/group/{group_uuid}/transactions | Get Group Transactions
*GroupTransactionsApi* | [**UpdateGroupTransaction**](docs/GroupTransactionsApi.md#updategrouptransaction) | **PUT** /api/v1/group/{group_uuid}/transactions/{transaction_uuid} | Update Group Transaction
*LoginApi* | [**LoginForAccessToken**](docs/LoginApi.md#loginforaccesstoken) | **POST** /api/v1/login | Login For Access Token
*LoginApi* | [**Logout**](docs/LoginApi.md#logout) | **POST** /api/v1/logout | Logout
*LoginApi* | [**RefreshAccessToken**](docs/LoginApi.md#refreshaccesstoken) | **POST** /api/v1/refresh | Refresh Access Token
*TransactionsApi* | [**CreateUserTransaction**](docs/TransactionsApi.md#createusertransaction) | **POST** /api/v1/transaction | Create User Transaction
*TransactionsApi* | [**DeleteTransaction**](docs/TransactionsApi.md#deletetransaction) | **DELETE** /api/v1/transaction/{transaction_uuid} | Delete Transaction
*TransactionsApi* | [**GetTransaction**](docs/TransactionsApi.md#gettransaction) | **GET** /api/v1/transaction/{transaction_uuid} | Get Transaction
*TransactionsApi* | [**GetUserTransactions**](docs/TransactionsApi.md#getusertransactions) | **GET** /api/v1/transaction | Get User Transactions
*TransactionsApi* | [**UpdateTransaction**](docs/TransactionsApi.md#updatetransaction) | **PUT** /api/v1/transaction/{transaction_uuid} | Update Transaction
*UserPurchaseCategoryApi* | [**CreatePurchaseCategory**](docs/UserPurchaseCategoryApi.md#createpurchasecategory) | **POST** /api/v1/purchase-category | Create Purchase Category
*UserPurchaseCategoryApi* | [**DeletePurchaseCategory**](docs/UserPurchaseCategoryApi.md#deletepurchasecategory) | **DELETE** /api/v1/purchase-category/{purchase_category_uuid} | Delete Purchase Category
*UserPurchaseCategoryApi* | [**GetPurchaseCategories**](docs/UserPurchaseCategoryApi.md#getpurchasecategories) | **GET** /api/v1/purchase-category | Get Purchase Categories
*UserPurchaseCategoryApi* | [**UpdatePurchaseCategory**](docs/UserPurchaseCategoryApi.md#updatepurchasecategory) | **PUT** /api/v1/purchase-category/{purchase_category_uuid} | Update Purchase Category
*UserTransactionItemsApi* | [**GetUserTransactionItems**](docs/UserTransactionItemsApi.md#getusertransactionitems) | **GET** /api/v1/transaction-items | Get User Transaction Items
*UsersApi* | [**CreateUser**](docs/UsersApi.md#createuser) | **POST** /api/v1/user | Create User
*UsersApi* | [**DbDeleteUser**](docs/UsersApi.md#dbdeleteuser) | **DELETE** /api/v1/db_user/{username} | Db Delete User
*UsersApi* | [**DeleteUser**](docs/UsersApi.md#deleteuser) | **DELETE** /api/v1/user/{username} | Delete User
*UsersApi* | [**GetUser**](docs/UsersApi.md#getuser) | **GET** /api/v1/user/{username} | Get User
*UsersApi* | [**GetUserRateLimits**](docs/UsersApi.md#getuserratelimits) | **GET** /api/v1/user/{username}/rate_limits | Get User Rate Limits
*UsersApi* | [**GetUserTier**](docs/UsersApi.md#getusertier) | **GET** /api/v1/user/{username}/tier | Get User Tier
*UsersApi* | [**GetUsers**](docs/UsersApi.md#getusers) | **GET** /api/v1/user | Get Users
*UsersApi* | [**GetUsersMe**](docs/UsersApi.md#getusersme) | **GET** /api/v1/user/me/ | Get Users Me
*UsersApi* | [**UpdateUser**](docs/UsersApi.md#updateuser) | **PATCH** /api/v1/user/{username} | Update User
*UsersApi* | [**UpdateUserTier**](docs/UsersApi.md#updateusertier) | **PATCH** /api/v1/user/{username}/tier | Update User Tier


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.Currency](docs/Currency.md)
 - [Model.GroupCreate](docs/GroupCreate.md)
 - [Model.GroupRead](docs/GroupRead.md)
 - [Model.GroupReadWithUserRole](docs/GroupReadWithUserRole.md)
 - [Model.GroupUpdate](docs/GroupUpdate.md)
 - [Model.HTTPValidationError](docs/HTTPValidationError.md)
 - [Model.Message](docs/Message.md)
 - [Model.PaginatedListResponseGroupReadWithUserRole](docs/PaginatedListResponseGroupReadWithUserRole.md)
 - [Model.PaginatedListResponsePurchaseCategoryRead](docs/PaginatedListResponsePurchaseCategoryRead.md)
 - [Model.PaginatedListResponseTransactionItemReadWithTransactionData](docs/PaginatedListResponseTransactionItemReadWithTransactionData.md)
 - [Model.PaginatedListResponseTransactionRead](docs/PaginatedListResponseTransactionRead.md)
 - [Model.PaginatedListResponseUserRead](docs/PaginatedListResponseUserRead.md)
 - [Model.PaginatedListResponseUserReadWithUserRole](docs/PaginatedListResponseUserReadWithUserRole.md)
 - [Model.PurchaseCategoryCreate](docs/PurchaseCategoryCreate.md)
 - [Model.PurchaseCategoryRead](docs/PurchaseCategoryRead.md)
 - [Model.PurchaseCategoryUpdate](docs/PurchaseCategoryUpdate.md)
 - [Model.Token](docs/Token.md)
 - [Model.TransactionCreate](docs/TransactionCreate.md)
 - [Model.TransactionItemCreate](docs/TransactionItemCreate.md)
 - [Model.TransactionItemRead](docs/TransactionItemRead.md)
 - [Model.TransactionItemReadWithTransactionData](docs/TransactionItemReadWithTransactionData.md)
 - [Model.TransactionRead](docs/TransactionRead.md)
 - [Model.TransactionUpdate](docs/TransactionUpdate.md)
 - [Model.UserCreate](docs/UserCreate.md)
 - [Model.UserRead](docs/UserRead.md)
 - [Model.UserReadWithUserRole](docs/UserReadWithUserRole.md)
 - [Model.UserRole](docs/UserRole.md)
 - [Model.UserTierUpdate](docs/UserTierUpdate.md)
 - [Model.UserUpdate](docs/UserUpdate.md)
 - [Model.ValidationError](docs/ValidationError.md)
 - [Model.ValidationErrorLocInner](docs/ValidationErrorLocInner.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="OAuth2PasswordBearer"></a>
### OAuth2PasswordBearer

- **Type**: OAuth
- **Flow**: password
- **Authorization URL**: 
- **Scopes**: N/A
