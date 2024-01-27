Band queen = new Band("Queen");

Album albumQueen = new Album("A night at the opera");

Music music1 = new Music(queen, "Love of my life")
{
    Duration = 213,
    Available = true,
};

Music music2 = new Music(queen, "Bohemian Rhapsody")
{
    Duration = 354,
    Available = true,
};

Episode ep1 = new(4, "Facilitation Techniques", 45);
ep1.AddGuests("Maria");
ep1.AddGuests("Marcelo");

Episode ep2 = new(2, "Learning techniques", 67);
ep2.AddGuests("Fernando");
ep2.AddGuests("Marcos");
ep2.AddGuests("Flavia");

Podcast podcast = new("Special podcast", "Daniel");
podcast.AddEpisodes(ep1);
podcast.AddEpisodes(ep2);
podcast.showDetails();

albumQueen.AddMusic(music1);
albumQueen.AddMusic(music2);

//albumQueen.showAlbumList();

queen.AddAlbum(albumQueen);
music1.ShowTechnicalList();
music2.ShowTechnicalList();
albumQueen.showAlbumList();
queen.showDiscography();