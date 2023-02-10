namespace Cuantos_años_tengo
{
    partial class Form1
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
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.btncomparar = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // datetime
            // 
            this.datetime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetime.Location = new System.Drawing.Point(219, 131);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(331, 29);
            this.datetime.TabIndex = 0;
            // 
            // btncomparar
            // 
            this.btncomparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomparar.Location = new System.Drawing.Point(219, 218);
            this.btncomparar.Name = "btncomparar";
            this.btncomparar.Size = new System.Drawing.Size(331, 84);
            this.btncomparar.TabIndex = 1;
            this.btncomparar.Text = "Comparar";
            this.btncomparar.UseVisualStyleBackColor = true;
            this.btncomparar.Click += new System.EventHandler(this.btncomparar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(219, 57);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(331, 31);
            this.txtresultado.TabIndex = 2;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 439);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btncomparar);
            this.Controls.Add(this.datetime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Button btncomparar;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

