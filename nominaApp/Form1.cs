﻿using AForge.Video;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Net.Mail;


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
            dgvRecibos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecibos.RowHeadersVisible = false;
            // Show Add Employee Menu everytime the app starts
            panelPayroll.Visible = false;
            imagesPath = @"C:\Users\andre\source\repos\nominaApp - Copy\nominaApp\bin\Debug\imagesPath";
        }
        #region Form1
        /// <summary>
        /// Closes active WebCam and saves DataGridView data when the program is closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseWebCam();
            SaveDGVRecibos();
        }
        /// <summary>
        /// Loads several objects and data when the program opens.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDGVRecibos();
            GetImageCounter();
            LoadDepartments();
            LoadDevices();
            TotalPay();
            EliminarFilasVacias(dgvRecibos);
        }

        /// <summary>
        /// Reads data contained in departamentos.txt to fill ComboBox2.
        /// </summary>
        public void LoadDepartments()
        {
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
        }
        /// <summary>
        /// Reads doc that contains Image Counter for new image file generator.
        /// </summary>
        public void GetImageCounter()
        {
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
        }
        /// <summary>
        /// Reads data containded in datosDGVRecibos.csv to fill DataGridView.
        /// </summary>
        public void LoadDGVRecibos()
        {
            // Obtener la ruta del archivo donde se guardaron los datos
            string filePath = "datosDGVRecibos.csv";

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
                            dgvRecibos.Columns.Add(header, header);
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
                        dgvRecibos.Rows.Add(row);
                    }
                    reader.Close();
                }
            }
        }
        /// <summary>
        /// Saves DataGridView's data.
        /// </summary>
        public void SaveDGVRecibos()
        {
            string filePath = "datosDGVRecibos.csv";

            // Crear un StreamWriter para escribir en el archivo CSV
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Escribir los nombres de las columnas en la primera línea
                for (int i = 0; i < dgvRecibos.Columns.Count; i++)
                {
                    writer.Write(dgvRecibos.Columns[i].HeaderText);
                    if (i < dgvRecibos.Columns.Count - 1)
                    {
                        writer.Write(",");
                    }
                }
                writer.WriteLine();

                // Escribir el contenido de cada fila en líneas separadas
                foreach (DataGridViewRow row in dgvRecibos.Rows)
                {
                    for (int i = 0; i < dgvRecibos.Columns.Count; i++)
                    {
                        if (!row.IsNewRow)
                        {
                            writer.Write(row.Cells[i].Value);
                        }

                        if (i < dgvRecibos.Columns.Count - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }

                writer.Close();
            }
        }

        #endregion

        #region Buttons
        
        /// <summary>
        /// Creates PDF file with Individual Selected Employee's receipt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIndividualReceipt_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila en el DataGridView
            if (dgvRecibos.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = dgvRecibos.SelectedRows[0];

                // Crea un documento PDF
                Document doc = new Document();

                try
                {
                    // Abre un cuadro de diálogo Guardar archivo para especificar la ubicación del archivo PDF
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Archivos PDF|*.pdf";
                    saveFileDialog.Title = "Guardar como PDF";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Crea un escritor de PDF
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        // Agrega los datos de la fila seleccionada al documento PDF
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            doc.Add(new Paragraph(dgvRecibos.Columns[i].HeaderText + ": " + row.Cells[i].Value.ToString()));
                        }

                        // Cierra el documento PDF
                        doc.Close();

                        MessageBox.Show("PDF creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila en el DataGridView.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Creates a PDF File containing every Payroll detail.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPDFPayroll_Click(object sender, EventArgs e)
        {
            // Verifica si hay filas en el DataGridView
            if (dgvRecibos.Rows.Count > 0)
            {
                // Abre un cuadro de diálogo Guardar archivo para especificar la ubicación del archivo PDF
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos PDF|*.pdf";
                saveFileDialog.Title = "Guardar como PDF";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Crea un documento PDF
                    Document doc = new Document();

                    try
                    {
                        // Crea un escritor de PDF
                        PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                        doc.Open();

                        int currentRow = 0;
                        int totalRows = dgvRecibos.Rows.Count;

                        // Imprime las filas en el documento PDF
                        while (currentRow <= totalRows - 2)
                        {
                            DataGridViewRow row = dgvRecibos.Rows[currentRow];

                            // Agrega los datos de la fila al documento PDF
                            for (int j = 0; j < row.Cells.Count; j++)
                            {
                                object cellValue = row.Cells[j].Value;
                                string cellText = cellValue != null ? cellValue.ToString() : string.Empty;
                                doc.Add(new Paragraph(dgvRecibos.Columns[j].HeaderText + ": " + cellText));
                            }

                            doc.Add(new Paragraph("-----------------"));
                            currentRow++;
                        }

                        // Imprime el total al final
                        string totalText = "Total = " + lblPayValue.Text + " " + lblNumeroEnLetras.Text;
                        doc.Add(new Paragraph(totalText));

                        // Cierra el documento PDF
                        doc.Close();

                        // Crea un mensaje de correo electrónico
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("andresvazquezo1@hotmail.com");
                        mailMessage.To.Add("andresvazquezo1@hotmail.com");
                        mailMessage.Subject = "Payroll PDF";
                        mailMessage.Body = "You will find the Payroll.pdf file attached in this mail.";

                        // Adjunta el archivo PDF al mensaje de correo electrónico
                        Attachment attachment = new Attachment(saveFileDialog.FileName);
                        mailMessage.Attachments.Add(attachment);

                        // Configura el cliente SMTP y envía el correo electrónico
                        SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com", 587);
                        smtpClient.EnableSsl = true;
                        smtpClient.Credentials = new System.Net.NetworkCredential("andresvazquezo1@hotmail.com", "acereros27");
                        smtpClient.Send(mailMessage);

                        MessageBox.Show("Correo electrónico enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear el PDF o enviar el correo electrónico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay filas en el DataGridView para imprimir.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            pbxEmployee.Image = System.Drawing.Image.FromFile(ofd.FileName);
        }

        /// <summary>
        /// Add a new Row containing Employee's Info to DataGridView Control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {   
            Employee employee = new Employee(txtName.Text, numericSalary.Value, comboBox2.Text,
            ofd.FileName, photoPath, dgvRecibos, txtName, numericSalary, comboBox2, pbxEmployee, ofd);
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
                emp.CalcularBono(emp.Department);

                decimal Total = numericHours.Value * Convert.ToDecimal(lblSalaryPayrollValue.Text);
                decimal bonoTotal = emp.Bono * Total;
                    Total += bonoTotal;
                    Total += (numericRestDay.Value * 2) * Convert.ToDecimal(lblSalaryPayrollValue.Text);
                Total += (numericHoliday.Value * 2) * Convert.ToDecimal(lblSalaryPayrollValue.Text);
                    
                    lblBonusValue.Text = bonoTotal.ToString();
                    lblBonusValue.Visible = true;
                lblBonus.Visible = true;
                lblTotalPerceptionsValue.Text = Total.ToString();
                lblTotalPerceptionsValue.Visible = true;
                lblPerceptions.Visible = true;
                Total -= emp.Salary * numericAbsence.Value;
                Total -= numericDiscount.Value;
                decimal deductions = (numericAbsence.Value * emp.Salary) + numericDiscount.Value;
                lblTotalDeductionsValue.Text = deductions.ToString();
                lblTotalDeductionsValue.Visible = true;
                lblDeductions.Visible = true;
                    DataGridViewRow row = dgvRecibos.SelectedRows[0];
                    if (dgvRecibos.SelectedRows.Count > 0)
                    {
                        DataGridViewRow selectedRow = dgvRecibos.SelectedRows[0];

                        // Actualizar los valores de la fila seleccionada
                        selectedRow.Cells[0].Value = txtNamePayroll.Text;
                        selectedRow.Cells[1].Value = lblDepartmentPayroll.Text;
                        selectedRow.Cells[2].Value = lblSalaryPayrollValue.Text;
                        selectedRow.Cells[3].Value = row.Cells[3].Value.ToString();
                        selectedRow.Cells[4].Value = Total;
                        selectedRow.Cells[5].Value = numericHours.Value.ToString();
                        selectedRow.Cells[6].Value = numericRestDay.Value.ToString();
                        selectedRow.Cells[7].Value = numericHoliday.Value.ToString();
                        selectedRow.Cells[8].Value = lblBonusValue.Text;
                        selectedRow.Cells[9].Value = lblTotalPerceptionsValue.Text;
                        selectedRow.Cells[10].Value = numericAbsence.Value.ToString();
                        selectedRow.Cells[11].Value = numericDiscount.Value.ToString();
                        selectedRow.Cells[12].Value = lblTotalDeductionsValue.Text;


                        // Refrescar la visualización del DataGridView
                        dgvRecibos.Refresh();
                    }
                    TotalPay();
                return;
                case DialogResult.No:
                    return;
            }
            
        }
        #endregion

        #region dgvRecibos
        /// <summary>
        /// Delete empty rows when the program opens method.
        /// </summary>
        /// <param name="dataGridView"></param>
        private void EliminarFilasVacias(DataGridView dataGridView)
        {
            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView.Rows[i];
                if (row.Cells[0].Value == null || string.IsNullOrWhiteSpace(row.Cells[0].Value.ToString()))
                {
                    try
                    {
                        dataGridView.Rows.Remove(row);

                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// Cleans controls when a selected DataGridView's row changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRecibos_SelectionChanged(object sender, EventArgs e)
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

        /// <summary>
        /// Convert number toText method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Calculates total Payroll showing quantity in numbers and letters calling toText Method.
        /// </summary>
        private void TotalPay()
        {
            CultureInfo cultureInfo = new CultureInfo("es-MX");
            decimal celda;
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvRecibos.Rows)
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

        /// <summary>
        /// Calls TotalPay method everytime a row from the DataGridView is deleted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRecibos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TotalPay();
        }

        /// <summary>
        /// Show Employee's Info on Controls when clicking a DataGridView Row
        /// </summary>
        /// <param name="sender">DataGridView</param>
        /// <param name="e">Celda de la DataGridView</param>
        private void dgvRecibos_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Get Image Path
                string rutaImagen = dgvRecibos.Rows[e.RowIndex].Cells[3].Value.ToString();
                // Show the image in both picture boxes
                pbxEmployee.Image = System.Drawing.Image.FromFile(rutaImagen);
                pbxPayroll.Image = System.Drawing.Image.FromFile(rutaImagen);
                // Show Employee's Name in both textboxes
                txtName.Text = dgvRecibos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNamePayroll.Text = dgvRecibos.Rows[e.RowIndex].Cells[0].Value.ToString();
                // Show Employee's Salary per Hour in both Numeric Controls
                numericSalary.Value = Convert.ToDecimal(dgvRecibos.Rows[e.RowIndex].Cells[2].Value);
                lblSalaryPayrollValue.Text = dgvRecibos.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblDepartmentPayroll.Text = dgvRecibos.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                dgvRecibos_SelectionChanged(sender, e);
                MessageBox.Show("Unable to show Employee's Info");
            }
        }

        /// <summary>
        /// Delete Employee from the DataGridView using Suprimir | Delete Key.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvRecibos_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dr = MessageBox.Show("Would you like to delete this row?", "Delete Row", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        try
                        {
                            // Get selected Row.
                            DataGridViewRow selectedRow = dgvRecibos.SelectedRows[0];
                            // Remove the selected Row.
                            dgvRecibos.Rows.Remove(selectedRow);
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
        /// 
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
        /// Take Photo cropping and saving the image from the picturebox.
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
                System.Drawing.Image capturedImage = pbxEmployee.Image;

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
                    graphics.DrawImage(capturedImage, 0, 0, new System.Drawing.Rectangle(x, y, desiredWidth, desiredHeight), GraphicsUnit.Pixel);
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
                pbxEmployee.Image = System.Drawing.Image.FromFile(photoPath);
                lblFace1.Visible = false;
                lblFace2.Visible = false;
                lblFace3.Visible = false;
                lblFace4.Visible = false;
            }
        }

        #endregion

        private void lblNumeroEnLetras_Click(object sender, EventArgs e)
        {

        }

        private void lblPayValue_Click(object sender, EventArgs e)
        {

        }

        private void lblPay_Click(object sender, EventArgs e)
        {

        }
    }
}
