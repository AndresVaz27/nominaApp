namespace nominaApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPayrollMenu = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbxEmployee = new System.Windows.Forms.PictureBox();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelAddEmployee = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.checkedDepartment = new System.Windows.Forms.CheckedListBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dgvAddEmployee = new System.Windows.Forms.DataGridView();
            this.panelPayroll = new System.Windows.Forms.Panel();
            this.lblDepartmentPayroll = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPay = new System.Windows.Forms.Label();
            this.numericPay = new System.Windows.Forms.NumericUpDown();
            this.numericDeductions = new System.Windows.Forms.NumericUpDown();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Label();
            this.numericAbsence = new System.Windows.Forms.NumericUpDown();
            this.lblAbsence = new System.Windows.Forms.Label();
            this.numericPerceptions = new System.Windows.Forms.NumericUpDown();
            this.lblPerceptions = new System.Windows.Forms.Label();
            this.numericBonus = new System.Windows.Forms.NumericUpDown();
            this.numericHoliday = new System.Windows.Forms.NumericUpDown();
            this.numericRestDay = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblHoliday = new System.Windows.Forms.Label();
            this.lblRestDay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.numericSalaryPayroll = new System.Windows.Forms.NumericUpDown();
            this.pbxPayroll = new System.Windows.Forms.PictureBox();
            this.lblSalaryPayroll = new System.Windows.Forms.Label();
            this.lblNamePayroll = new System.Windows.Forms.Label();
            this.txtNamePayroll = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.panelAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddEmployee)).BeginInit();
            this.panelPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeductions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPerceptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalaryPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayrollMenu
            // 
            this.btnPayrollMenu.Location = new System.Drawing.Point(12, 12);
            this.btnPayrollMenu.Name = "btnPayrollMenu";
            this.btnPayrollMenu.Size = new System.Drawing.Size(128, 91);
            this.btnPayrollMenu.TabIndex = 0;
            this.btnPayrollMenu.Text = "Payroll Menu";
            this.btnPayrollMenu.UseVisualStyleBackColor = true;
            this.btnPayrollMenu.Click += new System.EventHandler(this.btnMenuNomina_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEmployee.Location = new System.Drawing.Point(1392, 12);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(128, 91);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(61, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 30);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(56, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 29);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblSalary
            // 
            this.lblSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(56, 96);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(180, 29);
            this.lblSalary.TabIndex = 5;
            this.lblSalary.Text = "Salary per Hour";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBrowse.Location = new System.Drawing.Point(690, 230);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 46);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbxEmployee
            // 
            this.pbxEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxEmployee.Location = new System.Drawing.Point(592, 43);
            this.pbxEmployee.Name = "pbxEmployee";
            this.pbxEmployee.Size = new System.Drawing.Size(302, 180);
            this.pbxEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEmployee.TabIndex = 7;
            this.pbxEmployee.TabStop = false;
            // 
            // numericSalary
            // 
            this.numericSalary.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericSalary.BackColor = System.Drawing.SystemColors.Window;
            this.numericSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSalary.Location = new System.Drawing.Point(61, 126);
            this.numericSalary.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(273, 30);
            this.numericSalary.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(395, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 91);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddEmployee.Controls.Add(this.comboBox1);
            this.panelAddEmployee.Controls.Add(this.btnTakePhoto);
            this.panelAddEmployee.Controls.Add(this.btnStartCam);
            this.panelAddEmployee.Controls.Add(this.checkedDepartment);
            this.panelAddEmployee.Controls.Add(this.lblDepartment);
            this.panelAddEmployee.Controls.Add(this.pbxEmployee);
            this.panelAddEmployee.Controls.Add(this.lblSalary);
            this.panelAddEmployee.Controls.Add(this.numericSalary);
            this.panelAddEmployee.Controls.Add(this.lblName);
            this.panelAddEmployee.Controls.Add(this.btnAdd);
            this.panelAddEmployee.Controls.Add(this.txtName);
            this.panelAddEmployee.Controls.Add(this.btnBrowse);
            this.panelAddEmployee.Location = new System.Drawing.Point(149, 15);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(1234, 365);
            this.panelAddEmployee.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(914, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 33);
            this.comboBox1.TabIndex = 15;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTakePhoto.Location = new System.Drawing.Point(1019, 145);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(101, 46);
            this.btnTakePhoto.TabIndex = 14;
            this.btnTakePhoto.Text = "Take Photo";
            this.btnTakePhoto.UseVisualStyleBackColor = true;
            this.btnTakePhoto.Click += new System.EventHandler(this.btnTakePhoto_Click);
            // 
            // btnStartCam
            // 
            this.btnStartCam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStartCam.Location = new System.Drawing.Point(1019, 84);
            this.btnStartCam.Name = "btnStartCam";
            this.btnStartCam.Size = new System.Drawing.Size(101, 46);
            this.btnStartCam.TabIndex = 12;
            this.btnStartCam.Text = "Start Cam";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
            // 
            // checkedDepartment
            // 
            this.checkedDepartment.CheckOnClick = true;
            this.checkedDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedDepartment.FormattingEnabled = true;
            this.checkedDepartment.Items.AddRange(new object[] {
            "Sales",
            "Manager",
            "Assistant Manager"});
            this.checkedDepartment.Location = new System.Drawing.Point(61, 193);
            this.checkedDepartment.Name = "checkedDepartment";
            this.checkedDepartment.Size = new System.Drawing.Size(273, 96);
            this.checkedDepartment.TabIndex = 11;
            this.checkedDepartment.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedDepartment_ItemCheck);
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(56, 162);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(138, 29);
            this.lblDepartment.TabIndex = 10;
            this.lblDepartment.Text = "Department";
            // 
            // dgvAddEmployee
            // 
            this.dgvAddEmployee.AllowUserToDeleteRows = false;
            this.dgvAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvAddEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddEmployee.Location = new System.Drawing.Point(12, 389);
            this.dgvAddEmployee.Name = "dgvAddEmployee";
            this.dgvAddEmployee.RowHeadersWidth = 51;
            this.dgvAddEmployee.RowTemplate.Height = 24;
            this.dgvAddEmployee.Size = new System.Drawing.Size(1508, 438);
            this.dgvAddEmployee.TabIndex = 10;
            this.dgvAddEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddEmployee_CellClick);
            this.dgvAddEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddEmployee_CellDoubleClick);
            this.dgvAddEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAddEmployee_KeyDown);
            // 
            // panelPayroll
            // 
            this.panelPayroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPayroll.Controls.Add(this.lblDepartmentPayroll);
            this.panelPayroll.Controls.Add(this.btnCalculate);
            this.panelPayroll.Controls.Add(this.lblPay);
            this.panelPayroll.Controls.Add(this.numericPay);
            this.panelPayroll.Controls.Add(this.numericDeductions);
            this.panelPayroll.Controls.Add(this.lblDeductions);
            this.panelPayroll.Controls.Add(this.numericDiscount);
            this.panelPayroll.Controls.Add(this.btnDiscount);
            this.panelPayroll.Controls.Add(this.numericAbsence);
            this.panelPayroll.Controls.Add(this.lblAbsence);
            this.panelPayroll.Controls.Add(this.numericPerceptions);
            this.panelPayroll.Controls.Add(this.lblPerceptions);
            this.panelPayroll.Controls.Add(this.numericBonus);
            this.panelPayroll.Controls.Add(this.numericHoliday);
            this.panelPayroll.Controls.Add(this.numericRestDay);
            this.panelPayroll.Controls.Add(this.numericHours);
            this.panelPayroll.Controls.Add(this.lblBonus);
            this.panelPayroll.Controls.Add(this.lblHoliday);
            this.panelPayroll.Controls.Add(this.lblRestDay);
            this.panelPayroll.Controls.Add(this.lblHours);
            this.panelPayroll.Controls.Add(this.numericSalaryPayroll);
            this.panelPayroll.Controls.Add(this.pbxPayroll);
            this.panelPayroll.Controls.Add(this.lblSalaryPayroll);
            this.panelPayroll.Controls.Add(this.lblNamePayroll);
            this.panelPayroll.Controls.Add(this.txtNamePayroll);
            this.panelPayroll.Location = new System.Drawing.Point(146, 12);
            this.panelPayroll.Name = "panelPayroll";
            this.panelPayroll.Size = new System.Drawing.Size(1240, 371);
            this.panelPayroll.TabIndex = 11;
            // 
            // lblDepartmentPayroll
            // 
            this.lblDepartmentPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPayroll.Location = new System.Drawing.Point(29, 295);
            this.lblDepartmentPayroll.Name = "lblDepartmentPayroll";
            this.lblDepartmentPayroll.Size = new System.Drawing.Size(180, 29);
            this.lblDepartmentPayroll.TabIndex = 25;
            this.lblDepartmentPayroll.Text = "Department";
            this.lblDepartmentPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(889, 252);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 43);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate Payroll";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.Red;
            this.lblPay.Location = new System.Drawing.Point(824, 310);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(73, 29);
            this.lblPay.TabIndex = 24;
            this.lblPay.Text = "Pay =";
            // 
            // numericPay
            // 
            this.numericPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPay.ForeColor = System.Drawing.Color.Red;
            this.numericPay.Location = new System.Drawing.Point(903, 310);
            this.numericPay.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericPay.Name = "numericPay";
            this.numericPay.ReadOnly = true;
            this.numericPay.Size = new System.Drawing.Size(204, 30);
            this.numericPay.TabIndex = 23;
            // 
            // numericDeductions
            // 
            this.numericDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDeductions.Location = new System.Drawing.Point(1036, 181);
            this.numericDeductions.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericDeductions.Name = "numericDeductions";
            this.numericDeductions.ReadOnly = true;
            this.numericDeductions.Size = new System.Drawing.Size(204, 30);
            this.numericDeductions.TabIndex = 22;
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductions.Location = new System.Drawing.Point(824, 182);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(221, 29);
            this.lblDeductions.TabIndex = 21;
            this.lblDeductions.Text = "Total Deductions = ";
            // 
            // numericDiscount
            // 
            this.numericDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Location = new System.Drawing.Point(829, 128);
            this.numericDiscount.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericDiscount.Name = "numericDiscount";
            this.numericDiscount.Size = new System.Drawing.Size(204, 30);
            this.numericDiscount.TabIndex = 20;
            // 
            // btnDiscount
            // 
            this.btnDiscount.AutoSize = true;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.Location = new System.Drawing.Point(824, 96);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(278, 29);
            this.btnDiscount.TabIndex = 19;
            this.btnDiscount.Text = "Other Discounts (Money)";
            // 
            // numericAbsence
            // 
            this.numericAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAbsence.Location = new System.Drawing.Point(829, 46);
            this.numericAbsence.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericAbsence.Name = "numericAbsence";
            this.numericAbsence.Size = new System.Drawing.Size(204, 30);
            this.numericAbsence.TabIndex = 18;
            // 
            // lblAbsence
            // 
            this.lblAbsence.AutoSize = true;
            this.lblAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsence.Location = new System.Drawing.Point(824, 14);
            this.lblAbsence.Name = "lblAbsence";
            this.lblAbsence.Size = new System.Drawing.Size(193, 29);
            this.lblAbsence.TabIndex = 17;
            this.lblAbsence.Text = "Absence (Hours)";
            // 
            // numericPerceptions
            // 
            this.numericPerceptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPerceptions.Location = new System.Drawing.Point(499, 311);
            this.numericPerceptions.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericPerceptions.Name = "numericPerceptions";
            this.numericPerceptions.ReadOnly = true;
            this.numericPerceptions.Size = new System.Drawing.Size(204, 30);
            this.numericPerceptions.TabIndex = 16;
            // 
            // lblPerceptions
            // 
            this.lblPerceptions.AutoSize = true;
            this.lblPerceptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerceptions.Location = new System.Drawing.Point(275, 312);
            this.lblPerceptions.Name = "lblPerceptions";
            this.lblPerceptions.Size = new System.Drawing.Size(229, 29);
            this.lblPerceptions.TabIndex = 15;
            this.lblPerceptions.Text = "Total Perceptions = ";
            // 
            // numericBonus
            // 
            this.numericBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBonus.Location = new System.Drawing.Point(280, 265);
            this.numericBonus.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericBonus.Name = "numericBonus";
            this.numericBonus.ReadOnly = true;
            this.numericBonus.Size = new System.Drawing.Size(204, 30);
            this.numericBonus.TabIndex = 14;
            // 
            // numericHoliday
            // 
            this.numericHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHoliday.Location = new System.Drawing.Point(280, 196);
            this.numericHoliday.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericHoliday.Name = "numericHoliday";
            this.numericHoliday.Size = new System.Drawing.Size(204, 30);
            this.numericHoliday.TabIndex = 13;
            // 
            // numericRestDay
            // 
            this.numericRestDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericRestDay.Location = new System.Drawing.Point(280, 122);
            this.numericRestDay.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericRestDay.Name = "numericRestDay";
            this.numericRestDay.Size = new System.Drawing.Size(204, 30);
            this.numericRestDay.TabIndex = 12;
            // 
            // numericHours
            // 
            this.numericHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHours.Location = new System.Drawing.Point(280, 46);
            this.numericHours.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericHours.Name = "numericHours";
            this.numericHours.Size = new System.Drawing.Size(204, 30);
            this.numericHours.TabIndex = 11;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(275, 233);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(330, 29);
            this.lblBonus.TabIndex = 10;
            this.lblBonus.Text = "Bonus (% From HourWorked)";
            // 
            // lblHoliday
            // 
            this.lblHoliday.AutoSize = true;
            this.lblHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoliday.Location = new System.Drawing.Point(275, 164);
            this.lblHoliday.Name = "lblHoliday";
            this.lblHoliday.Size = new System.Drawing.Size(270, 29);
            this.lblHoliday.TabIndex = 9;
            this.lblHoliday.Text = "Holiday Worked (Hours)";
            // 
            // lblRestDay
            // 
            this.lblRestDay.AutoSize = true;
            this.lblRestDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestDay.Location = new System.Drawing.Point(275, 87);
            this.lblRestDay.Name = "lblRestDay";
            this.lblRestDay.Size = new System.Drawing.Size(285, 29);
            this.lblRestDay.TabIndex = 8;
            this.lblRestDay.Text = "Rest Day Worked (Hours)";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(275, 14);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(167, 29);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours Worked";
            // 
            // numericSalaryPayroll
            // 
            this.numericSalaryPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSalaryPayroll.Location = new System.Drawing.Point(22, 128);
            this.numericSalaryPayroll.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.numericSalaryPayroll.Name = "numericSalaryPayroll";
            this.numericSalaryPayroll.ReadOnly = true;
            this.numericSalaryPayroll.Size = new System.Drawing.Size(204, 30);
            this.numericSalaryPayroll.TabIndex = 5;
            // 
            // pbxPayroll
            // 
            this.pbxPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPayroll.Location = new System.Drawing.Point(22, 165);
            this.pbxPayroll.Name = "pbxPayroll";
            this.pbxPayroll.Size = new System.Drawing.Size(204, 127);
            this.pbxPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPayroll.TabIndex = 4;
            this.pbxPayroll.TabStop = false;
            // 
            // lblSalaryPayroll
            // 
            this.lblSalaryPayroll.AutoSize = true;
            this.lblSalaryPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPayroll.Location = new System.Drawing.Point(17, 96);
            this.lblSalaryPayroll.Name = "lblSalaryPayroll";
            this.lblSalaryPayroll.Size = new System.Drawing.Size(180, 29);
            this.lblSalaryPayroll.TabIndex = 2;
            this.lblSalaryPayroll.Text = "Salary per Hour";
            // 
            // lblNamePayroll
            // 
            this.lblNamePayroll.AutoSize = true;
            this.lblNamePayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePayroll.Location = new System.Drawing.Point(17, 25);
            this.lblNamePayroll.Name = "lblNamePayroll";
            this.lblNamePayroll.Size = new System.Drawing.Size(78, 29);
            this.lblNamePayroll.TabIndex = 1;
            this.lblNamePayroll.Text = "Name";
            // 
            // txtNamePayroll
            // 
            this.txtNamePayroll.Location = new System.Drawing.Point(22, 59);
            this.txtNamePayroll.Name = "txtNamePayroll";
            this.txtNamePayroll.ReadOnly = true;
            this.txtNamePayroll.Size = new System.Drawing.Size(204, 22);
            this.txtNamePayroll.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.dgvAddEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnPayrollMenu);
            this.Controls.Add(this.panelPayroll);
            this.Controls.Add(this.panelAddEmployee);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.panelAddEmployee.ResumeLayout(false);
            this.panelAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddEmployee)).EndInit();
            this.panelPayroll.ResumeLayout(false);
            this.panelPayroll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDeductions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPerceptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalaryPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPayrollMenu;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelAddEmployee;
        private System.Windows.Forms.Panel panelPayroll;
        private System.Windows.Forms.TextBox txtNamePayroll;
        private System.Windows.Forms.PictureBox pbxPayroll;
        private System.Windows.Forms.Label lblSalaryPayroll;
        private System.Windows.Forms.Label lblNamePayroll;
        private System.Windows.Forms.NumericUpDown numericSalaryPayroll;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.NumericUpDown numericPay;
        private System.Windows.Forms.NumericUpDown numericDeductions;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.Label btnDiscount;
        private System.Windows.Forms.NumericUpDown numericAbsence;
        private System.Windows.Forms.Label lblAbsence;
        private System.Windows.Forms.NumericUpDown numericPerceptions;
        private System.Windows.Forms.Label lblPerceptions;
        private System.Windows.Forms.NumericUpDown numericHoliday;
        private System.Windows.Forms.NumericUpDown numericRestDay;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblHoliday;
        private System.Windows.Forms.Label lblRestDay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.NumericUpDown numericBonus;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.NumericUpDown numericSalary;
        public System.Windows.Forms.DataGridView dgvAddEmployee;
        public System.Windows.Forms.PictureBox pbxEmployee;
        public System.Windows.Forms.CheckedListBox checkedDepartment;
        private System.Windows.Forms.Label lblDepartmentPayroll;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

