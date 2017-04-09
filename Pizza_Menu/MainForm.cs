using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Menu
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            // Hide the form & go to the menu form.
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
            
        }
    }
}
