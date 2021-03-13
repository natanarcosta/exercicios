using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_131.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        
        public OutsourcedEmployee()
        {

        }
        public OutsourcedEmployee(string name, int hours, double valueperhour, double additionalcharge) : base(name, hours, valueperhour)
        {
            AdditionalCharge = additionalcharge;
        }
        public override double Payment()
        {
            double payment = base.Payment();
            return payment += AdditionalCharge * 1.1;
        }
    }
}
