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
            if (string.IsNullOrWhiteSpace(this.EmailAdress)) throw new ArgumentException("Email adress is null");

            var isValidFormat = true;
            // Code here that validates the format of the email
            // using Regular Expressions
            if (!isValidFormat) throw new ArgumentException("Email is in invalid format");

            var isRealDomain = true;
            // Code here that confirms whether domain exists
            if (!isRealDomain) throw new ArgumentException("Such domain don't exists");
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {
            // try 3
            decimal goalStepCount = 0;
            decimal actualStepCount = 0;

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be typed", "goalSteps");
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual value must be typed", "actualSteps");

            if(!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal must be numeric");
            if(!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual value must be numeric!", "actualSteps");

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalStepCount, decimal actualStepCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater than 0", "goalSteps");

            return Math.Round((actualStepCount / goalStepCount)* 100 ,2);
        }

    }
}
