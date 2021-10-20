
namespace Cadastro_de_Veiculos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuilometragem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtLtsComb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOperacao = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.chkConsumir = new System.Windows.Forms.CheckBox();
            this.txtRodagem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAbastecimento = new System.Windows.Forms.TextBox();
            this.chkRodagem = new System.Windows.Forms.CheckBox();
            this.chkAbastecer = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(84, 117);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 27);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(317, 117);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(153, 27);
            this.txtPlaca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(953, 117);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(121, 27);
            this.comboMarca.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(589, 117);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(261, 27);
            this.txtDescricao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Média:";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(100, 193);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(100, 27);
            this.txtMedia.TabIndex = 9;
            this.txtMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMedia_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hodômetro:";
            // 
            // txtQuilometragem
            // 
            this.txtQuilometragem.Location = new System.Drawing.Point(348, 193);
            this.txtQuilometragem.Name = "txtQuilometragem";
            this.txtQuilometragem.Size = new System.Drawing.Size(254, 27);
            this.txtQuilometragem.TabIndex = 11;
            this.txtQuilometragem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuilometragem_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade de Combustível:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(271, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(271, 56);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(41, 19);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            // 
            // txtLtsComb
            // 
            this.txtLtsComb.Location = new System.Drawing.Point(910, 193);
            this.txtLtsComb.Name = "txtLtsComb";
            this.txtLtsComb.Size = new System.Drawing.Size(110, 27);
            this.txtLtsComb.TabIndex = 15;
            this.txtLtsComb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLtsComb_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(795, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(31, 428);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 41);
            this.btnCadastrar.TabIndex = 17;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.AliceBlue;
            this.btnIniciar.ForeColor = System.Drawing.Color.Black;
            this.btnIniciar.Location = new System.Drawing.Point(210, 428);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(166, 41);
            this.btnIniciar.TabIndex = 18;
            this.btnIniciar.Text = "Iniciar Atualização";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConcluir.ForeColor = System.Drawing.Color.Black;
            this.btnConcluir.Location = new System.Drawing.Point(413, 428);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(170, 41);
            this.btnConcluir.TabIndex = 19;
            this.btnConcluir.Text = "Concluir Atualização";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Crimson;
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(610, 428);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 41);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 480);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(795, 150);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOperacao);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.chkConsumir);
            this.groupBox1.Controls.Add(this.txtRodagem);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAbastecimento);
            this.groupBox1.Controls.Add(this.chkRodagem);
            this.groupBox1.Controls.Add(this.chkAbastecer);
            this.groupBox1.Location = new System.Drawing.Point(882, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 379);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // btnOperacao
            // 
            this.btnOperacao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOperacao.ForeColor = System.Drawing.Color.White;
            this.btnOperacao.Location = new System.Drawing.Point(43, 332);
            this.btnOperacao.Name = "btnOperacao";
            this.btnOperacao.Size = new System.Drawing.Size(175, 41);
            this.btnOperacao.TabIndex = 22;
            this.btnOperacao.Text = "Cadastrar Operação";
            this.btnOperacao.UseVisualStyleBackColor = false;
            this.btnOperacao.Click += new System.EventHandler(this.btnOperacao_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(14, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 41);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // chkConsumir
            // 
            this.chkConsumir.AutoSize = true;
            this.chkConsumir.Location = new System.Drawing.Point(147, 58);
            this.chkConsumir.Name = "chkConsumir";
            this.chkConsumir.Size = new System.Drawing.Size(96, 23);
            this.chkConsumir.TabIndex = 20;
            this.chkConsumir.Text = "Consumir";
            this.chkConsumir.UseVisualStyleBackColor = true;
            this.chkConsumir.CheckedChanged += new System.EventHandler(this.chkConsumir_CheckedChanged);
            // 
            // txtRodagem
            // 
            this.txtRodagem.Enabled = false;
            this.txtRodagem.Location = new System.Drawing.Point(136, 222);
            this.txtRodagem.Name = "txtRodagem";
            this.txtRodagem.Size = new System.Drawing.Size(153, 27);
            this.txtRodagem.TabIndex = 19;
            this.txtRodagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRodagem_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Quilômetros:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Litros: ";
            // 
            // txtAbastecimento
            // 
            this.txtAbastecimento.Enabled = false;
            this.txtAbastecimento.Location = new System.Drawing.Point(109, 90);
            this.txtAbastecimento.Name = "txtAbastecimento";
            this.txtAbastecimento.Size = new System.Drawing.Size(110, 27);
            this.txtAbastecimento.TabIndex = 16;
            this.txtAbastecimento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbastecimento_KeyPress);
            // 
            // chkRodagem
            // 
            this.chkRodagem.AutoSize = true;
            this.chkRodagem.Location = new System.Drawing.Point(28, 177);
            this.chkRodagem.Name = "chkRodagem";
            this.chkRodagem.Size = new System.Drawing.Size(95, 23);
            this.chkRodagem.TabIndex = 1;
            this.chkRodagem.Text = "Rodagem";
            this.chkRodagem.UseVisualStyleBackColor = true;
            this.chkRodagem.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkAbastecer
            // 
            this.chkAbastecer.AutoSize = true;
            this.chkAbastecer.Location = new System.Drawing.Point(26, 58);
            this.chkAbastecer.Name = "chkAbastecer";
            this.chkAbastecer.Size = new System.Drawing.Size(97, 23);
            this.chkAbastecer.TabIndex = 0;
            this.chkAbastecer.Text = "Abastecer";
            this.chkAbastecer.UseVisualStyleBackColor = true;
            this.chkAbastecer.CheckedChanged += new System.EventHandler(this.chkAbastecer_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 668);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 19);
            this.label10.TabIndex = 24;
            this.label10.Text = "Digite a placa:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(413, 660);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 41);
            this.btnPesquisar.TabIndex = 25;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(169, 665);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(188, 27);
            this.txtPesquisa.TabIndex = 27;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(57, 737);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1017, 156);
            this.listBox1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 905);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLtsComb);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuilometragem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Veiculos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuilometragem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtLtsComb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRodagem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAbastecimento;
        private System.Windows.Forms.CheckBox chkRodagem;
        private System.Windows.Forms.CheckBox chkAbastecer;
        private System.Windows.Forms.CheckBox chkConsumir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnOperacao;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ListBox listBox1;
    }
}

