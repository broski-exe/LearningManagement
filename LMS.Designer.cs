namespace LearningManagement
{
    partial class LMS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            lblStuID = new Label();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            txtStudentGPA = new TextBox();
            btnOthers = new Button();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(371, 359);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblStuID
            // 
            lblStuID.AutoSize = true;
            lblStuID.Location = new Point(201, 141);
            lblStuID.Name = "lblStuID";
            lblStuID.Size = new Size(82, 20);
            lblStuID.TabIndex = 1;
            lblStuID.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 205);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Student Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 287);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 3;
            label3.Text = "GPA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 9);
            label1.Name = "label1";
            label1.Size = new Size(571, 58);
            label1.TabIndex = 4;
            label1.Text = "Enter Student's Information";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(362, 141);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 5;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(362, 205);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 6;
            // 
            // txtStudentGPA
            // 
            txtStudentGPA.Location = new Point(362, 287);
            txtStudentGPA.Name = "txtStudentGPA";
            txtStudentGPA.Size = new Size(125, 27);
            txtStudentGPA.TabIndex = 7;
            // 
            // btnOthers
            // 
            btnOthers.Location = new Point(579, 97);
            btnOthers.Name = "btnOthers";
            btnOthers.Size = new Size(200, 29);
            btnOthers.TabIndex = 8;
            btnOthers.Text = "See Other Student's";
            btnOthers.UseVisualStyleBackColor = true;
            btnOthers.Click += btnOthers_Click;
            // 
            // LMS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOthers);
            Controls.Add(txtStudentGPA);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblStuID);
            Controls.Add(btnSubmit);
            Name = "LMS";
            Text = "Learning Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label lblStuID;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private TextBox txtStudentGPA;
        private Button btnOthers;
    }
}
