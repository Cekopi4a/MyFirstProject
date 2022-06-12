using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_Project2
{
    public partial class ClientView : Form
    {
        int i = 1;

        public ClientView()
        {
            InitializeComponent();
        }

        private void goNext(object sender, EventArgs e)
        {
            i++;

            if (i > 12)
            {
                i = 1;
            }
            changeImage(i);
        }

        private void goBack(object sender, EventArgs e)
        {
            i--;

            if(i < 1)
            {
                i = 12;
            }
            changeImage(i);
        }

        private void changeImage(int num)
        {
            
          switch(num)
          {
                
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    Info.Text = "гр.Варна";
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    Info.Text = "гр.Варна";
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    Info.Text = "гр.София";
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    Info.Text = "гр.Пловдив";
                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    Info.Text = "гр.Варна";
                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    Info.Text = "гр.Пловдив";
                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    Info.Text = "гр.Пловдив";
                    break;
                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    Info.Text = "гр.София";
                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    Info.Text = "гр.София";
                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    Info.Text = "гр.Варна";
                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources._11;
                    Info.Text = "гр.София";
                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources._12;
                    Info.Text = "гр.Пловдив";
                    break;
            }

        }

        private void regLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registrationform = new Registration();
            registrationform.Show();
        }

        private void logLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm form1 = new LoginForm();
            form1.Show();
        }
    }
 }
