using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_199.Services
{
    interface IPaymentServices
    {
        public double InstallmentValue(double value, int installmentNumber);
    }
}
