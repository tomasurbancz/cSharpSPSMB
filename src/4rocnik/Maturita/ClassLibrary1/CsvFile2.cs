namespace ClassLibrary1
{
    
    public interface IFile
    {
        void Save(IEnumerable<Movie> movies);
    
        IEnumerable<Movie> Load(); 
    }

    public class CsvFile2 : IFile
    { 
        public void Save(IEnumerable<Movie> movies)
        {
            List<String> lines = new List<string>();
            lines.Add("Film,Genre,Lead Studio,Audience score %,Profitability,Rotten Tomatoes %,Worldwide Gross,Year");
            foreach (var movie in movies)
            {
                lines.Add($"{movie.Film}, {movie.Genre}, {movie.LeadStudio}, {movie.AudienceScore}, {movie.Profibality}, {movie.RottenTomatoes}, {movie.WorldwideGross}, {movie.Year}");
            }
            File.WriteAllLines("movies.csv", lines);
        }

        public IEnumerable<Movie> Load()
        {
            List<string> lines = File.ReadAllLines("movies.csv").ToList();
            List<Movie> movies = new List<Movie>();
            lines.RemoveAt(0);
            foreach (string line in lines)
            {
                movies.Add(new Movie(line));
            }
            return movies;
        }
    }
}