using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSMONAUTA.DAO
{
    class Conexao : IConexao
    {
        public string GetConexao()
        {
            return System.Configuration.ConfigurationSettings.AppSettings["ConnectionString"];
        }
    }
}
