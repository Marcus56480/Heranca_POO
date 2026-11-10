namespace Heranca
{
    public interface IPagamento // Uma interface define um contrato que estabelece quais metodos, propriedades ou outros membros uma classe deve disponibilizar 
    {
         void Pagar(decimal valor);
        // void Receber(decimal valor); - Interfaces podem conter diversos metodos 
    }
}