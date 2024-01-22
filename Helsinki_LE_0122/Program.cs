string[] input = File.ReadAllLines("helsinki.txt");

List<Helsinki> data = new List<Helsinki>();
for (int i = 0; i < input.Length; i = i + 2)
{
    data.Add(new Helsinki(input[i], input[i + 1]));
}

Console.WriteLine($"{data.Count * 2} pontszerző helyezést értek el a magyar olimpikonok.");

int x = 0;
int y = 0;
int z = 0;
for (int i = 0;i < data.Count; i++)
{
    if (data[i].helyezes = 1)
    {
        x += 1;
    }
    else if (data[i].helyezes = 2)
    {
        y += 1;
    }
    else if (data[i].helyezes = 3)
    {
        z += 1;
    }
}

int pontoklacikam = 0;
for (int i = 0;i < data.Count; i++)
{
    if (data[i].helyezes = 1)
    {
        pontoklacikam += 7;
    }
    else if (data[i].helyezes = 2)
    {
        pontoklacikam += 5;
    }
    else if (data[i].helyezes = 3)
    {
        pontoklacikam += 4;
    }
    else if (data[i].helyezes = 4)
    {
        pontoklacikam += 3;
    }
    else if (data[i].helyezes = 5)
    {
        pontoklacikam += 2;
    }
    else if (data[i].helyezes = 6)
    {
        pontoklacikam += 1;
    }
}

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

