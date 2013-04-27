using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friday
{
    /**
     * Class that represents a Robinson fighting card with all of its attributes. It implemetns the Card interface as it needs to be put into a deck that also has hazzard cards
     */
    public class RobinsonCard : Card
    {
        /**
         * The name of the Robinson card
         */ 
        private String name;
        /**
         * The fight(attack) value of the card.  This is not constant because this value could be changed later on by a card with an ability
         */
        private int fight;
        /**
         * A string representation of an ability.  This is going to be changed later on to an object that represents the ability.
         */ 
        private String ability;
        /**
         * The total cost of life points to remove this card from the game. 
         */
        private const int lifePointCost = 1;
        /**
         * This represents if the ability of this card has been used.  It is false of the ability has not been used and true if it has.
         */
        private Boolean isTapped = false;

        /**
         * Constructs a new Robinson card.  Instantiates the name its fight and its ability(for now).
         */ 
        public RobinsonCard(String name, int fight, String ability)
        {
            this.name = name;
            this.fight = fight;
            this.ability = ability;
        }

        /**
         * Returns the name of the Robinson card.
         */ 
        public String getName()
        {
            return name;
        }

        /**
         * Returns the fight value of the card to be used to attack
         */ 
        public int getFight()
        {
            return fight;
        }

        /**
         * Sets the fight value of the card.  This will be used when the cards fight value is doubled from another cards ability.
         */ 
        public void setFight(int newFight)
        {
           fight = newFight;
        }

        /**
         * When the ability of this card has been used it becomes tapped because after an ability has been used it cannot be used again.
         */ 
        public void useAbility()
        {
            isTapped = true;
        }

    }
}
