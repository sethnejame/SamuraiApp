using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiApp.Domain
{
    public class SamuraiBattle
    {
        // SamuraiId is a foreign key pointing back to the Samurai Class
        public int SamuraiId { get; set; }

        //BattleId is a foreign key pointing back to the Battle Class
        public int BattleId { get; set; }
        public Samurai Samurai { get; set; }
        public Battle Battle { get; set; }
    }
}
