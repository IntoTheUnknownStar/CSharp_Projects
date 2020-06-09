using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientManagementApp
{
    public partial class mainMenuLayout : Form
    {
        public mainMenuLayout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int click = 0;
            click += 1;

            if (click == 1)
            {
                this.Hide();
                NewClient newClient = new NewClient();
                newClient.ShowDialog();
            }

        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void mainMenuLayout_Load(object sender, EventArgs e)
        {

        }

        private void mainExistingButton_Click(object sender, EventArgs e)
        {
            int click = 0;
            click += 1;

            if (click == 1)
            {
                this.Hide();
                ExistingClient newExistingClient = new ExistingClient();
                newExistingClient.ShowDialog();
            }
        }
    }
}
