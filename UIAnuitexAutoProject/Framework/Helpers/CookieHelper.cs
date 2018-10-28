using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAnuitexAutoProject.Framework.Helpers
{
    public static class CookieHelper
    {
        public static void AddDefaultCookies(RestRequest request)
        {
            var str = "reflectorid:0000000000000000000000@lastupd:1540450519208@firstcreate:1540450518129";

            request.AddCookie("AID", "wmlspartner%3D0%3Areflectorid%3D0000000000000000000000%3Alastupd%3D1540450519208");
            request.AddCookie("DL", "94066%2C%2C%2Cip%2C94066%2C%2C");
            request.AddCookie("TS011baee6", "01c5a4e2f95454be1f8af79dd466f8e1d7d7ff1238cfd75f60604867b9f9592be8f1ec6c006e70a39d51e40113719373ad9bd376fc");
            request.AddCookie("TS018dc926", "01c5a4e2f95454be1f8af79dd466f8e1d7d7ff1238cfd75f60604867b9f9592be8f1ec6c006e70a39d51e40113719373ad9bd376fc");
            request.AddCookie("TS01a3099b", "01c5a4e2f95454be1f8af79dd466f8e1d7d7ff1238cfd75f60604867b9f9592be8f1ec6c006e70a39d51e40113719373ad9bd376fc");
            request.AddCookie("TS01e3f36f", "01c5a4e2f95454be1f8af79dd466f8e1d7d7ff1238cfd75f60604867b9f9592be8f1ec6c006e70a39d51e40113719373ad9bd376fc");
            request.AddCookie("WMP", "4");
            request.AddCookie("_abck", "b34q3ah9ozcftvpb9kf8_1823");
            request.AddCookie("_ga", "GA1.2.1224995826.1540450520");
            request.AddCookie("_gat_UA-126036700-1", "1");
            request.AddCookie("_gcl_au", "1.1.313866505.1540450521");
            request.AddCookie("_gid", "GA1.2.1877142342.1540450521");
            request.AddCookie("_scid", "673e2428-5776-46e6-81b6-d7fe3f7aaeb7");
            request.AddCookie("_sctr", "1|1540414800000");
            request.AddCookie("bstc", "dB-sjxZ_lJY-F7iXZ_iW3U");
            request.AddCookie("com.wm.reflector", $"\"{str}\"");
            request.AddCookie("cto_lwid", "8437471b-fb22-4bc4-aafb-6b0d69cd393d");
            request.AddCookie("customer", "%7B%22firstName%22%3A%22Ann%22%2C%22lastNameInitial%22%3A%22T%22%2C%22rememberme%22%3Atrue%7D");
            request.AddCookie("dfp_exp", "ads-mweb-skyline-control");
            request.AddCookie("exp-ck", "JUZP92MKaIf3OjCW-1SQMO11TkA-P2XfPOH1bOXs52h8bVz1lFNaS2o8b211p5xk41rtPI44wjqkF1");
            request.AddCookie("location-data", "94066%3ASan%20Bruno%3ACA%3A%3A0%3A0|21k%2C46y%2C1kf%2C1rc%2C46q%2C2nz%2C2b1%2C4bu%2C2er%2C1o1|2|3|1|");
            request.AddCookie("pulse_exp", "3");
            request.AddCookie("s_pers", "%20s_cmpstack%3D%255B%255B%2527seo_un%2527%252C%25271540450527731%2527%255D%255D%7C1698216927731%3B%20s_v%3DY%7C1540452419468%3B%20gpv_p11%3DAccount%253A%2520Create%7C1540452419517%3B%20gpv_p44%3DAccount%7C1540452419538%3B%20s_vs%3D1%7C1540452419552%3B%20s_fid%3D7DD62D6AA2B086BA-2DD672BB0CFE7421%7C1603612622847%3B");
            request.AddCookie("s_sess", "%20cmp%3Dseo_un%253A%3B%20ent%3DHomepage%3B%20s_cc%3Dtrue%3B%20cps%3D0%3B%20s_sq%3D%3B%20chan%3Dseo_un%3B%20v59%3DHomepage%3B%20v54%3DHomepage%3B");
            request.AddCookie("s_vi", "[CS]v1|2DE8B46D05311D70-40000103E0007187[CE]");
            request.AddCookie("vtc", "dB-sjxZ_lJY-F7iXZ_iW3U");
            request.AddCookie("x-csrf-jwt", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ0eXBlIjoiY29va2llIiwidXVpZCI6IjAzNTM4M2UwLWQ4MjMtMTFlOC1iNGQ4LWIxOTY2Y2ZkMDYzOCIsImlhdCI6MTU0MDQ1MDU1MiwiZXhwIjoxNTQyMjUwNTUyfQ.ei61iVE_GJ18Cpgf3xb59s0c0MEJvh76QbG8ma2IW1g");
            request.AddCookie("xpa", "JUZP9|MKaIf|OjCW-|SQMO1|TkA-P|XfPOH|bOXs5|h8bVz|lFNaS|o8b21|p5xk4|rtPI4|wjqkF");
            request.AddCookie("xpm", "1%2B1540450590%2BdB-sjxZ_lJY-F7iXZ_iW3U~%2B0");
        }
    }
}
