using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace john_EmployeeWageSystem
{
    public partial class FormInputEmployee : Form
    {
        FormMenu formMenu;

        public FormInputEmployee()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormInputEmployee_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            radioButtonRegular.Checked = true;

            listBoxInfo.Items.Clear();

            if (formMenu.listOfEmployee != null)
            {
                DisplayAllEmployee(formMenu.listOfEmployee, listBoxInfo);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBoxId.Text;
                string name = textBoxName.Text;
                int basicSalary = int.Parse(textBoxBasicSalary.Text);

                JohnEmployee myEmployee;

                if (radioButtonRegular.Checked)
                {
                    int numberOfChildren = (int)numericUpDownNumberOfChildren.Value;

                    myEmployee = new JohnRegularEmployee(id, name, basicSalary, numberOfChildren);
                    numericUpDownNumberOfChildren.Value = 0;
                }
                else
                {
                    DateTime startingWorkingDate = dateTimePickerStartDate.Value;
                    DateTime endingWorkingDate = dateTimePickerEndDate.Value;

                    myEmployee = new JohnTemporaryEmployee(id, name, basicSalary, startingWorkingDate, endingWorkingDate);
                    dateTimePickerStartDate.Value = DateTime.Now;
                    dateTimePickerEndDate.Value = DateTime.Now;
                }

                AddEmployee(myEmployee, listBoxInfo);

                textBoxId.Text = "";
                textBoxName.Text = "";
                textBoxBasicSalary.Text = "";

                textBoxId.Focus();
                radioButtonRegular.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEmployee(JohnEmployee employee, ListBox listBox)
        {
            formMenu.listOfEmployee.Add(employee);

            listBox.Items.AddRange(employee.DisplayData().Split('\n'));
            listBox.Items.Add("");

            MessageBox.Show("Employee Added to list.");
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRegular.Checked)
            {
                groupBoxRegularEmployee.Enabled = true;
                groupBoxTemporaryEmployee.Enabled = false;
            }
            else
            {
                groupBoxTemporaryEmployee.Enabled = true;
                groupBoxRegularEmployee.Enabled = false;
            }
        }

        private void DisplayAllEmployee(List<JohnEmployee> listOfEmployees, ListBox listBox)
        {
            foreach(JohnEmployee employee in listOfEmployees)
            {
                listBox.Items.AddRange(employee.DisplayData().Split('\n'));
                listBox.Items.Add("");
            }
        }
    }
}
