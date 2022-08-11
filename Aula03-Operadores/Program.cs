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

            //string tipousuario;

            //Console.WriteLine("Informe seu tipo de usuario");
            //tipousuario = Console.ReadLine();

            //if (!(tipousuario == "admistrador"))  //esta negando a condicao, forma mais usada
            //{
            //    Console.WriteLine("Atencao, usuário sem permissao de acesso, tarefas serão bloqueadas");
            //}
            //else
            //{
            //    Console.WriteLine("Bem vindo!");
            //}



            //Exercicio 04 - switch

            //int codigo;
            //string mensagem;

            //Console.WriteLine("Digite um código");
            //codigo = Convert.ToInt32(Console.ReadLine());

            //switch (codigo) //pode usar com variavel inteira ou caracteres, nao usa p string
            //{
            //    case 1:
            //        { //mais q uma linha tem q colocar chaves
            //            mensagem = "Você escollheu a opção ELOGIO PROFFISIONAL";
            //        }
            //        break; //pode ou nao estar dentro das chaves
            //    case 2:
            //        mensagem = "Você escollheu a opção ELOGIO FISICO";
            //        break;
            //    case 3:
            //        mensagem = "Você escollheu a opção ELOGIO PESSOAL";
            //        break;
            //    default:
            //        mensagem = "Opção inválida";
            //        break;
            //}
            //Console.WriteLine(mensagem);

            ////exemplo com IF
            //if (codigo == 1)
            //    mensagem = "Você escollheu a opção ELOGIO PROFFISIONAL";
            //else if (codigo == 2)
            //    mensagem = "Você escollheu a opção ELOGIO FISICO";
            //else if (codigo == 3)
            //    mensagem = "Você escollheu a opção ELOGIO PESSOAL";
            //else if (codigo == 4)
            //    mensagem = "Você escollheu a opção ELOGIO PESSOAL";
            //else
            //    mensagem = "Opção inválida";

            //Console.WriteLine(mensagem);


            //Excercicio 05 - Hands On
            //equilatero = 3 lados iguais
            //isoceles = 2 lados iguais
            //escaleno = 3 lados diferentes

            //int x, y, z;

            //Console.WriteLine("Digite o lado A do triangulo");
            //x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o lado B do triangulo");
            //y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Digite o lado c do triangulo");
            //z = Convert.ToInt32(Console.ReadLine());

            //if ((x + y > z) && (x + z > y) && (y + z > x))  //verifica a soma dos lados
            //{ //eh um triangulo
            //    if (x == z && x == y)
            //        Console.WriteLine("Tringulo Equilátero");
            //    else if (x != y && x != z && y != z)
            //        Console.WriteLine("Tringulo Escaleno");
            //    else
            //        Console.WriteLine("Tringulo Isoceles");
            //}
            //else //nao eh um triangulo
            //{
            //    Console.WriteLine("Esses valores não formam um triangulo");
            //}

            //Exercicio 06
            //int numero;

            //Console.WriteLine("Digite o numero do mes");
            //numero = Convert.ToInt32(Console.ReadLine());

            //switch (numero)
            //{
            //    case 1:
            //        Console.WriteLine("Janeiro");
            //        break;
            //    case 2:
            //        Console.WriteLine("Janeiro");
            //        break;
            //    case 3:
            //        Console.WriteLine("Março");
            //        break;
            //    case 4:
            //        Console.WriteLine("Abril");
            //        break;
            //    case 5:
            //        Console.WriteLine("Maio");
            //        break;
            //    case 6:
            //        Console.WriteLine("Junho");
            //        break;
            //    case 7:
            //        Console.WriteLine("Julho");
            //        break;
            //    case 8:
            //        Console.WriteLine("Agosto");
            //        break;
            //    case 9:
            //        Console.WriteLine("Setembro");
            //        break;
            //    case 10:
            //        Console.WriteLine("Outubro");
            //        break;
            //    case 11:
            //        Console.WriteLine("Novembro");
            //        break;
            //    case 12:
            //        Console.WriteLine("Dezembro");
            //        break;
            //    default:
            //        Console.WriteLine("Mes invalido");
            //        break;
            //   }

            //Exercicio 07

            double valor, saldo = 100;
            int codigo;

            Console.WriteLine("Menu: \nInforme o codigo da transacao:\n1-Deposito.\n2-Saque.\n3-Ver Saldo.");
            codigo = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {
                case 1:  //deposito
                    {
                        Console.WriteLine("Digite o valor do deposito");
                        valor = Convert.ToDouble(Console.ReadLine());
                        saldo += valor;
                        Console.WriteLine("Saldo atualizado: R${0}", saldo.ToString("0.00"));
                    } 
                    break;
                case 2: //Saque
                    {
                        Console.WriteLine("Digite o valor a fazer o saque");
                        valor = Convert.ToDouble(Console.ReadLine());
                        if (saldo >= valor)
                            saldo -= valor;
                        else
                            Console.WriteLine("Saldo insuficiente para saque");
                        Console.WriteLine("Saldo atualizado: R${0}", saldo.ToString("0.00"));
                    }
                    break;
                case 3: //ver saldo
                    {
                        Console.WriteLine("Saldo atualizado: R${0}", saldo.ToString("0.00"));
                    }
                    break ;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }









        }
    }
}
