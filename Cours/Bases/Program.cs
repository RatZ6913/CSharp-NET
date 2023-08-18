Console.WriteLine("Bonjour ! Comment t'appeles-tu ?");
string? answer = Console.ReadLine();

Console.WriteLine("Bonjour " + answer + " !");

Console.WriteLine("Quelle est ton année de naissance ?");
answer = Console.ReadLine();

int dateBirth = int.Parse(answer);

int age = DateTime.Today.Year - dateBirth;

Console.WriteLine($"Tu vas avoir {age} ans en {DateTime.Today.Year}");