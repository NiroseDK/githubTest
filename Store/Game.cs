using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Game
    {
        string title;
        string description;
        int rating;
        string[] genre;
        string systemReq; 
        double price;

        List<DLC> dlcs; 

        public Game(string g_Title, int g_Rating, string[] g_Genre, double g_Price)
        {
            title = g_Title;
            rating = g_Rating;
            genre = g_Genre;
            price = g_Price;
        }
    }
}
