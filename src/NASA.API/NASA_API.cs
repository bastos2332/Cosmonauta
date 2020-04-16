using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NASA
{
    public class NASA_API
    {
        public string API { get; set; } = "https://api.nasa.gov/planetary/apod";
        public string APIKey { get; set; } = "tNOJYwflSt0Zg0D8S5A6nxvVv1EqeJxNMAGTwkZ4";
        public RestClient client { get; set; }

        public NASA_API()
        {
            client = new RestClient(API);
            client.AddDefaultParameter("api_key", APIKey);
            client.Timeout = -1;
        }

    }
}
