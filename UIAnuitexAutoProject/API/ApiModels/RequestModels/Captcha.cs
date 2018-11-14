using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutoProject.Framework.Models.ApiModels.RequestModels
{
    public class Captcha
    {
        [JsonProperty("sensorData")]
        public string SensorData { get; set; }

    }
}
