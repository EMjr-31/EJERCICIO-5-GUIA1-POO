using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_Electrodomesticos
{
    public partial class Ventas : Form
    {
        //Indices de busqueda 
        int IndexC = -1;
        int IndexP = -1;
        //Variables globales 
        string datosCliente, datosProductos, Nproducto, fac="Factura";
        double precioP, total = 0;
        int edad, cantidadDis;
        ///Validador de errores 
        bool ok = true;
        /*LOS CLIENTES Y PRODUCTOS SERAN INGRESADOS POR DEFECTO
         * DEBIDO A QUE NO SE CUENTA CON ALAMCENAMIENTO DE DATOS
         * LOS DATOS SON DE CARACTER ILUSTRATIVO PARA EL FUNCIONAMIENTO DEL FORM*/
        ///Lista de clientes 
        private List<Clientes> clientes = new List<Clientes>();
        ///Lista Productos
        private List<Productos> productos = new List<Productos>();
        public Ventas()
        {
            InitializeComponent();
            //Ingreso de Clientes 
            CargaDatos();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clientes;
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        /////Funcion para validar campos 
        private bool ValidarCampos()
        {
            if (rtxtInfoCliente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(rtxtInfoCliente, "Seleccione un producto donde click sobre el");
            }
            if (rtxtCarrito.Text == "")
            {
                ok = false;
                errorProvider1.SetError(btnAniadir, "Ingrese Productos al carrito");
            }
            return ok;
        }
        ///Correccion de errores
        private void rtxtInfoCliente_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProvider1.SetError(rtxtInfoCliente, "");
            errorProvider1.SetError(dgvCliente, "");
        }
        private void rtxtCarrito_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProvider1.SetError(btnAniadir, "");
        }

        private void txtCantidaComprar_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProvider1.SetError(txtCantidaComprar, "");
        }

        private void txtCredito_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProvider1.SetError(txtCredito, "");
        }
        private void txtContado_TextChanged(object sender, EventArgs e)
        {
            ok = true;
            errorProvider1.SetError(txtContado, "");
        }
        //Busqueda automatica
        private void txtPC_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbtnCodigoC.Checked == true)
            {
                buscarCliente_codigo();
            }
            if (rbtnNombre.Checked == true)
            {
                buscarCliente_Nombre();
            }
            if (rbtnApellido.Checked == true)
            {
                buscarCliente_Apellido();
            }
            if (rbtnCodigoC.Checked == false && rbtnNombre.Checked == false && rbtnApellido.Checked == false)
            {
                MessageBox.Show("Seleccione un tipo de dato de busqueda");
                txtPC.Clear();
            }
        }
        private void txtPP_KeyUp(object sender, KeyEventArgs e)
        {
            if (rbtnProducto.Checked == true)
            {
                buscarProducto_Producto();
            }
            if (rbtnMarca.Checked == true)
            {
                buscarProducto_Marca();
            }
            if (rbtnModelo.Checked == true)
            {
                buscarProducto_Modelo();
            }
            if (rbtnProducto.Checked == false && rbtnMarca.Checked == false && rbtnModelo.Checked == false)
            {
                MessageBox.Show("Seleccione un tipo de dato de busqueda");
                txtPP.Clear();
            }
        }
        ////Metodos de busqueda 
        public void buscarCliente_codigo()
        {
            dgvCliente.DataSource = null;
            string dato = txtPC.Text.Trim();
            dgvCliente.DataSource = clientes.FindAll(p => p.Codigo.StartsWith(dato));
        }
        public void buscarCliente_Nombre()
        {
            dgvCliente.DataSource = null;
            string dato = txtPC.Text.Trim();
            dgvCliente.DataSource = clientes.FindAll(p => p.Nombre.StartsWith(dato));
        }
        public void buscarCliente_Apellido()
        {
            dgvCliente.DataSource = null;
            string dato = txtPC.Text.Trim();
            dgvCliente.DataSource = clientes.FindAll(p => p.Apellido.StartsWith(dato));
        }
        public void buscarProducto_Modelo()
        {
            dgvProductos.DataSource = null;
            string dato = txtPP.Text.Trim();
            dgvProductos.DataSource = productos.FindAll(p => p.Modelo.StartsWith(dato));
        }
        public void buscarProducto_Marca()
        {
            dgvProductos.DataSource = null;
            string dato = txtPP.Text.Trim();
            dgvProductos.DataSource = productos.FindAll(p => p.Marca.StartsWith(dato));
        }
        public void buscarProducto_Producto()
        {
            dgvProductos.DataSource = null;
            string dato = txtPP.Text.Trim();
            dgvProductos.DataSource = productos.FindAll(p => p.Producto.StartsWith(dato));
        }
        ///Metodos de seleccion

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            rtxtInfoCliente.Text = "";
            datosCliente = "";
            DataGridViewRow selected = dgvCliente.SelectedRows[0];
            int posicion = dgvCliente.Rows.IndexOf(selected);
            IndexC = posicion;
            Clientes client = clientes[posicion];
            DateTime fecha = DateTime.Parse(client.FechaNaci);
            edad = int.Parse(DateTime.Now.ToString("yyyy")) - int.Parse(fecha.ToString("yyyy"));
            datosCliente = "Nombre: " + client.Nombre + " " + client.Apellido + "\nEdad: " + edad.ToString() + "\nCorreo: " + client.Correo;
            rtxtInfoCliente.Text = datosCliente;

        }
        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            rtxtInfoProducto.Text = "";
            datosProductos = "";
            DataGridViewRow selected = dgvProductos.SelectedRows[0];
            int posicionP = dgvProductos.Rows.IndexOf(selected);
            IndexP = posicionP;
            Productos produc = productos[posicionP];
            cantidadDis = produc.Cantidad;
            precioP = produc.Precio;
            Nproducto = produc.Producto + " " + produc.Marca;
            datosProductos = Nproducto + "\n\tPrecio : $" + precioP.ToString();
            rtxtInfoProducto.Text = datosProductos;
        }
        ///Añadir al carrito 
        private void btnAniadir_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadSol = int.Parse(txtCantidaComprar.Text);
                if (cantidadSol <= cantidadDis)
                {
                    rtxtCarrito.Text = "";
                    ok = true;
                    total = total + cantidadSol * precioP;
                    fac = fac + "\n" + Nproducto + " " + cantidadSol.ToString() + "X" + precioP.ToString() + " = " + (cantidadSol * precioP).ToString();
                    rtxtCarrito.Text = fac;
                    txtCantidaComprar.Clear();
                }
                else
                {
                    ok = false;
                    errorProvider1.SetError(txtCantidaComprar, "No contamos con esa cantidad de productos");
                }
            }
            catch (Exception)
            {
                ok = false;
                errorProvider1.SetError(txtCantidaComprar, "Ingrese una cantidad correcta");
            }
        }

        private void txtCantidaComprar_Validated(object sender, EventArgs e)
        {

        }
        ///Metodos de pago 
        private void rbCredito_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnContado, "");
            if ((edad != 0))
            {
                ok = true;
                if (edad > 18)
                {
                    lbnumCuenta.Visible = true;
                    txtCredito.Visible = true;
                    lbContado.Visible = false;
                    txtContado.Visible = false;
                   
                }
                else {
                    lbnumCuenta.Visible = false;
                    txtCredito.Visible = false;
                    MessageBox.Show("El cliente no es mayor de edad");
                }
            }
            else
            {
                ok = false;
                errorProvider1.SetError(dgvCliente, "Seleccione un cliente");
                rbCredito.Checked = false;

            }

        }

        private void rbtnContado_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(rbtnContado, "");
            if ((edad != 0))
            {
                ok = true;
                if (edad > 18)
                {
                    lbnumCuenta.Visible = false;
                    txtCredito.Visible = false;
                    lbContado.Visible = true;
                    txtContado.Visible = true;

                }
                else
                {
                    lbnumCuenta.Visible = false;
                    txtCredito.Visible = false;
                }
            }
            else
            {
                ok = false;
                rbtnContado.Checked = false;
                errorProvider1.SetError(dgvCliente, "Seleccione un cliente");
            }
        }
        private void rbtnContado_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void bntPagar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            if (ValidarCampos() == true || ok == true)
            {
                if (total > 0)
                {
                    fac = fac + "------------------------------\n\tTotal $" + total.ToString();
                }
                if (txtContado.Visible == true)
                {
                    ok = true;
                    double cantidad = double.Parse(txtContado.Text);
                    if (cantidad >= total)
                    {
                        MessageBox.Show("Pago exitoso \nCambio $" + (cantidad - total));
                        limpiar();
                    }
                    else
                    {
                        ok = false;
                        errorProvider1.SetError(txtContado, "Ingrese un monto mayor o igual al total a cancelar");
                    }
                }
                if (txtCredito.Visible == true)
                {
                    if (!(txtCredito.Text == " "))
                    {
                        MessageBox.Show("Pago exitoso");
                        limpiar();
                    }
                    else
                    {
                        ok = false;
                        errorProvider1.SetError(txtCredito, "Ingrese numero de cuenta");
                    }
                }
                if (txtContado.Visible == false && txtContado.Visible == false)
                {
                    errorProvider1.SetError(rbtnContado, "Seleccione un metodo de pago");
                }
            }
               
        }



        ///Metodos para limpiar
        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            rtxtInfoCliente.Text = "";
            IndexC = -1;
            edad = 0;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Visible = true;
            this.Close();
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {

        }




        //Metodo para cargar datos genericos
        public void CargaDatos()
        {
            Clientes client1 = new Clientes();
            client1.Codigo = "JS2021001";
            client1.Nombre = "Julian";
            client1.Apellido = "Soler";
            client1.Correo = "soiwagebaufu-4439@yopmail.com";
            client1.FechaNaci = "02/11/1997";
            clientes.Add(client1);
            Clientes client2 = new Clientes();
            client2.Codigo = "JC2021002";
            client2.Nombre = "Josefina";
            client2.Apellido = "Contreras";
            client2.Correo = "boquawuvimau-3673@yopmail.com";
            client2.FechaNaci = "15/05/2001";
            clientes.Add(client2);
            Clientes client3 = new Clientes();
            client3.Codigo = "JV2021003";
            client3.Nombre = "Jon";
            client3.Apellido = "Verdugo";
            client3.Correo = "braubatreuneixo-8245@yopmail.com";
            client3.FechaNaci = "19/11/1999";
            clientes.Add(client3);
            Clientes client4 = new Clientes();
            client4.Codigo = "IM2021004";
            client4.Nombre = "Irene";
            client4.Apellido = "Mayor";
            client4.Correo = "saussemabovi-6798@yopmail.com";
            client4.FechaNaci = "20/01/1975";
            clientes.Add(client4);
            Clientes client5 = new Clientes();
            client5.Codigo = "AF2021005";
            client5.Nombre = "Alexander";
            client5.Apellido = "Ferreira";
            client5.Correo = "yefrasoussette-2434@yopmail.com";
            client5.FechaNaci = "21/09/2007";
            clientes.Add(client5);
            //Ingreso de Productos
            Productos produc1 = new Productos();
            produc1.Producto = "Licuadora";
            produc1.Marca = "Black + Decker";
            produc1.Modelo = "BLBD210GB-2G";
            produc1.Precio = 79.00;
            produc1.Cantidad = 4;
            productos.Add(produc1);
            Productos produc2 = new Productos();
            produc2.Producto = "Licuadora";
            produc2.Marca = "Oster";
            produc2.Modelo = "BLSTKAGRRD01";
            produc2.Precio = 54.99;
            produc2.Cantidad = 1;
            productos.Add(produc2);
            Productos produc3 = new Productos();
            produc3.Producto = "Licuadora";
            produc3.Marca = "Mastertech";
            produc3.Modelo = "MTBL08GJ2AB";
            produc3.Precio = 34.99;
            produc3.Cantidad = 10;
            productos.Add(produc3);
            Productos produc4 = new Productos();
            produc4.Producto = "Cafetera";
            produc4.Marca = "Black + Decker";
            produc4.Modelo = "CMU1000";
            produc4.Precio = 139;
            produc4.Cantidad = 3;
            productos.Add(produc4);
            Productos produc5 = new Productos();
            produc5.Producto = "Cafetera";
            produc5.Marca = "Mastertech";
            produc5.Modelo = "MTCM12PF2AB";
            produc5.Precio = 22.99;
            produc5.Cantidad = 5;
            productos.Add(produc5);
            Productos produc6 = new Productos();
            produc6.Producto = "Cafetera";
            produc6.Marca = "Oster";
            produc6.Modelo = " BVSTDC3390";
            produc6.Precio = 54;
            produc6.Cantidad = 6;
            productos.Add(produc6);
            Productos produc7 = new Productos();
            produc7.Producto = "Horno tostador";
            produc7.Marca = "Black + Decker";
            produc7.Modelo = "TO1785SGLA";
            produc7.Precio = 59.99;
            produc7.Cantidad = 9;
            productos.Add(produc7);
            Productos produc8 = new Productos();
            produc8.Producto = "Horno tostador";
            produc8.Marca = "Mastertech";
            produc8.Modelo = "TSSTTV10LTB-013";
            produc8.Precio = 57.90;
            produc8.Cantidad = 4;
            productos.Add(produc8);
            Productos produc9 = new Productos();
            produc9.Producto = "Horno tostador";
            produc9.Marca = "Oster";
            produc9.Modelo = "Hamilton Beach";
            produc9.Precio = 49;
            produc9.Cantidad = 8;
            productos.Add(produc9);
            Productos produc10 = new Productos();
            produc10.Producto = "Plancha";
            produc10.Marca = "Black + Decker";
            produc10.Modelo = "ICR1924";
            produc10.Precio = 46.99;
            produc10.Cantidad = 3;
            productos.Add(produc10);
            Productos produc12 = new Productos();
            produc12.Producto = "Plancha";
            produc12.Marca = "Mastertech";
            produc12.Modelo = "KANSU987";
            produc12.Precio = 0.0;
            produc12.Cantidad = 0;
            productos.Add(produc12);
            Productos produc13 = new Productos();
            produc13.Producto = "Plancha";
            produc13.Marca = "Oster";
            produc13.Modelo = "GCSTBS5906-013";
            produc13.Precio = 39.90;
            produc13.Cantidad = 2;
            productos.Add(produc13);
            Productos produc14 = new Productos();
            produc14.Producto = "Aspiradora";
            produc14.Marca = "Black + Decker";
            produc14.Modelo = " IRWM06BL";
            produc14.Precio = 67.99;
            produc14.Cantidad = 5;
            productos.Add(produc14);
            Productos produc15 = new Productos();
            produc15.Producto = "Aspiradora";
            produc15.Marca = "Mastertech";
            produc15.Modelo = " WD1";
            produc15.Precio = 94.99;
            produc15.Cantidad = 4;
            productos.Add(produc15);
        }



        private void rbnCodigoP_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void rbtnMarca_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnProducto_CheckedChanged(object sender, EventArgs e)
        {

        }
        ///Metodo Limpiar 
        public void limpiar()
        {
            rtxtCarrito.Clear();
            rtxtInfoCliente.Clear();
            rtxtInfoProducto.Clear();
            datosCliente = "";
            datosProductos = "";
            fac = "Factura";
            total = 0;
            edad = 0;
            txtContado.Clear();
            txtCredito.Clear();
        }

    }
}
