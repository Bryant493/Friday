using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friday
{
    class PlayerArea
    {
        public List<Card> freeCards = new List<Card>();
        public List<Card> paidCards = new List<Card>();
        public HazzardCard chosenCard;
        public int lifePoints;
        public List<HazzardCard> toChoose = new List<HazzardCard>(2);
        public PlayerArea()
        {
            chosenCard = null;
            lifePoints = 20;
        }

        public void chooseHazzard(int card)
        {
            chosenCard = toChoose[card-1];
        }

        public int getFightingPoints()
        {
            int totalFightingPoints = 0;
            for(int i = 0; i < freeCards.Count - 1; i++)
            {
                totalFightingPoints = freeCards[i].getFight();
            }
            for(int i = 0; i < paidCards.Count - 1; i++)
            {
                totalFightingPoints = paidCards[i].getFight();
            }
            return totalFightingPoints;
        }

        public String toString()
        {
            String cards = "";
            int hazzardPlacement = (freeCards.Count + paidCards.Count)/2;
            for (int i = 0; i < (freeCards.Count + paidCards.Count); i++)
            {
                if (i < freeCards.Count)
                {
                    cards += freeCards[i].toString() + "\n\n";
                }

                else
                {
                    cards += paidCards[i].toString() + "\n\n";
                }

                if(i == hazzardPlacement)
                {
                    cards += "\t" + chosenCard.toString();
                }
            }
            return cards;
        }

    }
}
