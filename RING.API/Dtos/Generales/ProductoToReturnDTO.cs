using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RING.API.Dtos.Generales
{
    public class ProductoToReturnDTO
    {
        public int ID_Producto { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int ID_Clasificacion { get; set; }
        public string Clasificacion { get; set; }
    }
}
