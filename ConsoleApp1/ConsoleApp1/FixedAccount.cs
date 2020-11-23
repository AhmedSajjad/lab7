using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FixedAccount:Account
    {
        private int tenureYear;

        override public int TenureYear
        {
            get { return tenureYear; }
            set { tenureYear = value; }
        }
        private int createYear;

        public int CreateYear
        {
            get { return createYear; }
            set { createYear = value; }
        }

        public FixedAccount()
        {

        }
        public FixedAccount(string accNo, string accName, int balance, int createYear, int tenureYear) : base(accNo, accName, balance)
        {
            this.createYear = createYear;
            this.tenureYear = tenureYear;
        }
          public override Boolean Withdraw(int amount) 
        {
            string curentYear = DateTime.Now.Year.ToString();
            int cyear = Int32.Parse(curentYear);
            if ((cyear - createYear) >= tenureYear)
            {
                return true;
            }
            else
                Console.WriteLine("Your account is not matured enough");
        }
        public void ShowInfo()
        {
            ShowInfo();
            Console.WriteLine("Account Opening Year: " + createYear);
            Console.WriteLine("Account Tenure Year: " + tenureYear);
        }

    }
}
