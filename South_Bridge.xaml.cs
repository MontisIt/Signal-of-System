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
    /// Логика взаимодействия для South_Bridge.xaml
    /// </summary>
    public partial class South_Bridge : Window
    {
        public bool btcheck_signal = MainWindow.scan_south_bridge;


        public bool[] Check_points_signal = new bool[44];


        public South_Bridge()
        {
            InitializeComponent();
        }
        //Main
        private void Scan_south_bridge()
        {
            //MainWindow mainWindow = new MainWindow();

            //btcheck_signal = mainWindow.scan_short_circuit;

            if (btcheck_signal == false)
            {
                Random random = new Random();
                bool randomNumber;

                for (int i = 1; i < 44; i++)
                {
                    randomNumber = (random.Next(2) == 0);
                    Check_points_signal[i] = randomNumber;
                }



                //System.Threading.Thread.Sleep(1000); // Подождать 1 секунду
            }


        }
        private void Back_from_South_Bridge_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Scan_data_lines(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double randomNumber;
            bool randomBoolean;

            foreach (UIElement el in Panel_data_lines.Children)
            {
                if(el is RadioButton)
                {
                   //((RadioButton) el) pressed = (RadioButton)sender;
                    if (((RadioButton)el).IsChecked == true)
                    {
                        if (btcheck_signal)
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(0 + 0.67 + (randomNumber / 100), 4);
                            
                            //Om.Content = 0;//Math.Round(random.Next(50, 60) + randomNumber, 3);
                            
                            //Amper.Content = 0;// Math.Round(random.Next(30, 32) + randomNumber, 2);

                            //Volt.Background = Brushes.Green;
                            //Om.Background = Brushes.Green;
                            //Amper.Background = Brushes.Green;
                        }
                        else
                        {
                            randomBoolean = (random.Next(2) == 0);
                            if(randomBoolean)
                            {
                                randomNumber = random.NextDouble();
                                Volt.Content = Math.Round(0 + 0.67 + (randomNumber/100), 4);

                                //Om.Content = 0;//Math.Round(random.Next(50, 60) + randomNumber, 3);

                                //Amper.Content = 0;// Math.Round(random.Next(30, 32) + randomNumber, 2);

                               // Volt.Background = Brushes.Green;
                               // Om.Background = Brushes.Green;
                               // Amper.Background = Brushes.Green;
                            }
                            else
                            {
                                randomBoolean = (random.Next(2) == 0);
                                if (randomBoolean)
                                {
                                    randomNumber = random.NextDouble();
                                    Volt.Content = Math.Round(0 + 0.6 + (randomNumber/100)+ (randomNumber / 1000), 4);

                                }
                                else{
                                    randomNumber = random.NextDouble();
                                    Volt.Content = 0;// Math.Round(0 + 0.67 + randomNumber, 4);
                                }
                                

                                //Om.Content = 0;//Math.Round(random.Next(50, 60) + randomNumber, 3);

                                //Amper.Content = 0;// Math.Round(random.Next(30, 32) + randomNumber, 2);

                                //Volt.Background = Brushes.Red;
                                //Om.Background = Brushes.Green;
                                //Amper.Background = Brushes.Green;
                            }

                        }
                    }
                }
            }
        }

        private void Repair_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.btrepair_south_bridge = true;
            if (btcheck_signal == false)
            {
                MainWindow.scan_south_bridge = true;
                btcheck_signal = true;
                result_repair_textblock.Text = "Ремонт неисправности прошел успешно";
            }
            else
            {
                result_repair_textblock.Text = "Неисправность для ремонта не была найдена ";
            }
        }
    }
}
