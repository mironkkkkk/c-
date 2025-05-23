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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 0 - x 1 - o
        int[,] arr = { { 2, 2, 2 }, { 2, 2, 2 }, { 2, 2, 2 } };

        bool move = false;
        // false - user1 (x) true user2 (o)

        public MainWindow()
        {
            InitializeComponent();
        }

        public void off() {
            checkBox1.Visibility = Visibility.Collapsed;
            checkBox1.IsEnabled = false;
            checkBox2.Visibility = Visibility.Collapsed;
            checkBox2.IsEnabled = false;
            checkBox3.Visibility = Visibility.Collapsed;
            checkBox3.IsEnabled = false;
            checkBox4.Visibility = Visibility.Collapsed;
            checkBox4.IsEnabled = false;
            checkBox5.Visibility = Visibility.Collapsed;
            checkBox5.IsEnabled = false;
            checkBox6.Visibility = Visibility.Collapsed;
            checkBox6.IsEnabled = false;
            checkBox7.Visibility = Visibility.Collapsed;
            checkBox7.IsEnabled = false;
            checkBox8.Visibility = Visibility.Collapsed;
            checkBox8.IsEnabled = false;
            checkBox9.Visibility = Visibility.Collapsed;
            checkBox9.IsEnabled = false;
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[0, 0] = 1;
                a1.Text = "O";
                move = false;
            }
            else {
                arr[0, 0] = 0;
                a1.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[1, 0] = 1;
                a4.Text = "O";
                move = false;
            }
            else {
                arr[1, 0] = 0;
                a4.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;

            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_3(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[2, 0] = 1;
                a7.Text = "O";
                move = false;
            }
            else {
                arr[2, 0] = 0;
                a7.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_4(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[0, 1] = 1;
                a2.Text = "O";
                move = false;
            }
            else {
                arr[0, 1] = 0;
                a2.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_5(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[1, 1] = 1;
                a5.Text = "O";
                move = false;
            }
            else {
                arr[1, 1] = 0;
                a5.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_6(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[2, 1] = 1;
                a8.Text = "O";
                move = false;
            }
            else {
                arr[2, 1] = 0;
                a8.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_7(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[0, 2] = 1;
                a3.Text = "O";
                move = false;
            }
            else {
                arr[0, 2] = 0;
                a3.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_8(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[1, 2] = 1;
                a6.Text = "O";
                move = false;
            }
            else {
                arr[1, 2] = 0;
                a6.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        private void CheckBox_Checked_9(object sender, RoutedEventArgs e)
        {
            if (move) {
                arr[2, 2] = 1;
                a9.Text = "O";
                move = false;
            }
            else {
                arr[2, 2] = 0;
                a9.Text = "X";
                move = true;
            }
            CheckBox clickedCheckBox = sender as CheckBox;
            clickedCheckBox.Visibility = Visibility.Collapsed;
            clickedCheckBox.IsEnabled = false;
            win();
        }

        public void win() {
            if (a1.Text == "X" || a1.Text == "O" && a2.Text == "X" || a2.Text == "O" && a3.Text == "X" || a3.Text == "O")
            {
                textResult.Text = "WIN";
                if (a1.Text == "X" && a2.Text == "X" && a3.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a1.Text == "X" || a1.Text == "O" && a4.Text == "X" || a4.Text == "O" && a7.Text == "X" || a7.Text == "O")
            {
                textResult.Text = "WIN";
                if (a1.Text == "X" && a4.Text == "X" && a7.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a1.Text == "X" || a1.Text == "O" && a5.Text == "X" || a5.Text == "O" && a9.Text == "X" || a9.Text == "O")
            {
                textResult.Text = "WIN";
                if (a1.Text == "X" && a5.Text == "X" && a9.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a2.Text == "X" || a2.Text == "O" && a5.Text == "X" || a5.Text == "O" && a8.Text == "X" || a8.Text == "O")
            {
                textResult.Text = "WIN";
                if (a2.Text == "X" && a5.Text == "X" && a8.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a3.Text == "X" || a3.Text == "O" && a6.Text == "X" || a6.Text == "O" && a9.Text == "X" || a9.Text == "O")
            {
                textResult.Text = "WIN";
                if (a3.Text == "X" && a6.Text == "X" && a9.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a3.Text == "X" || a3.Text == "O" && a5.Text == "X" || a5.Text == "O" && a7.Text == "X" || a7.Text == "O")
            {
                textResult.Text = "WIN";
                if (a3.Text == "X" && a5.Text == "X" && a7.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a4.Text == "X" || a4.Text == "O" && a5.Text == "X" || a5.Text == "O" && a6.Text == "X" || a6.Text == "O")
            {
                textResult.Text = "WIN";
                if (a4.Text == "X" && a5.Text == "X" && a6.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else if (a7.Text == "X" || a7.Text == "O" && a8.Text == "X" || a8.Text == "O" && a9.Text == "X" || a9.Text == "O")
            {
                textResult.Text = "WIN";
                if (a7.Text == "X" && a8.Text == "X" && a9.Text == "X")
                {
                    textResult.Text += " X";
                }
                else
                {
                    textResult.Text += " O";
                }
                off();
            }
            else {
                if (move) {
                    textResult.Text = "Move O";
                }
                else {
                    textResult.Text = "Move X";
                }
            }
        }
    }
}
