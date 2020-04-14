using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class CRUD
    {
        protected string StrCon { get; set; }
        protected int IdUser { get; set; }

        private static Conexao _cnx = new Conexao();

        private static UsuarioSESSION _userSession = new UsuarioSESSION();
        protected IDbConnection Bd { get; set; }



        public CRUD()
        {
            this.StrCon = _cnx.GetConexao;
            this.IdUser = _userSession.GetIDUsuarioSESSION();
            Bd = new SqlConnection(StrCon);
        }


        private DbType GetDBType(string propertType)
        {
            var retorno = null;
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
                if (!index == 0 & Information.IsNothing(valorPropriedade as CRUD))
                    param.Add($"@{nomePropriedade}", valorPropriedade, GetDBType(tipoPropriedade), ParameterDirection.Input);
                index += 1;
            }
        }
    }
}
