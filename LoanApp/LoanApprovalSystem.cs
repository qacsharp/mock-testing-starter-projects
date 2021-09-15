using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    class LoanApprovalSystem : ILoanApprovalSystem
    {
        public bool Approve(decimal amount)
        {
            if (amount < 1000)
                return true;
            else
                return false;
        }
    }
}
