using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Form1 : Form
    {
    
        int i = 0;
        int a = 0;
        int b = 0;

        List<string> customerName = new List<string>{};
        List<string> contactNo = new List<string> { };
        List<string> address = new List<string> { };
        List<string> order = new List<string> { };
        List<string> quantity = new List<string> { };
        List<int> quantity1 = new List<int> { };
        List<int> price = new List<int> { };
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        private void Price(int value,int a)
        {

            b = a * value;
            price.Add(b);


            MessageBox.Show("The bill is " + price[i] + "Tk.");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (customernameTextBox.Text == "" || contactnoTextBox.Text == "" || addressTextBox.Text == "" ||
                               orderComboBox.Text == "" || quantityTextBox.Text == "")
                {
                    if (customernameTextBox.Text == "" && contactnoTextBox.Text == "" && addressTextBox.Text == "" &&
                        orderComboBox.Text == "" && quantityTextBox.Text == "")
                    {
                        MessageBox.Show("Please enter all customer information");
                    }
                    else if (customernameTextBox.Text == "")
                    {
                        MessageBox.Show("Please enter a customer name");
                    }
                    else if (contactnoTextBox.Text == "")
                    {
                        MessageBox.Show("Please enter a customer no");
                    }
                    else if (addressTextBox.Text == "")
                    {
                        MessageBox.Show("Please enter a address");
                    }
                    else if (orderComboBox.Text == "")
                    {
                        MessageBox.Show("Order Must be Selected ");
                    }
                    else if (quantityTextBox.Text == "")
                    {
                        MessageBox.Show("Quantity can not be Empty ");
                    }
                    else
                    {
                        MessageBox.Show("Please enter all customer information");
                    }


                }
                else
                {
                    ////contactNo[0] = "0";
                    ////for (int j = 0; j < contactNo.Count(); j++)
                    ////{
                    //    if (contactNo[j] == contactnoTextBox.Text)
                    //    {
                    //        MessageBox.Show(" Contact no Must be Unique ");
                    //    }
                    //    else
                    //    {
                    customerName.Add(customernameTextBox.Text);
                    contactNo.Add(contactnoTextBox.Text);
                    address.Add(addressTextBox.Text);
                    order.Add(orderComboBox.Text);
                    quantity.Add(quantityTextBox.Text);

                    a = Convert.ToInt32(quantityTextBox.Text);

                    purchase_informationRichTextBox.Text = "";

                    if (orderComboBox.Text == "Black")
                    {
                        Price(120, a);
                    }
                    else if (orderComboBox.Text == "Cold")
                    {
                        Price(100, a);
                    }
                    else if (orderComboBox.Text == "Hot")
                    {
                        Price(90, a);
                    }
                    else if (orderComboBox.Text == "Regular")
                    {
                        Price(80, a);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a order");
                    }




                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Customer Name :" + customerName[i];
                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Contact Number:" + contactNo[i];
                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Address             :" + address[i];
                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Order                 :" + order[i];
                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Quantity            :" + quantity[i];
                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "Price                 :" + price[i] + "Tk.";
                    purchase_informationRichTextBox.SelectedText = Environment.NewLine + "";

                    MessageBox.Show("Successfully Saved");

                    customernameTextBox.Text = "";
                    contactnoTextBox.Text = "";
                    addressTextBox.Text = "";
                    orderComboBox.Text = "";
                    quantityTextBox.Text = "";
                    i++;
                    //}
                    //}

                    //List<int> quantity1;



                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }

           

        }

        private void showButton_Click(object sender, EventArgs e)
        {

            try
            {
                purchase_informationRichTextBox.Text = "";
                string x = "";
                for (int j = 0; j < customerName.Count(); j++)
                {
                    x += "Customer Name :" + customerName[j] + "\n" + "Contact Number:" + contactNo[j] + "\n" +
                         "Address             :" + address[j] + "\n" + "Order                 :" + order[j] + "\n" +
                         "Quantity            :" + quantity[j] + "\n" + "Price                 :" + price[j] + "Tk." + "\n";
                }

                //MessageBox.Show(x);
                purchase_informationRichTextBox.SelectedText = Environment.NewLine + " " + x + "\n";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
            
        }
    }
}
