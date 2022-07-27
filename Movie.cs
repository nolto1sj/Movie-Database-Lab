using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    public class Movie
    {
        public Movie(string argTitle, string argCategory)
        {
            Title = argTitle;
            Category = argCategory;
        }

        public Movie() { }

        public string Title { get; set; }
        public string Category { get; set; }

   }
}
