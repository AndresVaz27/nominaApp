using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;



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
        #region Buttons
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
            Employee employee = new Employee(txtName.Text, numericSalary.Value, comboBox2.Text,
            ofd.FileName, photoPath, dgvAddEmployee, txtName, numericSalary, comboBox2, pbxEmployee, ofd);
            photoPath = null;
            TotalPay();

        }

        /// <summary>
        /// Calculate Payroll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtNamePayroll.Text == "")
            {
                MessageBox.Show("Please double click on a row that contains Employee's Information before modifying.", "No Employee Selected.");
                return;
            }
           DialogResult dr = MessageBox.Show("Do you want to modify this employee?", "Modify Employee?",MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                Employee emp;
                emp = new Employee();
                emp.Name = txtNamePayroll.Text;
                emp.Salary = Convert.ToDecimal(lblSalaryPayrollValue.Text);
                emp.Department = lblDepartmentPayroll.Text;
                emp.CalcularBono(lblDepartmentPayroll.Text);

                decimal Total = numericHours.Value * Convert.ToDecimal(lblSalaryPayrollValue.Text);
                Total += numericRestDay.Value * 2 * Convert.ToDecimal(lblSalaryPayrollValue.Text);
                Total += numericHoliday.Value * 2 * Convert.ToDecimal(lblSalaryPayrollValue.Text);
                decimal bonusTotal = emp.Bono * numericHours.Value;
                lblBonusValue.Text = bonusTotal.ToString();
                lblBonusValue.Visible = true;
                lblBonus.Visible = true;
                Total += bonusTotal;
                lblTotalPerceptionsValue.Text = Total.ToString();
                lblTotalPerceptionsValue.Visible = true;
                lblPerceptions.Visible = true;
                Total -= emp.Salary * numericAbsence.Value;
                Total -= numericDiscount.Value;
                decimal deductions = (numericAbsence.Value * emp.Salary) + numericDiscount.Value;
                lblTotalDeductionsValue.Text = deductions.ToString();
                lblTotalDeductionsValue.Visible = true;
                lblDeductions.Visible = true;

                dgvAddEmployee.Rows[dgvAddEmployee.SelectedRows[0].Index].Cells[4].Value = Total;
                    TotalPay();
                return;
                case DialogResult.No:
                    return;
            }
            
        }
        #endregion

        #region dgvAddEmployee
        private void dgvAddEmployee_SelectionChanged(object sender, EventArgs e)
        {
            txtNamePayroll.Text = string.Empty;
            lblSalaryPayrollValue.Text = "";
            pbxPayroll.Image = null;
            lblDepartmentPayroll.Text = string.Empty;
            numericHours.Value = 0;
            numericRestDay.Value = 0;
            numericHoliday.Value = 0;
            lblBonusValue.Text = string.Empty;
            lblTotalPerceptionsValue.Text = string.Empty;
            numericAbsence.Value = 0;
            numericDiscount.Value = 0;
            lblTotalDeductionsValue.Text = string.Empty;
            txtName.Text = string.Empty;
            numericSalary.Value = 0;
            pbxEmployee.Image = null;
            txtNamePayroll.Text = string.Empty;
            lblSalaryPayrollValue.Text = "";
            lblDepartmentPayroll.Text = string.Empty;
            pbxPayroll.Image = null;
            lblBonusValue.Visible = false;
            lblBonus.Visible = false;
            lblTotalPerceptionsValue.Visible = false;
            lblTotalDeductionsValue.Visible = false;
        }

        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;

        }


        private void TotalPay()
        {
            CultureInfo cultureInfo = new CultureInfo("es-MX");
            decimal celda;
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvAddEmployee.Rows)
            {
                if(row.Cells[4].Value != "")
                {
                    celda = Convert.ToDecimal(row.Cells[4].Value);
                    suma += celda;
                    
                }
            }
            lblPayValue.Text = suma.ToString("C", cultureInfo);
            lblNumeroEnLetras.Text = toText(Convert.ToDouble(suma)) + " PESOS.";
        }
        
        private void dgvAddEmployee_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TotalPay();
        }
        /// <summary>
        /// Show Employee's Info on Controls when clicking a DataGridView Row
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Celda de la DataGridView</param>
        public void dgvAddEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
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
                lblSalaryPayrollValue.Text = dgvAddEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                    lblDepartmentPayroll.Text = dgvAddEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                    numericHours.Value = 0;
                    numericRestDay.Value = 0;
                    numericHoliday.Value = 0;
                lblBonusValue.Text = string.Empty;
                    lblTotalPerceptionsValue.Text = string.Empty;
                    numericAbsence.Value = 0;
                    numericDiscount.Value = 0;
                    lblTotalDeductionsValue.Text = string.Empty;
            }
            catch (Exception)
            {
                dgvAddEmployee_SelectionChanged(sender,e);
                MessageBox.Show("Unable to show Employee's Info");
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
                            lblSalaryPayrollValue.Text = "";
                            /*for (int i = 0; i < this.checkedDepartment.Items.Count; i++)
                            {
                                this.checkedDepartment.SetItemChecked(i, false);
                            }*/
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
        
        #endregion

        #region Form1
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
            // Add every existing Department in ComboBox2.
            string departamentos = "departamentos.txt";
            if (File.Exists(departamentos))
            {
                StreamReader reader = new StreamReader(departamentos);
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');
                        comboBox2.Items.Add(values[0]);
                    }
                }
            }
            comboBox2.Text = comboBox2.Items[0].ToString();
            LoadDevices();
            TotalPay();
        }
        #endregion

        #region Video Input Device
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
        /// Start Recording using VideoInputDevice selected in comboBox1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCam_Click(object sender, EventArgs e)
        {
            CloseWebCam();
            lblFace1.Visible = true;
            lblFace3.Visible = true;
            lblFace2.Visible = true;
            lblFace4.Visible = true;
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

                // Capture the image from the PictureBox.
                Image capturedImage = pbxEmployee.Image;

                // Calculate the desired dimensions for the cropped photo.
                int desiredWidth = 500;  // Set your desired width here
                int desiredHeight = 500; // Set your desired height here

                // Calculate the starting point for cropping.
                int x = (capturedImage.Width - desiredWidth) / 2;
                int y = (capturedImage.Height - desiredHeight) / 2;

                // Create a new Bitmap for the cropped photo.
                Bitmap croppedImage = new Bitmap(desiredWidth, desiredHeight);

                // Create a Graphics object from the croppedImage Bitmap.
                using (Graphics graphics = Graphics.FromImage(croppedImage))
                {
                    // Set the interpolation mode to high quality for better resizing.
                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    // Draw the cropped portion of the capturedImage onto the croppedImage.
                    graphics.DrawImage(capturedImage, 0, 0, new Rectangle(x, y, desiredWidth, desiredHeight), GraphicsUnit.Pixel);
                }

                // Generate a unique filename for the cropped photo.
                string fileName = string.Format("imagen{0}.jpg", imageCounter);

                // Save the croppedImage to the specified path.
                string croppedImagePath = Path.Combine(imagesPath, fileName);
                croppedImage.Save(croppedImagePath, ImageFormat.Jpeg);

                // Increment the imageCounter variable and save the updated value to a text file.
                imageCounter++;
                File.WriteAllText(counterFilePath, imageCounter.ToString());

                // Update the photoPath variable with the path of the cropped photo.
                photoPath = croppedImagePath;

                // Load the cropped photo into the pbxEmployee PictureBox.
                pbxEmployee.Image = Image.FromFile(photoPath);
                lblFace1.Visible = false;
                lblFace2.Visible = false;
                lblFace3.Visible = false;
                lblFace4.Visible = false;
            }
        }
        #endregion

        
    }
}
