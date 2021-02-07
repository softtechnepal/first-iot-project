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
    }
}
