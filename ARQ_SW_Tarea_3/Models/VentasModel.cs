using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Models
{
    class VentasModel
    {
        public int Id_Venta { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Producto { get; set; }
        public DateTime FechaVenta { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; }
    }
}
