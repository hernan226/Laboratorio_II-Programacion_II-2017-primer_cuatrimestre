namespace UIAulas
{
    partial class FrmListar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstListado = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LstListado
            // 
            this.LstListado.FormattingEnabled = true;
            this.LstListado.Location = new System.Drawing.Point(12, 10);
            this.LstListado.Name = "LstListado";
            this.LstListado.Size = new System.Drawing.Size(147, 238);
            this.LstListado.TabIndex = 0;
            // 
            // FrmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 261);
            this.Controls.Add(this.LstListado);
            this.Name = "FrmListar";
            this.Text = "FrmListar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstListado;
    }
}