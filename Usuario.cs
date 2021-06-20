using System;
using System.Collections.Generic;
using System.Text;

namespace CodigoParaTodxs_Bruno_Knaesel
{
    class Usuario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int Idade { get; set; }
        public double RendaMensal { get; set; }
        public double SaldoBanco { get; set; }
        public double ValorDesejadoEmp { get; set; }

        public virtual void MostraInformacoes()
        {
            Console.WriteLine("Nome: {0} ", Nome);
            Console.WriteLine("Cpf: {0} ", Cpf);
            Console.WriteLine("Idade: {0} ", Idade);
            Console.WriteLine("Renda mensal: {0} ", RendaMensal);
            Console.WriteLine("Saldo: {0} ", SaldoBanco);
            Console.WriteLine("Valor do emprestimo pego: {0} ", ValorDesejadoEmp);
        }



    }
}
