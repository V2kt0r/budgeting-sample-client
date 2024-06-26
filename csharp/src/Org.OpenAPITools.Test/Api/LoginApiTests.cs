/*
 * Budgeting Server
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.4
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
    ///  Class for testing LoginApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LoginApiTests : IDisposable
    {
        private LoginApi instance;

        public LoginApiTests()
        {
            instance = new LoginApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LoginApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LoginApi
            //Assert.IsType<LoginApi>(instance);
        }

        /// <summary>
        /// Test LoginForAccessToken
        /// </summary>
        [Fact]
        public void LoginForAccessTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //string? grantType = null;
            //string? scope = null;
            //string? clientId = null;
            //string? clientSecret = null;
            //var response = instance.LoginForAccessToken(username, password, grantType, scope, clientId, clientSecret);
            //Assert.IsType<TokenPair>(response);
        }

        /// <summary>
        /// Test LoginForAccessTokenSwagger
        /// </summary>
        [Fact]
        public void LoginForAccessTokenSwaggerTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string password = null;
            //string? grantType = null;
            //string? scope = null;
            //string? clientId = null;
            //string? clientSecret = null;
            //var response = instance.LoginForAccessTokenSwagger(username, password, grantType, scope, clientId, clientSecret);
            //Assert.IsType<Token>(response);
        }

        /// <summary>
        /// Test Logout
        /// </summary>
        [Fact]
        public void LogoutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Logout();
            //Assert.IsType<Message>(response);
        }

        /// <summary>
        /// Test RefreshAccessToken
        /// </summary>
        [Fact]
        public void RefreshAccessTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Token token = null;
            //var response = instance.RefreshAccessToken(token);
            //Assert.IsType<TokenPair>(response);
        }
    }
}
