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
    /* To save the security of the desktop application ,Admins only can add donors to system */

    public partial class Add_Doner : Form
    {
        public Add_Doner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateBaseContext db = new DateBaseContext();
            db.Database.EnsureCreated();
            try
            {
                Vendor Vendors = new Vendor();
                Vendors.VendorName = textBox1.Text;

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
                   Vendors.VendorMail = textBox3.Text;
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
                    Vendors.VendorPhone = textBox2.Text;
                    label8.Show();

                }

                Vendors.VendorPassword = textBox4.Text;
                Vendors.VendorAddress = textBox5.Text;
                Vendors.VendorType = textBox6.Text;
                if (IsValidEmail(textBox3.Text) && textBox2.TextLength == 11)
                {
                    db.vendors.Add(Vendors);
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
            Home_Admin ho = new Home_Admin();
            ho.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Doner_Load(object sender, EventArgs e)
        {

        }
    }
}
