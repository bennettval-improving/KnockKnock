using System;
using System.Collections.Generic;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> correctKnockResponses = new List<string> 
            { 
                "WHOS THERE", 
                "WHO'S THERE", 
                "WHO THERE", 
                "WHOS THEIR", 
                "WHO'S THEIR", 
                "WHO THEIR", 
                "WHOS THEY'RE", 
                "WHO'S THEY'RE", 
                "WHO THEY'RE" 
            };
            var correctMikeyResponse = "MIKEY WHO";

            bool hasCorrectKnockResponse = false;
            bool hasCorrectMikeyResponse = false;

            Console.WriteLine("Knock! Knock!");

            while (!hasCorrectKnockResponse)
            {
                var knockResponse = Console.ReadLine();

                knockResponse = knockResponse.Trim().ToUpper();
                knockResponse = knockResponse.Split('?')[0];

                if (correctKnockResponses.Contains(knockResponse)) hasCorrectKnockResponse = true;
                else Console.WriteLine("Invalid Response! Try again.");
            }

            Console.WriteLine("Mikey");

            while (!hasCorrectMikeyResponse)
            {
                var mikeyResponse = Console.ReadLine();

                mikeyResponse = mikeyResponse.Trim().ToUpper();
                mikeyResponse = mikeyResponse.Split('?')[0];

                if (correctMikeyResponse.Equals(mikeyResponse)) hasCorrectMikeyResponse = true;
                else
                {
                    Console.WriteLine("Invalid Response! Try again.");
                }
            }

            Console.WriteLine("Mikey isn't working, can you let me in?");
            Console.WriteLine("THE END");
        }
    }
}
