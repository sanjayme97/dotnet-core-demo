using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {  int range=100;
             try{
            Console.WriteLine("Enter The Max Range till the Prime Number Should print");
            range= int.Parse(Console.ReadLine());
           } catch(Exception){
          Console.WriteLine("Invalid Input");}
            
            Logic logic = new Logic();
            logic.printPrimeNumbers(range);
        }
    }
}
