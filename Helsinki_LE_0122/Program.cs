string[] input = File.ReadAllLines("helsinki.txt");
struct Helsinki
{
    public int helyezes;
    public int csapatszam;
    public string sportag;
    public string versenyszam;

    public Helsinki(string line, string line2)
    {
        string[] splitted = line.Split(' ');
        helyezes = int.Parse(splitted[0]);
        csapatszam = int.Parse(splitted[1]);
        sportag = line2;
        versenyszam = line2;
    }
}

