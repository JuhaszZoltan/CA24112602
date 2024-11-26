namespace CA24112602;

internal class Auto
{
    private List<(Szemely Szemely, DateTime Kezdet, DateTime Vege)>
        tulajdonosok = [];
    public string Rendszam { get; set; }
    public string Gyarto { get; set; }
    public string Modell { get; set; }
    public int Teljesitmeny { get; set; }
    public int Terfogat { get; set; }
    public float Fogyasztas { get; set; }

    public string GetTulajdonosok()
    {
        string res = string.Empty;
        foreach (var t in tulajdonosok)
        {
            res += $"{t.Szemely}:\n" +
                $"\t{t.Kezdet:yy-MM-dd}-{t.Vege:yy-MM-dd}\n";
        }
        return res;
    }

    public void AddNewTulajdonos(Szemely szemely, DateTime kezd, DateTime veg)
    {
        tulajdonosok.Add((szemely, kezd, veg));
    }

    public override string ToString() =>
        $"[{Rendszam}] {Gyarto} {Modell} " +
        $"({Teljesitmeny}hp, {Terfogat}cc, {Fogyasztas}mpg)";

    public Auto(string rendszam, string gyarto, string modell,
        int teljesitmeny, int terfogat, float fogyasztas)
    {
        Rendszam = rendszam;
        Gyarto = gyarto;
        Modell = modell;
        Teljesitmeny = teljesitmeny;
        Terfogat = terfogat;
        Fogyasztas = fogyasztas;
    }
}
