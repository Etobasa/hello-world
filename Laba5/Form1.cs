using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Laba5
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Laba4");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Cake
        {
            if (MessageBox.Show("Do you want to increase the window size by 50 units?", "Eat me!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Height += 50;
                Width += 50;
            }
        }

        private void Bottle_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reduce the window size by 50 units?", "Drink me!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes && this.Height > 50)
            {
                Height -= 50;
                Width -= 50;
            }
        }

        private void Button3_Click(object sender, EventArgs e) //Blue
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Laba4");
            reg.SetValue("Color", "Blue");
            reg.Close();
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void Red_button_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Laba4");
            reg.SetValue("Color", "Red");
            reg.Close();
            this.BackColor = System.Drawing.Color.Red;
        }

        private void Purple_button_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Laba4");
            reg.SetValue("Color", "Purple");
            reg.Close();
            this.BackColor = System.Drawing.Color.BlueViolet;
        }

        private void Button1_Click_1(object sender, EventArgs e) //Save
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Laba4");
            reg.SetValue("Height", Height);
            reg.SetValue("Width", Width);
            reg.Close();
        }

        private void Loadd_Click(object sender, EventArgs e)
        {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"Laba4");
            if (reg != null)
            {
                int Height = int.Parse(reg.GetValue("Height").ToString());
                int Width = int.Parse(reg.GetValue("Width").ToString());
                Size = new Size(Height, Width);
                string color = (string)reg.GetValue("Color");
                if (color == "Purple")
                {
                    this.BackColor = System.Drawing.Color.BlueViolet;
                }
                else if (color == "Red")
                {
                    this.BackColor = System.Drawing.Color.Red;
                }
                else if (color == "Blue")
                {
                    this.BackColor = System.Drawing.Color.Blue;
                }
            }
        }

        private void Dish_text_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e) //Colour
        {

        }
    }
}
