using CA24112602;

Auto auto = new(
    rendszam: "AAA-001",
    gyarto: "McLaren",
    modell: "F1 GTR",
    teljesitmeny: 627,
    terfogat: 6064,
    fogyasztas: 15.2f);

auto.AddNewTulajdonos(
    new("Juhász Zoltán"),
    new(1995, 07, 11),
    new(2004, 10, 21));