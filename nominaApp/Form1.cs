using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nominaApp
{
    public partial class Form1 : Form
    {
        public OpenFileDialog ofd;
        string imagesPath;
        bool devicesExist;
        FilterInfoCollection myDevices;
        VideoCaptureDevice myWebCam;
        private int imageCounter = 0;
        private string counterFilePath = "counter.txt";
        string photoPath;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            ofd = new OpenFileDialog();
            // Select the entire row when clicking on any cell
            dgvAddEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAddEmployee.RowHeadersVisible = false;
            // Show Add Employee Menu everytime the app starts
            panelPayroll.Visible = false;
            imagesPath = @"C:\Users\andre\source\repos\nominaApp - Copy\nominaApp\bin\Debug\imagesPath";
        }
        /// <summary>
        /// Load Video Input Devices to show in ComboBox1.
        /// </summary>
        public void LoadDevices()
        {
            // Collection of Video Input Devices.
            myDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (myDevices.Count > 0)
            {
                devicesExist = true;
                for (int i = 0; i < myDevices.Count; i++)
             // Add each item from the collection (myDevices) to ComboBox1.
                    comboBox1.Items.Add(myDevices[i].Name.ToString());
                // Show default device in ComboBox1.
                comboBox1.Text = myDevices[0].Name.ToString();

            }
            else
                devicesExist = false;
        }

        /// <summary>
        /// Show Payroll Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMenuNomina_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = false;
            panelPayroll.Visible = true;
        }

        /// <summary>
        /// Show Add Employee Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            panelAddEmployee.Visible = true;
            panelPayroll.Visible = false;
        }

        /// <summary>
        /// Browse files using an OpenFileDialog to find and Image for the New Employee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Filter that shows Image files only
            ofd.Filter = "Image Files (*.png)|*.png|Image Files (*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("An Image is required to add a new Employee.", "Image required", MessageBoxButtons.OK);
                return;
            }
            pbxEmployee.Image = Image.FromFile(ofd.FileName);
        }

        /// <summary>
        /// Add a new Row containing Employee's Info to DataGridView Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*Employee employee = new Employee();
            employee.Name = txtName.Text;
            employee.Salary = numericSalary.Value;
            employee.Department = checkedDepartment.Text;
            // Save Employee's Image from the picturebox
            employee.ImagePath = ofd.FileName;
            // Add a Row to the DataGridView containing the Employee's Info
            dgvAddEmployee.Rows.Add(employee.Name, employee.Department, employee.Salary, employee.ImagePath);
            // Clear Controls
            txtName.Clear();
            ofd.FileName = string.Empty;
            numericSalary.Value = 0;
            pbxEmployee.Image = null;
            checkedDepartment.SetItemChecked(checkedDepartment.SelectedIndex, false);
            checkedDepartment.ClearSelected();
            MessageBox.Show(employee.ToString());*/
            try
            {
              // Employee's Contructor Method.
              Employee employee = new Employee(txtName.Text, numericSalary.Value, checkedDepartment.Text, 
            ofd.FileName, photoPath, dgvAddEmployee, txtName, numericSalary, checkedDepartment, pbxEmployee, ofd);
              //MessageBox.Show(employee.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to add Employee");
            }
            

        }

        /// <summary>
        /// Show Employee's Info on Controls when clicking a DataGridView Row
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Celda de la DataGridView</param>
        private void dgvAddEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {

                        // Get Image Path
                        string rutaImagen = dgvAddEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                        // Show the image in both picture boxes
                        pbxEmployee.Image = Image.FromFile(rutaImagen);
                        pbxPayroll.Image = Image.FromFile(rutaImagen);
                        // Show Employee's Name in both textboxes
                        txtName.Text = dgvAddEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtNamePayroll.Text = dgvAddEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                        // Show Employee's Salary per Hour in both Numeric Controls
                        numericSalary.Value = Convert.ToDecimal(dgvAddEmployee.Rows[e.RowIndex].Cells[2].Value);
                        numericSalaryPayroll.Value = Convert.ToDecimal(dgvAddEmployee.Rows[e.RowIndex].Cells[2].Value);
                        lblDepartmentPayroll.Text = dgvAddEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                    numericHours.Value = 0;
                    numericRestDay.Value = 0;
                    numericHoliday.Value = 0;
                    numericBonus.Value = 0;
                    numericPerceptions.Value = 0;
                    numericAbsence.Value = 0;
                    numericDiscount.Value = 0;
                    numericDeductions.Value = 0;
                    numericPay.Value = 0;
                }
                else
                {
                    txtNamePayroll.Text = string.Empty;
                    numericSalaryPayroll.Value = 0;
                    pbxPayroll.Image = null;
                    lblDepartmentPayroll.Text = string.Empty;
                    numericHours.Value = 0;
                    numericRestDay.Value = 0;
                    numericHoliday.Value = 0;
                    numericBonus.Value = 0;
                    numericPerceptions.Value = 0;
                    numericAbsence.Value = 0;
                    numericDiscount.Value = 0;
                    numericDeductions.Value = 0;
                    numericPay.Value = 0;
                    return;
                }

            }
                catch (Exception)
                {
                txtName.Text = string.Empty;
                numericSalary.Value = 0;
                for (int i = 0; i < this.checkedDepartment.Items.Count; i++)
                {
                    this.checkedDepartment.SetItemChecked(i, false);
                }
                this.checkedDepartment.ClearSelected();
                pbxEmployee.Image = null;
                txtNamePayroll.Text = string.Empty;
                numericSalaryPayroll.Value = 0;
                lblDepartmentPayroll.Text = string.Empty;
                pbxPayroll.Image = null;
                MessageBox.Show("Unable to show Employee's Info");
                }

        }

        /// <summary>
        /// Delete DataGridView Row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void dgvAddEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Would you like to delete this row?", "Delete Row", MessageBoxButtons.YesNo);
                switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        DataGridViewRow selectedrow = dgvAddEmployee.Rows[e.RowIndex];// Get selected row's index 
                        dgvAddEmployee.Rows.Remove(selectedrow);
                        txtName.Text = string.Empty;txtNamePayroll.Text = string.Empty;
                        numericSalary.Value = 0;
                        numericSalaryPayroll.Value = 0;
                        for (int i = 0; i < this.checkedDepartment.Items.Count; i++)
                        {
                            this.checkedDepartment.SetItemChecked(i, false);
                        }
                        lblDepartmentPayroll.Text = string.Empty;
                        pbxEmployee.Image = null;
                        pbxPayroll.Image = null;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case DialogResult.No:
                    break; 
            }
        }
        /// <summary>
        /// Calculate Payroll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Employee emp;
            emp = new Employee();
            emp.Name = txtNamePayroll.Text;
            emp.Salary = numericSalaryPayroll.Value;
            emp.Department = lblDepartmentPayroll.Text;
            emp.CalcularBono();
            
            decimal Total = numericHours.Value * numericSalaryPayroll.Value;
            Total += numericRestDay.Value * 2 * numericSalaryPayroll.Value;
            Total += numericHoliday.Value * 2 * numericSalaryPayroll.Value;
            decimal bonusTotal = emp.Bono * numericHours.Value;
            numericBonus.Value = bonusTotal;
            Total += bonusTotal;
            numericPerceptions.Value = Total;
            Total -= emp.Salary * numericAbsence.Value;
            Total -= numericDiscount.Value;
            decimal deductions = (numericAbsence.Value * emp.Salary) + numericDiscount.Value;
            numericDeductions.Value = deductions;
            numericPay.Value = Total;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseWebCam();
            // Get file path where data is saved.
            string filePath = "datos.csv";
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write headers on the first line.
                for (int i = 0; i < dgvAddEmployee.Columns.Count; i++)
                {
                    writer.Write(dgvAddEmployee.Columns[i].HeaderText);
                    if (i < dgvAddEmployee.Columns.Count - 1)
                    {
                        writer.Write(",");
                    }
                }
                writer.WriteLine();

                // Write the content of each row on a different line per row.
                foreach (DataGridViewRow row in dgvAddEmployee.Rows)
                {
                    for (int i = 0; i < dgvAddEmployee.Columns.Count; i++)
                    {
                        if (!row.IsNewRow)
                        {
                            writer.Write(row.Cells[i].Value.ToString());
                        }

                        if (i < dgvAddEmployee.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
                writer.Close();
            }
            
        }
        /// <summary>
        /// Delete Employee from the DataGridView using Suprimir | Delete Key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAddEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                DialogResult dr = MessageBox.Show("Would you like to delete this row?", "Delete Row", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        try
                        {
                            // Get selected Row.
                            DataGridViewRow selectedRow = dgvAddEmployee.SelectedRows[0];
                            // Remove the selected Row.
                            dgvAddEmployee.Rows.Remove(selectedRow); 
                            // Clear controls.
                            txtName.Text = string.Empty; txtNamePayroll.Text = string.Empty;
                            numericSalary.Value = 0;
                            numericSalaryPayroll.Value = 0;
                            for (int i = 0; i < this.checkedDepartment.Items.Count; i++)
                            {
                                this.checkedDepartment.SetItemChecked(i, false);
                            }
                            lblDepartmentPayroll.Text = string.Empty;
                            pbxEmployee.Image = null;
                            pbxPayroll.Image = null;


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        break;
                    case DialogResult.No:
                        break;
                }


            }
        }
        /// <summary>
        /// Select only 1 item in checkedDepartment Control.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedDepartment_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // If the user is selecting a new item, deseleccionar cualquier otro elemento
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < checkedDepartment.Items.Count; ++i)
                {
                    if (i != e.Index && checkedDepartment.GetItemChecked(i))
                    {
                        checkedDepartment.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Obtener la ruta del archivo donde se guardaron los datos
            string filePath = "datos.csv";

            // Comprobar si el archivo existe
            if (File.Exists(filePath))
            {
                // Crear un StreamReader para leer el archivo
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Leer la primera línea que contiene los nombres de las columnas (si el archivo no está vacío)
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] headers = line.Split(',');

                        // Agregar las columnas al DataGridView
                        foreach (string header in headers)
                        {
                            dgvAddEmployee.Columns.Add(header, header);
                        }
                    }

                    // Leer las líneas restantes que contienen los datos de las filas
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');

                        // Crear una nueva fila y agregar los valores de las celdas
                        DataGridViewRow row = new DataGridViewRow();
                        foreach (string value in values)
                        {
                            row.Cells.Add(new DataGridViewTextBoxCell { Value = value });
                        }

                        // Agregar la fila al DataGridView
                        dgvAddEmployee.Rows.Add(row);
                    }
                    reader.Close();
                }
            }
            // Read counter value from txt file if the file exists.
            if (File.Exists(counterFilePath))
            {
                string counterString = File.ReadAllText(counterFilePath);
                int counterValue;
                // Convert string to int value.
                if (int.TryParse(counterString, out counterValue))
                {
                    // Asign value to variable.
                    imageCounter = counterValue;
                }
            }
            LoadDevices();
        }
        /// <summary>
        /// Start Recording using VideoInputDevice selected in comboBox1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCam_Click(object sender, EventArgs e)
        {
            CloseWebCam();
            int i = comboBox1.SelectedIndex;
            // Convert device name from collection to the right format (monikerString).
            string deviceName = myDevices[i].MonikerString;
            // Instance Video Input Device object.
            myWebCam = new VideoCaptureDevice(deviceName);
            // Everytime theres a new frame taken, call the "Recording Method" to show the Image.
            myWebCam.NewFrame += new NewFrameEventHandler(Recording);
            // Start using the Device.
            myWebCam.Start();
        }
        /// <summary>
        /// Clone the new frame taken and send it to the PictureBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eventArgs"></param>
        public void Recording(object sender, NewFrameEventArgs eventArgs)
        {
            // Clone the new frame.
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            // Show the copy of the frame in the PictureBox.
            pbxEmployee.Image = image;
        }
        /// <summary>
        /// Stop using the Video Input Device (MyWebCam).
        /// </summary>
        public void CloseWebCam()
        {
            if (myWebCam!=null && myWebCam.IsRunning)
            {
                myWebCam.SignalToStop();
                myWebCam = null;
            }
        }
        /// <summary>
        /// Take Photo saving the image from the picturebox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            if (myWebCam != null && myWebCam.IsRunning)
            {
                // Stop Video Input Device.
                CloseWebCam();
                // Asign new name to Photo.
                string fileName = string.Format("imagen{0}.jpg", imageCounter);
                // Save Image from the PictureBox.
                pbxEmployee.Image.Save(Path.Combine(imagesPath, fileName), ImageFormat.Jpeg);
                // Add 1 to counter so the next Photo has a different name.
                imageCounter++;
                // Save imageCounter value in txt Document.
                File.WriteAllText(counterFilePath, imageCounter.ToString());
                photoPath = Path.Combine(imagesPath, fileName);
                pbxEmployee.Image = Image.FromFile(photoPath);
            }
        }
    }
}
