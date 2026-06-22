// List<string> names = ["<name>", "Ana", "Felipe"];
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }

List<string> names = ["rohan", "rohit", "rajan"];
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name} ");
// }
Console.WriteLine();
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
// foreach (var name in names)
// {
//     Console.WriteLine($"Hello {name.ToUpper()}!");
// }
// Console.WriteLine($"The list has {names.Count} people in it");
// var index = names.IndexOf("rohan");
// if (index == -1)
// {
//     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
// }
// else
// {
//     Console.WriteLine($"The name {names[index]} is at index {index}");
// }

// index = names.IndexOf("Not Found");
// if (index == -1)
// {
//     Console.WriteLine($"When an item is not found, IndexOf returns {index}");
// }
// else
// {
//     Console.WriteLine($"The name {names[index]} is at index {index}");
// }
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}