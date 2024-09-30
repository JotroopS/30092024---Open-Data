using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _30092024___Open_Data
{
    public partial class Form1 : Form
    {
        Lista pers = new Lista();
        public Form1()
        {
            InitializeComponent();
        }
        class Lista
        {
            public List<Persona> Perso = new List<Persona>();
        }
        class Persona
        {
            public Persona(string popolarità, string datarilascio, string titolo, string voto)
            {
                this.popolarità = popolarità;
                this.datarilascio = datarilascio;
                this.titolo = titolo;
                this.voto = voto;
            }
            public string popolarità;
            public string datarilascio;
            public string titolo;
            public string voto;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var file = new FileStream("TopRatedMovies.csv", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file);
            string riga = sr.ReadLine();
            int i = 0;
            while (riga != null)
            {
                string[] dati = riga.Split(',');
                Persona persone = new Persona(dati[0], dati[1], dati[2], dati[3]);
                pers.Perso.Add(persone);
                riga = sr.ReadLine();
                lista.Items.Add(pers.Perso[i].popolarità + "," + pers.Perso[i].datarilascio + "," + pers.Perso[i].titolo + "," + pers.Perso[i].voto);
                i++;
            }
            sr.Close();
            file.Close();
        }
    }
}
