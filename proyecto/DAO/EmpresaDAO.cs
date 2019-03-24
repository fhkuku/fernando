using proyecto.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace proyecto.DAO
{
    class empresaDAO:conexion
    {
        string query;
        DataTable Datos;
        public DataTable ValidarEmpresa()
        {
            query = string.Format("select * from empresa");
            Datos = EjecutarQuery(query);
            return Datos;
        }


        public int AgregarEmpresa(EmpresaBO objet)
        {
            query = string.Format("insert into empresa (nombre, direccion, telefono) values ('{0}','{1}','{2}')", objet.nombre, objet.direccion, objet.telefono);//EDITAR
            return EjecutarSQL(query);
        }

        public int ModificarEmpresa(EmpresaBO objet)
        {
            query = string.Format("update empresa set nombre='{0}',direccion='{1}', telefono='{2}' where id='{3}'",objet.nombre, objet.direccion, objet.telefono, objet.id);//EDITAR
            return EjecutarSQL(query);
        }


        public DataTable CountCajones()
        {
            query = string.Format("select Count(id) as cajones from cajones");
            Datos = EjecutarQuery(query);
            return Datos;
        }

        public DataTable MaximoEmpresa()
        {
            query = string.Format("select MAX(id) as id from empresa");
            Datos = EjecutarQuery(query);
            return Datos;
        }

        public DataTable EmpresaDatos()
        {
            query = string.Format("select * from empresa");
            Datos = EjecutarQuery(query);
            return Datos;
        }






    }
}
