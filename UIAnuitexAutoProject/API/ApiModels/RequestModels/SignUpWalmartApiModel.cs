using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework.Models.ApiModels.RequestModels
{
    public class WalmartApiSignUpModel
    {        
        [JsonProperty("captcha")]
        public Captcha Captcha { get; set; }

        [JsonProperty("personName")]
        public PersonNameModel PersonName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("rememberme")]
        public bool Rememberme { get; set; }

        [JsonProperty("showRememberme")]
        public bool ShowRememberme { get; set; }

        [JsonProperty("emailNotificationAccepted")]
        public bool EmailNotificationAccepted { get; set; }
    }
}

