using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HotelOrdering.Model
{
    class Floor : IEnumerable
    {
        private List<Button> roomButtons;
        private List<Panel> flats;

        public Floor() 
        {
            roomButtons = new List<Button>();
            flats = new List<Panel>();
        }

        public Floor(List<Button> roomPanels, List<Panel> flats)
        {
            this.roomButtons = roomPanels;
            this.flats = flats;
        }

        public void Show(Control C)
        {
            foreach (Button b in roomButtons)
                C.Controls.Add(b);
            foreach (Panel p in flats)
                C.Controls.Add(p);
        }

        public IEnumerator GetEnumerator() { return roomButtons.GetEnumerator(); }
    }

      

}

