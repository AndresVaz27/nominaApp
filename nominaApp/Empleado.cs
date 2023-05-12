using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;




namespace nominaApp
{

    internal class Employee : Person, IBono
    {
        Form1 form = new Form1();
        decimal bono;
        DataGridView DataGridView;
        TextBox NameTextBox;
        NumericUpDown SalaryNumericUpDown;
        CheckedListBox DepartmentCheckedListBox;
        PictureBox EmployeePictureBox;
        OpenFileDialog OpenFileDialog;
        public decimal porcentajeBono;


        public override string ToString()
        {
            return "Employee added succesfully.";
        }

        public decimal Bono
        {
            get { return bono; }
            set { bono = value; }
        }


        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public decimal CalcularBono()
        {
            porcentajeBono = 0;

            switch (Department)
            {
                case "Sales":
                    porcentajeBono = 0.2m;
                    break;
                case "Manager":
                    porcentajeBono = 0.15m;
                    break;
                case "Assistant Manager":
                    porcentajeBono = 0.10m;
                    break;
            }

            return Bono = Salary * porcentajeBono;
        }

        public Employee(string name, decimal salary, string department, string imagePath, string photoPath, DataGridView dataGridView, TextBox nameTextBox, NumericUpDown salaryNumericUpDown, CheckedListBox departmentCheckedListBox, PictureBox employeePictureBox, OpenFileDialog openFileDialog)
        {
           if (name == "")
            {
                MessageBox.Show("Name Required.");
                return;
            }if (department == "")
            {
                MessageBox.Show("Deparment Required.");
                return;
            }if (imagePath == "" && photoPath == null )
            {
                MessageBox.Show("Image Required.");
                return;
            }
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
            if (imagePath == string.Empty)
            {
                this.ImagePath = photoPath;
            }
            else
            {
                this.ImagePath = imagePath;
            }
            this.DataGridView = dataGridView;
            this.NameTextBox = nameTextBox;
            this.SalaryNumericUpDown = salaryNumericUpDown;
            this.DepartmentCheckedListBox = departmentCheckedListBox;
            this.EmployeePictureBox = employeePictureBox;
            this.OpenFileDialog = openFileDialog;
            

            // Agregar Row a la DataGridView con la info del empleado.
            this.DataGridView.Rows.Add(this.Name, this.Department, this.Salary, this.ImagePath);

            // Clear Controls
            this.NameTextBox.Clear();
            this.OpenFileDialog.FileName = string.Empty;
            this.SalaryNumericUpDown.Value = 0;
            this.EmployeePictureBox.Image = null;
            for (int i = 0; i < this.DepartmentCheckedListBox.Items.Count; i++)
            {
                this.DepartmentCheckedListBox.SetItemChecked(i, false);
            }
            this.DepartmentCheckedListBox.ClearSelected();
        }
        public Employee()
        {
            // Sin declarar nada.
        }
        /*~Employee()
        {
            MessageBox.Show("Ocuppied Memory Released!.");
        }*/
    }
}
