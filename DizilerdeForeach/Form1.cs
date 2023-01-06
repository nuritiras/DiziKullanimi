using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DizilerdeForeach
{
    public partial class Form1 : Form
    {
        string[] isimler = new string[5]; //Global Dizi.
        int index = 0; //Global Değişken.
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler[index] = txtAdSoyad.Text;
            index++;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    lbListe.Items.Add(isimler[i]);
            //}

            foreach (var isim in isimler)
            {
                lbListe.Items.Add(isim);
            }
        }
    }
}
