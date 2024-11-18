using berek2020;
using System.Text;

List<Berek> bereks = [];
using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);
sr.ReadLine();
while(!sr.EndOfStream) bereks.Add(new(sr.ReadLine()));

Console.WriteLine($"3. feldat: Dolgozók száma: {bereks.Count} fő");

var f4 = bereks.Average(b => b.Ber);
Console.WriteLine($"4. feldat: 2020-as átlagbérek: {f4:0.0}FT");

Console.Write("5. feladat: Kérem a részleg nevét:");
string reszleg = Console.ReadLine();

Console.WriteLine("6. feladat: A legtöbbet kereső dolgozó a részlegen:");
var reszlegendolgozok = bereks.FindAll(e => e.Reszleg == reszleg);

var max = reszlegendolgozok.MaxBy(e => e.Ber);
Console.WriteLine($"\tNév: {max.Nev} \n\tNem: {max.Neme} \n\tBelépés: {max.Belepes} \n\tBér: {max.Ber} FT");



Console.WriteLine("7. feldat: Statisztika");
var statisztika = bereks.GroupBy(b => b.Reszleg).OrderBy(b => b.Key);
foreach(var grp in statisztika) Console.WriteLine(
    $"\t{grp.Key} - "+ 
    $"{grp.Count()} fő" );
  

