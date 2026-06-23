using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class Billing
    {
        public string PatientName;
        public double BaseCharge;

        protected Billing(string patientName, double baseCharge)
        {
            PatientName = patientName;
            BaseCharge = baseCharge;
        }

        public abstract double CalculateTotalCharge();
    }
    class InPatientBilling : Billing
    {
       double amountPerDay;

        public InPatientBilling(string patientName, double baseCharge, double amountPerDay) : base(patientName, baseCharge)
        {
            this.amountPerDay = amountPerDay;
        }
        public override double CalculateTotalCharge()
        {
            return BaseCharge + amountPerDay;
        }
    }
    class OutPatientBilling : Billing
    {
        double consultationFee;
        public OutPatientBilling(string patientName, double baseCharge, double consultationFee) : base(patientName, baseCharge)
        {
            this.consultationFee = consultationFee;
        }
        public override double CalculateTotalCharge()
        {
            return BaseCharge + consultationFee;
        }
    }
}
