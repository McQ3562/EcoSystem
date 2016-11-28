using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoSystem
{
    class World
    {
        HeardList heardList = new HeardList();

        public World()
        {
            INI_Manager iniRef = new INI_Manager();

        }

        public void Load()
        {
            //heardList.Load();
        }

        public void Tick()
        {

        }
    }
}
