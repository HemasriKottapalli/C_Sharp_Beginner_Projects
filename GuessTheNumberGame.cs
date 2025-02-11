using System;
 
public class GuessTheNumberGame{

    static void Main(string[] args){

        Console.WriteLine("Enter your Name: ");

        string name = Console.ReadLine();

        Console.WriteLine("Hey Hi " + name + " Let's start gueesing! ");

        Random random = new Random();

        int randomNumber = random.Next(10, 100);

        Console.WriteLine(randomNumber);

        int attemptsAllowed = 9;

        int noOfAttempts = 1;

        Console.WriteLine("Guess a Number between 10 and 99 :");

        int guessedNumber = Convert.ToInt32( Console.ReadLine());

        while (noOfAttempts <= attemptsAllowed){

            if (guessedNumber == randomNumber){

                Console.WriteLine("Yay! it's a win and the attempts you took : " + noOfAttempts);

                break;

            }

             else if (guessedNumber < randomNumber){

                    Console.WriteLine("Can you try guessing a bigger number? and the attempts you have left is :" + (attemptsAllowed - noOfAttempts));

                    guessedNumber = Convert.ToInt32( Console.ReadLine());

            }

            else{

                Console.WriteLine("Can you try guessing a smaller number? :");

                guessedNumber = Convert.ToInt32( Console.ReadLine());

            }

            noOfAttempts++;

        }

    }

}
 