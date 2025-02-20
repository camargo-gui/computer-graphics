namespace ComputerGraphics
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuColors;
        private System.Windows.Forms.Panel colorOptionsPanel;
        private System.Windows.Forms.PictureBox picMain;
        private System.Windows.Forms.PictureBox picCurrent;
        private System.Windows.Forms.PictureBox picChannelRed;
        private System.Windows.Forms.PictureBox picChannelGreen;
        private System.Windows.Forms.PictureBox picChannelBlue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar brightnessSlider;
        private System.Windows.Forms.TrackBar hueSlider;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.Label lblHue;
        private System.Windows.Forms.Button btnApplyGray;
        private System.Windows.Forms.Button btnResetImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            sidePanel = new Panel();
            btnLoadImage = new Button();
            lblStatus = new Label();
            colorOptionsPanel = new Panel();
            lblBrightness = new Label();
            brightnessSlider = new TrackBar();
            lblHue = new Label();
            hueSlider = new TrackBar();
            btnApplyGray = new Button();
            btnResetImage = new Button();
            menuStrip = new MenuStrip();
            menuColors = new ToolStripMenuItem();
            picMain = new PictureBox();
            picChannelRed = new PictureBox();
            picChannelGreen = new PictureBox();
            picChannelBlue = new PictureBox();
            sidePanel.SuspendLayout();
            colorOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brightnessSlider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hueSlider).BeginInit();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChannelRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChannelGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChannelBlue).BeginInit();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(250, 250, 250);
            sidePanel.Controls.Add(btnLoadImage);
            sidePanel.Controls.Add(lblStatus);
            sidePanel.Controls.Add(colorOptionsPanel);
            sidePanel.Dock = DockStyle.Right;
            sidePanel.Location = new Point(-36, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(10);
            sidePanel.Size = new Size(320, 261);
            sidePanel.TabIndex = 2;
            // 
            // btnLoadImage
            // 
            btnLoadImage.BackColor = Color.DodgerBlue;
            btnLoadImage.FlatStyle = FlatStyle.Flat;
            btnLoadImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLoadImage.ForeColor = Color.White;
            btnLoadImage.Location = new Point(20, 20);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(280, 40);
            btnLoadImage.TabIndex = 0;
            btnLoadImage.Text = "📷 Load Image";
            btnLoadImage.UseVisualStyleBackColor = false;
            btnLoadImage.Click += BtnLoadImage_Click;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(20, 70);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(280, 20);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status: Ready";
            // 
            // colorOptionsPanel
            // 
            colorOptionsPanel.Controls.Add(lblBrightness);
            colorOptionsPanel.Controls.Add(brightnessSlider);
            colorOptionsPanel.Controls.Add(lblHue);
            colorOptionsPanel.Controls.Add(hueSlider);
            colorOptionsPanel.Controls.Add(btnApplyGray);
            colorOptionsPanel.Controls.Add(btnResetImage);
            colorOptionsPanel.Dock = DockStyle.Bottom;
            colorOptionsPanel.Location = new Point(10, 51);
            colorOptionsPanel.Name = "colorOptionsPanel";
            colorOptionsPanel.Size = new Size(300, 200);
            colorOptionsPanel.TabIndex = 2;
            colorOptionsPanel.Visible = false;
            // 
            // lblBrightness
            // 
            lblBrightness.Font = new Font("Segoe UI", 10F);
            lblBrightness.ForeColor = Color.White;
            lblBrightness.Location = new Point(20, 10);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(280, 20);
            lblBrightness.TabIndex = 0;
            lblBrightness.Text = "🔆 Brightness";
            // 
            // brightnessSlider
            // 
            brightnessSlider.Location = new Point(20, 40);
            brightnessSlider.Maximum = 100;
            brightnessSlider.Minimum = -100;
            brightnessSlider.Name = "brightnessSlider";
            brightnessSlider.Size = new Size(280, 45);
            brightnessSlider.TabIndex = 1;
            brightnessSlider.TickFrequency = 10;
            // 
            // lblHue
            // 
            lblHue.Font = new Font("Segoe UI", 10F);
            lblHue.ForeColor = Color.White;
            lblHue.Location = new Point(20, 80);
            lblHue.Name = "lblHue";
            lblHue.Size = new Size(280, 20);
            lblHue.TabIndex = 2;
            lblHue.Text = "🎨 Hue";
            // 
            // hueSlider
            // 
            hueSlider.Location = new Point(20, 110);
            hueSlider.Maximum = 180;
            hueSlider.Minimum = -180;
            hueSlider.Name = "hueSlider";
            hueSlider.Size = new Size(280, 45);
            hueSlider.TabIndex = 3;
            hueSlider.TickFrequency = 30;
            // 
            // btnApplyGray
            // 
            btnApplyGray.BackColor = Color.DarkOrange;
            btnApplyGray.FlatStyle = FlatStyle.Flat;
            btnApplyGray.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApplyGray.ForeColor = Color.White;
            btnApplyGray.Location = new Point(20, 150);
            btnApplyGray.Name = "btnApplyGray";
            btnApplyGray.Size = new Size(280, 40);
            btnApplyGray.TabIndex = 4;
            btnApplyGray.Text = "🌑 Apply Grayscale";
            btnApplyGray.UseVisualStyleBackColor = false;
            // 
            // btnResetImage
            // 
            btnResetImage.BackColor = Color.Crimson;
            btnResetImage.FlatStyle = FlatStyle.Flat;
            btnResetImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetImage.ForeColor = Color.White;
            btnResetImage.Location = new Point(20, 200);
            btnResetImage.Name = "btnResetImage";
            btnResetImage.Size = new Size(280, 40);
            btnResetImage.TabIndex = 5;
            btnResetImage.Text = "🔄 Reset";
            btnResetImage.UseVisualStyleBackColor = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { menuColors });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(0, 24);
            menuStrip.TabIndex = 0;
            // 
            // menuColors
            // 
            menuColors.Name = "menuColors";
            menuColors.Size = new Size(49, 20);
            menuColors.Text = "Cores";
            menuColors.Click += MenuColors_Click;
            // 
            // picMain
            // 
            picMain.BackColor = Color.Black;
            picMain.Dock = DockStyle.Fill;
            picMain.Location = new Point(0, 0);
            picMain.Name = "picMain";
            picMain.Size = new Size(0, 261);
            picMain.SizeMode = PictureBoxSizeMode.Zoom;
            picMain.TabIndex = 1;
            picMain.TabStop = false;
            // 
            // picChannelRed
            // 
            picChannelRed.Location = new Point(0, 0);
            picChannelRed.Name = "picChannelRed";
            picChannelRed.Size = new Size(100, 50);
            picChannelRed.TabIndex = 0;
            picChannelRed.TabStop = false;
            // 
            // picChannelGreen
            // 
            picChannelGreen.Location = new Point(0, 0);
            picChannelGreen.Name = "picChannelGreen";
            picChannelGreen.Size = new Size(100, 50);
            picChannelGreen.TabIndex = 0;
            picChannelGreen.TabStop = false;
            // 
            // picChannelBlue
            // 
            picChannelBlue.Location = new Point(0, 0);
            picChannelBlue.Name = "picChannelBlue";
            picChannelBlue.Size = new Size(100, 50);
            picChannelBlue.TabIndex = 0;
            picChannelBlue.TabStop = false;
            // 
            // Form1
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(menuStrip);
            Controls.Add(picMain);
            Controls.Add(sidePanel);
            Name = "Form1";
            sidePanel.ResumeLayout(false);
            colorOptionsPanel.ResumeLayout(false);
            colorOptionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brightnessSlider).EndInit();
            ((System.ComponentModel.ISupportInitialize)hueSlider).EndInit();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChannelRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChannelGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChannelBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MenuColors_Click(object sender, System.EventArgs e)
        {
            colorOptionsPanel.Visible = !colorOptionsPanel.Visible;
        }
    }
}
