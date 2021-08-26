using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quizza
{

    public partial class Quiz : Form
    {
        List<Fråga> Frågorna = new List<Fråga>();
        Random random = new Random();
        int aktuellFråga;
        int längd;
        int poäng;
        int svaret;

        // Importerar alla frågorna från textfilen och sparar dem som Frågor(klass) 
        public void Importera()
        {
            Frågorna.Clear();
            string filepath = "Frågorna.txt";
            StreamReader reader = new StreamReader(filepath, System.Text.Encoding.Default);
            using (reader)
            {
                string rad = "";
                while ((rad = reader.ReadLine()) != null)
                {
                    string[] variablerna = new string[6];
                    variablerna = rad.Split('#');
                    int variabel5 = Int32.Parse(variablerna[5]);
                    Fråga nyFråga = new Fråga(variablerna[0], variablerna[1], variablerna[2], variablerna[3], variablerna[4], variabel5);
                    Frågorna.Add(nyFråga);
                }
            }
        }
        public void NästaFråga()
        {
            int nästafråga;
            längd = Frågorna.Count;
            if (längd != 0)
            {
                random.Next(0, längd + 1);
                nästafråga = random.Next(0, längd);
                aktuellFråga = nästafråga;
                label1.Text = Frågorna[aktuellFråga].Frågan;
                button1_1.Text = Frågorna[aktuellFråga].svar1;
                button1_2.Text = Frågorna[aktuellFråga].svar2;
                button1_3.Text = Frågorna[aktuellFråga].svar3;
                button1_4.Text = Frågorna[aktuellFråga].svar4;
                svaret = Frågorna[aktuellFråga].rättsvar;
                Frågorna.RemoveAt(aktuellFråga);
            }
            else
            {
                MessageBox.Show("Grattis!! Du har klarat alla frågorna. Du fick " + poäng + " poäng!!");
                panel2.Visible = false;
                Importera();
            }
        }


        public int Randomfråga()
        {
            int nästafråga;
            längd = Frågorna.Count;
            random.Next(0, längd + 1);
            nästafråga = random.Next(0, längd);
            return nästafråga;

        }

        public Quiz()
        {
            InitializeComponent();
            panel2.Visible = false;
            Importera();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Startar quizzet
        private void button1_startQuiz_Click(object sender, EventArgs e)
        {
            poäng = 0;
            panel2.Visible = true;
            NästaFråga();

        }

        // Svarsalternativen till frågorna med händelsen vid tryck

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (svaret == 1)
            {
                poäng++;
                MessageBox.Show("Rätt!! +1 poäng, du har nu " + poäng + " poäng");
                NästaFråga();

            }
            else
            {
                MessageBox.Show("Tyvärr det var fel, prova spela igen för att se hur långt du kan komma. Du fick " + poäng + " poäng den här omgången");
                Importera();
                panel2.Visible = false;
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            if (svaret == 2)
            {
                poäng++;
                MessageBox.Show("Rätt!! +1 poäng, du har nu " + poäng + " poäng");
                NästaFråga();
            }
            else
            {
                MessageBox.Show("Tyvärr det var fel, prova spela igen för att se hur långt du kan komma. Du fick " + poäng + " poäng den här omgången");
                Importera();
                panel2.Visible = false;

            }
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            if (svaret == 3)
            {
                poäng++;
                MessageBox.Show("Rätt!! +1 poäng, du har nu " + poäng + " poäng");
                NästaFråga();
            }
            else
            {
                MessageBox.Show("Tyvärr det var fel, prova spela igen för att se hur långt du kan komma. Du fick " + poäng + " poäng den här omgången");
                Importera();
                panel2.Visible = false;

            }
        }

        private void button1_4_Click(object sender, EventArgs e)
        {
            if (svaret == 4)
            {
                poäng++;
                MessageBox.Show("Rätt!! +1 poäng, du har nu " + poäng + " poäng");
                NästaFråga();
            }
            else
            {
                MessageBox.Show("Tyvärr det var fel, prova spela igen för att se hur långt du kan komma. Du fick " + poäng + " poäng den här omgången");
                Importera();
                panel2.Visible = false;

            }
        }

        private void button3_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
