using System.Text.Json;

namespace ClassLibrary1
{
    public class JsonFile2 : IFile
    {
        
        public void Save(IEnumerable<Movie> movies)
        {
            File.WriteAllText("movies.json", JsonSerializer.Serialize(movies));
        }

        public IEnumerable<Movie> Load()
        {
            var v = JsonSerializer.Deserialize<Movie>(File.ReadAllText("movies.json"));
            Console.WriteLine(v);
            return null;
        }
    }
}