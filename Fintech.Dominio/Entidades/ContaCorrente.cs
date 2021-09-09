﻿namespace Fintech.Dominio.Entidades
{
    class ContaCorrente
    {
        public int Id { get; set; }
        public Agencia Agencia { get; set; }
        public int Numero { get; set; }
        public int DigitoVerificador { get; set; }
        public decimal Saldo { get; set; }
        public Cliente Cliente { get; set; }

        public void EfetuarOperacao(decimal valor, Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Deposito:
                    Saldo += valor;
                    break;
                case Operacao.Saque:
                    Saldo -= valor;
                    break;
                default:
                    break;
            }
        }
    }
}