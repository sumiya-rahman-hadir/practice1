using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampuStore
{
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            
            btnSave.BackColor = Color.LightGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = SystemColors.Window;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }
    }
}
