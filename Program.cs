using System;
using System.Threading;

namespace CodigoParaTodxs_Bruno_Knaesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindx!\n");

            Console.WriteLine("Nós da empresa CréditoParaTodxs e estamos aqui para lhe auxiliar com crédito pessoal," +
                " independente por qual situação financeira você esteja passando atualmente!\n");
            Thread.Sleep(5000);
            int menu = 0;
            while (menu != 4)
            {
                Console.Clear();
                Console.WriteLine("O que você deseja fazer?  ");
                Console.WriteLine("=====================================");
                Console.WriteLine("1 - Conhecer um pouco mais da nossa empresa");
                Console.WriteLine("2 - Contratar algum serviço");
                Console.WriteLine("3 - Finalizar o programa");
                Console.WriteLine("=====================================");
                Console.Write("Digite uma opção: ");
                menu = Convert.ToInt32(Console.In.ReadLine());
                switch (menu)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine("Que legal que você escolheu essa opção!\n");
                        Console.WriteLine("Vamos começar nos apresentando e contando um pouquinho sobre nossa empresa\n");
                        Console.WriteLine("Somos uma empresa multinacional que ajuda milhões de pessoas a conseguirem o" +
                            " tão desejado crédito pessoal, já estamos no mercado a mais de 50 anos! Nós da CréditoParaTodxs" +
                            " preservamos nossos três principais pilares que são: a paixão pelo trabalho, o desejo de crescer" +
                            " diariamente e por ultimo mas não menos importante o respeito no trabalho!\n\n");
                        Console.WriteLine("pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Por enquanto estamos trabalhando apenas com a opção de emprestimo pessoal...\n");
                        Console.WriteLine("Deseja prosseguir com o emprestimo pessoal? ");
                        Console.Write("Digite sim ou nao: ");
                        string escolhausuario = Console.In.ReadLine();
                        if (escolhausuario == "sim")
                        {
                            Console.Clear();
                            Console.WriteLine("Que legal que escolheu essa opção, mas antes precisamos de algumas informações suas" +
                                " para realizar o emprestimo pessoal da melhor forma possivel\n");

                            Usuario usu = new Usuario();
                            Console.Write("Digite seu nome: ");
                            usu.Nome = Console.ReadLine();
                            Console.Write("Digite seu cpf: ");
                            usu.Cpf = Console.ReadLine();
                            Console.Write("Digite sua idade: ");
                            usu.Idade = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Digite sua renda mensal aproximadamente: ");
                            usu.RendaMensal = Convert.ToDouble(Console.In.ReadLine());
                            Console.Write("Digite seu saldo atual: ");
                            usu.SaldoBanco = Convert.ToDouble(Console.In.ReadLine());
                            Console.Write("Digite o valor desejado do empréstimo: ");
                            usu.ValorDesejadoEmp = Convert.ToDouble(Console.In.ReadLine());
                            if (usu.Idade < 18)
                            {
                                Console.Clear();
                                Console.WriteLine("Você não tem idade suficiente para realizar um empréstimo pessoal...\n");
                                Console.WriteLine("digite alguma tecla para continuar...");
                                Console.ReadKey();
                            }
                            if (usu.Idade >= 18)
                            {
                                if (usu.ValorDesejadoEmp > 30000)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Desculpa, mas infelizmente trabalhamos com no máximo 30 mil reais de empréstimo\n");
                                    Console.WriteLine("digite alguma tecla para continuar...");
                                    Console.ReadKey();
                                }
                                if (usu.ValorDesejadoEmp <= 30000)
                                {
                                    Console.Clear();
                                    Console.WriteLine("1 - 6 meses");
                                    Console.WriteLine("2 - 12 meses");
                                    Console.WriteLine("3 - 24 meses");
                                    Console.WriteLine("4 - 48 meses");                                   
                                    Console.Write("Dentro dessas opções em quantos meses você deseja pagar o empréstimo: ");
                                    int escolhausuario2 = Convert.ToInt32(Console.In.ReadLine());
                                    switch (escolhausuario2)
                                    {
                                        case 1:
                                            double valorparcelado;
                                            valorparcelado = usu.ValorDesejadoEmp / 6;
                                            double valorparcelado2;
                                            valorparcelado2 = valorparcelado * 2;
                                            Console.Clear();
                                            Console.WriteLine("A parcela mensal sera aproximadamente de: {0} ", valorparcelado2);
                                            Console.WriteLine();
                                            Console.WriteLine("=====================");
                                            Console.WriteLine("Deseja prosseguir?");
                                            Console.WriteLine("1 - SIM");
                                            Console.WriteLine("2 - NAO");
                                            Console.WriteLine("=====================");
                                            Console.Write("Digite a opção: ");
                                            int prosseguir = Convert.ToInt32(Console.In.ReadLine());
                                            if (prosseguir == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Obrigado por contratar nosso serviço..." +
                                                    " aqui estão suas novas informações!");
                                               
                                                usu.SaldoBanco = usu.SaldoBanco + usu.ValorDesejadoEmp;
                                                usu.MostraInformacoes();
                                                

                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            if (prosseguir == 2)
                                            {
                                                Console.WriteLine("Que pena... se for o caso realize outra tentativa de empréstimo\n");
                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            break;
                                        case 2:
                                            double vvalorparcelado;
                                            vvalorparcelado = usu.ValorDesejadoEmp / 12;
                                            double vvalorparcelado2;
                                            vvalorparcelado2 = vvalorparcelado * 2;
                                            Console.Clear();
                                            Console.WriteLine("A parcela mensal sera aproximadamente de: {0} ", vvalorparcelado2);
                                            Console.WriteLine();
                                            Console.WriteLine("=====================");
                                            Console.WriteLine("Deseja prosseguir?");
                                            Console.WriteLine("1 - SIM");
                                            Console.WriteLine("2 - NAO");
                                            Console.WriteLine("=====================");
                                            Console.Write("Digite a opção: ");
                                            int pprosseguir = Convert.ToInt32(Console.In.ReadLine());
                                            if (pprosseguir == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Obrigado por contratar nosso serviço..." +
                                                    " aqui estão suas novas informações!");

                                                usu.SaldoBanco = usu.SaldoBanco + usu.ValorDesejadoEmp;
                                                usu.MostraInformacoes();


                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            if (pprosseguir == 2)
                                            {
                                                Console.WriteLine("Que pena... se for o caso realize outra tentativa de empréstimo\n");
                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            break;

                                            
                                        case 3:
                                            double vvvalorparcelado;
                                            vvvalorparcelado = usu.ValorDesejadoEmp / 24;
                                            double vvvalorparcelado2;
                                            vvvalorparcelado2 = vvvalorparcelado * 2;
                                            Console.Clear();
                                            Console.WriteLine("A parcela mensal sera aproximadamente de: {0} ", vvvalorparcelado2);
                                            Console.WriteLine();
                                            Console.WriteLine("=====================");
                                            Console.WriteLine("Deseja prosseguir?");
                                            Console.WriteLine("1 - SIM");
                                            Console.WriteLine("2 - NAO");
                                            Console.WriteLine("=====================");
                                            Console.Write("Digite a opção: ");
                                            int ppprosseguir = Convert.ToInt32(Console.In.ReadLine());
                                            if (ppprosseguir == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Obrigado por contratar nosso serviço..." +
                                                    " aqui estão suas novas informações!");

                                                usu.SaldoBanco = usu.SaldoBanco + usu.ValorDesejadoEmp;
                                                usu.MostraInformacoes();


                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            if (ppprosseguir == 2)
                                            {
                                                Console.WriteLine("Que pena... se for o caso realize outra tentativa de empréstimo\n");
                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            break;

                                            
                                        case 4:
                                            double vvvvalorparcelado;
                                            vvvvalorparcelado = usu.ValorDesejadoEmp / 48;
                                            double vvvvalorparcelado2;
                                            vvvvalorparcelado2 = vvvvalorparcelado * 2;
                                            Console.Clear();
                                            Console.WriteLine("A parcela mensal sera aproximadamente de: {0} ", vvvvalorparcelado2);
                                            Console.WriteLine();
                                            Console.WriteLine("=====================");
                                            Console.WriteLine("Deseja prosseguir?");
                                            Console.WriteLine("1 - SIM");
                                            Console.WriteLine("2 - NAO");
                                            Console.WriteLine("=====================");
                                            Console.Write("Digite a opção: ");
                                            int pppprosseguir = Convert.ToInt32(Console.In.ReadLine());
                                            if (pppprosseguir == 1)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Obrigado por contratar nosso serviço..." +
                                                    " aqui estão suas novas informações!");

                                                usu.SaldoBanco = usu.SaldoBanco + usu.ValorDesejadoEmp;
                                                usu.MostraInformacoes();


                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            if (pppprosseguir == 2)
                                            {
                                                Console.WriteLine("Que pena... se for o caso realize outra tentativa de empréstimo\n");
                                                Console.WriteLine("digite qualquer tecla...");
                                                Console.ReadKey();
                                            }
                                            break;

                                            

                                        default:
                                            break;
                                    }
                                }
                            }
                            
                        }
                        if (escolhausuario == "nao")
                        {
                            Console.Clear();
                            Thread.Sleep(1500);
                            menu = 4;
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ah, que pena que você não tem interesse... desde já obrigado por utilizar nosso programa!" +
                            " finalizando em alguns segundos...");
                        Thread.Sleep(4500);
                        menu = 4;
                        break;

                    default:
                        break;
                }





            }
            










        }
        
    }
}
