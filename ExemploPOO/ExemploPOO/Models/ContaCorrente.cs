﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {

            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente!");
            }

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo disponível é {saldo}");
        }
            
        }
    }

