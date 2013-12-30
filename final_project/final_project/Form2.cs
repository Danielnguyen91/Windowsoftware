using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form2 : Form
    {
        int region = 0;
        Point location1 = new Point(492, 382);
        Point location2 = new Point(543, 412);
        Point location3 = new Point(588, 429);
        Point location4 = new Point(101, 165);
        Point location5 = new Point(425, 315);
        Point location6 = new Point(552, 337);
        Point location7 = new Point(661, 329);
        Point location8 = new Point(593, 203);
        Point location9 = new Point(336, 20);
        Point location10 = new Point(500, 25);
        Point location11 = new Point(624, 90);
        Point location12 = new Point(81, 372);
        Point location13 = new Point(275, 394);
        Point location14 = new Point(393, 369);
        Point location15 = new Point(375, 549);
        List<Point> points = new List<Point>();
       
        public Form2()
        {
            InitializeComponent();
        }
        public List<Point> sendpoint
        {
            get
            {
                return points;
            }
        }
        public void delete()
        {
            points.Clear();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch(comboBox1.SelectedIndex)
            {
                   
                case 0:
                    points.Add(location1);
                    
                    break;
                case 1:
                    points.Add(location2);
                    break;
                case 2:
                    points.Add(location3);
                    break;
                case 3:
                    points.Add(location4);
                    break;
                case 4:
                    points.Add(location5);
                    break;
                case 5:
                    points.Add(location6);
                    break;
                case 6:
                    points.Add(location7);
                    break;
                case 7:
                    points.Add(location8);
                    break;
                case 8:
                    points.Add(location9);
                    break;
                case 9:
                    points.Add(location10);
                    break;
                case 10:
                    points.Add(location11);
                    break;
                case 11:
                    points.Add(location12);
                    break;
                case 12:
                    points.Add(location13);
                    break;
                case 13:
                    points.Add(location14);
                    break;
                case 14:
                    points.Add(location15);
                    break;
                default:
                    break;

                  
        }

        }
      
        private void button_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {

                case 0:
                    points.Add(location1);

                    break;
                case 1:
                    points.Add(location2);
                    break;
                case 2:
                    points.Add(location3);
                    break;
                case 3:
                    points.Add(location4);
                    break;
                case 4:
                    points.Add(location5);
                    break;
                case 5:
                    points.Add(location6);
                    break;
                case 6:
                    points.Add(location7);
                    break;
                case 7:
                    points.Add(location8);
                    break;
                case 8:
                    points.Add(location9);
                    break;
                case 9:
                    points.Add(location10);
                    break;
                case 10:
                    points.Add(location11);
                    break;
                case 11:
                    points.Add(location12);
                    break;
                case 12:
                    points.Add(location13);
                    break;
                case 13:
                    points.Add(location14);
                    break;
                case 14:
                    points.Add(location15);
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
                    points.Add(location1);

                    break;
                case 1:
                    points.Add(location2);
                    break;
                case 2:
                    points.Add(location3);
                    break;
                case 3:
                    points.Add(location4);
                    break;
                case 4:
                    points.Add(location5);
                    break;
                case 5:
                    points.Add(location6);
                    break;
                case 6:
                    points.Add(location7);
                    break;
                case 7:
                    points.Add(location8);
                    break;
                case 8:
                    points.Add(location9);
                    break;
                case 9:
                    points.Add(location10);
                    break;
                case 10:
                    points.Add(location11);
                    break;
                case 11:
                    points.Add(location12);
                    break;
                case 12:
                    points.Add(location13);
                    break;
                case 13:
                    points.Add(location14);
                    break;
                case 14:
                    points.Add(location15);
                    break;
                default:
                    break;


            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {

                case 0:
                    points.Add(location1);

                    break;
                case 1:
                    points.Add(location2);
                    break;
                case 2:
                    points.Add(location3);
                    break;
                case 3:
                    points.Add(location4);
                    break;
                case 4:
                    points.Add(location5);
                    break;
                case 5:
                    points.Add(location6);
                    break;
                case 6:
                    points.Add(location7);
                    break;
                case 7:
                    points.Add(location8);
                    break;
                case 8:
                    points.Add(location9);
                    break;
                case 9:
                    points.Add(location10);
                    break;
                case 10:
                    points.Add(location11);
                    break;
                case 11:
                    points.Add(location12);
                    break;
                case 12:
                    points.Add(location13);
                    break;
                case 13:
                    points.Add(location14);
                    break;
                case 14:
                    points.Add(location15);
                    break;
                default:
                    break;


            }
        }
        
      
       
    }
}
