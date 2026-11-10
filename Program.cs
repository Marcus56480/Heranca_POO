using Heranca;                

Gerente gerente = new Gerente();


gerente.Nome = "Carlos";
gerente.Codigo = 123;

gerente.Trabalhar();
gerente.GerenciarEquipe();
gerente.ExibirSalario();

Funcionario f = new Gerente(); //? Crie um objeto do tipo gerente e permita que a variavel f, declarada como funcionario referencie esse objeto

Gerente gerente2 = new Gerente
{
    Nome = "Kessia"
};
gerente2.DefinirSalario(2000m);
gerente2.ExibirSalario();

IPagamento p1 = new PagamentoPix();
IPagamento p2 = new PagamentoCartao();

p1.Pagar(100m);
p2.Pagar(200m);