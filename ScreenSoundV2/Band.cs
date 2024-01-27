class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; }

    public Band(string name)
    {
        this.Name = name;
    }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void showDiscography()
    {
        Console.WriteLine($"Discography's {this.Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.DurationTotal})");
        }
    }
}