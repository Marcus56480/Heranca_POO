namespace Heranca
{
    public abstract class Funcionario
    {
        public string? Nome { get; set; }

        protected decimal Salario; /* Campo e Propriedade - Ambos são atributos 
        - Campo: É um Atributo com menos recursos, não possui controles como propriedade (getters e setter) -    
        - Propriedade: Atributo com mais controle 
        */
        public virtual void Trabalhar()
        {
            Console.WriteLine($"O Funcionário {Nome} está executando atividades");
        }

        public Funcionario()
        {
            
        }
        
        public Funcionario(string? nome, decimal salario) // Metodo Construtor é o que possui o mesmo nome da classe 
        {
            Nome = nome;
            Salario = salario;
        }

        public abstract decimal CalcularBonus();
    
    }
}