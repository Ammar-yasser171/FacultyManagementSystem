namespace FacultyManagementSystem
{
    partial class Staff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            Code = new TextBox();
            label2 = new Label();
            Id = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            Salary = new TextBox();
            label3 = new Label();
            id2 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 32, 38);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(95, 205, 217);
            button1.Location = new Point(131, 128);
            button1.Name = "button1";
            button1.Size = new Size(170, 43);
            button1.TabIndex = 12;
            button1.Text = "Assign";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Code
            // 
            Code.Location = new Point(112, 90);
            Code.Name = "Code";
            Code.Size = new Size(224, 23);
            Code.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 70);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 10;
            label2.Text = "Department Code";
            // 
            // Id
            // 
            Id.Location = new Point(112, 44);
            Id.Name = "Id";
            Id.Size = new Size(224, 23);
            Id.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 26);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 8;
            label1.Text = "Staff ID";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(95, 205, 217);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(852, 202);
            dataGridView1.TabIndex = 7;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 32, 38);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(95, 205, 217);
            button2.Location = new Point(579, 128);
            button2.Name = "button2";
            button2.Size = new Size(170, 43);
            button2.TabIndex = 17;
            button2.Text = "Set";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Salary
            // 
            Salary.Location = new Point(560, 90);
            Salary.Name = "Salary";
            Salary.Size = new Size(224, 23);
            Salary.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(560, 70);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 15;
            label3.Text = "Salary";
            // 
            // id2
            // 
            id2.Location = new Point(560, 44);
            id2.Name = "id2";
            id2.Size = new Size(224, 23);
            id2.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(560, 26);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 13;
            label4.Text = "Staff ID";
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 191, 157);
            Controls.Add(button2);
            Controls.Add(Salary);
            Controls.Add(label3);
            Controls.Add(id2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(Code);
            Controls.Add(label2);
            Controls.Add(Id);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Staff";
            Size = new Size(858, 376);
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox Code;
        private Label label2;
        private TextBox Id;
        private Label label1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox Salary;
        private Label label3;
        private TextBox id2;
        private Label label4;
    }
}
