Console.WriteLine("you have three guesses. goodluck.. goodluck");
Console.WriteLine("Guess a Number From 1 to thirty-Five!");


     Random random = new Random(); 
 int randomNumber = random.Next(1,35); 
 int guess = 0;
 int lastGuess;
 int no_ofGuess = 1;
 bool end = false;
 while(end == false) 
 { 
     lastGuess = guess;
     guess = Convert.ToInt32(Console.ReadLine());

  if(guess == lastGuess || guess > 35) 
  {
     Console.WriteLine("Invalid Try, Try another Number");

 }
     else if (guess != randomNumber && no_ofGuess == 3) 
     {
         Console.WriteLine("Game Over");
         end = true;
     } 

     else if(guess == randomNumber)  
     {
            Console.WriteLine("You won");
         end = true;
     }

     else if(guess > randomNumber && lastGuess != guess) 
     {
         Console.WriteLine($" {3 - no_ofGuess } chances left ");
         Console.WriteLine("enter a lesser value");
         no_ofGuess  = no_ofGuess  + 1;
      }

