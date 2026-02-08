namespace LearningManagement
{
    public partial class LMS : Form
    {
        public LMS()
        {
            InitializeComponent();
        }

        private void btnOthers_Click(object sender, EventArgs e)
        
        {
            this.Hide();
            StudentInfo newform = new StudentInfo();
            newform.ShowDialog();
            

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != string.Empty && txtStudentName.Text != string.Empty && txtStudentGPA.Text != string.Empty)
            {
               Student student = new Student();
                student.Id = int.Parse(txtStudentID.Text);
                student.Name = txtStudentName.Text;
                student.GPA = float.Parse(txtStudentGPA.Text);

                Data.mystudentlist.Add(student);

                MessageBox.Show($"Student has been added, click on 'Other Students' to see list! ", "Record added!");
                txtStudentID.Text = string.Empty;
                txtStudentGPA.Text = string.Empty;
                txtStudentName.Text = string.Empty;

            }
        }
    }
}
