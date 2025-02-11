using System;
 
public class RockPaperScissors{

    static void Main(string [] args){

        Console.WriteLine("Enter Your name: ");

        string name = Console.ReadLine();

        Console.WriteLine("Hey Hi! {0} Let's play rock paper scissors!", name);

        Random random = new Random();

        int randInt = random.Next(1,4);

        string choice = "";

        switch(randInt){

            case 1:

                choice = "rock";

                break;

            case 2 :

                choice = "paper";

                break;

            case 3 :

                choice = "scissors";

                break;

        }
 
        Console.WriteLine("Choose Rock, Paper or Scissors: ");

        string userChoice = Console.ReadLine();

        userChoice = userChoice.ToLower();

        if (userChoice != "rock" && userChoice !="paper" && userChoice != "scissors"){

            Console.WriteLine("Please choose a valid choice dumba$$");

        }

        else if(userChoice == choice){

            Console.WriteLine("I went with "+ choice + " you went with "+ userChoice);

            Console.WriteLine("It's a Draw!");

        }

        else  if((choice == "rock" && userChoice == "scissors") || (choice == "Scissors" && userChoice == "paper")

            || (choice == "Paper" && userChoice == "rock")){

              Console.WriteLine("I went with "+ choice + " you went with "+ userChoice);

            Console.WriteLine("you lost {0}", name);

        }

        else if((choice == "scissors" && userChoice == "rock") || (choice == "paper" && userChoice == "Scissors")

            || (choice == "rock" && userChoice == "paper")){

            Console.WriteLine("I went with "+ choice + " you went with "+ userChoice);

            Console.WriteLine("you won {0}", name);

        }

    }

}
 