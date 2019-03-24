using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto.BO;

namespace proyecto.DAO
{
    class cobroDAO : conexion
    {
        String query; DataTable datos; DataRow dr;
        public DataTable Buscarcobro()
        {
            query = string.Format("SELECT * FROM cobro");
            return EjecutarQuery(query);
        }

        public int Agregarcobro(cobroBO obo) //si la fecha es automatica hay que quitarla de aqui
        {
            query = string.Format("INSERT INTO  cobro(id,fecha, monto, iduser, idtipoCobro)VALUES ('{0}','{1}','{2}','{3}''{4}');", obo.id, obo.fecha.ToString("dd/mm/yyyy"), obo.monto.ToString(), obo.iduser, obo.idtipoCobro);
            return EjecutarSQL(query);
        }

        public int Modificarcobro(cobroBO obo)
        {
            query = string.Format("UPDATE  cobro SET monto='{1}', iduser='{2}', idtipoCobro='{4}'  WHERE id={0}", obo.id,  obo.fecha.ToString("dd/mm/yyyy"),  obo.monto.ToString(), obo.iduser, obo.idtipoCobro);
            return EjecutarSQL(query);
        }

        public int Borrarcobro(cobroBO obo)
        {
            query = string.Format("DELETE FROM cobro WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }
    }
}
