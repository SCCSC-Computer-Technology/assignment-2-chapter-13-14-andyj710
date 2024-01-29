using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT206_AndrewJablonski_Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creating the context
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Form1_Load(object sender, EventArgs e)
        {

            //intial loading for pt5 for units on hand
            var initialUOHLoad = from product in db.Products
                                 orderby product.Units_On_Hand ascending
                                 select product;

            //initial load for pt6 price in ascending
            var priceLoad = from product in db.Products
                            orderby product.Price ascending
                            select product;

            //Display products in datagrid
            unitDataGridView.DataSource = initialUOHLoad.ToList();

            //display prices in datagrid
            PriceDataGridView.DataSource = priceLoad.ToList();

        }

        private void searchProductNumber_Click(object sender, EventArgs e)
        {
            //associates the variable with the textbox
            string productNumSearch = productNumberTextBox.Text;

            //checks if the string is not null so reverses isnullorempty in the textbox
            if (!string.IsNullOrEmpty(productNumSearch))
            {
                //stores in results from product property in the database
                //where the product number contains the search variable
                var results = from product in db.Products
                              where product.Product_Number.Contains(productNumSearch)
                              select product;

                //shows if there are results from the LINQ statement to the datagrid
                if (results.Any())
                {
                    ProductDataGridView.DataSource = results.ToList();
                }
                else
                {
                    MessageBox.Show("No Product by that number, try something else");
                }

            }
            else
            {
                MessageBox.Show("You need to enter something");
            }
        }

        private void searchDescButton_Click(object sender, EventArgs e)
        {
            string searchText = productDescTextBox.Text;
            //checks if the string is not null so reverses isnullorempty in the textbox
            if (!string.IsNullOrEmpty(searchText))
            {
                //does the same as above and associates the search with a variable by 
                //seeing where the description "contains" the variable
                var prodDescSearch = from product in db.Products
                                     where product.Description.Contains(searchText)
                                     select product;
                //sends data to the datasource if they entered something
                if (prodDescSearch.Any())
                {
                    descriptionDataGridView.DataSource = prodDescSearch.ToList();
                }
                else
                {
                    MessageBox.Show("No Product by that description, try something else");
                }

            }
            else
            {
                MessageBox.Show("You need to enter something");
            }
        }

        //start of problem 5
        private void greaterThanButton_Click(object sender, EventArgs e)
        {
            //parses the user input and assigns the variable 
            if (int.TryParse(unitsTextBox.Text, out int greaterThan))
            {
                //LINQ statement comparing the variable greaterThan the user creates to UOH
                var great = from product in db.Products
                            where product.Units_On_Hand > greaterThan
                            orderby product.Units_On_Hand
                            select product;

                unitDataGridView.DataSource = great.ToList();
            }

            else
            {
                MessageBox.Show("You need to enter something");
            }
        } 

        private void lessThanButton_Click(object sender, EventArgs e)
        {
            //parses user input and assigns variable lessthan
            if (int.TryParse(unitsTextBox.Text, out int lessThan))
            {
                //LINQ statement comparing the variable lessThan the user creates to UOH
                var less = from product in db.Products
                              where product.Units_On_Hand < lessThan
                              orderby product.Units_On_Hand
                              select product;

                unitDataGridView.DataSource = less.ToList();
            }

            else
            {
                MessageBox.Show("You need to enter something");
            }
        }//end of problem 5

        //start of problem 6
        private void button2_Click(object sender, EventArgs e)
        {
            //parses both textboxes and assigns variables to both
            if (int.TryParse(minPriceTextBox.Text, out int min) && int.TryParse(maxPriceTextBox.Text, out int max))
            {
                //LINQ statement  where it orders between min and max (what the user enters)
                var minimum = from product in db.Products
                              where product.Price > min && product.Price < max
                              orderby product.Price
                              select product;

                PriceDataGridView.DataSource = minimum.ToList();
                
            }
            else
            {
                MessageBox.Show("You need to enter something in both Text Boxes");
            }
        }//end of problem 6

    }
}
