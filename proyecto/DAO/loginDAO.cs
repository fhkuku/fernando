using proyecto.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.DAO
{
    class loginDAO:conexion
    {
        string query;
        DataTable tabla;

        public DataTable Login(usuarioBO objeus)
        {
            query = string.Format("SELECT id, nombre, apellidos, telefono, sueldo, direccion, turno, idtipo, email FROM usuario  where email='{0}' and pass='{1}'",  objeus.email, objeus.pass);
            tabla = EjecutarQuery(query);
            return tabla;
        }
        public DataTable Buscarusuario()
        {
            query = string.Format("SELECT * FROM usuario");
            return EjecutarQuery(query);
        }

        public int Agregarusuario(usuarioBO obo) 
        {
            query = string.Format("INSERT INTO  usuario(id,nombre, apellidos, telefono, sueldo, direccion, turno, idtipo, email, pass)VALUES ('{0}','{1}','{2}','{3}''{4}','{5}','{6}','{7}''{8}','{9}');", obo.id, obo.nombre, obo.apellidos, obo.telefono, obo.sueldo, obo.direccion, obo.turno, obo.idtipo, obo.email, obo.pass);
            return EjecutarSQL(query);
        }

        public int Modificarusuario(usuarioBO obo)
        {
            query = string.Format("UPDATE  usuario SET nombre='{1}', apellidos='{2}', telefono='{4}', sueldo='{1}', direccion='{2}', turno='{4}', idtipo='{1}', email='{2}', pass='{4}' WHERE id={0}", obo.id, obo.nombre, obo.apellidos, obo.telefono, obo.sueldo, obo.direccion, obo.turno, obo.idtipo, obo.email, obo.pass);
            return EjecutarSQL(query);
        }

        public int Borrarusuario(usuarioBO obo)
        {
            query = string.Format("DELETE FROM usuario WHERE  id={0}", obo.id);
            return EjecutarSQL(query);
        }
    }
}
