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

namespace TriviaGameWPF
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //set default title bar
            this.Title = "Please set some values for your Companion";

        }
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //create a pop up message box
            MessageBox.Show("Congradulations " + Trivia.name + "! You got " + Trivia.score + " out of 5 correct.");
        }

        //begin work on texture section to control the image presented in the image rectangle in the GUI
        private void Question1_Checked(object sender, RoutedEventArgs e)
        {
            //what button was checked?
            //need a variable
            var button = sender as RadioButton;

            //What to do with the selection?
            //analyze conent value

            if ((bool)RbDoom.IsChecked)
            {
                Trivia.score ++;
            }
        }
        //create an update method
        private void UpdateSummary()
        {
           // this.Title = "Your companion has " + Companion.color + " " + Companion.texture + "and is named " + Companion.name + ".";
        }

        private void Question2_Checked(object sender, RoutedEventArgs e)
        {
            //which radiobutton was checked
            var button = sender as RadioButton;

            //What to do with the selection?
            //analyze conent value
            if ((bool)RbShrub.IsChecked)
            {
                Trivia.score++;
            }
        }

        private void Question3_Checked(object sender, RoutedEventArgs e)
        {
            //which radiobutton was checked
            var button = sender as RadioButton;

            //What to do with the selection?
            //analyze conent value
            if ((bool)RbHGrail.IsChecked)
            {
                Trivia.score++;
            }
            UpdateSummary();
        }

        private void Question4_Checked(object sender, RoutedEventArgs e)
        {
            //which radiobutton was checked
            var button = sender as RadioButton;

            //What to do with the selection?
            //analyze conent value
            if ((bool)RbBurj.IsChecked)
            {
                Trivia.score++;
            }
            //run the update summary after the switch is executed
            UpdateSummary();
        }

        private void Question5_Checked(object sender, RoutedEventArgs e)
        {
            //which radiobutton was checked
            var button = sender as RadioButton;

            //What to do with the selection?
            //analyze conent value
            if ((bool)Rb69.IsChecked)
            {
                Trivia.score++;
            }
            //run the update summary after the switch is executed
            UpdateSummary();
        }

        private void inName_TextChanged(object sender, TextChangedEventArgs e)
        {
            //update the companion name in real time
            Trivia.name = inName.Text;
            UpdateSummary();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
