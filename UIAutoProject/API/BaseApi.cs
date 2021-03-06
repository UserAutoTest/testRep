﻿using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework
{
    public class BaseApi
    {
        protected RestRequest _request;
        private RestClient _client;

        public T ExecuteRequest<T>(HttpStatusCode code = HttpStatusCode.OK) where T : new()
        {
            var response = Client.Execute<T>(_request);

            CheckResponse(code, response.StatusCode);

            var resposeData = response.Data;

            return resposeData;
        }

        public void CheckResponse(HttpStatusCode expectedStatus, HttpStatusCode actualStatusCode)
        {
            Assert.AreEqual(expectedStatus, actualStatusCode, "Wrong actual API response.");
        }

        public RestClient Client => _client ?? (_client = new RestClient("https://www.walmart.com/"));        
    }
}
