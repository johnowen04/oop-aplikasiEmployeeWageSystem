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
    public partial class FormDisplayEmployee : Form
    {
        FormMenu formMenu;

        public FormDisplayEmployee()
        {
            InitializeComponent();
        }

        private void FormDisplayEmployee_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            radioButtonAllTypes.Checked = true;
            listBoxInfo.Items.Clear();

            foreach (JohnEmployee employee in formMenu.listOfEmployee)
            {
                DisplayEmployee(employee, listBoxInfo);
            }
        }

        private void DisplayEmployee(JohnEmployee employee, ListBox listBox)
        {
            listBox.Items.AddRange(employee.DisplayData().Split('\n'));
            listBox.Items.Add("");
        }

        private void radioButtonTemporary_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange(radioButtonAllTypes, radioButtonTemporary, radioButtonRegular, listBoxInfo);
        }

        private void radioButtonAllTypes_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange(radioButtonAllTypes, radioButtonTemporary, radioButtonRegular, listBoxInfo);
        }

        private void radioButtonRegular_CheckedChanged(object sender, EventArgs e)
        {
            CheckChange(radioButtonAllTypes, radioButtonTemporary, radioButtonRegular, listBoxInfo);
        }

        private void CheckChange(RadioButton allTypes, RadioButton temporary, RadioButton regular, ListBox listBox)
        {
            listBox.Items.Clear();
            if (allTypes.Checked)
            {
                foreach (JohnEmployee employee in formMenu.listOfEmployee)
                {
                    DisplayEmployee(employee, listBox);
                }
            }
            else if (temporary.Checked)
            {
                foreach (JohnEmployee temporaryEmployee in formMenu.listOfEmployee)
                {
                    if (temporaryEmployee is JohnTemporaryEmployee)
                    {
                        DisplayEmployee(temporaryEmployee, listBoxInfo);
                    }
                }
            }
            else if (regular.Checked)
            {
                foreach (JohnEmployee regularEmployee in formMenu.listOfEmployee)
                {
                    if (regularEmployee is JohnRegularEmployee)
                    {
                        DisplayEmployee(regularEmployee, listBoxInfo);
                    }
                }
            }
        }
    }
}
