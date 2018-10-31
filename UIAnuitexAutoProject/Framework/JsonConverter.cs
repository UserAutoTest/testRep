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
        public static string _path = @"C:\Users\Anuitex\jsonFile.json";

        private List<UserFromJson> _alluserlist;
        public List<UserFromJson> AllUserList
        {
            get
            {
                if (_alluserlist == null)
                {
                    string json = File.ReadAllText(_path);
                    _alluserlist = JsonConvert.DeserializeObject<List<UserFromJson>>(json);
                }
                return _alluserlist;
            }
        }

        public UserFromJson GetUser()
        {
            UserFromJson currentUserData = AllUserList.LastOrDefault();
            return currentUserData;
        }    
        
        public UserFromJson GetDataByLogin(string login)
        {
            UserFromJson currentUserData = AllUserList.Where(x => x.Login == login).FirstOrDefault();
            return currentUserData;
        }

        public void ReplaceUserDataInJson(UserFromJson user, string s1, string s2)
        {
            UserFromJson currentUserData = AllUserList.Where(x => x.Login == user.Login).FirstOrDefault();
            currentUserData.FirstName = s1;
            currentUserData.LastName = s2;
            string output = JsonConvert.SerializeObject(AllUserList, Formatting.Indented);
            File.WriteAllText(_path, output);
        }
    }
}
