using MovieDatabaseLab;

bool loop = true;

List<Movie> movies = new List<Movie>
{
    new Movie ("Spider-Man: Into the Spiderverse", "Animated"),
    new Movie ("Jaws", "Horror"),
    new Movie ("Alien", "Sci-Fi"),
    new Movie ("Robocop", "Sci-Fi"),
    new Movie ("Nightcrawler", "Drama"),
    new Movie ("IT", "Horror"),
    new Movie ("Star Wars: A New Hope", "Sci-Fi"),
    new Movie ("Get Out", "Horror"),
    new Movie ("Arrival", "Sci-Fi"),
    new Movie ("Inside Out", "Animated")
};

while (loop)
{
    Console.WriteLine("Welcome to the Movie List Application!");
    Console.WriteLine();
    Console.WriteLine("There are 10 movies in this list.");
    Console.Write("What category are you interested in? ");

    string input = Console.ReadLine().ToLower();
    List<Movie> filteredList = new List<Movie>();
    Console.WriteLine();
    try
    {
        filteredList = movies.Where(x => x.Category.ToLower() == input).ToList();
        if (filteredList.Count == 0)
        {
            throw new Exception("Invalid category name. Please pick from Animated, Horror, Drama, and Sci-Fi");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    finally
    {
        List<string> orderedList = new List<string>();
        foreach (Movie movie in filteredList)
        {
            orderedList.Add(movie.Title); 
        }
        orderedList.Sort();
        foreach (string movie in orderedList)
        {
            Console.WriteLine(movie);
        }
        Console.Write("\nContinue? (y/n): ");
       
        bool yn = true;
        while (yn)
        {
            string moreMovie = Console.ReadLine().ToLower().Trim();
            if (moreMovie == "y")
            {
                Console.WriteLine();
                yn = false;
            }
            else if (moreMovie == "n")
            {
                Console.WriteLine("Goodbye!");
                Thread.Sleep(1000);
                loop = false;
                yn = false;
            }
            else
            {
                Console.Write("y or n please. ");
            }
        }
    }
    Console.Clear();
}




