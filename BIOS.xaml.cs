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
    /// Логика взаимодействия для BIOS.xaml
    /// </summary>
    public partial class BIOS : Window
    {
        public bool btcheck_signal = MainWindow.scan_bios;
        public bool check_run_or_turn_off =false;

       
        public BIOS()
        {
            InitializeComponent();
            
        }

        private void Back_from_BIOS_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void run_turn_off_the_motherboard(object sender, RoutedEventArgs e)
        {
            check_run_or_turn_off = check_run_or_turn_off == false ? true : false;

            if (check_run_or_turn_off) run_turn_off_the_motherboard_button.Background = Brushes.Green;
            else run_turn_off_the_motherboard_button.Background = Brushes.Red;

            if (check_run_or_turn_off)
            {
                foreach (UIElement el in Panel_data_lines.Children)
                {
                    if (el is RadioButton)
                    {
                        if (((RadioButton)el).IsChecked == true)
                        {
                            if (btcheck_signal)
                            {
                                LED.Fill = Brushes.Red;
                            }
                            else
                            {
                                LED.Fill = Brushes.DarkGray;
                            }
                        }
                    }
                }

            }
            else
            {
                LED.Fill = Brushes.DarkGray;
            }
        }

        private void Repair_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.btrepair_bios = true;
            if (btcheck_signal == false)
            {
                MainWindow.scan_bios = true;
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
