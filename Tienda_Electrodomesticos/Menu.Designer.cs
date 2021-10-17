namespace Tienda_Electrodomesticos
{
    partial class Menu
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
            this.btnIngresoC = new System.Windows.Forms.Button();
            this.btnIngresoP = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btnIngresoC
            // 
            this.btnIngresoC.Location = new System.Drawing.Point(56, 37);
            this.btnIngresoC.Name = "btnIngresoC";
            this.btnIngresoC.Size = new System.Drawing.Size(176, 23);
            this.btnIngresoC.TabIndex = 0;
            this.btnIngresoC.Text = "Ingreso de Clientes";
            this.btnIngresoC.UseVisualStyleBackColor = true;
            this.btnIngresoC.Click += new System.EventHandler(this.btnIngresoC_Click);
            // 
            // btnIngresoP
            // 
            this.btnIngresoP.Location = new System.Drawing.Point(56, 86);
            this.btnIngresoP.Name = "btnIngresoP";
            this.btnIngresoP.Size = new System.Drawing.Size(176, 23);
            this.btnIngresoP.TabIndex = 1;
            this.btnIngresoP.Text = "Ingreso de Prodcutos";
            this.btnIngresoP.UseVisualStyleBackColor = true;
            this.btnIngresoP.Click += new System.EventHandler(this.btnIngresoP_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(56, 135);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(176, 23);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btnSalir.Location = new System.Drawing.Point(56, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(176, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 219);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(290, 257);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnIngresoP);
            this.Controls.Add(this.btnIngresoC);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresoC;
        private System.Windows.Forms.Button btnIngresoP;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}