using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BO
{
    class contratoBO
    {
        public int id { get; set; }
        public decimal monto { get; set; }
        public string fechaInicio { get; set; }
        public string fechaFin { get; set; }
        public int iduser { get; set; }
        // cliente
        public int idcliente { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        // cajon.contrato
        public int idcontcajo { get; set; }
        public int idcajon { get; set; }
    }
}
