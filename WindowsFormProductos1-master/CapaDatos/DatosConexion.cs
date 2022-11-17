using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace CapaDatos
{
    public class DatosConexion
    {
        protected OleDbConnection conexion;
        protected string cadenaConexion= "@Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Euge\Desktop\tp_producto\WindowsFormProductos1-master\Productos1.mdb"

        public DatosConexion()
        {
            conexion = new OleDbConnection(cadenaConexion);

        }

        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State == ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }
        
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }

    }

}
