using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        //propriedades = "prop"//
        public string numero { get; set; } //get--> leitura   set--> escrita da variável//

        public string titular { get; set; }

        public string bandeira { get; set; }

        //atributo privado//

    //token de login - acesso ao login e expira conforme o tempo//
    //private para não ter alteração//
        private string token = "sjdfidjiojsdfojdsoikjsld83249";

        //variável protegida, podendo manipular nos métodos//
        protected string cvv { get; set; }

    // void --- método sem retorno//
        public void AprovarCompra(){
            //numero = numero+4343423;//
            Console.WriteLine("Compra aprovada");
        
        }

        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        protected bool ValidarCompra(){
            return true;
        }
    }
}

