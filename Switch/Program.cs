List<string> nombres2 = new List<string>();
nombres2.Add("Fernando");
nombres2.Add("Ignacio");
nombres2.Add("Brenda");
nombres2.Add("Khai");

switch (nombres2[0])
{
    case "Fernando":
        Console.WriteLine("El nombre es Fernando.");
        break;
    case "Ignacio":
        Console.WriteLine("El nombre es Ignacio.");
        break;
    case "Brenda":
        Console.WriteLine("El nombre es Brenda.");
        break;
    case "Khai":
        Console.WriteLine("El nombre es Khai.");
        break;
    default:
        Console.WriteLine("El nombre no fue nombrado.");
        break;
}
