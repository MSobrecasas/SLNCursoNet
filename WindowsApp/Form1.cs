using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Nombre = "Coca Cola";
            producto.Descripcion = "Gaseosa";
            producto.Margen = 0.30;
            producto.PrecioCosto = 460.5m;
            producto.IVA = 0.21;
            producto.Proveedor = "Coca Company";
            producto.Categoria = "Bebidas";
            producto.SubCategoria = "Sin Alcohol";

            string message = "Producto: " + producto.Nombre + " Descripcion: " + producto.Descripcion;
            message += " Costo: " + producto.PrecioCosto + " Margen: " + producto.Margen * 100;
            message += "% Precio Bruto: " + producto.PrecioBruto;
            message += " IVA: " + producto.IVA * 100 + "% Precio Venta: " + producto.PrecioVenta;
            message += " Categoria: " + producto.Categoria + " SubCategoria: " + producto.Categoria;
            MessageBox.Show(message);

        }

        private void btnCrearClienteIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo();

            clienteIndividuo.Nombre = "Maria";
            clienteIndividuo.Apellido = "Sobrecasas";
            clienteIndividuo.CUIT = "27333333333";
            clienteIndividuo.Email = "sns.mary@hotmail.com";
            clienteIndividuo.Telefono = "38815444444";
            clienteIndividuo.Direccion = "Av Siempre Viva 1234";

            string message = "Nombre y Apellido: " + clienteIndividuo.Nombre + clienteIndividuo.Apellido;
            message += " CUIT: " + clienteIndividuo.CUIT + " Email: " + clienteIndividuo.Email;
            message += " Telefono: " + clienteIndividuo.Telefono + " Direccion: " + clienteIndividuo.Direccion;
            MessageBox.Show(message);
        }
    }
}
