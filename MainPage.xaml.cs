using System.Text;

namespace Wordley
{
    public partial class MainPage : ContentPage
    {

       
      
        private List<string> fiveLetterWords = new List<string>
        {
            "apple", "happy", "green", "house", "music" // Add more words as needed
        };

        private string hiddenWord;
        private int attemptsLeft = 6;
        public MainPage()
        {
            InitializeComponent();
            InitializeGame();
           
        }
        private void RestartGame()
        {
            

        ClearAllEntries();
    }

    private void InitializeGame()
        {
            Random random = new Random();
            hiddenWord = fiveLetterWords[random.Next(fiveLetterWords.Count)];
        }
        private void Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;
            if (entry.Text.Length > 1)
            {
                entry.Text = entry.Text.Substring(0, 1);
            }
        }

        private void SubmitWords_Clicked(object sender, EventArgs e)
        {
            StringBuilder wordBuilder = new StringBuilder();

            wordBuilder.Append(Box1.Text);
            wordBuilder.Append(Box2.Text);
            wordBuilder.Append(Box3.Text);
            wordBuilder.Append(Box4.Text);
            wordBuilder.Append(Box5.Text);
            wordBuilder.Append(Box6.Text);
            wordBuilder.Append(Box7.Text);
            wordBuilder.Append(Box8.Text);
            wordBuilder.Append(Box9.Text);
            wordBuilder.Append(Box10.Text);
            wordBuilder.Append(Box11.Text);
            wordBuilder.Append(Box12.Text);
            wordBuilder.Append(Box13.Text);
            wordBuilder.Append(Box14.Text);
            wordBuilder.Append(Box15.Text);
            wordBuilder.Append(Box16.Text);
            wordBuilder.Append(Box17.Text);
            wordBuilder.Append(Box18.Text);
            wordBuilder.Append(Box19.Text);
            wordBuilder.Append(Box20.Text);
            wordBuilder.Append(Box21.Text);
            wordBuilder.Append(Box22.Text);
            wordBuilder.Append(Box23.Text);
            wordBuilder.Append(Box24.Text);
            wordBuilder.Append(Box25.Text);





            string word = wordBuilder.ToString();

            if (word.Length != 5)
            {
                DisplayAlert("Incomplete Words", "Please enter 5 letters.", "OK");
                return;
            }



            CheckWord(word);
        }
        private void CheckWord(string word)
        {
            attemptsLeft--;

            char[] targetChars = hiddenWord.ToCharArray();
            char[] guessedChars = word.ToCharArray();

            int correctPositionAndLetterCount = targetChars. Where((c, i) => i < guessedChars.Length && guessedChars[i] == c)
                 .Count();

            // Check if the entered word exists in the list of valid 5-letter words
            if (correctPositionAndLetterCount == 5)
            {
                DisplayAlert("Congratulations!", "You guessed the word correctly: " + hiddenWord, "OK");
                InitializeGame();
            

        }
            else if (attemptsLeft <= 0)
            {
                DisplayAlert("Game Over", "No more attempts left. The word was: " + hiddenWord, "OK");
                InitializeGame();
            }
            else
            {
                DisplayAlert("Incorrect Word", $"Correct letters and positions: {correctPositionAndLetterCount}\nAttempts left: {attemptsLeft}", "OK");
            }

              ClearAllEntries();
        }

        private void ClearAllEntries()
        {
            // Clear text in all Entry controls
            Box1.Text = "";
            Box2.Text = "";
            Box3.Text = ""; 
            Box4.Text = "";
            Box5.Text = "";
            Box6.Text = "";
            Box7.Text = "";
            Box8.Text = "";
            Box9.Text = "";
            Box10.Text = "";
            Box11.Text = "";
            Box12.Text = "";
            Box13.Text = "";
            Box14.Text = "";
            Box15.Text = "";
            Box16.Text = "";
            Box17.Text = "";
            Box18.Text = "";
            Box19.Text = "";
            Box20.Text = "";
            Box21.Text = "";
            Box22.Text = "";
            Box23.Text = "";
            Box24.Text = "";
            Box25.Text = "";
        }
            

        }
    }
