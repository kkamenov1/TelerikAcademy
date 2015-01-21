using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravitationOnTheMoon
{
    class Program
    {
        const double moonGravity = 0.17;

        static void Main(string[] args)
        {
            Console.Write("Enter your weight: ");
            double weight = double.Parse(Console.ReadLine());

            double moonWeight = weight * moonGravity;
            Console.WriteLine("Your weight on the moon is: {0}", moonWeight);
        }
    }
}
