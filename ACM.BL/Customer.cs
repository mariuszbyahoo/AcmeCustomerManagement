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

        public void ValidateEmail()
        {
            //if the user requested a receipt
            //get the customer data
            //Ensure a valid email adress was provided
            //If not,
            // request an email from the user.
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            // try 3
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be typed", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual value must be typed", "actualSteps");

            if(!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric", "goalSteps");
            if(!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual value must be numeric!", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return (actualStepCount / goalStepCount) * 100;
        }

    }
}
