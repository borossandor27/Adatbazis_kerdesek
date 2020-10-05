using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Adatbazis_kerdesek
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<Kerdes> kerdesek = new List<Kerdes>();
        static void Main()
        {
            Beolvas("orszagok", @"kerdesek\kerdesek_orszagok.txt");
            Beolvas("pizza", @"kerdesek\kerdesek_pizza.txt");
            Beolvas("tagdij", @"kerdesek\kerdesek_tagdij.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        static void Beolvas(string db, string fajl)
        {
            StreamReader sr = null;
            try
            {
                using (sr = new StreamReader(fajl))
                {
                    while (!sr.EndOfStream)
                    {
                        kerdesek.Add(new Kerdes(db, sr.ReadLine()));                    
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("\nProgram vége!");
                Environment.Exit(0);
            }
        }
    }
}
