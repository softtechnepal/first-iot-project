using System;
using System.Collections.Generic;
using System.Text;

namespace Real_time_With_Read_Holding_Registers
{
    public class Word
    {

        /// <summary>
        /// Convert UInt16 to byte array
        /// </summary>
        /// <param name="value">value</param>
        /// <returns>Byte Array</returns>
        public static byte[] UInt16ToByte(UInt16 value)
        {
            byte[] array = BitConverter.GetBytes(value);
            Array.Reverse(array);
            return array;
        }

        /// <summary>
        /// Convert UInt16 array to byte array
        /// </summary>
        /// <param name="value">Values</param>
        /// <returns>Byte Array</returns>
        public static byte[] UInt16ToByte(UInt16[] value)
        {
            ByteArray arr = new ByteArray();
            foreach (UInt16 val in value)
                arr.Add(UInt16ToByte(val));
            return arr.array;
        }

        public static UInt16 FromByteArray(byte[] bytes)
        {
            // bytes[0] -> HighByte
            // bytes[1] -> LowByte
            return FromBytes(bytes[1], bytes[0]);
        }

        public static UInt16 FromBytes(byte LoVal, byte HiVal)
        {
            return (UInt16)(HiVal * 256 + LoVal);
        }

        public static List<String> /*string */DecToString(ushort num)
        {
            string result = DecToBinary(num).ToString();

            List<string> results = new List<string>(result.Trim().Split(' '));
            List<int> bits = results.ConvertAll(int.Parse);

            List<String> one_register = new List<string>();
            List<List<String>> final_result = new List<List<string>>();
            foreach (int bit in bits)
            {
                if (bit == 0)
                {
                    one_register.Add("Manual");
                }
                else
                {
                    one_register.Add("Auto");
                }
            }
            final_result.Add(one_register);
            return one_register;
        }
        public static StringBuilder DecToBinary(ushort n)
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

        public static ushort[] ByteToBinary(byte[] bytes)
        {
            ushort[] name = new ushort[bytes.Length / 2];
            int counter = 0;

            for (int cnt = 0; cnt < bytes.Length / 2; cnt++)
                name[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++] });

            // string yourByteString = Convert.ToString(bytes).PadLeft(16, '0');
            return name;
        }
        public static UInt16[] ByteToUInt16(byte[] bytes)
        {
            UInt16[] values = new UInt16[bytes.Length / 2];
            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 2; cnt++)
                values[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++] });
            return values;
        }

        public static string[] ByteToString(byte[] bytes)
        {
            string[] booleans = new string[bytes.Length / 2];
            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 2; cnt++)
                booleans[cnt] = FromBytesString(new byte[] { bytes[counter++], bytes[counter++] });
            return booleans;
        }

        public static string[] BinaryValue(byte[] bytes)
        {
            string[] binary = ByteToString(bytes);
            return binary;
        }

        private static string FromBytesString(byte[] bytes)
        {
            return Convert.ToString(bytes[0]*256 + bytes[1], 2).PadLeft(16, '0');
        }
    }
}
/*foreach (string value in binary)
            {
                List<string> results = new List<string>(value.Split(' '));
                for (int i = 0; i < results.Count - 1; i++)
                {
                    if (results[i] == "0")
                    {
                        results[i] = "Manual";
                    }
                    else
                    {
                        results[i] = "Auto";
                    }
                }
                secVal.Add(results);
            }*/