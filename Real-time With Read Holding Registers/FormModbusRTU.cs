﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Real_time_With_Read_Holding_Registers
{
    public partial class FormModbusRTU : Form
    {
        private ModbusRTUProtocol modbusRTUProtocol = null;
        public FormModbusRTU()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }
        private void ToInt(object sender, ConvertEventArgs cevent)
        {
            // The method converts back to int type only. 
            if (cevent.DesiredType != typeof(int)) return;

            // Converts the string back to int using the static Parse method.
            cevent.Value = Int32.Parse(cevent.Value.ToString(),
            NumberStyles.Currency, null);
        }
        private void FormModbusRTU_Load(object sender, EventArgs e)
        {
            /*try
            {*/
            const uint _numberofPoints = 20;
            modbusRTUProtocol = new ModbusRTUProtocol(_numberofPoints);
            lbl40000.DataBindings.Add("Text", modbusRTUProtocol.Registers[0], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40001.DataBindings.Add("Text", modbusRTUProtocol.Registers[1], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40002.DataBindings.Add("Text", modbusRTUProtocol.Registers[2], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40003.DataBindings.Add("Text", modbusRTUProtocol.Registers[3], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40004.DataBindings.Add("Text", modbusRTUProtocol.Registers[4], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40005.DataBindings.Add("Text", modbusRTUProtocol.Registers[5], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40006.DataBindings.Add("Text", modbusRTUProtocol.Registers[6], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40007.DataBindings.Add("Text", modbusRTUProtocol.Registers[7], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40008.DataBindings.Add("Text", modbusRTUProtocol.Registers[8], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40009.DataBindings.Add("Text", modbusRTUProtocol.Registers[9], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40010.DataBindings.Add("Text", modbusRTUProtocol.Registers[10], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40011.DataBindings.Add("Text", modbusRTUProtocol.Registers[11], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40012.DataBindings.Add("Text", modbusRTUProtocol.Registers[12], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40013.DataBindings.Add("Text", modbusRTUProtocol.Registers[13], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40014.DataBindings.Add("Text", modbusRTUProtocol.Registers[14], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40015.DataBindings.Add("Text", modbusRTUProtocol.Registers[15], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40016.DataBindings.Add("Text", modbusRTUProtocol.Registers[16], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40017.DataBindings.Add("Text", modbusRTUProtocol.Registers[17], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40018.DataBindings.Add("Text", modbusRTUProtocol.Registers[18], "Address", true, DataSourceUpdateMode.OnPropertyChanged);
            lbl40019.DataBindings.Add("Text", modbusRTUProtocol.Registers[19], "Address", true, DataSourceUpdateMode.OnPropertyChanged);

            Binding binding = new Binding("Text", modbusRTUProtocol.Registers[0], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Parse += new ConvertEventHandler(ToInt);


            txt40000.DataBindings.Add(new Binding("Text", modbusRTUProtocol.Registers[0], "Value", true, DataSourceUpdateMode.OnPropertyChanged));



            txt40001.DataBindings.Add("Text", modbusRTUProtocol.RegistersValue[1], "Value14", true, DataSourceUpdateMode.OnPropertyChanged);
            //txt40001.DataBindings.Add("Text", modbusRTUProtocol.RegistersCopy[1], "Value1", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40002.DataBindings.Add("Text", modbusRTUProtocol.RegistersValue[2], "Value15", true, DataSourceUpdateMode.OnPropertyChanged);

            txt40003.DataBindings.Add("Text", modbusRTUProtocol.Registers[3], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40004.DataBindings.Add("Text", modbusRTUProtocol.Registers[4], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40005.DataBindings.Add("Text", modbusRTUProtocol.Registers[5], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40006.DataBindings.Add("Text", modbusRTUProtocol.Registers[6], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40007.DataBindings.Add("Text", modbusRTUProtocol.Registers[7], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40008.DataBindings.Add("Text", modbusRTUProtocol.Registers[8], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40009.DataBindings.Add("Text", modbusRTUProtocol.Registers[9], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40010.DataBindings.Add("Text", modbusRTUProtocol.Registers[10], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40011.DataBindings.Add("Text", modbusRTUProtocol.Registers[11], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40012.DataBindings.Add("Text", modbusRTUProtocol.Registers[12], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40013.DataBindings.Add("Text", modbusRTUProtocol.Registers[13], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40014.DataBindings.Add("Text", modbusRTUProtocol.Registers[14], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40015.DataBindings.Add("Text", modbusRTUProtocol.Registers[15], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40016.DataBindings.Add("Text", modbusRTUProtocol.Registers[16], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40017.DataBindings.Add("Text", modbusRTUProtocol.Registers[17], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40018.DataBindings.Add("Text", modbusRTUProtocol.Registers[18], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            txt40019.DataBindings.Add("Text", modbusRTUProtocol.Registers[19], "Value", true, DataSourceUpdateMode.OnPropertyChanged);


            //string result = DecToBinary(decimalNumber).ToString();

            modbusRTUProtocol.Start();
            //}
            /*catch (Exception ex)
            {
                MessageBox.Show("Here " + ex.Message);
            }*/
            /*label6.DataBindings.Add("Text", txt40000, "Text");*/
            ///String one = GetStatus(ushort.Parse(txt40000.Text));

            //label6.Text = one;
        }

        private void myScheduleView_PropertyChanged(Object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "HorizontalOffset" ||
               e.PropertyName == "VerticalOffset")
            {
                //TODO: something
            }
        }

        private static String GetStatus(ushort num)
        {
            string result = DecToBinary(num).ToString();

            List<string> results = new List<string>(result.Trim().Split(' '));
            List<int> bits = results.ConvertAll(int.Parse);

            if (bits[15] == 0)
            {
                return "Manual";
            }
            else
            {
                return "Auto";
            }
        }
        private static StringBuilder DecToBinary(ushort n)
        {
            var result = new StringBuilder();
            for (int i = 15; i >= 0; i--)
            {
                int k = n >> i;
                if ((k & 1) > 0)
                    result.Append("1 ");
                else
                    result.Append("0 ");
            }
            return result;
        }

        private void FormModbusRTU_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl40000_Click(object sender, EventArgs e)
        {

        }
    }
}
