using System;
using System.Windows;
using Lib_12;

namespace Practical1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("1 практическую работу выполнил студент группы ИСП-34 Букин Ярослав.");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Input.Text, out int n))
            {
                RandomSumCalculator calculator = new RandomSumCalculator();
                string result = calculator.CalculateRandomSum(n);
                Result.Text = result;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите целое число для N");
            }
        }
    }
}
