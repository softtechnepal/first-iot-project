using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_With_Read_Holding_Registers
{
    public class RegisterCopy : INotifyPropertyChanged
    {
        private ushort _Address;
        private string _Value1;
        private string _Value2;
        private string _Value3;
        private string _Value4;
        private string _Value5;
        private string _Value6;
        private string _Value7;
        private string _Value8;
        private string _Value9;
        private string _Value10;
        private string _Value11;
        private string _Value12;
        private string _Value13;
        private string _Value14;
        private string _Value15;
        private string _Value16;

        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ushort Address
        {
            get
            {
                return _Address;
            }

            set
            {
                if (_Address != value)
                {
                    _Address = value;
                    NotifyPropertyChanged("Address");
                }
            }
        }

        public string Value1
        {
            get
            {
                return _Value1;
            }

            set
            {
                if (_Value1 != value)
                {
                    _Value1 = value;
                    NotifyPropertyChanged("Value1");
                }
            }
        }

        public string Value2
        {
            get
            {
                return _Value2;
            }

            set
            {
                if (_Value2 != value)
                {
                    _Value2= value;
                    NotifyPropertyChanged("Value2");
                }
            }
        }

    }
}
