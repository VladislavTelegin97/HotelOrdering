using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HotelOrdering.Model;

namespace HotelOrdering.Floors
{
    struct FloorThird
    {
        Floor floor;

        public Floor Floor
        {
            get { return floor; }
            private set { floor = value; }
        }

        public FloorThird (string kek = "kek")
        {
            #region FloorThirdInitialization

            //Buttons

            Button f3r300 = new Button()
            {
                Size = new Size(49, 20),
                Left = 118,
                Top = 198,
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Text = "300"
            };

            //Panels

            Panel f3p300 = new Panel() { Size = new Size(45, 60), Left = 120, Top = 138, BackColor = Color.Green };

            //Floor creating

            floor = new Floor(new List<Button>() {
               f3r300
           }, new List<Panel>() {
               f3p300
           });

            #endregion
        }
    }
}