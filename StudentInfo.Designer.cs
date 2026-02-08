namespace LearningManagement
{
    partial class StudentInfo
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
            dataGridStudents = new DataGridView();
            lbl = new Label();
            btnGPA = new Button();
            btnAddStudent = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridStudents
            // 
            dataGridStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudents.Location = new Point(125, 187);
            dataGridStudents.Name = "dataGridStudents";
            dataGridStudents.RowHeadersWidth = 51;
            dataGridStudents.Size = new Size(582, 188);
            dataGridStudents.TabIndex = 0;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Emoji", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl.Location = new Point(274, 26);
            lbl.Name = "lbl";
            lbl.Size = new Size(245, 46);
            lbl.TabIndex = 1;
            lbl.Text = "Student's List :)";
            // 
            // btnGPA
            // 
            btnGPA.Location = new Point(125, 114);
            btnGPA.Name = "btnGPA";
            btnGPA.Size = new Size(173, 29);
            btnGPA.TabIndex = 2;
            btnGPA.Text = "Save Highest GPA";
            btnGPA.UseVisualStyleBackColor = true;
            btnGPA.Click += btnGPA_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(343, 114);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(166, 29);
            btnAddStudent.TabIndex = 3;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(565, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // StudentInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnAddStudent);
            Controls.Add(btnGPA);
            Controls.Add(lbl);
            Controls.Add(dataGridStudents);
            Name = "StudentInfo";
            Text = "StudentInfo";
            Load += StudentInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridStudents;
        private Label lbl;
        private Button btnGPA;
        private Button btnAddStudent;
        private Button btnDelete;
    }
}