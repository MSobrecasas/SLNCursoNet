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
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(308, 133);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(160, 30);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear Producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearClienteIndividuo
            // 
            this.btnCrearClienteIndividuo.Location = new System.Drawing.Point(308, 191);
            this.btnCrearClienteIndividuo.Name = "btnCrearClienteIndividuo";
            this.btnCrearClienteIndividuo.Size = new System.Drawing.Size(160, 30);
            this.btnCrearClienteIndividuo.TabIndex = 1;
            this.btnCrearClienteIndividuo.Text = "Crear Cliente Individuo";
            this.btnCrearClienteIndividuo.UseVisualStyleBackColor = true;
            this.btnCrearClienteIndividuo.Click += new System.EventHandler(this.btnCrearClienteIndividuo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearClienteIndividuo);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearClienteIndividuo;
    }
}

