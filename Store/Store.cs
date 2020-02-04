using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Store
    {
        Showcase showcase;

        public Store ()
        {
            showcase = new Showcase(5);
            Game g1 = new Game("Raid", 7, "Shooter", 60);
            // We need to add games to the showcase 
        }

        // Buying
        // Seeing what's for sale
    }
}
