using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAnuitexAutoProject.Framework.Models;

namespace UIAnuitexAutoProject.Framework
{
    public class JsonConverter
    {
        public static string path = @"C:\Users\Anuitex\jsonNewFile.json";

        private List<UserFromJson> _alluserlist;
        public List<UserFromJson> AllUserList
        {
            get
            {
                if (_alluserlist == null)
                {
                    string json = File.ReadAllText(path);
                    _alluserlist = JsonConvert.DeserializeObject<List<UserFromJson>>(json);
                }
                return _alluserlist;
            }
        }

        public string ReadTextFromJson(string path)
        {
            string json = File.ReadAllText(path);
            return json;
        }

        public UserFromJson GetUser()
        {
            UserFromJson currentUserData = AllUserList.FirstOrDefault();
            return currentUserData;
        }
    }
}
