// if (6 >= 3){
//     Console.WriteLine("Hello World!");
// }



// Console.WriteLine("Skriv ditt användarnamn");
// string namn = Console.ReadLine();
// Console.WriteLine("Skriv ditt lösenord ");
// string lösenord = Console.ReadLine();

// if (namn == "noname" && lösenord == "nopass")
// {
//     Console.WriteLine("Välkommen!");
// }

// else 
// {
//     Console.WriteLine("Fel lösenord eller användarnamn.");
// }




// for (int i=0; i<32; i++) 
// {
//     Console.WriteLine("Hello World" + i);
// }


// Console.WriteLine("Skriv ditt lösenord");
// string password = Console.ReadLine();
// while (password != "nopass") 
// {
//     Console.WriteLine("Fel lösenord");
//     password = Console.ReadLine();
// }
// Console.WriteLine("Välkommen");



// for (int i=1; i<5; i++) 
// {
//     Console.WriteLine("Skriv ett tal");
//     string tal = Console.ReadLine();
//     bool succes = int.TryParse(tal, out int result);

//     if (result>5)
//     {
//         Console.WriteLine("Högre än 5");
//     }

// }




// string input;
// int nummer;

// while (true) 
// {
//     Console.WriteLine("Ange ett tal");
//     input = Console.ReadLine();

//     if (int.TryParse(input, out nummer))
//     {
//         Console.WriteLine("Giltigt");
//     }

//     else{
//         Console.WriteLine("Ogiltigt");
//         break;
//     }

// }

int tal = Random.Shared.Next(1,10);
bool korrektGissning = false;
Console.WriteLine("Du ska gissa vilket tal mellan 1-10 som är rätt. Ange ett tal mellan 1-10");
while (!korrektGissning)
{
    string användarInput = Console.ReadLine();
    int gissning;

    if (int.TryParse(användarInput, out gissning))
    {
        if (gissning == tal)
        {
            Console.WriteLine("Snyggt! Du gissade rätt!");
            break;
        }

        else if (gissning > tal)
        {
            Console.WriteLine("För högt! Försök igen");
        }

        else if (gissning < tal)
        {
            Console.WriteLine("För lågt! Försök igen");
        }
       
    }

    else
    {
        Console.WriteLine("Ogiltig inmatning, skriv ett tal mellan 1-10");
    }

}


Console.ReadLine();