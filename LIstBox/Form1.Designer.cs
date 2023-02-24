namespace LIstBox
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
            this.lstfrutas = new System.Windows.Forms.ListBox();
            this.txtfruta = new System.Windows.Forms.TextBox();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.lblfruta = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstfrutas
            // 
            this.lstfrutas.FormattingEnabled = true;
            this.lstfrutas.Items.AddRange(new object[] {
            "Manzana",
            "Aguacate",
            "Pera"});
            this.lstfrutas.Location = new System.Drawing.Point(117, 131);
            this.lstfrutas.Name = "lstfrutas";
            this.lstfrutas.Size = new System.Drawing.Size(120, 95);
            this.lstfrutas.TabIndex = 0;
            this.lstfrutas.SelectedIndexChanged += new System.EventHandler(this.lstfrutas_SelectedIndexChanged);
            // 
            // txtfruta
            // 
            this.txtfruta.Location = new System.Drawing.Point(86, 60);
            this.txtfruta.Name = "txtfruta";
            this.txtfruta.Size = new System.Drawing.Size(192, 20);
            this.txtfruta.TabIndex = 1;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(117, 283);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(120, 23);
            this.btnadicionar.TabIndex = 2;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // lblfruta
            // 
            this.lblfruta.AutoSize = true;
            this.lblfruta.Location = new System.Drawing.Point(156, 98);
            this.lblfruta.Name = "lblfruta";
            this.lblfruta.Size = new System.Drawing.Size(35, 13);
            this.lblfruta.TabIndex = 3;
            this.lblfruta.Text = "label1";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(117, 347);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(120, 23);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 434);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.lblfruta);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtfruta);
            this.Controls.Add(this.lstfrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstfrutas;
        private System.Windows.Forms.TextBox txtfruta;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label lblfruta;
        private System.Windows.Forms.Button btneliminar;
    }
}

