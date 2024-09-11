using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "APPLE", "HOUSE", "MOUSE", "TRAIN", "PLANE", "BEACH", "CLOUD", "DREAM",
                "EARTH", "FLAME", "GRAPE", "HEART", "IVORY", "JELLY", "KNIFE", "LEMON",
                "MUSIC", "NIGHT", "OCEAN", "PIANO", "QUEEN", "RIVER", "STORM", "TABLE",
                "VOICE", "WATER", "YOUTH", "ZEBRA", "BREAD", "CHAIR", "DANCE", "EAGLE",
                "FROGS", "GHOST", "HONEY", "JUICE", "KITES", "LIGHT", "MAGIC", "NURSE",
                "OLIVE", "PAPER", "QUIET", "RADIO", "SNAKE", "TIGER", "UNCLE", "WITCH",
                "YACHT", "ZESTY", "BLOOM", "CRISP", "DWARF", "ELBOW", "FLUTE", "GLOVE",
                "HATCH", "IGLOO", "JOKER", "KOALA", "LUNAR", "MANGO", "NOBLE", "OASIS",
                "PLUSH", "QUILT", "ROBOT", "SWIRL", "TULIP", "URBAN", "VENOM", "WALTZ",
                "YUMMY", "BLISS", "CRAVE", "DROOP", "EERIE", "FLAKY", "GIDDY", "HOARD",
                "JAZZY", "KAYAK", "LUCKY", "MOODY", "NERDY", "ONION", "PLUMP", "QUIRK",
                "ROAST", "SPICY", "TROUT", "UNZIP", "VAGUE", "WHISK", "YIELD", "ACORN",
                "BROOM", "CLOWN", "DAISY", "FROST", "GREEN", "HAPPY", "JUMBO", "MELON",
                "NORTH", "PEACH", "QUICK", "SUNNY", "THUMB", "WAGON", "RUNNY", "CURLY",
                "TRUCK"
            };
            Random rnd = new Random();
            int RandomWordIndex = rnd.Next(0, words.Length);
            string secretWord = words[RandomWordIndex];
            
            Console.WriteLine("Guess a five letter word!");
            string input = Console.ReadLine().ToUpper();
            
            if (input.Length != 5)
            {
                Console.WriteLine("This Word Doesn't have five letters");
            }
           else
           {
                if (input == secretWord)
                {
                    Console.WriteLine("You got it!");
                }
                else
                {
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (secretWord[i] == input[i])
                        {
                            Console.WriteLine(input[i]);
                        }
                        else if (secretWord.Contains(input[i]))
                        {
                            Console.Write("O");
                        }
                        else
                        {
                            Console.Write("X");
                        }

                        Console.WriteLine("Guess Again");
                   
                    }


                
                }

            
            
           }
          
            Console.ReadLine();



        }
            

    }
}
