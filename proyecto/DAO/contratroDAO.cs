using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto.BO;

namespace proyecto.DAO
{
    class contratroDAO : conexion
    {
        String query; DataTable datos; DataRow dr;
        public DataTable Buscarcontrato()
        {
            query = string.Format("SELECT * FROM contrato");
            return EjecutarQuery(query);
        }

        public int Agregarcontrato(contratoBO obo) //si la fecha es automatica hay que quitarla de aqui
        {
            query = string.Format("INSERT INTO  contrato(monto, fechaInicio, iduser, idcliente)VALUES ('{0}','{1}','{2}','{3}');", obo.monto, obo.fechaInicio, obo.iduser, obo.idcliente);
            return EjecutarSQL(query);
        }

        public int Modificarcontrato(contratoBO obo)
        {
            query = string.Format("UPDATE  contrato SET monto='{1}', fechaFin='{2}', idcliente='{4}' WHERE id={0}", obo.id, obo.monto, obo.fechaFin, obo.iduser, obo.idcliente);
            return EjecutarSQL(query);
        }

        public int Borrarcontrato(contratoBO obo)
        {
            query = string.Format("DELETE FROM contrato WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }

        //TELEFONOS
        public DataTable Recuperarcliente(contratoBO obo)
        {
            query = string.Format("SELECT * FROM estacionamientoTelefono WHERE idestacionamiento='{0}'", obo.id);
            datos = EjecutarQuery(query);
            dr = datos.NewRow();
            dr["Num_1 "] = "Seleccionar";
            dr["Cod_Tel"] = 0;
            datos.Rows.InsertAt(dr, 0);
            return datos;
        }
        public DataTable Buscarcliente()
        {
            query = string.Format("SELECT * FROM cliente");
            return EjecutarQuery(query);
        }

        public int Agregarcliente(contratoBO obo)
        {
            query = string.Format("INSERT INTO  cliente (id,nombre,apellidos,telefono)VALUES ('{0}','{1}','{2}','{3}');", obo.idcliente, obo.nombre, obo.apellidos, obo.telefono);
            return EjecutarSQL(query);
        }

        public int Modificarcliente(contratoBO obo)
        {
            query = string.Format("UPDATE  cliente SET  nombre='{1}', apellidos='{2}',telefono='{2}' WHERE id={0}", obo.idcliente, obo.nombre, obo.apellidos, obo.telefono);
            return EjecutarSQL(query);
        }

        public int Borrarcliente(contratoBO obo)
        {
            query = string.Format("DELETE FROM cliente WHERE  id='{0}'", obo.idcliente);
            return EjecutarSQL(query);
        }

        //Cajones
        
        public DataTable BuscarcontratoCajon()
        {
            query = string.Format("SELECT * FROM contratoCajon");
            return EjecutarQuery(query);
        }

        public int AgregarcontratoCajon(contratoBO obo)
        {
            query = string.Format("INSERT INTO  contratoCajon(id,idcontrato,idcajon)VALUES ('{2}','{1}','{0}');", obo.idcajon, obo.id, obo.idcontcajo);
            return EjecutarSQL(query);
        }

        public int ModificarcontratoCajon(contratoBO obo)
        {
            query = string.Format("UPDATE  contratoCajon SET idcajon='{0}' idcontrato='{1}' WHERE id={2}", obo.idcajon, obo.id, obo.idcontcajo);
            return EjecutarSQL(query);
        }

        public int BorrarcontratoCajon(contratoBO obo)
        {
            query = string.Format("DELETE FROM contratoCajon WHERE  id='{0}'", obo.idcontcajo);
            return EjecutarSQL(query);
        }
    }
}
