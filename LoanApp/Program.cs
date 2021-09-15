using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanApprovalSystem loanApprovalSystem = new LoanApprovalSystem();

            ApprovalProcess process = new ApprovalProcess(loanApprovalSystem);

            while (true)
            {
                Console.Write("How much do you want to borrow? ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                string response = process.ApplyForLoan(amount);

                Console.WriteLine(response);
                Console.WriteLine();
            }
        }
    }
}
