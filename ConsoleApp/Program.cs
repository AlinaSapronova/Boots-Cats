// See https://aka.ms/new-console-template for more information

while(true){
Console.Write("Enter the number: ");
string inputNumber = Console.ReadLine();
if(int.TryParse(inputNumber, out int convertedNumber))
{
   
    if(convertedNumber % 5 == 0 && convertedNumber % 3 == 0)
{
    Console.WriteLine(" boots cats ");
   
}
else if(convertedNumber % 3 == 0)
{
     Console.WriteLine(" cats ");
     
}
else if(convertedNumber % 5 == 0)
{
     Console.WriteLine("boots ");
    
}
else
{
     Console.WriteLine(convertedNumber);
    
}
}
else
{
     Console.WriteLine("Invalid input");
}
}





