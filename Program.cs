Console.Clear();

string palavraSecreta;
string letra;

Console.WriteLine("--- Forca ---\n");

Console.Write("Qual a palavra secreta? ");
palavraSecreta = Console.ReadLine()!;

Console.Write("Qual a primeira letra? ");
letra = Console.ReadLine()!
    .Trim()
    .Substring(0, 1);

string letraExiste = palavraSecreta.Contains(letra) ? "Sim" : "Não";

Console.WriteLine($"\nA letra \"{letra}\" está na palavra secreta? {letraExiste}");