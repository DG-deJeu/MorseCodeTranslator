using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MorseCodeTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchButton_Click(object sender, RoutedEventArgs e)
        {
            string InputTextSwitch = InputText.Text;
            string OutputTextSwitch = OutputText.Text;

            switch (InputLabel.Content)
            {
                case "Alphabet Text":
                    InputLabel.Content = "Morse Code";
                    OutputLabel.Content = "Alphabet Text";

                    InputText.Text = OutputTextSwitch;
                    OutputText.Text = InputTextSwitch;
                    break;
                default:
                    InputLabel.Content = "Alphabet Text";
                    OutputLabel.Content = "Morse Code";

                    InputText.Text = OutputTextSwitch;
                    OutputText.Text = InputTextSwitch;
                    break;
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                DefaultExt = ".txt",
                Filter = "Text Files (*.txt)|*.txt"
            };
            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                InputText.Text = File.ReadAllText(dlg.FileName);
            }

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                DefaultExt = ".txt",
                Filter = "Text Files (*.txt)|*.txt"
            };
            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                File.WriteAllText(dlg.FileName, OutputText.Text);
            }
        }

        private void TranslateButton_Click(object sender, RoutedEventArgs e)
        {
            string InputTextTranslate = " " + InputText.Text + " ";
            string OutputTextTranslated = "Error";
            string[] Alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",};
            string[] MorseCode = { " .- ", " -... ", " -.-. ", " -.. ", " . ", " ..-. ", " --. ", " .... ", " .. ", " .--- ", " -.- ", " .-.. ", " -- ", " -. ", " --- ", " .--. ", " --.- ", " .-. ", " ... ", " - ", " ..- ", " ...- ", " .-- ", " -..- ", " -.-- ", " --.. "};

            switch (InputLabel.Content)
            {
                case "Alphabet Text":
                    OutputTextTranslated = InputTextTranslate.Replace(Alphabet[0], MorseCode[0], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[1], MorseCode[1], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[2], MorseCode[2], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[3], MorseCode[3], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[4], MorseCode[4], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[5], MorseCode[5], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[6], MorseCode[6], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[7], MorseCode[7], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[8], MorseCode[8], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[9], MorseCode[9], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[10], MorseCode[10], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[11], MorseCode[11], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[12], MorseCode[12], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[13], MorseCode[13], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[14], MorseCode[14], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[15], MorseCode[15], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[16], MorseCode[16], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[17], MorseCode[17], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[18], MorseCode[18], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[19], MorseCode[19], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[20], MorseCode[20], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[21], MorseCode[21], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[22], MorseCode[22], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[23], MorseCode[23], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[24], MorseCode[24], StringComparison.OrdinalIgnoreCase).Replace(Alphabet[25], MorseCode[25], StringComparison.OrdinalIgnoreCase);
                    break;
                default:
                    OutputTextTranslated = InputTextTranslate.Replace(MorseCode[0], Alphabet[0], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[1], Alphabet[1], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[2], Alphabet[2], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[3], Alphabet[3], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[4], Alphabet[4], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[5], Alphabet[5], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[6], Alphabet[6], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[7], Alphabet[7], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[8], Alphabet[8], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[9], Alphabet[9], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[10], Alphabet[10], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[11], Alphabet[11], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[12], Alphabet[12], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[13], Alphabet[13], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[14], Alphabet[14], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[15], Alphabet[15], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[16], Alphabet[16], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[17], Alphabet[17], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[18], Alphabet[18], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[19], Alphabet[19], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[20], Alphabet[20], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[21], Alphabet[21], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[22], Alphabet[22], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[23], Alphabet[23], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[24], Alphabet[24], StringComparison.OrdinalIgnoreCase).Replace(MorseCode[25], Alphabet[25], StringComparison.OrdinalIgnoreCase);
                    break;
            }

            OutputText.Text = OutputTextTranslated;
        }

        private void InfoButton_MouseEnter(object sender, MouseEventArgs e)
        {
            InfoLabel.Visibility = Visibility.Visible;
            InfoLabel2.Visibility = Visibility.Visible;
        }

        private void InfoButton_MouseLeave(object sender, MouseEventArgs e)
        {
            InfoLabel.Visibility = Visibility.Hidden;
            InfoLabel2.Visibility = Visibility.Hidden;
        }
    }
}
