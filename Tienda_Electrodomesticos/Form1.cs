using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Expresiones regulares
using System.Text.RegularExpressions;

namespace Tienda_Electrodomesticos
{
    public partial class Form1 : Form
    {
        ///matriz de productos y marcas de los electrofomesticos.vs
        string[,] Productos = new string[4,5]{ { "Licuadoras" ,"Cafeteras" ,"Hornos Eléctricos","Aspiradoras","Planchas"},
                                             {"Ninja","Keurig","Sindelen","Philips","Rowenta" },
                                             { "Oster","Black and Decker ","Thomas","Dyson","Aigostar " },
                                             { "Hamilton Beach","Bialetti","Daewoo"," Xiaomi","Oster" }};
        ///Contador de Codigo
        int cont=1;
        ///Validador de errores 
        bool ok = true;
        public Form1()
        {
            InitializeComponent();
            ///TextBox Codigo no sea editable 
            txtCodigo.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Asignando Valores al combobox Productos
            cbxProductos.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                cbxProductos.Items.Add(Productos[0,i]);
            }
            
        }

        private void cbxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(cbxProductos, "");
            //Limpiar combobox Marcas
            cbxMarca.Text = "";
            ///Si el codigo ha sido generado se limpia
            txtCodigo.Clear();
            cbxMarca.Items.Clear();
            //Asignando Valores al combobox Marcas segun el tipo de producto
            for (int i = 0; i < 5; i++)
            {
                if (cbxProductos.Text == Productos[0, i])
                {
                    for (int j = 0; j < 3; j++)
                    {
                        cbxMarca.Items.Add(Productos[j + 1, i]);
                    }
                }
            }
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ///Verificacion de los parametros necesarios para generar el codigo 
            if (cbxProductos.Text == "")
            {
                MessageBox.Show("Para generar el codigo debe seleccionar el tipo Producto");
                cbxProductos.Focus();
            }
            else {
                if (cbxMarca.Text == "") {
                    MessageBox.Show("Seleccione la marca del producto");
                    cbxMarca.Focus();
                }
                else
                {
                    txtCodigo.Text = GenerarCodigo();
                }
            }   
        }

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            //Si intenta seleccionar el textbox del codigo se le enviara un mensaje
            MessageBox.Show("El codigo de producto se genera automaticamente.\nClick sobre el boton Generar");
        }
        ///Funciona para generar el codigo del producto
        public string GenerarCodigo()
        {
            ///Varible que almacena el codigo 
            string codigo;
            //Generador de codigos 
            string Texto1 = cbxProductos.Text;
            string Texto2 = cbxMarca.Text;
            //Usando expresiones regulares obtendremos Dos incioales
            Match Letra1 = Regex.Match(Texto1, @"\w");
            Match Letra2 = Regex.Match(Texto2, @"\w");
            if (cont <= 9){ codigo = Letra1.Value + Letra2.Value + "-00" + cont.ToString(); }
            else
            {
                if (cont <= 99) { codigo = Letra1.Value + Letra2.Value + "-0" + cont.ToString(); }
                else { codigo = Letra1.Value + Letra2.Value + "-" + cont.ToString(); }
            }
            return codigo;
        }
        //Funcion para validar campos 
        private bool ValidarCampos()
        {
            //Cambos nulos
            if (txtModelo.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(txtModelo, "Ingrese el modelo");
            }
            if (cbxProductos.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(cbxProductos, "Seleccione el tipo de producto");
            }
            if (cbxMarca.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(cbxMarca, "Seleccione la marca");
            }
            if (txtCodigo.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(txtCodigo, "Genere el codigo");
            }
            if (txtCosto.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(txtCosto, "Ingrese el costo del Producto");
            }
            if (txtPrecio.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(txtPrecio, "Ingrese el precio del Producto");
            }
            if (txtCantidad.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(txtCantidad, "Ingrese La cantidad de Producto");
            }
            if (rtxtDetalles.Text == "")
            {
                ok = false;
                errorProviderProductos.SetError(rtxtDetalles, "Ingrese los Detalles del producto");
            }
            //validacion de fecha 
            string fecha = dtpFecha.Value.ToString("dd/MM/yyyy"); ;
            string hoy = DateTime.Now.ToString("dd/MM/yyyy");
            if (!(fecha == hoy))
            {
                ok = false;
                errorProviderProductos.SetError(dtpFecha, "La fecha debe ser la del dia de hoy");
            } 
            return ok;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            if (ValidarCampos()==true || ok==true )
            {
                MessageBox.Show("Producto Registrado con exito");
                cont++;
                limpiar();
            }
        }
        
        ///Correccion de Errores
        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(cbxMarca, "");
            ok = true;
        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(txtModelo, "");
            ok = true;
        }

        private void rtxtDetalles_TextChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(rtxtDetalles, "");
            ok = true;
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(txtCosto, "");
            ok = true;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(txtPrecio, "");
            ok = true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(txtCantidad, "");
            ok = true;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(txtCodigo, "");
            ok = true;
        }
        private void dtpFecha_TabIndexChanged(object sender, EventArgs e)
        {   
            ///Si tiene error, se corrige
            errorProviderProductos.SetError(dtpFecha, "");
            ok = true;
        }

        ///EVENTOS VALIDATING 
        private void txtCosto_Validating(object sender, CancelEventArgs e)
        {
            double costo;
            if (!double.TryParse(txtCosto.Text, out costo))
            {
                ok = false;
                errorProviderProductos.SetError(txtCosto, "Ingrese datos numericos");
            }
            else {
                ok = true;
            }
        }

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            double precio;
            if (!double.TryParse(txtCosto.Text, out precio))
            {
                ok = false;
                errorProviderProductos.SetError(txtPrecio, "Ingrese datos numericos");
            }
            else
            {
                ok = true;
            }
        }

        private void txtCantidad_Validating(object sender, CancelEventArgs e)
        {
            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                ok = false;
                errorProviderProductos.SetError(txtCantidad, "Ingrese datos numericos");
            }
            else
            {
                ok = true;
            }
        }
        private void dtpFecha_Validating(object sender, CancelEventArgs e)
        {
            string fecha = dtpFecha.Value.ToString("dd/MM/yyyy"); ;
            string hoy = DateTime.Now.ToString("dd/MM/yyyy");
            if (!(fecha == hoy))
            {
                ok = false;
                errorProviderProductos.SetError(dtpFecha, "La fecha debe ser la del dia de hoy");
            }
            else
            {
                ok = true;
                errorProviderProductos.SetError(dtpFecha, "");
            }
        }

        ///EVENTOS VALIDATED
        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            try
            {
                ///Varificar que el precio sea 20% mayor que el precio 
                double costo = double.Parse(txtCosto.Text), precio = double.Parse(txtPrecio.Text), precioIdeal;
                precioIdeal = costo * 1.2;
                if (!(precio >= precioIdeal))
                {
                    ok = false;
                    errorProviderProductos.SetError(txtPrecio, "El precio debe ser 20% mayor al costo");
                }
                else
                {
                    ok = true;
                }
            }
            catch (Exception )
            {

            }

        }
        private void txtCantidad_Validated(object sender, EventArgs e)
        {
            try
            {
                //verificar que la cantidad debe ser mayor que cero 
                int cantidad = int.Parse(txtCantidad.Text);
                if (!(cantidad > 0))
                {
                    ok = false;
                    errorProviderProductos.SetError(txtCantidad, "La cantidad debe ser mayor que cero");
                }
                else
                {
                    ok = true;
                }
            }
            catch (Exception)
            {

            }
        }
        ////Metodo limpiar
        public void limpiar()
        {
            cbxProductos.Text="";
            cbxMarca.Text = "";
            txtCodigo.Clear();
            txtModelo.Clear();
            rtxtDetalles.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cbxProductos.Focus();
        }
        private void txtCantidad_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Visible = true;
            this.Close();
        }
    }

}
