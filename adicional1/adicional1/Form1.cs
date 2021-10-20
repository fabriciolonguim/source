using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adicional1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           

            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int nr;
            nr = x.Next(1, 6);

            if (lblUm.Text == "0")
            {
                lblUm.Text = nr.ToString();
                string img = nr.ToString()+".png";
                pictureBox1.ImageLocation = img; //= System.Drawing.Image.FromFile(img);
            } else
            {
                lblDois.Text = nr.ToString();
                string img = nr.ToString() + ".png";
                pictureBox2.ImageLocation = img;
            }

            int j1 = int.Parse(lblUm.Text);
            int j2 = int.Parse(lblDois.Text);

            if(j2 != 0)
            {
                if (j1 > j2)
                {
                    lblResultado.Text = "O jogador 1 é o campeão!";
                    lblResultado.Visible = true;
                }
                else if (j1 < j2)
                {
                    lblResultado.Text = "O jagador 2 é o campeão!";
                    lblResultado.Visible = true;
                }
                else
                {
                    lblResultado.Text = "Houve um empate!";
                    lblResultado.Visible = true;
                }

                btnUm.Enabled = false;
                btnNovamente.Visible = true;
            }
           


        }

        private void txtNovamente_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            lblUm.Text = "0";
            lblDois.Text = "0";
            btnUm.Enabled = true;
            btnNovamente.Visible = false;

        }
    }
}
