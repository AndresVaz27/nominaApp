using System;
using System.Collections.Generic;
using System.IO;
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
        ComboBox ComboBox;

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

        public decimal CalcularBono(string departamento)
        {
            string[] lineas = File.ReadAllLines("departamentos.txt");  // Read every line from the file

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');  // Divide la línea en los datos separados por comas
                if (datos[0].Trim() == departamento)
                {
                    decimal porcentaje = decimal.Parse(datos[1].Trim());
                    return Bono = Salary * porcentaje;
                }
            }

            return 0;  // Devuelve 0 si no se encuentra el departamento
        }

        public Employee(string name, decimal salary, string department, string imagePath, 
            string photoPath, DataGridView dataGridView, TextBox nameTextBox, NumericUpDown salaryNumericUpDown, 
            ComboBox comboBox, PictureBox employeePictureBox, OpenFileDialog openFileDialog)
        {
           if (name == "")
            {
                MessageBox.Show("Name Required.");
                return;
            }
            if (salary == 0)
            {
                MessageBox.Show("Salary must not be '0'.");
                return;
            }
            if (department == "")
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
            this.ComboBox = comboBox;
            this.EmployeePictureBox = employeePictureBox;
            this.OpenFileDialog = openFileDialog;

            decimal pay = Salary * 40;
            pay = CalcularBono(department) + pay;

            // Agregar Row a la DataGridView con la info del empleado.
            this.DataGridView.Rows.Add(this.Name, this.Department, this.Salary, this.ImagePath, pay);
            MessageBox.Show(ToString());
            // Clear Controls
            this.NameTextBox.Clear();
            this.OpenFileDialog.FileName = string.Empty;
            this.SalaryNumericUpDown.Value = 0;
            this.EmployeePictureBox.Image = null;
            
        }
        public Employee()
        {
            CalcularBono(department);
        }
        /*~Employee()
        {
            MessageBox.Show("Ocuppied Memory Released!.");
        }*/
    }
}
