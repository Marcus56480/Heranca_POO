using Heranca;                

Gerente gerente = new Gerente();
Gerente gerente2 = new Gerente
{
    Nome = "Kessia",
    Salario = 30000m
};

gerente.Nome = "Carlos";
gerente.Codigo = 123;

gerente.Trabalhar();
gerente.GerenciarEquipe();
gerente.ExibirSalario();

Funcionario f = new Gerente(); //? Crie um objeto do tipo gerente e permita que a variavel f, declarada como funcionario referencie esse objeto
