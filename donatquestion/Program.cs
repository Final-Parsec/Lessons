using System;
using System.Collections.Generic;
using System.Linq;

namespace donatquestion
{
    public class komentarz
    {
        public string Nick { get; set; }
        public string Contents { get; set; }
        public string Rate { get; set; }

        public komentarz(string nick, string contents, string rate)
        {
            this.Nick = nick;
            this.Contents = contents;
            this.Rate = rate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<komentarz> comments = new List<komentarz>()
            {
                new komentarz("Alicja", "Movie", "5,2,1,3"),
                new komentarz("Cat", "Book", "1,5,5,3"),
                new komentarz("Shrek", "Movie", "10,2,1,2"),
            };

            foreach (var item in comments)
            {
                Console.WriteLine("{0}, {1}, {2}", item.Nick, item.Contents, item.Rate);
            }

            var queryAlicja = from komentarz in comments
                              where komentarz.Nick == ("Alicja")
                              select komentarz;

            Console.WriteLine(queryAlicja.FirstOrDefault().Nick);

        }
    }
}
