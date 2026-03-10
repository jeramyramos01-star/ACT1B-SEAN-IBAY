namespace sean
{
    partial class RegisterStudent
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
            lblRegister = new Label();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblCourse = new Label();
            lblSection = new Label();
            lblAge = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.Location = new Point(85, 70);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(249, 20);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "REGISTER STUDENT INFORMATION";
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstname.Location = new Point(28, 112);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(87, 20);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "First Name:";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastname.Location = new Point(28, 149);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(84, 20);
            lblLastname.TabIndex = 2;
            lblLastname.Text = "Last Name:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(52, 197);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(60, 20);
            lblCourse.TabIndex = 3;
            lblCourse.Text = "Course:";
            // 
            // lblSection
            // 
            lblSection.AutoSize = true;
            lblSection.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSection.Location = new Point(49, 246);
            lblSection.Name = "lblSection";
            lblSection.Size = new Size(63, 20);
            lblSection.TabIndex = 4;
            lblSection.Text = "Section:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(72, 301);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(40, 20);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(191, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(143, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 23);
            textBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(143, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(191, 23);
            comboBox1.TabIndex = 8;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(143, 243);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(191, 23);
            comboBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(143, 298);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(191, 23);
            textBox3.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(515, 389);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 412);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblAge);
            Controls.Add(lblSection);
            Controls.Add(lblCourse);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(lblRegister);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private Label lblFirstname;
        private Label lblLastname;
        private Label lblCourse;
        private Label lblSection;
        private Label lblAge;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private Button button1;
    }
}