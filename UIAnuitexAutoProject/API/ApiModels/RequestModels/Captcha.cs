using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.Models.ApiModels.RequestModels
{
    public class Captcha
    {
        [JsonProperty("sensorData")]
        public string sensorData { get; set; }

    }
}
