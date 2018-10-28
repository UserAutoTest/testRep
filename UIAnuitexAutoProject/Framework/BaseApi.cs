using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework.Helpers;

namespace UIAnuitexAutoProject.Framework
{
    public class BaseApi
    {
        public static  IList<RestResponseCookie> _allResponseCookie;

        public void DoPost(string path, string urlSegment = null, object myBodyModel = null,
            HttpStatusCode code = HttpStatusCode.OK)
        {
            
            var client = new RestClient(path);

            var request = new RestRequest($"{path}{urlSegment}", Method.POST);
            request.RequestFormat = DataFormat.Json;

            CookieHelper.AddDefaultCookies(request);

            request.AddParameter("Content-Type", "application/json; charset=utf-8");
            request.AddParameter("ref", "domain");

            request.AddBody(myBodyModel);

            if (_allResponseCookie != null)
            {
                foreach (var c in _allResponseCookie)
                {
                    request.AddCookie(c.Name, c.Value);
                }
            }

            IRestResponse response = client.Execute(request);

            CheckResponse(code, response.StatusCode);

            _allResponseCookie = response.Cookies;
        }

        public void CheckResponse(HttpStatusCode expectedStatus, HttpStatusCode actualStatusCode)
        { 
            Assert.AreEqual(expectedStatus, actualStatusCode, "Wrong actual API response.");
        }
    }
}
