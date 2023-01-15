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
            CrearProducto();

        }
        private void btnCrearClienteIndividuo_Click(object sender, EventArgs e)
        {
            CrearCliente();
        }
        private void btnCrearClienteEmpresa_Click(object sender, EventArgs e)
        {
            CrearEmpresa();
        }
        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            CrearVendedor();

        }
        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            CrearFactura();

        }
        private void btnCrearRemito_Click(object sender, EventArgs e)
        {
            CrearRemito();
        }
        private static void CrearProducto()
        {
            Producto producto = new Producto("Coca Cola", "Gaseosa", 30, 460.5, 21, "Coca Company", "Bebidas", "Sin Alcohol");

            string message = "Producto: " + producto.Nombre + " Descripcion: " + producto.Descripcion;
            message += " Costo: " + producto.PrecioCosto + " Margen: " + producto.Margen;
            message += "% Precio Bruto: " + producto.PrecioBruto;
            message += " IVA: " + producto.IVA + "% Precio Venta: " + producto.PrecioVenta;
            message += " Categoria: " + producto.Categoria + " SubCategoria: " + producto.SubCategoria;
            MessageBox.Show(message,"Producto");
        }



        private static void CrearCliente()
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo("Maria", "Sobrecasas", "27333333333", "sns.mary@hotmail.com", "38815444444", "Av Siempre Viva 1234");

            string message = "Nombre y Apellido: " + clienteIndividuo.Nombre + " " + clienteIndividuo.Apellido;
            message += " CUIT: " + clienteIndividuo.CUIT + " Email: " + clienteIndividuo.Email;
            message += " Telefono: " + clienteIndividuo.Telefono + " Direccion: " + clienteIndividuo.Direccion;
            MessageBox.Show(message,"Cliente");
        }



        private static void CrearEmpresa()
        {
            Empresa clienteEmpresa = new Empresa("Suria", "35-5115555-3", "Jose Suria", "suria@suria.com", "388454871", "Arenales 1023");

            string message = "Nombre: " + clienteEmpresa.Nombre + " Contacto: " + clienteEmpresa.Contacto;
            message += " CUIT: " + clienteEmpresa.CUIT + " Email: " + clienteEmpresa.Email;
            message += " Telefono: " + clienteEmpresa.Telefono + " Direccion: " + clienteEmpresa.Direccion;
            MessageBox.Show(message,"Empresa");
        }



        private static void CrearVendedor()
        {
            Vendedor vendedor = new Vendedor("Maria", "Sobrecasas", "27333333333", "sns.mary@hotmail.com", "38815444444", "Av Siempre Viva 1234");
            string message = "Nombre y Apellido: " + vendedor.Nombre + " " + vendedor.Apellido;
            message += " DNI: " + vendedor.DNI + " Email: " + vendedor.Email;
            message += " Telefono: " + vendedor.Telefono + " Direccion: " + vendedor.Direccion;
            MessageBox.Show(message,"Vendedor");
        }



        private static void CrearFactura()
        {
            Factura factura = new Factura("C-2003", new DateTime(2023, 1, 12), "Jonh Doe", "Av Siempre Viva", "Responsable Inscripto", "Contado", "Gaseosas", 102203.2m, "pesos");
            string message = "Factura N°: " + factura.Numero + " Fecha" + factura.Fecha;
            message += " \nCliente: " + factura.Cliente + " Direccion: " + factura.Direccion;
            message += "\nCondicion IVA: " + factura.CondicionIVA + " Condicion Venta: " + factura.CondicionVenta;
            message += "\nDetalle: " + factura.Detalle + " Total: " + factura.Total + " Tipo: " + factura.Tipo;
            MessageBox.Show(message,"Factura");
        }



        private static void CrearRemito()
        {
            Remito remito = new Remito("C-2003", new DateTime(2023, 1, 12), "Jonh Doe", "Av Siempre Viva", "Responsable Inscripto", "Contado", "Gaseosas", 102203.2m, new DateTime(2023, 1, 13));
            string message = "Remito N°: " + remito.Numero + " Fecha" + remito.Fecha;
            message += " \nCliente: " + remito.Cliente + " Direccion: " + remito.Direccion;
            message += "\nCondicion IVA: " + remito.CondicionIVA + " Condicion Venta: " + remito.CondicionVenta;
            message += "\nDetalle: " + remito.Detalle + " Total: " + remito.Total + " Fecha Entrega: " + remito.FechaEntrega;
            MessageBox.Show(message,"Remito");
        }
    }
}
