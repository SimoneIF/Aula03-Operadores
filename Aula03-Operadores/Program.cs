using System;

namespace Aula03_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Exercicio 01 - Operador logico && and, || or
            //string usuario, senha;
            //Console.WriteLine("Digite seu usuario:");
            //usuario = Console.ReadLine();

            //Console.WriteLine("Digite sua senha");
            //senha = Console.ReadLine();

            //if (usuario == "admistrador" && senha == "123")
            //{
            //    Console.WriteLine("Acesso autorizado");
            //}
            //else
            //{
            //    Console.WriteLine("Usuario ou senha invalida\nAcesso negado!");
            //}

            //Exercicio 02 - || OR

            //double compra, valorfinal;
            //string cupom;

            //Console.WriteLine("Informe o valor de sua compra");
            //compra = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Informe seu cupom");
            //cupom = Console.ReadLine();

            //if (compra > 1000 || cupom == "desconto20")
            //{
            //    valorfinal = compra - (compra * 0.2);
            //}
            //else
            //{
            //    valorfinal = compra;
            //}

            //Console.WriteLine("Valor final da compra: R$" + valorfinal.ToString("0.00"));


            //Excercicio 03 - !=  not

            string tipousuario;

            Console.WriteLine("Informe seu tipo de usuario");
            tipousuario = Console.ReadLine();

            if (!(tipousuario == "admistrador"))  //esta negando a condicao 
            {
                Console.WriteLine("Atencao, usuário sem permissao de acesso, tarefas serão bloqueadas");
            }
            else
            {
                Console.WriteLine("Bem vindo!");
            }


















        }
    }
}
