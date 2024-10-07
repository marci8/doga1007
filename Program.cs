using doga1007;
using System.Text;

List<Triatlon> events = [];

using StreamReader sr = new(
    path: @"..\..\..\src\forras.txt",
    encoding: Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) events.Add(new(sr.ReadLine()));

Console.WriteLine($"{events.Count} darab versenyző fejezte be a versenyt");

var tCnt = events.Count(e => e.Kategoria == "25-29");
Console.WriteLine($"A 25-29 - es kategóriába tartozó versenyzők száma: {tCnt} darab");

