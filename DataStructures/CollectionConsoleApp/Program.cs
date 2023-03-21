using System.Threading.Channels;

var g1 = new List<int>() { 10 ,20, 30 ,3};
var g2 = new List<int>() { 15, 25, 35, 10 ,3};
var g3 = new List<int>() { 10, 15, 20, 25, 40, 50 , 40, 50 ,3 };

// Tekrar etmeyecek şekilde tüm elemanlar

#region uzunyol
/*
var list = new List<int>();
list.AddRange(g1);
list.AddRange(g2);
list.AddRange(g3);
for (int i = 0; i < list.Count; i++)
{
    for (int j = i+1; j < list.Count; j++)
    {
        if (list[i].Equals(list[j]))
        {
            list.RemoveAt(j);
            j--;
        }
    }
}
foreach (var item in list)
{
    Console.WriteLine(item);
}*/
#endregion
//-----------kısa yol (küme)
g1
    .Union(g2)
    .Union(g3)          //bu yapıya "dot per line" denir.
    .ToList()
    .ForEach(x => Console.WriteLine(x));
Console.WriteLine("-----------------");

//Ortak elemanlar
g1
    .Intersect(g2)
    .Intersect(g3)
    .ToList()
    .ForEach(x => Console.WriteLine(x));
Console.WriteLine("-----------------");

//g1'de olup g2'de olmayanlar
g1
    .Except(g2)
    .ToList()
    .ForEach(x => Console.WriteLine(x));
