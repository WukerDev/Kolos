using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wiktor_Kozakowski
{
    public partial class Form1 : Form
    {
        //sekcja konfiguracji
        string selected;
        string nazwa_towaru;
        string jednostka;
        int ilosc;
        string[] ComboRange = { "metr", "kg", "litr" };

        public Form1()
        {
            InitializeComponent();
            ComboBoxLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BazaZapis();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = ComboRange[comboBox1.SelectedIndex]; 
        }
        private void ComboBoxLoad()
        {
            comboBox1.Items.AddRange(ComboRange.ToArray());
        }
        private void BazaZapis()
        {
            nazwa_towaru = textBox1.Text;
            jednostka = selected;
            ilosc = Convert.ToInt32(textBox2.Text);
            using (var db = new obsluga())
            {
                StanMagazynowy stanMagazynowy = new StanMagazynowy
                {
                    Ilosc = ilosc
                 };
                db.StanMagazynowy.Add(stanMagazynowy);
                db.SaveChanges();
                int stanMagazynowyLenght = db.StanMagazynowy.Count();
                Towar towar = new Towar
                {
                    TowarNazwa = nazwa_towaru,
                    Jednostka = jednostka,
                    FK = stanMagazynowyLenght
                };
                db.Towar.Add(towar);
                db.SaveChanges();
            };
                

        }
    }
}


