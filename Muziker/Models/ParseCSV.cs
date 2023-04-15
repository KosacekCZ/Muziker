namespace Muziker.Models;

public class ParseCSV
{
    public static List<Item> Parse()
    {
        List<Item> _temp = new List<Item>();
        foreach (string line in System.IO.File.ReadLines("/home/mikolasp/RiderProjects/MusicANALYTICS/MusicANALYTICS/bin/Debug/net7.0/csv/music.csv").Skip(1))
        {

            List<string> lines = line.Split(";").ToList();
            lines = lines.Select(s => s.Replace("\"", "").Trim()).ToList();

            _temp.Add(new Item(int.Parse(lines[0]), 
                int.Parse(lines[1]),
                int.Parse(lines[2]),
                lines[3],
                lines[4],
                lines[5],
                lines[6],
                lines[7],
                lines[8],
                lines[9],
                lines[10],
                lines[11]));
        }
        return _temp;
    }
}