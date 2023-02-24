namespace ComboBox
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
            this.cmbalimentos = new System.Windows.Forms.ComboBox();
            this.txtalimento = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lblindice = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbalimentos
            // 
            this.cmbalimentos.FormattingEnabled = true;
            this.cmbalimentos.Items.AddRange(new object[] {
            "Frijol",
            "Tomate"});
            this.cmbalimentos.Location = new System.Drawing.Point(131, 132);
            this.cmbalimentos.Name = "cmbalimentos";
            this.cmbalimentos.Size = new System.Drawing.Size(121, 21);
            this.cmbalimentos.TabIndex = 0;
            this.cmbalimentos.Text = "Alimentos";
            this.cmbalimentos.SelectedIndexChanged += new System.EventHandler(this.cmbalimentos_SelectedIndexChanged);
            // 
            // txtalimento
            // 
            this.txtalimento.Location = new System.Drawing.Point(131, 67);
            this.txtalimento.Name = "txtalimento";
            this.txtalimento.Size = new System.Drawing.Size(121, 20);
            this.txtalimento.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(131, 262);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(121, 53);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.Location = new System.Drawing.Point(107, 207);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(35, 13);
            this.lblindice.TabIndex = 3;
            this.lblindice.Text = "label1";
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(249, 206);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(35, 13);
            this.lbltexto.TabIndex = 4;
            this.lbltexto.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 376);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lblindice);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtalimento);
            this.Controls.Add(this.cmbalimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbalimentos;
        private System.Windows.Forms.TextBox txtalimento;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lblindice;
        private System.Windows.Forms.Label lbltexto;
    }
}

