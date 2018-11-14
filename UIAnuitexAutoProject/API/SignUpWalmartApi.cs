using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UIAutoProject.Framework.Models.ApiModels.ResponseModels;

namespace UIAutoProject.Framework
{
    public class SignUpWalmartApi : BaseApi
    {      
        public SignUpWalmartApi()
        {
            _request = new RestRequest(SignUpApi, Method.POST);

            _request.RequestFormat = DataFormat.Json;

            _request.AddCookie("com.wm.reflector", $"\"reflectorid: 0000000000000000000000@lastupd: 1540450519208@firstcreate: 1540450518129\"");
            
            _request.AddParameter("Content-Type", "application/json; charset=utf-8");

            _request.AddParameter("ref", "domain");
        }
        
        public string SignUpApi => "https://www.walmart.com/account/electrode/api/signup?ref=domain";


        public SignUpResponse CallSignUpApi(object myBodyModel= null, HttpStatusCode expectedResponse = HttpStatusCode.OK)
        {
            _request.AddBody(myBodyModel);

            SignUpResponse response = ExecuteRequest<SignUpResponse>();
          
            return response;
        }
    }
}
