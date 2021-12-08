using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace john_EmployeeWageSystem
{
    public partial class FormMenu : Form
    {
        public List<JohnEmployee> listOfEmployee = new List<JohnEmployee>();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputEmployee formInputEmployee = new FormInputEmployee();
            formInputEmployee.Owner = this;
            formInputEmployee.ShowDialog();
        }

        private void displayEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDisplayEmployee formDisplayEmployee = new FormDisplayEmployee();
            formDisplayEmployee.Owner = this;
            formDisplayEmployee.ShowDialog();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open/Load Saved File";
            openFileDialog.Filter = "(*.vc)|*.vc";
            openFileDialog.FileName = "EmployeeData.vc";

            try
            {
                DialogResult userResponse = openFileDialog.ShowDialog();

                if (userResponse == DialogResult.OK)
                {
                    if (File.Exists(openFileDialog.FileName))
                    {
                        FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);

                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        listOfEmployee = binaryFormatter.Deserialize(fileStream) as List<JohnEmployee>;

                        fileStream.Close();
                        MessageBox.Show("File opened.");
                    }
                    else
                    {
                        throw new ArgumentException("File does not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save to File";
            saveFileDialog.Filter = "(*.vc)|*.vc";
            saveFileDialog.FileName = "EmployeeData.vc";

            try
            {
                DialogResult userResponse = saveFileDialog.ShowDialog();

                if (userResponse == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write);

                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, listOfEmployee);

                    fileStream.Close();
                    MessageBox.Show("File saved.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
