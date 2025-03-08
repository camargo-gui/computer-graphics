using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class Form1 : Form
    {
        private Bitmap imagemOriginal;
        private Bitmap imagemAtual;

        public Form1()
        {
            InitializeComponent();
            this.Padding = new Padding(50, 0, 0, 0);
            this.WindowState = FormWindowState.Maximized;
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void BotaoCarregarImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialogoAbrir = new OpenFileDialog())
            {
                dialogoAbrir.Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp";
                if (dialogoAbrir.ShowDialog() == DialogResult.OK)
                {
                    imagemOriginal = new Bitmap(dialogoAbrir.FileName);
                    imagemAtual = new Bitmap(imagemOriginal);
                    imgOriginal.Image = imagemAtual;
                    AtualizarMiniaturas(imagemAtual);
                    barraBrilho.Value = 0;
                    barraMatiz.Value = 0;
                }
            }
        }

        private void BotaoConverterLuminancia_Click(object sender, EventArgs e)
        {
            if (imagemAtual == null) return;
            Bitmap temp = new Bitmap(imagemAtual.Width, imagemAtual.Height);
            for (int y = 0; y < imagemAtual.Height; y++)
            {
                for (int x = 0; x < imagemAtual.Width; x++)
                {
                    Color cor = imagemAtual.GetPixel(x, y);
                    int cinza = (int)(0.299 * cor.R + 0.587 * cor.G + 0.114 * cor.B);
                    cinza = Math.Max(0, Math.Min(255, cinza));
                    temp.SetPixel(x, y, Color.FromArgb(cinza, cinza, cinza));
                }
            }
            imagemAtual = temp;
            imgOriginal.Image = imagemAtual;
            AtualizarMiniaturas(imagemAtual);
        }

        private void BotaoResetar_Click(object sender, EventArgs e)
        {
            if (imagemOriginal == null) return;
            imagemAtual = new Bitmap(imagemOriginal);
            imgOriginal.Image = imagemAtual;
            barraBrilho.Value = 0;
            barraMatiz.Value = 0;
            AtualizarMiniaturas(imagemAtual);
        }

        private void BotaoAplicarIntervaloMatiz_Click(object sender, EventArgs e)
        {
            if (imagemOriginal == null) return;
            double minH = 0;
            double maxH = 360;
            double.TryParse(txtMatizMin.Text, out minH);
            double.TryParse(txtMatizMax.Text, out maxH);
            Bitmap temp = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
            for (int y = 0; y < imagemOriginal.Height; y++)
            {
                for (int x = 0; x < imagemOriginal.Width; x++)
                {
                    Color cor = imagemOriginal.GetPixel(x, y);
                    double H, S, I;
                    ConverterRGBParaHSI(cor.R, cor.G, cor.B, out H, out S, out I);
                    if (H >= minH && H <= maxH)
                    {
                        temp.SetPixel(x, y, cor);
                    }
                    else
                    {
                        temp.SetPixel(x, y, Color.Black);
                    }
                }
            }
            imagemAtual = temp;
            imgOriginal.Image = imagemAtual;
            AtualizarMiniaturas(imagemAtual);
        }

        private void ImagemOriginal_MouseMove(object sender, MouseEventArgs e)
        {
            if (imagemAtual == null) return;
            Point pt = TraduzirPosicaoMouse(imgOriginal, e.Location);
            if (pt.X < 0 || pt.X >= imagemAtual.Width || pt.Y < 0 || pt.Y >= imagemAtual.Height)
                return;
            Color cor = imagemAtual.GetPixel(pt.X, pt.Y);
            int r = cor.R;
            int g = cor.G;
            int b = cor.B;
            int cC = 255 - r;
            int cM = 255 - g;
            int cY = 255 - b;
            double h, s, i;
            ConverterRGBParaHSI(r, g, b, out h, out s, out i);
            string info = $"RGB({r}, {g}, {b}) | CMY({cC}, {cM}, {cY}) | HSI(H={h:F1}, S={s:F1}, I={i:F1})";
            lblInfo.Text = info;
        }

        private void BarraBrilho_Scroll(object sender, EventArgs e)
        {
            if (imagemOriginal == null) return;
            double brilho = barraBrilho.Value;
            Bitmap temp = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
            for (int y = 0; y < imagemOriginal.Height; y++)
            {
                for (int x = 0; x < imagemOriginal.Width; x++)
                {
                    Color cor = imagemOriginal.GetPixel(x, y);
                    double H, S, I;
                    ConverterRGBParaHSI(cor.R, cor.G, cor.B, out H, out S, out I);
                    I = Math.Max(0, Math.Min(255, I + brilho));
                    Color novaCor = ConverterHSIParaRGB(H, S, I);
                    temp.SetPixel(x, y, novaCor);
                }
            }
            double mudancaMatiz = barraMatiz.Value;
            if (Math.Abs(mudancaMatiz) > 0.001)
            {
                temp = AplicarMudancaMatiz(temp, mudancaMatiz);
            }
            imagemAtual = temp;
            imgOriginal.Image = imagemAtual;
            AtualizarMiniaturas(imagemAtual);
        }

        private void BarraMatiz_Scroll(object sender, EventArgs e)
        {
            if (imagemOriginal == null) return;
            double mudancaMatiz = barraMatiz.Value;
            int brilho = barraBrilho.Value;
            Bitmap temp = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
            for (int y = 0; y < imagemOriginal.Height; y++)
            {
                for (int x = 0; x < imagemOriginal.Width; x++)
                {
                    Color cor = imagemOriginal.GetPixel(x, y);
                    int r = cor.R + brilho;
                    int g = cor.G + brilho;
                    int b = cor.B + brilho;
                    r = Math.Max(0, Math.Min(255, r));
                    g = Math.Max(0, Math.Min(255, g));
                    b = Math.Max(0, Math.Min(255, b));
                    temp.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            temp = AplicarMudancaMatiz(temp, mudancaMatiz);
            imagemAtual = temp;
            imgOriginal.Image = imagemAtual;
            AtualizarMiniaturas(imagemAtual);
        }

        private Point TraduzirPosicaoMouse(PictureBox pic, Point mouse)
        {
            if (pic.Image == null) return new Point(-1, -1);
            float proporcaoImagem = (float)pic.Image.Width / pic.Image.Height;
            float proporcaoCaixa = (float)pic.Width / pic.Height;
            int larguraImg, alturaImg, offsetX, offsetY;
            if (proporcaoImagem > proporcaoCaixa)
            {
                larguraImg = pic.Width;
                alturaImg = (int)(pic.Width / proporcaoImagem);
                offsetX = 0;
                offsetY = (pic.Height - alturaImg) / 2;
            }
            else
            {
                alturaImg = pic.Height;
                larguraImg = (int)(pic.Height * proporcaoImagem);
                offsetX = (pic.Width - larguraImg) / 2;
                offsetY = 0;
            }
            int mx = mouse.X - offsetX;
            int my = mouse.Y - offsetY;
            if (mx < 0 || my < 0 || mx >= larguraImg || my >= alturaImg)
                return new Point(-1, -1);
            float rx = mx / (float)larguraImg;
            float ry = my / (float)alturaImg;
            int px = (int)(rx * pic.Image.Width);
            int py = (int)(ry * pic.Image.Height);
            return new Point(px, py);
        }

        private void ConverterRGBParaHSI(int R, int G, int B, out double H, out double S, out double I)
        {
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;
            double num = 0.5 * ((r - g) + (r - b));
            double den = Math.Sqrt((r - g) * (r - g) + (r - b) * (g - b));
            double theta = 0;
            if (den != 0)
            {
                double acosValue = num / den;
                if (acosValue > 1.0) acosValue = 1.0;
                if (acosValue < -1.0) acosValue = -1.0;
                theta = Math.Acos(acosValue);
            }
            if (b > g) theta = 2.0 * Math.PI - theta;
            H = theta * 180.0 / Math.PI;
            double minVal = Math.Min(r, Math.Min(g, b));
            double soma = r + g + b;
            S = (soma == 0) ? 0 : 1 - (3 * minVal / soma);
            double intensidade = soma / 3.0;
            S *= 100.0;
            I = intensidade * 255.0;
        }

        private Color ConverterHSIParaRGB(double H, double S, double I)
        {
            double h = H * Math.PI / 180.0;
            double s = S / 100.0;
            double i = I / 255.0;
            double r = 0, g = 0, b = 0;
            if (h < 0) h += 2.0 * Math.PI;
            double z = 1.0 - Math.Abs((h / (Math.PI / 3.0)) % 2.0 - 1.0);
            double c = (3 * i * s) / (1 + z);
            double x = c * z;
            double hDeg = H;
            double m = i * (1 - s);
            if (hDeg >= 0 && hDeg < 120)
            {
                r = c + m;
                g = x + m;
                b = m;
            }
            else if (hDeg >= 120 && hDeg < 240)
            {
                r = m;
                g = c + m;
                b = x + m;
            }
            else
            {
                r = x + m;
                g = m;
                b = c + m;
            }
            int R = (int)Math.Round(r * 255.0);
            int G = (int)Math.Round(g * 255.0);
            int B = (int)Math.Round(b * 255.0);
            R = Math.Max(0, Math.Min(255, R));
            G = Math.Max(0, Math.Min(255, G));
            B = Math.Max(0, Math.Min(255, B));
            return Color.FromArgb(R, G, B);
        }

        private void AtualizarMiniaturas(Bitmap origem)
        {
            if (origem == null) return;
            imgCinzaVermelho.Image = CriarCanalCinzaRGB(origem, 'R');
            imgCinzaVerde.Image = CriarCanalCinzaRGB(origem, 'G');
            imgCinzaAzul.Image = CriarCanalCinzaRGB(origem, 'B');
            imgCinzaMatiz.Image = CriarCanalCinzaHSI(origem, 'H');
            imgCinzaSaturacao.Image = CriarCanalCinzaHSI(origem, 'S');
            imgCinzaIntensidade.Image = CriarCanalCinzaHSI(origem, 'I');
        }

        private Bitmap CriarCanalCinzaRGB(Bitmap src, char canal)
        {
            Bitmap cinza = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color cor = src.GetPixel(x, y);
                    int valor = 0;
                    switch (canal)
                    {
                        case 'R': valor = cor.R; break;
                        case 'G': valor = cor.G; break;
                        case 'B': valor = cor.B; break;
                    }
                    cinza.SetPixel(x, y, Color.FromArgb(valor, valor, valor));
                }
            }
            return cinza;
        }

        private Bitmap CriarCanalCinzaHSI(Bitmap src, char canal)
        {
            Bitmap cinza = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color cor = src.GetPixel(x, y);
                    double H, S, I;
                    ConverterRGBParaHSI(cor.R, cor.G, cor.B, out H, out S, out I);
                    double valor = 0;
                    switch (canal)
                    {
                        case 'H': valor = (H / 360.0) * 255.0; break;
                        case 'S': valor = (S / 100.0) * 255.0; break;
                        case 'I': valor = I; break;
                    }
                    int v = (int)Math.Round(valor);
                    v = Math.Max(0, Math.Min(255, v));
                    cinza.SetPixel(x, y, Color.FromArgb(v, v, v));
                }
            }
            return cinza;
        }

        private Bitmap AplicarMudancaMatiz(Bitmap src, double mudancaMatiz)
        {
            Bitmap resultado = new Bitmap(src.Width, src.Height);
            for (int y = 0; y < src.Height; y++)
            {
                for (int x = 0; x < src.Width; x++)
                {
                    Color cor = src.GetPixel(x, y);
                    double H, S, I;
                    ConverterRGBParaHSI(cor.R, cor.G, cor.B, out H, out S, out I);
                    H += mudancaMatiz;
                    if (H < 0) H += 360.0;
                    if (H >= 360) H -= 360.0;
                    Color novaCor = ConverterHSIParaRGB(H, S, I);
                    resultado.SetPixel(x, y, novaCor);
                }
            }
            return resultado;
        }

        private void ImagemOriginal_Click(object sender, EventArgs e)
        {
        }
    }
}
