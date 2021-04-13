using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;

namespace DistApplication
{
    public class CookieAwareWebClient : WebClient
    {
        private CookieContainer CookieContainer;

        public void Login(string loginPageAddress, NameValueCollection loginData)
        {
            System.Net.CookieContainer container;

            var request = (HttpWebRequest)WebRequest.Create(loginPageAddress);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            var query = string.Join("&",
              loginData.Cast<string>().Select(key => $"{key}={loginData[key]}"));

            var buffer = Encoding.ASCII.GetBytes(query);
            request.ContentLength = buffer.Length;
            var requestStream = request.GetRequestStream();
            requestStream.Write(buffer, 0, buffer.Length);
            requestStream.Close();

            container = request.CookieContainer = new CookieContainer();

            var response = request.GetResponse();
            response.Close();
            CookieContainer = container;
        }
        public CookieAwareWebClient(CookieContainer container)
        {
            CookieContainer = container;
        }

        public CookieAwareWebClient()
          : this(new CookieContainer())
        { }

        public CookieContainer CookieContainer { get; private set; }

        protected override WebRequest GetWebRequest(Uri address)
        {
            var request = (HttpWebRequest)base.GetWebRequest(address);
            request.CookieContainer = CookieContainer;
            return request;
        }

    }
    class Program
        {
            static void Main(string[] args)
            {
            var loginAddress = "https://www.senegence.com/senegenceweb/DistBackOffice/Default.aspx";   /* "https://seneweb.senegence.com/us/contact/distributor-login/";*/
            var loginData = new NameValueCollection
           {
             { "username", "1111" },
             { "password", "LIPS2NV" }
            };
 
            var client = new CookieAwareWebClient();
            client.Login(loginAddress, loginData);
              
        }
            
    }
   

    
}
