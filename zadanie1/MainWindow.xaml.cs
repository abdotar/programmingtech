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
using System.Collections;
using System.IO;
using Microsoft.Win32;


namespace laba_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml проверка 1
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemcount = Convert.ToInt32(elements_tb.Text);
            Random rn = new Random();
            int number;
            mass_lb.Items.Clear();
            for (index = 1; index <= itemcount; index++)
            {
                number = -100 + rn.Next(200);
                myAL.Add(number);
                mass_lb.Items.Add(number);

            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemcount = Convert.ToInt32(elements_tb.Text);
            Random rn = new Random();
            int number;
            mass_lb.Items.Clear();
            mass_lb.Items.Add("Исходный массив");
            for (index = 1; index <= itemcount; index++)
            {
                number = -100 + rn.Next(200);
                myAL.Add(number);
                mass_lb.Items.Add(number);
            }
            myAL.Sort();
            mass_lb.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                mass_lb.Items.Add(elem);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SaveFileDialog mydialog = new SaveFileDialog();
            mydialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";
            if (mydialog.ShowDialog() == true)
            {
                string filename = mydialog.FileName;
                // StreamWriter file = new StreamWriter(filename,false)
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                    foreach (object inside in mass_lb.Items)
                    {
                        file.WriteLine(inside);
                    }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Для массива из 10 целых чисел подчитать сумму элементов,­ значения которых не кратны 3.

            ArrayList myAL = new ArrayList();
            int index;
            int itemcount = Convert.ToInt32(elements_tb.Text);
            Random rn = new Random();
            int number;
            mass_lb.Items.Clear();
            mass_lb.Items.Add("массив");
            int sum = 0;
            for (index = 1; index <= itemcount; index++)
            {
                number = -100 + rn.Next(200);
                myAL.Add(number);
                mass_lb.Items.Add(number);
            }
            

            for (int i = 0; i < itemcount; i++)
            {
                int cheker = Convert.ToInt32(myAL[i]);//сравниваемое число


                if (cheker % 3 != 0)
                {
                   sum=sum+Convert.ToInt32(myAL[i]);
                }
            
            }
            mass_lb.Items.Add("результат выполнения алгоритма подсчета суммы элементов,­ значения которых не кратны 3.=" + Convert.ToString(sum));

        }


        public  void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                zadanie1.AboutBox1 F = new zadanie1.AboutBox1();
                F.ShowDialog();

            }
        }

    }
}
