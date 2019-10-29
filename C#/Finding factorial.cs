using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        { int x,dum;
          double fac;
          Console.WriteLine("Finding Factorial");
          Console.WriteLine("\nEnter number to find factorial");
          x=Convert.ToInt32(Console.ReadLine());
          dum=x;
          fac=1.0;
          while(dum>0)
          {
             
              fac=dum*fac;
              dum--;
            
          }
        Console.WriteLine ("The factorial of{0} is {1}",x,fac);
        Console.WriteLine("THANKYOU");
        
        }
    }
}
