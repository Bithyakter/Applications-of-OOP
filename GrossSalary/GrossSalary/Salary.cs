using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrossSalary
{
    class Salary
    {
        public int basicSalary;
        public int houseRent;
        public int medicalAllowance;
        public int conveyanceAllowance;
        public int tax;
        public Currency currency;

        double bs_percent;
        double hr_percent;
        double ma_percent;
        double ca_percent;
        double tx_percent;


        /*-----------Gross Salary Calculate---------*/
        public int CalculateByBasicSalary(int basicSalary)
        {
            this.bs_percent = 0.50;     // 50% Basic
            this.hr_percent = 0.20;     // 20% House
            this.ma_percent = 0.15;     // 15% Medical
            this.ca_percent = 0.10;     // 10% Conveyance
            this.tx_percent = 0.05;      // 5%  Tax(Deduction)

            //-------------------------------
            // Basic                 100%
            this.currency = Currency.BDT;

            this.basicSalary = basicSalary;
            this.houseRent = Convert.ToInt32(basicSalary * 0.20);
            this.medicalAllowance = Convert.ToInt32(basicSalary * 0.15);
            this.conveyanceAllowance = Convert.ToInt32(basicSalary * 0.10);
            this.tax = Convert.ToInt32(basicSalary * 0.05);
            var re = this.basicSalary 
                + this.houseRent 
                + this.medicalAllowance 
                + this.conveyanceAllowance 
                - this.tax;
            return re;
        }

    }

    public enum Currency
    {
        BDT, RS, USD, ERO, CNY, YEN
    }

}



