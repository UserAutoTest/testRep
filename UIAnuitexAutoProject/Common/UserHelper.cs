using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutoProject.Framework.Models;

namespace UIAutoProject.Framework
{
    public class UserHelper
    {
        public static string _path = @"C:\Users\Anuitex\jsonFile.json";

        private List<User> _alluserlist;
        public List<User> AllUserList
        {
            get
            {
                if (_alluserlist == null)
                {
                    string json = File.ReadAllText(_path);
                    _alluserlist = JsonConvert.DeserializeObject<List<User>>(json);
                }
                return _alluserlist;
            }
        }

        public User GetUser()
        {
            User currentUserData = AllUserList.LastOrDefault();
            return currentUserData;
        }    
        
        public User GetDataByLogin(string login)
        {
            User currentUserData = AllUserList.Where(x => x.Login == login).FirstOrDefault();
            return currentUserData;
        }

        public void ReplaceUserDataInJson(User user, string s1, string s2)
        {
            User currentUserData = AllUserList.Where(x => x.Login == user.Login).FirstOrDefault();
            currentUserData.FirstName = s1;
            currentUserData.LastName = s2;
            string output = JsonConvert.SerializeObject(AllUserList, Formatting.Indented);
            File.WriteAllText(_path, output);
        }
    }
}
