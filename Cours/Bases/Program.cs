Console.WriteLine("Quelle est ton année de naissance ?");
string? rep = Console.ReadLine();

int annéeNais = int.Parse(rep);
const int annéeMin = 1900;

if (annéeNais >= annéeMin && annéeNais <= DateTime.Today.Year)
{
    int age = DateTime.Today.Year - annéeNais;
    Console.WriteLine($"Tu as ou vas avoir {age} ans en {DateTime.Today.Year}.");

    string tranche = string.Empty;
    if (age < 25)
        tranche = "moins de 25 ans";
    else if (age >= 25 && age < 40)
        tranche = "25 - 40 ans";
    else if (age >= 40 && age < 55)
        tranche = "40 - 55 ans";
    else
        tranche = "plus de 55 ans";

    Console.WriteLine($"Ta tranche d'âge est : {tranche}");
}
else
{
    Console.WriteLine($"Ton année de naissance doit être comprise entre {annéeMin} et {DateTime.Today.Year}");
}

Console.WriteLine("As-tu un code de réduction (O/N) ?");
rep = Console.ReadLine();

bool reduc = (rep == "O");

Console.WriteLine(annéeNais < 2000 ? "Tu es né au 20 ème siècle" : "Tu es née au 21 ème siècle");

Console.WriteLine("Quel âge as-tu ?");
string? answer = Console.ReadLine();

if (int.TryParse(answer, out int age)) // Convertir la réponse en entier
{
    string result = string.Empty;

    switch (age)
    {
        case int a when a < 6:
            result = "bébé";
            break;
        case int a when a < 12:
            result = "gamin";
            break;
        case int a when a < 18:
            result = "adolescent";
            break;
        default:
            result = "adulte";
            break;
    }

    Console.WriteLine($"Tu fais partie de la catégorie : {result}");
}
