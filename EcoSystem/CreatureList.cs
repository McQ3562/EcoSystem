using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class CreatureList
    {
        List<Creature> creatureList = new List<Creature>();

        public void Load(INIFile creatureFile)
        {
            int creatureCounter = 1;
            int creatureID;

            while (Int32.TryParse(creatureFile.GetValueFromName("CreatureID", creatureCounter), out creatureID))
            {
                Creature tmpCreature = new Creature();
                tmpCreature.CreatureID = creatureID; //Convert.ToInt32(creatureFile.GetValueFromName("CreatureID", creatureCounter));
                tmpCreature.CreatureName = creatureFile.GetValueFromName("CreatureName", creatureCounter);
                tmpCreature.MovementRate = Convert.ToInt32(creatureFile.GetValueFromName("MovementRate", creatureCounter));
                tmpCreature.PreceptionRange = Convert.ToInt32(creatureFile.GetValueFromName("PreceptionRange", creatureCounter));
                tmpCreature.AgressionIndex = Convert.ToInt32(creatureFile.GetValueFromName("AgressionIndex", creatureCounter));
                tmpCreature.GrowthRate = Convert.ToInt32(creatureFile.GetValueFromName("GrowthRate", creatureCounter));
                tmpCreature.FoodValue = Convert.ToInt32(creatureFile.GetValueFromName("FoodValue", creatureCounter));

                creatureList.Add(tmpCreature);
                
                creatureCounter += 1;
            }
        }
    }
}
