using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace john_EmployeeWageSystem
{
    [Serializable]
    public class JohnRegularEmployee : JohnEmployee
    {
        #region DATA FIELDS
        private int numberOfChildren;
        #endregion

        #region CONSTRUCTORS
        public JohnRegularEmployee(string id, string name, int basicSalary, int numberOfChildren) : base(id, name, basicSalary)
        {
            this.NumberOfChildren = numberOfChildren;
        }
        #endregion

        #region PROPERTIES
        public int NumberOfChildren { get => numberOfChildren; set => numberOfChildren = value; }
        #endregion

        #region METHODS
        public override double CalculateBonus()
        {
            double childrenAllowance;

            if (numberOfChildren < 3)
            {
                childrenAllowance = numberOfChildren * (0.2 * this.BasicSalary);
            }
            else
            {
                childrenAllowance = 3 * (0.2 * this.BasicSalary);
            }

            double bonus = this.BasicSalary + childrenAllowance;

            return bonus;
        }
        public override string DisplayData()
        {
            return base.DisplayData()
                + "\nEmployee's Children : " + this.NumberOfChildren
                + "\nEmployee Bonus Available : " + CalculateBonus();
        }
        #endregion
    }
}