class Podcast
{
    private List<Episode> episodes = new();
    public string Name { get; }
    public string Host { get; }
    public int EpisodesTotal => episodes.Count;

    public Podcast(string name, string host)
    {
        this.Name = name;
        this.Host = host;
    }

    public void AddEpisodes(Episode episode)
    {
        episodes.Add(episode);
    }

    public void showDetails()
    {
        Console.WriteLine($"Podcast >|{this.Name}|< hosted by [{this.Host}]\n");
        foreach (Episode episode in episodes.OrderBy(e => e.Order))
        {
            Console.WriteLine(episode.Summary);
        }
        Console.WriteLine($"\n\nTotal episodes: {this.EpisodesTotal}.");
    }
}