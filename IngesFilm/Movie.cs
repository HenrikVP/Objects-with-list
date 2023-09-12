namespace IngesFilm
{
    internal class Movie
    {
        public string Name { get; set; }
        public List<Actor> Actors { get; set; } = new();

        public void ShowMovie()
        {
            Console.WriteLine("\n" + Name);
            Console.WriteLine("\nActors");
            foreach (var actor in Actors)
            {
                Console.WriteLine(actor.Name);
            }
        }
    }
}
