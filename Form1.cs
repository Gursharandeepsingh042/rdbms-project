using System;
using System.Data;
using System.Windows.Forms;
using EDIRECTCLASSES;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        contactclass c = new contactclass();
        private object txtboxLastName;
        private object cmbGender;

        public object txtboxFirstName { get; private set; }
        public object DataGridViewContactlist { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //getvaluesofinput fields
            c.FirstName = txtboxfirstname.Text;
            c.LastName = txtboxlastname.Text;
            c.ContactNo = txtboxcontactnumber.Text;
            c.Gender = txtboxGender.Text;
            c.Address = txtboxaddress.Text;


            //inserting data into the db;
            bool success = c.insert(c);
            if (success == true)
            {
                MessageBox.Show("NEW CONTACTS INSERTED SUCCESSFULLY");

            }
            else
            {
                MessageBox.Show("FAILED TO ADD THE CONTACT. TRY AGAIN !");

            }

            DataTable dt = c.select();
              
           dataGridView1.DataSource = dt;    
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void txtboxfirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
