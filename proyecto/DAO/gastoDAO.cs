using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto.BO;

namespace proyecto.DAO
{
    class gastoDAO : conexion
    {
        String query; DataTable datos; DataRow dr;
        public DataTable Buscargasto()
        {
            query = string.Format("SELECT * FROM gasto");
            return EjecutarQuery(query);
        }

        public int Agregargasto(gastoBO obo)
        {
            query = string.Format("INSERT INTO  gasto(id,idtipoGasto, fecha, iduser, monto)VALUES ('{0}','{1}','{2}','{3}''{4}');", obo.id, obo.idtipoGasto, obo.fecha.ToString("dd/mm/yyyy"), obo.iduser, obo.monto);
            return EjecutarSQL(query);
        }

        public int Modificargasto(gastoBO obo)
        {
            query = string.Format("UPDATE  gasto SET idtipoGasto='{1}', iduser='{2}', monto='{4}'  WHERE id={0}", obo.id, obo.idtipoGasto, obo.fecha.ToString("dd/mm/yyyy"), obo.iduser, obo.monto);
            return EjecutarSQL(query);
        }

        public int Borrargasto(gastoBO obo)
        {
            query = string.Format("DELETE FROM gasto WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }

        //tarifa
        public DataTable Recuperartarifa(gastoBO obo)
        {
            query = string.Format("SELECT * FROM tipoGasto WHERE id='{0}'", obo.idtipoGasto);
            return EjecutarQuery(query);
        }
        public DataTable tipoGasto()
        {
            query = string.Format("SELECT * FROM tipoGasto");
            datos = EjecutarQuery(query);
            dr = datos.NewRow();
            dr["nombre"] = "Seleccionar";
            dr["id"] = 0;
            datos.Rows.InsertAt(dr, 0);
            return datos;
        }

        public int AgregartipoGasto(gastoBO obo)
        {
            query = string.Format("INSERT INTO  tipoGasto (id,nom)VALUES ('{0}','{1}');", obo.idtipoGasto, obo.nom);
            return EjecutarSQL(query);
        }

        public int ModificartipoGasto(gastoBO obo)
        {
            query = string.Format("UPDATE  tipoGasto SET  nom='{1}' WHERE id={0}", obo.idtipoGasto, obo.nom);
            return EjecutarSQL(query);
        }

        public int BorrartipoGasto(gastoBO obo)
        {
            query = string.Format("DELETE FROM tipoGasto WHERE  id='{0}'", obo.idtipoGasto);
            return EjecutarSQL(query);
        }
    }
}
