using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bacheca b1 = new Bacheca("b1");
        public int counter = 0; 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Aggiorna()
        {
            Lista.Items.Clear();
            for(int i = 0; i < 100; i++)
            {
                if(b1.Cerca(b1.GetAnnuncio(i)) != -1)
                {
                    Annuncio a = b1.GetAnnuncio(i);
                    if(a != null)
                    {
                        ListViewItem itm;
                        itm = new ListViewItem(a.ToString());
                        Lista.Items.Add(itm);

                    }
                }
            }

        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            Annuncio annuncioa = new Annuncio (counter.ToString(), nomeTxt.Text, descTxt.Text, dateBox.Text, Convert.ToInt32(CostoTxt.Text));

            b1.Aggiungi(annuncioa);
            counter++;
            Aggiorna();

            nomeTxt.Text = null;
            descTxt.Text = null;
            CostoTxt.Text=null; 
        }

        private void CercaButton_Click(object sender, EventArgs e)
        {
            string[] stringa = new string[4];
            stringa = b1.CercaperId(Idtxt.Text);

            nomeTxt.Text = stringa[0];
            descTxt.Text = stringa[1];
            dateBox.Text = stringa[2];
            CostoTxt.Text = stringa[3];
        }

        private void Modifica_Click(object sender, EventArgs e)
        {
            Annuncio annuncioa = new Annuncio(counter.ToString(), nomeTxt.Text, descTxt.Text,dateBox.Text, Convert.ToInt32(CostoTxt.Text));
            b1.Mod(Idtxt.Text, annuncioa);
            Aggiorna();
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            b1.Elimina(Idtxt.Text);
            Aggiorna();
        }

        private void Ordina_Click(object sender, EventArgs e)
        {
            b1.Ordina();
            Aggiorna();
        }

        private void PrezzoTot_Click(object sender, EventArgs e)
        {
            PrezzoTot.Text = null;
            PrezzoTot.Text = b1.Prezzo().ToString();
        }
    }
}
