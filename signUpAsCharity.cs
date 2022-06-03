using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace Project_for_waste_food
{
    public partial class signUpAsCharity : Form
    {
        public signUpAsCharity()
        {
            InitializeComponent();
        }

        private void signUpAsCharity_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateBaseContext db = new DateBaseContext();
            //db.Database.EnsureCreated();
            //try
            //{
            //    Customer customers = new Customer();
            //    customers.CustomerName = textBox1.Text;
            //    customers.CustomerPhone = textBox2.Text;
            //    customers.CustomerMail = textBox3.Text;
            //    customers.CustomerPassward = textBox4.Text;
            //    customers.CustomerAddress = textBox5.Text;
            //    customers.CustomerType = textBox5.Text;
            //    db.customers.Add(customers);
            //    db.SaveChanges();
            //    var res = MessageBox.Show(" Success \n Do You Want go to Login ", " Created", MessageBoxButtons.YesNo);
            //    if (res == DialogResult.Yes)
            //    {
            //        log_in f = new log_in();
            //        f.Show();
            //        Hide();
            //    }
            //    else
            //    {
            //        textBox1.Text = "";
            //        textBox2.Text = "";
            //        textBox3.Text = "";
            //        textBox4.Text = "";
            //        textBox5.Text = "";
            //        textBox5.Text = "";

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error");
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateBaseContext db = new DateBaseContext();
            db.Database.EnsureCreated();
            try
            {
                Customer customers = new Customer();
                customers.CustomerName = textBox1.Text;
               
                bool IsValidEmail(string eMail)
                {
                    bool Result = false;

                    try
                    {
                        var eMailValidator = new System.Net.Mail.MailAddress(eMail);

                        Result = (eMail.Contains(".") && eMail.Contains("@"));
                    }
                    catch
                    {
                        Result = false;
                    };

                    return Result;
                }
                if (IsValidEmail(textBox3.Text))
                {
                    customers.CustomerMail = textBox3.Text;
                }
                else
                {
                    MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label7.Show();
                    textBox3.Text = " ";
                }
                if (textBox2.TextLength != 11)
                {
                    MessageBox.Show("Wrong Telephone No Please check it again",
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = " ";
                }
                else
                {
                    customers.CustomerPhone = textBox2.Text;
                    label8.Show();
                   
                }

                customers.CustomerPassword = textBox4.Text;
                customers.CustomerAddress = textBox5.Text;
                customers.CustomerType = textBox6.Text;
                if (IsValidEmail(textBox3.Text) && textBox2.TextLength == 11)
                {
                    db.customers.Add(customers);
                    db.SaveChanges();
                    var res = MessageBox.Show(" Success \n Do You Want go to Login ", " Created", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        log_in lo = new log_in();
                        lo.Show();
                        Hide();
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("facebook.com");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
