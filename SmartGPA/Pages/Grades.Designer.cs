namespace SmartGPA.Pages
{
    partial class Grades
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subject_panel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.add_year = new System.Windows.Forms.Button();
            this.add_results = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.name_input = new System.Windows.Forms.TextBox();
            this.grade_dropdown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.credit_dropdown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.year_panel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.year_confirm = new System.Windows.Forms.Button();
            this.semester_dropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.year_dropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listPanel = new System.Windows.Forms.Panel();
            this.subject_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.year_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.listPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // subject_panel
            // 
            this.subject_panel.AutoSize = true;
            this.subject_panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.subject_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.subject_panel.Controls.Add(this.dataGridView1);
            this.subject_panel.Controls.Add(this.add_year);
            this.subject_panel.Controls.Add(this.add_results);
            this.subject_panel.Controls.Add(this.label6);
            this.subject_panel.Controls.Add(this.name_input);
            this.subject_panel.Controls.Add(this.grade_dropdown);
            this.subject_panel.Controls.Add(this.label5);
            this.subject_panel.Controls.Add(this.credit_dropdown);
            this.subject_panel.Controls.Add(this.label4);
            this.subject_panel.Controls.Add(this.year_label);
            this.subject_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subject_panel.Location = new System.Drawing.Point(0, 0);
            this.subject_panel.Name = "subject_panel";
            this.subject_panel.Size = new System.Drawing.Size(640, 433);
            this.subject_panel.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle91.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle91.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle91.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle91.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle91.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle91.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle91.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle91;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle98.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle98.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle98.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle98.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle98.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle98.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle98.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle98;
            this.dataGridView1.Location = new System.Drawing.Point(51, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle99.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle99.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle99.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle99.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle99.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle99.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle99;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Size = new System.Drawing.Size(531, 174);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // Column1
            // 
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle92;
            this.Column1.FillWeight = 128F;
            this.Column1.HeaderText = "Module Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle93;
            this.Column2.FillWeight = 68.88209F;
            this.Column2.HeaderText = "Credits";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle94;
            this.Column3.FillWeight = 68.88209F;
            this.Column3.HeaderText = "Grades";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle95.Format = "N1";
            dataGridViewCellStyle95.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle95;
            this.Column4.FillWeight = 68.88209F;
            this.Column4.HeaderText = "Points";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DefaultCellStyle = dataGridViewCellStyle96;
            this.Column5.FillWeight = 38.88209F;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Edit";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.DefaultCellStyle = dataGridViewCellStyle97;
            this.Column6.FillWeight = 38.88209F;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column6.Text = "Delete";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // add_year
            // 
            this.add_year.AutoSize = true;
            this.add_year.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_year.FlatAppearance.BorderSize = 0;
            this.add_year.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_year.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_year.ForeColor = System.Drawing.Color.White;
            this.add_year.Location = new System.Drawing.Point(58, 10);
            this.add_year.Name = "add_year";
            this.add_year.Size = new System.Drawing.Size(80, 29);
            this.add_year.TabIndex = 14;
            this.add_year.Text = "Add Year";
            this.add_year.UseVisualStyleBackColor = false;
            this.add_year.Click += new System.EventHandler(this.add_year_Click);
            // 
            // add_results
            // 
            this.add_results.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add_results.AutoSize = true;
            this.add_results.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.add_results.FlatAppearance.BorderSize = 0;
            this.add_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_results.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_results.ForeColor = System.Drawing.Color.White;
            this.add_results.Location = new System.Drawing.Point(259, 139);
            this.add_results.Name = "add_results";
            this.add_results.Size = new System.Drawing.Size(140, 33);
            this.add_results.TabIndex = 13;
            this.add_results.Text = "Add Results";
            this.add_results.UseVisualStyleBackColor = false;
            this.add_results.Click += new System.EventHandler(this.add_results_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(55, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model Name";
            // 
            // name_input
            // 
            this.name_input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(141, 81);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(143, 22);
            this.name_input.TabIndex = 11;
            // 
            // grade_dropdown
            // 
            this.grade_dropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grade_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade_dropdown.FormattingEnabled = true;
            this.grade_dropdown.Location = new System.Drawing.Point(510, 81);
            this.grade_dropdown.Name = "grade_dropdown";
            this.grade_dropdown.Size = new System.Drawing.Size(67, 23);
            this.grade_dropdown.TabIndex = 10;
            this.grade_dropdown.SelectedIndexChanged += new System.EventHandler(this.grade_dropdown_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(464, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grade";
            // 
            // credit_dropdown
            // 
            this.credit_dropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.credit_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_dropdown.FormattingEnabled = true;
            this.credit_dropdown.Location = new System.Drawing.Point(380, 81);
            this.credit_dropdown.Name = "credit_dropdown";
            this.credit_dropdown.Size = new System.Drawing.Size(60, 23);
            this.credit_dropdown.TabIndex = 8;
            this.credit_dropdown.SelectedIndexChanged += new System.EventHandler(this.credit_dropdown_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(328, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credits";
            // 
            // year_label
            // 
            this.year_label.Dock = System.Windows.Forms.DockStyle.Top;
            this.year_label.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_label.ForeColor = System.Drawing.Color.White;
            this.year_label.Location = new System.Drawing.Point(0, 0);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(640, 29);
            this.year_label.TabIndex = 4;
            this.year_label.Text = "Year 01 Semester 01 Results";
            this.year_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_panel
            // 
            this.year_panel.AutoSize = true;
            this.year_panel.Controls.Add(this.label8);
            this.year_panel.Controls.Add(this.panel1);
            this.year_panel.Controls.Add(this.listPanel);
            this.year_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.year_panel.Location = new System.Drawing.Point(0, 0);
            this.year_panel.Name = "year_panel";
            this.year_panel.Size = new System.Drawing.Size(640, 433);
            this.year_panel.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(233, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "View Results";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "All Reults Table";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.MouseEnter += new System.EventHandler(this.label7_MouseEnter);
            this.label7.MouseLeave += new System.EventHandler(this.label7_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.year_confirm);
            this.panel1.Controls.Add(this.semester_dropdown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.year_dropdown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(45, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 170);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Year and Semester";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // year_confirm
            // 
            this.year_confirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.year_confirm.AutoSize = true;
            this.year_confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.year_confirm.FlatAppearance.BorderSize = 0;
            this.year_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.year_confirm.Font = new System.Drawing.Font("Montserrat Medium", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_confirm.ForeColor = System.Drawing.Color.White;
            this.year_confirm.Location = new System.Drawing.Point(193, 112);
            this.year_confirm.Name = "year_confirm";
            this.year_confirm.Size = new System.Drawing.Size(137, 37);
            this.year_confirm.TabIndex = 1;
            this.year_confirm.Text = "Confirm";
            this.year_confirm.UseVisualStyleBackColor = false;
            this.year_confirm.Click += new System.EventHandler(this.year_confirm_Click);
            // 
            // semester_dropdown
            // 
            this.semester_dropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.semester_dropdown.FormattingEnabled = true;
            this.semester_dropdown.Location = new System.Drawing.Point(372, 67);
            this.semester_dropdown.Name = "semester_dropdown";
            this.semester_dropdown.Size = new System.Drawing.Size(134, 21);
            this.semester_dropdown.TabIndex = 6;
            this.semester_dropdown.SelectedIndexChanged += new System.EventHandler(this.semester_dropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Year";
            // 
            // year_dropdown
            // 
            this.year_dropdown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.year_dropdown.FormattingEnabled = true;
            this.year_dropdown.Location = new System.Drawing.Point(88, 67);
            this.year_dropdown.Name = "year_dropdown";
            this.year_dropdown.Size = new System.Drawing.Size(150, 21);
            this.year_dropdown.TabIndex = 5;
            this.year_dropdown.SelectedIndexChanged += new System.EventHandler(this.year_dropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(292, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Semester";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listPanel
            // 
            this.listPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listPanel.AutoSize = true;
            this.listPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.listPanel.Controls.Add(this.label7);
            this.listPanel.Location = new System.Drawing.Point(202, 225);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(362, 162);
            this.listPanel.TabIndex = 10;
            // 
            // Grades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(640, 433);
            this.Controls.Add(this.year_panel);
            this.Controls.Add(this.subject_panel);
            this.Name = "Grades";
            this.Text = "Grades";
            this.Load += new System.EventHandler(this.Grades_Load);
            this.subject_panel.ResumeLayout(false);
            this.subject_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.year_panel.ResumeLayout(false);
            this.year_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.listPanel.ResumeLayout(false);
            this.listPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel subject_panel;
        private System.Windows.Forms.Button year_confirm;
        private System.Windows.Forms.Panel year_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox semester_dropdown;
        private System.Windows.Forms.ComboBox year_dropdown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.ComboBox credit_dropdown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox grade_dropdown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_year;
        private System.Windows.Forms.Button add_results;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listPanel;
    }
}