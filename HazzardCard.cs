using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friday
{
    class HazzardCard : Card
    {
        private String hazzardName;
        private int freeDraw;
        private int phaseOneHazzardValue;
        private int phaseTwoHazzardValue;
        private int phaseThreeHazzardValue;
        private String knowledgeName;
        private int fight;
        private String ability;
        private const int lifePointCost = 1;
        private bool isHazzard = true;
        private bool isTapped;

        public HazzardCard(String hazzardName, int freeDraw, int phaseOneHazzardValue, int phaseTwoHazzardValue, int phaseThreeHazzardValue, String knowledgeName, int fight, String ability)
        {
            this.hazzardName = hazzardName;
            this.freeDraw = freeDraw;
            this.phaseOneHazzardValue = phaseOneHazzardValue;
            this.phaseTwoHazzardValue = phaseTwoHazzardValue;
            this.phaseThreeHazzardValue = phaseThreeHazzardValue;
            this.knowledgeName = knowledgeName;
            this.fight = fight;
            this.ability = ability;
        }

        public String getName()
        {
            if (isHazzard) return hazzardName;
            else return knowledgeName;
        }

        public void hazzardConvert()
        {
            isHazzard = false;
        }

        public int getHazzardValue(int phase)
        {
            if (phase == 1) return phaseOneHazzardValue;
            else if (phase == 2) return phaseTwoHazzardValue;
            else if (phase == 3) return phaseThreeHazzardValue;
            else return -1;
        }

        public String toString()
        {
            String card = "";
            //If the card is a hazzard card out output the hazzard side of the card
            if (isHazzard)
            {
                card += "Hazzard:" + "\t" + hazzardName + "\n";
                card += "Value: " + "\t\t" + phaseOneHazzardValue + "," + phaseTwoHazzardValue + "," + phaseThreeHazzardValue + "\n";
                card += "Free cards: " + "\t" + freeDraw + "\n";
                card += "Robinson:" + "\t" + knowledgeName + "\n";
                card += "Fight:" + "\t\t" + fight + "\n";
                card += "Ability:" + "\t" + ability + "\n";
            }
            else
            {
                card += "Robinson:" + "\t" + knowledgeName + "\n";
                card += "Fight:" + "\t\t" + fight + "\n";
                card += "Ability:" + "\t" + ability + "\n";
                card += "Hazzard:" + "\t" + hazzardName + "\n";
                card += "Value: " + "\t\t" + phaseOneHazzardValue + "," + phaseTwoHazzardValue + "," + phaseThreeHazzardValue + "\n";
                card += "Free cards: " + "\t" + freeDraw + "\n";
            }
            return card;
        }

        public int getFight()
        {
            return fight;
        }


    }
}
