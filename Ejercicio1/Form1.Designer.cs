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
            this.listBox2 = new System.Windows.Forms.ListBox();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxProducto
            // 
            this.ListBoxProducto.FormattingEnabled = true;
            this.ListBoxProducto.ItemHeight = 16;
            this.ListBoxProducto.Location = new System.Drawing.Point(12, 236);
            this.ListBoxProducto.Name = "ListBoxProducto";
            this.ListBoxProducto.Size = new System.Drawing.Size(297, 244);
            this.ListBoxProducto.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(688, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(230, 228);
            this.listBox2.TabIndex = 1;
            // 
            // textBoxCB
            // 
            this.textBoxCB.Location = new System.Drawing.Point(178, 16);
            this.textBoxCB.Name = "textBoxCB";
            this.textBoxCB.Size = new System.Drawing.Size(100, 22);
            this.textBoxCB.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(178, 44);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(178, 72);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // maskedTextBoxPrecio
            // 
            this.maskedTextBoxPrecio.Location = new System.Drawing.Point(178, 100);
            this.maskedTextBoxPrecio.Name = "maskedTextBoxPrecio";
            this.maskedTextBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxPrecio.TabIndex = 5;
            // 
            // labelCB
            // 
            this.labelCB.AutoSize = true;
            this.labelCB.Location = new System.Drawing.Point(9, 22);
            this.labelCB.Name = "labelCB";
            this.labelCB.Size = new System.Drawing.Size(59, 16);
            this.labelCB.TabIndex = 6;
            this.labelCB.Text = "Barcode";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(9, 50);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 16);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Name";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(9, 75);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(75, 16);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Description";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(9, 103);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(38, 16);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Price";
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 209);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(178, 149);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 37);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 492);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ListBoxProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxProducto;
        private System.Windows.Forms.ListBox listBox2;
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
    }
}

