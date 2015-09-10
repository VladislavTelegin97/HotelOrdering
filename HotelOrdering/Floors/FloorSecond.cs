using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HotelOrdering.Model;

namespace HotelOrdering.Floors
{
    struct FloorSecond
    {
        Floor floor;

        public Floor Floor
        {
            get { return floor; }
            private set { floor = value; }
        }

        public FloorSecond (string kek = "kek")
        {
            #region FloorSecondInitialization

            //Buttons:

            Button f2r200 = new Button()
            {
                Size = new Size(49, 20),
                Left = 8,
                Top = 88,
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Text = "200"
            };

            //Panels

            Panel f2p200 = new Panel() { Size = new Size(45, 60), Left = 10, Top = 28, BackColor = Color.White };

            //Floor creation

            floor = new Floor(new List<Button>() {
               f2r200
           }, new List<Panel>() {
               f2p200
           });

            #endregion
        }
    }
}