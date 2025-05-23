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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    // Добавьте эти поля в класс MainWindow


    public partial class MainWindow : Window
    {
        bool flagRadio = false;
        // true - rus false - morse



        private Dictionary<char, string> rusToMorse = new Dictionary<char, string>() {
            {'а', ".-"}, {'б', "-..."}, {'в', ".--"}, {'г', "--."}, {'д', "-.."},
            {'е', "."}, {'ж', "...-"}, {'з', "--.."}, {'и', ".."}, {'й', ".---"},
            {'к', "-.-"}, {'л', ".-.."}, {'м', "--"}, {'н', "-."}, {'о', "---"},
            {'п', ".--."}, {'р', ".-."}, {'с', "..."}, {'т', "-"}, {'у', "..-"},
            {'ф', "..-."}, {'х', "...."}, {'ц', "-.-."}, {'ч', "---."}, {'ш', "----"},
            {'щ', "--.-"}, {'ъ', "--.--"}, {'ы', "-.--"}, {'ь', "-..-"}, {'э', "..-.."},
            {'ю', "..--"}, {'я', ".-.-"}, {' ', "/"}, {'1', ".----"}, {'2', "..---"},
            {'3', "...--"}, {'4', "....-"}, {'5', "....."}, {'6', "-...."}, {'7', "--..."},
            {'8', "---.."}, {'9', "----."}, {'0', "-----"}
        };

        private Dictionary<string, char> morseToRus = new Dictionary<string, char>() {
            {".-", 'а'}, {"-...", 'б'}, {".--", 'в'}, {"--.", 'г'}, {"-..", 'д'},
            {".", 'е'}, {"...-", 'ж'}, {"--..", 'з'}, {"..", 'и'}, {".---", 'й'},
            {"-.-", 'к'}, {".-..", 'л'}, {"--", 'м'}, {"-.", 'н'}, {"---", 'о'},
            {".--.", 'п'}, {".-.", 'р'}, {"...", 'с'}, {"-", 'т'}, {"..-", 'у'},
            {"..-.", 'ф'}, {"....", 'х'}, {"-.-.", 'ц'}, {"---.", 'ч'}, {"----", 'ш'},
            {"--.-", 'щ'}, {"--.--", 'ъ'}, {"-.--", 'ы'}, {"-..-", 'ь'}, {"..-..", 'э'},
            {"..--", 'ю'}, {".-.-", 'я'}, {"/", ' '}, {".----", '1'}, {"..---", '2'},
            {"...--", '3'}, {"....-", '4'}, {".....", '5'}, {"-....", '6'}, {"--...", '7'},
            {"---..", '8'}, {"----.", '9'}, {"-----", '0'}
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        public void checkRadio() {
            if (radioRus.IsChecked == true)
            {
                flagRadio = true;
            }
            else
            {
                flagRadio = false;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_CheckedRus(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_CheckedMorse(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textTranslationEnd.Content = "";
            checkRadio();
            if (flagRadio) {
                string text = textTranslationStart.Text.ToLower();
                foreach (var item in text) {
                    foreach (var item2 in rusToMorse) {
                        if (item2.Key == item) {
                            textTranslationEnd.Content += Convert.ToString(item2.Value);
                        }
                    }
                }   
            }
            else {
                string text = textTranslationStart.Text.ToLower();
                string[] morseCodes = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string s in morseCodes)
                {
                    if (morseToRus.ContainsKey(s))
                    {
                        char russianChar = morseToRus[s];
                        textTranslationEnd.Content += Convert.ToString(russianChar);
                    }
                }
            }
        }
    }
}
