using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YG_TestPlatform
{
    public class CRC
    {
        
        //获取CRC16-Modbus校验码
        public static ushort CalculateCRC(byte[] data)
        {
            ushort crc = 0xFFFF;

            for (int i = 0; i < data.Length; i++)
            {
                crc ^= data[i];

                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            return crc;
        }

        //校验数据
        public static bool ValidateData(byte[] data)
        {
            if (data.Length < 2)
            {
                return false;
            }

            ushort receivedCRC = (ushort)(data[data.Length - 1] << 8 | data[data.Length - 2]);
            byte[] dataWithoutCRC = new byte[data.Length - 2];
            Array.Copy(data, 0, dataWithoutCRC, 0, dataWithoutCRC.Length);
            ushort calculatedCRC = CalculateCRC(dataWithoutCRC);

            return receivedCRC == calculatedCRC;
        }
    }
}
