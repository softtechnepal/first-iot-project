using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_time_With_Read_Holding_Registers
{
    public class RegisterValue : INotifyPropertyChanged
    {
        private ushort _Address;
        private string _Value0;
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

        public string Value0
        {
            get
            {
                return _Value0;
            }

            set
            {
                if (_Value0 != value)
                {
                    _Value0 = value;
                    NotifyPropertyChanged("Value0");
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
                    _Value2 = value;
                    NotifyPropertyChanged("Value2");
                }
            }
        }

        public string Value3
        {
            get
            {
                return _Value3;
            }

            set
            {
                if (_Value3 != value)
                {
                    _Value3 = value;
                    NotifyPropertyChanged("Value3");
                }
            }
        }
        public string Value4
        {
            get
            {
                return _Value4;
            }

            set
            {
                if (_Value4 != value)
                {
                    _Value4 = value;
                    NotifyPropertyChanged("Value4");
                }
            }
        }

        public string Value5
        {
            get
            {
                return _Value5;
            }

            set
            {
                if (_Value5 != value)
                {
                    _Value5 = value;
                    NotifyPropertyChanged("Value5");
                }
            }
        }
        public string Value6
        {
            get
            {
                return _Value6;
            }

            set
            {
                if (_Value6 != value)
                {
                    _Value6 = value;
                    NotifyPropertyChanged("Value6");
                }
            }
        }
        public string Value7
        {
            get
            {
                return _Value7;
            }

            set
            {
                if (_Value7 != value)
                {
                    _Value7 = value;
                    NotifyPropertyChanged("Value7");
                }
            }
        }
        public string Value8
        {
            get
            {
                return _Value8;
            }

            set
            {
                if (_Value8 != value)
                {
                    _Value8 = value;
                    NotifyPropertyChanged("Value8");
                }
            }
        }
        public string Value9
        {
            get
            {
                return _Value9;
            }

            set
            {
                if (_Value9 != value)
                {
                    _Value9 = value;
                    NotifyPropertyChanged("Value9");
                }
            }
        }
        public string Value10
        {
            get
            {
                return _Value10;
            }

            set
            {
                if (_Value10 != value)
                {
                    _Value10 = value;
                    NotifyPropertyChanged("Value10");
                }
            }
        }
        public string Value11
        {
            get
            {
                return _Value11;
            }

            set
            {
                if (_Value11 != value)
                {
                    _Value11 = value;
                    NotifyPropertyChanged("Value11");
                }
            }
        }
        public string Value12
        {
            get
            {
                return _Value12;
            }

            set
            {
                if (_Value12 != value)
                {
                    _Value12 = value;
                    NotifyPropertyChanged("Value12");
                }
            }
        }
        public string Value13
        {
            get
            {
                return _Value13;
            }

            set
            {
                if (_Value13 != value)
                {
                    _Value13 = value;
                    NotifyPropertyChanged("Value13");
                }
            }
        }
        public string Value14
        {
            get
            {
                return _Value14;
            }

            set
            {
                if (_Value14 != value)
                {
                    _Value14 = value;
                    NotifyPropertyChanged("Value14");
                }
            }
        }

        public string Value15
        {
            get
            {
                return _Value15;
            }

            set
            {
                if (_Value15 != value)
                {
                    _Value15 = value;
                    NotifyPropertyChanged("Value15");
                }
            }
        }
    }
}
