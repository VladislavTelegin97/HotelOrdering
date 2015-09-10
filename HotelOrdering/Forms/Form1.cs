using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HotelOrdering.Floors;
using HotelOrdering.Model;

namespace HotelOrdering
{
    public partial class Form1 : Form
    {
        #region MAIN_FIELDS

            int currentFloor = 1;
            Configuration currentConfig;
            List<Floor> floorList;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeFloors();
            ShowFloor(currentFloor);
            try 
            {
                currentConfig = Configuration.GetConfiguration();
                currentConfig.ApplyConfiguration(floorList);
            }
            catch { }
        }

        private void InitializeFloors()
        {
            floorList = new List<Floor>();

            FloorFirst floorFirst = new FloorFirst("kek");
            FloorSecond floorSecond = new FloorSecond("kok");
            FloorThird floorThird = new FloorThird("sas");

            floorList.Add(floorFirst.Floor);
            floorList.Add(floorSecond.Floor);
            floorList.Add(floorThird.Floor);

            foreach (Floor f in floorList)
                foreach (Button b in f)
                    b.Click += new System.EventHandler(RoomClickedHandler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowFloor(--currentFloor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowFloor(++currentFloor);
        }

        private void ShowFloor(int i)
        {
            this.panel1.Controls.Clear();
            floorList[i-1].Show(this.panel1);
            if (currentFloor == floorList.Count) { button1.Enabled = true;  button2.Enabled = false; }
            else if (currentFloor == 1) { button1.Enabled = false; button2.Enabled = true; }
            else { button1.Enabled = true; button2.Enabled = true; }
        }

        private void RoomClickedHandler(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.Black)
            {
                ((Button)sender).BackColor = Color.White;
                ((Button)sender).ForeColor = Color.Black;
                //
            }
            else
            {
                ((Button)sender).BackColor = Color.Black;
                ((Button)sender).ForeColor = Color.White;
                //
            }
        }

        private void SaveChanges(object sender, FormClosingEventArgs e)
        {
            currentConfig = new Configuration();
            foreach (Floor f in floorList)
                foreach (Button b in f)
                    currentConfig.configList.Add(int.Parse(b.Text), b.BackColor);
            currentConfig.SetConfiguration();
        } 
    }
}
