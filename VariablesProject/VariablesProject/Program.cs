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
            Console.WriteLine("Ryan Studios");
            Console.WriteLine();
            Console.WriteLine("The Best Game of All Time");
            Console.WriteLine();

            // whole number = integer (0,1,2,3,-1,-2)


            // declaring score variable to be integer type
            int score;
            int enemyValue;
            string realName;
            string gamerTag;
            float percentile; // 0.0 , 100.0
            int shield;
            int health;


            // initializing 
            health;
            shield = 100;
            enemyValue = 250;
            score = 0;
            realName = "Ryan LeBlanc";
            gamerTag = "Ryphil";
            percentile = 85.543f;


            // pretend gameplay
            score = score + enemyValue; // "=" means assign or get value
            // score += enemyValue; "+=" same thing as ^
            percentile = 290000.0f / 300000.0f * 100;
            // hud
            Console.WriteLine(realName + " (" + gamerTag + ")"); 
            
            Console.WriteLine("Score: " + score);
            Console.WriteLine("Percentile Rank: " + percentile + " %");
            
            Console.WriteLine();
            



            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        
        }
    }
}
