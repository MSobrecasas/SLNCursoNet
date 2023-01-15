namespace WindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCrearClienteIndividuo = new System.Windows.Forms.Button();
            this.btnCrearProveedor = new System.Windows.Forms.Button();
            this.btnCrearVendedor = new System.Windows.Forms.Button();
            this.btnCrearClienteEmpresa = new System.Windows.Forms.Button();
            this.btnCrearFactura = new System.Windows.Forms.Button();
            this.btnCrearRemito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(308, 56);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(160, 30);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear Producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearClienteIndividuo
            // 
            this.btnCrearClienteIndividuo.Location = new System.Drawing.Point(308, 128);
            this.btnCrearClienteIndividuo.Name = "btnCrearClienteIndividuo";
            this.btnCrearClienteIndividuo.Size = new System.Drawing.Size(160, 30);
            this.btnCrearClienteIndividuo.TabIndex = 1;
            this.btnCrearClienteIndividuo.Text = "Crear Cliente Individuo";
            this.btnCrearClienteIndividuo.UseVisualStyleBackColor = true;
            this.btnCrearClienteIndividuo.Click += new System.EventHandler(this.btnCrearClienteIndividuo_Click);
            // 
            // btnCrearProveedor
            // 
            this.btnCrearProveedor.Location = new System.Drawing.Point(308, 92);
            this.btnCrearProveedor.Name = "btnCrearProveedor";
            this.btnCrearProveedor.Size = new System.Drawing.Size(160, 30);
            this.btnCrearProveedor.TabIndex = 2;
            this.btnCrearProveedor.Text = "Crear Proveedor";
            this.btnCrearProveedor.UseVisualStyleBackColor = true;
            this.btnCrearProveedor.Click += new System.EventHandler(this.btnCrearProveedor_Click);
            // 
            // btnCrearVendedor
            // 
            this.btnCrearVendedor.Location = new System.Drawing.Point(308, 200);
            this.btnCrearVendedor.Name = "btnCrearVendedor";
            this.btnCrearVendedor.Size = new System.Drawing.Size(160, 30);
            this.btnCrearVendedor.TabIndex = 3;
            this.btnCrearVendedor.Text = "Crear Vendedor";
            this.btnCrearVendedor.UseVisualStyleBackColor = true;
            this.btnCrearVendedor.Click += new System.EventHandler(this.btnCrearVendedor_Click);
            // 
            // btnCrearClienteEmpresa
            // 
            this.btnCrearClienteEmpresa.Location = new System.Drawing.Point(308, 164);
            this.btnCrearClienteEmpresa.Name = "btnCrearClienteEmpresa";
            this.btnCrearClienteEmpresa.Size = new System.Drawing.Size(160, 30);
            this.btnCrearClienteEmpresa.TabIndex = 4;
            this.btnCrearClienteEmpresa.Text = "Crear Cliente Empresa";
            this.btnCrearClienteEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearClienteEmpresa.Click += new System.EventHandler(this.btnCrearClienteEmpresa_Click);
            // 
            // btnCrearFactura
            // 
            this.btnCrearFactura.Location = new System.Drawing.Point(308, 236);
            this.btnCrearFactura.Name = "btnCrearFactura";
            this.btnCrearFactura.Size = new System.Drawing.Size(160, 30);
            this.btnCrearFactura.TabIndex = 5;
            this.btnCrearFactura.Text = "Crear Factura";
            this.btnCrearFactura.UseVisualStyleBackColor = true;
            // 
            // btnCrearRemito
            // 
            this.btnCrearRemito.Location = new System.Drawing.Point(308, 272);
            this.btnCrearRemito.Name = "btnCrearRemito";
            this.btnCrearRemito.Size = new System.Drawing.Size(160, 30);
            this.btnCrearRemito.TabIndex = 6;
            this.btnCrearRemito.Text = "Crear Remito";
            this.btnCrearRemito.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearRemito);
            this.Controls.Add(this.btnCrearFactura);
            this.Controls.Add(this.btnCrearClienteEmpresa);
            this.Controls.Add(this.btnCrearVendedor);
            this.Controls.Add(this.btnCrearProveedor);
            this.Controls.Add(this.btnCrearClienteIndividuo);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearClienteIndividuo;
        private System.Windows.Forms.Button btnCrearProveedor;
        private System.Windows.Forms.Button btnCrearVendedor;
        private System.Windows.Forms.Button btnCrearClienteEmpresa;
        private System.Windows.Forms.Button btnCrearFactura;
        private System.Windows.Forms.Button btnCrearRemito;
    }
}

