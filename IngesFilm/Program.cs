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
                actor.ShowActor(data.movies);
            }
        }

        static void ShowMovies(Data data)
        {
            Console.WriteLine("\n***Movies***");
            foreach (var movie in data.movies)
            {
                movie.ShowMovie();
            }
        }
    }
}