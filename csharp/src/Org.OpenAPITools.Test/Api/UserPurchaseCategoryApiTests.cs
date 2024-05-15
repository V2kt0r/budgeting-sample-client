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
    ///  Class for testing UserPurchaseCategoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserPurchaseCategoryApiTests : IDisposable
    {
        private UserPurchaseCategoryApi instance;

        public UserPurchaseCategoryApiTests()
        {
            instance = new UserPurchaseCategoryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserPurchaseCategoryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserPurchaseCategoryApi
            //Assert.IsType<UserPurchaseCategoryApi>(instance);
        }

        /// <summary>
        /// Test CreatePurchaseCategory
        /// </summary>
        [Fact]
        public void CreatePurchaseCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PurchaseCategoryCreate purchaseCategoryCreate = null;
            //var response = instance.CreatePurchaseCategory(purchaseCategoryCreate);
            //Assert.IsType<PurchaseCategoryRead>(response);
        }

        /// <summary>
        /// Test DeletePurchaseCategory
        /// </summary>
        [Fact]
        public void DeletePurchaseCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid purchaseCategoryUuid = null;
            //var response = instance.DeletePurchaseCategory(purchaseCategoryUuid);
            //Assert.IsType<Message>(response);
        }

        /// <summary>
        /// Test GetPurchaseCategories
        /// </summary>
        [Fact]
        public void GetPurchaseCategoriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? itemsPerPage = null;
            //var response = instance.GetPurchaseCategories(page, itemsPerPage);
            //Assert.IsType<PaginatedListResponsePurchaseCategoryRead>(response);
        }

        /// <summary>
        /// Test UpdatePurchaseCategory
        /// </summary>
        [Fact]
        public void UpdatePurchaseCategoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid purchaseCategoryUuid = null;
            //PurchaseCategoryUpdate purchaseCategoryUpdate = null;
            //var response = instance.UpdatePurchaseCategory(purchaseCategoryUuid, purchaseCategoryUpdate);
            //Assert.IsType<Message>(response);
        }
    }
}
