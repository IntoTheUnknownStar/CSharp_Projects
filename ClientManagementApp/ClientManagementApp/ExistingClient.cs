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
    public partial class ExistingClient : Form
    {

        public ExistingClient()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void ExistingClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'client_Management_DatabaseDataSet1.tblClientData' table. You can move, or remove it, as needed.
            this.tblClientDataTableAdapter.Fill(this.client_Management_DatabaseDataSet1.tblClientData);
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           
          
            //Connection of Access Database tables for active Clients
            int click = 0;
            click += 1;

            if (click == 1)
            {
                if (activeRadioButton.Checked == true)
                {

                    DataView active;
                    active = new DataView(client_Management_DatabaseDataSet1.tblClientData, "Status = 'Active' ","Status Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = active;
                   
                }
                else if(inactiveRadioButton.Checked == true)
                {
                    DataView inactive;
                    inactive = new DataView(client_Management_DatabaseDataSet1.tblClientData, "Status = 'Inactive' ", "Status Desc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = inactive;

                }
            }
        }

        private void closeExistingButton_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void inactiveRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tblClientDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
