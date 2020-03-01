namespace Facturacion
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
            this.label = new System.Windows.Forms.Label();
            this.lbl_nomproducto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_pre = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_cod = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.LightCoral;
            this.label.Font = new System.Drawing.Font("Photographs", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(208, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(94, 42);
            this.label.TabIndex = 0;
            this.label.Text = "FACTURA";
            // 
            // lbl_nomproducto
            // 
            this.lbl_nomproducto.AutoSize = true;
            this.lbl_nomproducto.Location = new System.Drawing.Point(34, 60);
            this.lbl_nomproducto.Name = "lbl_nomproducto";
            this.lbl_nomproducto.Size = new System.Drawing.Size(202, 13);
            this.lbl_nomproducto.TabIndex = 1;
            this.lbl_nomproducto.Text = "INGRSE EL NOMBRE DEL PRODUCTO";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(34, 142);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(62, 13);
            this.lbl_cantidad.TabIndex = 3;
            this.lbl_cantidad.Text = "CANTIDAD";
            this.lbl_cantidad.Click += new System.EventHandler(this.lbl_cantidad_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(37, 158);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 4;
            // 
            // lbl_pre
            // 
            this.lbl_pre.AutoSize = true;
            this.lbl_pre.Location = new System.Drawing.Point(34, 181);
            this.lbl_pre.Name = "lbl_pre";
            this.lbl_pre.Size = new System.Drawing.Size(47, 13);
            this.lbl_pre.TabIndex = 5;
            this.lbl_pre.Text = "PRECIO";
            this.lbl_pre.Click += new System.EventHandler(this.lbl_pre_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(37, 197);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 20);
            this.txt_precio.TabIndex = 6;
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(34, 99);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(49, 13);
            this.lbl_codigo.TabIndex = 7;
            this.lbl_codigo.Text = "CODIGO";
            // 
            // txt_cod
            // 
            this.txt_cod.Location = new System.Drawing.Point(37, 116);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.Size = new System.Drawing.Size(100, 20);
            this.txt_cod.TabIndex = 8;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(233, 193);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(100, 26);
            this.btn.TabIndex = 9;
            this.btn.Text = "FACTURAR ";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.Location = new System.Drawing.Point(313, 406);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(0, 13);
            this.lbl_tot.TabIndex = 10;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(37, 398);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 21);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(479, 435);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_tot);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.lbl_pre);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_nomproducto);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbl_nomproducto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_pre;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.TextBox txt_cod;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.Button btn_salir;
    }
}

