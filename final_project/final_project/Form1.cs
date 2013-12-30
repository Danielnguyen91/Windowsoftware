/*
 * Name: Toan Nguyen
 * Class: Csci 351
 * Final Project
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

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
        Point bridgea = new Point(164, 300);
        Point bridgeb = new Point(309, 300);
        Point bridgec = new Point(415, 350);
        Point bridged = new Point(518, 404);
        Point bridgeE = new Point(605, 442);
        int landlocation = 0;
        int landlocation2 = 0;
        bool move = false;
        private Point startlocation;
        double speed = 8f;
        List<Point> points = new List<Point>();
        List<Point> points2 = new List<Point>();
        List<Point> points3 = new List<Point>();
        List<Point> bridge = new List<Point>();
        List<Point> bridge2 = new List<Point>();
        List<Point> bridge3 = new List<Point>();
        private int index = 0;
        private int index2 = 0;
        private int index3 = 0;
        bool isabove = false;
        bool isabove2 = false;
        Graphics graph;
        static double distance(Point p, Point r)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(p.X - r.X), 2) + Math.Pow(Math.Abs(p.Y - r.Y), 2));
            
            
        }
      
        private Point closesPoint(List<Point> bridge)
        {
            bridge.Add(bridgea);
            bridge.Add(bridgeb);
            bridge.Add(bridgec);
            bridge.Add(bridged);
            bridge.Add(bridgeE);

            Point start = icon1.Location;
            
            Point result = bridge[0];
            foreach (Point pt in bridge)
            {
                if (distance(start, pt) < distance(start, result))
                {
                    result = pt;
                }
            }
           
        

            return result ;
           
        }
        private Point closesPoint2(List<Point> bridge2)
        {
            bridge2.Add(bridgea);
            bridge2.Add(bridgeb);
            bridge2.Add(bridgec);
            bridge2.Add(bridged);
            bridge2.Add(bridgeE);

            Point start = icon2.Location;

            Point result = bridge2[0];
            foreach (Point pt in bridge2)
            {
                if (distance(start, pt) < distance(start, result))
                {
                    result = pt;
                }
            }



            return result;

        }
        private Point closesPoint3(List<Point> bridge3)
        {
            bridge3.Add(bridgea);
            bridge3.Add(bridgeb);
            bridge3.Add(bridgec);
            bridge3.Add(bridged);
            bridge3.Add(bridgeE);

            Point start = icon3.Location;

            Point result = bridge3[0];
            foreach (Point pt in bridge3)
            {
                if (distance(start, pt) < distance(start, result))
                {
                    result = pt;
                }
            }



            return result;

        }

      
        private bool above()
        {
            if ((icon1.Left > 0) && (icon1.Left < 1269))
            {
                if (icon1.Top < 300)
                {
                    isabove = true;
                   // richTextBox1.Text = isabove.ToString();

                }
            }
            if ((icon1.Left > 753) && (icon1.Left < 1269))
            {
                if ((icon1.Top > 300))
                {
                    isabove = true;
                   // richTextBox1.Text = isabove.ToString();
                    
                }
            }
           if ((icon1.Left > 431) && (icon1.Left < 684))
            {
                if (icon1.Top < 339)
                {
                    isabove = true;
                }
            }
            
            return isabove;
        }
        private bool below()
        {
            if ((icon1.Left > 88) && (icon1.Left < 432))
            {
                if (icon1.Top < 366)
                {
                    isabove = false;
                }
            }
            return isabove;

        }
        private bool above2()
        {
            if ((icon2.Left > 0) && (icon2.Left < 1269))
            {
                if (icon2.Top < 300)
                {
                    isabove2 = true;
                    // richTextBox1.Text = isabove.ToString();

                }
            }
            if ((icon2.Left > 753) && (icon2.Left < 1269))
            {
                if ((icon2.Top > 300))
                {
                    isabove2 = true;
                    // richTextBox1.Text = isabove.ToString();

                }
            }
            if ((icon2.Left > 431) && (icon2.Left < 684))
            {
                if (icon2.Top < 339)
                {
                    isabove2 = true;
                }
            }

            return isabove2;
        }
        private int landscape()
        {
            if (points[index] == location1)
            {
                landlocation = 3;
            }
            else if (points[index] == location2)
            {
                landlocation = 3;
            }
            else if (points[index] == location3)
            {
                landlocation = 4;
            }
            else if (points[index] == location4)
            {
                landlocation = 1;
            }
            else if (points[index] == location5)
            {
                landlocation = 1;

            }
            else if (points[index] == location6)
            {
                landlocation = 1;
            }
            else if (points[index] == location7)
            {
                landlocation = 1;
            }
            else if (points[index] == location8)
            {
                landlocation = 1;
            }
            else if (points[index] == location9)
            {
                landlocation = 1;
            }
            else if (points[index] == location10)
            {
                landlocation = 1;
            }
            else if (points[index] == location11)
            {
                landlocation = 1;
            }
            else if (points[index] == location12)
            {
                landlocation = 2;
            }
            else if (points[index] == location13)
            {
                landlocation = 2;
            }
            else if (points[index] == location14)
            {
                landlocation = 2;
            }
            else if (points[index] == location15)
            {
                landlocation = 2;
            }
            return landlocation;

        }
        private int landscape2()
        {
            if (points2[index2] == location1)
            {
                landlocation2 = 3;
            }
            else if (points2[index2] == location2)
            {
                landlocation2 = 3;
            }
            else if (points2[index2] == location3)
            {
                landlocation2 = 4;
            }
            else if (points2[index2] == location4)
            {
                landlocation2 = 1;
            }
            else if (points2[index2] == location5)
            {
                landlocation2 = 1;

            }
            else if (points2[index2] == location6)
            {
                landlocation2 = 1;
            }
            else if (points2[index2] == location7)
            {
                landlocation2 = 1;
            }
            else if (points2[index2] == location8)
            {
                landlocation2 = 1;
            }
            else if (points2[index2] == location9)
            {
                landlocation = 1;
            }
            else if (points2[index2] == location10)
            {
                landlocation2 = 1;
            }
            else if (points2[index2] == location11)
            {
                landlocation2 = 1;
            }
            else if (points2[index2] == location12)
            {
                landlocation2 = 2;
            }
            else if (points2[index2] == location13)
            {
                landlocation2 = 2;
            }
            else if (points2[index2] == location14)
            {
                landlocation2 = 2;
            }
            else if (points2[index2] == location15)
            {
                landlocation2 = 2;
            }
            return landlocation2;

        }
       
       
        private void icon_down(object sender, MouseEventArgs e)
        {
            move = true;
            if (e.Button == MouseButtons.Left)
            {
                startlocation = e.Location;
            }


        }

        private void icon_up(object sender, MouseEventArgs e)
        {
            move = false;
           
          using (Form2 form2 = new Form2())
            {
                form2.delete();
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    points = form2.sendpoint;
                    this.timer1.Enabled = true;
                 
                    
                }
            }
          
          
           
        }

        private void icon_move(object sender, MouseEventArgs e)
        {
            if (move)
            {
                icon1.Left += e.Location.X - startlocation.X;
                icon1.Top += e.Location.Y - startlocation.Y;
            }

        }

        private void icon2_down(object sender, MouseEventArgs e)
        {
            move = true;
            if (e.Button == MouseButtons.Left)
            {
                startlocation = e.Location;
            }
        }

        private void icon2_up(object sender, MouseEventArgs e)
        {
            move = false;
            using (Form2 form2 = new Form2())
            {
                form2.delete();
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    points2 = form2.sendpoint;
                    this.timer2.Enabled = true;
                    if (points2.Count > 0)
                    {
                        foreach (var pt in points)
                        {
                            richTextBox1.Text = pt.ToString();
                        }
                    }
                    else MessageBox.Show("nothing");
                }


            }
        }

        private void icon2_move(object sender, MouseEventArgs e)
        {
            if (move)
            {
                icon2.Left += e.Location.X - startlocation.X;
                icon2.Top += e.Location.Y - startlocation.Y;
            }
        }

        private void icon3_down(object sender, MouseEventArgs e)
        {
            move = true;
            if (e.Button == MouseButtons.Left)
            {
                startlocation = e.Location;
            }
        }

        private void icon3_up(object sender, MouseEventArgs e)
        {
            move = false;
            using (Form2 form2 = new Form2())
            {
                form2.delete();
                if (form2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    points3 = form2.sendpoint;
                    this.timer3.Enabled = true;
                    if (points3.Count > 0)
                    {
                        foreach (var pt in points)
                        {
                            richTextBox1.Text = pt.ToString();
                        }
                    }
                    else MessageBox.Show("nothing");
                }


            }
        }

        private void icon3_move(object sender, MouseEventArgs e)
        {
            if (move)
            {
                icon3.Left += e.Location.X - startlocation.X;
                icon3.Top += e.Location.Y - startlocation.Y;
            }
        }



        private void map_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = e.Location.ToString();
        }




        /* private void draw_picture(object sender, PaintEventArgs e)
         {
              Graphics g = e.Graphics;


              if ((icon1.Left != points[index].X) && (icon1.Top != points[index].Y))
              {
                g.DrawLine(new Pen(Color.Red, 3), icon1.Left,icon1.Top, points[index].X, points[index].Y);
             
              }
            
             
        }*/

        private void timer1_Tick(object sender, EventArgs e)
        {

            graph = map.CreateGraphics();
            double xtrue = icon1.Left;
            double ytrue = icon1.Top;

            double dir;




            if ((icon1.Left != points[index].X) && (icon1.Top != points[index].Y))
            {
                if (above() && (landscape() == 1))
                {
                    dir = (float)(Math.Atan2(points[index].Y - ytrue, points[index].X - xtrue) * 180 / Math.PI);
                    xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                    ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                    icon1.Left = (int)xtrue;
                    icon1.Top = (int)ytrue;


                    graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, points[index].X, points[index].Y);

                    if ((Math.Abs(icon1.Left - points[index].X) < 5) && ((Math.Abs(icon1.Top - points[index].Y)) < 5))
                    {
                        icon1.Location = points[index];
                    }
                    if ((icon1.Left == points[index].X) && (icon1.Top < points[index].Y))
                    {
                        xtrue++;
                        ytrue--;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;

                    }
                    else if ((icon1.Left == points[index].X) && (icon1.Top > points[index].Y))
                    {
                        xtrue++;
                        ytrue++;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                    }
                    if ((icon1.Left < points[index].X) && (icon1.Top == points[index].Y))
                    {
                        ytrue++;
                        xtrue++;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                    }
                    else if ((icon1.Left > points[index].X) && (icon1.Top == points[index].Y))
                    {
                        ytrue++;
                        xtrue--;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                    }


                }
                else if (!above() && (landscape() == 2))
                {
                    dir = (float)(Math.Atan2(points[index].Y - ytrue, points[index].X - xtrue) * 180 / Math.PI);
                    xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                    ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                    icon1.Left = (int)xtrue;
                    icon1.Top = (int)ytrue;


                    graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, points[index].X, points[index].Y);
                    graph.DrawLine(new Pen(Color.Red, 3), icon1.Right, icon1.Top, points[index].X, points[index].Y);
                    if ((Math.Abs(icon1.Left - points[index].X) < 5) && ((Math.Abs(icon1.Top - points[index].Y)) < 5))
                    {
                        icon1.Location = points[index];
                    }
                    if ((icon1.Left == points[index].X) && (icon1.Top < points[index].Y))
                    {
                        xtrue++;
                        ytrue--;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;

                    }
                    else if ((icon1.Left == points[index].X) && (icon1.Top > points[index].Y))
                    {
                        xtrue++;
                        ytrue++;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                    }
                    if ((icon1.Left < points[index].X) && (icon1.Top == points[index].Y))
                    {
                        ytrue++;
                        xtrue++;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                    }
                    else if ((icon1.Left > points[index].X) && (icon1.Top == points[index].Y))
                    {
                        ytrue++;
                        xtrue--;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                    }



                }



                else if ((above() && (landscape() == 2)))
                {

                    if (((icon1.Left != closesPoint(bridge).X) && (icon1.Top != closesPoint(bridge).Y)))
                    {
                        dir = (float)(Math.Atan2(closesPoint(bridge).Y - ytrue, closesPoint(bridge).X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, closesPoint(bridge).X, closesPoint(bridge).Y);
                        if ((icon1.Left == (closesPoint(bridge).X)) && (icon1.Top < (closesPoint(bridge).Y)))
                        {
                            xtrue++;
                            ytrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;

                        }
                        else if ((icon1.Left == (closesPoint(bridge).X)) && (icon1.Top > (closesPoint(bridge).Y)))
                        {
                            xtrue++;
                            ytrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        if ((icon1.Left < (closesPoint(bridge).X)) && (icon1.Top == (closesPoint(bridge).Y)))
                        {
                            ytrue++;
                            xtrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        else if ((icon1.Left > (closesPoint(bridge).X)) && (icon1.Top == (closesPoint(bridge).Y)))
                        {
                            ytrue++;
                            xtrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        if ((Math.Abs(icon1.Left - (closesPoint(bridge).X)) < 10) || ((Math.Abs(icon1.Top - (closesPoint(bridge).Y)) < 10)))
                        {
                            icon1.Location = closesPoint(bridge);

                        }

                    }


                    if ((icon1.Left == closesPoint(bridge).X) && (icon1.Top == closesPoint(bridge).Y))
                    {
                        /*  ytrue++;
                          xtrue--;
                          icon1.Left = (int)xtrue;
                          icon1.Top = (int)ytrue;*/
                        icon1.Left = points[index].X;
                        icon1.Top = points[index].Y;
                        isabove = false;
                    }








                }
                else if ((!above()) && (landscape() == 1))
                {
                    if (((icon1.Left != closesPoint(bridge).X) && (icon1.Top != closesPoint(bridge).Y)))
                    {
                        dir = (float)(Math.Atan2(closesPoint(bridge).Y - ytrue, closesPoint(bridge).X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, closesPoint(bridge).X, closesPoint(bridge).Y);
                        if ((icon1.Left == (closesPoint(bridge).X)) && (icon1.Top < (closesPoint(bridge).Y)))
                        {
                            xtrue++;
                            ytrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;

                        }
                        else if ((icon1.Left == (closesPoint(bridge).X)) && (icon1.Top > (closesPoint(bridge).Y)))
                        {
                            xtrue++;
                            ytrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        if ((icon1.Left < (closesPoint(bridge).X)) && (icon1.Top == (closesPoint(bridge).Y)))
                        {
                            ytrue++;
                            xtrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        else if ((icon1.Left > (closesPoint(bridge).X)) && (icon1.Top == (closesPoint(bridge).Y)))
                        {
                            ytrue++;
                            xtrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }

                    }
                    if ((Math.Abs(icon1.Left - (closesPoint(bridge).X)) < 10) && ((Math.Abs(icon1.Top - (closesPoint(bridge).Y)) < 10)))
                    {
                        icon1.Location = closesPoint(bridge);


                    }
                    if ((icon1.Left == closesPoint(bridge).X) && (icon1.Top == closesPoint(bridge).Y))
                    {
                        ytrue++;
                        xtrue--;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                        /*    icon1.Left = points[index].X;
                            icon1.Top = points[index].Y;*/
                    }
                }
                else if ((landscape() == 3))
                {
                    if (((icon1.Left != 518) && (icon1.Top != 404)))
                    {
                        dir = (float)(Math.Atan2(404 - ytrue, 518 - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, 404, 518);
                        if ((icon1.Left == 518) && (icon1.Top < 404))
                        {
                            xtrue++;
                            ytrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;

                        }
                        else if ((icon1.Left == 518) && (icon1.Top > 404))
                        {
                            xtrue++;
                            ytrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        if ((icon1.Left < 518) && (icon1.Top == 404))
                        {
                            ytrue++;
                            xtrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        else if ((icon1.Left > 518) && (icon1.Top == 404))
                        {
                            ytrue++;
                            xtrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }

                    }
                    if ((Math.Abs(icon1.Left - 518) < 10) && ((Math.Abs(icon1.Top - 404) < 10)))
                    {
                        icon1.Location = bridged;

                    }
                    if ((icon1.Left == 518) && (icon1.Top == 404))
                    {

                        icon1.Left = points[index].X;
                        icon1.Top = points[index].Y;
                    }
                    if (above() && (landscape() == 1))
                    {
                        dir = (float)(Math.Atan2(points[index].Y - ytrue, points[index].X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;


                        graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, points[index].X, points[index].Y);
                        graph.DrawLine(new Pen(Color.Red, 3), icon1.Right, icon1.Top, points[index].X, points[index].Y);
                        if ((Math.Abs(icon1.Left - points[index].X) < 5) && ((Math.Abs(icon1.Top - points[index].Y)) < 5))
                        {
                            icon1.Location = points[index];
                        }
                        if ((icon1.Left == points[index].X) && (icon1.Top < points[index].Y))
                        {
                            xtrue++;
                            ytrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;

                        }
                        else if ((icon1.Left == points[index].X) && (icon1.Top > points[index].Y))
                        {
                            xtrue++;
                            ytrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        if ((icon1.Left < points[index].X) && (icon1.Top == points[index].Y))
                        {
                            ytrue++;
                            xtrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        else if ((icon1.Left > points[index].X) && (icon1.Top == points[index].Y))
                        {
                            ytrue++;
                            xtrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }


                    }

                }
                else if ((landscape() == 4))
                {
                    if (((icon1.Left != 605) && (icon1.Top != 442)))
                    {
                        dir = (float)(Math.Atan2(442 - ytrue, 605 - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, 605, 442);
                        if ((icon1.Left == 518) && (icon1.Top < 404))
                        {
                            xtrue++;
                            ytrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;

                        }
                        else if ((icon1.Left == 518) && (icon1.Top > 404))
                        {
                            xtrue++;
                            ytrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        if ((icon1.Left < 518) && (icon1.Top == 404))
                        {
                            ytrue++;
                            xtrue++;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }
                        else if ((icon1.Left > 518) && (icon1.Top == 404))
                        {
                            ytrue++;
                            xtrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                        }


                        if ((Math.Abs(icon1.Left - 605) < 5) && ((Math.Abs(icon1.Top - 442) < 5)))
                        {
                            icon1.Location = bridgeE;


                        }
                        if ((icon1.Left == 605) && (icon1.Top == 442))
                        {
                            ytrue++;
                            xtrue--;
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;
                            /* icon1.Left = points[index].X;
                             icon1.Top = points[index].Y;*/
                        }
                        if (above() && (landscape() == 1))
                        {
                            dir = (float)(Math.Atan2(points[index].Y - ytrue, points[index].X - xtrue) * 180 / Math.PI);
                            xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                            ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                            icon1.Left = (int)xtrue;
                            icon1.Top = (int)ytrue;


                            graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, points[index].X, points[index].Y);
                            graph.DrawLine(new Pen(Color.Red, 3), icon1.Right, icon1.Top, points[index].X, points[index].Y);
                            if ((Math.Abs(icon1.Left - points[index].X) < 5) && ((Math.Abs(icon1.Top - points[index].Y)) < 5))
                            {
                                icon1.Location = points[index];
                            }
                            if ((icon1.Left == points[index].X) && (icon1.Top < points[index].Y))
                            {
                                xtrue++;
                                ytrue--;
                                icon1.Left = (int)xtrue;
                                icon1.Top = (int)ytrue;

                            }
                            else if ((icon1.Left == points[index].X) && (icon1.Top > points[index].Y))
                            {
                                xtrue++;
                                ytrue++;
                                icon1.Left = (int)xtrue;
                                icon1.Top = (int)ytrue;
                            }
                            if ((icon1.Left < points[index].X) && (icon1.Top == points[index].Y))
                            {
                                ytrue++;
                                xtrue++;
                                icon1.Left = (int)xtrue;
                                icon1.Top = (int)ytrue;
                            }
                            else if ((icon1.Left > points[index].X) && (icon1.Top == points[index].Y))
                            {
                                ytrue++;
                                xtrue--;
                                icon1.Left = (int)xtrue;
                                icon1.Top = (int)ytrue;
                            }
                            if (!above() && (landscape() == 2))
                            {
                                dir = (float)(Math.Atan2(points[index].Y - ytrue, points[index].X - xtrue) * 180 / Math.PI);
                                xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                                ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                                icon1.Left = (int)xtrue;
                                icon1.Top = (int)ytrue;


                                graph.DrawLine(new Pen(Color.Red, 3), icon1.Left, icon1.Top, points[index].X, points[index].Y);
                                graph.DrawLine(new Pen(Color.Red, 3), icon1.Right, icon1.Top, points[index].X, points[index].Y);
                                if ((Math.Abs(icon1.Left - points[index].X) < 5) && ((Math.Abs(icon1.Top - points[index].Y)) < 5))
                                {
                                    icon1.Location = points[index];
                                }
                                if ((icon1.Left == points[index].X) && (icon1.Top < points[index].Y))
                                {
                                    xtrue++;
                                    ytrue--;
                                    icon1.Left = (int)xtrue;
                                    icon1.Top = (int)ytrue;

                                }
                                else if ((icon1.Left == points[index].X) && (icon1.Top > points[index].Y))
                                {
                                    xtrue++;
                                    ytrue++;
                                    icon1.Left = (int)xtrue;
                                    icon1.Top = (int)ytrue;
                                }
                                if ((icon1.Left < points[index].X) && (icon1.Top == points[index].Y))
                                {
                                    ytrue++;
                                    xtrue++;
                                    icon1.Left = (int)xtrue;
                                    icon1.Top = (int)ytrue;
                                }
                                else if ((icon1.Left > points[index].X) && (icon1.Top == points[index].Y))
                                {
                                    ytrue++;
                                    xtrue--;
                                    icon1.Left = (int)xtrue;
                                    icon1.Top = (int)ytrue;
                                }

                            }
                        }
                    }
                }
            





            }

            else
            {


                index++;


            }

            if (index == (points.Count))
            {
                index = 0;
                timer1.Enabled = false;
            }

        }























        private void timer2_Tick(object sender, EventArgs e)
        {

            double xtrue = icon2.Left;
            double ytrue = icon2.Top;
            double dir;
            graph = map.CreateGraphics();




            if ((icon2.Left != points2[index2].X) && (icon2.Top != points2[index2].Y))
            {
                if (above2() && (landscape2() == 1))
                {
                   dir = (float)(Math.Atan2(points2[index2].Y - ytrue, points2[index2].X - xtrue) * 180 / Math.PI);
                    xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                    ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                    icon2.Left = (int)xtrue;
                    icon2.Top = (int)ytrue;
                  
                    graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, points2[index].X, points2[index].Y);
                    if ((Math.Abs(icon2.Left - points2[index2].X) < 5) && ((Math.Abs(icon2.Top - points2[index2].Y)) < 5))
                    {
                        icon2.Location = points2[index2];
                    }
                    if ((icon2.Left == points2[index2].X) && (icon2.Top < points2[index2].Y))
                    {
                        xtrue++;
                        ytrue--;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;

                    }
                    else if ((icon2.Left == points2[index2].X) && (icon2.Top > points2[index2].Y))
                    {
                        xtrue++;
                        ytrue++;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    }
                    if ((icon2.Left < points2[index2].X) && (icon2.Top == points2[index2].Y))
                    {
                        ytrue++;
                        xtrue++;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    }
                    else if ((icon2.Left > points2[index2].X) && (icon2.Top == points2[index2].Y))
                    {
                        ytrue++;
                        xtrue--;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    }


                }
                else  if (!above2() && (landscape2() == 2))
                {
                     dir = (float)(Math.Atan2(points2[index2].Y - ytrue, points2[index2].X - xtrue) * 180 / Math.PI);
                    xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                    ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                    icon2.Left = (int)xtrue;
                    icon2.Top = (int)ytrue;
                    //  if ((distance(icon1.Location,points[index]) < 0.1))
                    graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, points2[index].X, points2[index].Y);
                    if ((Math.Abs(icon2.Left - points2[index2].X) < 5) && ((Math.Abs(icon2.Top - points2[index2].Y)) < 5))
                    {
                        icon2.Location = points2[index2];
                    }
                    if ((icon2.Left == points2[index2].X) && (icon2.Top < points2[index2].Y))
                    {
                        xtrue++;
                        ytrue--;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;

                    }
                    else if ((icon2.Left == points2[index2].X) && (icon2.Top > points2[index2].Y))
                    {
                        xtrue++;
                        ytrue++;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    }
                    if ((icon2.Left < points2[index2].X) && (icon2.Top == points2[index2].Y))
                    {
                        ytrue++;
                        xtrue++;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    }
                    else if ((icon2.Left > points2[index2].X) && (icon2.Top == points2[index2].Y))
                    {
                        ytrue++;
                        xtrue--;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    }


                }
                  else if ((above2() && (landscape2() == 2)))
                {

                    if (((icon2.Left != closesPoint2(bridge2).X) && (icon2.Top != closesPoint2(bridge2).Y)))
                    {
                        dir = (float)(Math.Atan2(closesPoint2(bridge2).Y - ytrue, closesPoint2(bridge2).X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, closesPoint2(bridge2).X, closesPoint2(bridge2).Y);
                         if ((icon2.Left == (closesPoint2(bridge2).X)) && (icon2.Top < (closesPoint2(bridge2).Y)))
                         {
                             xtrue++;
                             ytrue--;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;

                         }
                         else if ((icon2.Left == (closesPoint2(bridge2).X)) && (icon2.Top > (closesPoint2(bridge2).Y)))
                         {
                             xtrue++;
                             ytrue++;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         if ((icon2.Left < (closesPoint2(bridge2).X)) && (icon2.Top == (closesPoint2(bridge2).Y)))
                         {
                             ytrue++;
                             xtrue++;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         else if ((icon2.Left > (closesPoint2(bridge2).X)) && (icon2.Top == (closesPoint2(bridge2).Y)))
                         {
                             ytrue++;
                             xtrue--;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         if ((Math.Abs(icon2.Left - (closesPoint2(bridge2).X)) < 10) || ((Math.Abs(icon2.Top - (closesPoint2(bridge2).Y)) < 10)))
                         {
                             icon2.Location = closesPoint2(bridge2);

                         }

                    }
                   

                    if ((icon2.Left == closesPoint2(bridge2).X) && (icon2.Top == closesPoint2(bridge2).Y))
                    {
                      /*  ytrue++;
                        xtrue--;
                        icon1.Left = (int)xtrue;
                        icon1.Top = (int)ytrue;*/
                        icon2.Left = points2[index2].X;
                        icon2.Top = points2[index2].Y;
                        isabove = false;
                    }








                }
                else if ((!above2()) && (landscape2() == 1))
                {
                    if (((icon2.Left != closesPoint2(bridge2).X) && (icon2.Top != closesPoint(bridge2).Y)))
                    {
                        dir = (float)(Math.Atan2(closesPoint2(bridge2).Y - ytrue, closesPoint2(bridge2).X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, closesPoint2(bridge2).X, closesPoint2(bridge2).Y);
                        if ((icon2.Left == (closesPoint2(bridge2).X)) && (icon2.Top < (closesPoint2(bridge2).Y)))
                        {
                            xtrue++;
                            ytrue--;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;

                        }
                        else if ((icon2.Left == (closesPoint2(bridge2).X)) && (icon2.Top > (closesPoint2(bridge2).Y)))
                        {
                            xtrue++;
                            ytrue++;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        if ((icon2.Left < (closesPoint2(bridge2).X)) && (icon2.Top == (closesPoint2(bridge2).Y)))
                        {
                            ytrue++;
                            xtrue++;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        else if ((icon2.Left > (closesPoint2(bridge2).X)) && (icon2.Top == (closesPoint2(bridge2).Y)))
                        {
                            ytrue++;
                            xtrue--;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        if ((Math.Abs(icon2.Left - (closesPoint2(bridge2).X)) < 10) || ((Math.Abs(icon2.Top - (closesPoint2(bridge2).Y)) < 10)))
                        {
                            icon2.Location = closesPoint2(bridge2);

                        }
                    }
                    if ((icon2.Left == closesPoint2(bridge2).X) && (icon2.Top == closesPoint2(bridge2).Y))
                    {
                        ytrue++;
                        xtrue--;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                    /*    icon1.Left = points[index].X;
                        icon1.Top = points[index].Y;*/
                    }
                }
                else if ((landscape2() == 3))
                {
                    if (((icon2.Left != 518) && (icon2.Top != 404)))
                    {
                        dir = (float)(Math.Atan2(404 - ytrue, 518 - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, 404, 518);
                         if ((icon2.Left == 518) && (icon2.Top < 404))
                         {
                             xtrue++;
                             ytrue--;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;

                         }
                         else if ((icon2.Left == 518) && (icon2.Top > 404))
                         {
                             xtrue++;
                             ytrue++;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         if ((icon2.Left < 518) && (icon2.Top == 404))
                         {
                             ytrue++;
                             xtrue++;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         else if ((icon2.Left > 518) && (icon2.Top == 404))
                         {
                             ytrue++;
                             xtrue--;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }

                    }
                    if ((Math.Abs(icon2.Left - 518) < 10) && ((Math.Abs(icon2.Top - 404) < 10)))
                    {
                        icon2.Location = bridged;

                    }
                    if ((icon2.Left == 518) && (icon2.Top == 404))
                    {

                      icon2.Left = points2[index2].X;
                      icon2.Top = points2[index2].Y;
                    }
                    if (above2() && (landscape2() == 1))
                    {
                        dir = (float)(Math.Atan2(points2[index2].Y - ytrue, points2[index2].X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                       

                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, points2[index2].X, points2[index2].Y);
                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Right, icon2.Top, points2[index2].X, points2[index2].Y);
                        if ((Math.Abs(icon2.Left - points2[index2].X) < 5) && ((Math.Abs(icon2.Top - points2[index2].Y)) < 5))
                        {
                            icon2.Location = points2[index2];
                        }
                        if ((icon2.Left == points2[index2].X) && (icon2.Top < points2[index2].Y))
                        {
                            xtrue++;
                            ytrue--;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;

                        }
                        else if ((icon2.Left == points2[index2].X) && (icon2.Top > points2[index2].Y))
                        {
                            xtrue++;
                            ytrue++;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        if ((icon2.Left < points2[index2].X) && (icon2.Top == points2[index2].Y))
                        {
                            ytrue++;
                            xtrue++;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        else if ((icon2.Left > points2[index2].X) && (icon2.Top == points2[index2].Y))
                        {
                            ytrue++;
                            xtrue--;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }


                    }

                }
                else if ((landscape2() == 4))
                {
                    if (((icon2.Left != 605) && (icon2.Top != 442)))
                    {
                        dir = (float)(Math.Atan2(442 - ytrue, 605 - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, 605, 442);
                         if ((icon2.Left == 518) && (icon2.Top < 404))
                         {
                             xtrue++;
                             ytrue--;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;

                         }
                         else if ((icon2.Left == 518) && (icon2.Top > 404))
                         {
                             xtrue++;
                             ytrue++;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         if ((icon1.Left < 518) && (icon2.Top == 404))
                         {
                             ytrue++;
                             xtrue++;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }
                         else if ((icon2.Left > 518) && (icon2.Top == 404))
                         {
                             ytrue++;
                             xtrue--;
                             icon2.Left = (int)xtrue;
                             icon2.Top = (int)ytrue;
                         }

                    }
                    if ((Math.Abs(icon2.Left - 605) < 5) && ((Math.Abs(icon2.Top - 442) < 5)))
                    {
                        icon2.Location = bridgeE;


                    }
                    if ((icon2.Left == 605) && (icon2.Top == 442))
                    {
                        ytrue++;
                        xtrue--;
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;
                       /* icon1.Left = points[index].X;
                        icon1.Top = points[index].Y;*/
                    }
                    if (above2() && (landscape2() == 1))
                    {
                        dir = (float)(Math.Atan2(points2[index2].Y - ytrue, points2[index2].X - xtrue) * 180 / Math.PI);
                        xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                        ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                        icon2.Left = (int)xtrue;
                        icon2.Top = (int)ytrue;


                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, points2[index2].X, points2[index2].Y);
                        graph.DrawLine(new Pen(Color.Red, 3), icon2.Right, icon2.Top, points2[index2].X, points2[index2].Y);
                        if ((Math.Abs(icon2.Left - points2[index2].X) < 5) && ((Math.Abs(icon2.Top - points2[index2].Y)) < 5))
                        {
                            icon2.Location = points2[index2];
                        }
                        if ((icon2.Left == points2[index2].X) && (icon2.Top < points2[index2].Y))
                        {
                            xtrue++;
                            ytrue--;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;

                        }
                        else if ((icon2.Left == points2[index2].X) && (icon2.Top > points2[index2].Y))
                        {
                            xtrue++;
                            ytrue++;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        if ((icon2.Left < points2[index2].X) && (icon2.Top == points2[index2].Y))
                        {
                            ytrue++;
                            xtrue++;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        else if ((icon2.Left > points2[index2].X) && (icon2.Top == points2[index2].Y))
                        {
                            ytrue++;
                            xtrue--;
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                        }
                        if (!above() && (landscape() == 2))
                        {
                            dir = (float)(Math.Atan2(closesPoint2(bridge2).Y - ytrue, closesPoint2(bridge2).X - xtrue) * 180 / Math.PI);
                            xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                            ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                            icon2.Left = (int)xtrue;
                            icon2.Top = (int)ytrue;
                            graph.DrawLine(new Pen(Color.Red, 3), icon2.Left, icon2.Top, closesPoint2(bridge2).X, closesPoint2(bridge2).Y);
                            if ((icon2.Left == (closesPoint2(bridge2).X)) && (icon2.Top < (closesPoint2(bridge2).Y)))
                            {
                                xtrue++;
                                ytrue--;
                                icon2.Left = (int)xtrue;
                                icon2.Top = (int)ytrue;

                            }
                            else if ((icon2.Left == (closesPoint2(bridge2).X)) && (icon2.Top > (closesPoint2(bridge2).Y)))
                            {
                                xtrue++;
                                ytrue++;
                                icon2.Left = (int)xtrue;
                                icon2.Top = (int)ytrue;
                            }
                            if ((icon2.Left < (closesPoint2(bridge2).X)) && (icon2.Top == (closesPoint2(bridge2).Y)))
                            {
                                ytrue++;
                                xtrue++;
                                icon2.Left = (int)xtrue;
                                icon2.Top = (int)ytrue;
                            }
                            else if ((icon2.Left > (closesPoint2(bridge2).X)) && (icon2.Top == (closesPoint2(bridge2).Y)))
                            {
                                ytrue++;
                                xtrue--;
                                icon2.Left = (int)xtrue;
                                icon2.Top = (int)ytrue;
                            }
                          

                        }
                    }
                
            }
            









            }










            else
            {


                index2++;


            }

            if (index2 == (points2.Count))
            {
                index2 = 0;
                timer2.Enabled = false;
            }




        }

        private void timer3_Tick(object sender, EventArgs e)
        {
              double xtrue = icon3.Left;
            double ytrue = icon3.Top;
            double dir;
            graph = map.CreateGraphics();




            if ((icon3.Left != points3[index3].X) && (icon3.Top != points3[index3].Y))
            {
                dir = (float)(Math.Atan2(points3[index3].Y - ytrue, points3[index3].X - xtrue) * 180 / Math.PI);
                xtrue += speed * (float)Math.Cos(dir * Math.PI / 180);
                ytrue += speed * (float)Math.Sin(dir * Math.PI / 180);
                icon3.Left = (int)xtrue;
                icon3.Top = (int)ytrue;

                graph.DrawLine(new Pen(Color.Red, 3), icon3.Left, icon3.Top, points3[index3].X, points3[index3].Y);
                if ((Math.Abs(icon3.Left - points3[index3].X) < 5) && ((Math.Abs(icon3.Top - points3[index3].Y)) < 5))
                {
                    icon3.Location = points3[index3];
                }
                if ((icon3.Left == points3[index3].X) && (icon3.Top < points3[index3].Y))
                {
                    xtrue++;
                    ytrue--;
                    icon3.Left = (int)xtrue;
                    icon3.Top = (int)ytrue;

                }
                else if ((icon3.Left == points3[index3].X) && (icon3.Top > points3[index3].Y))
                {
                    xtrue++;
                    ytrue++;
                    icon3.Left = (int)xtrue;
                    icon3.Top = (int)ytrue;
                }
                if ((icon3.Left < points3[index3].X) && (icon3.Top == points3[index3].Y))
                {
                    ytrue++;
                    xtrue++;
                    icon3.Left = (int)xtrue;
                    icon3.Top = (int)ytrue;
                }
                else if ((icon3.Left > points3[index3].X) && (icon3.Top == points3[index3].Y))
                {
                    ytrue++;
                    xtrue--;
                    icon3.Left = (int)xtrue;
                    icon3.Top = (int)ytrue;
                }
            }
            else
            {
                index3++;
            }
            if (index3 == (points3.Count))
            {
                index3 = 0;
                timer3.Enabled = false;
            }


        }
    }
}



