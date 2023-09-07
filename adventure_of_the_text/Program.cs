using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("You have to save Our Lord, your the only person able too");
                Task.Delay(5000).Wait();
                Console.WriteLine("As you run up to the castle to save The Lord you run into a huge trash monster");
                Task.Delay(5000).Wait();
                Console.Clear();
                Console.WriteLine("Before you attack you have to roll a D20 to see the outcome of the interaction (Press Enter too roll the D20)");

                Console.ReadKey();
                Random rnd = new Random();
                int dice = rnd.Next(1, 21);

                string value = $"You rolled a {dice}";
                Console.WriteLine(value);
                Task.Delay(2000).Wait();

                if (dice <= 11)
                {
                    Console.Write($"You lose the fight with the trash monster and the lord dies and the whole kingdom falls. ");
                }

                else if (dice <= 19)
                {
                    Console.WriteLine($"You defeat the trash monter but the lord falls during a fight against the Trash Monster King and they take over the kingdom.");
                }

                else
                {
                    _ = dice = 20;
                    Console.WriteLine("You rolled a 20, You destroy the trash monster and you save the lord and in return he crowns you as the new lord to rule the kingdom. ");
                }

                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Uh oh, u didnt chose the correct path. You lose to the trash monster. ");
            }
        }
    }
}