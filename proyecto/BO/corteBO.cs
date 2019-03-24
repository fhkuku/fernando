using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BO
{
    class corteBO
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int iduser { get; set; }
        public decimal monto { get; set; }
        public int idcobro { get; set; }
        public int idgasto { get; set; } // no esta en la base de datos
    }
}
