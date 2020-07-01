using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIdButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameText.Text;
            string lastName = lastNameText.Text;

            EmployeeProcessor processor = new EmployeeProcessor();
            string employeeId = processor.GenerateEmployeeId(firstName, lastName);

            employeeIdText.Text = employeeId;
        }

         private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
