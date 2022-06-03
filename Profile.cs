using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_for_waste_food
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
            textBox11.Text = StroreData.v.VendorName;
            textBox1.Text = StroreData.v.VendorPhone;
            textBox2.Text = StroreData.v.VendorMail;
            textBox3.Text = StroreData.v.VendorPassword;
            textBox4.Text = StroreData.v.VendorAddress;
            textBox5.Text = StroreData.v.VendorType;

            /*
            label7.Text = StroreData.v.VendorName;
            label8.Text = StroreData.v.VendorPhone;
            label9.Text = StroreData.v.VendorMail;
            label10.Text = StroreData.v.VendorPassward;
            label11.Text = StroreData.v.VendorAddress;
            label12.Text = StroreData.v.VendorType;*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            howDonorAddFood howDonorAddFood = new howDonorAddFood();
            howDonorAddFood.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
