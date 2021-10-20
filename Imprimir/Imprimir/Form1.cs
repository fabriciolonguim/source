using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imprimir
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        int altura;
        int largura;
        int num_linhas;
        int pagina;
        int num_paginas;

        public Form1()
        {
            InitializeComponent();
            pagina = 0;
            num_paginas = 0;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;

            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() != DialogResult.Cancel)
            {
                largura = printDocument1.DefaultPageSettings.Bounds.Width;
                altura = printDocument1.DefaultPageSettings.Bounds.Height;
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
            

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            #region Parte 1

            //string texto = "Trabalhando com impressão.";
            //Font letra = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Point pontoInicial = new Point(100, 50);

            //e.Graphics.DrawString(texto,letra, pincel, pontoInicial);
            //e.Graphics.DrawString("Fabrício Longuim", letra, Brushes.Goldenrod, new Point(100, 150));
            //e.Graphics.FillRectangle(Brushes.Green, new Rectangle(120, 220, 400, 100));

            #endregion

            #region Parte 2

            //Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            //int x = printDocument1.DefaultPageSettings.Bounds.X;
            //int y = printDocument1.DefaultPageSettings.Bounds.Y;
            //int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            //int altura = printDocument1.DefaultPageSettings.Bounds.Height;

            //string titulo = "Lorem ipsum dolor sit amet";
            //Font letra = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Blue);
            //Rectangle areaTexto = new Rectangle(x + 50,y + 100, largura - 100, 100);
            //StringFormat formatoTitulo = new StringFormat();
            //formatoTitulo.Alignment = StringAlignment.Center;
            //formatoTitulo.LineAlignment = StringAlignment.Center;

            //string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent placerat, tellus a pretium aliquam, leo leo feugiat odio, in convallis mauris justo in est. Suspendisse potenti. Nunc massa nisi, gravida finibus luctus quis, iaculis sit amet dolor. Sed dui massa, blandit in nulla eget, dictum facilisis odio. Vivamus quis fermentum urna. Morbi erat leo, rhoncus ut leo a, venenatis sodales nulla. Sed egestas ultrices pharetra. Aenean vehicula risus lectus, quis ullamcorper eros laoreet ultricies. Morbi nec quam dapibus, lobortis elit eu, iaculis purus. .";
            //Font letraTitulo = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            //Brush pincelTitulo = new SolidBrush(Color.Black);
            //Rectangle areaTextoTitulo = new Rectangle(x + 50, y + 200, largura - 100, altura - 400);

            //e.Graphics.DrawString(titulo, letraTitulo, pincelTitulo, areaTextoTitulo, formatoTitulo);
            //e.Graphics.DrawString(texto, letra, pincel, areaTexto);
            //e.Graphics.DrawString(texto, letra, pincel, areaTextoTitulo);
            //e.Graphics.DrawString(texto, letra, pincel, areaTexto);


            #endregion

            #region Parte 3

            //Rectangle area = printDocument1.DefaultPageSettings.Bounds;
            //int x = printDocument1.DefaultPageSettings.Bounds.X;
            //int y = printDocument1.DefaultPageSettings.Bounds.Y;
            //int largura = printDocument1.DefaultPageSettings.Bounds.Width;
            //int altura = printDocument1.DefaultPageSettings.Bounds.Height;

            List<string> linhas = new List<string>()
            {
                "1. Lorem ipusm dollor site amet.",
                "2. Lorem ipusm dollor site amet.",
                "3. Lorem ipusm dollor site amet.",
                "4. Lorem ipusm dollor site amet.",
                "5. Lorem ipusm dollor site amet.",
                "6. Lorem ipusm dollor site amet.",
                "7. Lorem ipusm dollor site amet.",
                "8. Lorem ipusm dollor site amet.",
                "9. Lorem ipusm dollor site amet.",
                "10. Lorem ipusm dollor site amet.",
                "11. Lorem ipusm dollor site amet.",
                "12. Lorem ipusm dollor site amet.",
                "13. Lorem ipusm dollor site amet.",
                "14. Lorem ipusm dollor site amet.",
                "15. Lorem ipusm dollor site amet.",
                "16. Lorem ipusm dollor site amet.",
                "17. Lorem ipusm dollor site amet.",
                "18. Lorem ipusm dollor site amet.",
                "19. Lorem ipusm dollor site amet.",
                "20. Lorem ipusm dollor site amet.",
                "21. Lorem ipusm dollor site amet.",
                "22. Lorem ipusm dollor site amet.",
                "23. Lorem ipusm dollor site amet.",
                "24. Lorem ipusm dollor site amet.",
                "25. Lorem ipusm dollor site amet.",
                "26. Lorem ipusm dollor site amet.",
                "27. Lorem ipusm dollor site amet.",
                "28. Lorem ipusm dollor site amet.",
                "29. Lorem ipusm dollor site amet.",
                "30. Lorem ipusm dollor site amet.",
                "31. Lorem ipusm dollor site amet.",
                "32. Lorem ipusm dollor site amet.",
                "33. Lorem ipusm dollor site amet.",
                "34. Lorem ipusm dollor site amet.",
                "35. Lorem ipusm dollor site amet.",
                "36. Lorem ipusm dollor site amet.",
                "37. Lorem ipusm dollor site amet.",
                "88. Lorem ipusm dollor site amet.",
                "99. Lorem ipusm dollor site amet.",
                "40. Lorem ipusm dollor site amet."
            };

            string titulo = "Lorem ipsum dolor sit amet";
            Font letratitulo = new Font("Verdana", 24, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Brush pincelTitulo = new SolidBrush(Color.Blue);
            Rectangle areaTextoTitulo = new Rectangle(x, y, largura - 100, 100);
            StringFormat formatoTitulo = new StringFormat();
            formatoTitulo.Alignment = StringAlignment.Center;
            formatoTitulo.LineAlignment = StringAlignment.Center;

            //e.Graphics.DrawString(texto, letra, pincel, areaTextoTitulo);
            Font letra = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            Brush pincel = new SolidBrush(Color.Black);

            while (num_linhas < linhas.Count)
            {
                if (num_linhas == 0)
                {

                    e.Graphics.DrawString(titulo, letratitulo, pincelTitulo, areaTextoTitulo);
                    y += 150;
                }
                e.Graphics.DrawString(linhas[num_linhas], letra, pincel, new Point(x, y));
                y += 30;
                num_linhas++;

                if (y >= altura - 50)
                {
                    // Mudar de Pagina
                    y = 50;
                    e.HasMorePages = true;
                    num_paginas++;
                    break;
                }
            }

            #endregion
        }

        private void BtnVisualizar_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            printDocument1.Print();

            printPreviewControl1.Document = printDocument1;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (pagina > 0)
            {
                printPreviewControl1.StartPage = --pagina;
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (pagina > num_paginas)
            {
                printPreviewControl1.StartPage = ++pagina;
            }
        }

        private void btnVPadrao_Click(object sender, EventArgs e)
        {
            largura = printDocument1.DefaultPageSettings.Bounds.Width;
            altura = printDocument1.DefaultPageSettings.Bounds.Height;
            x = 50;
            y = 50;
            num_linhas = 0;
            printDocument1.Print();

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
                 
        }
    }
}
