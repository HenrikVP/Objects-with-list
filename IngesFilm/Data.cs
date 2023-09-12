namespace IngesFilm
{
    internal class Data
    {
        public List<Actor> actors;
        public List<Movie> movies = new();

        public Data() { AddData(); }

        void AddData()
        {
            Actor actor1 = new Actor() { Name = "Harrison Ford"};
            Actor actor2 = new Actor() { Name = "Nicolas Cage"};
            Actor actor3 = new Actor() { Name = "Ryan Gosling"};
            Actor actor4 = new Actor() { Name = "Some 80' action hero"};
            Actor actor5 = new Actor() { Name = "Pedro Pascal"};

            actors = new() { actor1, actor2, actor3 , actor4, actor5 };

            Movie movie1 = new Movie() { Name = "Balde Runner 2049" };
            Movie movie2 = new Movie() { Name = "The Unbearable Weight of Massive Talent" };
            Movie movie3 = new Movie() { Name = "The Expendables" };

            movie1.Actors.Add(actor1);
            movie1.Actors.Add(actor3);
            movie2.Actors.Add(actor2);
            movie2.Actors.Add(actor5);
            movie3.Actors.Add(actor1);
            movie3.Actors.Add(actor4);

            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
        }

    }
}
