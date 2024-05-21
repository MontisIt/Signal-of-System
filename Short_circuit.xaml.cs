using MaterialDesignColors.Recommended;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
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
    /// Логика взаимодействия для Short_circuit.xaml
    /// </summary>
    public partial class Short_circuit : Window
    {

        public bool btcheck_signal=MainWindow.scan_short_circuit;
        

        public bool[] Check_points_arr=new bool[25];
        public bool[] Check_points_signal = new bool[25];


        public bool No_point_check=false;

        //Конструктор
        public Short_circuit()
        {
            InitializeComponent();
           
            Scan_Short_circuit();
            
        }

        //Main
        private void Scan_Short_circuit()
        {
            //MainWindow mainWindow = new MainWindow();

            //btcheck_signal = mainWindow.scan_short_circuit;

            if(btcheck_signal==false)
            {
                Random random = new Random();
                bool randomNumber;

                for (int i = 1; i < 25; i++)
                {
                   randomNumber = (random.Next(2) == 0);
                    Check_points_signal[i]= randomNumber;
                }
               
                

                //System.Threading.Thread.Sleep(1000); // Подождать 1 секунду
            }


        }

       


        //Функция для рандома исправности или неисправности точки
        private static bool Random_bool_number()
        {
            Random rnd = new Random();
            bool random = (rnd.Next(2) == 0);

            return random;

        }
       



        //кнопка НАЗАД
        private void Back_from_Short_circuit_Click(object sender, RoutedEventArgs e)
        {         
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();

        }

        public void ResetCheckBox()
        {
          
            for (int i = 1; i < Check_points_arr.Length; i++)
            {
                Check_points_arr[i] = false;
            }
        } 


        private void Scan_Points(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            double randomNumber;
            //Pin 1 3.3V
            randomNumber = random.NextDouble();
            //Label1.Content = Math.Round(3+randomNumber,2);

           // MainWindow mainWindow = new MainWindow();

            //btcheck_signal = mainWindow.scan_short_circuit;


            int index = 5;
            for(int i=1;i< Check_points_arr.Length; i++)
            {
                if(Check_points_arr[i])
                {
                    index=i; break;
                }
            }
            if (btcheck_signal)
            {

            switch (index)
            {
                case 1:
                    //Pin 1 3.3V
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(3+randomNumber,2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(1 + randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;
                case 2:
                        //Pin 2 3.3V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(3 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(1+ randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 3:
                    //Pin 3 GND
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(0.0, 2); 
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(0.0, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;
                        break;

                case 4:
                    //Pin 4 5V
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(5 + randomNumber, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(random.Next(1,3) + randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(31 + randomNumber, 2);
                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;
                case 5:
                    //Pin 5 GND
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(0.0, 2); 
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(0.0, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(0.0, 2); 
                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;
                case 6:
                        //Pin 6 5V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(5 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(random.Next(1,3) + randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;
                        break;
                case 7:
                    //Pin 7 GND
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(0.0, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(0.0, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;
                        break;

                case 8:
                    //Pin 8 Power_Good
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(5 + randomNumber, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(1 + randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(31 + randomNumber, 2);
                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 9:
                        //Pin 9 5V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(5 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(random.Next(1,3) + randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 10:
                    //Pin 10 +12V
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(12 + randomNumber, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(1+ randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(41 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;
                        break;
                case 11:
                    //Pin 11 +12V
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(12 + randomNumber, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(1 + randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(41 + randomNumber, 2);
                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;
                case 12:
                        //Pin 12 +3.3V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(3 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(1 + randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 13:
                        //Pin 13 +3.3V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(3 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(1 + randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;
                case 14:
                    //Pin 14 -12V
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(11 + randomNumber, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(1 + randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(0 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 15:
                        //Pin 15 GND
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(0.0, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(0.0, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 16:
                    //Pin 16 PS_ON
                    randomNumber = random.NextDouble();
                    Volt.Content = Math.Round(5 + randomNumber, 2);
                    randomNumber = random.NextDouble();
                    Om.Content = Math.Round(1 + randomNumber, 3);
                    randomNumber = random.NextDouble();
                    Amper.Content = Math.Round(32 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 17:
                        //Pin 17 GND
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(0.0, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(0.0, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 18:
                        //Pin 18 GND
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(0.0, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(0.0, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 19:
                        //Pin 19 GND
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(0.0, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(0.0, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 21:
                        //Pin 21 5V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(5 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(1 + randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 22:
                        //Pin 22 5V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(5 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(1+ randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 23:
                        //Pin 23 5V
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(5 + randomNumber, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(1 + randomNumber, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(31 + randomNumber, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;

                case 24:
                        //Pin 24 GND
                        randomNumber = random.NextDouble();
                        Volt.Content = Math.Round(0.0, 2);
                        randomNumber = random.NextDouble();
                        Om.Content = Math.Round(0.0, 3);
                        randomNumber = random.NextDouble();
                        Amper.Content = Math.Round(0.0, 2);

                        Volt.Background = Brushes.Green;
                        Om.Background = Brushes.Green;
                        Amper.Background = Brushes.Green;

                        break;


            }
                Om.Content = "";
                Amper.Content = "";
                Om.Background = Brushes.WhiteSmoke;
                Amper.Background = Brushes.WhiteSmoke;
            }

            else
            {
                    switch (index)
                    {
                        case 1:
                            //Pin 1 3.3V
                            if (Check_points_signal[index])
                            {

                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(3 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                            Volt.Background = Brushes.Green;
                            Om.Background = Brushes.Green;
                            Amper.Background = Brushes.Green;
                            break;
                            }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0,3) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(0,1) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(15,20) + randomNumber, 2);
                            Volt.Background = Brushes.Red;
                            Om.Background = Brushes.Red;
                            Amper.Background = Brushes.Red;
                        }


                            break;
                        case 2:
                        //Pin 2 3.3V
                        if (Check_points_signal[index])
                        {

                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(3 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                            Volt.Background = Brushes.Green;
                            Om.Background = Brushes.Green;
                            Amper.Background = Brushes.Green;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 3) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(0, 1) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(15, 20) + randomNumber, 2);
                            Volt.Background = Brushes.Red;
                            Om.Background = Brushes.Red;
                            Amper.Background = Brushes.Red;
                        }
                        break;

                        case 3:
                        //Pin 3 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(0.0, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0.0, 2);
                            Volt.Background = Brushes.Green;
                            Om.Background = Brushes.Green;
                            Amper.Background = Brushes.Green;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0.0,2);
                            Volt.Background = Brushes.Red;
                            Om.Background = Brushes.Red;
                            Amper.Background = Brushes.Red;
                        }
                            break;

                        case 4:
                        //Pin 4 5V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(1,3) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(2,4) + randomNumber, 2) : Math.Round(random.Next(6, 8) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(20, 25) + randomNumber, 2);
                        }
                            break;
                        case 5:
                        //Pin 5 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(0.0, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0.0, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0.0,2);
                        }
                        break;
                        case 6:
                        //Pin 6 5V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(1,3) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(2, 4) + randomNumber, 2) : Math.Round(random.Next(6, 8) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(0, 1) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(20, 25) + randomNumber, 2);
                        }
                        break;
                        case 7:
                        //Pin 7 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(0.0, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0.0, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0.0, 2);
                        }
                        break;

                        case 8:
                        //Pin 8 Power_Good
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0,2) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(0, 1) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(25,31) + randomNumber, 2);
                        }
                            break;

                        case 9:
                        //Pin 9 5V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(1, 3) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(2, 4) + randomNumber, 2) : Math.Round(random.Next(6, 8) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(20, 25) + randomNumber, 2);
                        }
                        break;

                        case 10:
                        //Pin 10 +12V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(12 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(41 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(9,11) + randomNumber, 2) : Math.Round(random.Next(13, 15) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(0, 1) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(35, 41) + randomNumber, 2);

                        }
                            break;
                        case 11:
                        //Pin 11 +12V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(12 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(41 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(9, 11) + randomNumber, 2) : Math.Round(random.Next(13, 15) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(0, 1) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(35, 41) + randomNumber, 2);

                        }
                        break;
                        case 12:
                        //Pin 12 +3.3V
                        if (Check_points_signal[index])
                        {

                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(3 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 3) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(15, 20) + randomNumber, 2);
                        }
                        break;

                        case 13:
                        //Pin 13 +3.3V
                        if (Check_points_signal[index])
                        {

                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(3 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 3) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(15, 20) + randomNumber, 2);
                        }
                        break;
                        case 14:
                        //Pin 14 -12V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(11 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(9, 11) + randomNumber, 2) : Math.Round(random.Next(13, 15) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(0 + randomNumber, 2);
                        }
                            break;

                        case 15:
                        //Pin 15 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = 0;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        break;

                        case 16:
                        //Pin 16 PS_ON
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(32 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        break;

                        case 17:
                        //Pin 17 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = 0;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        break;

                        case 18:
                        //Pin 18 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = 0;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        break;

                        case 19:
                        //Pin 19 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = 0;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        break;

                        case 21:
                        //Pin 21 5V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(2, 4) + randomNumber, 2) : Math.Round(random.Next(6, 8) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(20, 25) + randomNumber, 2);
                        }
                        break;

                        case 22:
                        //Pin 22 5V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(1 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(2, 4) + randomNumber, 2) : Math.Round(random.Next(6, 8) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(20, 25) + randomNumber, 2);
                        }
                        break;

                        case 23:
                        //Pin 23 5V
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(5 + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(random.Next(1, 3) + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(31 + randomNumber, 2);
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = random.Next(2) == 0 ? Math.Round(random.Next(2, 4) + randomNumber, 2) : Math.Round(random.Next(6, 8) + randomNumber, 2);
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0 + randomNumber, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = Math.Round(random.Next(20, 25) + randomNumber, 2);
                        }
                        break;

                        case 24:
                        //Pin 24 GND
                        if (Check_points_signal[index])
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = 0;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        else
                        {
                            randomNumber = random.NextDouble();
                            Volt.Content = Math.Round(random.Next(0, 2) + randomNumber, 2); ;
                            randomNumber = random.NextDouble();
                            Om.Content = Math.Round(0.0, 3);
                            randomNumber = random.NextDouble();
                            Amper.Content = 0;
                        }
                        break;
                    }
                Om.Content = ""; 
                Amper.Content = "";
                Om.Background = Brushes.WhiteSmoke;
                Amper.Background = Brushes.WhiteSmoke;
                ChangeColorLabels(Check_points_signal[index]);
                }


        }

        public void ChangeColorLabels(bool check)                                         
        {
            if(check)
            {
                Volt.Background = Brushes.Green;
                Om.Background = Brushes.Green;
                Amper.Background = Brushes.Green;
            }
            else
            {
                Volt.Background = Brushes.Red;
                Om.Background = Brushes.Red;
                Amper.Background = Brushes.Red;
            }
        }

        private void No_1_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton pressed = (RadioButton)sender;
            ResetCheckBox();

            if (pressed.IsChecked == true) {
                No_point_check = true;
                Check_points_arr[1]=true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[1] = false;
            }

        }

        private void No_2_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[2] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[2] = false;
            }
        }

        private void No_4_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[4] = true;

            }
            else
            {
                No_point_check = false;
                Check_points_arr[4] = false;
            }
        }

        private void No_6_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[6] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[6] = false;
            }
        }

        private void No_9_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[9] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[9] = false;
            }
        }

        private void No_10_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[10] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[10] = false;
            }
        }

        private void No_11_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[11] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[11] = false;
            }
        }

        private void No_12_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[12] = true;
            }
            else
            {
                 No_point_check = false;
                Check_points_arr[12] =false;
            }
        }

        private void No_13_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[13] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[13] = false;
            }
        }

        private void No_14_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[14] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[14] = false;
            }
        }

        private void No_21_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[21] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[21] = false;
            }
        }

        private void No_22_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[22] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[22] = false;
            }
        }

        private void No_23_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[23] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[23] = false;
            }
        }

        private void No_3_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[3] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[3] = false;
            }
        }

        private void No_5_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[5] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[5] = false;
            }
        }

        private void No_7_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[7] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[7] = false;
            }
        }

        private void No_8_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[8] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[8] = false;
            }
        }

        private void No_15_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[15] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[15] = false;
            }
        }

        private void No_16_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[16] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[16] = false;
            }
        }

        private void No_17_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[17] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[17] = false;
            }
        }

        private void No_18_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[18] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[19] = false;
            }
        }

        private void No_19_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[19] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[19] = false;
            }
        }

        private void No_24_Checked(object sender, RoutedEventArgs e)
        {
            ResetCheckBox();
            RadioButton pressed = (RadioButton)sender;
            if (pressed.IsChecked == true)
            {
                No_point_check = true;
                Check_points_arr[24] = true;
            }
            else
            {
                No_point_check = false;
                Check_points_arr[24] = false;
            }
        }

        private void Repair_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.btrepair_short_circuit = true;
            if (btcheck_signal == false)
            {
                
                MainWindow.scan_short_circuit = true;
                btcheck_signal = true;
                result_repair_textblock.Text= "Ремонт неисправности прошел успешно";
            }
            else
            {
               
                result_repair_textblock.Text = "Неисправность для ремонта не была найдена ";
            }

        }
    }
}
