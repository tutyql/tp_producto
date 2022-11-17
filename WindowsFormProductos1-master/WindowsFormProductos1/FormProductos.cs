using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocios;

namespace WindowsFormProductos1
{
    public partial class FormProductos : Form
    {

        Producto NuevoProd;
        Producto ProdExistente;
        NegProductos ObjNegProducto = new NegProductos();
        bool nuevo = true;
        int fila;
        bool Nuevo;


        public FormProductos()
        {
            InitializeComponent();
            CrearDgv();
            //trae datos de la base de datos 
            LlenarDgv();
            chk_ingreso.Checked = true; 
        }


        private void CrearDgv()
        {
            dgv_productos.Columns.Add("0", "Código");
            dgv_productos.Columns.Add("1", "Descripción");
            dgv_productos.Columns.Add("2", "Stock");

            dgv_productos.Columns[0].Width = 100;
            dgv_productos.Columns[1].Width = 380;
            dgv_productos.Columns[2].Width = 60;
        }


        private void LlenarDgv()
        {
            dgv_productos.Rows.Clear();

            DataSet ds = new DataSet();
            ds = ObjNegProducto.listadoProductos("Todos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgv_productos.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString());
                }
            }
            else
                MessageBox.Show("No hay Productos cargados en el sistema");
        }


        private void bt_cargar_Click(object sender, EventArgs e)
        {
            // Producto NuevoProd;
            // NuevoProd = new Producto(int.Parse(txt_codigo.Text), txt_desc.Text);
            // lbl_codmov.Text = NuevoProd.p_codigo.ToString();
            // lbl_desmov.Text = NuevoProd.p_descripcion;
            // lbl_stockmov.Text = "Hay " + NuevoProd.p_stock.ToString() + " Unidades";
            // MessageBox.Show("Producto Instanciado");


            int nGrabados = -1;
            // Producto NuevoProd;
            // instanciamos utilizando el constructor con parametros
            NuevoProd = new Producto(int.Parse(txt_codigo.Text), txt_desc.Text);

            nGrabados = ObjNegProducto.abmProductos("Agregar", NuevoProd);

            if (nGrabados == -1)
            {
                MessageBox.Show("No se pudo grabar el Producto en el Sistema");

            }
            else
            {
                lbl_codmov.Text = NuevoProd.p_codigo.ToString();
                lbl_desmov.Text = NuevoProd.p_descripcion;
                lbl_stockmov.Text = NuevoProd.p_stock.ToString();

                txt_codigo.Clear();
                txt_desc.Clear();
                
                tabControl1.SelectedTab = tabMovimientos;
                txt_cant.Clear();
                txt_cant.Focus();

                //LLevarProdAldgv(NuevoProd);
                nuevo = true;
                LlenarDgv();

            }



        }


        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            //TxtBOX_a_Obj();

            if (nuevo == false)
            {
                if (chk_ingreso.Checked == true) // esta seleccionado el ingreso
                {
                    ProdExistente.Ingreso(int.Parse(txt_cant.Text));
                }
                if (chk_egreso.Checked == true)
                {
                    ProdExistente.Salida(int.Parse(txt_cant.Text));
                }

                int nResultado = -1;

                nResultado = ObjNegProducto.abmProductos("Modificar", ProdExistente);
                if (nResultado != -1)
                {
                    LlenarDgv();
                }
                else
                    MessageBox.Show("Error", "Se produjo un error al intentar modificar el Producto");
            }
            else
            {
                if (chk_ingreso.Checked == true)
                {
                    NuevoProd.Ingreso(int.Parse(txt_cant.Text));
                }
                if (chk_egreso.Checked == true)
                {
                    NuevoProd.Salida(int.Parse(txt_cant.Text));
                }

                int nResultado = -1;

                nResultado = ObjNegProducto.abmProductos("Modificar", NuevoProd);
                if (nResultado != -1)
                {
                    LlenarDgv();
                }
                else
                    MessageBox.Show("Error", "Se produjo un error al intentar modificar el Producto");
            }

                
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdExistente = new Producto(Convert.ToInt32(dgv_productos.CurrentRow.Cells[0].Value),
                dgv_productos.CurrentRow.Cells[1].Value.ToString(), Convert.ToInt32(dgv_productos.CurrentRow.Cells[2].Value));

            DataSet ds = new DataSet();
            nuevo = false;

            ds = ObjNegProducto.listadoProductos(ProdExistente.p_codigo.ToString()); //busco uno en particular
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_Controles(ds);
            }

        }


        //private void Ds_a_Controles(DataSet ds)
        //{
        //    lbl_codmov.Text = ds.Tables[0].Rows[0]["Codigo"].ToString();
        //    lbl_desmov.Text = ds.Tables[0].Rows[0]["Descripcion"].ToString();
        //    lbl_stockmov.Text = "Hay " + ds.Tables[0].Rows[0]["Stock"].ToString() + " unidades";
        //    txt_cant.Clear();
        //}
        private void Ds_a_Controles(DataSet ds)
        {
            lbl_codmov.Text = ProdExistente.p_codigo.ToString();
            lbl_desmov.Text = ProdExistente.p_descripcion;
            lbl_stockmov.Text = ProdExistente.p_stock.ToString();
            txt_cant.Clear();
        }



    }

}
