using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variables.");
            Console.WriteLine("--------------");
            Console.WriteLine();

            // whole number = integer (0,1,2,3,-1,-2)


            // declaring score variable to be integer type
            int score;
            int enemyValue;
            string realName;
            string gamerTag;
            float percentile;

            
            
            // initializing 
            enemyValue = 250;
            score = 0;
            realName = "Ryan LeBlanc";
            gamerTag = "Ryphil";
            percentile = 85.543f;


            // pretend gameplay
            score = score + enemyValue; // "=" means assign or get value
            // score += enemyValue; "+=" same thing as ^

            // hud
            Console.WriteLine(realName + " (" + gamerTag + ")");
            
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Percentile Rank: " + percentile);
            
            Console.WriteLine();
            Console.WriteLine("Hi, " + realName + ". " + "How are you?");



            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        
        }
    }
}
