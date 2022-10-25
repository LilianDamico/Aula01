// SwitchCase Inicio
Console.Title = "SwitchCase";
int op;
Console.WriteLine("ESCOLHA ALGUMA DAS OPÇÕES ABAIXO:");
Console.WriteLine("1 - PRIMEIRA");
Console.WriteLine("2 - SEGUNDA");
Console.WriteLine("3 - TERCEIRA");
Console.WriteLine("4 - SAIR");
op = Convert.ToInt32(Console.ReadLine());
Console.Clear();
switch (op)
{
    case 1:
        Console.WriteLine("Opção 1");
        break;
    case 2:
        Console.WriteLine("Opção 2");
        break;
    case 3:
        Console.WriteLine("Opção 3");
        break;
    case 4:
        Console.WriteLine("Sair");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}
Console.ReadKey();

//Fim
