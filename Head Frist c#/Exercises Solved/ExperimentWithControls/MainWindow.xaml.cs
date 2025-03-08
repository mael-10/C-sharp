using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExperimentWithControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //When a event handle is created, take a closer look on name "x:Name" and the the properie's name. 
        //To set up event handle name, need to use the two names
        public MainWindow()
        {
            InitializeComponent();
            
        }

        //Every time that text change, will execute that method
        //x:Name at XAML is like a variable name. It's like similar to Js DOM
        private void numberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            number.Text = numberTextBox.Text;

            if(numberTextBox.Text == "")
            {
                number.Text = "#";
            }
        }

        //Every time that text change, will execute that method to check it's number or not
        //int.TryParse check if the text is a number
        //e.Handled tell to WPF to ignore the output if it's true
        private void numberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        //Text to access text
        //Value to access numbers
        //ToString convert value to a string
        //The value of a slider is a fractional number. 0 converts a whole number
        private void smallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = smallSlider.Value.ToString("0");
        }

        //The slider numbers will be converted to string and will be formatted as placed bellow (000-000-0000)
        private void bigSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            number.Text = bigSlider.Value.ToString("000-000-0000");
        }

        //All radio buttons will be called for the same method
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                number.Text = radioButton.Content.ToString();
            }
        }
        //SelectionChanged="" has been used ListBox
        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(myListBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();
            }
        }

        //SelectionChanged="" is used when comboBox is IsEditable="false"
        private void readOnlyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (readOnlyComboBox.SelectedItem is ListBoxItem listBoxItem)
            {
                number.Text = listBoxItem.Content.ToString();
            }
        }

        //TextBoxBase.TextChanged="" is used when comboBox is IsEditable="True"
        private void editableComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(sender is ComboBox comboBox)
            {
                number.Text = editableComboBox.Text;
            }
        }

        //Brush is a classe for a pallete of colors
        private void PurpleBtn_Click(object sender, RoutedEventArgs e)
        {
            Bck.Background = Brushes.Purple;
            number.Foreground = Brushes.White;
        }
    }
}