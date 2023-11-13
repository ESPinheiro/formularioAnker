namespace FormFormulario
{
    partial class Form2
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
            this.textBoxDados = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnDependentes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDados
            // 
            this.textBoxDados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDados.Location = new System.Drawing.Point(0, 1);
            this.textBoxDados.Multiline = true;
            this.textBoxDados.Name = "textBoxDados";
            this.textBoxDados.Size = new System.Drawing.Size(800, 449);
            this.textBoxDados.TabIndex = 0;
            // 
            // btnSalva
            // 
            this.btnSalva.BackColor = System.Drawing.Color.Yellow;
            this.btnSalva.Location = new System.Drawing.Point(708, 407);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(92, 43);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "Salvar";
            this.btnSalva.UseVisualStyleBackColor = false;
            this.btnSalva.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnDependentes
            // 
            this.btnDependentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDependentes.Location = new System.Drawing.Point(708, 354);
            this.btnDependentes.Name = "btnDependentes";
            this.btnDependentes.Size = new System.Drawing.Size(92, 47);
            this.btnDependentes.TabIndex = 2;
            this.btnDependentes.Text = "INCLUIR DEPENDENTE";
            this.btnDependentes.UseVisualStyleBackColor = false;
            this.btnDependentes.Click += new System.EventHandler(this.btnDependentes_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDependentes);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.textBoxDados);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDados;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnDependentes;
    }
}