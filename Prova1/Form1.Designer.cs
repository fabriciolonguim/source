
namespace Prova1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFuncionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbIii = new System.Windows.Forms.RadioButton();
            this.rdbIi = new System.Windows.Forms.RadioButton();
            this.rdbI = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSim = new System.Windows.Forms.CheckBox();
            this.chkNao = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorDistancia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdicional = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do funcionário:";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Location = new System.Drawing.Point(241, 22);
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.Size = new System.Drawing.Size(184, 29);
            this.txtFuncionario.TabIndex = 1;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distância a ser percorrida:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(241, 84);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(184, 29);
            this.txtDistancia.TabIndex = 3;
            this.txtDistancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistancia_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIii);
            this.groupBox1.Controls.Add(this.rdbIi);
            this.groupBox1.Controls.Add(this.rdbI);
            this.groupBox1.Location = new System.Drawing.Point(17, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 193);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modalidade:";
            // 
            // rdbIii
            // 
            this.rdbIii.AutoSize = true;
            this.rdbIii.Location = new System.Drawing.Point(16, 146);
            this.rdbIii.Name = "rdbIii";
            this.rdbIii.Size = new System.Drawing.Size(469, 25);
            this.rdbIii.TabIndex = 2;
            this.rdbIii.TabStop = true;
            this.rdbIii.Text = "Deslocamento+ horas técnicas  + alimentação (R$ 3,00 por Km)";
            this.rdbIii.UseVisualStyleBackColor = true;
            // 
            // rdbIi
            // 
            this.rdbIi.AutoSize = true;
            this.rdbIi.Location = new System.Drawing.Point(16, 95);
            this.rdbIi.Name = "rdbIi";
            this.rdbIi.Size = new System.Drawing.Size(359, 25);
            this.rdbIi.TabIndex = 1;
            this.rdbIi.TabStop = true;
            this.rdbIi.Text = "Deslocamento e horas técnicas(R$ 2,50 por Km)";
            this.rdbIi.UseVisualStyleBackColor = true;
            // 
            // rdbI
            // 
            this.rdbI.AutoSize = true;
            this.rdbI.Location = new System.Drawing.Point(16, 40);
            this.rdbI.Name = "rdbI";
            this.rdbI.Size = new System.Drawing.Size(302, 25);
            this.rdbI.TabIndex = 0;
            this.rdbI.TabStop = true;
            this.rdbI.Text = "Apenas deslocamento(R$ 1,50  por Km)";
            this.rdbI.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Abrange horáario noturno:";
            // 
            // chkSim
            // 
            this.chkSim.AutoSize = true;
            this.chkSim.Location = new System.Drawing.Point(17, 428);
            this.chkSim.Name = "chkSim";
            this.chkSim.Size = new System.Drawing.Size(56, 25);
            this.chkSim.TabIndex = 6;
            this.chkSim.Text = "Sim";
            this.chkSim.UseVisualStyleBackColor = true;
            // 
            // chkNao
            // 
            this.chkNao.AutoSize = true;
            this.chkNao.Location = new System.Drawing.Point(116, 428);
            this.chkNao.Name = "chkNao";
            this.chkNao.Size = new System.Drawing.Size(58, 25);
            this.chkNao.TabIndex = 7;
            this.chkNao.Text = "Não";
            this.chkNao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor da distância: ";
            // 
            // txtValorDistancia
            // 
            this.txtValorDistancia.Location = new System.Drawing.Point(247, 486);
            this.txtValorDistancia.Name = "txtValorDistancia";
            this.txtValorDistancia.Size = new System.Drawing.Size(156, 29);
            this.txtValorDistancia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor adicional noturno:";
            // 
            // txtAdicional
            // 
            this.txtAdicional.Location = new System.Drawing.Point(247, 535);
            this.txtAdicional.Name = "txtAdicional";
            this.txtAdicional.Size = new System.Drawing.Size(156, 29);
            this.txtAdicional.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(247, 599);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(156, 29);
            this.txtTotal.TabIndex = 13;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(295, 654);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(97, 37);
            this.btnCalcular.TabIndex = 14;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(33, 654);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 37);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAdicional);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorDistancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkNao);
            this.Controls.Add(this.chkSim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Prova1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbIii;
        private System.Windows.Forms.RadioButton rdbIi;
        private System.Windows.Forms.RadioButton rdbI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSim;
        private System.Windows.Forms.CheckBox chkNao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorDistancia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdicional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}

