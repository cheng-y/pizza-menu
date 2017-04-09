using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza_Menu
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            // Read the Text file & display total amount.
            StreamReader inputFile;
            inputFile = File.OpenText("sum.txt");
            string sumAmount = inputFile.ReadLine();
            amountTotalLabel.Text = sumAmount;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // Display Thank you message.
            MessageBox.Show("Approved !");
            MessageBox.Show("Thank you for Choosing Mom's Kitchen Pizza");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the Form.
            this.Close();
        }
    }
}
