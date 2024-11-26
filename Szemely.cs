using System.Diagnostics.CodeAnalysis;

namespace CA24112602;

internal class Szemely
{
    public Guid Guid { get; }
    public required string Nev { get; set; }

    public override string ToString() =>
        $"{Nev} (GUID: {Guid})";

    [SetsRequiredMembers]
    public Szemely(string nev)
    {
        Guid = Guid.NewGuid();
        Nev = nev;
    }
}
