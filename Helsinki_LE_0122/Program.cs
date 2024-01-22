string[] input = File.ReadAllLines("helsinki.txt");

List<Helsinki> data = new List<Helsinki>();
for (int i = 0; i < input.Length; i = i + 2)
{
    data.Add(new Helsinki(input[i], input[i + 1]));
}

Console.WriteLine($"{data.Count * 2} pontszerző helyezést értek el a magyar olimpikonok.");

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

