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
            Console.WriteLine("--------------------------");
            Console.WriteLine("The Best Game of All Time");
            Console.WriteLine("--------------------------");

            // whole number = integer (0,1,2,3,-1,-2)


            // declaring score variable to be integer type
            int exp;
            int enemyValue;
            string gamerTag;
            float percentile; // 0.0 , 100.0
            int shield;
            int health;
            int lives;
            int monsterattack;
            int monsterhealth;
            
            // initializing 
            health = 100;
            shield = 100;
            enemyValue = 250;
            exp = 0;
            gamerTag = "Ryphil";
            lives = 3;
            monsterattack = 10;
            monsterhealth = 100;
            percentile = 30.2f;
            
            
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name: " + gamerTag + "        " + "Lives: " + lives); ;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Health: " + health + "        " + "Shield: " + shield);
            
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Exp: " + exp);
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Battle Starting!!!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name: " + gamerTag + "        " + "Lives: " + lives + "   |   Enemy: Monster" + "      Health: " + monsterhealth );
            Console.WriteLine("Health: " + health + "        " + "Shield: " + shield + " |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("The wild Monster uses Rising Cut!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" - 10 !");
            Console.WriteLine();
            shield = shield - monsterattack;
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name: " + gamerTag + "        " + "Lives: " + lives + "   |   Enemy: Monster" + "      Health: " + monsterhealth);
            Console.WriteLine("Health: " + health + "        " + "Shield: " + shield + "  |");
            Console.WriteLine("--------------------------------");

            


            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Exp: " + exp);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Ryphil uses Cross Slash!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("It's a critical hit!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" -  100 !");
            Console.WriteLine();
            Console .WriteLine("-------------------------------");
            monsterhealth = monsterhealth - 100;
            
            Console.WriteLine("Name: " + gamerTag + "        " + "Lives: " + lives + "   |   Enemy: Monster" + "      Health:" + monsterhealth);
            Console.WriteLine("Health: " + health + "        " + "Shield: " + shield + "  |");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Victory!, You've been awarded " + enemyValue + "Exp.");

            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Name: " + gamerTag + "        " + "Lives: " + lives + "   |  ");
            Console.WriteLine("Health: " + health + "        " + "Shield: " + shield + "  |");
            Console.WriteLine("--------------------------------");




            Console.WriteLine();
            Console.WriteLine();

            exp = exp + enemyValue;

            Console.WriteLine("Exp: " + exp);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}