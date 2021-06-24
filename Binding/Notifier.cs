using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WpfApp2
{
    class Notifier : INotifyPropertyChanged
    {
        // Interface to Notify framework an attribute has changed

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }


        }
    }
}