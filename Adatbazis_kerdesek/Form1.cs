using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Windows.Media;
using System.Globalization;
using Brushes = System.Windows.Media.Brushes;
using System.Media;

namespace Adatbazis_kerdesek
{
    public partial class Form1 : Form
    {
        Stopwatch stopper = new Stopwatch();
        List<Kerdes> kerdesek = new List<Kerdes>();
        Kerdes kerdes;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_Elteltido.Text = "";
            label_adatbazis.Text = "";
            label_Kerdes.Text = "";
        }
 

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Elteltido.Text = stopper.Elapsed.ToString("mm\\:ss");
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox_Nev.Text.Trim()))
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Add meg a neved!");
                textBox_Nev.Focus();
                return;
            }
            Random r = new Random();
            kerdesek.Clear();
            if (checkBox_Orszagok.Checked)
            {
                kerdesek.AddRange(Program.kerdesek.FindAll(x => x.Db.Equals("orszagok")));
            }
            if (checkBox_Pizza.Checked)
            {
                kerdesek.AddRange(Program.kerdesek.FindAll(x => x.Db.Equals("pizza")));
            }
            if (checkBox_Tagdij.Checked)
            {
                kerdesek.AddRange(Program.kerdesek.FindAll(x => x.Db.Equals("tagdij")));
            }
            if (kerdesek.Count<1)
            {
                MessageBox.Show("Nincsenek kijelölt adatbázisok");
                return;
            }
            kerdes = Program.kerdesek[r.Next(0,kerdesek.Count)];
            label_adatbazis.Text = "<" + kerdes.Db + "> adatbázis";
            label_Kerdes.Text = kerdes.Szoveg;
            
            timer1.Enabled = Enabled;
            stopper.Restart();
            stopper.Start();
            textBox_Valasz.Text = "SELECT ";
            textBox_Valasz.SelectionStart = textBox_Valasz.Text.Length;
            textBox_Valasz.Focus();
            SystemSounds.Beep.Play();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stopper.Stop();
            eredmenytMent();
        }

        private void eredmenytMent()
        {

        }
 
    }
}
