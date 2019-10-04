using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAdress { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            var op = new OperationResult();

            if (string.IsNullOrWhiteSpace(this.EmailAdress))
            {
                op.Success = false;
                op.AddMessage("Email adress is null");
            }
            if (op.Success)
            {
                var isValidFormat = true;
                // Code here that validates the format of the email
                // using Regular Expressions
                if (!isValidFormat)
                {
                    op.Success = false;
                    op.AddMessage("Email adress is in incorrect format");
                }
                var isRealDomain = true;
                // Code here that confirms whether domain exists
                if (!isRealDomain)
                {
                    op.Success = false;
                    op.AddMessage("Email adress has invalid domain");
                }
            }
            
            return op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            // try 3

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be typed", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual value must be typed", "actualSteps");
            
            decimal goalStepCount = 0;
            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");
            
            decimal actualStepCount = 0;
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual value must be numeric!", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount / goalStepCount)* 100 ,2);
        }
    }
}
