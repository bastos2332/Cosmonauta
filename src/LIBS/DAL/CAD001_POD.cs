using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DAL
{
    public class CAD001_POD
    {
        public int PDOId { get; set; }
        public DateTime PDOData { get; set; }
        public string PDOTitulo { get; set; }
        public string PDODescricao { get; set; }
        public string PDOUrl { get; set; }
    }
}