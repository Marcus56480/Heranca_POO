namespace Heranca
{
    public class Gerente : Funcionario
    {
        public int Codigo { get; set; }

        public void GerenciarEquipe()
        {
            Console.WriteLine($"O gestor {Nome} de Codigo {Codigo} está gerenciando a equipe");
        }
    }
}