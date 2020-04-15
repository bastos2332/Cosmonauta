using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMONAUTA.DAL
{
    public class Cad001ApodModel
    {
        public int APDOid { get; set; }
        [JsonProperty("date")]
        public DateTime APDOdata { get; set; }
        [JsonProperty("title")]
        public string APDOtitulo { get; set; }
        [JsonProperty("explanation")]
        public string APDOdescricao { get; set; }
        [JsonProperty("url")]
        public string APDOurl { get; set; }
    }
}
