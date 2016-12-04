using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class Creature
    {
        int creatureID;
        string creatureName;
        int movementRate;
        int preceptionRange;
        int agressionIndex;
        int growthRate;
        int foodValue;

        public int CreatureID { get { return creatureID; } set { creatureID = value; } }
        public string CreatureName { get { return creatureName; } set { creatureName = value; } }
        public int MovementRate { get { return movementRate; } set { movementRate = value; } }
        public int PreceptionRange { get { return preceptionRange; } set { preceptionRange = value; } }
        public int AgressionIndex { get { return agressionIndex; } set { agressionIndex = value; } }
        public int GrowthRate { get { return growthRate; } set { growthRate = value; } }
        public int FoodValue { get { return foodValue; } set { foodValue = value; } }
    }
}
