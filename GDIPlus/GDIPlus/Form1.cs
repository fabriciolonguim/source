using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Criar uma folha em branco

            // Criar um desenhador

            // Utilizar o desenho ou imagem


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDesenhar_Click(object sender, EventArgs e)
        {
            // Folha em branco
            Bitmap folha = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics desenhador = Graphics.FromImage(folha);

            //desenhador.Clear(Color.DodgerBlue);
            desenhador.Clear(Color.White);

            #region Linhas

            //Brush pincel = new SolidBrush(Color.Red);

            //Pen lapis_mesmo = new Pen(pincel, 5);
            //Pen lapis2 = new Pen(Color.Black, 5);
            //Point ponto1 = new Point(100, 200);
            //Point ponto2 = new Point(400, 100);
            //Point ponto3= new Point(0, 0);
            //Point ponto4 = new Point(100, 200);

            //Point[] pontos = 
            //{
            //    new Point(50,50),
            //    new Point(250,50),
            //    new Point(250,150),
            //    new Point(100,80),
            //    new Point(85,140)
            //    //new Point(50,50),
            //}; 

            ////desenhador.DrawLine(lapis_mesmo, ponto1, ponto2);
            ////desenhador.DrawLine(lapis2, ponto3, ponto4);

            //desenhador.DrawLines(lapis_mesmo, pontos);


            #endregion

            #region Retangulos

            //Pen lapis1 = new Pen(Color.Black, 5);
            //Pen lapis2 = new Pen(Color.Aquamarine, 10);

            //Rectangle rect1 = new Rectangle(70, 50, 300, 200);
            //Rectangle rect2 = new Rectangle(50, 95, 120, 40);
            //Rectangle rect3 = new Rectangle(20, 20, 145, 100);
            //Rectangle rect4 = new Rectangle(54, 200, 250, 100);

            ////desenhador.DrawRectangle(lapis1, rect1);
            ////desenhador.DrawRectangle(lapis2, 50, 50, 250, 250);

            //Rectangle[] retangulos =
            //{
            //    rect1, rect2, rect3, rect4, new Rectangle(10, 30, 40, 50)
            //};

            ////desenhador.DrawRectangles(lapis2, retangulos);

            //Brush pincel = new SolidBrush(Color.Azure);
            //Brush pincel2 = new LinearGradientBrush(rect4, Color.Aquamarine, Color.Yellow, 90);
            //Brush pincel3 = new LinearGradientBrush(rect3, Color.Aquamarine, Color.Yellow, 45);

            ////desenhador.FillRectangle(pincel2 , rect4);
            ////desenhador.FillRectangle(pincel3, rect3);

            //desenhador.FillRectangles(pincel2, retangulos);

            #endregion

            #region Elipse e Circulos

            //Pen lapis = new Pen(Color.Black, 5);
            //Rectangle retangulo = new Rectangle(50, 50, 100, 100);
            //Brush pincel = new SolidBrush(Color.Yellow);
            //Brush pincel2 = new LinearGradientBrush(retangulo, Color.Aquamarine, Color.Yellow, 45);


            //desenhador.DrawRectangle(lapis, retangulo);
            //desenhador.DrawEllipse(lapis, retangulo);
            ////desenhador.FillEllipse(pincel, retangulo);
            ////desenhador.FillEllipse(Brushes.Gray, retangulo);
            //desenhador.FillEllipse(pincel2, retangulo);


            #endregion

            #region Poligono

            //Pen lapis = new Pen(Color.Black, 5);



            //Point[] pontos = 
            //{
            //    new Point(100,100),
            //    new Point(300, 200),
            //    new Point(250, 250),
            //    new Point(100,200)

            //};

            //desenhador.DrawPolygon(lapis, pontos);
            //Brush pincel = new LinearGradientBrush(new Rectangle(100,100,200,200), Color.Aquamarine, Color.Yellow, 45);
            ////desenhador.FillPolygon(Brushes.Blue, pontos);
            //desenhador.FillPolygon(pincel, pontos);

            #endregion

            #region Curvas

            //Pen lapis = new Pen(Color.Black, 5);

            //Point[] pontos = 
            //{
            //    new Point(100, 50),
            //    new Point(200, 150),
            //    new Point(300, 100),
            //    new Point(500, 250),
            //    new Point(300, 300)
            //};

            ////desenhador.DrawCurve(lapis, pontos, 3.5f);
            ////desenhador.DrawClosedCurve(lapis, pontos, 3.5f, FillMode.Alternate);
            //desenhador.FillClosedCurve(Brushes.Red, pontos, FillMode.Winding, 2.5f);

            #endregion

            #region Arcos

            //Pen lapis = new Pen(Color.Red, 5);


            //desenhador.DrawArc(lapis, new Rectangle(100,50, 400,250), 90f, 200f);
            //desenhador.DrawRectangle(lapis, new Rectangle(100, 50, 400, 250));

            #endregion

            #region Beziers

            //Pen lapis = new Pen(Color.DodgerBlue, 15);
            ////Point p1 = new Point(50, 300);
            ////Point p2 = new Point(200, 400);
            ////Point p3 = new Point(300, 10);
            ////Point p4 = new Point(500, 100);

            //Point[] ponts =
            //{
            //    new Point(50, 300),
            //    new Point(150, 350),
            //    new Point(300, 100),
            //    new Point(400, 150),
            //    new Point(500, 400),
            //    new Point(550, 10),
            //    new Point(600, 100)
            //};

            //desenhador.DrawBezier(lapis, p1, p2, p3, p4);
            //desenhador.DrawBeziers(lapis, ponts);

            #endregion

            #region Pie

            //Pen lapis = new Pen(Color.Black, 35);
            //Rectangle rect = new Rectangle(50, 50, 300, 300);
            //Brush pincel = new LinearGradientBrush(rect, Color.Aquamarine, Color.Yellow, 45);


            ////desenhador.DrawPie(lapis, rect, 45, 90);
            //desenhador.DrawRectangle(lapis, rect);
            //desenhador.DrawPie(lapis, rect, 0, 180);
            ////desenhador.FillPie(Brushes.DodgerBlue, rect, 0, 180);
            //desenhador.FillPie(pincel, rect, 0, 175);

            #endregion


            #region Path

            //Pen lapis = new Pen(Color.Black, 5);
            //GraphicsPath graphics = new GraphicsPath(FillMode.Alternate);
            //graphics.AddEllipse(new RectangleF(10, 10, 100, 150));
            //graphics.AddEllipse(new RectangleF(50, 50, 100, 150));
            //graphics.AddRectangle(new RectangleF(200, 50, 200, 200));

            //desenhador.DrawPath(lapis, graphics);
            //desenhador.FillPath(Brushes.Red, graphics);

            #endregion

            #region Strings

            //string texto = "Lorem Ipsum Dolor Sit Amet";
            //Font fonte = new Font("Times new Roman", 28, FontStyle.Regular, GraphicsUnit.Point);
            //Brush pincel = new LinearGradientBrush(new Rectangle(0, 0, 400, 400), Color.Aquamarine, Color.Yellow, 45);
            //Point ponto = new Point(10, 20);
            //Rectangle rect = new Rectangle(10, 20, 400, 300);
            //StringFormat alinhamentoPorExemplo = new StringFormat();

            //alinhamentoPorExemplo.Alignment = StringAlignment.Center;
            //alinhamentoPorExemplo.LineAlignment = StringAlignment.Near;
            ////alinhamentoPorExemplo.FormatFlags = StringFormatFlags.NoWrap;


            ////desenhador.DrawString(texto, fonte, Brushes.Red, ponto);
            ////desenhador.DrawString(texto, fonte, pincel, ponto);
            //desenhador.DrawRectangle(new Pen(Color.Black, 5), rect);
            //desenhador.DrawString(texto, fonte, pincel, rect, alinhamentoPorExemplo);

            #endregion


            #region Imagens

            Image image = Image.FromFile(Application.StartupPath + @"\imagens\paisagem.jpg");
            Rectangle origem = new Rectangle(0, 0, image.Width, image.Height);
            //Rectangle origem = new Rectangle(340, 140, 75, 180);
            //Rectangle destino = new Rectangle(100, 50, image.Width / 2, image.Height / 2);
            //Rectangle destino = new Rectangle(100, 50, 75, 180);
            Rectangle destino = new Rectangle(100, 50, pictureBox1.Width,pictureBox1.Height);

            Image image2 = Image.FromFile(Application.StartupPath + @"\imagens\sprites.png");
            Rectangle origem2 = new Rectangle(40, 25, 150, 200);
            Rectangle destino2 = new Rectangle(170, 170, 150, 200);


            desenhador.DrawImage(image, destino, origem, GraphicsUnit.Pixel);
            desenhador.DrawImage(image2, destino2, origem2, GraphicsUnit.Pixel);

            #endregion


            pictureBox1.BackgroundImage = folha;

            folha.Save(@"C:\Users\fabricio\Pictures\desenho.png", System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
