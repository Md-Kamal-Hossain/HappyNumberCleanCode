using System;

namespace HappyNumberCleanCode 
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Happy Number"  + " : ");
            
            int result = Number;
          
            while (result != 1 && result != 4)
            {
                result = HappyNumber.IsHappyNumber(result);
            }                 
            if (result == 1)
            {
                Console.Write(Number + " ");
            }
            
            Console.ReadKey();
        }
    }
}