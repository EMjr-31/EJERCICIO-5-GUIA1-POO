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
        int cont=0;
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
            GenerarCodigo();
        }

        private void txtCodigo_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("El codigo de producto se genera automaticament.\nClick sobre el boton Generar");
        }

        public void GenerarCodigo()
        {
            //Generador de codigos 
            string Texto1 = cbxProductos.Text;
            string Texto2 = cbxMarca.Text;
            //Usando expresiones regulares obtendremos Dos incioales
            Match Letra1 = Regex.Match(Texto1, @"\w");
            Match Letra2 = Regex.Match(Texto2, @"\w");
            MessageBox.Show(Letra1.Value+Letra2.Value);

        }
    }

}
