using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApplication2.cards
{
    public class getCards
    {
        static string json = File.ReadAllText("../debug/json/AllCards.json");
        static dynamic cards = JsonConvert.DeserializeObject(json);

        public static IEnumerable<dynamic> returnCards()
        {
            return cards;
        }

        public static string[] colors()
        {
            return new string[] { "Red", "White", "Blue", "Green", "Black", "Colourless" };
        }

    }
}
