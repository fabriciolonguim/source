
namespace Criptografia
{
    partial class Criptografia
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCriptografia = new System.Windows.Forms.Button();
            this.btnComparar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCriptografia
            // 
            this.btnCriptografia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptografia.Location = new System.Drawing.Point(144, 503);
            this.btnCriptografia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCriptografia.Name = "btnCriptografia";
            this.btnCriptografia.Size = new System.Drawing.Size(296, 90);
            this.btnCriptografia.TabIndex = 0;
            this.btnCriptografia.Text = "Criptografar";
            this.btnCriptografia.UseVisualStyleBackColor = true;
            this.btnCriptografia.Click += new System.EventHandler(this.btnCriptografia_Click);
            // 
            // btnComparar
            // 
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.Location = new System.Drawing.Point(675, 503);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(296, 90);
            this.btnComparar.TabIndex = 1;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(18, 658);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(1164, 88);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEntrada
            // 
            this.txtEntrada.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtEntrada.Location = new System.Drawing.Point(40, 20);
            this.txtEntrada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEntrada.Multiline = true;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(1140, 187);
            this.txtEntrada.TabIndex = 3;
            // 
            // txtSaida
            // 
            this.txtSaida.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.txtSaida.Location = new System.Drawing.Point(40, 256);
            this.txtSaida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSaida.Multiline = true;
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.ReadOnly = true;
            this.txtSaida.Size = new System.Drawing.Size(1140, 187);
            this.txtSaida.TabIndex = 4;
            // 
            // Criptografia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 762);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnCriptografia);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Criptografia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriptografia;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSaida;
    }
}

