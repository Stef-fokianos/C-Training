using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._7
{
    public class Database
    {
        private List<IMovie> movies;
        

        public void IntializeDB()
        {
            //Add movies to db 
            movies = new List<IMovie>
            {
                new Movie1(),
                new Movie2(),
                new Movie3(),
                new Movie4(),
                new Movie5(),
                new Movie6(),
                new Movie7(),
                new Movie8(),
                new Movie9(),
                new Movie10()
            };
        }

        public IEnumerable<IMovie> GetMovies()
        //Source of data for movies
        {
            return movies;
        }

    }

    public interface IMovie
    {
        string Title { get; set; }
        double Rating { get; set; }
    }

    public class Movie1 : IMovie
    {
        public string Title { get; set; } = "Last Exit: Rita Hayworth";
        public double Rating { get; set; } = 9.3;
    }
    public class Movie2 : IMovie
    {
        public string Title { get; set; } = "The Godfather";
        public double Rating { get; set; } = 9.2;
    }
    public class Movie3 : IMovie
    {
        public string Title { get; set; } = "The Dark Knight";
        public double Rating { get; set; } = 9.0;
    }
    public class Movie4 : IMovie
    {
        public string Title { get; set; } = "The Godfather, Part 2";
        public double Rating { get; set; } = 9.0;
    }
    public class Movie5 : IMovie
    {
        public string Title { get; set; } = "The 12 Jurors";
        public double Rating { get; set; } = 9.0;
    }
    public class Movie6 : IMovie
    {
        public string Title { get; set; } = "The Lord of the Rings: The Return of the King";
        public double Rating { get; set; } = 9.0;
    }
    public class Movie7 : IMovie
    {
        public string Title { get; set; } = "Schindler's List";
        public double Rating { get; set; } = 9.0;
    }
    public class Movie8 : IMovie
    {
        public string Title { get; set; } = "Pulp Fiction";
        public double Rating { get; set; } = 8.9;
    }
    public class Movie9 : IMovie
    {
        public string Title { get; set; } = "The Lord of the Rings: The Fellowship of the Ring";
        public double Rating { get; set; } = 8.9;
    }
    public class Movie10 : IMovie
    {
        public string Title { get; set; } = "The Good, the Bad and the Ugly";
        public double Rating { get; set; } = 8.8;
    }



}
