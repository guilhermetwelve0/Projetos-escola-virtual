using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Departamento humanas = new Departamento();
            humanas.Nome = "Departamento de Humanas";

            Departamento exatas = new Departamento();
            exatas.Nome = "Departamento de Exatas";

            Aluno joazinho = new Aluno();
            joazinho.setNome("Joao da Silva");
            joazinho.setIdade(12);
            joazinho.Matricula = 13;
            joazinho.Presente = false;
            joazinho.imprimir();
            

            Aluno ritinha = new Aluno();
            ritinha.setNome("Rita de Souza");
            ritinha.setIdade(11);
            ritinha.Matricula = 89;
            ritinha.Presente = true;

            ritinha.imprimir();

            Professor jose = new Professor();
            jose.setNome("José de Oliveira");
            jose.setIdade(35);
            jose.ValorHora = 30;
            jose.Tipo = 1;
            jose.Bonus = 0;
            Console.WriteLine("Salario: {0:c}", jose.CalcularSalario(120));
            jose.imprimir();
            jose.addAluno(joazinho);
            jose.addAluno(ritinha);
            jose.ImprimirAlunos();
            jose.setDepartamento = exatas;

            Professor maria = new Professor();
            maria.setNome("Maria Teixeira");
            maria.setIdade(48);
            maria.ValorHora = 30;
            maria.Tipo = 2;
            maria.Bonus = 15;
            Console.WriteLine("Salario: {0:c}", maria.CalcularSalarioFinal(120));
            maria.imprimir();
            maria.addAluno(ritinha);
            maria.ImprimirAlunos();
            maria.setDepartamento = humanas; 

            joazinho.addProfessor(jose);

            humanas.addProfessor(maria);
            exatas.addProfessor(jose);

            Console.WriteLine("Hello World!");
            Console.ReadLine();


        }
    }
}
