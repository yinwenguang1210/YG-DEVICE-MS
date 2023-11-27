using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YG_TestPlatform
{
    public class IniFile
    {
        /************************************************************************/
        /*写操作 
         * strSection   节 
         * strKey       键 
         * strValue     需要写入的值 
         * strFilePath  配置文件的全路径（wince中只能使用绝对全路径） 
         */
        /************************************************************************/
        public static void PutINI(string strSection, string strKey, string strValue, string strFilePath)
        {
            INICommon(false, strSection, strKey, strValue, strFilePath);
        }

        /************************************************************************/
        /* 读操作 
         * strSection   节 
         * strKey       键 
         * strDefault   如果未找到相应键对应的值则填入此值 
         * strFilePath  配置文件的全路径（wince中只能使用绝对全路径） 
         * 返回：       指定键的相应值 
         * 说明：       如果在文件中未找到相应节则添加，未找到相应键亦添加，如果键对应的值为空串则使用默认值填充ini文件并返回 
        /************************************************************************/
        public static string GetINI(string strSection, string strKey, string strDefault, string strFilePath)
        {
            return INICommon(true, strSection, strKey, strDefault, strFilePath);
        }

        private static string[] Split(string input, string pattern)
        {
            string[] arr = System.Text.RegularExpressions.Regex.Split(input, pattern);
            return arr;
        }
        private static void AppendToFile(string strPath, string strContent)
        {
            FileStream fs = new FileStream(strPath, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);
            streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            streamWriter.WriteLine(strContent);
            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
        }
        private static void WriteArray(string strPath, string[] strContent)
        {
            FileStream fs = new FileStream(strPath, FileMode.Truncate);
            StreamWriter streamWriter = new StreamWriter(fs, System.Text.Encoding.Default);
            streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);

            for (int i = 0; i < strContent.Length; i++)
            {
                if (strContent[i].Trim() == "\r\n")
                    continue;
                streamWriter.WriteLine(strContent[i].Trim());
            }

            streamWriter.Flush();
            streamWriter.Close();
            fs.Close();
        }
        //INI文件解析查找  
        private static string INICommon(bool isRead, string ApplicationName, string KeyName, string Default, string FileName)
        {
            string strSection = "[" + ApplicationName + "]";
            string strBuf;
            try
            {
                //a.文件不存在则创建  
                if (!File.Exists(FileName))
                {
                    FileStream sr = File.Create(FileName);
                    sr.Close();
                }
                //读取INI文件  
                System.IO.StreamReader stream = new System.IO.StreamReader(FileName, System.Text.Encoding.Default);
                strBuf = stream.ReadToEnd();
                stream.Close();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString(), "INI文件读取异常");  
                return Default;
            }

            string[] rows = Split(strBuf, "\r\n");
            string oneRow;
            int i = 0;
            for (; i < rows.Length; i++)
            {
                oneRow = rows[i].Trim();

                //空行  
                if (0 == oneRow.Length)
                    continue;

                //此行为注释  
                if (';' == oneRow[0])
                    continue;

                //没找到  
                if (strSection != oneRow)
                    continue;

                //找到了  
                break;
            }

            //b.没找到对应的section，创建一节并创建属性  
            if (i >= rows.Length)
            {
                AppendToFile(FileName, "\r\n" + strSection + "\r\n" + KeyName + "=" + Default);
                return Default;
            }

            //找到section  

            i += 1; //跳过section   

            int bakIdxSection = i;//备份section的下一行  

            string[] strLeft;

            //查找属性  
            for (; i < rows.Length; i++)
            {
                oneRow = rows[i].Trim();

                //空行  
                if (0 == oneRow.Length)
                    continue;

                //此行为注释  
                if (';' == oneRow[0])
                    continue;

                //越界  
                if ('[' == oneRow[0])
                    break;

                strLeft = Split(oneRow, "=");

                if (strLeft == null || strLeft.Length != 2)
                    continue;

                //找到属性  
                if (strLeft[0].Trim() == KeyName)
                {
                    //读  
                    if (isRead)
                    {
                        //c.找到属性但没有值  
                        if (0 == strLeft[1].Trim().Length)
                        {
                            rows[i] = strLeft[0].Trim() + "=" + Default;
                            WriteArray(FileName, rows);
                            return Default;
                        }
                        else
                        {
                            //找到了                          
                            return strLeft[1].Trim();
                        }
                    }

                    //写  
                    else
                    {
                        rows[i] = strLeft[0].Trim() + "=" + Default;
                        WriteArray(FileName, rows);
                        return Default;
                    }
                }
            }

            //d.没找到对应的属性,创建之并赋为默认  
            rows[bakIdxSection] = rows[bakIdxSection] + "\r\n" + KeyName + "=" + Default;
            WriteArray(FileName, rows);
            return Default;
        }
    }
}
