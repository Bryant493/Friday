using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friday
{
    /**
     * Represents the Hazzard deck with the hazzard deck and its discard pile.  This deck can only contain hazzard cards
     */ 
    class HazzardDeck
    {
        /**
         * List that represents the deck of hazzard cards
         */ 
        List<HazzardCard> hazzardDeck = new List<HazzardCard>();
        /**
         * List that represents the hazzard discard pile
         */ 
        List<HazzardCard> discardPile = new List<HazzardCard>();
        /**
         * Constructs the hazzard deck containing all the starting cards.
         */ 
        public HazzardDeck()
        {
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "food", 0, "+1 life"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "food", 0, "+1 life"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "food", 1, "+1 life"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "food", 1, "+1 life"));
            hazzardDeck.Add(new HazzardCard("Further exploring the island", 3, 2, 5, 8, "food", 2, "+1 life"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "deception", 0, "1x below the pile"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "deception", 1, "1x below the pile"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "strategy", 0, "2x exchange"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "strategy", 0, "2x exchange"));
            hazzardDeck.Add(new HazzardCard("Further exploring the island", 3, 2, 5, 8, "strategy", 2, "1x exchange"));
            hazzardDeck.Add(new HazzardCard("Wild animals", 4, 4, 7, 11, "strategy", 3, "1x exchange"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "equipment", 0, "+2 cards"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "equipment", 0, "+2 cards"));
            hazzardDeck.Add(new HazzardCard("Further exploring the island", 3, 2, 5, 8, "vision", 2, "sort 3 cards"));
            hazzardDeck.Add(new HazzardCard("Wild animals", 4, 4, 7, 11, "vision", 3, "sort 3 cards"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "weapon", 2, null));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "weapon", 2, null));
            hazzardDeck.Add(new HazzardCard("Cannibals", 5, 5, 9, 14, "weapon", 4, null));
            hazzardDeck.Add(new HazzardCard("Cannibals", 5, 5, 9, 14, "weapon", 4, null));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "realization", 0, "1x destroy"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "realization", 1, "1x destroy"));
            hazzardDeck.Add(new HazzardCard("Further exploring the island", 3, 2, 5, 8, "realization", 2, "1x destroy"));
            hazzardDeck.Add(new HazzardCard("Wild animals", 4, 4, 7, 11, "realization", 3, "1x destroy"));
            hazzardDeck.Add(new HazzardCard("Further exploring the island", 3, 2, 5, 8, "experience", 2, "+1 card"));
            hazzardDeck.Add(new HazzardCard("Wild animals", 4, 4, 7, 11, "experience", 3, "+1 card"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "books", 0, "phase -1"));
            hazzardDeck.Add(new HazzardCard("With the raft to the wreck", 1, 0, 1, 3, "mimicry", 0, "1x copy"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "mimicry", 1, "1x copy"));
            hazzardDeck.Add(new HazzardCard("Exploring the island", 2, 1, 3, 6, "repeat", 1, "1x double"));
            hazzardDeck.Add(new HazzardCard("Further exploring the island", 3, 2, 5, 8, "repeat", 1, "1x double"));
            shuffle();
        }

        /**
         * Shuffles the deck according to the Fisher-Yates algorithm
         */ 
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = hazzardDeck.Count; i > 1; i--)
            {
                int nextRand = rand.Next(i);

                HazzardCard temp = hazzardDeck[nextRand];
                hazzardDeck[nextRand] = hazzardDeck[i - 1];
                hazzardDeck[i - 1] = temp;
            }
        }

        /**
         * Basically just outputs the list of the deck line by line
         */ 
        public String deckToString()
        {
            String deck = "";
            for (int i = 0; i < hazzardDeck.Count; i++)
            {
                deck += hazzardDeck[i].toString() + "\n";
            }
            return deck;
        }

        /**
         * Draws a card from the hazzard Deck
         */ 
        public HazzardCard draw()
        {
            //Gets the last card in the list and adds it to card
            HazzardCard card = hazzardDeck[hazzardDeck.Count - 1];
            //Removes the card from the list and returns it
            hazzardDeck.RemoveAt(hazzardDeck.Count - 1);
            return card;

        }

        /**
         * Adds a card to the discard pile
         */ 
        public void discard(HazzardCard card)
        {
            discardPile.Add(card);
        }

        /**
          * A to string of the discard pile list.
          */ 
        public String discardToString()
        {
            String deck = "";
            for (int i = 0; i < discardPile.Count; i++)
            {
                deck += discardPile[i].toString() + "\n";
            }
            return deck;
        }
    }
}
