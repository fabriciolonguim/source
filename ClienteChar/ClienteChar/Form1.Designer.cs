
namespace ClienteChar
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
            this.components = new System.ComponentModel.Container();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtVisitante = new System.Windows.Forms.TextBox();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.btnConectar = new System.Windows.Forms.Button();
            this.textB = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(22, 35);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(306, 26);
            this.txtIp.TabIndex = 0;
            this.txtIp.Text = "127.0.0.1";
            // 
            // txtVisitante
            // 
            this.txtVisitante.Location = new System.Drawing.Point(22, 98);
            this.txtVisitante.Name = "txtVisitante";
            this.txtVisitante.Size = new System.Drawing.Size(306, 26);
            this.txtVisitante.TabIndex = 1;
            this.txtVisitante.Text = "Visitante";
            // 
            // nPort
            // 
            this.nPort.Location = new System.Drawing.Point(423, 35);
            this.nPort.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Size = new System.Drawing.Size(223, 26);
            this.nPort.TabIndex = 2;
            this.nPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnConectar.Location = new System.Drawing.Point(423, 93);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(207, 37);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // textB
            // 
            this.textB.Location = new System.Drawing.Point(22, 534);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(435, 26);
            this.textB.TabIndex = 5;
            this.textB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEnviar.Location = new System.Drawing.Point(502, 534);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(128, 40);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(252, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "não conectado";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(22, 154);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(624, 358);
            this.txtLog.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.nPort);
            this.Controls.Add(this.txtVisitante);
            this.Controls.Add(this.txtIp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Green;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Cliente de Char";
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtVisitante;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLog;
    }
}

