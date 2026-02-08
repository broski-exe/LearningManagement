using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Text;
using System.Windows.Forms;

namespace LearningManagement
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }


        private void StudentInfo_Load(object sender, EventArgs e)
        {
            dataGridStudents.DataSource = Data.mystudentlist;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete??", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.mystudentlist.RemoveAt(dataGridStudents.CurrentRow.Index);
                dataGridStudents.DataSource = null;
                dataGridStudents.DataSource = Data.mystudentlist;

            }

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            LMS newLMS = new LMS();
            newLMS.Show();
            this.Hide();
        }

        private void btnGPA_Click(object sender, EventArgs e)
        {
            Data.mystudentlist.Sort(new StudentGPAS());
            int x = Data.mystudentlist.Count-1;
            Student winner = Data.mystudentlist[x];


            MessageBox.Show($"Student {winner.Id},{winner.Name} has a GPA of {winner.GPA}!");

            string message = $"Student {winner.Id},{winner.Name} has a GPA of {winner.GPA}!";



            const string path = @"C:\Files\";

            string fileName = path + "winner";

            StreamWriter writer = null;

            try
            {
                if (!File.Exists(fileName))
                {
                    writer = File.CreateText(fileName);
                    writer.WriteLine($"{message}");

                }
                else
                {
                    File.AppendAllText(fileName, $"\nFile is accessed on {DateTime.Now}");
                    Console.WriteLine("File appended successfully");
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("An error occurred: " + ex.Message);
            }

            finally
            {

                if (writer != null)
                {
                    writer.Close();
                }
            }



        }
    }
}

        

  