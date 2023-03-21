// Dependencies sağ tık -> Add Project Reference
//or
// cmd -> cd .\ArrayConsoleApp\ -> dotnet add .\ArrayConsoleApp.csproj\ reference ..\Array\

// Immutable - Değişmez!

#region week_02
//overloading
var names1 = new Array.Array("Ahmet", "Mehmet", "Büşra", "Can", "Burcu");

var names2 = new Array.Array();
names2.Add("Ahmet");
names2.Add("Mehmet");
names2.Add("Büşra");
names2.Add("Can");
names2.Add("Burcu");

Console.WriteLine(names1.Count);         // 0 
Console.WriteLine(names1.Capasity);      // 5

Console.WriteLine(names2.Count);        // 5
Console.WriteLine(names2.Capasity);     // 8
#endregion
#region week_01
/*
var array = new Array.Array(); // sadece Array() yazdığımızda c# kendi Array'i ile karıştırıp hangisi olduğunu çözümleyemediği için kütüphane adıyla birlikte belirttik.
// -  Bir sınıftan new'leme yapıyorsak ürettiğimiz şeye(burada "array") INSTANCE denir. !!!
// -  instance üzerinden ulaştığımız bütün elemanlara ise INSTANCE MEMBER denir. !!! 

// -  direkt Array.Array. ...  üzerinden yani sınıf üzerinden ulaştıklarımıza ise CLASS MEMBER denir. !!!

array.Add("Ahmet");    // 0   ->   4       //instance member : "Ahmet"
array.Add("Mehmet");   // 1   ->   4       //instance member : "Mehmet"
array.Add("Can");      // 2   ->   4       //instance member : "Can"
array.Add("Filiz");    // 3   ->   4       //instance member : "Filiz"
array.Add("Furkan");   // 4   ->   8       //instance member : "Furkan"

Console.WriteLine(array.Remove());  // Remove() metodu -> instance member'dır
Console.WriteLine(array.Remove());
*/
#endregion