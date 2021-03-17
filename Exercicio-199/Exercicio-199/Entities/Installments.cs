using System;
using System.Collections.Generic;
using System.Text;
using Exercicio_199.Services;
using System.Globalization;

namespace Exercicio_199.Entities
{
    class Installments
    {
        public DateTime DueDate { get; set; }
        public double Value { get; set; }

        public Installments(DateTime dueDate, double value)
        {
            DueDate = dueDate;
            Value = value;
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + " - " + Value.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
