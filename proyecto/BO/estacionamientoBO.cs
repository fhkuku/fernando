using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BO
{
    class estacionamientoBO
    {
        public int id { get; set; }
        public int idempresa { get; set; }
        public string rfc { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        // cajones
        public int idcajon { get; set; }
        public bool estatus { get; set; }
        public int idtipoCajon { get; set; }
        //Telefono
        public int idtel { get; set; }
        public string numero { get; set; }
        public int idnumero { get; set; }
    }
}
