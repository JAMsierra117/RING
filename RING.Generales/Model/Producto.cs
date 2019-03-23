using System;
using System.Collections.Generic;
using System.Text;

namespace RING.Generales.Model
{
    public class Producto
    {
        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Clasificacion { get; set; }
        public Clasificacion Clasificacion { get; set; }
    }
}
