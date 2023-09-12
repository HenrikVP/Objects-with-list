namespace IngesFilm
{
    internal class Actor
    {
        public string Name { get; set; }

        public void ShowActor(List<Movie> movies)
        {
            Console.WriteLine("\n" + Name);
            Console.WriteLine("\nMovies");
            foreach (var movie in movies)
            {
                foreach (var movieActor in movie.Actors)
                {
                    if (movieActor.Name == Name)
                        Console.WriteLine(movie.Name);
                }
            }
        }
    }
}
