using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_146.Entities.Exceptions;

namespace Exercicio_146.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (Balance == 0)
            {
                throw new DomainException("Saldo deve ser positivo!");
            }
            if ( amount > WithdrawLimit)
            {
                throw new DomainException("Saque deve ser menor que o limite de saques!");
            }

            Balance -= amount;
        }
    }
}
