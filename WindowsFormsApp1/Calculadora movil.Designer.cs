namespace WindowsFormsApp1
{
    partial class Ejercicio6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio6));
            this.lblejercicio = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lbloperacion = new System.Windows.Forms.Label();
            this.btncopiar = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnborrar = new System.Windows.Forms.Button();
            this.btnporcent = new System.Windows.Forms.Button();
            this.btnoff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblejercicio
            // 
            this.lblejercicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblejercicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblejercicio.Location = new System.Drawing.Point(0, 0);
            this.lblejercicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblejercicio.Name = "lblejercicio";
            this.lblejercicio.Size = new System.Drawing.Size(207, 654);
            this.lblejercicio.TabIndex = 0;
            this.lblejercicio.Text = "Ejercicio 6";
            this.lblejercicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblnum1);
            this.panel1.Controls.Add(this.lbloperacion);
            this.panel1.Controls.Add(this.btncopiar);
            this.panel1.Controls.Add(this.txtpantalla);
            this.panel1.Controls.Add(this.panelnumerico);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(207, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 654);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblnum1
            // 
            this.lblnum1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblnum1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnum1.Location = new System.Drawing.Point(300, 148);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(248, 39);
            this.lblnum1.TabIndex = 6;
            this.lblnum1.Text = "0";
            this.lblnum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblnum1.Visible = false;
            // 
            // lbloperacion
            // 
            this.lbloperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbloperacion.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloperacion.ForeColor = System.Drawing.Color.Orange;
            this.lbloperacion.Location = new System.Drawing.Point(412, 187);
            this.lbloperacion.Name = "lbloperacion";
            this.lbloperacion.Size = new System.Drawing.Size(136, 39);
            this.lbloperacion.TabIndex = 5;
            this.lbloperacion.Text = "0";
            this.lbloperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbloperacion.Visible = false;
            // 
            // btncopiar
            // 
            this.btncopiar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncopiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncopiar.BackgroundImage")));
            this.btncopiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncopiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncopiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncopiar.FlatAppearance.BorderSize = 0;
            this.btncopiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncopiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncopiar.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncopiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncopiar.Location = new System.Drawing.Point(303, 238);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(40, 40);
            this.btncopiar.TabIndex = 4;
            this.btncopiar.UseVisualStyleBackColor = false;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // txtpantalla
            // 
            this.txtpantalla.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpantalla.Font = new System.Drawing.Font("Consolas", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpantalla.ForeColor = System.Drawing.SystemColors.Window;
            this.txtpantalla.Location = new System.Drawing.Point(346, 226);
            this.txtpantalla.MaxLength = 7;
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.ReadOnly = true;
            this.txtpantalla.Size = new System.Drawing.Size(202, 63);
            this.txtpantalla.TabIndex = 3;
            this.txtpantalla.Text = "0";
            this.txtpantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelnumerico
            // 
            this.panelnumerico.Location = new System.Drawing.Point(300, 363);
            this.panelnumerico.Name = "panelnumerico";
            this.panelnumerico.Size = new System.Drawing.Size(186, 241);
            this.panelnumerico.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btndiv);
            this.flowLayoutPanel2.Controls.Add(this.btnmult);
            this.flowLayoutPanel2.Controls.Add(this.btnresta);
            this.flowLayoutPanel2.Controls.Add(this.btnsuma);
            this.flowLayoutPanel2.Controls.Add(this.btnigual);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(489, 295);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(59, 309);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btndiv
            // 
            this.btndiv.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndiv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndiv.BackgroundImage")));
            this.btndiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndiv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndiv.FlatAppearance.BorderSize = 0;
            this.btndiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndiv.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndiv.Location = new System.Drawing.Point(3, 3);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(55, 55);
            this.btndiv.TabIndex = 1;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = false;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmult.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmult.BackgroundImage")));
            this.btnmult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmult.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnmult.FlatAppearance.BorderSize = 0;
            this.btnmult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnmult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmult.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnmult.Location = new System.Drawing.Point(3, 64);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(55, 55);
            this.btnmult.TabIndex = 2;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnresta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnresta.BackgroundImage")));
            this.btnresta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnresta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnresta.FlatAppearance.BorderSize = 0;
            this.btnresta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnresta.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnresta.Location = new System.Drawing.Point(3, 125);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(55, 55);
            this.btnresta.TabIndex = 3;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnsuma
            // 
            this.btnsuma.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsuma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsuma.BackgroundImage")));
            this.btnsuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsuma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsuma.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsuma.FlatAppearance.BorderSize = 0;
            this.btnsuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsuma.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsuma.Location = new System.Drawing.Point(3, 186);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(55, 55);
            this.btnsuma.TabIndex = 4;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = false;
            this.btnsuma.Click += new System.EventHandler(this.btnsuma_Click);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnigual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnigual.BackgroundImage")));
            this.btnigual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnigual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnigual.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnigual.FlatAppearance.BorderSize = 0;
            this.btnigual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnigual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnigual.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnigual.Location = new System.Drawing.Point(3, 247);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(55, 55);
            this.btnigual.TabIndex = 5;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnborrar);
            this.flowLayoutPanel1.Controls.Add(this.btnporcent);
            this.flowLayoutPanel1.Controls.Add(this.btnoff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 295);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnborrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnborrar.BackgroundImage")));
            this.btnborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnborrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnborrar.FlatAppearance.BorderSize = 0;
            this.btnborrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrar.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnborrar.Location = new System.Drawing.Point(3, 3);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(55, 55);
            this.btnborrar.TabIndex = 0;
            this.btnborrar.Text = "AC";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // btnporcent
            // 
            this.btnporcent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnporcent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnporcent.BackgroundImage")));
            this.btnporcent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnporcent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnporcent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnporcent.FlatAppearance.BorderSize = 0;
            this.btnporcent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnporcent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnporcent.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnporcent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnporcent.Location = new System.Drawing.Point(64, 3);
            this.btnporcent.Name = "btnporcent";
            this.btnporcent.Size = new System.Drawing.Size(55, 55);
            this.btnporcent.TabIndex = 1;
            this.btnporcent.Text = "%";
            this.btnporcent.UseVisualStyleBackColor = false;
            this.btnporcent.Click += new System.EventHandler(this.btnporcent_Click);
            // 
            // btnoff
            // 
            this.btnoff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnoff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnoff.BackgroundImage")));
            this.btnoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoff.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnoff.FlatAppearance.BorderSize = 0;
            this.btnoff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoff.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnoff.Location = new System.Drawing.Point(125, 3);
            this.btnoff.Name = "btnoff";
            this.btnoff.Size = new System.Drawing.Size(55, 55);
            this.btnoff.TabIndex = 2;
            this.btnoff.Text = "OFF";
            this.btnoff.UseVisualStyleBackColor = false;
            this.btnoff.Click += new System.EventHandler(this.btnoff_Click);
            // 
            // Ejercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1161, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblejercicio);
            this.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Ejercicio6";
            this.Text = "CalculadoraM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblejercicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.TextBox txtpantalla;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.Button btnporcent;
        private System.Windows.Forms.Button btnoff;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lbloperacion;
    }
}

