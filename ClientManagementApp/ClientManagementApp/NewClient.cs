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
    public partial class NewClient : Form
    {
        private OleDbConnection con = new OleDbConnection();
        
        public NewClient()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\aaron\OneDrive\Documents\Client Management Database.accdb;
            Persist Security Info=False;";

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NewClient_Load(object sender, EventArgs e)
        {


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            //Check each radiobutton for a rating value
            //Then add the form data to the access datbase
            try
            {
                if (radioButton1.Checked == true)
                {
                    string button = "1";
                    string status = "Active";
                    OleDbCommand cmd = new OleDbCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = "INSERT INTO tblClientData ([First Name], [Last Name], [Street Number], [Street Name], City, Zipcode, State, Status, [Client Rating], Occupation, [Note]) " +
                        "VALUES('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + streetNumbertextBox.Text + "','" + streetNameTextBox.Text + "','" + cityNameTextBox.Text + "','" + zipTextBox.Text + "','" + stateTextBox.Text + "','"+status+"','"+button+"','" + jobTextBox.Text + "','" + notesTextBox.Text + "')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
                else if (radioButton2.Checked == true)
                {
                    string button = "2";
                    string status = "Active";
                    OleDbCommand cmd1 = new OleDbCommand();
                    con.Open();
                    cmd1.Connection = con;
                    cmd1.CommandText = "INSERT INTO tblClientData ([First Name], [Last Name], [Street Number], [Street Name], City, Zipcode, State, Status, [Client Rating], Occupation, [Note]) " +
                        "VALUES('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + streetNumbertextBox.Text + "','" + streetNameTextBox.Text + "','" + cityNameTextBox.Text + "','" + zipTextBox.Text + "','" + stateTextBox.Text + "','" + status + "','" + button + "','" + jobTextBox.Text + "','" + notesTextBox.Text + "')";
                    cmd1.ExecuteNonQuery();
                    con.Close();

                }
                else if (radioButton3.Checked == true)
                {
                    string button = "3";
                    string status = "Active";
                    OleDbCommand cmd2 = new OleDbCommand();
                    con.Open();
                    cmd2.Connection = con;
                    cmd2.CommandText = "INSERT INTO tblClientData ([First Name], [Last Name], [Street Number], [Street Name], City, Zipcode, State, Status, [Client Rating], Occupation, [Note]) " +
                        "VALUES('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + streetNumbertextBox.Text + "','" + streetNameTextBox.Text + "','" + cityNameTextBox.Text + "','" + zipTextBox.Text + "','" + stateTextBox.Text + "','" + status + "','" + button + "','" + jobTextBox.Text + "','" + notesTextBox.Text + "')";
                    cmd2.ExecuteNonQuery();
                    con.Close();

                }
                else if (radioButton4.Checked == true)
                {
                    string button = "4";
                    string status = "Active";
                    OleDbCommand cmd3 = new OleDbCommand();
                    con.Open();
                    cmd3.Connection = con;
                    cmd3.CommandText = "INSERT INTO tblClientData ([First Name], [Last Name], [Street Number], [Street Name], City, Zipcode, State, Status, [Client Rating], Occupation, [Note]) " +
                        "VALUES('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + streetNumbertextBox.Text + "','" + streetNameTextBox.Text + "','" + cityNameTextBox.Text + "','" + zipTextBox.Text + "','" + stateTextBox.Text + "','" + status + "','" + button + "','" + jobTextBox.Text + "','" + notesTextBox.Text + "')";
                    cmd3.ExecuteNonQuery();
                    con.Close();

                }
                else
                {
                    string button = "5";
                    string status = "Active";
                    con.Open();
                    OleDbCommand cmd4 = new OleDbCommand();
                    cmd4.Connection = con;
                    cmd4.CommandText = "INSERT INTO tblClientData ([First Name], [Last Name], [Street Number], [Street Name], City, Zipcode, State, Status, [Client Rating], Occupation, [Note]) " +
                        "VALUES('" + firstNameTextBox.Text + "','" + lastNameTextBox.Text + "','" + streetNumbertextBox.Text + "','" + streetNameTextBox.Text + "','" + cityNameTextBox.Text + "','" + zipTextBox.Text + "','" + stateTextBox.Text + "','" + status + "','" + button + "','" + jobTextBox.Text + "','" + notesTextBox.Text + "')";
                    cmd4.ExecuteNonQuery();
                    con.Close();

                }
                //Save message
                MessageBox.Show("Save successfully.");
                //Removes the submitted client data once saved successfully
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                streetNumbertextBox.Clear();
                streetNameTextBox.Clear();
                cityNameTextBox.Clear();
                stateTextBox.Clear();
                zipTextBox.Clear();
                jobTextBox.Clear();
                notesTextBox.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;









            }
            catch (Exception error)
            {
                MessageBox.Show("Save unsuccessful: Please check your data." + error);
            }


        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void returnMenuFromNew_Click(object sender, EventArgs e)
        {
            int click = 0;
            click += 1;

            if (click == 1)
            {
                this.Hide();
                mainMenuLayout returnMenu = new mainMenuLayout();
                returnMenu.ShowDialog();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearClientButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
