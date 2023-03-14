namespace SmartGPA
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
            this.button1 = new System.Windows.Forms.Button();
            this.submit_button = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.name_input = new System.Windows.Forms.TextBox();
            this.credit_dropdown = new System.Windows.Forms.ComboBox();
            this.grade_dropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpa_label = new System.Windows.Forms.Label();
            this.submit_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // submit_button
            // 
            this.submit_button.Controls.Add(this.gpa_label);
            this.submit_button.Controls.Add(this.dataGridView1);
            this.submit_button.Controls.Add(this.button2);
            this.submit_button.Controls.Add(this.name_input);
            this.submit_button.Controls.Add(this.credit_dropdown);
            this.submit_button.Controls.Add(this.grade_dropdown);
            this.submit_button.Controls.Add(this.label1);
            this.submit_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.submit_button.Location = new System.Drawing.Point(0, 0);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(800, 450);
            this.submit_button.TabIndex = 1;
            this.submit_button.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(183, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 38);
            this.button2.TabIndex = 4;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // name_input
            // 
            this.name_input.Location = new System.Drawing.Point(194, 59);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(188, 20);
            this.name_input.TabIndex = 3;
            // 
            // credit_dropdown
            // 
            this.credit_dropdown.FormattingEnabled = true;
            this.credit_dropdown.Location = new System.Drawing.Point(456, 59);
            this.credit_dropdown.Name = "credit_dropdown";
            this.credit_dropdown.Size = new System.Drawing.Size(121, 21);
            this.credit_dropdown.TabIndex = 2;
            this.credit_dropdown.SelectedIndexChanged += new System.EventHandler(this.credit_dropdown_SelectedIndexChanged);
            // 
            // grade_dropdown
            // 
            this.grade_dropdown.FormattingEnabled = true;
            this.grade_dropdown.Location = new System.Drawing.Point(602, 59);
            this.grade_dropdown.Name = "grade_dropdown";
            this.grade_dropdown.Size = new System.Drawing.Size(121, 21);
            this.grade_dropdown.TabIndex = 1;
            this.grade_dropdown.SelectedIndexChanged += new System.EventHandler(this.grade_dropdown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // gpa_label
            // 
            this.gpa_label.AutoSize = true;
            this.gpa_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpa_label.Location = new System.Drawing.Point(385, 170);
            this.gpa_label.Name = "gpa_label";
            this.gpa_label.Size = new System.Drawing.Size(59, 25);
            this.gpa_label.TabIndex = 6;
            this.gpa_label.Text = "GPA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.submit_button.ResumeLayout(false);
            this.submit_button.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel submit_button;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.ComboBox credit_dropdown;
        private System.Windows.Forms.ComboBox grade_dropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label gpa_label;
    }
}

