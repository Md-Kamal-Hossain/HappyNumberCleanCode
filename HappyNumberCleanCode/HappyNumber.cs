using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumberCleanCode
{
    public static class HappyNumber
    {
        public static int IsHappyNumber(int happyNumber)
        {

            int sum = 0;int rem = 0;    
            while (happyNumber>0) 
            {
                rem = happyNumber % 10;
                sum = sum+ rem*rem;
                happyNumber =happyNumber / 10;  
            }
            return sum;
            




        }
       

    }
}
