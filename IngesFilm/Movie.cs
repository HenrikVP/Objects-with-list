namespace IngesFilm
{
    internal class Movie
    {
        public string Name { get; set; }
        public List<Actor> Actors { get; set; } = new();
    }
}
