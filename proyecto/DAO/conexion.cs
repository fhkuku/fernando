using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.DAO
{
    class conexion
    {
        MySqlConnection con;
        MySqlCommand cmd = new MySqlCommand();

        public MySqlConnection EstablecerConexion()
        {
            string cadena = "Server=192.168.0.46; Database=estacionamientobd; uid=fernando; pwd=123"; 
            con = new MySqlConnection(cadena);
            return con;
        }

        protected void AbrirBD()
        {
            con.Open();
        }

        protected void CerrarBD() 
        {
            con.Close();
        }

        protected int EjecutarSQL(string instruccion) 
        {

            cmd.Connection = EstablecerConexion(); 
            AbrirBD(); 
            cmd.CommandText = instruccion;
            int acuse = cmd.ExecuteNonQuery();
            CerrarBD(); 

            if (acuse <= 0)
            {
                return 0;
            }
            return 1;
        }

        protected DataTable EjecutarQuery(string ConsultarSQL)
        {
            MySqlDataAdapter Tabla_BD = new MySqlDataAdapter(ConsultarSQL, EstablecerConexion());
            DataTable Tabla_Virtual = new DataTable();
            Tabla_BD.Fill(Tabla_Virtual);
            return Tabla_Virtual;
        }

        

    }
}
