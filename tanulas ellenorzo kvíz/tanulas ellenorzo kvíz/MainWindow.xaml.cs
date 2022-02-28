using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tanulas_ellenorzo_kvíz
{
    

    public partial class MainWindow : Window
    {
        static List<Kerdes> kerdesek;
        public MainWindow()
        {
            InitializeComponent();
            tantargyak.Items.Add("Fizika");
            tantargyak.Items.Add("Történelem");
            tantargyak.Items.Add("Irodalom");
            temakor.IsEnabled = false;
           
        }
        public class Kerdes
        {
            public string tantargy;
            public string temakor;
            public string kerdes;
            public string helyesValasz;
            public string elsoRosszValasz;
            public string masodikRosszValasz;
            public string harmadikRosszValasz;
        }
        static List<Kerdes> egySor = new List<Kerdes>();
        private static void FajlBeolvasasa()
        {
            string[] fajlok = { "Fizika.txt" };
            for (int i = 0; i < fajlok.Length; i++)
            {
                string[] allomany = File.ReadAllLines(fajlok[i]);

                foreach (var sor in allomany)
                {
                    string[] sorE = sor.Split(';');
                    Kerdes adat = new Kerdes();
                    adat.tantargy = sorE[0];
                    adat.temakor = sorE[1];
                    adat.kerdes = sorE[2];
                    adat.helyesValasz= sorE[3];
                    adat.elsoRosszValasz= sorE[4];
                    adat.masodikRosszValasz= sorE[5];
                    adat.harmadikRosszValasz= sorE[6];
                    egySor.Add(adat);
                }
            }

        }

        private void tantargyak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tantargyak.SelectedItem=="Fizika")
            {
                temakor.Items.Clear();
                temakor.Items.Add("Rezgések és hullámok");
                temakor.Items.Add("Erőtan");
                temakor.IsEnabled = true;
            }
            else if (tantargyak.SelectedItem == "Történelem")
            {
                temakor.Items.Clear();
                temakor.Items.Add("Középkor");
                temakor.Items.Add("Magyar történelem");
                temakor.IsEnabled = true;
            }
            else 
            {
                temakor.Items.Clear();
                temakor.Items.Add("Orosz irodalom");
                temakor.Items.Add("Nyugat I. Nemzedéke");
                temakor.IsEnabled = true;
            }

        } 

            private void feladatokGeneralasa_Click(object sender, RoutedEventArgs e)
        {
            eloLap.Visibility = Visibility.Hidden;
            foLap.Visibility = Visibility.Visible;
            tantargy.Content = egySor[0+1];
        }
        private void temakor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }
    }
}
