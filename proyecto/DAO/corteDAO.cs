using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto.BO;

namespace proyecto.DAO
{
    class corteDAO : conexion
    {
        string query; DataTable datos; 
        public DataTable Buscarcorte()
        {
            query = string.Format("SELECT * FROM corte");
            return EjecutarQuery(query);
        }

        public int Agregarcorte(corteBO obo)
        {
            query = string.Format("INSERT INTO corte(id,idcobro, fecha, iduser, monto)VALUES ('{0}','{1}','{2}','{3}''{4}');", obo.id, obo.idcobro, obo.fecha.ToString("dd/mm/yyyy"), obo.iduser, obo.monto, obo.idgasto);
            return EjecutarSQL(query);
        }

        public int Modificarcorte(corteBO obo)
        {
            query = string.Format("UPDATE  corte SET idcobro='{1}', iduser='{2}', monto='{4}'  WHERE id={0}", obo.id, obo.idcobro, obo.fecha.ToString("dd/mm/yyyy"), obo.iduser, obo.monto, obo.idgasto);
            return EjecutarSQL(query);
        }

        public int Borrarcorte(corteBO obo)
        {
            query = string.Format("DELETE FROM corte WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }
    }
}
