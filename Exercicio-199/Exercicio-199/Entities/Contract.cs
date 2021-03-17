using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_199.Services;

namespace Exercicio_199.Entities
{
    class Contract
    {
        public int ContractNumber { get; set; }
        public  DateTime ContractDate { get; set; }
        public double ContractValue { get; set; }
        public int InstallmentsQnt { get; set; }

        public List<Installments> ContractInstallments = new List<Installments>();

        public IPaymentServices PaymentService;

        public Contract(int contractNumber, DateTime contractDate, double contractValue, int installmentsQnt, IPaymentServices paymentService)
        {
            ContractNumber = contractNumber;
            ContractDate = contractDate;
            ContractValue = contractValue;
            InstallmentsQnt = installmentsQnt;
            PaymentService = paymentService;
        }

        public void CreateInstallments()
        {
            for(int i = 1; i <= InstallmentsQnt; i++)
            {
                DateTime dueDate = ContractDate.AddDays(30 * i);
                double value = ContractValue / InstallmentsQnt;
                double actualValue = PaymentService.InstallmentValue(value, i);               
                ContractInstallments.Add(new Installments(dueDate, actualValue));
                
            }

        }
        public void PrintInstallments()
        {
            foreach(Installments x  in ContractInstallments)
            {
                Console.WriteLine(x.ToString());
            }
        }

    }
}
