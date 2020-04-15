using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COSMONAUTA;
using Newtonsoft.Json;

namespace NASA
{
    public class APDO
    {
        public string Api { get; set; } = "https://api.nasa.gov/planetary/apod";

        public COSMONAUTA.DAL.Cad001ApodModel GetImagemDia()
        {
            RestClient client = new RestClient(Api);
            client.AddDefaultParameter("api_key", "tNOJYwflSt0Zg0D8S5A6nxvVv1EqeJxNMAGTwkZ4");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            return JsonConvert.DeserializeObject<COSMONAUTA.DAL.Cad001ApodModel>(response.Content);
        }
    }
}
