using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace COSMONAUTA.DAO.DAO
{
    class Cad001ApodDAO: CRUD
    {
        public List<DAL.Cad001ApodModel> Listar()
        {
            return base.Bd.Query<DAL.Cad001ApodModel>("sp_CAD001_APOD_List", CommandType.StoredProcedure).ToList();
        }
    }
}
