using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.API
{
    public static class ApiUrl
    {
        public static string BaseUrl => "https://www.walmart.com/";

        public static string SignUpApi => $"{BaseUrl}account/electrode/api/signup?ref=domain";            

    }
}

