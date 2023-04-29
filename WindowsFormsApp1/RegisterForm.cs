using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            username.Text = "your login";
            username.ForeColor = Color.Gray;
        }
       

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void autorise_buttom_Click(object sender, EventArgs e)
        {
            DB db = new DB();   
            MySqlCommand mySqlCommand = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login,@password)", db.getconnection());
            mySqlCommand.Parameters.Add("@login", MySqlDbType.VarChar).Value = username.Text;
            String user = username.Text;
            String pass = hash.hashpassword(password.Text);
            String confirm = hash.hashpassword(confirm_pass.Text);
            //String pass = password.Text;
            //String confirm = confirm_pass.Text;
            if (password.Text == "" ||  confirm_pass.Text == "")
            {
                MessageBox.Show("you forgot to write your password");
                password.Clear();
                confirm_pass.Clear();
                return;
            }
            if(confirm != pass)
            {
                MessageBox.Show("Passwords arent the same!");
                password.Clear();
                confirm_pass.Clear();
                return;
            }
            mySqlCommand.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;

            db.open_connection();


            if (mySqlCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Account was registrated");
            }
            else MessageBox.Show("Account wasnt registrated");


            db.closed_connection();
        }

        private void close_form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_Leave(object sender, EventArgs e)
        {
            
        }

        private void username_Enter(object sender, EventArgs e)
        {
           
        }

        private void login_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            AutorizeForm autorizeForm = new AutorizeForm();
            autorizeForm.Show();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_MouseLeave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "your login";
                username.ForeColor = Color.Gray;
            }
        }

        private void username_MouseEnter(object sender, EventArgs e)
        {
            if (username.Text == "your login")
            {
                username.Text = "";
            }
        }
    }
}
