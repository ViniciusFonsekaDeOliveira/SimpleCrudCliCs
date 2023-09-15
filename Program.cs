Console.WriteLine("Hello, World!");

string firstname = "Vinícius";
string lastname = "Oliveira";
string nickname = "vini";
string email = "vini@vini.com";

Person person = new(firstname, lastname, nickname, email);

Console.WriteLine(p.ToDict());

Dictionary<string, string> personDict = p.ToDict();

Console.WriteLine(personDict.Keys);

foreach (string key in personDict.Keys)
    Console.WriteLine($"{key}: {personDict[key]}");

//params

//ArrayList - não é fortemente tipada.
//Add, Insert(index, elem), AddRange - ArrayList()
//RemoveAt, Remove, RemoveRange - ArrayList()
// Contains(elem) - ArrayList()
// arrayList.Sort() -- quick sort.
// Array.Sort(array)
// ArrayList não oferece o melhor desempenho, recomenda-se utilizar sempre List!

/*

List<T>

é fortemente tipada.

Add(), AddRange(), Insert(), InsertRange()
Remove(), RemoveAt(), RemoveRange(),
Contains(), 
Count
Sort(), Clear()

Find(), FindLast(), FindIndex(), FindLastIndex(), FindAll()

Predicado: é uma função, mas pode ser representado também pela expressão lambda: x => x * x

Box e unboxing atrapalham o desempenho.

Avaliar uso de IEnumerable(lazy evaluation + performance em nível de memória) e List.

Métodos de extensão

Any(), OrderBy(), 

 */

List<Person> list = new();
list.Add(person);

List<string> frutas = new() { "Banana", "Maça", "Laranja" };

frutas.Find(fruta => fruta.Contains("B"));
