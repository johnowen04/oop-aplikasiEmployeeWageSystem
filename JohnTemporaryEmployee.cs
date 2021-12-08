using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace john_EmployeeWageSystem
{
    [Serializable]
    public class JohnTemporaryEmployee : JohnEmployee
    {
        #region DATA FIELDS
        private DateTime startingWorkingDate;
        private DateTime endingWorkingDate;
        #endregion

        #region CONSTRUCTORS
        public JohnTemporaryEmployee(string id, string name, int basicSalary, DateTime startingWorkingDate, DateTime endingWorkingDate)  : base(id, name, basicSalary)
        {
            this.StartingWorkingDate = startingWorkingDate;
            this.EndingWorkingDate = endingWorkingDate;
        }
        #endregion

        #region PROPERTIES
        public DateTime StartingWorkingDate { get => startingWorkingDate; set => startingWorkingDate = value; }
        public DateTime EndingWorkingDate { get => endingWorkingDate; set => endingWorkingDate = value; }
        #endregion

        #region METHODS
        public override double CalculateBonus()
        {
            double numberOfAttendance = EndingWorkingDate.Subtract(StartingWorkingDate).TotalDays;
            double attendanceBonus = numberOfAttendance * (0.01 * this.BasicSalary);
            double bonus = (0.1 * this.BasicSalary) + attendanceBonus;

            return bonus;
        }
        public override string DisplayData()
        {
            return base.DisplayData()
                + "\nEmployee Starting Working Date : " + this.StartingWorkingDate.ToShortDateString()
                + "\nEmployee Ending Working Date : " + this.EndingWorkingDate.ToShortDateString()
                + "\nEmployee Bonus Available : " + CalculateBonus();
        }
        #endregion
    }
}