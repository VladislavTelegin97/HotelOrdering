using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
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
            initializeFloors();
            ShowFloor(currentFloor);
            try 
            {
                currentConfig = Configuration.GetConfiguration();
                currentConfig.ApplyConfiguration(floorList);
            }
            catch { }
        }

        private void initializeFloors()
        {
            floorList = new List<Floor>();

            #region FirstFloorInitialization
            //floor#1:

            //buttons:
            Button f1r100 = new Button()
            {
                Size = new Size(49, 20),
                Left = 8,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "100"
            };
            Button f1r101 = new Button()
            {
                Size = new Size(49, 20),
                Left = 63,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "101"
            };
            Button f1r102 = new Button()
            {
                Size = new Size(49, 20),
                Left = 118,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "102"
            };
            Button f1r103 = new Button()
            {
                Size = new Size(49, 20),
                Left = 173,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "103"
            };
            Button f1r104 = new Button()
            {
                Size = new Size(49, 20),
                Left = 228,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "104"
            };

            Button f1r105 = new Button()
            {
                Size = new Size(49, 20),
                Left = 8,
                Top = 217,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "105"
            };
            Button f1r106 = new Button()
            {
                Size = new Size(49, 20),
                Left = 63,
                Top = 217,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "106"
            };
            Button f1r107 = new Button()
            {
                Size = new Size(49, 20),
                Left = 118,
                Top = 217,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "107"
            };
            Button f1r108 = new Button()
            {
                Size = new Size(49, 20),
                Left = 173,
                Top = 217,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "108"
            };
            Button f1r109 = new Button()
            {
                Size = new Size(49, 20),
                Left = 228,
                Top = 217,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "109"
            };

            Button f1r110 = new Button()
            {
                Size = new Size(49, 20),
                Left = 8,
                Top = 348,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "110"
            };
            Button f1r111 = new Button()
            {
                Size = new Size(49, 20),
                Left = 63,
                Top = 348,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "111"
            };
            Button f1r112 = new Button()
            {
                Size = new Size(49, 20),
                Left = 118,
                Top = 348,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "112"
            };
            Button f1r113 = new Button()
            {
                Size = new Size(49, 20),
                Left = 173,
                Top = 348,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "113"
            };
            Button f1r114 = new Button()
            {
                Size = new Size(49, 20),
                Left = 228,
                Top = 348,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "114"
            };

            Button f1r115 = new Button()
            {
                Size = new Size(22, 51),
                Left = 319,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "115"
            };
            Button f1r116 = new Button()
            {
                Size = new Size(22, 51),
                Left = 319,
                Top = 145,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "116"
            };
            Button f1r117 = new Button()
            {
                Size = new Size(22, 51),
                Left = 319,
                Top = 202,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "117"
            };
            Button f1r118 = new Button()
            {
                Size = new Size(22, 51),
                Left = 319,
                Top = 259,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "118"
            };
            Button f1r119 = new Button()
            {
                Size = new Size(22, 51),
                Left = 319,
                Top = 316,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "119"
            };

            Button f1r120 = new Button()
            {
                Size = new Size(22, 51),
                Left = 431,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "120"
            };
            Button f1r121 = new Button()
            {
                Size = new Size(22, 51),
                Left = 431,
                Top = 145,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "121"
            };
            Button f1r122 = new Button()
            {
                Size = new Size(22, 51),
                Left = 431,
                Top = 202,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "122"
            };
            Button f1r123 = new Button()
            {
                Size = new Size(22, 51),
                Left = 431,
                Top = 259,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "123"
            };
            Button f1r124 = new Button()
            {
                Size = new Size(22, 51),
                Left = 431,
                Top = 316,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "124"
            };

            Button f1r125 = new Button()
            {
                Size = new Size(22, 51),
                Left = 551,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "125"
            };
            Button f1r126 = new Button()
            {
                Size = new Size(22, 51),
                Left = 551,
                Top = 145,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "126"
            };
            Button f1r127 = new Button()
            {
                Size = new Size(22, 51),
                Left = 551,
                Top = 202,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "127"
            };
            Button f1r128 = new Button()
            {
                Size = new Size(22, 51),
                Left = 551,
                Top = 259,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "128"
            };
            Button f1r129 = new Button()
            {
                Size = new Size(22, 51),
                Left = 551,
                Top = 316,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "129"
            };

            Button f1r130 = new Button()
            {
                Size = new Size(49, 20),
                Left = 666,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "130"
            };
            Button f1r132 = new Button()
            {
                Size = new Size(49, 20),
                Left = 666,
                Top = 178,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "132"
            };
            Button f1r134 = new Button()
            {
                Size = new Size(49, 20),
                Left = 666,
                Top = 247,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "134"
            };
            Button f1r136 = new Button()
            {
                Size = new Size(49, 20),
                Left = 666,
                Top = 318,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "136"
            };

            Button f1r131 = new Button()
            {
                Size = new Size(49, 20),
                Left = 721,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "131"
            };
            Button f1r133 = new Button()
            {
                Size = new Size(49, 20),
                Left = 721,
                Top = 178,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "133"
            };
            Button f1r135 = new Button()
            {
                Size = new Size(49, 20),
                Left = 721,
                Top = 247,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "135"
            };
            Button f1r137 = new Button()
            {
                Size = new Size(49, 20),
                Left = 721,
                Top = 318,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "137"
            };

            //panels
            Panel f1p100 = new Panel() { Size = new Size(45, 60), Left = 10, Top = 28, BackColor = Color.Maroon };
            Panel f1p101 = new Panel() { Size = new Size(45, 60), Left = 65, Top = 28, BackColor = Color.Maroon };
            Panel f1p102 = new Panel() { Size = new Size(45, 60), Left = 120, Top = 28, BackColor = Color.Maroon };
            Panel f1p103 = new Panel() { Size = new Size(45, 60), Left = 175, Top = 28, BackColor = Color.Maroon };
            Panel f1p104 = new Panel() { Size = new Size(45, 60), Left = 230, Top = 28, BackColor = Color.Maroon };

            Panel f1p105 = new Panel() { Size = new Size(45, 60), Left = 10, Top = 157, BackColor = Color.RoyalBlue };
            Panel f1p106 = new Panel() { Size = new Size(45, 60), Left = 65, Top = 157, BackColor = Color.RoyalBlue };
            Panel f1p107 = new Panel() { Size = new Size(45, 60), Left = 120, Top = 157, BackColor = Color.RoyalBlue };
            Panel f1p108 = new Panel() { Size = new Size(45, 60), Left = 175, Top = 157, BackColor = Color.RoyalBlue };
            Panel f1p109 = new Panel() { Size = new Size(45, 60), Left = 230, Top = 157, BackColor = Color.RoyalBlue };

            Panel f1p110 = new Panel() { Size = new Size(45, 60), Left = 10, Top = 288, BackColor = Color.Maroon };
            Panel f1p111 = new Panel() { Size = new Size(45, 60), Left = 65, Top = 288, BackColor = Color.Maroon };
            Panel f1p112 = new Panel() { Size = new Size(45, 60), Left = 120, Top = 288, BackColor = Color.Maroon };
            Panel f1p113 = new Panel() { Size = new Size(45, 60), Left = 175, Top = 288, BackColor = Color.Maroon };
            Panel f1p114 = new Panel() { Size = new Size(45, 60), Left = 230, Top = 288, BackColor = Color.Maroon };

            Panel f1p115 = new Panel() { Size = new Size(58, 49), Left = 341, Top = 89, BackColor = Color.Orange };
            Panel f1p116 = new Panel() { Size = new Size(58, 49), Left = 341, Top = 146, BackColor = Color.Orange };
            Panel f1p117 = new Panel() { Size = new Size(58, 49), Left = 341, Top = 203, BackColor = Color.Orange };
            Panel f1p118 = new Panel() { Size = new Size(58, 49), Left = 341, Top = 260, BackColor = Color.Orange };
            Panel f1p119 = new Panel() { Size = new Size(58, 49), Left = 341, Top = 317, BackColor = Color.Orange };

            Panel f1p120 = new Panel() { Size = new Size(58, 49), Left = 453, Top = 89, BackColor = Color.DarkOliveGreen };
            Panel f1p121 = new Panel() { Size = new Size(58, 49), Left = 453, Top = 146, BackColor = Color.DarkOliveGreen };
            Panel f1p122 = new Panel() { Size = new Size(58, 49), Left = 453, Top = 203, BackColor = Color.DarkOliveGreen };
            Panel f1p123 = new Panel() { Size = new Size(58, 49), Left = 453, Top = 260, BackColor = Color.DarkOliveGreen };
            Panel f1p124 = new Panel() { Size = new Size(58, 49), Left = 453, Top = 317, BackColor = Color.DarkOliveGreen };

            Panel f1p125 = new Panel() { Size = new Size(58, 49), Left = 573, Top = 89, BackColor = Color.Teal };
            Panel f1p126 = new Panel() { Size = new Size(58, 49), Left = 573, Top = 146, BackColor = Color.Teal };
            Panel f1p127 = new Panel() { Size = new Size(58, 49), Left = 573, Top = 203, BackColor = Color.Teal };
            Panel f1p128 = new Panel() { Size = new Size(58, 49), Left = 573, Top = 260, BackColor = Color.Teal };
            Panel f1p129 = new Panel() { Size = new Size(58, 49), Left = 573, Top = 317, BackColor = Color.Teal };

            Panel f1p130 = new Panel() { Size = new Size(47, 60), Left = 667, Top = 28, BackColor = Color.Gold };
            Panel f1p131 = new Panel() { Size = new Size(47, 60), Left = 722, Top = 28, BackColor = Color.Gold };

            Panel f1p132 = new Panel() { Size = new Size(47, 26), Left = 667, Top = 151, BackColor = Color.Maroon };
            Panel f1p133 = new Panel() { Size = new Size(47, 26), Left = 722, Top = 151, BackColor = Color.Maroon };

            Panel f1p134 = new Panel() { Size = new Size(47, 26), Left = 667, Top = 221, BackColor = Color.Gold };
            Panel f1p135 = new Panel() { Size = new Size(47, 26), Left = 722, Top = 221, BackColor = Color.Gold };

            Panel f1p136 = new Panel() { Size = new Size(47, 26), Left = 667, Top = 291, BackColor = Color.Indigo };
            Panel f1p137 = new Panel() { Size = new Size(47, 26), Left = 722, Top = 291, BackColor = Color.Indigo };
            #endregion

            #region SecondFloorInitialization
            //floor#2:

            //buttons:
            Button f2r200 = new Button()
            {
                Size = new Size(49, 20),
                Left = 8,
                Top = 88,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "200"
            };

            //panels
            Panel f2p200 = new Panel() { Size = new Size(45, 60), Left = 10, Top = 28, BackColor = Color.White };
            #endregion

            #region ThirdFloorInitialization
            //floor#2:

            //buttons:
            Button f2r300 = new Button()
            {
                Size = new Size(49, 20),
                Left = 118,
                Top = 198,
                BackColor = Color.White,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Text = "300"
            };

            //panels
            Panel f2p300 = new Panel() { Size = new Size(45, 60), Left = 120, Top = 138, BackColor = Color.Green };
            #endregion

            floorList.Add(new Floor(new List<Button>() { 
               f1r100, f1r101, f1r102, f1r103, f1r104, f1r105, f1r106, f1r107 , f1r108, f1r109,
               f1r110, f1r111, f1r112, f1r113, f1r114, f1r115, f1r116, f1r117, f1r118, f1r119,
               f1r120, f1r121, f1r122, f1r123, f1r124, f1r125, f1r126, f1r127, f1r128, f1r129,
               f1r130, f1r131, f1r132, f1r133, f1r134, f1r135, f1r136, f1r137
           }, new List<Panel>() {
               f1p100, f1p101, f1p102, f1p103, f1p104, f1p105, f1p106, f1p107 , f1p108, f1p109,
               f1p110, f1p111, f1p112, f1p113, f1p114, f1p115, f1p116, f1p117, f1p118, f1p119,
               f1p120, f1p121, f1p122, f1p123, f1p124, f1p125, f1p126, f1p127, f1p128, f1p129,
               f1p130, f1p131, f1p132, f1p133, f1p134, f1p135, f1p136, f1p137
           }));

           floorList.Add(new Floor(new List<Button>() { f2r200 }, new List<Panel>() { f2p200 }));

           floorList.Add(new Floor(new List<Button>() { f2r300 }, new List<Panel>() { f2p300 })); 

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
