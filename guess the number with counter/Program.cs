// lets make guess the number software

// in order to do that we need to declare two variables

using System.Transactions;

int numberToGuess = 56;

// and we need to declare another variable and set it to zero

int userNumber = 0;

int tries = 0;

// Now we need to use the while and if stataments to keep the program running 

//At first lets ask the user to input the number

Console.WriteLine("Please enter the number");






while (numberToGuess!=userNumber)
{
    tries++;
    // in this while loop we have set the condition to run the programme until the user has inputed the correct number
    // converting the user input into number
    userNumber = int.Parse(Console.ReadLine());
    //Now lets declare the tries and how many tries it took to guess the number right

   
    
    // using if Staments to run the programme. 
    if (numberToGuess > userNumber)
    {
        Console.WriteLine("the number is too high try again");
    }else if (numberToGuess < userNumber) 
    { Console.WriteLine
            ("Number is too long try again"); }

    else { Console.WriteLine("Good job it took you " + tries ); }
}