using System;

namespace hangman_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("                  Welcome to Hangman                ");
            Console.WriteLine("****************************************************");
            int lives = 5;
            string[] titles = new string[] { "Gangs of New York", "The Dark Knight rises" };
            Random random = new Random();
            // Display asterik-cised word - masked
            // Select a random word - return word at the random index of the master string list.
            string titleSelection = titles[random.Next(0, titles.Length)];
            // Select random 80% of the string's char indexes.
            // 
            string maskedTitle =  ReturnMaskedTitle(titleSelection,80);
            Console.WriteLine(titleSelection);
            Console.WriteLine(maskedTitle);

            // while lives are > 0, keep validating entered inputs
            while(lives > 0) ValidateKey(Console.ReadKey().KeyChar);


            void ValidateKey(char userInput) // take original string & masked tring also as inputs
            { 
                // check key along original string, 
                // if present, replace original char -> asterikCount--;
                // display updatedMaskedString
                // if asterikCount == 0, you win/score a point
                // display || SCORE | SCORE | 

                // if key is not present, lives--
            }

            //  TO-DO : Ensure MIN 70% and MAX 80% is masked

            string ReturnMaskedTitle(string title, int percent)
            {
                char[] charrArray = title.ToCharArray();
                int strLength = charrArray.Length;
                int counter = 0;
                for (int i = 0;  i < charrArray.Length; i++) 
                {
                    if (1 == random.Next(0, 2)) {
                        if(!Char.IsWhiteSpace(charrArray[i])) // and if char isn't already *
                        {
                            charrArray[i] = '*';
                            counter++;
                        }
                    }
                    if ((counter / strLength) > (percent / 100))
                        break;
                }
                return new string(charrArray);
            }
        }
    }

    class MyClass
    {

    }
}
