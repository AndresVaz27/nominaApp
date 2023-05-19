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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTakePhoto = new System.Windows.Forms.Button();
            this.btnStartCam = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dgvAddEmployee = new System.Windows.Forms.DataGridView();
            this.panelPayroll = new System.Windows.Forms.Panel();
            this.lblBonusValue = new System.Windows.Forms.Label();
            this.lblTotalDeductionsValue = new System.Windows.Forms.Label();
            this.lblTotalPerceptionsValue = new System.Windows.Forms.Label();
            this.lblDepartmentPayroll = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.numericDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnDiscount = new System.Windows.Forms.Label();
            this.numericAbsence = new System.Windows.Forms.NumericUpDown();
            this.lblAbsence = new System.Windows.Forms.Label();
            this.lblPerceptions = new System.Windows.Forms.Label();
            this.numericHoliday = new System.Windows.Forms.NumericUpDown();
            this.numericRestDay = new System.Windows.Forms.NumericUpDown();
            this.numericHours = new System.Windows.Forms.NumericUpDown();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblHoliday = new System.Windows.Forms.Label();
            this.lblRestDay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.pbxPayroll = new System.Windows.Forms.PictureBox();
            this.lblSalaryPayroll = new System.Windows.Forms.Label();
            this.lblNamePayroll = new System.Windows.Forms.Label();
            this.txtNamePayroll = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblPayValue = new System.Windows.Forms.Label();
            this.lblNumeroEnLetras = new System.Windows.Forms.Label();
            this.lblSalaryPayrollValue = new System.Windows.Forms.Label();
            this.lblFace1 = new System.Windows.Forms.Label();
            this.lblFace3 = new System.Windows.Forms.Label();
            this.lblFace2 = new System.Windows.Forms.Label();
            this.lblFace4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.panelAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddEmployee)).BeginInit();
            this.panelPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbsence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoliday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayroll)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPayrollMenu
            // 
            this.btnPayrollMenu.Location = new System.Drawing.Point(12, 12);
            this.btnPayrollMenu.Name = "btnPayrollMenu";
            this.btnPayrollMenu.Size = new System.Drawing.Size(128, 91);
            this.btnPayrollMenu.TabIndex = 9;
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
            this.btnAddEmployee.TabIndex = 10;
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
            this.txtName.TabIndex = 1;
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
            this.btnBrowse.Location = new System.Drawing.Point(676, 281);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(101, 46);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbxEmployee
            // 
            this.pbxEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbxEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxEmployee.Location = new System.Drawing.Point(607, 45);
            this.pbxEmployee.Name = "pbxEmployee";
            this.pbxEmployee.Size = new System.Drawing.Size(230, 220);
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
            this.numericSalary.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(395, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 91);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelAddEmployee
            // 
            this.panelAddEmployee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelAddEmployee.Controls.Add(this.lblFace3);
            this.panelAddEmployee.Controls.Add(this.lblFace1);
            this.panelAddEmployee.Controls.Add(this.comboBox2);
            this.panelAddEmployee.Controls.Add(this.comboBox1);
            this.panelAddEmployee.Controls.Add(this.btnTakePhoto);
            this.panelAddEmployee.Controls.Add(this.btnStartCam);
            this.panelAddEmployee.Controls.Add(this.lblDepartment);
            this.panelAddEmployee.Controls.Add(this.lblSalary);
            this.panelAddEmployee.Controls.Add(this.numericSalary);
            this.panelAddEmployee.Controls.Add(this.lblName);
            this.panelAddEmployee.Controls.Add(this.btnAdd);
            this.panelAddEmployee.Controls.Add(this.txtName);
            this.panelAddEmployee.Controls.Add(this.btnBrowse);
            this.panelAddEmployee.Controls.Add(this.lblFace2);
            this.panelAddEmployee.Controls.Add(this.lblFace4);
            this.panelAddEmployee.Controls.Add(this.pbxEmployee);
            this.panelAddEmployee.Location = new System.Drawing.Point(149, 15);
            this.panelAddEmployee.Name = "panelAddEmployee";
            this.panelAddEmployee.Size = new System.Drawing.Size(1234, 365);
            this.panelAddEmployee.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(61, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(273, 33);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(914, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 33);
            this.comboBox1.TabIndex = 4;
            // 
            // btnTakePhoto
            // 
            this.btnTakePhoto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTakePhoto.Location = new System.Drawing.Point(1019, 145);
            this.btnTakePhoto.Name = "btnTakePhoto";
            this.btnTakePhoto.Size = new System.Drawing.Size(101, 46);
            this.btnTakePhoto.TabIndex = 6;
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
            this.btnStartCam.TabIndex = 5;
            this.btnStartCam.Text = "Start Cam";
            this.btnStartCam.UseVisualStyleBackColor = true;
            this.btnStartCam.Click += new System.EventHandler(this.btnStartCam_Click);
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
            this.dgvAddEmployee.ReadOnly = true;
            this.dgvAddEmployee.RowHeadersWidth = 51;
            this.dgvAddEmployee.RowTemplate.Height = 24;
            this.dgvAddEmployee.Size = new System.Drawing.Size(1508, 414);
            this.dgvAddEmployee.TabIndex = 10;
            this.dgvAddEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddEmployee_CellDoubleClick);
            this.dgvAddEmployee.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvAddEmployee_RowsRemoved);
            this.dgvAddEmployee.SelectionChanged += new System.EventHandler(this.dgvAddEmployee_SelectionChanged);
            this.dgvAddEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAddEmployee_KeyDown);
            // 
            // panelPayroll
            // 
            this.panelPayroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelPayroll.Controls.Add(this.lblSalaryPayrollValue);
            this.panelPayroll.Controls.Add(this.lblBonusValue);
            this.panelPayroll.Controls.Add(this.lblTotalDeductionsValue);
            this.panelPayroll.Controls.Add(this.lblTotalPerceptionsValue);
            this.panelPayroll.Controls.Add(this.lblDepartmentPayroll);
            this.panelPayroll.Controls.Add(this.btnModify);
            this.panelPayroll.Controls.Add(this.lblDeductions);
            this.panelPayroll.Controls.Add(this.numericDiscount);
            this.panelPayroll.Controls.Add(this.btnDiscount);
            this.panelPayroll.Controls.Add(this.numericAbsence);
            this.panelPayroll.Controls.Add(this.lblAbsence);
            this.panelPayroll.Controls.Add(this.lblPerceptions);
            this.panelPayroll.Controls.Add(this.numericHoliday);
            this.panelPayroll.Controls.Add(this.numericRestDay);
            this.panelPayroll.Controls.Add(this.numericHours);
            this.panelPayroll.Controls.Add(this.lblBonus);
            this.panelPayroll.Controls.Add(this.lblHoliday);
            this.panelPayroll.Controls.Add(this.lblRestDay);
            this.panelPayroll.Controls.Add(this.lblHours);
            this.panelPayroll.Controls.Add(this.pbxPayroll);
            this.panelPayroll.Controls.Add(this.lblSalaryPayroll);
            this.panelPayroll.Controls.Add(this.lblNamePayroll);
            this.panelPayroll.Controls.Add(this.txtNamePayroll);
            this.panelPayroll.Location = new System.Drawing.Point(146, 12);
            this.panelPayroll.Name = "panelPayroll";
            this.panelPayroll.Size = new System.Drawing.Size(1240, 371);
            this.panelPayroll.TabIndex = 11;
            // 
            // lblBonusValue
            // 
            this.lblBonusValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonusValue.Location = new System.Drawing.Point(437, 263);
            this.lblBonusValue.Name = "lblBonusValue";
            this.lblBonusValue.Size = new System.Drawing.Size(209, 29);
            this.lblBonusValue.TabIndex = 28;
            this.lblBonusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBonusValue.Visible = false;
            // 
            // lblTotalDeductionsValue
            // 
            this.lblTotalDeductionsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeductionsValue.Location = new System.Drawing.Point(1043, 312);
            this.lblTotalDeductionsValue.Name = "lblTotalDeductionsValue";
            this.lblTotalDeductionsValue.Size = new System.Drawing.Size(121, 29);
            this.lblTotalDeductionsValue.TabIndex = 27;
            // 
            // lblTotalPerceptionsValue
            // 
            this.lblTotalPerceptionsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPerceptionsValue.Location = new System.Drawing.Point(672, 312);
            this.lblTotalPerceptionsValue.Name = "lblTotalPerceptionsValue";
            this.lblTotalPerceptionsValue.Size = new System.Drawing.Size(95, 29);
            this.lblTotalPerceptionsValue.TabIndex = 26;
            // 
            // lblDepartmentPayroll
            // 
            this.lblDepartmentPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentPayroll.Location = new System.Drawing.Point(220, 263);
            this.lblDepartmentPayroll.Name = "lblDepartmentPayroll";
            this.lblDepartmentPayroll.Size = new System.Drawing.Size(180, 29);
            this.lblDepartmentPayroll.TabIndex = 25;
            this.lblDepartmentPayroll.Text = "Department";
            this.lblDepartmentPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1142, 122);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(92, 67);
            this.btnModify.TabIndex = 12;
            this.btnModify.Text = "Modify Employee";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeductions.Location = new System.Drawing.Point(824, 312);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(221, 29);
            this.lblDeductions.TabIndex = 21;
            this.lblDeductions.Text = "Total Deductions = ";
            this.lblDeductions.Visible = false;
            // 
            // numericDiscount
            // 
            this.numericDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDiscount.Location = new System.Drawing.Point(825, 196);
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
            this.btnDiscount.Location = new System.Drawing.Point(824, 164);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(278, 29);
            this.btnDiscount.TabIndex = 19;
            this.btnDiscount.Text = "Other Discounts (Money)";
            // 
            // numericAbsence
            // 
            this.numericAbsence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericAbsence.Location = new System.Drawing.Point(829, 122);
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
            this.lblAbsence.Location = new System.Drawing.Point(824, 87);
            this.lblAbsence.Name = "lblAbsence";
            this.lblAbsence.Size = new System.Drawing.Size(193, 29);
            this.lblAbsence.TabIndex = 17;
            this.lblAbsence.Text = "Absence (Hours)";
            // 
            // lblPerceptions
            // 
            this.lblPerceptions.AutoSize = true;
            this.lblPerceptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerceptions.Location = new System.Drawing.Point(437, 312);
            this.lblPerceptions.Name = "lblPerceptions";
            this.lblPerceptions.Size = new System.Drawing.Size(229, 29);
            this.lblPerceptions.TabIndex = 15;
            this.lblPerceptions.Text = "Total Perceptions = ";
            this.lblPerceptions.Visible = false;
            // 
            // numericHoliday
            // 
            this.numericHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericHoliday.Location = new System.Drawing.Point(442, 201);
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
            this.numericRestDay.Location = new System.Drawing.Point(442, 122);
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
            this.numericHours.Location = new System.Drawing.Point(442, 49);
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
            this.lblBonus.Location = new System.Drawing.Point(437, 234);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(330, 29);
            this.lblBonus.TabIndex = 10;
            this.lblBonus.Text = "Bonus (% From HourWorked)";
            this.lblBonus.Visible = false;
            // 
            // lblHoliday
            // 
            this.lblHoliday.AutoSize = true;
            this.lblHoliday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoliday.Location = new System.Drawing.Point(437, 164);
            this.lblHoliday.Name = "lblHoliday";
            this.lblHoliday.Size = new System.Drawing.Size(270, 29);
            this.lblHoliday.TabIndex = 9;
            this.lblHoliday.Text = "Holiday Worked (Hours)";
            // 
            // lblRestDay
            // 
            this.lblRestDay.AutoSize = true;
            this.lblRestDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestDay.Location = new System.Drawing.Point(437, 87);
            this.lblRestDay.Name = "lblRestDay";
            this.lblRestDay.Size = new System.Drawing.Size(285, 29);
            this.lblRestDay.TabIndex = 8;
            this.lblRestDay.Text = "Rest Day Worked (Hours)";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(437, 17);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(167, 29);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours Worked";
            // 
            // pbxPayroll
            // 
            this.pbxPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPayroll.Location = new System.Drawing.Point(192, 38);
            this.pbxPayroll.Name = "pbxPayroll";
            this.pbxPayroll.Size = new System.Drawing.Size(230, 220);
            this.pbxPayroll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPayroll.TabIndex = 4;
            this.pbxPayroll.TabStop = false;
            // 
            // lblSalaryPayroll
            // 
            this.lblSalaryPayroll.AutoSize = true;
            this.lblSalaryPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPayroll.Location = new System.Drawing.Point(6, 165);
            this.lblSalaryPayroll.Name = "lblSalaryPayroll";
            this.lblSalaryPayroll.Size = new System.Drawing.Size(180, 29);
            this.lblSalaryPayroll.TabIndex = 2;
            this.lblSalaryPayroll.Text = "Salary per Hour";
            // 
            // lblNamePayroll
            // 
            this.lblNamePayroll.AutoSize = true;
            this.lblNamePayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePayroll.Location = new System.Drawing.Point(6, 87);
            this.lblNamePayroll.Name = "lblNamePayroll";
            this.lblNamePayroll.Size = new System.Drawing.Size(78, 29);
            this.lblNamePayroll.TabIndex = 1;
            this.lblNamePayroll.Text = "Name";
            // 
            // txtNamePayroll
            // 
            this.txtNamePayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePayroll.Location = new System.Drawing.Point(11, 122);
            this.txtNamePayroll.Name = "txtNamePayroll";
            this.txtNamePayroll.ReadOnly = true;
            this.txtNamePayroll.Size = new System.Drawing.Size(157, 30);
            this.txtNamePayroll.TabIndex = 0;
            // 
            // lblPay
            // 
            this.lblPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.Red;
            this.lblPay.Location = new System.Drawing.Point(539, 806);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(73, 29);
            this.lblPay.TabIndex = 24;
            this.lblPay.Text = "Pay =";
            // 
            // lblPayValue
            // 
            this.lblPayValue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayValue.ForeColor = System.Drawing.Color.Red;
            this.lblPayValue.Location = new System.Drawing.Point(618, 806);
            this.lblPayValue.Name = "lblPayValue";
            this.lblPayValue.Size = new System.Drawing.Size(137, 29);
            this.lblPayValue.TabIndex = 25;
            this.lblPayValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumeroEnLetras
            // 
            this.lblNumeroEnLetras.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblNumeroEnLetras.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroEnLetras.ForeColor = System.Drawing.Color.Red;
            this.lblNumeroEnLetras.Location = new System.Drawing.Point(761, 806);
            this.lblNumeroEnLetras.Name = "lblNumeroEnLetras";
            this.lblNumeroEnLetras.Size = new System.Drawing.Size(725, 29);
            this.lblNumeroEnLetras.TabIndex = 26;
            this.lblNumeroEnLetras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalaryPayrollValue
            // 
            this.lblSalaryPayrollValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryPayrollValue.Location = new System.Drawing.Point(6, 197);
            this.lblSalaryPayrollValue.Name = "lblSalaryPayrollValue";
            this.lblSalaryPayrollValue.Size = new System.Drawing.Size(162, 29);
            this.lblSalaryPayrollValue.TabIndex = 29;
            // 
            // lblFace1
            // 
            this.lblFace1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFace1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFace1.Location = new System.Drawing.Point(612, 60);
            this.lblFace1.Name = "lblFace1";
            this.lblFace1.Size = new System.Drawing.Size(222, 53);
            this.lblFace1.TabIndex = 11;
            this.lblFace1.Text = "Center your face in here.";
            this.lblFace1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblFace1.Visible = false;
            // 
            // lblFace3
            // 
            this.lblFace3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFace3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFace3.Location = new System.Drawing.Point(612, 183);
            this.lblFace3.Name = "lblFace3";
            this.lblFace3.Size = new System.Drawing.Size(222, 77);
            this.lblFace3.TabIndex = 12;
            this.lblFace3.Text = "Center your face in here.";
            this.lblFace3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFace3.Visible = false;
            // 
            // lblFace2
            // 
            this.lblFace2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFace2.BackColor = System.Drawing.Color.Transparent;
            this.lblFace2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFace2.Location = new System.Drawing.Point(778, 113);
            this.lblFace2.Name = "lblFace2";
            this.lblFace2.Size = new System.Drawing.Size(57, 142);
            this.lblFace2.TabIndex = 13;
            this.lblFace2.Visible = false;
            // 
            // lblFace4
            // 
            this.lblFace4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFace4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFace4.Location = new System.Drawing.Point(610, 113);
            this.lblFace4.Name = "lblFace4";
            this.lblFace4.Size = new System.Drawing.Size(53, 142);
            this.lblFace4.TabIndex = 14;
            this.lblFace4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 853);
            this.Controls.Add(this.lblNumeroEnLetras);
            this.Controls.Add(this.lblPayValue);
            this.Controls.Add(this.dgvAddEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.btnPayrollMenu);
            this.Controls.Add(this.panelAddEmployee);
            this.Controls.Add(this.panelPayroll);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAbsence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoliday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRestDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPayroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.NumericUpDown numericDiscount;
        private System.Windows.Forms.Label btnDiscount;
        private System.Windows.Forms.NumericUpDown numericAbsence;
        private System.Windows.Forms.Label lblAbsence;
        private System.Windows.Forms.Label lblPerceptions;
        private System.Windows.Forms.NumericUpDown numericHoliday;
        private System.Windows.Forms.NumericUpDown numericRestDay;
        private System.Windows.Forms.NumericUpDown numericHours;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblHoliday;
        private System.Windows.Forms.Label lblRestDay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblDepartment;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.NumericUpDown numericSalary;
        public System.Windows.Forms.DataGridView dgvAddEmployee;
        public System.Windows.Forms.PictureBox pbxEmployee;
        private System.Windows.Forms.Label lblDepartmentPayroll;
        private System.Windows.Forms.Button btnTakePhoto;
        private System.Windows.Forms.Button btnStartCam;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblTotalDeductionsValue;
        private System.Windows.Forms.Label lblTotalPerceptionsValue;
        private System.Windows.Forms.Label lblPayValue;
        private System.Windows.Forms.Label lblBonusValue;
        private System.Windows.Forms.Label lblNumeroEnLetras;
        private System.Windows.Forms.Label lblSalaryPayrollValue;
        private System.Windows.Forms.Label lblFace4;
        private System.Windows.Forms.Label lblFace2;
        private System.Windows.Forms.Label lblFace3;
        private System.Windows.Forms.Label lblFace1;
    }
}

