/* Name: Toan Nguyen
 * Class: Cs351
 * Program 1: Grade Organizer
 * Grade Organizer is allow user to enter the score and program will calculate the min,max,sum,median,mean and also sort the score up down
  */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Visible = false;
            textBox2.Visible = false;
            textBox2.Text = "Please type the curve seed here";
            button4.Visible = false;
            List<string> _items = new List<string>();
            _items.Add("up (sort grades in ascending)");
            _items.Add("down (sort grades in descending)");
            _items.Add("max (maximum grade)");
            _items.Add("min (minimum grade)");
            _items.Add("sum (sum of all grades)");
            _items.Add("median (median grade)");
            _items.Add("mean (mean value)");
            _items.Add("stdev (standard deviation)");
            _items.Add("new (allow user to enter a new list of grades)");
            _items.Add("curve (simply adds an integer to all values)");
            listBox1.DataSource = _items;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int sum = 0; int m = 0;
            double mean = 0.0;
            double variance = 0.0;
            double standard = 0.0;
            double samplestd = 0.0;



            int minvalue = 0;
            int maxvalue = 0;

            int[] myArray = new int[listBox2.Items.Count];
            int[] myArray2 = new int[listBox2.Items.Count];

            for (int h = 0; h < listBox2.Items.Count; h++)
            {
                myArray[h] = Convert.ToInt32(listBox2.Items[h]);
                myArray2[h] = Convert.ToInt32(listBox2.Items[h]);


            }
            sum = myArray.Sum();
            minvalue = myArray.Min();
            maxvalue = myArray.Max();
            mean = myArray.Average();
            Array.Sort(myArray);
            Array.Sort(myArray2);
            Array.Reverse(myArray2);
            while (m < listBox2.Items.Count)
            {
                variance += (Math.Pow((Convert.ToInt32(listBox2.Items[m++]) - mean), 2));
            }
            standard = Math.Sqrt(variance / m);
            samplestd = Math.Sqrt(variance / (m - 1));
            double number3 = 0.0;


            if (myArray.Length % 2 != 0)
            {
                number3 = myArray[myArray.Length / 2];
            }
            else if (myArray.Length % 2 == 0)
            {
                number3 = Convert.ToDouble((myArray[myArray.Length / 2] + myArray[(myArray.Length / 2) - 1])) / 2;
            }



            for (int i = 0; i < listBox1.SelectedItems.Count; i++)
            {

                string value = listBox1.SelectedItems[i].ToString();


                switch (value)
                {
                    case "up (sort grades in ascending)":

                        listBox3.Items.Clear();
                        foreach (int num in myArray)
                        {
                            listBox3.Items.Add(num);
                        }
                        break;
                    case "down (sort grades in descending)":

                        listBox3.Items.Clear();
                        foreach (int num2 in myArray2)
                        {
                            listBox3.Items.Add(num2);
                        }
                        break;
                    case "min (minimum grade)":

                        listBox3.Items.Clear();
                        listBox3.Items.Add(minvalue);



                        break;
                    case "max (maximum grade)":

                        listBox3.Items.Clear();
                        listBox3.Items.Add(maxvalue);
                        break;
                    case "sum (sum of all grades)":

                        listBox3.Items.Clear();
                        listBox3.Items.Add(sum);
                        break;
                    case "median (median grade)":

                        listBox3.Items.Clear();
                        listBox3.Items.Add(number3);
                        break;
                    case "mean (mean value)":

                        listBox3.Items.Clear();
                        listBox3.Items.Add(mean);
                        break;
                    case "stdev (standard deviation)":

                        listBox3.Items.Clear();
                        listBox3.Items.Add(samplestd);
                        break;
                    case "new (allow user to enter a new list of grades)":
                        listBox2.Items.Clear();
                        listBox3.Items.Clear();
                        break;
                    case "curve (simply adds an integer to all values)":
                        textBox2.Visible = true;
                        button4.Visible = true;
                        textBox2.Focus();
                        break;
                    default:
                        break;
                }



            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int value = Convert.ToInt32(textBox1.Text);


                if (value <= 100 && value >= 0)
                {
                    listBox2.Items.Add(value);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("ALL INPUT MUST BE VALIDED");
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            catch
            {
                MessageBox.Show("ALL INPUT MUST BE VALIDED");
                textBox1.Clear();
                textBox1.Focus();
            }






        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            int[] curarray = new int[listBox2.Items.Count];
          
            for (int h = 0; h < listBox2.Items.Count; h++)
            {
                curarray[h] = Convert.ToInt32(listBox2.Items[h]);

            }

            try
            {
                int curve = Convert.ToInt32(textBox2.Text);
                if (curve >= 1 && curve <= 10)
                {
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    foreach (int m in curarray)
                    {


                        if (m + curve <= 100)
                        {
                            
                            listBox2.Items.Add(m + curve);
                            listBox3.Items.Add(m + curve);
                        }
                        else
                        {
                            listBox3.Items.Add("100");
                            listBox2.Items.Add("100");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Curve must be in range 1-10");
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Curve must be in range 1-10");
                textBox2.Clear();
                textBox2.Focus();
            }


        }

       

  


    }
}
