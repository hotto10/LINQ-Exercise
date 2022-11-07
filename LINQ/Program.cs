namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var movies = new List<string>() { "Black Panther", "Iron Man", "Hulk", "Dr Strange", "Spider Man" };

            movies.OrderBy(x => x.Length).ToList().ForEach(Console.WriteLine); 
        }

        
    }
}
