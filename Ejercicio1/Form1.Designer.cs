namespace Ejercicio1
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
            this.ListBoxProducto = new System.Windows.Forms.ListBox();
            this.listBoxArticulos = new System.Windows.Forms.ListBox();
            this.textBoxCB = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.labelCB = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFinalizarVenta = new System.Windows.Forms.Button();
            this.maskedTextBoxCantidad = new System.Windows.Forms.MaskedTextBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonIniciarVenta = new System.Windows.Forms.Button();
            this.buttonCant = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxProducto
            // 
            this.ListBoxProducto.FormattingEnabled = true;
            this.ListBoxProducto.Location = new System.Drawing.Point(9, 192);
            this.ListBoxProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListBoxProducto.Name = "ListBoxProducto";
            this.ListBoxProducto.Size = new System.Drawing.Size(224, 199);
            this.ListBoxProducto.TabIndex = 0;
            // 
            // listBoxArticulos
            // 
            this.listBoxArticulos.FormattingEnabled = true;
            this.listBoxArticulos.Location = new System.Drawing.Point(516, 10);
            this.listBoxArticulos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxArticulos.Name = "listBoxArticulos";
            this.listBoxArticulos.Size = new System.Drawing.Size(174, 186);
            this.listBoxArticulos.TabIndex = 1;
            // 
            // textBoxCB
            // 
            this.textBoxCB.Location = new System.Drawing.Point(134, 13);
            this.textBoxCB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCB.Name = "textBoxCB";
            this.textBoxCB.Size = new System.Drawing.Size(76, 20);
            this.textBoxCB.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(134, 36);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(76, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(134, 58);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(76, 20);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // maskedTextBoxPrecio
            // 
            this.maskedTextBoxPrecio.Location = new System.Drawing.Point(134, 81);
            this.maskedTextBoxPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.maskedTextBoxPrecio.Name = "maskedTextBoxPrecio";
            this.maskedTextBoxPrecio.Size = new System.Drawing.Size(76, 20);
            this.maskedTextBoxPrecio.TabIndex = 5;
            // 
            // labelCB
            // 
            this.labelCB.AutoSize = true;
            this.labelCB.Location = new System.Drawing.Point(7, 18);
            this.labelCB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCB.Name = "labelCB";
            this.labelCB.Size = new System.Drawing.Size(85, 13);
            this.labelCB.TabIndex = 6;
            this.labelCB.Text = "Codigo de barra:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(7, 41);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(7, 61);
            this.labelDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(7, 84);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Precio";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.textBoxDescripcion);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Controls.Add(this.textBoxCB);
            this.groupBox1.Controls.Add(this.labelDescripcion);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Controls.Add(this.maskedTextBoxPrecio);
            this.groupBox1.Controls.Add(this.labelCB);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(223, 170);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(134, 121);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 30);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFinalizarVenta
            // 
            this.buttonFinalizarVenta.Location = new System.Drawing.Point(294, 352);
            this.buttonFinalizarVenta.Name = "buttonFinalizarVenta";
            this.buttonFinalizarVenta.Size = new System.Drawing.Size(160, 36);
            this.buttonFinalizarVenta.TabIndex = 12;
            this.buttonFinalizarVenta.Text = "Finalizar Venta";
            this.buttonFinalizarVenta.UseVisualStyleBackColor = true;
            this.buttonFinalizarVenta.Click += new System.EventHandler(this.buttonFinalizarVenta_Click);
            // 
            // maskedTextBoxCantidad
            // 
            this.maskedTextBoxCantidad.Location = new System.Drawing.Point(354, 217);
            this.maskedTextBoxCantidad.Name = "maskedTextBoxCantidad";
            this.maskedTextBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxCantidad.TabIndex = 13;
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Location = new System.Drawing.Point(291, 220);
            this.labelCant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(49, 13);
            this.labelCant.TabIndex = 12;
            this.labelCant.Text = "Cantidad";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(574, 266);
            this.labelSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(77, 20);
            this.labelSubtotal.TabIndex = 15;
            this.labelSubtotal.Text = "Subtotal";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(574, 320);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 20);
            this.labelTotal.TabIndex = 16;
            this.labelTotal.Text = "Total";
            // 
            // buttonIniciarVenta
            // 
            this.buttonIniciarVenta.Location = new System.Drawing.Point(294, 17);
            this.buttonIniciarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.buttonIniciarVenta.Name = "buttonIniciarVenta";
            this.buttonIniciarVenta.Size = new System.Drawing.Size(160, 30);
            this.buttonIniciarVenta.TabIndex = 12;
            this.buttonIniciarVenta.Text = "IniciarVenta";
            this.buttonIniciarVenta.UseVisualStyleBackColor = true;
            this.buttonIniciarVenta.Click += new System.EventHandler(this.buttonIniciarVenta_Click_1);
            // 
            // buttonCant
            // 
            this.buttonCant.Location = new System.Drawing.Point(294, 256);
            this.buttonCant.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCant.Name = "buttonCant";
            this.buttonCant.Size = new System.Drawing.Size(160, 30);
            this.buttonCant.TabIndex = 12;
            this.buttonCant.Text = "Agregar";
            this.buttonCant.UseVisualStyleBackColor = true;
            this.buttonCant.Click += new System.EventHandler(this.buttonCant_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 400);
            this.Controls.Add(this.buttonCant);
            this.Controls.Add(this.buttonIniciarVenta);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.maskedTextBoxCantidad);
            this.Controls.Add(this.buttonFinalizarVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxArticulos);
            this.Controls.Add(this.ListBoxProducto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProducto;
        private System.Windows.Forms.ListBox listBoxArticulos;
        private System.Windows.Forms.TextBox textBoxCB;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecio;
        private System.Windows.Forms.Label labelCB;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFinalizarVenta;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCantidad;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonIniciarVenta;
        private System.Windows.Forms.Button buttonCant;
    }
}

