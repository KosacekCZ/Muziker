namespace Muziker.Models;

public class Item
{
    public int songID {get; private set;} 
    public int year { get; private set; }
    public int position { get; private set; }
    public string artist { get; private set; }
    public string song { get; private set; }
    public string revenue { get; private set; }
    public string us { get; private set; }
    public string uk { get; private set; }
    public string de { get; private set; }
    public string fr { get; private set; }
    public string ca { get; private set; }
    public string au { get; private set; }
    public List<String> songs = new List<string>();

    public Item(int id, int y, int pos, string art, string song, string rev, string us, string uk, string de, string fr, string ca, string au)
    {
        songID = id;
        year = y;
        position = pos;
        artist = art;
        this.song = song;
        revenue = rev;
        this.us = us;
        this.uk = uk;
        this.de = de;
        this.fr = fr;
        this.ca = ca;
        this.au = au;

    }

    public override string ToString()
    {
        return $"{songID}, {song} by {artist}, {year}";
    }
}