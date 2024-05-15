/*
 * Budgeting Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing TransactionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransactionsApiTests : IDisposable
    {
        private TransactionsApi instance;

        public TransactionsApiTests()
        {
            instance = new TransactionsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransactionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TransactionsApi
            //Assert.IsType<TransactionsApi>(instance);
        }

        /// <summary>
        /// Test CreateUserTransaction
        /// </summary>
        [Fact]
        public void CreateUserTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //TransactionCreate transactionCreate = null;
            //var response = instance.CreateUserTransaction(transactionCreate);
            //Assert.IsType<TransactionRead>(response);
        }

        /// <summary>
        /// Test DeleteTransaction
        /// </summary>
        [Fact]
        public void DeleteTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid transactionUuid = null;
            //var response = instance.DeleteTransaction(transactionUuid);
            //Assert.IsType<Message>(response);
        }

        /// <summary>
        /// Test GetTransaction
        /// </summary>
        [Fact]
        public void GetTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid transactionUuid = null;
            //var response = instance.GetTransaction(transactionUuid);
            //Assert.IsType<TransactionRead>(response);
        }

        /// <summary>
        /// Test GetUserTransactions
        /// </summary>
        [Fact]
        public void GetUserTransactionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DateTime? before = null;
            //DateTime? after = null;
            //int? page = null;
            //int? itemsPerPage = null;
            //var response = instance.GetUserTransactions(before, after, page, itemsPerPage);
            //Assert.IsType<PaginatedListResponseTransactionRead>(response);
        }

        /// <summary>
        /// Test UpdateTransaction
        /// </summary>
        [Fact]
        public void UpdateTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid transactionUuid = null;
            //TransactionUpdate transactionUpdate = null;
            //var response = instance.UpdateTransaction(transactionUuid, transactionUpdate);
            //Assert.IsType<Message>(response);
        }
    }
}
