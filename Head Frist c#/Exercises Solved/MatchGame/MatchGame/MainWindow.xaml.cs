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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();

        }

        private void SetUpGame()

        {
            List<string> animalEmoji = new List<string>()
            {
                "🙉", "🙉",
                "🤖", "🤖",
                "☠️", "☠️",
                "😻", "😻",
                "🐼", "🐼",
                "🐔", "🐔",
                "🦄", "🦄",
                "🐻", "🐻",
            };

            //Create a obj random
            Random random = new Random();

            //Interact on all textBlocks with the name "mainGrid" available
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                //Generate a random number based on animalEmoji List
                int index = random.Next(animalEmoji.Count);
                //Put the random emoji var
                string nextEmoji = animalEmoji[index];
                //Put emoji on text
                textBlock.Text = nextEmoji;
                //Romove emoji current index list
                animalEmoji.RemoveAt(index);
            }
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}