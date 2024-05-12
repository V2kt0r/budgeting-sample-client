# Org.OpenAPITools.Model.TransactionCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timestamp** | **DateTime** | Timestamp must be a valid datetime. | [optional] 
**Amount** | **decimal** | Value of the transaction. | 
**Currency** | **Currency** | Currency of the transaction. | 
**Name** | **string** |  | 
**Description** | **string** |  | 
**PurchaseCategoryUuid** | **Guid?** |  | [optional] 
**TagNames** | **List&lt;string&gt;** | List of tags associated with the transaction. | [optional] 
**TransactionItems** | [**List&lt;TransactionItemCreate&gt;**](TransactionItemCreate.md) | List of items associated with the transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

