using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2WFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            f_nameValue.Text = "";
            l_nameValue.Text = "";
            idnumValue.Text = "";
            phoneValue.Text = "";
            emailValue.Text = "";
            addressValue.Text = "";
            gender_mButton.Checked = false;
            gender_fButton.Checked = false;
            status_studyingButton.Checked = false;
            status_graduatedButton.Checked = false;
            dobValue.Value = DateTime.Today;
            profile_pictureBox.Image = Project2WFA.Properties.Resources.man;
            profile_pictureLabel.Text = "No file chosen.";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (f_nameValue.Text == "" || 
               l_nameValue.Text == "" ||
               idnumValue.Text == "" ||
               phoneValue.Text == "" ||
               emailValue.Text == "" ||
               addressValue.Text == ""||
               gender_mButton.Checked == false && gender_fButton.Checked == false||
               status_studyingButton.Checked == false && status_graduatedButton.Checked == false||
               profile_pictureLabel.Text == "No file chosen.")
            {
                MessageBox.Show("Please fill in the information.");            }
            else {
                MessageBox.Show("Information submitted succesfully!");
                f_nameValue.Text = "";
                l_nameValue.Text = "";
                idnumValue.Text = "";
                phoneValue.Text = "";
                emailValue.Text = "";
                addressValue.Text = "";
                gender_mButton.Checked = false;
                gender_fButton.Checked = false;
                status_studyingButton.Checked = false;
                status_graduatedButton.Checked = false;
                dobValue.Value = DateTime.Today;
                profile_pictureBox.Image = Project2WFA.Properties.Resources.man;
                profile_pictureLabel.Text = "No file chosen.";
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void l_nameValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void genderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void choosefilebutton_Click(object sender, EventArgs e)
        {
            string Chosen_File = "";
            openFD.Title = "Insert an Image";
            openFD.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|GIF Images|*.gif|BITMAPS|*.bmp|PNG File|*.png";
            if (openFD.ShowDialog() != DialogResult.Cancel)
            {

                Chosen_File = openFD.FileName;
                profile_pictureBox.Image = Image.FromFile(Chosen_File);
                profile_pictureLabel.Text = Chosen_File;
            }
        }

        private void openFD_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void profile_pictureLabel_Click(object sender, EventArgs e)
        {

        }

        private void profile_pictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
