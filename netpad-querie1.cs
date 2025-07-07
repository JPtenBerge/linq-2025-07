var actors = new List<Actor>
{
    new Actor
    {
        Name = "Leonardo DiCaprio",
        Age = 50,
        Movies = new List<Movie>
        {
            new Movie { Title = "Inception", ReleaseYear = 2010 },
            new Movie { Title = "Titanic", ReleaseYear = 1997 },
        }
    },
    new Actor
    {
        Name = "Kate Winslet",
        Age = 48,
        Movies = new List<Movie>
        {
            new Movie { Title = "Titanic", ReleaseYear = 1997 },
            new Movie { Title = "The Holiday", ReleaseYear = 2006 },
            new Movie { Title = "Steve Jobs", ReleaseYear = 2015 }
        }
    },
    new Actor
    {
        Name = "Morgan Freeman",
        Age = 87,
        Movies = new List<Movie>
        {
            new Movie { Title = "The Shawshank Redemption", ReleaseYear = 1994 },
            new Movie { Title = "Bruce Almighty", ReleaseYear = 2003 },
            new Movie { Title = "Evan Almighty", ReleaseYear = 2005 },
            new Movie { Title = "Se7en", ReleaseYear = 1995 }
        }
    },
    new Actor
    {
        Name = "Scarlett Johansson",
        Age = 40,
        Movies = new List<Movie>
        {
            new Movie { Title = "The Avengers", ReleaseYear = 2012 },
            new Movie { Title = "Lucy", ReleaseYear = 2014 },
            new Movie { Title = "Marriage Story", ReleaseYear = 2019 }
        }
    },
    new Actor
    {
        Name = "Mobert Downey Jr.",
        Age = 59,
        Movies = new List<Movie>
        {
            new Movie { Title = "Iron Man", ReleaseYear = 2008 },
            new Movie { Title = "The Avengers", ReleaseYear = 2012 },
            new Movie { Title = "Sherlock Holmes", ReleaseYear = 2009 }
        }
    }
};

var movies = new List<Movie>
{
    new Movie
    {
        Title = "Inception",
        ReleaseYear = 2010,
        Actors = new List<Actor>
        {
            actors[0], // Leonardo DiCaprio
            actors[1]  // Kate Winslet
        }
    },
    new Movie
    {
        Title = "Titanic",
        ReleaseYear = 1997,
        Actors = new List<Actor>
        {
            actors[0], // Leonardo DiCaprio
            actors[1]  // Kate Winslet
        }
    },
    new Movie
    {
        Title = "The Shawshank Redemption",
        ReleaseYear = 1994,
        Actors = new List<Actor>
        {
            actors[2]  // Morgan Freeman
        }
    },
    new Movie
    {
        Title = "The Avengers",
        ReleaseYear = 2012,
        Actors = new List<Actor>
        {
            actors[3], // Scarlett Johansson
            actors[4]  // Robert Downey Jr.
        }
    },
    new Movie
    {
        Title = "Iron Man",
        ReleaseYear = 2010,
        Actors = new List<Actor>
        {
            actors[4]  // Robert Downey Jr.
        }
    }
};


// actors.Select(x => new
// {
//     Name = x.Name,
//     NrOfMovies = x.Movies.Count
// }).Dump();

// var firstLetter = "K";
// // var dingen = from a
// //              in actors
// //              where a.Name.StartsWith(firstLetter)
// //              select a;
// var dingen = actors.Where(x => x.Name.StartsWith(firstLetter));

// firstLetter = "M";

// dingen.Dump(); // foreach, .ForEach, .ToList(), .ToArray()




// var alles = from m
//             in movies
//             group m by m.ReleaseYear into grp
//             let nrOfMovies = grp.Count()
//             orderby nrOfMovies, grp.Key descending
//             select new { grp.Key, NrOfMovies = nrOfMovies };
// alles.Dump();


var alles = from actorMovie in actors.SelectMany(x => x.Movies)
            join movie in movies on actorMovie.Title equals movie.Title
            select new { actorMovie, movie };
alles.Dump();


class Actor
{
    public string Name { get; set; }
    public int Age { get; set; }

    public List<Movie> Movies { get; set; } = [];
}
class Movie
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }

    public List<Actor> Actors { get; set; } = [];
}

