using System;
using System.Collections.Generic;
using System.Text;

namespace DataTest_MS
{

    public class Movie
    {
        public string title { get; set; }
        public string releaseYear { get; set; }
    }

    public class RootObject
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<Movie> movies { get; set; }
    }
}
