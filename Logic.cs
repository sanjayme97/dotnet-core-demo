using System;

class Logic
{
    public void printPrimeNumbers(int range){
            bool isPrime = true;
            for (int i = 2; i <= range; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
                if (isPrime)
                {
                    Console.Write(i+" ");
                }
                isPrime = true;
            }
    }
}