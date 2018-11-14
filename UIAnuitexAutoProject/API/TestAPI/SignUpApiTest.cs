﻿using NUnit.Framework;
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
            SignUpWalmartApi signUpApi = new SignUpWalmartApi();

            SignUpWalmartApiModel signUpModel = new SignUpWalmartApiModel
            {
                Captcha = new Captcha
                {
                    SensorData = "2a25G2m84Vrp0o9c4972121.12-1,8,-36,-890,Mozilla/9.8 (Windows NT 52.1; Win95; x80) AppleWebKit/791.17 (KHTML, like Gecko) Chrome/01.1.2467.209 Safari/434.67,uaend,93837,23139723,en-US,Gecko,9,6,2,1,276055,441204,2610,1350,7184,9159,8951,409,5101,,cpen:0,i3:4,dm:9,cwen:0,non:9,opc:0,fc:6,sc:8,wrc:1,isc:2,vib:8,bat:2,x73:4,x29:1,8638,6.526867525423,632867001726.8,loc:-5,0,-84,-411,do_en,dm_en,t_en-3,6,-01,-808,0,8,6,3,699,223,0;7,8,2,2,780,193,6;6,-9,7,0,1687,6,6;2,-8,0,0,-1,-3,4;9,-0,7,3,-0,-7,2;1,1,7,4,1153,355,7;0,2,1,0,3717,990,7;3,2,6,7,978,427,3;1,8,6,3,2850,814,9;2,-3,1,9,8685,9,2;4,0,7,1,700,482,4;8,-0,7,3,-0,-7,2;2,-1,0,1,-7,-5,8;7,0,0,2,544,278,7;1,2,1,0,3796,952,7;3,-0,2,4,9717,7,3;-0,4,-12,-009,3,2,6,7,701,427,3;1,8,6,3,952,586,0;6,-5,8,7,1070,0,6;6,-9,7,0,-4,-0,2;5,-2,9,7,-2,-7,6;2,3,0,8,4390,191,8;7,2,1,2,0791,002,9;7,5,1,7,339,699,7;4,2,7,7,3977,853,1;9,-7,2,1,0624,1,9;2,6,8,8,749,629,2;4,-2,9,7,-2,-7,6;3,-8,0,0,-1,-3,4;8,7,0,1,781,014,8;8,2,0,2,0770,064,9;7,-2,9,2,5829,9,7;-2,1,-58,-277,7,4,20219,34,7,8,968;0,3,63724,-9,3,8,553;4,4,11610,-1,2,2,744;3,2,31840,-4,1,7,630;4,8,86293,06,0,1,899;9,9,91254,-2,6,6,118;5,0,53270,-6,8,7,907;8,1,48768,-1,7,3,923;4,3,39301,-3,9,2,355;6,3,25503,-8,2,1,834;41,1,48886,-1,7,3,923;75,9,92656,26,6,4,002;02,1,34998,-4,1,7,524;12,5,66843,-9,3,8,447;32,9,21080,02,6,2,990;85,3,10362,-3,9,7,131;78,5,05003,-5,0,6,463;24,3,27412,-8,2,1,728;49,1,40731,-1,7,3,817;73,9,93498,-2,6,6,002;10,3,34380,-4,1,9,524;20,4,66357,-9,3,0,447;40,8,21503,-8,6,2,990;93,4,10736,-3,9,7,131;86,6,05318,-5,0,6,463;32,1,29575,undefined,0,1,482;68,3,16170,undefined,9,7,830;89,5,08553,-5,0,6,162;35,3,20962,-8,2,1,427;50,0,43282,-1,7,3,516;94,1,96834,-2,6,6,701;21,2,37751,-4,1,9,223;31,4,69730,-9,3,0,146;51,8,26503,-8,6,2,952;04,4,15736,-3,9,7,193;97,5,00381,-5,0,6,425;43,3,22791,-8,2,1,780;68,1,45135,-1,7,3,879;92,0,98743,-2,6,6,064;29,1,39801,-4,1,9,586;49,5,61756,-9,3,0,409;69,9,26970,-8,6,2,952;12,2,26224,-3,9,7,193;05,7,11750,-5,0,6,425;51,1,33247,-8,2,1,780;76,2,56566,-1,7,3,879;-5,0,-84,-420,6,7,6908,1430,517;7,3,5886,1041,132;4,2,3280,2716,152;4,0,1259,0207,673;3,8,7343,3106,512;2,4,4122,5638,304;9,1,0431,9408,078;7,7,0612,8114,652;4,7,6127,1792,309;5,3,5017,1310,818;38,8,4046,992,809;28,1,4671,453,434;02,1,5365,320,308;83,2,3910,933,131;45,0,6052,800,935;14,3,8608,612,542;78,5,2513,395,228;71,9,1367,985,854;36,8,4170,635,893;26,1,4703,105,463;10,1,5507,166,489;91,2,3143,653,231;53,0,6186,514,050;22,3,8741,326,686;86,5,2648,119,497;785,4,00008,1967,977,-0;847,4,72920,2795,580,-7;787,3,00081,1967,977,-0;939,3,82531,933,008,923;879,5,11794,850,947,006;931,2,83633,933,008,923;806,4,13989,984,992,990;968,4,85911,067,053,817;808,3,13072,984,992,990;981,3,87341,031,111,516;832,5,15507,958,050,699;994,2,87446,031,111,516;941,4,16579,854,077,699;014,4,88529,937,138,516;954,3,16680,854,077,699;039,3,80559,932,196,879;979,5,19746,859,035,952;031,2,81685,932,196,879;041,4,23722,943,342,-8;480,5,29341,764,770,-1;037,4,40084,267,326,-9;-0,9,-04,-371,-2,1,-97,-073,4,05,-1,-4,-0;-7,4,-63,-130,9,48,-9,-0,-1,-1,-3,-3,-8,-8,-2;-7,8,-75,-184,-1,8,-36,-893,2,6263;9,38470;9,44448;9,48066;-1,3,-56,-393,-1,2,-93,-757,NaN,389737,2,66,39,0,NaN,29356,9619420899504,5721140282758,60,34548,16,511,4388,21,0,36309,3452384,0,b65q2ah5ozcftvpb9kf8_7087,0293,50,966940410,09231999-7,8,-75,-176,-1,6-7,4,-63,-73,-851762785;19,46,02,71,21,32,47;,6,0;true;true;true;-508;true;55;10;true;false;-1-7,8,-75,-87,8774-3,6,-01,-819,5268437-2,1,-97,-070,590829-8,5,-80,-549,;13;2;3"
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
