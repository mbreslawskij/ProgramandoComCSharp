﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fintech.Dominio.Entidades
{
    public class Movimento
    {
        public Movimento(decimal valor, Operacao operacao)
        {
            Valor = valor;
            Operacao = operacao;
        }

        public int Id { get; set; }
        public Guid Guid { get; set; }
        public DateTime Data { get; set; } = DateTime.Now;
        public Operacao Operacao { get; set; }
        public decimal Valor { get; set; }
        public Conta conta { get; set; }
    }
}
