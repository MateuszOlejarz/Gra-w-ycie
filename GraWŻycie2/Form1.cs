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

namespace GraWŻycie2
{
    public partial class Form1 : Form
    {
        bool[,] Tab;
        Button[,] Tab1;
        private int Wysokosc;
        private int Szerokosc;
        private int przyciskUmarł = 0;
        private int przyciskZyje = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void MojaPlansza(int w, int s)
        {
            Wysokosc = w;
            Szerokosc = s;
            Tab1 = new Button[Wysokosc, Szerokosc];
            Tab = new bool[Wysokosc, Szerokosc];
            timer1.Tick += Generowanie;
            this.Name = w.ToString() + "s" + s.ToString();
            this.Text = this.Name;
            for (int i = 0; i < Wysokosc; i++)
            {
                for (int j = 0; j < Szerokosc; j++)
                {
                    Tab1[i, j] = new Button();
                    Tab1[i, j].BackColor = Color.Blue;
                    Tab1[i, j].Name = i.ToString() + " " + j.ToString();
                    Tab1[i, j].Location = new Point(j * 45 + 3, i * 45 + 3);
                    Tab1[i, j].Size = new Size(50, 50);
                    panel1.Controls.Add(Tab1[i, j]);
                    Tab1[i, j].Enabled = false;
                    Tab1[i, j].Click += new EventHandler(Klikamy_Click);
                }
                panel1.Location = new Point(panel1.Width);
            }
        }
            private void Generowanie(object sender, EventArgs e)
        {
            bool[,] ij_tablica = new bool[Wysokosc, Szerokosc];
            int ZywySasiedniPrzycisk = 0;
            for (int i = 0; i < Wysokosc; i++)
            {
                for (int j = 0; j < Szerokosc; j++)
                {
                    ZywySasiedniPrzycisk = PrzyciskiSasiedzi(i, j);
                    if (Tab[i, j])
                    {
                        if (ZywySasiedniPrzycisk == 2 || ZywySasiedniPrzycisk == 3)
                        {
                            ij_tablica[i, j] = true;
                        }
                        if (ZywySasiedniPrzycisk < 2 || ZywySasiedniPrzycisk > 3)
                        {
                            ij_tablica[i, j] = false;
                        }
                    }
                    else
                    {
                        if (ZywySasiedniPrzycisk == 3)
                            ij_tablica[i, j] = true;
                    }
                }
            }
            Tab = ij_tablica;
            przyciskUmarł = 0;
            przyciskZyje = 0;
            for (int i = 0; i < Wysokosc; i++)
            {
                for (int j = 0; j < Szerokosc; j++)
                {
                    if (Tab[i, j] == true)
                    {
                        Tab1[i, j].BackColor = Color.Black;
                        przyciskZyje++;
                    }
                    else
                    {
                        Tab1[i, j].BackColor = Color.Blue;
                        przyciskUmarł++;
                    }
                }
            }
        }
        private void Klikamy_Click(object sender, EventArgs e)
        {
            String[] tab1 = (sender as Button).Name.Split(' ');
            int a = Int32.Parse(tab1[0]);
            int b= Int32.Parse(tab1[1]);
            if ((sender as Button).BackColor == Color.Blue)
            {
                (sender as Button).BackColor = Color.Black;
                Tab[a,b] = true;
                przyciskZyje++;
                przyciskUmarł--;
            }
            else
            {
                (sender as Button).BackColor = Color.Blue;

                Tab[a,b] = false;
                przyciskUmarł++;
                przyciskZyje--;
            }
        }
        public int PrzyciskiSasiedzi(int a, int b)
        {
            int sasiadniPrzycisk = 0;
            for (int i = b - 1; i <= b + 1; i++)
            {
                for (int j = a - 1; j <= a + 1; j++)
                {
                    if (i < 0 || i > Szerokosc - 1 || j < 0 || j > Wysokosc - 1 || (i == b && j == a))
                        continue;
                    if (Tab1[j, i].BackColor == Color.Black)
                        sasiadniPrzycisk++;
                }
            }
            return sasiadniPrzycisk;
        }
        public bool Przyciski(int a, int b)
        {
            int sasiedzi = PrzyciskiSasiedzi(a, b);
            if (Tab[a, b])
            {
                if (sasiedzi == 3 || sasiedzi == 2)
                    return true;
                if (sasiedzi <= 1 || sasiedzi > 3)
                    return false;
            }
            else
            {
                if (sasiedzi == 3) return true;
            }
            return false;
        }
        private void STOP_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void NOWAGRA_Click(object sender, EventArgs e)
        {
        }
        private void button6_Click_1(object sender, EventArgs e)
        {
            MojaPlansza(10, 10);
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            GRAJ.Visible = true;
        }
        private void GRAJ_Click(object sender, EventArgs e)
        {
            foreach (Button Kliknieto in Tab1)
            {
                Kliknieto.Enabled = true;
            }
            GRAJ.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            START.Visible = true;
            STOP.Visible = true;
            START.Enabled = true;
            WczytajPlansze.Enabled = true;
            ZapiszPlansze.Enabled = true;
            ZapiszPlansze.Visible = true;
        }
        private void START_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GRAJ.Enabled = false;
            STOP.Enabled = true;
        }
        private void STOP_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void WczytajPlansze_Click(object sender, EventArgs e)
        {
            przyciskUmarł = 0;
            przyciskZyje = 0;
            Stream myStream = null; ;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Users\\Mati\\inne\\Documents\\Visual Studio 2015\\Projects\\NaZaliczenie\\GraWŻycie2";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        String line;
                        using (StreamReader sr = new StreamReader(myStream))
                        {
                            for (int i = 0; i < Wysokosc; i++)
                            {
                                line = sr.ReadLine();
                                for (int j = 0; j < Szerokosc; j++)
                                {
                                    if (line.ElementAt(j) == '1')
                                    {
                                        Tab1[i, j].BackColor = Color.Blue;
                                        Tab[i, j] = true;
                                        przyciskZyje++;
                                    }
                                    else
                                    {
                                        Tab1[i, j].BackColor = Color.DarkRed;
                                        Tab[i, j] = false;
                                        przyciskUmarł++;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
                GRAJ.Enabled = true;
                GRAJ.Visible = true;
                START.Enabled = true;
                STOP.Enabled = false;
            }
        }
        private void ZapiszPlansze_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = "C:\\Users\\Mati\\inne\\Documents\\Visual Studio 2015\\Projects\\NaZaliczenie\\GraWŻycie2";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    int i = 0;
                    int ile = 0;
                    String[] line = new String[Wysokosc];
                    using (StreamWriter sw = new StreamWriter(myStream))
                    {
                        foreach (Control kom in Tab1)
                        {
                            if (kom is Button)
                            {
                                if (kom.BackColor == Color.Blue)
                                {
                                    line[i] += "1";
                                }
                                else
                                {
                                    line[i] += "0";
                                }
                            }
                            ile++;
                            if (ile % Szerokosc == 0 || ile == 0)
                            {
                                sw.WriteLine(line[i]);
                                i++;
                            }
                        }
                    }
                    myStream.Close();
                }
            }
    }
        private void button7_Click(object sender, EventArgs e)
        {
            MojaPlansza(10, 15);
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            GRAJ.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            MojaPlansza(15, 15);
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            GRAJ.Visible = true;
        }
    }
}
