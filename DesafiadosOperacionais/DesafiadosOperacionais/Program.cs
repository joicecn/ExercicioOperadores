
Console.WriteLine("Insira a nota final");
int notaFinal = int.Parse(Console.ReadLine());

if (notaFinal < 5)
    Console.WriteLine("Você foi reprovado");

else if (notaFinal > 6 || notaFinal < 7)
    Console.WriteLine("Você esta de recuperação");

else Console.WriteLine("Aluno aprovado");




