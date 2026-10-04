using System.Drawing;
using System.Windows.Forms;

namespace CafeSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlSol = new Panel();
            lblCafe = new Label();
            pbLogo = new PictureBox();
            lblMuddet = new Label();
            txtMuddet = new TextBox();
            lblMebleg = new Label();
            txtMebleg = new TextBox();
            lblQaliq = new Label();
            txtQaliq = new TextBox();
            btnHesabla = new Button();
            btnTemizle = new Button();
            pnlSag = new Panel();
            lblSebet = new Label();
            lstSebet = new ListBox();
            btnSil = new Button();
            btnYenile = new Button();
            btnYekun = new Button();
            lblHesab = new Label();
            txtHesab = new TextBox();
            lblMenu = new Label();
            pbTort = new PictureBox();
            pbKola = new PictureBox();
            pbCay = new PictureBox();
            pbBurger = new PictureBox();
            pbSendvic = new PictureBox();
            pbPizza = new PictureBox();
            pbKeks = new PictureBox();
            pbHotdoq = new PictureBox();
            pbPecenye = new PictureBox();
            pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbSendvic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPizza).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbKeks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHotdoq).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPecenye).BeginInit();
            SuspendLayout();
            // 
            // pnlSol
            // 
            pnlSol.BackColor = Color.FromArgb(85, 85, 85);
            pnlSol.Controls.Add(lblCafe);
            pnlSol.Controls.Add(pbLogo);
            pnlSol.Controls.Add(lblMuddet);
            pnlSol.Controls.Add(txtMuddet);
            pnlSol.Controls.Add(lblMebleg);
            pnlSol.Controls.Add(txtMebleg);
            pnlSol.Controls.Add(lblQaliq);
            pnlSol.Controls.Add(txtQaliq);
            pnlSol.Controls.Add(btnHesabla);
            pnlSol.Controls.Add(btnTemizle);
            pnlSol.Location = new Point(10, 0);
            pnlSol.Name = "pnlSol";
            pnlSol.Size = new Size(190, 460);
            pnlSol.TabIndex = 0;
            // 
            // lblCafe
            // 
            lblCafe.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblCafe.Location = new Point(0, 20);
            lblCafe.Name = "lblCafe";
            lblCafe.Size = new Size(190, 36);
            lblCafe.TabIndex = 0;
            lblCafe.Text = "Cafe";
            lblCafe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            pbLogo.Location = new Point(40, 65);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(110, 95);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 1;
            pbLogo.TabStop = false;
            // 
            // lblMuddet
            // 
            lblMuddet.AutoSize = true;
            lblMuddet.Location = new Point(14, 205);
            lblMuddet.Name = "lblMuddet";
            lblMuddet.Size = new Size(64, 20);
            lblMuddet.TabIndex = 2;
            lblMuddet.Text = "Müddət:";
            // 
            // txtMuddet
            // 
            txtMuddet.BackColor = Color.FromArgb(15, 15, 15);
            txtMuddet.BorderStyle = BorderStyle.FixedSingle;
            txtMuddet.ForeColor = Color.White;
            txtMuddet.Location = new Point(82, 202);
            txtMuddet.Name = "txtMuddet";
            txtMuddet.Size = new Size(94, 27);
            txtMuddet.TabIndex = 3;
            // 
            // lblMebleg
            // 
            lblMebleg.AutoSize = true;
            lblMebleg.Location = new Point(22, 252);
            lblMebleg.Name = "lblMebleg";
            lblMebleg.Size = new Size(60, 20);
            lblMebleg.TabIndex = 4;
            lblMebleg.Text = "Məbləğ";
            // 
            // txtMebleg
            // 
            txtMebleg.BackColor = Color.FromArgb(15, 15, 15);
            txtMebleg.BorderStyle = BorderStyle.FixedSingle;
            txtMebleg.ForeColor = Color.White;
            txtMebleg.Location = new Point(22, 272);
            txtMebleg.Name = "txtMebleg";
            txtMebleg.Size = new Size(146, 27);
            txtMebleg.TabIndex = 5;
            // 
            // lblQaliq
            // 
            lblQaliq.AutoSize = true;
            lblQaliq.Location = new Point(22, 310);
            lblQaliq.Name = "lblQaliq";
            lblQaliq.Size = new Size(45, 20);
            lblQaliq.TabIndex = 6;
            lblQaliq.Text = "Qalıq";
            // 
            // txtQaliq
            // 
            txtQaliq.BackColor = Color.FromArgb(15, 15, 15);
            txtQaliq.BorderStyle = BorderStyle.FixedSingle;
            txtQaliq.ForeColor = Color.White;
            txtQaliq.Location = new Point(22, 330);
            txtQaliq.Name = "txtQaliq";
            txtQaliq.ReadOnly = true;
            txtQaliq.Size = new Size(146, 27);
            txtQaliq.TabIndex = 7;
            // 
            // btnHesabla
            // 
            btnHesabla.BackColor = Color.FromArgb(76, 197, 85);
            btnHesabla.FlatAppearance.BorderSize = 0;
            btnHesabla.FlatStyle = FlatStyle.Flat;
            btnHesabla.ForeColor = Color.Black;
            btnHesabla.Location = new Point(22, 375);
            btnHesabla.Name = "btnHesabla";
            btnHesabla.Size = new Size(146, 30);
            btnHesabla.TabIndex = 8;
            btnHesabla.Text = "Hesabla";
            btnHesabla.UseVisualStyleBackColor = false;
            btnHesabla.Click += btnHesabla_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.FromArgb(255, 179, 179);
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.ForeColor = Color.Maroon;
            btnTemizle.Location = new Point(22, 415);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(146, 30);
            btnTemizle.TabIndex = 9;
            btnTemizle.Text = "Təmizlə";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // pnlSag
            // 
            pnlSag.BackColor = Color.FromArgb(85, 85, 85);
            pnlSag.Controls.Add(lblSebet);
            pnlSag.Controls.Add(lstSebet);
            pnlSag.Controls.Add(btnSil);
            pnlSag.Controls.Add(btnYenile);
            pnlSag.Controls.Add(btnYekun);
            pnlSag.Controls.Add(lblHesab);
            pnlSag.Controls.Add(txtHesab);
            pnlSag.Location = new Point(620, 0);
            pnlSag.Name = "pnlSag";
            pnlSag.Size = new Size(190, 460);
            pnlSag.TabIndex = 1;
            // 
            // lblSebet
            // 
            lblSebet.Font = new Font("Segoe UI", 16F, FontStyle.Italic);
            lblSebet.Location = new Point(0, 20);
            lblSebet.Name = "lblSebet";
            lblSebet.Size = new Size(190, 36);
            lblSebet.TabIndex = 0;
            lblSebet.Text = "Səbət";
            lblSebet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lstSebet
            // 
            lstSebet.BackColor = Color.FromArgb(15, 15, 15);
            lstSebet.BorderStyle = BorderStyle.None;
            lstSebet.Font = new Font("Segoe UI", 10F);
            lstSebet.ForeColor = Color.White;
            lstSebet.IntegralHeight = false;
            lstSebet.Location = new Point(15, 70);
            lstSebet.Name = "lstSebet";
            lstSebet.Size = new Size(160, 215);
            lstSebet.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(45, 45, 45);
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(15, 300);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(160, 28);
            btnSil.TabIndex = 2;
            btnSil.Text = "Səbətdən sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnYenile
            // 
            btnYenile.BackColor = Color.FromArgb(45, 45, 45);
            btnYenile.FlatAppearance.BorderSize = 0;
            btnYenile.FlatStyle = FlatStyle.Flat;
            btnYenile.ForeColor = Color.White;
            btnYenile.Location = new Point(15, 336);
            btnYenile.Name = "btnYenile";
            btnYenile.Size = new Size(160, 28);
            btnYenile.TabIndex = 3;
            btnYenile.Text = "Yenilə";
            btnYenile.UseVisualStyleBackColor = false;
            btnYenile.Click += btnYenile_Click;
            // 
            // btnYekun
            // 
            btnYekun.BackColor = Color.FromArgb(45, 45, 45);
            btnYekun.FlatAppearance.BorderSize = 0;
            btnYekun.FlatStyle = FlatStyle.Flat;
            btnYekun.ForeColor = Color.White;
            btnYekun.Location = new Point(15, 372);
            btnYekun.Name = "btnYekun";
            btnYekun.Size = new Size(160, 28);
            btnYekun.TabIndex = 4;
            btnYekun.Text = "Yekun hesab";
            btnYekun.UseVisualStyleBackColor = false;
            btnYekun.Click += btnYekun_Click;
            // 
            // lblHesab
            // 
            lblHesab.AutoSize = true;
            lblHesab.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblHesab.Location = new Point(12, 421);
            lblHesab.Name = "lblHesab";
            lblHesab.Size = new Size(64, 23);
            lblHesab.TabIndex = 5;
            lblHesab.Text = "Hesab:";
            // 
            // txtHesab
            // 
            txtHesab.BackColor = Color.FromArgb(15, 15, 15);
            txtHesab.BorderStyle = BorderStyle.FixedSingle;
            txtHesab.ForeColor = Color.White;
            txtHesab.Location = new Point(77, 418);
            txtHesab.Name = "txtHesab";
            txtHesab.ReadOnly = true;
            txtHesab.Size = new Size(98, 27);
            txtHesab.TabIndex = 6;
            // 
            // lblMenu
            // 
            lblMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            lblMenu.Location = new Point(200, 20);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(420, 36);
            lblMenu.TabIndex = 2;
            lblMenu.Text = "MENU";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbTort
            // 
            pbTort.Cursor = Cursors.Hand;
            pbTort.Image = (Image)resources.GetObject("pbTort.Image");
            pbTort.Location = new Point(215, 80);
            pbTort.Name = "pbTort";
            pbTort.Size = new Size(110, 100);
            pbTort.SizeMode = PictureBoxSizeMode.StretchImage;
            pbTort.TabIndex = 3;
            pbTort.TabStop = false;
            pbTort.Tag = "Tort";
            pbTort.Click += Sekil_Click;
            // 
            // pbKola
            // 
            pbKola.Cursor = Cursors.Hand;
            pbKola.Image = (Image)resources.GetObject("pbKola.Image");
            pbKola.Location = new Point(355, 80);
            pbKola.Name = "pbKola";
            pbKola.Size = new Size(110, 100);
            pbKola.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKola.TabIndex = 4;
            pbKola.TabStop = false;
            pbKola.Tag = "Kola";
            pbKola.Click += Sekil_Click;
            // 
            // pbCay
            // 
            pbCay.Cursor = Cursors.Hand;
            pbCay.Image = (Image)resources.GetObject("pbCay.Image");
            pbCay.Location = new Point(495, 80);
            pbCay.Name = "pbCay";
            pbCay.Size = new Size(110, 100);
            pbCay.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCay.TabIndex = 5;
            pbCay.TabStop = false;
            pbCay.Tag = "Buzlu çay";
            pbCay.Click += Sekil_Click;
            // 
            // pbBurger
            // 
            pbBurger.Cursor = Cursors.Hand;
            pbBurger.Image = (Image)resources.GetObject("pbBurger.Image");
            pbBurger.Location = new Point(215, 205);
            pbBurger.Name = "pbBurger";
            pbBurger.Size = new Size(110, 100);
            pbBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBurger.TabIndex = 6;
            pbBurger.TabStop = false;
            pbBurger.Tag = "Burger";
            pbBurger.Click += Sekil_Click;
            // 
            // pbSendvic
            // 
            pbSendvic.Cursor = Cursors.Hand;
            pbSendvic.Image = (Image)resources.GetObject("pbSendvic.Image");
            pbSendvic.Location = new Point(355, 205);
            pbSendvic.Name = "pbSendvic";
            pbSendvic.Size = new Size(110, 100);
            pbSendvic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSendvic.TabIndex = 7;
            pbSendvic.TabStop = false;
            pbSendvic.Tag = "Sendviç";
            pbSendvic.Click += Sekil_Click;
            // 
            // pbPizza
            // 
            pbPizza.Cursor = Cursors.Hand;
            pbPizza.Image = (Image)resources.GetObject("pbPizza.Image");
            pbPizza.Location = new Point(495, 205);
            pbPizza.Name = "pbPizza";
            pbPizza.Size = new Size(110, 100);
            pbPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPizza.TabIndex = 8;
            pbPizza.TabStop = false;
            pbPizza.Tag = "Pizza";
            pbPizza.Click += Sekil_Click;
            // 
            // pbKeks
            // 
            pbKeks.Cursor = Cursors.Hand;
            pbKeks.Image = (Image)resources.GetObject("pbKeks.Image");
            pbKeks.Location = new Point(215, 330);
            pbKeks.Name = "pbKeks";
            pbKeks.Size = new Size(110, 100);
            pbKeks.SizeMode = PictureBoxSizeMode.StretchImage;
            pbKeks.TabIndex = 9;
            pbKeks.TabStop = false;
            pbKeks.Tag = "Keks";
            pbKeks.Click += Sekil_Click;
            // 
            // pbHotdoq
            // 
            pbHotdoq.Cursor = Cursors.Hand;
            pbHotdoq.Image = (Image)resources.GetObject("pbHotdoq.Image");
            pbHotdoq.Location = new Point(355, 330);
            pbHotdoq.Name = "pbHotdoq";
            pbHotdoq.Size = new Size(110, 100);
            pbHotdoq.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHotdoq.TabIndex = 10;
            pbHotdoq.TabStop = false;
            pbHotdoq.Tag = "Hot-doq";
            pbHotdoq.Click += Sekil_Click;
            // 
            // pbPecenye
            // 
            pbPecenye.Cursor = Cursors.Hand;
            pbPecenye.Image = (Image)resources.GetObject("pbPecenye.Image");
            pbPecenye.Location = new Point(495, 330);
            pbPecenye.Name = "pbPecenye";
            pbPecenye.Size = new Size(110, 100);
            pbPecenye.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPecenye.TabIndex = 11;
            pbPecenye.TabStop = false;
            pbPecenye.Tag = "Peçenye";
            pbPecenye.Click += Sekil_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(38, 38, 38);
            ClientSize = new Size(820, 460);
            Controls.Add(pnlSol);
            Controls.Add(pnlSag);
            Controls.Add(lblMenu);
            Controls.Add(pbTort);
            Controls.Add(pbKola);
            Controls.Add(pbCay);
            Controls.Add(pbBurger);
            Controls.Add(pbSendvic);
            Controls.Add(pbPizza);
            Controls.Add(pbKeks);
            Controls.Add(pbHotdoq);
            Controls.Add(pbPecenye);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cafe system";
            pnlSol.ResumeLayout(false);
            pnlSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSag.ResumeLayout(false);
            pnlSag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTort).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKola).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCay).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbSendvic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPizza).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbKeks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHotdoq).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPecenye).EndInit();
            ResumeLayout(false);
        }

        private Panel pnlSol, pnlSag;
        private Label lblCafe, lblMenu, lblSebet, lblMuddet, lblMebleg, lblQaliq, lblHesab;
        private TextBox txtMuddet, txtMebleg, txtQaliq, txtHesab;
        private ListBox lstSebet;
        private Button btnHesabla, btnTemizle, btnSil, btnYenile, btnYekun;
        private PictureBox pbLogo, pbTort, pbKola, pbCay, pbBurger, pbSendvic, pbPizza, pbKeks, pbHotdoq, pbPecenye;
    }
}