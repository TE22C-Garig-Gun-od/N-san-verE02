

foreach (string leksak in leksaker)
{
    Console.WriteLine(leksaker);
}

string[] klasskamrater = { "Amira", "Theodora", "Leo", "Zion", "Vilma" };
List<string> leksaker = new List<string> { "Gosedjur", "Lego", "Docka", "Bilar", "Spiderman mini figure" };
List<int> numer = new List<int> { 2, 4, 6, 8, 10 };

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {numer[i]}");
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////


List<string> cities = new List<string>{};
string stad;

Console.WriteLine("Ange namn på städer, eller skriv exit för att avsluta");

while (true) {

    Console.WriteLine("Ange en stad: ");
    stad = Console.ReadLine();



    if (stad == "exit")
    {
        break;
    }
    cities.Add(stad);
    Console.WriteLine($"Staden {stad} har lagts in i listan");

    
}

 Console.WriteLine("Du har lagt till följande städer: ");
foreach (string city in cities) 
{
    Console.WriteLine(city);
}


Console.ReadLine();