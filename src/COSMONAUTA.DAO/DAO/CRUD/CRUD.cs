using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace COSMONAUTA.DAO
{

    public abstract class CRUD
    {
        protected string StrCon { get; set; }
        protected int IdUser { get; set; }

        private static Conexao _cnx = new Conexao();

        protected IDbConnection Bd { get; set; }

        public CRUD()
        {
            this.StrCon = _cnx.GetConexao();
            Bd = new SqlConnection(StrCon);
        }


        private DbType GetDBType(string propertType)
        {
            DbType retorno = DbType.Object;
            switch (propertType)
            {
                case "String":
                    {
                        retorno = DbType.String;
                        break;
                    }

                case "Int32":
                    {
                        retorno = DbType.Int32;
                        break;
                    }

                case "Nullable`1":
                    {
                        retorno = DbType.String;
                        break;
                    }

                case "Byte[]":
                    {
                        retorno = DbType.Binary;
                        break;
                    }

                case "Guid":
                    {
                        retorno = DbType.Guid;
                        break;
                    }
            }
            return retorno;
        }

        protected void PreecnherParametros(DynamicParameters param, CRUD classe)
        {
            int index = 0;
            Type type = null;
            type = classe.GetType();
            PropertyInfo[] propriedades = type.GetProperties();
            foreach (PropertyInfo propriedade in propriedades)
            {
                var nomePropriedade = propriedade.Name;
                var valorPropriedade = propriedade.GetValue(classe, propriedade.GetIndexParameters());
                var tipoPropriedade = propriedade.PropertyType.Name;
                if (index != 0 & valorPropriedade as CRUD == null) //Não pegar PK e nem Propriedades Complexas
                {
                    param.Add($"@{nomePropriedade}", valorPropriedade, GetDBType(tipoPropriedade), ParameterDirection.Input);
                }
                index += 1;
            }
        }
    }
}
