
namespace WindowsFormProductos1
{
    partial class FormProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCarga = new System.Windows.Forms.TabPage();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.bt_cargar = new System.Windows.Forms.Button();
            this.tabMovimientos = new System.Windows.Forms.TabPage();
            this.lbl_stockmov = new System.Windows.Forms.Label();
            this.chk_egreso = new System.Windows.Forms.CheckBox();
            this.chk_ingreso = new System.Windows.Forms.CheckBox();
            this.bt_aceptar = new System.Windows.Forms.Button();
            this.txt_cant = new System.Windows.Forms.TextBox();
            this.lbl_cant = new System.Windows.Forms.Label();
            this.lbl_desmov = new System.Windows.Forms.Label();
            this.lbl_codmov = new System.Windows.Forms.Label();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabCarga.SuspendLayout();
            this.tabMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCarga);
            this.tabControl1.Controls.Add(this.tabMovimientos);
            this.tabControl1.Location = new System.Drawing.Point(38, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 212);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.Tag = "";
            // 
            // tabCarga
            // 
            this.tabCarga.Controls.Add(this.txt_codigo);
            this.tabCarga.Controls.Add(this.lbl_codigo);
            this.tabCarga.Controls.Add(this.txt_stock);
            this.tabCarga.Controls.Add(this.lbl_desc);
            this.tabCarga.Controls.Add(this.txt_desc);
            this.tabCarga.Controls.Add(this.lbl_stock);
            this.tabCarga.Controls.Add(this.bt_cargar);
            this.tabCarga.Location = new System.Drawing.Point(4, 22);
            this.tabCarga.Name = "tabCarga";
            this.tabCarga.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarga.Size = new System.Drawing.Size(710, 186);
            this.tabCarga.TabIndex = 0;
            this.tabCarga.Text = "Carga de Productos";
            this.tabCarga.UseVisualStyleBackColor = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(151, 46);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(170, 20);
            this.txt_codigo.TabIndex = 8;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(39, 49);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(43, 13);
            this.lbl_codigo.TabIndex = 7;
            this.lbl_codigo.Text = "Código:";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(151, 142);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(170, 20);
            this.txt_stock.TabIndex = 6;
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(40, 99);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(66, 13);
            this.lbl_desc.TabIndex = 1;
            this.lbl_desc.Text = "Descripción:";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(151, 96);
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(170, 20);
            this.txt_desc.TabIndex = 5;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(40, 145);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_stock.TabIndex = 2;
            this.lbl_stock.Text = "Stock:";
            // 
            // bt_cargar
            // 
            this.bt_cargar.Location = new System.Drawing.Point(492, 157);
            this.bt_cargar.Name = "bt_cargar";
            this.bt_cargar.Size = new System.Drawing.Size(75, 23);
            this.bt_cargar.TabIndex = 3;
            this.bt_cargar.Text = "Cargar";
            this.bt_cargar.UseVisualStyleBackColor = true;
            this.bt_cargar.Click += new System.EventHandler(this.bt_cargar_Click);
            // 
            // tabMovimientos
            // 
            this.tabMovimientos.Controls.Add(this.lbl_stockmov);
            this.tabMovimientos.Controls.Add(this.chk_egreso);
            this.tabMovimientos.Controls.Add(this.chk_ingreso);
            this.tabMovimientos.Controls.Add(this.bt_aceptar);
            this.tabMovimientos.Controls.Add(this.txt_cant);
            this.tabMovimientos.Controls.Add(this.lbl_cant);
            this.tabMovimientos.Controls.Add(this.lbl_desmov);
            this.tabMovimientos.Controls.Add(this.lbl_codmov);
            this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
            this.tabMovimientos.Name = "tabMovimientos";
            this.tabMovimientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovimientos.Size = new System.Drawing.Size(710, 186);
            this.tabMovimientos.TabIndex = 1;
            this.tabMovimientos.Text = "Movimientos de Productos";
            this.tabMovimientos.UseVisualStyleBackColor = true;
            // 
            // lbl_stockmov
            // 
            this.lbl_stockmov.AutoSize = true;
            this.lbl_stockmov.Location = new System.Drawing.Point(28, 87);
            this.lbl_stockmov.Name = "lbl_stockmov";
            this.lbl_stockmov.Size = new System.Drawing.Size(70, 13);
            this.lbl_stockmov.TabIndex = 7;
            this.lbl_stockmov.Text = "muestrastock";
            // 
            // chk_egreso
            // 
            this.chk_egreso.AutoSize = true;
            this.chk_egreso.Location = new System.Drawing.Point(352, 137);
            this.chk_egreso.Name = "chk_egreso";
            this.chk_egreso.Size = new System.Drawing.Size(59, 17);
            this.chk_egreso.TabIndex = 6;
            this.chk_egreso.Text = "Egreso";
            this.chk_egreso.UseVisualStyleBackColor = true;
            // 
            // chk_ingreso
            // 
            this.chk_ingreso.AutoSize = true;
            this.chk_ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_ingreso.Location = new System.Drawing.Point(352, 114);
            this.chk_ingreso.Name = "chk_ingreso";
            this.chk_ingreso.Size = new System.Drawing.Size(61, 17);
            this.chk_ingreso.TabIndex = 5;
            this.chk_ingreso.Text = "Ingreso";
            this.chk_ingreso.UseVisualStyleBackColor = true;
            // 
            // bt_aceptar
            // 
            this.bt_aceptar.Location = new System.Drawing.Point(458, 114);
            this.bt_aceptar.Name = "bt_aceptar";
            this.bt_aceptar.Size = new System.Drawing.Size(74, 38);
            this.bt_aceptar.TabIndex = 4;
            this.bt_aceptar.Text = "Aceptar";
            this.bt_aceptar.UseVisualStyleBackColor = true;
            this.bt_aceptar.Click += new System.EventHandler(this.bt_aceptar_Click);
            // 
            // txt_cant
            // 
            this.txt_cant.Location = new System.Drawing.Point(106, 130);
            this.txt_cant.Name = "txt_cant";
            this.txt_cant.Size = new System.Drawing.Size(92, 20);
            this.txt_cant.TabIndex = 3;
            // 
            // lbl_cant
            // 
            this.lbl_cant.AutoSize = true;
            this.lbl_cant.Location = new System.Drawing.Point(28, 133);
            this.lbl_cant.Name = "lbl_cant";
            this.lbl_cant.Size = new System.Drawing.Size(52, 13);
            this.lbl_cant.TabIndex = 2;
            this.lbl_cant.Text = "Cantidad:";
            // 
            // lbl_desmov
            // 
            this.lbl_desmov.AutoSize = true;
            this.lbl_desmov.Location = new System.Drawing.Point(28, 60);
            this.lbl_desmov.Name = "lbl_desmov";
            this.lbl_desmov.Size = new System.Drawing.Size(78, 13);
            this.lbl_desmov.TabIndex = 1;
            this.lbl_desmov.Text = "muestradescrip";
            // 
            // lbl_codmov
            // 
            this.lbl_codmov.AutoSize = true;
            this.lbl_codmov.Location = new System.Drawing.Point(28, 31);
            this.lbl_codmov.Name = "lbl_codmov";
            this.lbl_codmov.Size = new System.Drawing.Size(76, 13);
            this.lbl_codmov.TabIndex = 0;
            this.lbl_codmov.Text = "muestracodigo";
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Location = new System.Drawing.Point(42, 233);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.Size = new System.Drawing.Size(710, 170);
            this.dgv_productos.TabIndex = 8;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellClick);
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProductos";
            this.Text = "FormProductos";
            this.tabControl1.ResumeLayout(false);
            this.tabCarga.ResumeLayout(false);
            this.tabCarga.PerformLayout();
            this.tabMovimientos.ResumeLayout(false);
            this.tabMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCarga;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Button bt_cargar;
        private System.Windows.Forms.TabPage tabMovimientos;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button bt_aceptar;
        private System.Windows.Forms.TextBox txt_cant;
        private System.Windows.Forms.Label lbl_cant;
        private System.Windows.Forms.Label lbl_desmov;
        private System.Windows.Forms.Label lbl_codmov;
        private System.Windows.Forms.Label lbl_stockmov;
        private System.Windows.Forms.CheckBox chk_egreso;
        private System.Windows.Forms.CheckBox chk_ingreso;
        private System.Windows.Forms.DataGridView dgv_productos;
    }
}