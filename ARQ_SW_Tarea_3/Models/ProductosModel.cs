using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARQ_SW_Tarea_3.Models
{
    class ProductosModel
    {
        public int Id_producto { get; set; }
        public string Id_Producto { get; internal set; }
        public string Producto { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
    }
}
