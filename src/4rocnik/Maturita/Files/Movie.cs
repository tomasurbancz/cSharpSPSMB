namespace Files
{
    public class Movie
    {
        public string Film { get; private set; }
        public string Genre;
        public string LeadStudio;
        public int AudienceScore;
        public float Profibality;
        public int RottenTomatoes;
        public float WorldwideGross;
        public int Year;

        public Movie(string line)
        {
            Film = line.Split(',')[0];
            Genre = line.Split(',')[1];
            LeadStudio = line.Split(',')[2];
            AudienceScore = int.Parse(line.Split(',')[3]);
            Profibality = float.Parse(line.Split(',')[4].Replace(".", ","));
            RottenTomatoes = int.Parse(line.Split(',')[5]);
            WorldwideGross = float.Parse(line.Split(',')[6].Replace("$", "").Replace(".", ","));
            Year = int.Parse(line.Split(',')[7]);
        }

        public override string ToString()
        {
            return $"Film: {Film}\nGenre: {Genre}\nLead Studio: {LeadStudio}\nAudience Score: {AudienceScore}\nProfitability: {Profibality}\n" +
                   $"Rotten Tomatoes: {RottenTomatoes}\nWorldwide Gross: {WorldwideGross}\nYear: {Year}";
        }
    }
}