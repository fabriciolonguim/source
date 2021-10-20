using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Criptografia : Form
    {
        public Criptografia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCriptografia_Click(object sender, EventArgs e)
        {
            CriptoMD5 md5 = new CriptoMD5();

            txtSaida.Text = md5.RetornarMD5(txtEntrada.Text);

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            string senhaBanco = "B44EEAF37527E798A2C5CE90CDE9ED7E"; //Longuim
            string senha = txtEntrada.Text;

            CriptoMD5 md5 = new CriptoMD5();

            bool resultado = md5.CompararMD5(senha, senhaBanco);

            if (resultado)
            {
                lblResultado.Text = "Senhas Iguais";
            }
            else
            {
                lblResultado.Text = "Senha Diferentes";
            }

            
        }
    }
}
