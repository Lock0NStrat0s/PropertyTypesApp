using ConsoleUI;

PersonModel person = new PersonModel("Jabir");

person.FirstName = "Mohammad";
//person.LastName = "Jabir";
person.Age = 28;
person.SIN = "123-456-789";

Console.WriteLine(person.FullName);
Console.WriteLine(person.SIN);