using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace YG_TestPlatform
{
    /// <summary>
    /// 文件发送帮助类
    /// </summary>
    public class CommonHelper
    {

        public static bool IsHexString(string input)
        {
            bool isHex = true;
            foreach (char c in input)
            {
                if (!IsHexDigit(c))
                {
                    isHex = false;
                    break;
                }
            }
            return isHex;
        }

        static bool IsHexDigit(char c)
        {
            return (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F') || (c >= 'a' && c <= 'f');
        }

        public static void ShuffleArray<T>(T[] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }

    }
}
