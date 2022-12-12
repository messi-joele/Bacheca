using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Annuncio
    {
        public string id;
        public string nome;
        public string testo;
        public string data;
        public int costo;

        public Annuncio(string id, string testo,string nome, string data, int costo)
        {
            Id = id;
            Nome = nome;
            Testo = testo;
            Data = data;
            Costo = costo;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Testo
        {
            get { return id; }
            set {testo = value;}
        }

        public string Data
        {
            get { return data; }
            set {data = value;}
        }

        public int Costo
        {
            get { return costo; }
            set {
                if (value > 0)
                    costo = value;
                else
                {
                    throw new Exception("costo non valito inserire numero positivo   ");

                }
            }
        }

        public string[] ToString()
        {
            string[] p = { id, nome, testo, data, Convert.ToString(costo) };
            return p;
        }
    }
}
