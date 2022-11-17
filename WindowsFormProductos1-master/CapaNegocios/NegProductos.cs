using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using Entidades;

namespace CapaNegocios
{
    public class NegProductos
    {
        AdminisProductos DatosObjProducto = new AdminisProductos();

        public int abmProductos(string accion, Producto objProducto)
        {
            return DatosObjProducto.abmProductos(accion, objProducto);

        }

        public DataSet listadoProductos(string cual)
        {
            return DatosObjProducto.listadoProductos(cual);
        }


    }

}
