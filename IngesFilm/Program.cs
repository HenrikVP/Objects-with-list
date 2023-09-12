namespace IngesFilm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
            Data data = new();
            ShowMovies(data);
            ShowActors(data);
        }

        private static void ShowActors(Data data)
        {
            Console.WriteLine("\n***Actors***");
            foreach (var actor in data.actors)
            {
                Console.WriteLine("\n" + actor.Name);
                Console.WriteLine("\nMovies");
                foreach (var movie in data.movies)
                {
                    foreach (var movieActor in movie.Actors)
                    {
                        if (movieActor.Name == actor.Name)
                            Console.WriteLine(movie.Name);
                    }
                }
            }
        }

        static void ShowMovies(Data data)
        {
            Console.WriteLine("\n***Movies***");
            foreach (var movie in data.movies)
            {
                Console.WriteLine("\n"+movie.Name);
                Console.WriteLine("\nActors");
                foreach (var actor in movie.Actors)
                {
                    Console.WriteLine(actor.Name);
                }
            }
        }
    }
}