
            // vars and opening statement
            string userInput;
            string translatedToPigLatin;
            string check;

            Console.WriteLine("Welcome to the Pig Latin translator!");
            user - dfg;

            /* Expected outcome:
                 Welcome to the Pig Latin Translator!
                 Enter a line to be translated: {this sentence exists here}
                 Isthay entencesay existsway erehay
                 Translate another line ? (y / n) : N 
                 Move user input to a string array, then run each word through each part of the array.
             */


            // getting, calling, spitting, checking
            while (true)
            {
                // user input
                Console.Write("Please, enter a line to be translated: ");
                userInput = Console.ReadLine();

                // call method to translate
                translatedToPigLatin = PigLatinMagic(userInput.ToLower()); //make lower before passing to method
                
                // output Pig Latin
                Console.WriteLine(translatedToPigLatin);

                // check for continue
                Console.Write("Would you like to translate another line? (y/n): ");
                check = Console.ReadLine();
                if (check != "y")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cool, let's do this again!");
                }
            }
        }
        // method to translate
        // add functionality to check for multiple consonants and remove them
        // add functionality to convert full sentences
        static string PigLatinMagic(string x)
        {
            // vars only used in this method
            string firstLetter = x.Substring(0, 1);
            string ay = "ay";
            string way = "way";
            string translated;
            string restOfWord;
            

            //Start checks and translation
            
            if ("aeiou".Contains(firstLetter)) // Check for vowel
            {
                translated = (x + way);
                return translated;
            }
            else // No vowel, do the translate
            {
                restOfWord = x.Remove(0, 1);
                translated = restOfWord + firstLetter + ay;

                return translated;
            }
        }
