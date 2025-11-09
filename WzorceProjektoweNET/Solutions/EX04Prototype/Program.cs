using EX04Prototype;

Ork ork1 = new Ork("Gorg", 100, 50);

List<Ork> orksHorde = new List<Ork>();

for (int i = 1; i <= 5; i++)
{
    Ork orkClone = ork1.Clone();
    orkClone.Name = $"Gorg Clone {i}";
    orkClone.Strenght = Random.Shared.Next(40, 101);

    orksHorde.Add(orkClone);
}

Console.WriteLine("Horda sklonowanych Orków nadciąga!");
Console.WriteLine(new string('-', 40));

foreach (var ork in orksHorde)
{
    Console.WriteLine(ork);
}

Ork ork2 = new Ork("Borg", 140, 50);
List<Ork> moreSerializedOrks = new List<Ork>();
for (int i = 1; i <= 5; i++)
{
    string serializedOrk = Newtonsoft.Json.JsonConvert.SerializeObject(ork2);
    Ork orkClone = Newtonsoft.Json.JsonConvert.DeserializeObject<Ork>(serializedOrk);
    orkClone.Name = $"Gorg Serialized Clone {i}";
    orkClone.Strenght = Random.Shared.Next(40, 101);
    moreSerializedOrks.Add(orkClone);
}

Console.WriteLine("Kolejna horda sklonowanych Orków (serializacja) nadciąga!");
Console.WriteLine(new string('-', 40));
foreach (var ork in moreSerializedOrks)
{
    Console.WriteLine(ork);
}