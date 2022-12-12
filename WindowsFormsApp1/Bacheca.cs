using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Bacheca
    {
        private const int max = 100;

        public string id;

        private Annuncio[] annunci = new Annuncio[max];

        public Bacheca (string id)
        {
            Id = id; 
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public Annuncio GetAnnuncio(int a)
        {
            return annunci[a];
        }
        private int getNumAnnunci()
        {
            int c=0;
            while (c<annunci.Length && annunci[c] != null)
            {
                c++;
            }

            if( c != annunci.Length)
            {
                return c;   

            }
            else
            {
                throw new Exception("Bacheca piena billone");
            }
        }

       public void Aggiungi (Annuncio x)
        {
            if (x != null)
            {
                annunci[getNumAnnunci()] = x;

            }
        }

        public int Cerca(Annuncio e)
        {
            int pos = -1;
            for (int t = 0; t < max; t++)
            {
                if (annunci[t] == e)
                {
                    pos = t;
                }
            }
            return pos;
        }

        public string[] CercaperId(string id)
        {
            string[] ids = new string[4];
                for (int i = 0; i < max; i++)
            {
                if (annunci[i] != null)
                {
                    if (annunci[i].id == id)
                    {
                            ids[i] = annunci[i].testo;
                            ids[i] = annunci[i].nome;
                            ids[i] = annunci[i].data;
                            ids[i] = annunci[i].costo.ToString();

                    }
                }
            }
            return ids;
        }

        public void Elimina (string id)
        {
              for( int i = 0; i < max; i++)
            {
                if( annunci[i] != null)
                {
                    if (annunci[i].id == id)
                    {
                        annunci[i] = null;
                    }
                }
            }
        }

        public void Mod(string id,Annuncio input)
        {
            for(int i = 0; i < max; i++)
            {
                if (annunci[i] != null)
                {
                    if (annunci[i].id == id)
                    {
                        annunci[i] = null;
                        annunci[i] = input;
                    }
                }
            }
        }

        public void Ordina()
        {
            int x=getNumAnnunci();
           Annuncio temp;
            for(int i=0; i <= x - 1; i++)   
            {
                for(int e=0; e <= x - 1; e++)
                {
                    if (annunci[e + 1] != null)
                    {
                        if (annunci[i].costo > annunci[e + 1].costo)
                        {
                            temp = annunci[e + 1];
                            annunci[e+1]= annunci[e];
                            annunci[e] = temp;
                        }
                    }
                }
            }

        }

        public int Prezzo()
        {
            int totale = 0; 
            for( int i = 0; i < annunci.Length; i++)
            {
                if(annunci[i] != null)
                {
                    totale = totale + annunci[i].costo;
                }
            }

            return totale;
        }
    }
}
