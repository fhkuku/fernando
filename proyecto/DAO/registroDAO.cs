using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto.BO;

namespace proyecto.DAO
{
    class registroDAO : conexion
    {
        String query; DataTable datos; DataRow dr;
        public DataTable Buscarregistro()
        {
            query = string.Format("SELECT * FROM registro");
            return EjecutarQuery(query);
        }

        public int Agregarregistro(registroBO obo)
        {
            query = string.Format("INSERT INTO  registro(id,horaEntrada, horaSalida, matricula, idcajon, idtarifa)VALUES ('{0}','{1}','{2}','{3}''{4}','{5}');", obo.id, obo.horaEntrada.ToString("hh:mm:ss"), obo.horaSalida.ToString("hh:mm:ss"), obo.matricula, obo.idcajon, obo.idtarifa);
            return EjecutarSQL(query);
        }

        public int Modificarregistro(registroBO obo)
        {
            query = string.Format("UPDATE  registro SET horaEntrada='{1}', horaSalida='{2}', matricula='{4}', idcajon='{5}'  WHERE id={0}", obo.id, obo.horaEntrada.ToString("hh:mm:ss"), obo.horaSalida.ToString("hh:mm:ss"), obo.matricula, obo.idcajon, obo.idtarifa);
            return EjecutarSQL(query);
        }

        public int Borrarregistro(registroBO obo)
        {
            query = string.Format("DELETE FROM registro WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }

        //tarifa
        public DataTable Recuperartarifa(registroBO obo)
        {
            query = string.Format("SELECT * FROM tarifa WHERE idestacionamiento='{0}'", obo.id);
            return EjecutarQuery(query);
        }
        public DataTable Buscartarifa()
        {
            query = string.Format("SELECT * FROM tarifa");
            datos = EjecutarQuery(query);
            dr = datos.NewRow();
            dr["nombre"] = "Seleccionar";
            dr["id"] = 0;
            datos.Rows.InsertAt(dr, 0);
            return datos;
        }

        public int Agregartarifa(registroBO obo)
        {
            query = string.Format("INSERT INTO  tarifa (id,nombre,precio)VALUES ('{0}','{1}','{2}');", obo.idtarifa, obo.nombre, obo.precio);
            return EjecutarSQL(query);
        }

        public int Modificartarifa(registroBO obo)
        {
            query = string.Format("UPDATE  tarifa SET  nombre='{1}', precio='{2}' WHERE id={0}", obo.idtarifa, obo.nombre, obo.precio);
            return EjecutarSQL(query);
        }

        public int Borrartarifa(registroBO obo)
        {
            query = string.Format("DELETE FROM tarifa WHERE  id='{0}'", obo.idtarifa);
            return EjecutarSQL(query);
        }
    }
}
