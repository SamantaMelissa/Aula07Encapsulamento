namespace Aula07Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas { get; set; }

        public void ComprarComDescontoMastercard(float desconto) {
                //ultilizando encapsulamento com assinatura protected//
            cvv = "434";
            System.Console.WriteLine($"Compra realizada com {parcelas} parcelas e R${desconto} de desconto.");
        }
    }
}