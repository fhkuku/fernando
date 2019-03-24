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









    }
}
