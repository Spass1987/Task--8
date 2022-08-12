//Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все четные числа от 1 до N.
//пример: 5 -> 2,4 ; 8 -> 2, 4, 6, 8.

Console.Clear(); 
Console.WriteLine("This program find all even number from 1 to Number.");
Console.WriteLine("Please ender your integer number for finding:");
int Number=Convert.ToInt32(Console.ReadLine()); 
int Index=1; 
int TotalNumber = 0; 
Console.Write("There are the following even numbers between 1 and " + Number +" : ");
while (Index<=Number)
{
   int Result=Index % 2; 
     if (Result==0)
      {
           Console.Write(Index + " ");
           TotalNumber++;
      }
      Index++;
}
if (TotalNumber==0) 
{
    Console.Write("Nothing was found!");
}
Console.WriteLine();
Console.WriteLine("Total number of all even number = "+ " "+ TotalNumber);
 