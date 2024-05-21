using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Signal_of_System
{
    /// <summary>
    /// Логика взаимодействия для RAM_SLOTS.xaml
    /// </summary>
    public partial class RAM_SLOTS : Window
    {
        public bool btcheck_signal = MainWindow.scan_ram_slots;

        public bool mather_board = false;

        public bool A1_check = false;
        public bool A2_check = false;
        public bool B1_check = false;
        public bool B2_check = false;


        public RAM_SLOTS()
        {
            InitializeComponent();
        }

        private void Back_from_RAM_SLOTS_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Repair_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.btrepair_ram_slots = true;
            if (btcheck_signal == false)
            {
                MainWindow.scan_ram_slots = true;
                btcheck_signal = true;
                result_repair_textblock.Text = "Ремонт неисправности прошел успешно";
            }
            else
            {
                result_repair_textblock.Text = "Неисправность для ремонта не была найдена ";
            }
        }

        private void Scan_RAM_SLOTS(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double randomNumber;
            bool randomBOOL;
            randomBOOL = (random.Next(2) == 0);
            if (mather_board)
            {
                if (btcheck_signal)
                {

                    randomNumber = random.NextDouble();
                    VDD.Content = Math.Round(1 + 0.2 + (randomNumber / 100), 3); //напряжение питания памяти (указан только один из контактов).
                    VDDSPD.Content = Math.Round(3 + 0.3 + (random.NextDouble() / 100), 3); //напряжение питания микросхемы, хранящей данные SPD.
                    VREF.Content = Math.Round((1 + 0.2 + (randomNumber / 100)) / 2, 3); //опорное напряжение, как правило, равно VDD/2.
                    VTT.Content = Math.Round((1 + 0.2 + (randomNumber / 100)) / 2, 3);//напряжение терминации памяти, как правило, равно VDD/2
                    VPP.Content = Math.Round(2 + 0.5 + (random.NextDouble() / 100), 3); //напряжение активации памяти.

                }
                else
                {
                    double VDDvalue = 0;
                    randomNumber = random.NextDouble();
                    if ((random.Next(2) == 0) == false)
                    {
                        VDD.Content = Math.Round(0 + 0.8 + (randomNumber / 100), 3);
                        VDDvalue = Math.Round(0 + 0.8 + (randomNumber / 100), 3);

                    }
                    else
                    {
                        VDD.Content = Math.Round(1 + 0.2 + (randomNumber / 100), 3);
                        VDDvalue = Math.Round(0 + 0.8 + (randomNumber / 100), 3);
                    }

                    if ((random.Next(2) == 0) == false)
                    {
                        VDDSPD.Content = Math.Round(2 + 0.7 + (random.NextDouble() / 100), 3);

                    }
                    else { VDDSPD.Content = Math.Round(3 + 0.3 + (random.NextDouble() / 100), 3); }

                    VREF.Content = Math.Round(VDDvalue / 2, 3); //опорное напряжение, как правило, равно VDD/2.
                    VTT.Content = Math.Round(VDDvalue / 2, 3);//напряжение терминации памяти, как правило, равно VDD/2

                    if ((random.Next(2) == 0) == false)
                    {
                        VPP.Content = Math.Round(1 + 0.9 + (random.NextDouble() / 100), 3);

                    }
                    else { VPP.Content = Math.Round(2 + 0.5 + (random.NextDouble() / 100), 3); }


                }
            }

        }

       

        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (mather_board)
            {
                A1_check = true;
                A2_check = false;
                B1_check = false;
                B2_check = false;

                A1.Background = Brushes.WhiteSmoke;
                A2.Background = null;
                B1.Background = null;
                B2.Background = null;

                A1.Foreground = Brushes.Black;
                A2.Foreground = Brushes.WhiteSmoke;
                B1.Foreground = Brushes.WhiteSmoke;
                B2.Foreground = Brushes.WhiteSmoke;

            }
        }

        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (mather_board)
            {
                A1_check = false;
                A2_check = true;
                B1_check = false;
                B2_check = false;

                A1.Background = null;
                A2.Background = Brushes.WhiteSmoke;
                B1.Background = null;
                B2.Background = null;

                A1.Foreground = Brushes.WhiteSmoke;
                A2.Foreground = Brushes.Black;
                B1.Foreground = Brushes.WhiteSmoke;
                B2.Foreground = Brushes.WhiteSmoke;
            }
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (mather_board)
            {
                A1_check = false;
                A2_check = false;
                B1_check = true;
                B2_check = false;

                A1.Background = null;
                A2.Background = null;
                B1.Background = Brushes.WhiteSmoke;
                B2.Background = null;

                A1.Foreground = Brushes.WhiteSmoke;
                A2.Foreground = Brushes.WhiteSmoke;
                B1.Foreground = Brushes.Black;
                B2.Foreground = Brushes.WhiteSmoke;
            }
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (mather_board)
            {
                A1_check = false;
                A2_check = false;
                B1_check = false;
                B2_check = true;

                A1.Background = null;
                A2.Background = null;
                B1.Background = null;
                B2.Background = Brushes.WhiteSmoke;

                A1.Foreground = Brushes.WhiteSmoke;
                A2.Foreground = Brushes.WhiteSmoke;
                B1.Foreground = Brushes.WhiteSmoke;
                B2.Foreground = Brushes.Black;
            }
        }

        private void run_turn_off_the_motherboard(object sender, RoutedEventArgs e)
        {
            mather_board = mather_board ? false : true;
            
                A1.Background = null;
                A2.Background = null;
                B1.Background = null;
                B2.Background = null;

                A1.Foreground = Brushes.WhiteSmoke;
                A2.Foreground = Brushes.WhiteSmoke;
                B1.Foreground = Brushes.WhiteSmoke;
                B2.Foreground = Brushes.WhiteSmoke;

            if(mather_board)
            {
                run_turn_off_the_motherboard_button.Background = Brushes.Green;
            }
            else
            {
                run_turn_off_the_motherboard_button.Background = Brushes.Red;
            }
            

        }
    }
}
