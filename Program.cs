//main
using System.Globalization;

string userChoice = "";
while(userChoice != "4"){
    DisplayMenu();
    userChoice = GetUserChoice();
    RouteEm(userChoice);
}
//end main


static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("Enter 1 to display a plain topping-less pizza slice\nEnter 2 to display cheese pizza slice\nEnter 3 to display pepperoni pizza slice\nEnter 4 to exit");
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void RouteEm(string userChoice){
    switch(userChoice){
        case "1":
            PlainPizza();
            break;
        case "2":
            CheesePizza();
            break;
        case "3":
            PepperoniPizza();
            break;
        case "4":
            SayBye();
            break;
        default:
            InvalidInput();
            break;
    }
}

static int GetRndNumber(){
    Random rnd = new Random();
    int numRows = rnd.Next(8,13);
    return numRows;
}

static void PlainPizza(){
    int numRows = GetRndNumber();
    System.Console.WriteLine();
    for(int i = 0; i < numRows; i++){
        for(int j = 0; j < numRows - i; j++){
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    Pause();
}

static void CheesePizza(){
    int numRows = GetRndNumber();
    System.Console.WriteLine();
    for(int i=0; i < numRows; i++){
        for(int j = 0; j < numRows - i; j++){
            if(j == numRows-i-1 || j == 0){
                Console.Write("* ");
            }
            else if(i == numRows-1 || i == 0){
                Console.Write("* ");
            }
            else{
                Console.Write("# ");
            }
        }
        Console.WriteLine();
    }
    Pause();
}

static void PepperoniPizza(){
    int numRows = GetRndNumber();
    System.Console.WriteLine();
    for(int i=0; i < numRows; i++){
        for(int j = 0; j < numRows - i; j++){
            if(j == numRows-i-1 || j == 0){
                Console.Write("* ");
            }
            else if(i == numRows-1 || i == 0){
                Console.Write("* ");
            }
            else{
                Random rnd = new Random();
                int number = rnd.Next(4);
                if(number != 0){
                    Console.Write("# ");
                }
                else{
                    Console.Write("[]");
                }
            }
        }
        Console.WriteLine();
    }
    Pause();
}

static void SayBye(){
    System.Console.WriteLine("Goodbye!");
}

static void InvalidInput(){
    System.Console.WriteLine("Invalid Input");
}

static void Pause(){
    System.Console.WriteLine("\nPress any key to continue");
    Console.ReadKey();
}