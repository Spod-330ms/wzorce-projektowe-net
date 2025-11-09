using EX03Builder;

List<AWojownik> soldiers = new List<AWojownik>() {
    Garnizon.CreateSoldier(TypWojownika.Piechur, "Janek"),
    Garnizon.CreateSoldier(TypWojownika.Piechur, "Franek"),
    Garnizon.CreateSoldier(TypWojownika.Konny, "Maniek"),
    Garnizon.CreateSoldier(TypWojownika.Konny, "Heniek"),
    Garnizon.CreateSoldier(TypWojownika.Strzelec, "Darek"),
    Garnizon.CreateSoldier(TypWojownika.Strzelec, "Marek")
};

foreach (var soldier in soldiers)
{
    Console.WriteLine(soldier);
    Console.WriteLine(new string('-', 40));
}