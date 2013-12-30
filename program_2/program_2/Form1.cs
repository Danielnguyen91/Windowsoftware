/* Name: Toan Nguyen
 * Assignment 2
 * Calulator for restaurant bill
 * */
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

namespace program_2
{
    public partial class Form1 : Form
    {
         double pre_price = 0.0;
         double pre_price1 = 0.0;
         double pre_price2 = 0.0;
         double pre_price3 = 0.0;
         double pre_price4 = 0.0;
        public Form1()
        {
           
            InitializeComponent();
            label6.Visible = false;
            label13.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            label15.Visible = false;
            comboBox5.Visible = false;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox10.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false; 
            comboBox14.Visible = false;
            comboBox15.Visible = false;
            comboBox16.Visible = false;
            comboBox17.Visible = false;
            comboBox18.Visible = false;
            comboBox19.Visible = false;
            label14.Visible = false;
            comboBox13.Visible = false;
            comboBox20.Visible = false;
         

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    comboBox13.Visible = true;
                    label14.Visible = true;
                    label9.Visible = true;
                    comboBox14.Visible = true;
                    textBox2.Text = "$24.00";
                    break;
                case 1:
                    comboBox13.Visible = true;
                    label14.Visible = true;
                    label9.Visible = true;
                    comboBox14.Visible = true;
                    textBox2.Text = "$21.00";
                    break;
                case 2:
                     comboBox13.Visible = true;
                     label14.Visible = true;
                     label9.Visible = true;
                    comboBox14.Visible = true;
                     textBox2.Text = "$22.00";
                    break;
                case 3:
                    comboBox13.Visible = true;
                    label14.Visible = true;
                    label9.Visible = true;
                    comboBox14.Visible = true;
                    textBox2.Text = "$35.00";
                    break;
                case 4:
                    comboBox13.Visible = true;
                    label14.Visible = true;
                     label9.Visible = true;
                    comboBox14.Visible = true;
                    textBox2.Text = "$22.00";
                    break;

                default:
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    textBox3.Text = "$25.00";
                     label15.Visible = true;
                     comboBox17.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label6.Visible = true;
                    label7.Visible = true;
                    comboBox6.Visible = true;
                    comboBox5.Visible = true;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                    break;
                case 1:
                    label6.Visible = true;
                    label7.Visible = true;
                    comboBox8.Visible = true;
                    comboBox5.Visible = true;
                    comboBox6.Visible = false;
                    comboBox7.Visible = false;
                    comboBox9.Visible = false;
                    break;
                case 2:
                    label6.Visible = true;
                    label7.Visible = true;
                    comboBox7.Visible = true;
                    comboBox5.Visible = true;
                    comboBox8.Visible = false;
                   
                    comboBox6.Visible = false;
                    comboBox9.Visible = false;
                    break;
                case 3:
                    label13.Visible = true;
                    label7.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$35.00";
                    comboBox5.Visible = true;
                    comboBox6.Visible = false;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                    break;
                case 4:
                    label6.Visible = true;
                    label7.Visible = true;
                    comboBox9.Visible = true;
                    comboBox5.Visible = true;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox6.Visible = false;
                    break;
                case 5:
                    label13.Visible = true;
                    label7.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$35.00";
                    comboBox5.Visible = true;
                    comboBox5.Visible = true;
                    comboBox6.Visible = false;
                    comboBox7.Visible = false;
                    comboBox8.Visible = false;
                    comboBox9.Visible = false;
                    break;
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
    
            switch (comboBox6.SelectedIndex)
            {
                case 0:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$25.00";
                    break;
                default:
                    break;
            }
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.SelectedIndex)
            {
                case 0:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$32.00";
                    break;
                case 1:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$33.00";
                    break;
                case 2:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$34.00";
                    break;
            }
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.SelectedIndex)
            {
                case 0:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$34.00";
                    break;
                case 1:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$35.00";
                    break;
                case 2:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$36.00";
                    break;
            }

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.SelectedIndex)
            {
                case 0:
                    label13.Visible = true;
                    comboBox10.Visible = true;
                    textBox1.Text = "$36.00";
                    break;
                
            }
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = 0.0;

            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            switch (comboBox10.SelectedIndex)
            {
                 case 0:
                    
                    price = pre_price1 + price;
                    textBox1.Text = (price + 8).ToString("C");
                    pre_price1 = pre_price1 - 8;
                    break;
                case 1:
                    price = pre_price1 + price ;
                    textBox1.Text = (price + 6).ToString("C");
                    pre_price1 = pre_price1 - 6;
                  
                    break;
                case 2:
                    price = pre_price1 + price ;
                    textBox1.Text = (price + 6).ToString("C");
                    pre_price1 = pre_price1 - 6;
                  
                    break;
                default:
                    break;
              
            }
           
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox5.SelectedIndex)
            {
                case 0:
                    comboBox11.Visible = true;
                    comboBox12.Visible = true;
                    break;
                case 1:
                    comboBox12.Visible = true;
                   break;
                case 2:
                   
                    comboBox12.Visible = true;
              
                    break;
            }
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            double price = 0.0;
           
            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            
            switch (comboBox11.SelectedIndex)
            {
               
                case 0:
                    price = pre_price2 + price;
                    textBox1.Text = (price + 5).ToString("C");
                    pre_price2 = pre_price2 - 5;
                    break;
                case 1:
                    price = pre_price2 + price;
                    textBox1.Text = (price + 7).ToString("C");
                    pre_price2 = pre_price2 - 7;

                    break;
                default:
                    break;

            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             pre_price = 0.0;
             pre_price1 = 0.0;
             pre_price2 = 0.0;
            pre_price3 = 0.0;
             pre_price4 = 0.0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
          
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            label6.Visible = false;
            label9.Visible = false;
            label13.Visible = false;
            label7.Visible = false;
            label15.Visible = false;
            comboBox5.Visible = false;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox6.Visible = false;
            comboBox7.Visible = false;
            comboBox7.SelectedIndex = -1;
            comboBox8.Visible = false;
            comboBox8.SelectedIndex = -1;
            comboBox9.Visible = false;
            comboBox9.SelectedIndex = -1;
            comboBox10.Visible = false;
            comboBox10.SelectedIndex = -1;
            comboBox11.Visible = false;
            comboBox11.SelectedIndex = -1;
            comboBox12.Visible = false;
            comboBox12.SelectedIndex = -1;
            comboBox13.Visible = false;
            comboBox13.SelectedIndex = -1;
            comboBox14.Visible = false;
            comboBox14.SelectedIndex = -1;
            comboBox15.Visible = false;
            comboBox15.SelectedIndex = -1;
            comboBox16.Visible = false;
            comboBox16.SelectedIndex = -1;
            comboBox17.Visible = false;
            comboBox17.SelectedIndex = -1;
            comboBox18.Visible = false;
            comboBox18.SelectedIndex = -1;
            comboBox19.Visible = false;
            comboBox19.SelectedIndex = -1;
            label14.Visible = false;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox20.Visible = false;
            comboBox20.SelectedIndex = -1;


        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double tax;
            double.TryParse(textBox6.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out tax);
            textBox7.Text = (tax * 0.08).ToString("C");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = 0;
            String sb = "";
            String sb1 = "";
            try
            {
                number = Convert.ToInt32(textBox9.Text);
                if (number < 0)
                {
                    MessageBox.Show("Please enter the valid number of table");
                    textBox9.Text = " ";
                }
                using (StreamWriter Writer = new StreamWriter("bill.txt"))
                {
                    Writer.WriteLine("                                   CLIFF HOUSE RESTAURANT");
                    Writer.WriteLine("Table: #" + textBox9.Text);
                    Writer.WriteLine();
                    Writer.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++INVOICE+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Writer.WriteLine();
                    if (comboBox1.SelectedIndex > -1)
                    {
                        if (comboBox6.SelectedIndex > -1)
                        {
                            sb = comboBox1.Text + " " + comboBox6.Text + " " + comboBox10.Text + " And " + comboBox12.Text + " And " +
                            comboBox11.Text + " " + comboBox5.Text; 
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox1.Text));
                        }
                        else if (comboBox8.SelectedIndex > -1)
                        {
                            sb = comboBox1.Text + " " + comboBox8.Text + " " + comboBox10.Text + " And " + comboBox12.Text + " And " + 
                            comboBox11.Text + " " + comboBox5.Text;
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox1.Text));
                        }
                        else if (comboBox7.SelectedIndex > -1)
                        {
                            sb = comboBox1.Text + " " + comboBox7.Text + " " + comboBox10.Text + " And " + comboBox12.Text + " And " +
                            comboBox11.Text + " " + comboBox5.Text;
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox1.Text));
                        }
                        else if (comboBox9.SelectedIndex > -1)
                        {
                            sb = comboBox1.Text + " " + comboBox9.Text + " " + comboBox10.Text + " And " + comboBox12.Text + " And " +
                             comboBox11.Text + " " + comboBox5.Text;
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox1.Text));
                        }
                        else
                        {
                            sb1 = comboBox1.Text + " " + comboBox10.Text + " And " + comboBox12.Text + " And " +
                            comboBox11.Text + " " + comboBox5.Text;
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", sb1, textBox1.Text));
                        }

                    }
                    if (comboBox2.SelectedIndex > -1)
                    {
                        sb = comboBox2.Text + " " + comboBox13.Text + " And " + comboBox14.Text + " And " +
                           comboBox15.Text + "" + comboBox16.Text;
                        Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox2.Text));
                    }
                    if (comboBox3.SelectedIndex > -1)
                    {

                        sb = comboBox3.Text + " And " + comboBox18.Text + " And " + comboBox19.Text + " " +
                               comboBox17.Text;
                        Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox3.Text));

                    }
                    if (comboBox4.SelectedIndex > -1)
                    {
                        if (comboBox20.SelectedIndex > -1)
                        {
                            sb = comboBox4.Text + " " + comboBox20.Text;
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", sb, textBox4.Text));

                        }
                        else
                            Writer.WriteLine(String.Format("{0,-101}{1,20}", comboBox4.Text, textBox4.Text));
                    }
                    Writer.WriteLine();
                    Writer.WriteLine("-------------------------------------------------------------------------------------------------------------------------");
                    Writer.WriteLine(String.Format("{0,111}{1,10}", "Subtotal", textBox6.Text));
                    Writer.WriteLine(String.Format("{0,111}{1,10}", "Tax(8%)", textBox7.Text));
                    Writer.WriteLine(String.Format("{0,111}{1,10}", "Total", textBox8.Text));
                    Writer.WriteLine("                                              ++++THANK YOU++++");
                }

            }
            catch 
            {
                MessageBox.Show("Please enter the valid number of table");
                textBox9.Text = " ";
            }
          
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    comboBox20.Visible = true;
                    textBox4.Text = "$8.00";

                    break;
                case 1:
                    textBox4.Text = "$7.50";
                    break;
                case 2:
                    textBox4.Text = "$7.50";
                    break;
                case 3:
                    textBox4.Text = "$7.00";
                    break;
                case 4:
                    textBox4.Text = "$8.00";
                    break;
                case 5:
                    textBox4.Text = "$9.00";
                    break;
                default:
                    break;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double price; double price1; double price2; double price3;
            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price1);
            double.TryParse(textBox3.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price2);
            double.TryParse(textBox4.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price3);
          

            textBox6.Text = (price + price1 + price2 + price3 ).ToString("C");
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double price; double price1; double price2; double price3; 

            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price1);
            double.TryParse(textBox3.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price2);
            double.TryParse(textBox4.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price3);
         
      
            textBox6.Text = (price + price1 + price2 + price3).ToString("C");
        
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double price; double price1; double price2; double price3; 
            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price1);
            double.TryParse(textBox3.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price2);
            double.TryParse(textBox4.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price3);
           
            textBox6.Text = (price + price1 + price2 + price3 ).ToString("C");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double price; double tax;
            double.TryParse(textBox7.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out tax);
            double.TryParse(textBox6.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            textBox8.Text = (price + tax).ToString("C");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double price; double price1; double price2; double price3; 
            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price1);
            double.TryParse(textBox3.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price2);
            double.TryParse(textBox4.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price3);
         

            textBox6.Text = (price + price1 + price2 + price3 ).ToString("C");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double price; double price1; double price2; double price3;
            double.TryParse(textBox1.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price1);
            double.TryParse(textBox3.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price2);
            double.TryParse(textBox4.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price3);
           

            textBox6.Text = (price + price1 + price2 + price3 ).ToString("C");
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = 0.0;
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);



            switch (comboBox13.SelectedIndex)
            {

                   case 0:
                       price = pre_price + price;
                       textBox2.Text = (price + 6).ToString("C");
                       pre_price = pre_price - 6;
                       break;
                   case 1:
                       price = pre_price + price;
                       textBox2.Text = (price + 6).ToString("C");
                       pre_price = pre_price - 6;
                       
                       break;
                   default:
                       break;
            }
        }



                  
        
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox14.SelectedIndex)
            {
                case 0:
                    comboBox16.Visible = true;
                    comboBox15.Visible = true;
                    break;
                case 1:
                    comboBox15.Visible = true;
                    break;
                case 2:

                    comboBox15.Visible = true;

                    break;
            }
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = 0.0;
            double.TryParse(textBox2.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            switch (comboBox16.SelectedIndex)
            {
                case 0:
                    price = pre_price3 + price;
                    textBox2.Text = (price + 5).ToString("C");
                    pre_price3 = pre_price3 - 5;
                    break;
                case 1:
                    price = pre_price3 + price;
                    textBox2.Text = (price + 7).ToString("C");
                    pre_price3 = pre_price3 - 7;

                    break;
                default:
                    break;
            }
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox17.SelectedIndex)
            {
                case 0:
                    comboBox19.Visible = true;
                    comboBox18.Visible = true;
                    break;
                case 1:
                    comboBox18.Visible = true;
                    break;
                case 2:

                    comboBox18.Visible = true;

                    break;
            }
        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = 0.0;
            double.TryParse(textBox3.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            switch (comboBox19.SelectedIndex)
            {
                case 0:
                    
                  
                   
                    price = pre_price4 + price;
                    textBox3.Text = (price + 5).ToString("C");
                    pre_price4 = pre_price4 - 5;
                   
                   
                    break;
                case 1:
                  
                    price = pre_price4 + price;
                    textBox3.Text = (price + 7).ToString("C");
                    pre_price4 = pre_price4 - 7;
                  
                 
                   
                    break;
                default:
                    break;
            }
        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {
            double price = 0.0;
            double.TryParse(textBox4.Text, System.Globalization.NumberStyles.Currency, System.Globalization.CultureInfo.CurrentCulture, out price);
            switch (comboBox20.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    textBox4.Text = (price + 3).ToString("C");
                    break;
                default:
                    break;
            }
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
