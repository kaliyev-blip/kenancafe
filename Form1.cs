using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CafeSystem

{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, decimal> qiymetler = new Dictionary<string, decimal>
        {
            { "Tort", 3.50m }, { "Kola", 1.50m }, { "Buzlu çay", 2.00m },
            { "Burger", 5.00m }, { "Sendviç", 4.00m }, { "Pizza", 6.00m },
            { "Keks", 2.50m }, { "Hot-doq", 3.00m }, { "Peçenye", 1.50m }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private static bool Eded(string metn, out decimal eded)
        {
            return decimal.TryParse(metn.Replace(',', '.'), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out eded);
        }

        private static string Pul(decimal eded)
        {
            return eded.ToString("0.00", CultureInfo.InvariantCulture);
        }

        private void Sekil_Click(object sender, EventArgs e)
        {
            lstSebet.Items.Add(((PictureBox)sender).Tag);
            txtHesab.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int index = lstSebet.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Silmək üçün səbətdən yemək seçin!");
                return;
            }
            string ad = lstSebet.Items[index].ToString();
            lstSebet.Items.RemoveAt(index);
            txtHesab.Clear();
            MessageBox.Show(ad + " səbətdən silindi");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Xanalar sıfırlansınmı?", "Yenilə", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cavab == DialogResult.Yes)
            {
                lstSebet.Items.Clear();
                txtMebleg.Clear();
                txtQaliq.Clear();
                txtHesab.Clear();
            }
        }

        private void btnYekun_Click(object sender, EventArgs e)
        {
            if (lstSebet.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
                return;
            }
            decimal cem = 0;
            foreach (object yemek in lstSebet.Items)
                cem += qiymetler[yemek.ToString()];
            txtHesab.Text = Pul(cem);
        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            decimal hesab, mebleg;
            if (!Eded(txtHesab.Text, out hesab))
            {
                MessageBox.Show("Əvvəlcə \"Yekun hesab\" düyməsinə basın!");
                return;
            }
            if (!Eded(txtMebleg.Text, out mebleg))
            {
                MessageBox.Show("Məbləği düzgün daxil edin!");
                return;
            }
            if (mebleg < hesab)
            {
                MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                return;
            }
            txtQaliq.Text = Pul(mebleg - hesab);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtMebleg.Clear();
            txtQaliq.Clear();
        }
    }
}