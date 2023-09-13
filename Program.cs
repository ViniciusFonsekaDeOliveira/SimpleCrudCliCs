Console.WriteLine("Hello, World!");

string firstname = "Vinícius";
string lastname = "Oliveira";
string nickname = "vini";
string email = "vini@vini.com";

Person p = new(firstname, lastname, nickname, email);

Console.WriteLine(p.ToDict());

Dictionary<string, string> personDict = p.ToDict();

Console.WriteLine(personDict.Keys);

foreach (string key in personDict.Keys)
    Console.WriteLine($"{key}: {personDict[key]}");