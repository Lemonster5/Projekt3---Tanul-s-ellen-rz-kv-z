using System;
using System.Collections.Generic;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tantargyak.Items.Add("Fizika");
            tantargyak.Items.Add("Történelem");
            tantargyak.Items.Add("Irodalom");
        }

        private void tantargyak_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (tantargyak.SelectedItem=="Fizika")
            {
                temakor.Items.Clear();
                temakor.Items.Add("Rezgések és hullámok");
                temakor.Items.Add("Erőtan");
            }
            else if (tantargyak.SelectedItem == "Történelem")
            {
                temakor.Items.Clear();
                temakor.Items.Add("Középkor");
                temakor.Items.Add("Magyar történelem");
            }
            else 
            {
                temakor.Items.Clear();
                temakor.Items.Add("Orosz irodalom");
                temakor.Items.Add("Nyugat I. Nemzedéke");
            }

        } 

    private void feladatokGeneralasa_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
