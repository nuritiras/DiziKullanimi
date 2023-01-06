using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziKullanimi
{
    public partial class Dizi : Form
    {
        int[] OgrNo=new int[3] ;
        string[] AdSoyad= new string[3] ;
        bool[] Cinsiyet=new bool[3] {true,true,false};
        double[] Ortalma=new double[3] {10.0,20.5,30.30};
    

        public Dizi()
        {
            InitializeComponent();
            OgrNo[0] = 486;
            OgrNo[1] = 654;
            OgrNo[2] = 999;
            AdSoyad[0] = "Süleyman";
            AdSoyad[1] = "Eren";
            AdSoyad[2] = "Fatma";
            Cinsiyet[1] = false;
            Cinsiyet[3] = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
