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
    public class APDO : NASA_API

    {

        public COSMONAUTA.DAL.Cad001ApodModel GetImagemDia()
        {
            var request = new RestRequest(Method.GET);
            IRestResponse response = base.client.Execute(request);
            return JsonConvert.DeserializeObject<COSMONAUTA.DAL.Cad001ApodModel>(response.Content);
        }

        public COSMONAUTA.DAL.Cad001ApodModel GetImagemDia(string data)
        {
            base.client.AddDefaultParameter("date", data);
            var request = new RestRequest(Method.GET);
            IRestResponse response = base.client.Execute(request);
            return JsonConvert.DeserializeObject<COSMONAUTA.DAL.Cad001ApodModel>(response.Content);
        }
    }
}
