using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friday
{
    /**
     * The start of a text GUI for the Game Friday.   
     */ 
    class Friday
    {
        public static void Main()
        {
            // Creates new player, hazzard deck, and robinson deck.
            PlayerArea player = new PlayerArea();
            HazzardDeck hazzardDeck = new HazzardDeck();
            RobinsonDeck robinsonDeck = new RobinsonDeck();
            String hazzardChoice = "";
            // Which hazzard to choose. 1 for the first card and 2 for the second
            int hazzardNumber;

            Console.Write("Friday: A solo adventure" + "\n\n");
            while (true)
            {
                // Draw two cards and add them to the tochoose deck to be chosen
                player.toChoose.Add(hazzardDeck.draw());
                player.toChoose.Add(hazzardDeck.draw());
                Console.Write("Choose one of the Hazzards" + "\n");
                Console.Write("1 = first card, 2 = second card" + "\n\n");
                // Output the two cards so the user can choose
                Console.Write("1) " + "\n" + player.toChoose[0].toString() + "\n");
                Console.Write("2) " + "\n" + player.toChoose[1].toString() + "\n\n");
                // Read in the choice and add choose that card to be the chosen hazzard
                hazzardChoice = Console.ReadLine();
                int.TryParse(hazzardChoice, out hazzardNumber);
                player.chooseHazzard(hazzardNumber);
                //if (hazzardNumber == 1)
                //{
                    //hazzardDeck.discard(player.toChoose[1]);
                //}
                Console.Clear();
                player.toString();
                Console.ReadKey();
            }
        }
    }
}
