namespace Tienda_Electrodomesticos
{
    partial class Ventas
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.bntPagar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.Informacion = new System.Windows.Forms.GroupBox();
            this.rtxtInfoCliente = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCodigoC = new System.Windows.Forms.RadioButton();
            this.rbtnApellido = new System.Windows.Forms.RadioButton();
            this.rbtnNombre = new System.Windows.Forms.RadioButton();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbtnContado = new System.Windows.Forms.RadioButton();
            this.rbCredito = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.txtCantidaComprar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtxtInfoProducto = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnModelo = new System.Windows.Forms.RadioButton();
            this.rbtnMarca = new System.Windows.Forms.RadioButton();
            this.rbtnProducto = new System.Windows.Forms.RadioButton();
            this.txtPP = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.Informacion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Black;
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(17, 655);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(46, 23);
            this.btnRegresar.TabIndex = 31;
            this.btnRegresar.Text = "<---";
            this.btnRegresar.UseVisualStyleBackColor = false;
            // 
            // bntPagar
            // 
            this.bntPagar.BackColor = System.Drawing.Color.Black;
            this.bntPagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntPagar.Location = new System.Drawing.Point(749, 655);
            this.bntPagar.Margin = new System.Windows.Forms.Padding(0);
            this.bntPagar.Name = "bntPagar";
            this.bntPagar.Size = new System.Drawing.Size(75, 23);
            this.bntPagar.TabIndex = 30;
            this.bntPagar.Text = "Pagar ";
            this.bntPagar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiarCliente);
            this.groupBox2.Controls.Add(this.dgvCliente);
            this.groupBox2.Controls.Add(this.Informacion);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(17, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(807, 303);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(21, 260);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarCliente.TabIndex = 14;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(326, 25);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(459, 234);
            this.dgvCliente.TabIndex = 16;
            // 
            // Informacion
            // 
            this.Informacion.Controls.Add(this.rtxtInfoCliente);
            this.Informacion.Location = new System.Drawing.Point(21, 118);
            this.Informacion.Name = "Informacion";
            this.Informacion.Size = new System.Drawing.Size(283, 141);
            this.Informacion.TabIndex = 13;
            this.Informacion.TabStop = false;
            this.Informacion.Text = "Infromacion";
            // 
            // rtxtInfoCliente
            // 
            this.rtxtInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfoCliente.Location = new System.Drawing.Point(18, 23);
            this.rtxtInfoCliente.Name = "rtxtInfoCliente";
            this.rtxtInfoCliente.Size = new System.Drawing.Size(247, 100);
            this.rtxtInfoCliente.TabIndex = 12;
            this.rtxtInfoCliente.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.rbtnCodigoC);
            this.groupBox3.Controls.Add(this.rbtnApellido);
            this.groupBox3.Controls.Add(this.rbtnNombre);
            this.groupBox3.Controls.Add(this.txtPC);
            this.groupBox3.Location = new System.Drawing.Point(21, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 99);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqua de Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese el parametro de Busqueda";
            // 
            // rbtnCodigoC
            // 
            this.rbtnCodigoC.AutoSize = true;
            this.rbtnCodigoC.Location = new System.Drawing.Point(21, 23);
            this.rbtnCodigoC.Name = "rbtnCodigoC";
            this.rbtnCodigoC.Size = new System.Drawing.Size(64, 19);
            this.rbtnCodigoC.TabIndex = 18;
            this.rbtnCodigoC.TabStop = true;
            this.rbtnCodigoC.Text = "Codigo";
            this.rbtnCodigoC.UseVisualStyleBackColor = true;
            // 
            // rbtnApellido
            // 
            this.rbtnApellido.AutoSize = true;
            this.rbtnApellido.Location = new System.Drawing.Point(198, 23);
            this.rbtnApellido.Name = "rbtnApellido";
            this.rbtnApellido.Size = new System.Drawing.Size(69, 19);
            this.rbtnApellido.TabIndex = 17;
            this.rbtnApellido.TabStop = true;
            this.rbtnApellido.Text = "Apellido";
            this.rbtnApellido.UseVisualStyleBackColor = true;
            // 
            // rbtnNombre
            // 
            this.rbtnNombre.AutoSize = true;
            this.rbtnNombre.Location = new System.Drawing.Point(107, 23);
            this.rbtnNombre.Name = "rbtnNombre";
            this.rbtnNombre.Size = new System.Drawing.Size(70, 19);
            this.rbtnNombre.TabIndex = 16;
            this.rbtnNombre.TabStop = true;
            this.rbtnNombre.Text = "Nombre";
            this.rbtnNombre.UseVisualStyleBackColor = true;
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(21, 65);
            this.txtPC.Name = "txtPC";
            this.txtPC.Size = new System.Drawing.Size(244, 21);
            this.txtPC.TabIndex = 15;
            this.txtPC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtPC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPC_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.dgvProductos);
            this.groupBox1.Location = new System.Drawing.Point(17, 355);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 284);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos a Comprar";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Controls.Add(this.richTextBox1);
            this.groupBox6.Location = new System.Drawing.Point(525, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(276, 247);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Carrito";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.rbtnContado);
            this.groupBox7.Controls.Add(this.rbCredito);
            this.groupBox7.Location = new System.Drawing.Point(9, 141);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 100);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Forma Pago";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contado: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 2;
            // 
            // rbtnContado
            // 
            this.rbtnContado.AutoSize = true;
            this.rbtnContado.Location = new System.Drawing.Point(141, 22);
            this.rbtnContado.Name = "rbtnContado";
            this.rbtnContado.Size = new System.Drawing.Size(65, 17);
            this.rbtnContado.TabIndex = 1;
            this.rbtnContado.TabStop = true;
            this.rbtnContado.Text = "Contado";
            this.rbtnContado.UseVisualStyleBackColor = true;
            // 
            // rbCredito
            // 
            this.rbCredito.AutoSize = true;
            this.rbCredito.Location = new System.Drawing.Point(27, 22);
            this.rbCredito.Name = "rbCredito";
            this.rbCredito.Size = new System.Drawing.Size(58, 17);
            this.rbCredito.TabIndex = 0;
            this.rbCredito.TabStop = true;
            this.rbCredito.Text = "Credito";
            this.rbCredito.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 116);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAniadir);
            this.groupBox5.Controls.Add(this.txtCantidaComprar);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.rtxtInfoProducto);
            this.groupBox5.Location = new System.Drawing.Point(316, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 247);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Producto Seleccionado";
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(9, 211);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(184, 23);
            this.btnAniadir.TabIndex = 16;
            this.btnAniadir.Text = "Añadir al Carrito→";
            this.btnAniadir.UseVisualStyleBackColor = true;
            // 
            // txtCantidaComprar
            // 
            this.txtCantidaComprar.Location = new System.Drawing.Point(9, 180);
            this.txtCantidaComprar.Name = "txtCantidaComprar";
            this.txtCantidaComprar.Size = new System.Drawing.Size(184, 20);
            this.txtCantidaComprar.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantida de Producto";
            // 
            // rtxtInfoProducto
            // 
            this.rtxtInfoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtInfoProducto.Location = new System.Drawing.Point(10, 19);
            this.rtxtInfoProducto.Name = "rtxtInfoProducto";
            this.rtxtInfoProducto.Size = new System.Drawing.Size(184, 141);
            this.rtxtInfoProducto.TabIndex = 13;
            this.rtxtInfoProducto.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.rbtnModelo);
            this.groupBox4.Controls.Add(this.rbtnMarca);
            this.groupBox4.Controls.Add(this.rbtnProducto);
            this.groupBox4.Controls.Add(this.txtPP);
            this.groupBox4.Location = new System.Drawing.Point(17, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(283, 99);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto de Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ingrese el parametro de Busqueda";
            // 
            // rbtnModelo
            // 
            this.rbtnModelo.AutoSize = true;
            this.rbtnModelo.Location = new System.Drawing.Point(198, 20);
            this.rbtnModelo.Name = "rbtnModelo";
            this.rbtnModelo.Size = new System.Drawing.Size(60, 17);
            this.rbtnModelo.TabIndex = 18;
            this.rbtnModelo.TabStop = true;
            this.rbtnModelo.Text = "Modelo";
            this.rbtnModelo.UseVisualStyleBackColor = true;
            this.rbtnModelo.CheckedChanged += new System.EventHandler(this.rbnCodigoP_CheckedChanged);
            // 
            // rbtnMarca
            // 
            this.rbtnMarca.AutoSize = true;
            this.rbtnMarca.Location = new System.Drawing.Point(122, 20);
            this.rbtnMarca.Name = "rbtnMarca";
            this.rbtnMarca.Size = new System.Drawing.Size(55, 17);
            this.rbtnMarca.TabIndex = 17;
            this.rbtnMarca.TabStop = true;
            this.rbtnMarca.Text = "Marca";
            this.rbtnMarca.UseVisualStyleBackColor = true;
            this.rbtnMarca.CheckedChanged += new System.EventHandler(this.rbtnMarca_CheckedChanged);
            // 
            // rbtnProducto
            // 
            this.rbtnProducto.AutoSize = true;
            this.rbtnProducto.Location = new System.Drawing.Point(31, 20);
            this.rbtnProducto.Name = "rbtnProducto";
            this.rbtnProducto.Size = new System.Drawing.Size(68, 17);
            this.rbtnProducto.TabIndex = 16;
            this.rbtnProducto.TabStop = true;
            this.rbtnProducto.Text = "Producto";
            this.rbtnProducto.UseVisualStyleBackColor = true;
            this.rbtnProducto.CheckedChanged += new System.EventHandler(this.rbtnProducto_CheckedChanged);
            // 
            // txtPP
            // 
            this.txtPP.Location = new System.Drawing.Point(21, 65);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(244, 20);
            this.txtPP.TabIndex = 15;
            this.txtPP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPP_KeyUp);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(17, 124);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(283, 142);
            this.dgvProductos.TabIndex = 18;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bntPagar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Name = "Ventas";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.Informacion.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button bntPagar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.GroupBox Informacion;
        private System.Windows.Forms.RichTextBox rtxtInfoCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCodigoC;
        private System.Windows.Forms.RadioButton rbtnApellido;
        private System.Windows.Forms.RadioButton rbtnNombre;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnModelo;
        private System.Windows.Forms.RadioButton rbtnMarca;
        private System.Windows.Forms.RadioButton rbtnProducto;
        private System.Windows.Forms.TextBox txtPP;
        private System.Windows.Forms.RichTextBox rtxtInfoProducto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rbCredito;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.TextBox txtCantidaComprar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtnContado;
    }
}