using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanApp
{
    public class ApprovalProcess
    {
        private readonly ILoanApprovalSystem loanApprovalSystem;

        public ApprovalProcess()
        {
            this.loanApprovalSystem = new LoanApprovalSystem();
        }

        public ApprovalProcess(ILoanApprovalSystem loanApprovalSystem)
        {
            this.loanApprovalSystem = loanApprovalSystem;
        }

        public string ApplyForLoan(decimal amount)
        {
            bool approved = loanApprovalSystem.Approve(amount);

            if (approved)
                return $"Your loan for {amount:C2} has been approved.";
            else
                return $"Your loan for {amount:C2} has been declined.";
        }
    }
}
