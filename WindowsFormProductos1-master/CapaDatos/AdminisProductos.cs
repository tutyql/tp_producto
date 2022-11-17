using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Entidades;

namespace CapaDatos
{
    public class AdminisProductos : DatosConexion
    {
        public int abmProductos(string accion, Producto objProducto)
        {
            int resultado = -1;  //controlar que se realice la opreacion con exito
            string orden = string.Empty; //para guardar consulta sql

            if (accion == "Agregar") //para agreagar un producto nuevo
                orden = "insert into Productos values (" + objProducto.p_codigo + ",'" + objProducto.p_descripcion + "', "+ objProducto.p_stock + ");";

            if (accion == "Modificar") //para modificar un existente
                orden = "update Productos set Descripcion='" + objProducto.p_descripcion + "', Stock=" + objProducto.p_stock + " where Codigo = " + objProducto.p_codigo + "; ";
            
            // falta la orden de borrar

            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Productos",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoProductos(string cual) //para 1 o todos los datos segun el código
        {
            string orden = string.Empty;

            if (cual != "Todos")
                orden = "select * from Productos where Codigo = " + int.Parse(cual) + ";";
            else
                orden = "select * from Productos;";
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            DataSet ds = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar productos", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;

        }

    }

}

   

