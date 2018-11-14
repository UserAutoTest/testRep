using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework.Models.ApiModels.RequestModels
{
    public class SignUpWalmartApiModel
    {        
        [JsonProperty("captcha")]
        public Captcha captcha { get; set; }

        [JsonProperty("personName")]
        public PersonNameModel personName { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("password")]
        public string password { get; set; }

        [JsonProperty("rememberme")]
        public bool rememberme { get; set; }

        [JsonProperty("showRememberme")]
        public bool showRememberme { get; set; }

        [JsonProperty("emailNotificationAccepted")]
        public bool emailNotificationAccepted { get; set; }
    }
}

