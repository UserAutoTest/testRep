using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UIAutoProject.Framework.API;
using UIAutoProject.Framework.Helpers;
using UIAutoProject.Framework.Models.ApiModels.ResponseModels;

namespace UIAutoProject.Framework
{
    public class SignUpWalmartApi : BaseApi
    {      
        public SignUpWalmartApi()
        {
            _request = new RestRequest(WalmartApiUrls.SignUpApi, Method.POST);

            _request.RequestFormat = DataFormat.Json;

            CookieHelper.AddDefaultCookies(_request);

            _request.AddParameter("Content-Type", "application/json; charset=utf-8");

            _request.AddParameter("ref", "domain");
        }

        public string BaseUrl => "https://www.walmart.com/";

        public string SignUpApi => $"{BaseUrl}account/electrode/api/signup?ref=domain";


        public SignUpResponse CallSignUpApi(object myBodyModel= null, HttpStatusCode expectedResponse = HttpStatusCode.OK)
        {
            _request.AddBody(myBodyModel);

            SignUpResponse response = ExecuteRequest<SignUpResponse>();

            if (_allResponseCookie != null)
            {
                foreach (var c in _allResponseCookie)
                {
                    _request.AddCookie(c.Name, c.Value);
                }
            }
            return response;
        }
    }
}
