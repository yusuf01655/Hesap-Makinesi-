using System;
using System.Windows.Forms;
namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        bool esittirBasildi = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void RakamOlay(object sender, EventArgs e)
        {
            if (esittirBasildi)
            {
                txtSonuc.Clear();
                lbSonuc.Text = "";
                esittirBasildi = false;
                opt = "";

            }
            if (txtSonuc.Text == "0" || optDurum)
                txtSonuc.Clear();
            optDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text += btn.Text;
        }
        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOpt;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }
        private void button19_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            sonuc = 0;
            opt = "";
            lbSonuc.Text = "";
            optDurum = false;
        }
        private void button17_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = "";
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + Double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - Double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * Double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / Double.Parse(txtSonuc.Text)).ToString(); break;
            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            esittirBasildi = true;
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (!txtSonuc.Text.Contains(","))
                txtSonuc.Text += ",";
        }

    }
}