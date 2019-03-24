using proyecto.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.DAO
{
    class usuarioDAO:conexion 
    {

        string query; DataTable datos;
        public DataTable BuscarTipoUsuario()
        {
            query = string.Format("SELECT * FROM tipoUsuario");
            return EjecutarQuery(query);
        }

        public int AgregaTipoUsuario(usuarioBO objeus)
        {
            query = string.Format("insert into tipoUsuario (nombre)values ('{0}')", objeus.tipo);
            return EjecutarSQL(query);
        }

        public int ModificarTipoUsuario(usuarioBO objeus)
        {
            query = string.Format("UPDATE  tipoUsuario set nombre='{0}' where id ={1}", objeus.tipo, objeus.id);
            return EjecutarSQL(query);
        }

        public int BorrarTipoUsuario(usuarioBO objeus)
        {
            query = string.Format("DELETE FROM tipoUsuario WHERE  id={0}", objeus.id);
            return EjecutarSQL(query);
        }

        public DataTable ValidarTipoUsuario(usuarioBO objeus)
        {
            query = string.Format("SELECT * FROM tipoUsuario where nombre='{0}'",objeus.tipo);
            return EjecutarQuery(query);
        }

    }
}
