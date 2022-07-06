using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2101681070_VeselaApostolova_domashna_rabota.Zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox2.Image;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox3.Image;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox4.Image;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox5.Image;
        }
        float backpack = 45;
        float windows = 105;
        double izplashtane = 0.20;
        double basePrice = 2986.8;
        double total = 0;

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {

                total = basePrice * double.Parse(tbBroi.Text);
            }
            catch (Exception excep)
            {
                MessageBox.Show("Enter quantity!!!");
            }
            MessageBox.Show($"Вие успешно закупихте лаптоп ASUS G750JZ-T4039D \nЦена: {Math.Round(basePrice*double.Parse(tbBroi.Text),0)}лв","Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cbWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWindows.CheckState == CheckState.Checked)
            {
                 basePrice += windows;
                lbCena.Text = Math.Round(total + basePrice,0) + "лв";
                lbCenaIzplashtane.Text = "Цена на лизинг:12x0лв";
                lbCharact.Text = "OC Windows 8.1 \nProcessor:Intel Core i7 Quad Core \nRAM: 8GB  \nDisplay:17.6' \nVideo card:NIVIDIA GForce 720";
            }
        }

        private void cbBackpack_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBackpack.CheckState == CheckState.Checked)
            {
                basePrice+= backpack;
                lbCena.Text =Math.Round( total + basePrice,0) + "лв";
                lbCenaIzplashtane.Text = "Цена на лизинг:12x0лв";
            }
        }

        private void cbIzplashtane_CheckedChanged(object sender, EventArgs e)
        {
            double rezultatIzplashtane = 0;
            if (cbIzplashtane.CheckState == CheckState.Checked)
            {
                rezultatIzplashtane= (basePrice/12)+(basePrice*izplashtane);
                lbCena.Text = Math.Round(total+basePrice)+"лв";
                lbCenaIzplashtane.Text = "Цена на лизинг:12X " + Math.Round(rezultatIzplashtane,0) + "лв.";
            }
        }

        private void lbCenaIzplashtane_Click(object sender, EventArgs e)
        {

        }

        private void tbBroi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Искате ли да изтриете поръчката си?", "Изтриване на поръчка",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            cbBackpack.CheckState = CheckState.Unchecked;
            cbIzplashtane.CheckState = CheckState.Unchecked;
            cbWindows.CheckState = CheckState.Unchecked;
            lbCena.Text = string.Empty;
            lbCenaIzplashtane.Text = string.Empty;
            tbBroi.Text = string.Empty;
        }
    }
}
