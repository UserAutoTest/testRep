using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.Models.ApiModels.ResponseModels
{
    public class SignUpResponse
    {
        [JsonProperty("cid")]
        public Guid Cid { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("omsCustomerId")]
        public long OmsCustomerId { get; set; }

        [JsonProperty("iamError")]
        public bool IamError { get; set; }

        [JsonProperty("caError")]
        public bool CaError { get; set; }
    }
}
