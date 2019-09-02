namespace Alimentos
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
            this.CB_Agregar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btt_Agregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Agregar
            // 
            this.CB_Agregar.FormattingEnabled = true;
            this.CB_Agregar.Location = new System.Drawing.Point(102, 12);
            this.CB_Agregar.Name = "CB_Agregar";
            this.CB_Agregar.Size = new System.Drawing.Size(414, 21);
            this.CB_Agregar.TabIndex = 0;
            this.CB_Agregar.SelectedIndexChanged += new System.EventHandler(this.CB_Agregar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btt_Agregar
            // 
            this.btt_Agregar.Location = new System.Drawing.Point(339, 162);
            this.btt_Agregar.Name = "btt_Agregar";
            this.btt_Agregar.Size = new System.Drawing.Size(188, 30);
            this.btt_Agregar.TabIndex = 4;
            this.btt_Agregar.Text = "&Agregar";
            this.btt_Agregar.UseVisualStyleBackColor = true;
            this.btt_Agregar.Click += new System.EventHandler(this.Btt_Agregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 373);
            this.Controls.Add(this.btt_Agregar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Agregar);
            this.Name = "Form1";
            this.Text = "Alimentos - Agregar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btt_Agregar;
    }
}

