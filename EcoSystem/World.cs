using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class World
    {
        CreatureList creatureList = new CreatureList();
        HeardList heardList = new HeardList();
        INI_Manager iniRef;

        public World()
        {
            iniRef = new INI_Manager();

        }

        public void Load()
        {
            creatureList.Load(iniRef.GetFile("Creature.ini"));
            //heardList.Load();
        }

        public void Tick()
        {

        }
    }
}
