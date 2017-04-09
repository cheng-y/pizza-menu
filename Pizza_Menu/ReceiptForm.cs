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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            // Read the text file.
            StreamReader inputFile;
            inputFile = File.OpenText("receipt.txt");
            while (!inputFile.EndOfStream)
            {
                string receiptItems = inputFile.ReadLine();
                receiptListBox.Items.Add(receiptItems);
            }
            inputFile.Close();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            // Hides the receipt form & go to payment form.
            this.Hide();
            Payment paymentForm = new Payment();
            paymentForm.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Hides the payment form & goes back to menu form.
            this.Hide();
            Menu menuForm = new Menu();
            menuForm.ShowDialog();
        }
    }
}
