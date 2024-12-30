using ExemploPOO.Models;
using System;

//Polimorfismo

Aluno a1 = new Aluno();
a1.Nome = "Victor Vernizzi";
a1.Idade = 15;
a1.Email = "teste@teste.com";
a1.Nota = 10;
a1.Apresentar();




Professor p1 = new Professor();
p1.Nome = "Eduardo Vernizzi";
p1.Idade = 25;
p1.Salario = 5000;
p1.Apresentar();


//Herança
//Aluno a1 = new Aluno();
//a1.Nome = "Eduardo";
//a1.Idade = 25;
//a1.Nota = 10;
//a1.Email = "teste@teste.com";
//a1.Apresentar();








//Encapsulamento
//ContaCorrente c1 = new ContaCorrente(123, 1000);

//c1.ExibirSaldo();
//c1.Sacar(500);
//c1.ExibirSaldo();



//Pessoa p1 = new Pessoa();
//p1.Nome = "Carlos Eduardo";
//p1.Idade = 25;
//p1.Apresentar();