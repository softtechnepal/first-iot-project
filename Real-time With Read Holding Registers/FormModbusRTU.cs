using System;
using System.IO.Ports;
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

        private void FormModbusRTU_Load(object sender, EventArgs e)
        {
            try
            {
                const uint NumberofPoints = 20;
                modbusRTUProtocol = new ModbusRTUProtocol(NumberofPoints);
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

                txt40000.DataBindings.Add(new Binding("Text", modbusRTUProtocol.Registers[0], "Value", true, DataSourceUpdateMode.OnPropertyChanged));
                //txt40000.DataBindings.Add("Text", modbusRTUProtocol.Registers[0], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
                txt40001.DataBindings.Add("Text", modbusRTUProtocol.Registers[1], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
                txt40002.DataBindings.Add("Text", modbusRTUProtocol.Registers[2], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
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

                modbusRTUProtocol.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
