// Dependencies sağ tık -> Add Project Reference
//or
// cmd -> cd .\ArrayConsoleApp\ -> dotnet add .\ArrayConsoleApp.csproj\ reference ..\Array\

var array = new Array.Array(); // sadece Array() yazdığımızda c# kendi Array'i ile karıştırıp hangisi olduğunu çözümleyemediği için kütüphane adıyla birlikte belirttik.

array.Add("Ahmet");    // 0   ->   4
array.Add("Mehmet");   // 1   ->   4
array.Add("Can");      // 2   ->   4
array.Add("Filiz");    // 3   ->   4
array.Add("Furkan");   // 4   ->   8

Console.WriteLine(array.Remove());  // instance member
Console.WriteLine(array.Remove());
