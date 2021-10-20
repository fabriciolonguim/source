
namespace coronavoucher
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
            this.txtRendaf = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.grpCampos = new System.Windows.Forms.GroupBox();
            this.txtRt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQpessoas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTlac = new System.Windows.Forms.TextBox();
            this.txtPlac = new System.Windows.Forms.TextBox();
            this.lblGestante = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTnivel = new System.Windows.Forms.TextBox();
            this.txtPnivel = new System.Windows.Forms.TextBox();
            this.lblNivelamento = new System.Windows.Forms.Label();
            this.txtTdoente = new System.Windows.Forms.TextBox();
            this.txtPdoente = new System.Windows.Forms.TextBox();
            this.lblDoente = new System.Windows.Forms.Label();
            this.txtTidoso = new System.Windows.Forms.TextBox();
            this.txtPidoso = new System.Windows.Forms.TextBox();
            this.lbldoso = new System.Windows.Forms.Label();
            this.txtTpessoas = new System.Windows.Forms.TextBox();
            this.txtPpessoas = new System.Windows.Forms.TextBox();
            this.lblTpessoas = new System.Windows.Forms.Label();
            this.txtTcrianca = new System.Windows.Forms.TextBox();
            this.txtPcrianca = new System.Windows.Forms.TextBox();
            this.lblCrianca = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSudeste = new System.Windows.Forms.RadioButton();
            this.rdbSul = new System.Windows.Forms.RadioButton();
            this.rdbCentro = new System.Windows.Forms.RadioButton();
            this.rdbNorte = new System.Windows.Forms.RadioButton();
            this.chkLg = new System.Windows.Forms.CheckBox();
            this.chkIdosos = new System.Windows.Forms.CheckBox();
            this.chkCron = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCriancas = new System.Windows.Forms.GroupBox();
            this.rdbMaisSeis = new System.Windows.Forms.RadioButton();
            this.rdbAteSeis = new System.Windows.Forms.RadioButton();
            this.rdbTres = new System.Windows.Forms.RadioButton();
            this.chkCriancas = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpCampos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCriancas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite a renda:";
            // 
            // txtRendaf
            // 
            this.txtRendaf.Location = new System.Drawing.Point(157, 54);
            this.txtRendaf.Name = "txtRendaf";
            this.txtRendaf.Size = new System.Drawing.Size(124, 27);
            this.txtRendaf.TabIndex = 2;
            this.txtRendaf.TextChanged += new System.EventHandler(this.txtRendaf_TextChanged);
            this.txtRendaf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRendaf_KeyPress);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(328, 52);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(105, 29);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // grpCampos
            // 
            this.grpCampos.Controls.Add(this.txtRt);
            this.grpCampos.Controls.Add(this.label11);
            this.grpCampos.Controls.Add(this.txtQpessoas);
            this.grpCampos.Controls.Add(this.label2);
            this.grpCampos.Controls.Add(this.txtTlac);
            this.grpCampos.Controls.Add(this.txtPlac);
            this.grpCampos.Controls.Add(this.lblGestante);
            this.grpCampos.Controls.Add(this.btnLimpar);
            this.grpCampos.Controls.Add(this.btnFechar);
            this.grpCampos.Controls.Add(this.btnTotal);
            this.grpCampos.Controls.Add(this.txtTotal);
            this.grpCampos.Controls.Add(this.label9);
            this.grpCampos.Controls.Add(this.txtTnivel);
            this.grpCampos.Controls.Add(this.txtPnivel);
            this.grpCampos.Controls.Add(this.lblNivelamento);
            this.grpCampos.Controls.Add(this.txtTdoente);
            this.grpCampos.Controls.Add(this.txtPdoente);
            this.grpCampos.Controls.Add(this.lblDoente);
            this.grpCampos.Controls.Add(this.txtTidoso);
            this.grpCampos.Controls.Add(this.txtPidoso);
            this.grpCampos.Controls.Add(this.lbldoso);
            this.grpCampos.Controls.Add(this.txtTpessoas);
            this.grpCampos.Controls.Add(this.txtPpessoas);
            this.grpCampos.Controls.Add(this.lblTpessoas);
            this.grpCampos.Controls.Add(this.txtTcrianca);
            this.grpCampos.Controls.Add(this.txtPcrianca);
            this.grpCampos.Controls.Add(this.lblCrianca);
            this.grpCampos.Controls.Add(this.groupBox1);
            this.grpCampos.Controls.Add(this.chkLg);
            this.grpCampos.Controls.Add(this.chkIdosos);
            this.grpCampos.Controls.Add(this.chkCron);
            this.grpCampos.Controls.Add(this.label3);
            this.grpCampos.Controls.Add(this.grpCriancas);
            this.grpCampos.Controls.Add(this.chkCriancas);
            this.grpCampos.Enabled = false;
            this.grpCampos.Location = new System.Drawing.Point(27, 133);
            this.grpCampos.Name = "grpCampos";
            this.grpCampos.Size = new System.Drawing.Size(700, 639);
            this.grpCampos.TabIndex = 4;
            this.grpCampos.TabStop = false;
            this.grpCampos.Visible = false;
            // 
            // txtRt
            // 
            this.txtRt.Enabled = false;
            this.txtRt.Location = new System.Drawing.Point(515, 223);
            this.txtRt.Name = "txtRt";
            this.txtRt.Size = new System.Drawing.Size(100, 27);
            this.txtRt.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 35;
            this.label11.Text = "Renda Total:";
            // 
            // txtQpessoas
            // 
            this.txtQpessoas.Location = new System.Drawing.Point(343, 38);
            this.txtQpessoas.Name = "txtQpessoas";
            this.txtQpessoas.Size = new System.Drawing.Size(100, 27);
            this.txtQpessoas.TabIndex = 34;
            this.txtQpessoas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQpessoas_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Quantidade de pessoas:";
            // 
            // txtTlac
            // 
            this.txtTlac.Enabled = false;
            this.txtTlac.Location = new System.Drawing.Point(515, 289);
            this.txtTlac.Name = "txtTlac";
            this.txtTlac.Size = new System.Drawing.Size(100, 27);
            this.txtTlac.TabIndex = 31;
            this.txtTlac.Visible = false;
            // 
            // txtPlac
            // 
            this.txtPlac.Enabled = false;
            this.txtPlac.Location = new System.Drawing.Point(439, 288);
            this.txtPlac.Name = "txtPlac";
            this.txtPlac.Size = new System.Drawing.Size(54, 27);
            this.txtPlac.TabIndex = 30;
            this.txtPlac.Visible = false;
            // 
            // lblGestante
            // 
            this.lblGestante.AutoSize = true;
            this.lblGestante.Location = new System.Drawing.Point(249, 291);
            this.lblGestante.Name = "lblGestante";
            this.lblGestante.Size = new System.Drawing.Size(182, 19);
            this.lblGestante.TabIndex = 29;
            this.lblGestante.Text = "Valor Gestante/Lactante:";
            this.lblGestante.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(243, 520);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(81, 33);
            this.btnLimpar.TabIndex = 28;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(68, 519);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(90, 34);
            this.btnFechar.TabIndex = 27;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(439, 520);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 33);
            this.btnTotal.TabIndex = 26;
            this.btnTotal.Text = "Calcular";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(439, 478);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 27);
            this.txtTotal.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 486);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Totais:";
            // 
            // txtTnivel
            // 
            this.txtTnivel.Enabled = false;
            this.txtTnivel.Location = new System.Drawing.Point(515, 430);
            this.txtTnivel.Name = "txtTnivel";
            this.txtTnivel.Size = new System.Drawing.Size(100, 27);
            this.txtTnivel.TabIndex = 23;
            this.txtTnivel.Visible = false;
            // 
            // txtPnivel
            // 
            this.txtPnivel.Enabled = false;
            this.txtPnivel.Location = new System.Drawing.Point(439, 429);
            this.txtPnivel.Name = "txtPnivel";
            this.txtPnivel.Size = new System.Drawing.Size(54, 27);
            this.txtPnivel.TabIndex = 22;
            this.txtPnivel.Visible = false;
            // 
            // lblNivelamento
            // 
            this.lblNivelamento.AutoSize = true;
            this.lblNivelamento.Location = new System.Drawing.Point(249, 433);
            this.lblNivelamento.Name = "lblNivelamento";
            this.lblNivelamento.Size = new System.Drawing.Size(143, 19);
            this.lblNivelamento.TabIndex = 21;
            this.lblNivelamento.Text = "Valor nivelamento:";
            this.lblNivelamento.Visible = false;
            // 
            // txtTdoente
            // 
            this.txtTdoente.Enabled = false;
            this.txtTdoente.Location = new System.Drawing.Point(515, 398);
            this.txtTdoente.Name = "txtTdoente";
            this.txtTdoente.Size = new System.Drawing.Size(100, 27);
            this.txtTdoente.TabIndex = 20;
            this.txtTdoente.Visible = false;
            // 
            // txtPdoente
            // 
            this.txtPdoente.Enabled = false;
            this.txtPdoente.Location = new System.Drawing.Point(439, 395);
            this.txtPdoente.Name = "txtPdoente";
            this.txtPdoente.Size = new System.Drawing.Size(54, 27);
            this.txtPdoente.TabIndex = 19;
            this.txtPdoente.Visible = false;
            // 
            // lblDoente
            // 
            this.lblDoente.AutoSize = true;
            this.lblDoente.Location = new System.Drawing.Point(249, 401);
            this.lblDoente.Name = "lblDoente";
            this.lblDoente.Size = new System.Drawing.Size(105, 19);
            this.lblDoente.TabIndex = 18;
            this.lblDoente.Text = "Valor doente:";
            this.lblDoente.Visible = false;
            // 
            // txtTidoso
            // 
            this.txtTidoso.Enabled = false;
            this.txtTidoso.Location = new System.Drawing.Point(515, 358);
            this.txtTidoso.Name = "txtTidoso";
            this.txtTidoso.Size = new System.Drawing.Size(100, 27);
            this.txtTidoso.TabIndex = 17;
            this.txtTidoso.Visible = false;
            // 
            // txtPidoso
            // 
            this.txtPidoso.Enabled = false;
            this.txtPidoso.Location = new System.Drawing.Point(439, 358);
            this.txtPidoso.Name = "txtPidoso";
            this.txtPidoso.Size = new System.Drawing.Size(54, 27);
            this.txtPidoso.TabIndex = 16;
            this.txtPidoso.Visible = false;
            // 
            // lbldoso
            // 
            this.lbldoso.AutoSize = true;
            this.lbldoso.Location = new System.Drawing.Point(249, 358);
            this.lbldoso.Name = "lbldoso";
            this.lbldoso.Size = new System.Drawing.Size(95, 19);
            this.lbldoso.TabIndex = 15;
            this.lbldoso.Text = "Valor idoso:";
            this.lbldoso.Visible = false;
            // 
            // txtTpessoas
            // 
            this.txtTpessoas.Enabled = false;
            this.txtTpessoas.Location = new System.Drawing.Point(515, 320);
            this.txtTpessoas.Name = "txtTpessoas";
            this.txtTpessoas.Size = new System.Drawing.Size(100, 27);
            this.txtTpessoas.TabIndex = 14;
            this.txtTpessoas.Visible = false;
            // 
            // txtPpessoas
            // 
            this.txtPpessoas.Enabled = false;
            this.txtPpessoas.Location = new System.Drawing.Point(439, 319);
            this.txtPpessoas.Name = "txtPpessoas";
            this.txtPpessoas.Size = new System.Drawing.Size(54, 27);
            this.txtPpessoas.TabIndex = 13;
            this.txtPpessoas.Visible = false;
            // 
            // lblTpessoas
            // 
            this.lblTpessoas.AutoSize = true;
            this.lblTpessoas.Location = new System.Drawing.Point(249, 323);
            this.lblTpessoas.Name = "lblTpessoas";
            this.lblTpessoas.Size = new System.Drawing.Size(153, 19);
            this.lblTpessoas.TabIndex = 12;
            this.lblTpessoas.Text = "Valor Total Pessoas:";
            this.lblTpessoas.Visible = false;
            this.lblTpessoas.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtTcrianca
            // 
            this.txtTcrianca.Enabled = false;
            this.txtTcrianca.Location = new System.Drawing.Point(515, 258);
            this.txtTcrianca.Name = "txtTcrianca";
            this.txtTcrianca.Size = new System.Drawing.Size(100, 27);
            this.txtTcrianca.TabIndex = 11;
            this.txtTcrianca.Visible = false;
            // 
            // txtPcrianca
            // 
            this.txtPcrianca.Enabled = false;
            this.txtPcrianca.Location = new System.Drawing.Point(439, 258);
            this.txtPcrianca.Name = "txtPcrianca";
            this.txtPcrianca.Size = new System.Drawing.Size(54, 27);
            this.txtPcrianca.TabIndex = 10;
            this.txtPcrianca.Visible = false;
            // 
            // lblCrianca
            // 
            this.lblCrianca.AutoSize = true;
            this.lblCrianca.Location = new System.Drawing.Point(249, 261);
            this.lblCrianca.Name = "lblCrianca";
            this.lblCrianca.Size = new System.Drawing.Size(116, 19);
            this.lblCrianca.TabIndex = 9;
            this.lblCrianca.Text = "Valor Crianças:";
            this.lblCrianca.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSudeste);
            this.groupBox1.Controls.Add(this.rdbSul);
            this.groupBox1.Controls.Add(this.rdbCentro);
            this.groupBox1.Controls.Add(this.rdbNorte);
            this.groupBox1.Location = new System.Drawing.Point(22, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Qual é a sua região:";
            // 
            // rdbSudeste
            // 
            this.rdbSudeste.AutoSize = true;
            this.rdbSudeste.Location = new System.Drawing.Point(16, 151);
            this.rdbSudeste.Name = "rdbSudeste";
            this.rdbSudeste.Size = new System.Drawing.Size(82, 23);
            this.rdbSudeste.TabIndex = 3;
            this.rdbSudeste.TabStop = true;
            this.rdbSudeste.Text = "Sudeste";
            this.rdbSudeste.UseVisualStyleBackColor = true;
            // 
            // rdbSul
            // 
            this.rdbSul.AutoSize = true;
            this.rdbSul.Location = new System.Drawing.Point(16, 121);
            this.rdbSul.Name = "rdbSul";
            this.rdbSul.Size = new System.Drawing.Size(49, 23);
            this.rdbSul.TabIndex = 2;
            this.rdbSul.TabStop = true;
            this.rdbSul.Text = "Sul";
            this.rdbSul.UseVisualStyleBackColor = true;
            // 
            // rdbCentro
            // 
            this.rdbCentro.AutoSize = true;
            this.rdbCentro.Location = new System.Drawing.Point(16, 80);
            this.rdbCentro.Name = "rdbCentro";
            this.rdbCentro.Size = new System.Drawing.Size(120, 23);
            this.rdbCentro.TabIndex = 1;
            this.rdbCentro.TabStop = true;
            this.rdbCentro.Text = "Centro-Oeste";
            this.rdbCentro.UseVisualStyleBackColor = true;
            // 
            // rdbNorte
            // 
            this.rdbNorte.AutoSize = true;
            this.rdbNorte.Location = new System.Drawing.Point(16, 40);
            this.rdbNorte.Name = "rdbNorte";
            this.rdbNorte.Size = new System.Drawing.Size(135, 23);
            this.rdbNorte.TabIndex = 0;
            this.rdbNorte.TabStop = true;
            this.rdbNorte.Text = "Norte/Nordeste";
            this.rdbNorte.UseVisualStyleBackColor = true;
            // 
            // chkLg
            // 
            this.chkLg.AutoSize = true;
            this.chkLg.Location = new System.Drawing.Point(486, 139);
            this.chkLg.Name = "chkLg";
            this.chkLg.Size = new System.Drawing.Size(175, 23);
            this.chkLg.TabIndex = 7;
            this.chkLg.Text = "Gestante ou Lactante";
            this.chkLg.UseVisualStyleBackColor = true;
            // 
            // chkIdosos
            // 
            this.chkIdosos.AutoSize = true;
            this.chkIdosos.Location = new System.Drawing.Point(486, 110);
            this.chkIdosos.Name = "chkIdosos";
            this.chkIdosos.Size = new System.Drawing.Size(75, 23);
            this.chkIdosos.TabIndex = 6;
            this.chkIdosos.Text = "Idosos";
            this.chkIdosos.UseVisualStyleBackColor = true;
            // 
            // chkCron
            // 
            this.chkCron.AutoSize = true;
            this.chkCron.Location = new System.Drawing.Point(486, 81);
            this.chkCron.Name = "chkCron";
            this.chkCron.Size = new System.Drawing.Size(151, 23);
            this.chkCron.TabIndex = 5;
            this.chkCron.Text = "Doentes Cronicos";
            this.chkCron.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "A familia possui:";
            // 
            // grpCriancas
            // 
            this.grpCriancas.Controls.Add(this.rdbMaisSeis);
            this.grpCriancas.Controls.Add(this.rdbAteSeis);
            this.grpCriancas.Controls.Add(this.rdbTres);
            this.grpCriancas.Enabled = false;
            this.grpCriancas.Location = new System.Drawing.Point(22, 81);
            this.grpCriancas.Name = "grpCriancas";
            this.grpCriancas.Size = new System.Drawing.Size(200, 169);
            this.grpCriancas.TabIndex = 1;
            this.grpCriancas.TabStop = false;
            // 
            // rdbMaisSeis
            // 
            this.rdbMaisSeis.AutoSize = true;
            this.rdbMaisSeis.Location = new System.Drawing.Point(16, 128);
            this.rdbMaisSeis.Name = "rdbMaisSeis";
            this.rdbMaisSeis.Size = new System.Drawing.Size(103, 23);
            this.rdbMaisSeis.TabIndex = 2;
            this.rdbMaisSeis.TabStop = true;
            this.rdbMaisSeis.Text = "Mais que 6";
            this.rdbMaisSeis.UseVisualStyleBackColor = true;
            // 
            // rdbAteSeis
            // 
            this.rdbAteSeis.AutoSize = true;
            this.rdbAteSeis.Location = new System.Drawing.Point(16, 86);
            this.rdbAteSeis.Name = "rdbAteSeis";
            this.rdbAteSeis.Size = new System.Drawing.Size(51, 23);
            this.rdbAteSeis.TabIndex = 1;
            this.rdbAteSeis.TabStop = true;
            this.rdbAteSeis.Text = "4-6";
            this.rdbAteSeis.UseVisualStyleBackColor = true;
            // 
            // rdbTres
            // 
            this.rdbTres.AutoSize = true;
            this.rdbTres.Location = new System.Drawing.Point(16, 45);
            this.rdbTres.Name = "rdbTres";
            this.rdbTres.Size = new System.Drawing.Size(51, 23);
            this.rdbTres.TabIndex = 0;
            this.rdbTres.TabStop = true;
            this.rdbTres.Text = "1-3";
            this.rdbTres.UseVisualStyleBackColor = true;
            // 
            // chkCriancas
            // 
            this.chkCriancas.AutoSize = true;
            this.chkCriancas.Location = new System.Drawing.Point(22, 40);
            this.chkCriancas.Name = "chkCriancas";
            this.chkCriancas.Size = new System.Drawing.Size(134, 23);
            this.chkCriancas.TabIndex = 0;
            this.chkCriancas.Text = "Possui crianças";
            this.chkCriancas.UseVisualStyleBackColor = true;
            this.chkCriancas.CheckedChanged += new System.EventHandler(this.chkCriancas_CheckedChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(466, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 133);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 861);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpCampos);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtRendaf);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Coranavoucher";
            this.Validating += new System.ComponentModel.CancelEventHandler(this.Form1_Validating);
            this.grpCampos.ResumeLayout(false);
            this.grpCampos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCriancas.ResumeLayout(false);
            this.grpCriancas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRendaf;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox grpCampos;
        private System.Windows.Forms.Label lbldoso;
        private System.Windows.Forms.TextBox txtTpessoas;
        private System.Windows.Forms.TextBox txtPpessoas;
        private System.Windows.Forms.Label lblTpessoas;
        private System.Windows.Forms.TextBox txtTcrianca;
        private System.Windows.Forms.TextBox txtPcrianca;
        private System.Windows.Forms.Label lblCrianca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSudeste;
        private System.Windows.Forms.RadioButton rdbSul;
        private System.Windows.Forms.RadioButton rdbCentro;
        private System.Windows.Forms.RadioButton rdbNorte;
        private System.Windows.Forms.CheckBox chkLg;
        private System.Windows.Forms.CheckBox chkIdosos;
        private System.Windows.Forms.CheckBox chkCron;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCriancas;
        private System.Windows.Forms.RadioButton rdbMaisSeis;
        private System.Windows.Forms.RadioButton rdbAteSeis;
        private System.Windows.Forms.RadioButton rdbTres;
        private System.Windows.Forms.CheckBox chkCriancas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTnivel;
        private System.Windows.Forms.TextBox txtPnivel;
        private System.Windows.Forms.Label lblNivelamento;
        private System.Windows.Forms.TextBox txtTdoente;
        private System.Windows.Forms.TextBox txtPdoente;
        private System.Windows.Forms.Label lblDoente;
        private System.Windows.Forms.TextBox txtTidoso;
        private System.Windows.Forms.TextBox txtPidoso;
        private System.Windows.Forms.TextBox txtTlac;
        private System.Windows.Forms.TextBox txtPlac;
        private System.Windows.Forms.Label lblGestante;
        private System.Windows.Forms.TextBox txtQpessoas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

