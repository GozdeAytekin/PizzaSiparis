using PizzaSiparis.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pizzaları doldur.
            PizzaDoldur();
            //ekstra malzemeleri doldur.
            EkstraMalzemeleriDoldur();
            groupBox1.Enabled = btnSiparisiTamamla.Enabled = false;


        }

        private void EkstraMalzemeleriDoldur()
        {
            flMalzemeler.Controls.Add(new CheckBox() { Text = "Mısır", Tag = new Malzeme() { MalzemeAdi = "Mısır", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "Kornişon Turşu", Tag = new Malzeme() { MalzemeAdi = "Kornişon Turşu", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "Salam", Tag = new Malzeme() { MalzemeAdi = "Salam", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "sosis", Tag = new Malzeme() { MalzemeAdi = "sosis", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "yeşil zeytin", Tag = new Malzeme() { MalzemeAdi = "yeşil zeytin", MalzemeFiyati = 5 } });
        }

        private void PizzaDoldur()
        {
            //datasource
            cmbPizzalar.Items.AddRange((new List<Pizza>() {
            new Pizza()
            {
                Adi="Karışık Pizza",
                Fiyati=20,
                Malzemeleri= new List<Malzeme>(){
                    new Malzeme() { MalzemeAdi="Sucuk",MalzemeFiyati=5},
                    new Malzeme() { MalzemeAdi = "Salam", MalzemeFiyati = 5 },
                    new Malzeme() { MalzemeAdi = "Sosis", MalzemeFiyati = 5 } }
            },
          new Pizza()
            {
                Adi="Kayseri Ateşi Pizza",
                Fiyati=50,
                Malzemeleri= new List<Malzeme>(){
                    new Malzeme() { MalzemeAdi="Pastırma",MalzemeFiyati=5},
                    new Malzeme() { MalzemeAdi = "Kavurma", MalzemeFiyati = 5 },
                    new Malzeme() { MalzemeAdi = "Sosis", MalzemeFiyati = 5 } }
            },
          new Pizza()
            {
                Adi="Egeli Pizza",
                Fiyati=30,
                Malzemeleri= new List<Malzeme>(){
                    new Malzeme() { MalzemeAdi="Domates",MalzemeFiyati=5},
                    new Malzeme() { MalzemeAdi = "Peynir", MalzemeFiyati = 5 },
                    new Malzeme() { MalzemeAdi = "Roka", MalzemeFiyati = 5 } }
            }}).ToArray());
        }

        private void cmbPizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza secilen = cmbPizzalar.SelectedItem as Pizza;
            //lblIcerik.Text = secilen.Malzemeleri.Add(;
            string s = null;
            foreach (var item in secilen.Malzemeleri)
            {
                s += item.MalzemeAdi + " ";
            }
            lblIcerik.Text = s;
        }
    }
}
