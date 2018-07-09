namespace practicasPalParcial
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnchoDeFrente = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLeer = new System.Windows.Forms.Button();
            this.RtbLista = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(13, 30);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
            this.TxtDireccion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ancho De Frente";
            // 
            // TxtAnchoDeFrente
            // 
            this.TxtAnchoDeFrente.Location = new System.Drawing.Point(13, 74);
            this.TxtAnchoDeFrente.Name = "TxtAnchoDeFrente";
            this.TxtAnchoDeFrente.Size = new System.Drawing.Size(100, 20);
            this.TxtAnchoDeFrente.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(143, 30);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(75, 23);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLeer
            // 
            this.BtnLeer.Location = new System.Drawing.Point(143, 74);
            this.BtnLeer.Name = "BtnLeer";
            this.BtnLeer.Size = new System.Drawing.Size(75, 23);
            this.BtnLeer.TabIndex = 5;
            this.BtnLeer.Text = "Leer";
            this.BtnLeer.UseVisualStyleBackColor = true;
            this.BtnLeer.Click += new System.EventHandler(this.BtnLeer_Click);
            // 
            // RtbLista
            // 
            this.RtbLista.Location = new System.Drawing.Point(13, 101);
            this.RtbLista.Name = "RtbLista";
            this.RtbLista.Size = new System.Drawing.Size(284, 264);
            this.RtbLista.TabIndex = 6;
            this.RtbLista.Text = "";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 377);
            this.Controls.Add(this.RtbLista);
            this.Controls.Add(this.BtnLeer);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.TxtAnchoDeFrente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.label1);
            this.Name = "FrmPpal";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAnchoDeFrente;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLeer;
        private System.Windows.Forms.RichTextBox RtbLista;
    }
}

