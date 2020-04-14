using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAO
{
    class Conexao : IConexao

    {
        public string GetConexao() => ConfigurationSettings.AppSettings[""];
    }

}


