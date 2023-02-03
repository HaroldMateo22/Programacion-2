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
            this.button9 = new System.Windows.Forms.Button();
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.panelnumerico = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btndiv = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel1.Controls.Add(this.button9);
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
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(303, 238);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 40);
            this.button9.TabIndex = 4;
            this.button9.UseVisualStyleBackColor = false;
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
            this.flowLayoutPanel2.Controls.Add(this.button5);
            this.flowLayoutPanel2.Controls.Add(this.button6);
            this.flowLayoutPanel2.Controls.Add(this.button7);
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
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(3, 64);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 55);
            this.button5.TabIndex = 2;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(3, 125);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 55);
            this.button6.TabIndex = 3;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(3, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 55);
            this.button7.TabIndex = 4;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = false;
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
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 295);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(183, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "AC";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(64, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 1;
            this.button2.Text = "%";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(125, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 2;
            this.button3.Text = "OFF";
            this.button3.UseVisualStyleBackColor = false;
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
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtpantalla;
        private System.Windows.Forms.FlowLayoutPanel panelnumerico;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lbloperacion;
    }
}

