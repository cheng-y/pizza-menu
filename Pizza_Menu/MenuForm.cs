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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            // Menu items to show on receipt form when checked.
            decimal sum = 0;
            StreamWriter outputFile;
            outputFile = File.CreateText("receipt.txt");
            if (smallRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza Size - Small: $8.00");
                decimal cost = 8;
                sum = sum + cost;
            }
            if (mediumRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza Size - Medium: $10.00");
                decimal cost = 10;
                sum = sum + cost;
            }
            if (largeRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza Size - Large $12.00");
                decimal cost = 12;
                sum = sum + cost;
            }
            if (extraLargeRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza Size - Extra Large: $14.00");
                decimal cost = 14;
                sum = sum + cost;
            }
            if (veggieRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Veggie");
            }
            if (hawaiianRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Hawiian");
            }
            if (canadianRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Canadian");
            }
            if (extravanganzaRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Extravanganza");
            }
            if (meatzaRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Meatza");
            }
            if (chickenRanchRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Chicken Bacon Ranch");
            }
            if (brooklynStyleRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Brooklyn Style");
            }
            if (phillySteakRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Philly Steak");
            }
            if (deluxeRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Deluxe");
            }
            if (bbqChickenRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - BBQ Chicken");
            }
            if (pepperoniRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Pepperoni");
            }
            if (chickenBaconRadioButton.Checked)
            {
                outputFile.WriteLine("Pizza - Chicken Bacon Alfredo");
            }
            if (chickenAlfredoCheckBox.Checked)
            {
                outputFile.WriteLine("Pasta - Chicken Alfredo: $11.00");
                decimal cost = 11;
                sum = sum + cost;
            }
            if (italianSausageCheckBox.Checked)
            {
                outputFile.WriteLine("Pasta - Italian Sausage Marinara: $11.00");
                decimal cost = 11;
                sum = sum + cost;
            }
            if (chickenCabonaraCheckBox.Checked)
            {
                outputFile.WriteLine("Pasta - Chicken Cabonara: $11.00");
                decimal cost = 11;
                sum = sum + cost;
            }
            if (pastaPrimaveraCheckBox.Checked)
            {
                outputFile.WriteLine("Pasta - Pasta Primavera: $11.00");
                decimal cost = 11;
                sum = sum + cost;
            }
            if (bbqWingsCheckBox.Checked)
            {
                outputFile.WriteLine("Wings - Barbeque: $4.00");
                decimal cost = 4;
                sum = sum + cost;
            }
            if (buffaloCheckBox.Checked)
            {
                outputFile.WriteLine("Wings - Buffalo: $4.00");
                decimal cost = 4;
                sum = sum + cost;
            }
            if (honeyGarlicCheckBox.Checked)
            {
                outputFile.WriteLine("Wings - Honey Garlic: $4.00");
                decimal cost = 4;
                sum = sum + cost;
            }
            if (mangoCheckBox.Checked)
            {
                outputFile.WriteLine("Wings - Mango Habanero: $4.00");
                decimal cost = 4;
                sum = sum + cost;
            }
            if (cheesyBreadCheckBox.Checked)
            {
                outputFile.WriteLine("Bread - Cheesy Bread: $7.00");
                decimal cost = 7;
                sum = sum + cost;
            }
            if (garlicFingersCheckBox.Checked)
            {
                outputFile.WriteLine("Bread - Garlic Fingers: $7.00");
                decimal cost = 7;
                sum = sum + cost;
            }
            if (parmesanBitesCheckBox.Checked)
            {
                outputFile.WriteLine("Bread - Parmesan Bites: $7.00");
                decimal cost = 7;
                sum = sum + cost;
            }
            if (breadSticksCheckBox.Checked)
            {
                outputFile.WriteLine("Bread - Bread Sticks: $7.00");
                decimal cost = 7;
                sum = sum + cost;
            }
            if (cinnamonStixCheckBox.Checked)
            {
                outputFile.WriteLine("Bread - Cinnamon Stix: $7.00");
                decimal cost = 7;
                sum = sum + cost;
            }
            if (hotDipCheckBox.Checked)
            {
                outputFile.WriteLine("Dip - Hot Dip: $0.75");
                decimal cost = 0.75M;
                sum = sum + cost;
            }
            if (roastedGarlicCheckBox.Checked)
            {
                outputFile.WriteLine("Dip - Roasted Garlic: $0.75");
                decimal cost = 0.75M;
                sum = sum + cost;
            }
            if (marinaraCheckBox.Checked)
            {
                outputFile.WriteLine("Dip - Marinara: $0.75");
                decimal cost = 0.75M;
                sum = sum + cost;
            }
            if (ranchCheckBox.Checked)
            {
                outputFile.WriteLine("Dip - Ranch: $0.75");
                decimal cost = 0.75M;
                sum = sum + cost;
            }
            if (cheesyCheckBox.Checked)
            {
                outputFile.WriteLine("Dip - Cheesy Jalapeno: $0.75");
                decimal cost = 0.75M;
                sum = sum + cost;
            }
            if (bbqDipCheckBox.Checked)
            {
                outputFile.WriteLine("Dip - BBQ: $0.75");
                decimal cost = 0.75M;
                sum = sum + cost;
            }
            if (cokeCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Coca Cola: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (cokeZeroCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Coke Zero: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (dietCokeCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Diet Coke: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (spriteCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Sprite: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (gingerAleCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Ginger Ale: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (nesteaCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Nestea: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (rootBeerCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Root Beer: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }
            if (creamSodaCheckBox.Checked)
            {
                outputFile.WriteLine("Soft Drinks - Cream Soda: $1.50");
                decimal cost = 1.50M;
                sum = sum + cost;
            }

            decimal tax = sum * 5 / 100;
            decimal sumTax = tax + sum;

            // Write the checked menu items to the text file,
            // Hide the menu form & go to the receipt form
            outputFile.WriteLine("Subtotal: " + sum.ToString("c"));
            outputFile.WriteLine("Sales Tax: " + tax.ToString("c"));
            outputFile.WriteLine("Total: " + sumTax.ToString("C"));
            outputFile.Close();

            outputFile = File.CreateText("sum.txt");
            outputFile.WriteLine(sumTax.ToString("c"));
            outputFile.Close();

            this.Hide();
            Receipt receiptForm = new Receipt();
            receiptForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Display pizza toppings in a message box.
            MessageBox.Show("Veggie (fresh green peppers, onions, tomatoes, mushrooms, and black olives)" + "\n" + "\n" +
"Extravaganza (loads of peperoni, ham, Italian sausage, beef, fresh onions, green peppers, mushrooms, black olives, and extra layer of cheese)" + "\n" + "\n" +
"Brooklyn style (Brooklyn pepperoni, and extra provolone cheese on top)" + "\n" + "\n" +
"BBQ Chicken (BBQ sauce base, chicken, bacon, fresh onions, green peppers, and cheddar cheese)" + "\n" + "\n" +
"Canadian (pepperoni, mushrooms, smoked bacon, extra layer of mozzarella cheese)" + "\n" + "\n" +
"Deluxe (pepperoni, Italian sausage, green peppers, mushrooms, onions, and extra layer of cheese)" + "\n" + "\n" +
"Hawaiian (pineapple, ham, and extra layer of cheese)" + "\n" + "\n" +
"Meatza (pepperoni, ham, beef, Italian sausage, and extra layer of cheese)" + "\n" + "\n" +
"Philly streak (slices of steak, provolone cheese, onions, green peppers, mushrooms, and cheese)" + "\n" + "\n" +
"Pepperoni (pepperoni and extra layer of cheese)" + "\n" + "\n" +
"Chicken Bacon Alfredo (alfredo sauce base, mushrooms, onions, white meat chicken, bacon and mozzarella/cheddar cheese blend)" + "\n" + "\n" +
"Chicken Bacon Ranch (ranch sauce base, tomatoes, green peppers, white meat chicken, bacon and mozzarella/cheddar cheese blend)"
);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
