namespace SmartGPA
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.year_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.semester_dropdown = new System.Windows.Forms.ComboBox();
            this.year_dropdown = new System.Windows.Forms.ComboBox();
            this.year_confirm = new System.Windows.Forms.Button();
            this.subject_panel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subject_button = new System.Windows.Forms.Button();
            this.grade_dropdown = new System.Windows.Forms.ComboBox();
            this.credit_dropdown = new System.Windows.Forms.ComboBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gpa_label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.year_panel.SuspendLayout();
            this.subject_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(306, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // year_panel
            // 
            this.year_panel.Controls.Add(this.label3);
            this.year_panel.Controls.Add(this.label2);
            this.year_panel.Controls.Add(this.label1);
            this.year_panel.Controls.Add(this.semester_dropdown);
            this.year_panel.Controls.Add(this.year_dropdown);
            this.year_panel.Controls.Add(this.year_confirm);
            this.year_panel.Location = new System.Drawing.Point(49, 24);
            this.year_panel.Name = "year_panel";
            this.year_panel.Size = new System.Drawing.Size(644, 138);
            this.year_panel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Semester";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Year and  Semester";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // semester_dropdown
            // 
            this.semester_dropdown.FormattingEnabled = true;
            this.semester_dropdown.Location = new System.Drawing.Point(443, 46);
            this.semester_dropdown.Name = "semester_dropdown";
            this.semester_dropdown.Size = new System.Drawing.Size(121, 21);
            this.semester_dropdown.TabIndex = 2;
            this.semester_dropdown.SelectedIndexChanged += new System.EventHandler(this.semester_dropdown_SelectedIndexChanged);
            // 
            // year_dropdown
            // 
            this.year_dropdown.FormattingEnabled = true;
            this.year_dropdown.Location = new System.Drawing.Point(168, 46);
            this.year_dropdown.Name = "year_dropdown";
            this.year_dropdown.Size = new System.Drawing.Size(121, 21);
            this.year_dropdown.TabIndex = 1;
            this.year_dropdown.SelectedIndexChanged += new System.EventHandler(this.year_dropdown_SelectedIndexChanged);
            // 
            // year_confirm
            // 
            this.year_confirm.BackColor = System.Drawing.SystemColors.Control;
            this.year_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_confirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.year_confirm.Location = new System.Drawing.Point(270, 87);
            this.year_confirm.Name = "year_confirm";
            this.year_confirm.Size = new System.Drawing.Size(94, 31);
            this.year_confirm.TabIndex = 0;
            this.year_confirm.Text = "Confirm";
            this.year_confirm.UseVisualStyleBackColor = false;
            this.year_confirm.Click += new System.EventHandler(this.year_confirm_Click);
            // 
            // subject_panel
            // 
            this.subject_panel.AutoScroll = true;
            this.subject_panel.AutoSize = true;
            this.subject_panel.Controls.Add(this.label6);
            this.subject_panel.Controls.Add(this.label5);
            this.subject_panel.Controls.Add(this.label4);
            this.subject_panel.Controls.Add(this.year_label);
            this.subject_panel.Controls.Add(this.dataGridView1);
            this.subject_panel.Controls.Add(this.subject_button);
            this.subject_panel.Controls.Add(this.grade_dropdown);
            this.subject_panel.Controls.Add(this.credit_dropdown);
            this.subject_panel.Controls.Add(this.name_input);
            this.subject_panel.Location = new System.Drawing.Point(49, 207);
            this.subject_panel.Name = "subject_panel";
            this.subject_panel.Size = new System.Drawing.Size(660, 288);
            this.subject_panel.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Model Name";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_label.Location = new System.Drawing.Point(298, 11);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(66, 24);
            this.year_label.TabIndex = 5;
            this.year_label.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(70, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 113);
            this.dataGridView1.TabIndex = 4;
            // 
            // subject_button
            // 
            this.subject_button.BackColor = System.Drawing.SystemColors.Control;
            this.subject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subject_button.Location = new System.Drawing.Point(289, 132);
            this.subject_button.Name = "subject_button";
            this.subject_button.Size = new System.Drawing.Size(75, 24);
            this.subject_button.TabIndex = 3;
            this.subject_button.Text = "Add";
            this.subject_button.UseVisualStyleBackColor = false;
            this.subject_button.Click += new System.EventHandler(this.subject_button_Click);
            // 
            // grade_dropdown
            // 
            this.grade_dropdown.FormattingEnabled = true;
            this.grade_dropdown.Location = new System.Drawing.Point(413, 94);
            this.grade_dropdown.Name = "grade_dropdown";
            this.grade_dropdown.Size = new System.Drawing.Size(121, 21);
            this.grade_dropdown.TabIndex = 2;
            this.grade_dropdown.SelectedIndexChanged += new System.EventHandler(this.grade_dropdown_SelectedIndexChanged);
            // 
            // credit_dropdown
            // 
            this.credit_dropdown.FormattingEnabled = true;
            this.credit_dropdown.Location = new System.Drawing.Point(168, 94);
            this.credit_dropdown.Name = "credit_dropdown";
            this.credit_dropdown.Size = new System.Drawing.Size(121, 21);
            this.credit_dropdown.TabIndex = 1;
            this.credit_dropdown.SelectedIndexChanged += new System.EventHandler(this.credit_dropdown_SelectedIndexChanged);
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(168, 49);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(366, 20);
            this.name_input.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.gpa_label);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.year_panel);
            this.panel2.Controls.Add(this.subject_panel);
            this.panel2.Location = new System.Drawing.Point(-51, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 498);
            this.panel2.TabIndex = 4;
            // 
            // gpa_label
            // 
            this.gpa_label.AutoSize = true;
            this.gpa_label.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_label.ForeColor = System.Drawing.Color.Navy;
            this.gpa_label.Location = new System.Drawing.Point(373, 0);
            this.gpa_label.Name = "gpa_label";
            this.gpa_label.Size = new System.Drawing.Size(0, 29);
            this.gpa_label.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form2";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.year_panel.ResumeLayout(false);
            this.year_panel.PerformLayout();
            this.subject_panel.ResumeLayout(false);
            this.subject_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel year_panel;
        private System.Windows.Forms.Panel subject_panel;
        private System.Windows.Forms.Button year_confirm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button subject_button;
        private System.Windows.Forms.ComboBox grade_dropdown;
        private System.Windows.Forms.ComboBox credit_dropdown;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.ComboBox semester_dropdown;
        private System.Windows.Forms.ComboBox year_dropdown;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label gpa_label;
    }
}