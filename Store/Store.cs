using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Store
    {
        public Showcase showcase;

        public Store ()
        {
            showcase = new Showcase(5);
            Game g1 = new Game("Braid", 7, "Puzzle", 20);
            Game g2 = new Game("Warcraft", 4, "RTS", 40);
            Game g3 = new Game("Doom", 9, "Shooter", 60);

            DLC d1 = new DLC(g2, "value pack", 5, 10);
            g2.dlcs.Add(d1);

            // We need to add games to the showcase 
            showcase.AddGame(g1);
            showcase.AddGame(g2);
            showcase.AddGame(g3);
        }
    }
}
