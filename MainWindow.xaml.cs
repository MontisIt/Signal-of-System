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
using System.Collections;
using System.Windows.Resources;

namespace Signal_of_System
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public static bool scan_short_circuit = true;
        public static bool scan_south_bridge = true;
        public static bool scan_bios=true;
        public static bool scan_cmos= true;
        public static bool scan_pci_e = true;
        public static bool scan_ram_slots = true;

        public static bool btrepair_short_circuit = false;

        public static bool btrepair_south_bridge = false;

        public static bool btrepair_bios = false;

        public static bool btrepair_cmos = false;

        public static bool btrepair_pci_e = false;

        public static bool btrepair_ram_slots = false;


        public static bool start=false;

        public static bool turn_on_pc = false;



        CancellationTokenSource currentOperationTioken;

        public MainWindow()
        {
            InitializeComponent();


            if (btrepair_short_circuit == true || start==false) {
                //Короткое замыкание
                Health_Signal_of_Short_circuit.Content = "Состояние: напряжение в норме"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_Short_circuit.Background = Brushes.Green;
            }
            else
            {
                Health_Signal_of_Short_circuit.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_Short_circuit.Background = Brushes.WhiteSmoke;
            }

            if (btrepair_south_bridge || start == false)
            {
                //Южный Мост
                Health_Signal_of_South_Bridge.Content = "Состояние: напряжение в норме";
                Health_Signal_of_South_Bridge.Background = Brushes.Green;
            }
            else
            {
                Health_Signal_of_South_Bridge.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_South_Bridge.Background = Brushes.WhiteSmoke;
            }

            if (btrepair_bios || start == false) {
                //BIOS
                Health_Signal_of_BIOS.Content = "Состояние:  исправно"; //: "Неисправна";
                Health_Signal_of_BIOS.Background =  Brushes.Green;
            }
            else
            {
                Health_Signal_of_BIOS.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_BIOS.Background = Brushes.WhiteSmoke;
            }

            if (btrepair_pci_e || start == false)
            {
                //PCI_E
                Health_Signal_of_PCI_E.Content =  "Состояние:  исправно"; //: "Неисправна";
                Health_Signal_of_PCI_E.Background = Brushes.Green;
            }
            else
            {
                Health_Signal_of_PCI_E.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_PCI_E.Background = Brushes.WhiteSmoke;
            }


            if (btrepair_cmos || start == false)
            {
                //CMOS
                Health_Signal_of_CMOS.Content = "Состояние:  исправно"; //: "Неисправна";
                Health_Signal_of_CMOS.Background = Brushes.Green;
            }
            else
            {
                Health_Signal_of_CMOS.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_CMOS.Background = Brushes.WhiteSmoke;
            }

            if (btrepair_ram_slots || start == false)
            {
                //RAM_SLOTS
                Health_Signal_of_RAM_SLOTS.Content = "Состояние: напряжение в норме"; //: "Неисправна";
                Health_Signal_of_RAM_SLOTS.Background = Brushes.Green;
            }
            else
            {
                Health_Signal_of_RAM_SLOTS.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
                Health_Signal_of_RAM_SLOTS.Background = Brushes.WhiteSmoke;
            }


        }
        private bool Random_bool_number()
        {
            Random rnd = new Random();
            bool random = (rnd.Next(2)==0);
            
            return random;
        }
        private void Scan_Click(object sender, RoutedEventArgs e)
        {
            start = true;
            WINDOW.Source = new BitmapImage(new Uri("/black_window.png", UriKind.Relative));
            Ellipse_On_off.Fill = Brushes.Red;
            

            Random rnd = new Random();

            //Короткое замыкание
            scan_short_circuit = (rnd.Next(2) == 0);
            Health_Signal_of_Short_circuit.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
            Health_Signal_of_Short_circuit.Background = Brushes.WhiteSmoke;
            //Южный Мост
            scan_south_bridge = (rnd.Next(2) == 0);
            Health_Signal_of_South_Bridge.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
            Health_Signal_of_South_Bridge.Background = Brushes.WhiteSmoke;
            //BIOS
            scan_bios = (rnd.Next(2) == 0);
            Health_Signal_of_BIOS.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
            Health_Signal_of_BIOS.Background = Brushes.WhiteSmoke;
            //CMOS
            scan_cmos = (rnd.Next(2) == 0);
            Health_Signal_of_CMOS.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
            Health_Signal_of_CMOS.Background = Brushes.WhiteSmoke;
            //PCI-E
            scan_pci_e = (rnd.Next(2) == 0);
            Health_Signal_of_PCI_E.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
            Health_Signal_of_PCI_E.Background = Brushes.WhiteSmoke;
            //RAM_SLOTS
            scan_ram_slots = (rnd.Next(2) == 0);
            Health_Signal_of_RAM_SLOTS.Content = "Состояние: неизвестно"; //: "Состояние: Имеются отклонения";
            Health_Signal_of_RAM_SLOTS.Background = Brushes.WhiteSmoke;

        }

        private void Short_circuit_button_detailed_Click(object sender, RoutedEventArgs e)
        {
            Short_circuit short_Circuit = new Short_circuit();
            short_Circuit.Show();
            Hide();
        }

        private void South_Bridge_button_detailed_Click(object sender, RoutedEventArgs e)
        {
            South_Bridge south_Bridge = new South_Bridge();
            south_Bridge.Show();
            Hide();
        }

        private void BIOS_button_detailed_Click(object sender, RoutedEventArgs e)
        {
           BIOS bios = new BIOS();
           bios.Show();
           Hide();
        }

        private void CMOS_button_detailed_Click(object sender, RoutedEventArgs e)
        {
            CMOS cmos = new CMOS();
            cmos.Show();
            Hide();
        }

        private void PCI_E_button_detailed_Click(object sender, RoutedEventArgs e)
        {
            PCI_E pci_e = new PCI_E();
            pci_e.Show();
            Hide();
        }

        private void RAM_SLOTS_button_detailed_Click(object sender, RoutedEventArgs e)
        {
           RAM_SLOTS ram_slots = new RAM_SLOTS();
            ram_slots.Show();
            Hide();
        }

        private void ON_mother_board_button_Click(object sender, RoutedEventArgs e)
        {
            

            turn_on_pc = turn_on_pc ? false : true;
            if (turn_on_pc)
            {
                if (scan_short_circuit && scan_south_bridge && scan_bios && scan_cmos && scan_pci_e && scan_ram_slots)
                {
                    
                   
                    WINDOW.Source = new BitmapImage(new Uri("/W10_USER_TABLE.png", UriKind.Relative));
                    Ellipse_On_off.Fill = Brushes.Green;
                    




                }
                else
                {

                   
                    WINDOW.Source = new BitmapImage(new Uri("/black_window.png", UriKind.Relative));
                    Ellipse_On_off.Fill = Brushes.Green;
                    

                }
            }
            else
            {
                WINDOW.Source = new BitmapImage(new Uri("/black_window.png", UriKind.Relative));
                Ellipse_On_off.Fill = Brushes.Red;
                

            }
        }

       
    }




}
