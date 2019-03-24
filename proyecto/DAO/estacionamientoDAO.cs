using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using proyecto.BO;

namespace proyecto.DAO
{
    class estacionamientoDAO : conexion
    {
        String query; DataTable datos; DataRow dr;
        public DataTable RecuperarEmpresa()
        {
            query = string.Format("SELECT * FROM empresa");
            datos = EjecutarQuery(query);
            dr = datos.NewRow();
            dr["Nombre"] = "Seleccionar";
            dr["NúmE"] = 0;
            datos.Rows.InsertAt(dr, 0);
            return datos;
        }

        public DataTable BuscarESTACIONAMIENTO()
        {
            query = string.Format("SELECT * FROM estacionamiento");
            return EjecutarQuery(query);
        }

        public int AgregarESTACIONAMIENTO(estacionamientoBO obo)

        {
            query = string.Format("INSERT INTO  estacionamiento(idempresa,nombres, rfc,direccion)VALUES ('{0}','{1}','{2}','{3}');", obo.idempresa, obo.rfc, obo.nombre, obo.direccion);
            return EjecutarSQL(query);
        }

        public int ModificarESTACIONAMIENTO(estacionamientoBO obo)
        {
            query = string.Format("UPDATE  estacionamiento SET idempresa='{0}', nombres='{2}', direccion='{4}' WHERE id={1}", obo.idempresa, obo.id, obo.rfc, obo.nombre, obo.direccion);
            return EjecutarSQL(query);
        }

        public int BorrarESTACIONAMIENTO(estacionamientoBO obo)
        {
            query = string.Format("DELETE FROM estacionamiento WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }

        //TELEFONOS
        public DataTable RecuperarTelefono(estacionamientoBO obo)
        {
            query = string.Format("SELECT * FROM estacionamientoTelefono WHERE idestacionamiento='{0}'", obo.id);
            datos = EjecutarQuery(query);
            dr = datos.NewRow();
            dr["Num_1 "] = "Seleccionar";
            dr["Cod_Tel"] = 0;
            datos.Rows.InsertAt(dr, 0);
            return datos;
        }
        public DataTable BuscarTelefonos()
        {
            query = string.Format("SELECT * FROM telefono");
            return EjecutarQuery(query);
        }

        public int AgregarTelefonos(estacionamientoBO obo)
        {
            query = string.Format("INSERT INTO  telefono (id,numero)VALUES ('{0}','{1}');", obo.idtel, obo.numero);
            return EjecutarSQL(query);
        }

        public int ModificarTelefonos(estacionamientoBO obo)
        {
            query = string.Format("UPDATE  telefono SET  numero='{1}' WHERE idtel={0}", obo.idtel, obo.numero);
            return EjecutarSQL(query);
        }

        public int BorrarTelefonos(estacionamientoBO obo)
        {
            query = string.Format("DELETE FROM telefono WHERE  idtel='{0}'", obo.idtel);
            return EjecutarSQL(query);
        }

        //Cajones
        public DataTable RecuperarCat_Cajon()
        {
            query = string.Format("SELECT * FROM tipoCajon");
            datos = EjecutarQuery(query);
            dr = datos.NewRow();
            dr["nombre"] = "Seleccionar";
            dr["id"] = 0;
            datos.Rows.InsertAt(dr, 0);
            return datos;
        }

        public DataTable Buscarcajones()
        {
            query = string.Format("SELECT * FROM cajones");
            return EjecutarQuery(query);
        }

        public int Agregarcajones(estacionamientoBO obo)

        {
            query = string.Format("INSERT INTO  cajones(id,estatus,idtipoCajon,idestacionamiento)VALUES ('{0}','{1}','{2}','{3});", obo.idcajon, obo.estatus, obo.idtipoCajon, obo.id);
            return EjecutarSQL(query);
        }

        public int Modificarcajones(estacionamientoBO obo)
        {
            query = string.Format("UPDATE  cajones SET estatus='{1}' idtipoCajon='{2}', idestacionamiento='{3}', WHERE idcajon={0}", obo.idcajon, obo.estatus, obo.idtipoCajon, obo.id);
            return EjecutarSQL(query);
        }

        public int Borrarcajones(estacionamientoBO obo)
        {
            query = string.Format("DELETE FROM cajones WHERE  id='{0}'", obo.id);
            return EjecutarSQL(query);
        }


        public int Agregar(estacionamientoBO obo)
        {
            query = string.Format("INSERT INTO  estacionamientoTelefono (idestacionamiento, idnumero)VALUES ('{0}','{1}');", obo.id, obo.idnumero);
            return EjecutarSQL(query);
        }

        public int Modificar(estacionamientoBO obo)
        {
            query = string.Format("UPDATE  estacionamientoTelefono SET idestacionamiento='{1}'  WHERE idnumero={0}", obo.id, obo.idnumero);
            return EjecutarSQL(query);
        }

        public int Borrar(estacionamientoBO obo)
        {
            query = string.Format("DELETE FROM estacionamientoTelefono WHERE  idnumero='{0}'", obo.idnumero);
            return EjecutarSQL(query);
        }
    }
}
