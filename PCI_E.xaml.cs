using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для PCI_E.xaml
    /// </summary>
    /// 

    public partial class PCI_E : Window
    {
        public bool btcheck_signal = MainWindow.scan_pci_e;
        public bool[] random_rectangle_PCIEX16 = new bool[65];
        public bool[] random_rectangle_PCIEX4 = new bool[65];
        public bool[] random_rectangle_PCIEX1 = new bool[65];

        public int countPCIEX16=0;
        public bool checkcountPCIEX16 = true;

        public int countPCIEX4 = 0;
        public bool checkcountPCIEX4 = true;

        public int countPCIEX1 = 0;
        public bool checkcountPCIEX1 = true;

        public bool btcheck_pci_ex16 = false;
        public bool btcheck_pci_ex4 = false;
        public bool btcheck_pci_ex1 = false;


       
        public PCI_E()
        {
            InitializeComponent();
            if (btcheck_signal == false)
            {
                Random random = new Random();
                bool randomNumber;

                for (int i = 1; i < 65; i++)
                {
                    
               
                    randomNumber = (random.Next(2) == 0);
                    random_rectangle_PCIEX16[i]= randomNumber;
                    randomNumber = (random.Next(2) == 0);
                    random_rectangle_PCIEX4[i]= randomNumber;
                    randomNumber = (random.Next(2) == 0);
                    random_rectangle_PCIEX1[i] = randomNumber;
                }

            }
        }

            private void Back_from_PCI_E_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Repair_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.btrepair_pci_e = true;
            if (btcheck_signal == false)
            {
                MainWindow.scan_pci_e = true;
                btcheck_signal = true;
                result_repair_textblock.Text = "Ремонт неисправности прошел успешно";
            }
            else
            {
                result_repair_textblock.Text = "Неисправность для ремонта не была найдена";
            }
        }

        private void PCI_EX16_Click(object sender, RoutedEventArgs e)
        {
            if (!btcheck_pci_ex16)
            {
                btcheck_pci_ex16 = true;
                PCI_EX16.Background = new SolidColorBrush(Colors.White);


                PCI_EX1.Background = null;
                PCI_EX4.Background = null;

                btcheck_pci_ex4 = false;
                btcheck_pci_ex1 = false;
            }
            else
            {
                btcheck_pci_ex16 = false;
                PCI_EX16.Background = new SolidColorBrush();
                PCI_EX16.Background = null;
            }
        }

        private void PCI_EX4_Click(object sender, RoutedEventArgs e)
        {
            if (!btcheck_pci_ex4)
            {
                btcheck_pci_ex4 = true;
                PCI_EX4.Background = new SolidColorBrush(Colors.White);
                PCI_EX16.Background = null;
                PCI_EX1.Background = null;

                btcheck_pci_ex16 = false;
                btcheck_pci_ex1 = false;
            }
            else
            {
                btcheck_pci_ex4 = false;
                PCI_EX4.Background = new SolidColorBrush();
                PCI_EX4.Background = null;
            }
        }

        private void PCI_EX1_Click(object sender, RoutedEventArgs e)
        {
            if (!btcheck_pci_ex1)
            {
                btcheck_pci_ex1 = true;
                PCI_EX1.Background = new SolidColorBrush(Colors.White);
                PCI_EX16.Background = null;
                PCI_EX4.Background = null;

                btcheck_pci_ex4 = false;
                btcheck_pci_ex16 = false;
            }
            else
            {
                btcheck_pci_ex1 = false;
                PCI_EX1.Background = new SolidColorBrush();
                PCI_EX1.Background = null;
            }
        }

        private void Scan_PCI_E_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double randomNumber;
            bool randomBoolean;

            countPCIEX16 = 0;


            countPCIEX4 = 0;


            countPCIEX1 = 0;

            foreach (UIElement el in Grid_R.Children)
            {
                if (el is Rectangle)
                {
                    //((RadioButton) el) pressed = (RadioButton)sender;

                    if (btcheck_signal)
                    {

                        if (btcheck_pci_ex16)
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.Red);

                        }

                        else if (btcheck_pci_ex4)
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            RXN0.Fill = new SolidColorBrush(Colors.Red);
                            RXP0.Fill = new SolidColorBrush(Colors.Red);
                            RXN1.Fill = new SolidColorBrush(Colors.Red);
                            RXP1.Fill = new SolidColorBrush(Colors.Red);
                            RXP2.Fill = new SolidColorBrush(Colors.Red);
                            RXN2.Fill = new SolidColorBrush(Colors.Red);
                            RXN3.Fill = new SolidColorBrush(Colors.Red);
                            RXP3.Fill = new SolidColorBrush(Colors.Red);
                            RXN4.Fill = new SolidColorBrush(Colors.Red);
                            RXP4.Fill = new SolidColorBrush(Colors.Red);
                            RXP5.Fill = new SolidColorBrush(Colors.Red);
                            RXN6.Fill = new SolidColorBrush(Colors.Red);
                            RXN7.Fill = new SolidColorBrush(Colors.Red);
                            RXP7.Fill = new SolidColorBrush(Colors.Red);
                            RXN8.Fill = new SolidColorBrush(Colors.Red);
                            RXP8.Fill = new SolidColorBrush(Colors.Red);

                            TXN0.Fill = new SolidColorBrush(Colors.Red);
                            TXP0.Fill = new SolidColorBrush(Colors.Red);
                            TXN1.Fill = new SolidColorBrush(Colors.Red);
                            TXP1.Fill = new SolidColorBrush(Colors.Red);
                            TXP2.Fill = new SolidColorBrush(Colors.Red);
                            TXN2.Fill = new SolidColorBrush(Colors.Red);
                            TXN3.Fill = new SolidColorBrush(Colors.Red);
                            TXP3.Fill = new SolidColorBrush(Colors.Red);
                            TXN4.Fill = new SolidColorBrush(Colors.Red);
                            TXP4.Fill = new SolidColorBrush(Colors.Red);
                            TXP5.Fill = new SolidColorBrush(Colors.Red);
                            TXN6.Fill = new SolidColorBrush(Colors.Red);
                            TXN7.Fill = new SolidColorBrush(Colors.Red);
                            TXP7.Fill = new SolidColorBrush(Colors.Red);
                            TXN8.Fill = new SolidColorBrush(Colors.Red);
                            TXP8.Fill = new SolidColorBrush(Colors.Red);
                        }

                        else if (btcheck_pci_ex1)
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            RXN0.Fill = new SolidColorBrush(Colors.Red);
                            RXP0.Fill = new SolidColorBrush(Colors.Red);
                            RXN1.Fill = new SolidColorBrush(Colors.Red);
                            RXP1.Fill = new SolidColorBrush(Colors.Red);


                            TXN0.Fill = new SolidColorBrush(Colors.Red);
                            TXP0.Fill = new SolidColorBrush(Colors.Red);
                            TXN1.Fill = new SolidColorBrush(Colors.Red);
                            TXP1.Fill = new SolidColorBrush(Colors.Red);


                        }
                        else
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                        }



                    }
                    else
                    {
                        if (btcheck_pci_ex16)
                        {

                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            if (random_rectangle_PCIEX16[countPCIEX16])
                                ((Rectangle)el).Fill = new SolidColorBrush(Colors.Red);
                            else
                            {
                                ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            }
                            countPCIEX16++;

                        }

                        else if (btcheck_pci_ex4)
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            if (random_rectangle_PCIEX4[countPCIEX4] && (countPCIEX4 < 9 || countPCIEX4 > 31) && countPCIEX4 < 40)
                                ((Rectangle)el).Fill = new SolidColorBrush(Colors.Red);
                            else
                            {
                                ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            }
                            countPCIEX4++;


                        }

                        else if (btcheck_pci_ex1)
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            if (random_rectangle_PCIEX1[countPCIEX1] && (countPCIEX1 < 4 || countPCIEX1 > 31) && countPCIEX1 < 35)
                                ((Rectangle)el).Fill = new SolidColorBrush(Colors.Red);
                            else
                            {
                                ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                            }
                            countPCIEX1++;


                        }
                        else
                        {
                            ((Rectangle)el).Fill = new SolidColorBrush(Colors.LightBlue);
                        }

                    }

                }

            }
        }
    }
}
