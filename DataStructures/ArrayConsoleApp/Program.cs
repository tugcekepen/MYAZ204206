// Dependencies sağ tık -> Add Project Reference
//or
// cmd -> cd .\ArrayConsoleApp\ -> dotnet add .\ArrayConsoleApp.csproj\ reference ..\Array\

var array = new Array.Array(); // sadece Array() yazdığımızda c# kendi Array'i ile karıştırıp hangisi olduğunu çözümleyemediği için kitaplık adıyla birlikte belirttik.

array.Add("Ahmet");
array.Add("Mehmet");

Console.WriteLine(array.Count);