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

namespace SudokuGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int inputNumber;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if(Convert.ToInt32(txtNumber.Text) > 4)
            {
                inputNumber = Convert.ToInt32(txtNumber.Text);
                inputNumber--;
                txtNumber.Text = Convert.ToString(inputNumber);
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(txtNumber.Text) < 9)
            {
                inputNumber = Convert.ToInt32(txtNumber.Text);
                inputNumber+=1;
                txtNumber.Text = Convert.ToString(inputNumber);
            }
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (tbInitialStatus.Text.Length == Math.Pow(Convert.ToDouble(txtNumber.Text), 2))
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            }
            else if (tbInitialStatus.Text.Length > Convert.ToInt32(txtNumber.Text))
            {
                MessageBox.Show($"A feladvány hosszú: törlendő {tbInitialStatus.Text.Length - Math.Pow(Convert.ToDouble(txtNumber.Text),2)} számjegy!");
            }
            else 
            {
                MessageBox.Show($"A feladvány rövid: kell még {Math.Pow(Convert.ToDouble(txtNumber.Text), 2) - tbInitialStatus.Text.Length} számjegy!");
            }
        }

        private void tbInitialStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblLength.Content = "Hossz: " + tbInitialStatus.Text.Length;
        }

        private void txtNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNumber.Text.Length == 0 || Convert.ToByte(txtNumber.Text) > 9 || Convert.ToByte(txtNumber.Text) < 4)
            {
                txtNumber.Text = "4";
            }
        }
    }
}

