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

    using System.Windows.Threading;

    public partial class MainWindow : Window
    {
        /*
          Add these three lines of code to
          create a new timer and add two fields
          to keep track of the time elapsed and
          number of matches the player has found.
         */

        //Create a new timer
        DispatcherTimer timer = new DispatcherTimer();
        //Keep track of time elapsed
        int tenthsOfSecondsElapsed;
        //number of matches the player 
        int matchesFound;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(.1);
            // Insets a method
            timer.Tick += Timer_Tick;
            SetUpGame();
        }

        //Method to a timer call
        private void Timer_Tick(object sender, EventArgs e)
        {
            tenthsOfSecondsElapsed++;
            timeTextBlock.Text = (tenthsOfSecondsElapsed / 10F).ToString("0.0s");
            if (matchesFound == 8)
            {
                timer.Stop();
                timeTextBlock.Text = timeTextBlock.Text + " - Play again?";
            }
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

            //Interact on all textBlocks inside the name "mainGrid" grid available
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            {
                //It fix the bug
                if(textBlock.Name != "timeTextBlock")
                {
                    //When program is restarted it makes icon visible
                    textBlock.Visibility = Visibility.Visible;
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

            //Starter the timer and add the fields
            timer.Start();
            tenthsOfSecondsElapsed = 0;
            matchesFound = 0;
        }

        TextBlock lastTextBlockClicked;
        bool findingMatch = false;

        //Method to get action when textblock is clicked
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock textBlock = sender as TextBlock;
            if (findingMatch == false)
            {
                textBlock.Visibility = Visibility.Hidden;
                //Recebe a propiedade do TextBlock
                lastTextBlockClicked = textBlock;
                findingMatch = true;
            }
            else if (textBlock.Text == lastTextBlockClicked.Text)
            {
                matchesFound++;
                textBlock.Visibility = Visibility.Hidden;
                findingMatch = false;
            }
            else
            {
                lastTextBlockClicked.Visibility = Visibility.Visible;
                findingMatch = false;
            }
        }

        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (matchesFound == 8)
            {
                SetUpGame();
            }
        }
    }
}