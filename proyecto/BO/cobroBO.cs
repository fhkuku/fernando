using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BO
{
    class cobroBO
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int iduser { get; set; }
        public decimal monto { get; set; }
        //Tipo de cobro
        public int idtipoCobro { get; set; }
      

    }
}
