using Heranca;                

Gerente gerente = new Gerente();

gerente.Nome = "Carlos";
gerente.Codigo = 123;

gerente.Trabalhar();
gerente.GerenciarEquipe();

Funcionario f = new Gerente(); //? Crie um objeto do tipo gerente e permita que a variavel f, declarada como funcionario referencie esse objeto
