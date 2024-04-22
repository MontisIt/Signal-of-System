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
using System.IO;
using System.Threading;

namespace Signal_of_System
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool scan_short_circuit=true;

        CancellationTokenSource currentOperationTioken;

        public MainWindow()
        {
            InitializeComponent();

        }
        private bool Random_bool_number()
        {
            Random rnd = new Random();
            bool random = (rnd.Next(2)==0);
            
            return random;
        }
        private void Scan_Click(object sender, RoutedEventArgs e)
        {
            scan_short_circuit = Random_bool_number();
           
            Health_Signal_of_Short_circuit.Content = scan_short_circuit ? "Хорошее" : "Плохое";
            Health_Signal_of_Short_circuit.Background = scan_short_circuit ?  Brushes.Green : Brushes.Red;

        }

        private void Short_circuit_button_detailed_Click(object sender, RoutedEventArgs e)
        {
            Short_circuit short_Circuit = new Short_circuit();
            short_Circuit.Show();
            Hide();
        }

       
    }




}
