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
using System.Windows.Shapes;

namespace Signal_of_System
{
    /// <summary>
    /// Логика взаимодействия для CMOS.xaml
    /// </summary>
    public partial class CMOS : Window
    {
        public bool btcheck_signal = MainWindow.scan_cmos;
        public bool btcheck_CMOS=false;

        public CMOS()
        {
            InitializeComponent();
        }

        

        private void Back_from_CMOS_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Scan_CMOS(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double randomNumber;
            double randomNumber_2;
            double randomNumber_3;
            bool randomBoolean;

            if (btcheck_CMOS)
            {

                if (btcheck_signal)
                {
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(3 + 0.2 + (randomNumber / 100), 3);

                    //Om.Content = 0;//Math.Round(random.Next(50, 60) + randomNumber, 3);

                    //Amper.Content = 0;// Math.Round(random.Next(30, 32) + randomNumber, 2);

                    //Volt.Background = Brushes.Green;
                    //Om.Background = Brushes.Green;
                    //Amper.Background = Brushes.Green;
                }

                else
                {
                    randomNumber = random.Next(0,3);
                    randomNumber_2 = random.NextDouble();
                    randomNumber_3 = random.NextDouble();
                    Volt.Content = Math.Round(randomNumber + randomNumber_2/10 + (randomNumber_3 / 100), 3);
                }
            }
        }

        private void Repair_button_Click(object sender, RoutedEventArgs e)
          {
            MainWindow.btrepair_cmos = true;
            btcheck_CMOS = true;
            if (btcheck_signal == false)
            {
                MainWindow.scan_cmos = true;
                btcheck_signal = true;
                result_repair_textblock.Text = "Ремонт неисправности прошел успешно";
            }
            else
            {
                result_repair_textblock.Text = "Неисправность для ремонта не была найдена";
            }
        }

        private void CMOS_Click(object sender, RoutedEventArgs e)
        {
           
            if (!btcheck_CMOS)
            {
                btcheck_CMOS = true;
                CMOS_Scan.Background = new SolidColorBrush(Colors.White);
            }
            else
            {
                btcheck_CMOS = false;
                CMOS_Scan.Background = new SolidColorBrush();
                CMOS_Scan.Background = null;
            }
        }
    }
}
