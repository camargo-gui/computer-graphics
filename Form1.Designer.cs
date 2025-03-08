namespace ComputerGraphics
{
    partial class Form1
    {
        private System.ComponentModel.IContainer recursos = null;
        private System.Windows.Forms.Panel painelSuperior;
        private System.Windows.Forms.Panel painelLateralEsquerdo;
        private System.Windows.Forms.Panel painelInferior;
        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.PictureBox imgCinzaVermelho;
        private System.Windows.Forms.PictureBox imgCinzaVerde;
        private System.Windows.Forms.PictureBox imgCinzaAzul;
        private System.Windows.Forms.PictureBox imgCinzaMatiz;
        private System.Windows.Forms.PictureBox imgCinzaSaturacao;
        private System.Windows.Forms.PictureBox imgCinzaIntensidade;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TrackBar barraBrilho;
        private System.Windows.Forms.TrackBar barraMatiz;
        private System.Windows.Forms.Button btnAbrirImagem;
        private System.Windows.Forms.Label lblBrilho;
        private System.Windows.Forms.Label lblMatiz;
        private System.Windows.Forms.Label lblCanaisRGB;
        private System.Windows.Forms.Label lblCanaisHSI;
        private System.Windows.Forms.FlowLayoutPanel painelRGB;
        private System.Windows.Forms.FlowLayoutPanel painelHSI;
        private System.Windows.Forms.Button btnConverterLuminancia;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.Label lblMatizMin;
        private System.Windows.Forms.TextBox txtMatizMin;
        private System.Windows.Forms.Label lblMatizMax;
        private System.Windows.Forms.TextBox txtMatizMax;
        private System.Windows.Forms.Button btnAplicarMatiz;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (recursos != null))
                recursos.Dispose();
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Forms Designer

        private void InitializeComponent()
        {
            painelSuperior = new Panel();
            btnAbrirImagem = new Button();
            lblStatus = new Label();
            lblInfo = new Label();
            painelLateralEsquerdo = new Panel();
            lblCanaisRGB = new Label();
            painelRGB = new FlowLayoutPanel();
            imgCinzaVermelho = new PictureBox();
            imgCinzaVerde = new PictureBox();
            imgCinzaAzul = new PictureBox();
            lblCanaisHSI = new Label();
            painelHSI = new FlowLayoutPanel();
            imgCinzaMatiz = new PictureBox();
            imgCinzaSaturacao = new PictureBox();
            imgCinzaIntensidade = new PictureBox();
            painelInferior = new Panel();
            lblBrilho = new Label();
            barraBrilho = new TrackBar();
            lblMatiz = new Label();
            barraMatiz = new TrackBar();
            lblMatizMin = new Label();
            txtMatizMin = new TextBox();
            lblMatizMax = new Label();
            txtMatizMax = new TextBox();
            btnAplicarMatiz = new Button();
            btnConverterLuminancia = new Button();
            btnRestaurar = new Button();
            imgOriginal = new PictureBox();
            painelSuperior.SuspendLayout();
            painelLateralEsquerdo.SuspendLayout();
            painelRGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCinzaVermelho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaVerde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaAzul).BeginInit();
            painelHSI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgCinzaMatiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaSaturacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaIntensidade).BeginInit();
            painelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)barraBrilho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barraMatiz).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgOriginal).BeginInit();
            SuspendLayout();
            // 
            // painelSuperior
            // 
            painelSuperior.Controls.Add(btnAbrirImagem);
            painelSuperior.Controls.Add(lblStatus);
            painelSuperior.Controls.Add(lblInfo);
            painelSuperior.Dock = DockStyle.Top;
            painelSuperior.Location = new Point(0, 0);
            painelSuperior.Name = "painelSuperior";
            painelSuperior.Size = new Size(1036, 80);
            painelSuperior.TabIndex = 0;
            // 
            // btnAbrirImagem
            // 
            btnAbrirImagem.Location = new Point(400, 20);
            btnAbrirImagem.Name = "btnAbrirImagem";
            btnAbrirImagem.Size = new Size(200, 40);
            btnAbrirImagem.TabIndex = 0;
            btnAbrirImagem.Text = "Abrir Imagem";
            btnAbrirImagem.UseVisualStyleBackColor = true;
            btnAbrirImagem.Click += BotaoCarregarImagem_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 50);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(210, 21);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Informações da imagem...";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(10, 65);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(210, 21);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Passe o mouse para ver as informações...";
            // 
            // painelLateralEsquerdo
            // 
            painelLateralEsquerdo.Controls.Add(lblCanaisRGB);
            painelLateralEsquerdo.Controls.Add(painelRGB);
            painelLateralEsquerdo.Controls.Add(lblCanaisHSI);
            painelLateralEsquerdo.Controls.Add(painelHSI);
            painelLateralEsquerdo.Dock = DockStyle.Left;
            painelLateralEsquerdo.Location = new Point(0, 80);
            painelLateralEsquerdo.Name = "painelLateralEsquerdo";
            painelLateralEsquerdo.Size = new Size(200, 520);
            painelLateralEsquerdo.TabIndex = 1;
            // 
            // lblCanaisRGB
            // 
            lblCanaisRGB.AutoSize = true;
            lblCanaisRGB.Location = new Point(10, 10);
            lblCanaisRGB.Name = "lblCanaisRGB";
            lblCanaisRGB.Size = new Size(148, 21);
            lblCanaisRGB.TabIndex = 6;
            lblCanaisRGB.Text = "Canais de Cinza (RGB)";
            // 
            // painelRGB
            // 
            painelRGB.Controls.Add(imgCinzaVermelho);
            painelRGB.Controls.Add(imgCinzaVerde);
            painelRGB.Controls.Add(imgCinzaAzul);
            painelRGB.Location = new Point(10, 40);
            painelRGB.Name = "painelRGB";
            painelRGB.Size = new Size(180, 200);
            painelRGB.TabIndex = 7;
            // 
            // imgCinzaVermelho
            // 
            imgCinzaVermelho.BorderStyle = BorderStyle.FixedSingle;
            imgCinzaVermelho.Location = new Point(4, 4);
            imgCinzaVermelho.Name = "imgCinzaVermelho";
            imgCinzaVermelho.Size = new Size(82, 71);
            imgCinzaVermelho.SizeMode = PictureBoxSizeMode.Zoom;
            imgCinzaVermelho.TabIndex = 0;
            imgCinzaVermelho.TabStop = false;
            // 
            // imgCinzaVerde
            // 
            imgCinzaVerde.BorderStyle = BorderStyle.FixedSingle;
            imgCinzaVerde.Location = new Point(94, 4);
            imgCinzaVerde.Name = "imgCinzaVerde";
            imgCinzaVerde.Size = new Size(82, 71);
            imgCinzaVerde.SizeMode = PictureBoxSizeMode.Zoom;
            imgCinzaVerde.TabIndex = 1;
            imgCinzaVerde.TabStop = false;
            // 
            // imgCinzaAzul
            // 
            imgCinzaAzul.BorderStyle = BorderStyle.FixedSingle;
            imgCinzaAzul.Location = new Point(184, 4);
            imgCinzaAzul.Name = "imgCinzaAzul";
            imgCinzaAzul.Size = new Size(82, 71);
            imgCinzaAzul.SizeMode = PictureBoxSizeMode.Zoom;
            imgCinzaAzul.TabIndex = 2;
            imgCinzaAzul.TabStop = false;
            // 
            // lblCanaisHSI
            // 
            lblCanaisHSI.AutoSize = true;
            lblCanaisHSI.Location = new Point(10, 250);
            lblCanaisHSI.Name = "lblCanaisHSI";
            lblCanaisHSI.Size = new Size(142, 21);
            lblCanaisHSI.TabIndex = 8;
            lblCanaisHSI.Text = "Canais de Cinza (HSI)";
            // 
            // painelHSI
            // 
            painelHSI.Controls.Add(imgCinzaMatiz);
            painelHSI.Controls.Add(imgCinzaSaturacao);
            painelHSI.Controls.Add(imgCinzaIntensidade);
            painelHSI.Location = new Point(10, 280);
            painelHSI.Name = "painelHSI";
            painelHSI.Size = new Size(180, 200);
            painelHSI.TabIndex = 9;
            // 
            // imgCinzaMatiz
            // 
            imgCinzaMatiz.BorderStyle = BorderStyle.FixedSingle;
            imgCinzaMatiz.Location = new Point(4, 4);
            imgCinzaMatiz.Name = "imgCinzaMatiz";
            imgCinzaMatiz.Size = new Size(82, 71);
            imgCinzaMatiz.SizeMode = PictureBoxSizeMode.Zoom;
            imgCinzaMatiz.TabIndex = 0;
            imgCinzaMatiz.TabStop = false;
            // 
            // imgCinzaSaturacao
            // 
            imgCinzaSaturacao.BorderStyle = BorderStyle.FixedSingle;
            imgCinzaSaturacao.Location = new Point(94, 4);
            imgCinzaSaturacao.Name = "imgCinzaSaturacao";
            imgCinzaSaturacao.Size = new Size(82, 71);
            imgCinzaSaturacao.SizeMode = PictureBoxSizeMode.Zoom;
            imgCinzaSaturacao.TabIndex = 1;
            imgCinzaSaturacao.TabStop = false;
            // 
            // imgCinzaIntensidade
            // 
            imgCinzaIntensidade.BorderStyle = BorderStyle.FixedSingle;
            imgCinzaIntensidade.Location = new Point(184, 4);
            imgCinzaIntensidade.Name = "imgCinzaIntensidade";
            imgCinzaIntensidade.Size = new Size(82, 71);
            imgCinzaIntensidade.SizeMode = PictureBoxSizeMode.Zoom;
            imgCinzaIntensidade.TabIndex = 2;
            imgCinzaIntensidade.TabStop = false;
            // 
            // painelInferior
            // 
            painelInferior.Controls.Add(lblBrilho);
            painelInferior.Controls.Add(barraBrilho);
            painelInferior.Controls.Add(lblMatiz);
            painelInferior.Controls.Add(barraMatiz);
            painelInferior.Controls.Add(lblMatizMin);
            painelInferior.Controls.Add(txtMatizMin);
            painelInferior.Controls.Add(lblMatizMax);
            painelInferior.Controls.Add(txtMatizMax);
            painelInferior.Controls.Add(btnAplicarMatiz);
            painelInferior.Controls.Add(btnConverterLuminancia);
            painelInferior.Controls.Add(btnRestaurar);
            painelInferior.Dock = DockStyle.Bottom;
            painelInferior.Location = new Point(200, 480);
            painelInferior.Name = "painelInferior";
            painelInferior.Size = new Size(836, 120);
            painelInferior.TabIndex = 2;
            // 
            // lblBrilho
            // 
            lblBrilho.AutoSize = true;
            lblBrilho.Location = new Point(10, 10);
            lblBrilho.Name = "lblBrilho";
            lblBrilho.Size = new Size(51, 21);
            lblBrilho.TabIndex = 2;
            lblBrilho.Text = "Brilho";
            // 
            // barraBrilho
            // 
            barraBrilho.Location = new Point(10, 35);
            barraBrilho.Maximum = 100;
            barraBrilho.Minimum = -100;
            barraBrilho.Name = "barraBrilho";
            barraBrilho.Size = new Size(200, 45);
            barraBrilho.TabIndex = 3;
            barraBrilho.TickFrequency = 10;
            barraBrilho.Scroll += BarraBrilho_Scroll;
            // 
            // lblMatiz
            // 
            lblMatiz.AutoSize = true;
            lblMatiz.Location = new Point(220, 10);
            lblMatiz.Name = "lblMatiz";
            lblMatiz.Size = new Size(90, 21);
            lblMatiz.TabIndex = 4;
            lblMatiz.Text = "Matiz (Hue)";
            // 
            // barraMatiz
            // 
            barraMatiz.Location = new Point(220, 35);
            barraMatiz.Maximum = 180;
            barraMatiz.Minimum = -180;
            barraMatiz.Name = "barraMatiz";
            barraMatiz.Size = new Size(200, 45);
            barraMatiz.TabIndex = 5;
            barraMatiz.TickFrequency = 30;
            barraMatiz.Scroll += BarraMatiz_Scroll;
            // 
            // lblMatizMin
            // 
            lblMatizMin.AutoSize = true;
            lblMatizMin.Location = new Point(430, 10);
            lblMatizMin.Name = "lblMatizMin";
            lblMatizMin.Size = new Size(69, 21);
            lblMatizMin.TabIndex = 12;
            lblMatizMin.Text = "Matiz Min";
            // 
            // txtMatizMin
            // 
            txtMatizMin.Location = new Point(430, 35);
            txtMatizMin.Name = "txtMatizMin";
            txtMatizMin.Size = new Size(56, 29);
            txtMatizMin.TabIndex = 13;
            txtMatizMin.Text = "0";
            // 
            // lblMatizMax
            // 
            lblMatizMax.AutoSize = true;
            lblMatizMax.Location = new Point(500, 10);
            lblMatizMax.Name = "lblMatizMax";
            lblMatizMax.Size = new Size(71, 21);
            lblMatizMax.TabIndex = 14;
            lblMatizMax.Text = "Matiz Max";
            // 
            // txtMatizMax
            // 
            txtMatizMax.Location = new Point(500, 35);
            txtMatizMax.Name = "txtMatizMax";
            txtMatizMax.Size = new Size(56, 29);
            txtMatizMax.TabIndex = 15;
            txtMatizMax.Text = "360";
            // 
            // btnAplicarMatiz
            // 
            btnAplicarMatiz.Location = new Point(570, 35);
            btnAplicarMatiz.Name = "btnAplicarMatiz";
            btnAplicarMatiz.Size = new Size(150, 30);
            btnAplicarMatiz.TabIndex = 16;
            btnAplicarMatiz.Text = "Aplicar Intervalo Matiz";
            btnAplicarMatiz.UseVisualStyleBackColor = true;
            btnAplicarMatiz.Click += BotaoAplicarIntervaloMatiz_Click;
            // 
            // btnConverterLuminancia
            // 
            btnConverterLuminancia.Location = new Point(730, 10);
            btnConverterLuminancia.Name = "btnConverterLuminancia";
            btnConverterLuminancia.Size = new Size(100, 45);
            btnConverterLuminancia.TabIndex = 10;
            btnConverterLuminancia.Text = "Converter Luminância";
            btnConverterLuminancia.UseVisualStyleBackColor = true;
            btnConverterLuminancia.Click += BotaoConverterLuminancia_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(730, 65);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(100, 45);
            btnRestaurar.TabIndex = 11;
            btnRestaurar.Text = "Restaurar Imagem";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += BotaoResetar_Click;
            // 
            // imgOriginal
            // 
            imgOriginal.BorderStyle = BorderStyle.FixedSingle;
            imgOriginal.Dock = DockStyle.Fill;
            imgOriginal.Location = new Point(200, 80);
            imgOriginal.Name = "imgOriginal";
            imgOriginal.Size = new Size(836, 400);
            imgOriginal.SizeMode = PictureBoxSizeMode.Zoom;
            imgOriginal.TabIndex = 0;
            imgOriginal.TabStop = false;
            imgOriginal.Click += ImagemOriginal_Click;
            imgOriginal.MouseMove += ImagemOriginal_MouseMove;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 600);
            Controls.Add(imgOriginal);
            Controls.Add(painelInferior);
            Controls.Add(painelLateralEsquerdo);
            Controls.Add(painelSuperior);
            Name = "Form1";
            Text = "Aplicativo de Processamento de Imagens";
            painelSuperior.ResumeLayout(false);
            painelSuperior.PerformLayout();
            painelLateralEsquerdo.ResumeLayout(false);
            painelLateralEsquerdo.PerformLayout();
            painelRGB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCinzaVermelho).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaVerde).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaAzul).EndInit();
            painelHSI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgCinzaMatiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaSaturacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgCinzaIntensidade).EndInit();
            painelInferior.ResumeLayout(false);
            painelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)barraBrilho).EndInit();
            ((System.ComponentModel.ISupportInitialize)barraMatiz).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgOriginal).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}