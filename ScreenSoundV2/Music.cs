class Music
{
    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public Genre Genre { get; set; }
    public string Description =>
        $"The song {this.Name} belongs to the band {this.Artist}";

    // constructor
    public Music(Band artist, string name)
    {
        this.Artist = artist;
        this.Name = name;
    }

    public void ShowTechnicalList()
    {
        Console.WriteLine($"Name: {this.Name}");
        Console.WriteLine($"Artist: {this.Artist.Name}");
        Console.WriteLine($"Duration: {this.Duration}");
        
        if (Available)
        {
            Console.WriteLine("Available on plan.");
        }
        else
        {
            Console.WriteLine("Purchase the Plus+ plan");
        }
    }

    public void ShowNameAndArtist()
    {
        Console.WriteLine($"Name/Artist: {this.Name} - {this.Artist}");
    }

}