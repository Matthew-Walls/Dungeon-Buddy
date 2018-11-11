using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Buddy
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        // Initialize variable to hold the selected campaign.
        private Campaign _campaign;

        // Define properties.
        public Campaign Campaign
        {
            set { _campaign = value; }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // On form load create and display FormSplash
            FormSplash formSplash = new FormSplash(this);
            formSplash.ShowDialog();
        }
    }
}
