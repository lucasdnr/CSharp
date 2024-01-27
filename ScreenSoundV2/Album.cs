class Album
{
    private List<Music> musics = new List<Music>();

    public string Name { get; }

    public int DurationTotal => musics.Sum(m => m.Duration);

    public Album(string nane)
    {
        this.Name = nane;
    }

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }

    public void showAlbumList()
    {
        Console.WriteLine($"Music List of album {this.Name}:\n");
        foreach (var music in this.musics)
        {
            Console.WriteLine($"Music: {music.Name}");
        }
        Console.WriteLine($"\nTo listen to this entire album you need {this.DurationTotal} seconds");
    }
}