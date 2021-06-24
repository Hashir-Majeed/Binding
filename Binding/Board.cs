using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp2
{
    class Board : Notifier
    {

        private string colourT;

        public Board()
        {
            colourT = "White";
        }
        public string ColourText
        {
            get { return colourT; }
            set
            {
                colourT = value;
                OnPropertyChanged("ColourText");
            }
        }




    }
}