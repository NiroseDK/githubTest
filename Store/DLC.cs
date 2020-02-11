using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class DLC
    {
        Game game;
        
        string title;
        string description;
        int rating;
        string genre;
        double price;

        public DLC(Game d_Game, string d_Title, int d_Rating,  double d_Price)
        {
            game = d_Game;
            
            title = d_Title;
            rating = d_Rating;
            genre = d_Genre;
            price = d_Price;
        }
    }
}
