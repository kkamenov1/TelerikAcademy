using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalArea = 250M;
            
            
            decimal tomatoSeeds = decimal.Parse(Console.ReadLine());
            decimal tomatoArea = decimal.Parse(Console.ReadLine());
            decimal cucumberSeeds = decimal.Parse(Console.ReadLine());
            decimal cucumberArea = decimal.Parse(Console.ReadLine());
            decimal potatoSeeds = decimal.Parse(Console.ReadLine());
            decimal potatoArea = decimal.Parse(Console.ReadLine());
            decimal carrotSeeds = decimal.Parse(Console.ReadLine());
            decimal carrotArea = decimal.Parse(Console.ReadLine());
            decimal cabbageSeeds = decimal.Parse(Console.ReadLine());
            decimal cabbageArea = decimal.Parse(Console.ReadLine());
            decimal beansSeeds = decimal.Parse(Console.ReadLine());

            decimal tomatoSeedsAll = tomatoSeeds * 0.5M;
            decimal cucumberSeedsAll = cucumberSeeds * 0.4M;
            decimal potatoSeedsAll = potatoSeeds * 0.25m;
            decimal carrotSeedsAll = carrotSeeds * 0.6M;
            decimal cabbageSeedsAll = cabbageSeeds * 0.3M;
            decimal beansSeedsAll = beansSeeds * 0.4M;

            decimal totalSeedsCost = tomatoSeedsAll + cucumberSeedsAll + potatoSeedsAll + carrotSeedsAll + cabbageSeedsAll + beansSeedsAll;
            decimal beansArea = totalArea - (tomatoArea + cucumberArea + potatoArea + carrotArea + cabbageArea);


            Console.WriteLine("Total cost: " + totalSeedsCost);
            if (beansArea < 0)
            {
                Console.WriteLine("Insufficient area");
            }
            else if (beansArea == 0)
            {
                Console.WriteLine("No area for beans");
            }
            else
            {
                Console.WriteLine("Beans Area: " + beansArea);
            }
        }
    }
}
