using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class AlternativeLoanApprovalSystem : ILoanApprovalSystem
    {
        public bool Approve(decimal amount)
        {
            if (amount % 1000 == 0)
                return true;
            else
                return false;
        }
    }
}
