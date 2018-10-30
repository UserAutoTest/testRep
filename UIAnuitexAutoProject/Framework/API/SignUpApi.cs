using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework.API;
using UIAnuitexAutoProject.Framework.Helpers;
using UIAnuitexAutoProject.Framework.Models.ApiModels.ResponseModels;

namespace UIAnuitexAutoProject.Framework
{
    public class SignUpApi : BaseApi1
    {
        public SignUpApi()
        {
            _request = new RestRequest(ApiUrl.SignUpApi, Method.POST);

            _request.RequestFormat = DataFormat.Json;

            CookieHelper.AddDefaultCookies(_request);

            _request.AddParameter("Content-Type", "application/json; charset=utf-8");

            _request.AddParameter("ref", "domain");

        }

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
