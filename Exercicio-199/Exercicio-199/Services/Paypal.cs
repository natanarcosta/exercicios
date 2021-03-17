using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_199.Services;
using Exercicio_199.Entities;
using System.Globalization;

namespace Exercicio_199.Services
{
    class Paypal : IPaymentServices
    {
        public double InstallmentValue(double value, int installmentNumber)
        {
            double temp =  (value += (value * 0.01 * installmentNumber));
            return temp += temp * 0.02;
        }
    }
}
