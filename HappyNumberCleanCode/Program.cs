using System;

namespace HappyNumberCleanCode 
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a Number : ");
            int Number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Your given number"  + "  ");
            
            int result = Number;
          
            while (result != 1 && result != 4)
            {
                result = HappyNumber.IsHappyNumber(result);
            }                 
            if (result == 1)
            {
                Console.Write(Number + " Happy number");
            }
            else
            {
                Console.Write(Number + " Not happy number");    
            }
            
            Console.ReadKey();
        }
    }
}