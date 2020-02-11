using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Game
    {
        public string name;
        public string description;
        public int rating;
        public string genre;
        public string systemReq;
        public double price;

        public List<DLC> dlcs; 

        public Game(string g_name, int g_Rating, string g_Genre, double g_Price)
        {
            name = g_name;
            rating = g_Rating;
            genre = g_Genre;
            price = g_Price;
        }
    }
}
