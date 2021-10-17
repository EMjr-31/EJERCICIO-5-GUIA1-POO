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
    public partial class Form2 : Form
    {
        ///Contador de Codigo
        int cont = 1;
        ///Validador de errores 
        bool ok = true;
        /// Varianle almacenadora de correos
        string correos;
        public Form2()
        {
            InitializeComponent();
            ///TextBoxs no sea editable 
            txtCodigo.ReadOnly = true;
            txtEdad.ReadOnly = true;
            ///Aginamos valor nulo a al variable correos para poder concatenarla
            correos = "";
        }


        /////Funcion para validar campos 
        private bool ValidarCampos()
        {
            if (txtNombre.Text == "")
            {
                errorProviderCliente.SetError(txtNombre, "Ingrese el Nombre");
                ok = false;
            }
            if (txtApellido.Text == "")
            {
                errorProviderCliente.SetError(txtApellido, "Ingrese el Apellido");
                ok = false;
            }
            if (txtEdad.Text == "")
            {
                errorProviderCliente.SetError(dtpFecha, "Seleccione la fecha de nacimiento");
                ok = false;
            }
            if (txtCodigo.Text == "")
            {
                ok = false;
                errorProviderCliente.SetError(txtCodigo, "Genere el codigo");
            }
            if (rtxtCorreos.Text == "")
            {
                ok = false;
                errorProviderCliente.SetError(btnAniadir, "Debe agregar al menos un correo");
            }

            return ok;
        }
        ///Correccion de Errores

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProviderCliente.SetError(txtCorreo, "");
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProviderCliente.SetError(txtNombre, "");
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProviderCliente.SetError(txtApellido, "");
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProviderCliente.SetError(txtCodigo, "");
        }

        private void rtxtCorreos_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProviderCliente.SetError(btnAniadir, "");
        }
        ///Eventos VALIDATING
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }
        private void dtpFecha_Validating(object sender, CancelEventArgs e)
        {
            //vaidamos que la fecha de nacimiento nos la fecha por defecto
            string fecha = dtpFecha.Value.ToString("dd/MM/yyyy"); ;
            string hoy = DateTime.Now.ToString("dd/MM/yyyy");
            if ((fecha == hoy))
            {
                ok = true;
                errorProviderCliente.SetError(dtpFecha, "");
            }
            else
            {
                ok = false;
                errorProviderCliente.SetError(dtpFecha, "La fecha no debe del año actual");
            }
        }
        ///EVENTOS VALIDATED
        private void dtpFecha_Validated(object sender, EventArgs e)
        {
            int edad = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(dtpFecha.Value.ToString("yyyy"));
            //validamos que la fecha no sea superior al año actual
            if (edad > 0)
            {
                ok = true;
                errorProviderCliente.SetError(dtpFecha, "");
                txtEdad.Text = edad.ToString();
            }
            else
            {
                ok = false;
                errorProviderCliente.SetError(dtpFecha, "La fecha no puede ser superor a la fecha actual");
            }
        }
        //Metodo para validad solo letras 
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        ///Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            if (ValidarCampos() == true || ok == true)
            {
                MessageBox.Show("Cliente Registrado con exito");
                cont++;
                limpiar();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ///Verificacion de los parametros necesarios para generar el codigo 
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Para generar el codigo debe ingresar el nombre");
                txtNombre.Focus();
            }
            else
            {
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Para generar el codigo debe ingresar el apellido");
                    txtApellido.Focus();
                }
                else
                {
                    txtCodigo.Text = GenerarCodigo();
                }
            }
        }
        ///Funciona para generar el codigo del cliente
        public string GenerarCodigo()
        {
            ///Varible que almacena el codigo 
            string codigo;
            //Generador de codigos 
            string Texto1 = txtNombre.Text;
            string Texto2 = txtApellido.Text;
            string anio = DateTime.Now.ToString("yyyy"); ;
            //Usando expresiones regulares obtendremos Dos incioales
            Match Letra1 = Regex.Match(Texto1, @"\w");
            Match Letra2 = Regex.Match(Texto2, @"\w");
            if (cont <= 9) { codigo = Letra1.Value + Letra2.Value + anio + "00" + cont.ToString(); }
            else
            {
                if (cont <= 99) { codigo = Letra1.Value + Letra2.Value + anio + "0" + cont.ToString(); }
                else { codigo = Letra1.Value + Letra2.Value + anio + cont.ToString(); }
            }
            return codigo;
        }
        ///Funcion para validad emial
        private Boolean VerificarEmail(string email)
        {
            ///usando expresiones regulares veficamos el formato del correo
            return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
        ///boton añadir correos
        private void btnAniadir_Click(object sender, EventArgs e)
        {
            if (VerificarEmail(txtCorreo.Text))
            {
                ok = true;
                correos = correos + txtCorreo.Text + "\n";
                rtxtCorreos.Text = correos;
                txtCorreo.Clear();
            }
            else
            {
                ok = false;
                errorProviderCliente.SetError(txtCorreo, "Ingrese un correo valido");
            }
        }

        ///Metodo Limpiar
        public void limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtCodigo.Clear();
            rtxtCorreos.Clear();
            correos = "";
            txtNombre.Focus(); 
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
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
