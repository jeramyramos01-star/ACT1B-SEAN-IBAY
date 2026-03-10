namespace sean
{
    partial class dashboard
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
            btnRegister = new Button();
            btnStudent = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(56, 191);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(116, 64);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "REGISTER STUDENT";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            btnStudent.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(225, 191);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(117, 64);
            btnStudent.TabIndex = 1;
            btnStudent.Tag = "";
            btnStudent.Text = "STUDENT LIST";
            btnStudent.UseVisualStyleBackColor = true;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 450);
            Controls.Add(btnStudent);
            Controls.Add(btnRegister);
            Name = "dashboard";
            Text = "dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnStudent;
    }
}