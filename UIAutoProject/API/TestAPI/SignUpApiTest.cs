using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIAutoProject.Framework;
using UIAutoProject.Framework.Models;
using UIAutoProject.Framework.Models.ApiModels.RequestModels;

namespace UIAutoProject.TestAPI
{
    public class SignUpApiTest : BaseApi
    {
        [Test]
        public void CreateNewUserApiTest()
        {
            WalmartApiSignUp signUpApi = new WalmartApiSignUp();

            WalmartApiSignUpModel signUpModel = new WalmartApiSignUpModel
            {
                Captcha = new Captcha
                {
                    SensorData = ""
                },
                PersonName = new PersonNameModel
                {
                    FirstName = $"F{DateTime.Now.ToString("mmddhhmmss")}",
                    LastName = $"L{DateTime.Now.ToString("mmddhhmmss")}"
                },
                Email = $"test{DateTime.Now.ToString("mmddhhmmss")}@gmail.com",
                Password = "12345678",
                Rememberme = true,
                ShowRememberme = true,
                EmailNotificationAccepted = true
            };            
            
            var signUpresponse = signUpApi.CallSignUpApi(signUpModel);
            var fName = signUpresponse.FirstName;
            var lName = signUpresponse.LastName;

            Assert.Multiple(() =>
            {
                Assert.AreEqual(signUpModel.PersonName.FirstName, fName, "Check that First Names are equal");
                Assert.AreEqual(signUpModel.PersonName.LastName, lName, "Check that Last Names are equal");
            });            
        }
    }
}
