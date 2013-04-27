using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friday
{
    /**
     * This calss represents a robinson deck with all of its cards represented as a list.
     * It also represents the discard pile.
     */ 
    class RobinsonDeck
    {
        /**
         * List that represents the deck 
         */ 
        List<Card> robinsonDeck = new List<Card>();
        /**
         * List that represents the discard pile
         */ 
        List<Card> robinsonDiscard = new List<Card>();
        /**
         * Constructs a robinson deck with all the starting cards in the deck and adds them to the robinsonDeck.
         */ 
        public RobinsonDeck()
        {
            robinsonDeck.Add(new RobinsonCard("distracted", -1, null));
            robinsonDeck.Add(new RobinsonCard("distracted", -1, null));
            robinsonDeck.Add(new RobinsonCard("distracted", -1, null));
            robinsonDeck.Add(new RobinsonCard("distracted", -1, null));
            robinsonDeck.Add(new RobinsonCard("distracted", -1, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("weak", 0, null));
            robinsonDeck.Add(new RobinsonCard("eating", 0, "+2 life"));
            robinsonDeck.Add(new RobinsonCard("focused", 1, null));
            robinsonDeck.Add(new RobinsonCard("focused", 1, null));
            robinsonDeck.Add(new RobinsonCard("focused", 1, null));
            robinsonDeck.Add(new RobinsonCard("focused", 2, null));
            shuffle();
        }

        /**
         * Shuffles the deck according to the Fisher-Yates algorithm
         */ 
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = robinsonDeck.Count; i > 1; i--)
            {
                int nextRand = rand.Next(i);

                Card temp = robinsonDeck[nextRand];
                robinsonDeck[nextRand] = robinsonDeck[i - 1];
                robinsonDeck[i - 1] = temp;
            }
        }

        /**
         * Simply draws a card from the deck at the last element in the robinsonDeck list
         */ 
        public Card draw()
        {
            //Gets the last card in the list and adds it to card
            Card card = robinsonDeck[robinsonDeck.Count - 1];
            //Removes the card from the list and returns it
            robinsonDeck.RemoveAt(robinsonDeck.Count - 1);
            return card;

        }

        //Discards the specified card to the discard pile.
        public void discard(Card card)
        {
            robinsonDiscard.Add(card);
        }
    }
}
