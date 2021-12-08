using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace john_EmployeeWageSystem
{
    [Serializable]
    public abstract class JohnEmployee
    {
        #region DATA FIELDS
        private string id;
        private string name;
        private int basicSalary;
        #endregion

        #region CONSTRUCTORS
        public JohnEmployee(string id, string name, int basicSalary)
        {
            this.Id = id;
            this.Name = name;
            this.BasicSalary = basicSalary;
        }
        #endregion

        #region PROPERTIES
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        #endregion

        #region METHODS
        public virtual string DisplayData()
        {
            return "Employee Id : " + this.Id
                + "\nEmployee Name : " + this.Name
                + "\nEmployee Basic Salary : " + this.BasicSalary;
        }
        public abstract double CalculateBonus();
        #endregion
    }
}