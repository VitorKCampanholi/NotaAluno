using ExercicioAluno;
using System;
using System.Globalization;

Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();
Console.WriteLine("Digite as três notas do aluno:");
Console.Write("Nota 1 : ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Nota 2 : ");
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Nota 3 : ");
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Aprovado())
{
    Console.WriteLine("APROVADO"); 
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "PONTOS");
}