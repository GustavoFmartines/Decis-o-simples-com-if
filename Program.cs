Console.Clear();

    Decimal p1, p2, media;

Console.Write("Nota da P1: ");
    p1 = Convert.ToDecimal(Console.ReadLine());

Console.Write("Nota da P2:");
    p2 = Convert.ToDecimal(Console.ReadLine());

        media = p1 + p2 / 2;

Console.WriteLine($"A média do aluno é: {media}");

if (media >= 5)
    Console.WriteLine("Aprovado!!!");

else
{
    Console.WriteLine("Reprovado! :(");
};
