using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BO
{
    class gastoBO
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int iduser { get; set; }
        public decimal monto { get; set; }
        //Tarifa
        public int idtipoGasto { get; set; }
        public string nom { get; set; }
        

    }
}
