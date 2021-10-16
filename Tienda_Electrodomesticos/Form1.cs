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
            bool ok =true;


            return ok;
        }
    }

}
