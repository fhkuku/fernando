using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto.BO
{
    class registroBO
    {
        public int id { get; set; }
        public DateTime horaEntrada { get; set; }
        public DateTime horaSalida { get; set; }
        public string matricula { get; set; }
        public int idcajon { get; set; }
        //Tarifa
        public int idtarifa { get; set; }       
        public string nombre { get; set; }
        public decimal precio { get; set; }


    }
}
