using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assesment2Csharp
{
    public partial class OrdersTimMonday : Form
    {
        public OrdersTimMonday()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void OrdersTimMonday_Load(object sender, EventArgs e)
        {
            string[] productStrings;
            productStrings = new string[5];
            // product number arraystring declared

            productStrings[0] = "3115";
            productStrings[1] = "3116";
            productStrings[2] = "3117";
            productStrings[3] = "3118";
            productStrings[4] = "3119";

            // arraystrings for product number


            txtProd1.Text = productStrings[0];
            txtProd2.Text = productStrings[1];
            txtProd3.Text = productStrings[2];
            txtProd4.Text = productStrings[3];

            //displaying the nunber in textbox

           

            







































        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string[] descriptionStrings;
            descriptionStrings = new string[5];
            //delcare description strings

            descriptionStrings[0] = "USB Scanner";
            descriptionStrings[1] = "Monitor 17";
            descriptionStrings[2] = "Mono Laser Printer";
            descriptionStrings[3] = "LCD/Tv Monitor 19";
            descriptionStrings[4] = "Colour Laser Printer";
            // description string values

            txtDesc1.Text = descriptionStrings[0];
            txtDesc2.Text = descriptionStrings[1];
            txtDesc3.Text = descriptionStrings[2];
            txtDesc4.Text = descriptionStrings[3];
            //display description values


            string[] priceStrings;
            priceStrings = new string[5];
            // price string decalred

            priceStrings[0] = "49.99";
            priceStrings[1] = "159.99";
            priceStrings[2] = "129.99";
            priceStrings[3] = "319.99";
            priceStrings[4] = "349.99";
            // price string values

            txtPrice1.Text = priceStrings[0];
            txtPrice2.Text = priceStrings[1];
            txtPrice3.Text = priceStrings[2];
            txtPrice4.Text = priceStrings[3];
            // displaying price strings in textbox



         
            


            double price1 = Convert.ToDouble(txtPrice1.Text);
            int quantity1 = int.Parse(txtQuant1.Text);
            double lineTotal1 = price1 * quantity1;

            txtLineTotal1.Text = lineTotal1.ToString("C2");


            double price2 = Convert.ToDouble(txtPrice2.Text);
            int quantity2 = int.Parse(txtQuant2.Text);
            double lineTotal2 = price2 * quantity2;

            txtLineTotal2.Text = lineTotal2.ToString("C2");


            double price3 = Convert.ToDouble(txtPrice3.Text);
            int quantity3 = int.Parse(txtQuant3.Text);
            double lineTotal3 = price3 * quantity3;

            txtLineTotal3.Text = lineTotal3.ToString("C2");

            double price4 = Convert.ToDouble(txtPrice4.Text);
            int quantity4 = int.Parse(txtQuant4.Text);
            double lineTotal4 = price4 * quantity4;

            txLineTotal4.Text = lineTotal4.ToString("C2");
            //Line Totals

           
            double txtBoxSubTotal = lineTotal1 + lineTotal2 + lineTotal3 + lineTotal4;
            txtBoxSubTotal= subTotal.ToString("C2");
            




          
            //Sub 

            string subTotal2 = Convert.ToString(subTotal);


            double txtBoxSubTotal = (subTotal * 0.10);
            double txtBoxDisscount2 = (subTotal - txtBoxSubTotal);

            double disscount = 0;

            double subTotal3 = lineTotal1 + lineTotal2 + lineTotal3 + lineTotal4;

            string total = Convert.ToString(subTotal3 + disscount);



            if (subTotal >= 5000)
            {

                disscount = subTotal * 0.10;
                txtBoxDisscount.Text = disscount.ToString("C2");

            }
            
            else
            {

                txtBoxDisscount.Text = 0.ToString("C2"); 

                
            }

            total = (subTotal3 - disscount).ToString("C2");
            txtBoxOrdTotal.Text = total.ToString();
            
            
            

                
                 
            

            
           
            


        















        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            
            txtProd1.Clear();
            txtProd2.Clear();
            txtProd3.Clear();
            txtProd4.Clear();
            // ^Product code textboxes^
            txtDesc1.Clear();
            txtDesc2.Clear();
            txtDesc3.Clear();
            txtDesc4.Clear();
            // ^product description textboxes^
            txtQuant1.Clear();
            txtQuant2.Clear();
            txtQuant3.Clear();
            txtQuant4.Clear();
            // ^prodct prices text boxes^


        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
