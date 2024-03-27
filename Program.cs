Console.WriteLine("Soletrar");

Console.Write("escreva aqui seu texto: ");
string carro;
carro=Console.ReadLine()!;
for (int i = 0; i < carro.Length; i++)
{
    Console.Write(carro[i]);
    if (i < carro.Length-1)
    {
        Console.Write("-");
    }
}
Console.WriteLine();