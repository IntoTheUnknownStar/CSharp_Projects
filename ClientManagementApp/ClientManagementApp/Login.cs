using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManagementApp
{
    public partial class Login : Form
    {
        private OleDbConnection con = new OleDbConnection();
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\aaron\OneDrive\Documents\Client Management Database.accdb;
            Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter data = new OleDbDataAdapter("SELECT Count(*) FROM tblLogin WHERE Username='"+usernameTextBox.Text+"' and " +
                "Password ='"+passwordTextBox.Text+"'",con);
            DataTable dtable = new DataTable();
            data.Fill(dtable);
            if (dtable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                mainMenuLayout newMainMenu = new mainMenuLayout();
                newMainMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("   Username/Password Invalid");
                passwordTextBox.Clear();


            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '*';
            if(Control.IsKeyLocked(Keys.CapsLock))
            {
                MessageBox.Show("Caps Lock is ON.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
