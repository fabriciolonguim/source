
namespace adicional1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUm = new System.Windows.Forms.Label();
            this.btnUm = new System.Windows.Forms.Button();
            this.lblDois = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnNovamente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUm
            // 
            this.lblUm.AutoSize = true;
            this.lblUm.Location = new System.Drawing.Point(160, 212);
            this.lblUm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUm.Name = "lblUm";
            this.lblUm.Size = new System.Drawing.Size(17, 18);
            this.lblUm.TabIndex = 0;
            this.lblUm.Text = "0";
            // 
            // btnUm
            // 
            this.btnUm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUm.Location = new System.Drawing.Point(230, 288);
            this.btnUm.Name = "btnUm";
            this.btnUm.Size = new System.Drawing.Size(130, 41);
            this.btnUm.TabIndex = 1;
            this.btnUm.Text = "Jogar";
            this.btnUm.UseVisualStyleBackColor = false;
            this.btnUm.Click += new System.EventHandler(this.btnUm_Click);
            // 
            // lblDois
            // 
            this.lblDois.AutoSize = true;
            this.lblDois.Location = new System.Drawing.Point(461, 212);
            this.lblDois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDois.Name = "lblDois";
            this.lblDois.Size = new System.Drawing.Size(17, 18);
            this.lblDois.TabIndex = 2;
            this.lblDois.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(66, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 109);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(354, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 109);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Jogador 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Jogador 2: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(143, 21);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 24);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "label3";
            this.lblResultado.Visible = false;
            // 
            // btnNovamente
            // 
            this.btnNovamente.BackColor = System.Drawing.Color.Red;
            this.btnNovamente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNovamente.Location = new System.Drawing.Point(417, 290);
            this.btnNovamente.Name = "btnNovamente";
            this.btnNovamente.Size = new System.Drawing.Size(149, 39);
            this.btnNovamente.TabIndex = 8;
            this.btnNovamente.Text = "Jogar Novamente";
            this.btnNovamente.UseVisualStyleBackColor = false;
            this.btnNovamente.Visible = false;
            this.btnNovamente.Click += new System.EventHandler(this.txtNovamente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 623);
            this.Controls.Add(this.btnNovamente);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDois);
            this.Controls.Add(this.btnUm);
            this.Controls.Add(this.lblUm);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUm;
        private System.Windows.Forms.Button btnUm;
        private System.Windows.Forms.Label lblDois;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnNovamente;
    }
}

