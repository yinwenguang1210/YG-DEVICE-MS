using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YG_TestPlatform
{
    public class SQLiteSamples
    {
        //数据库连接
        SQLiteConnection m_dbConnection;


        public SQLiteSamples()
        { 
            bool flag = File.Exists(Path.GetFullPath("MyDatabase.sqlite"));

            if (!flag)
            {
                createNewDatabase();
                connectToDatabase();
                createTable();
                fillTable();
            }
            else
            {
                connectToDatabase();
            }
        }

        //创建一个空的数据库
        void createNewDatabase()
        {
            SQLiteConnection.CreateFile("MyDatabase.sqlite");
        }

        //创建一个连接到指定数据库
        void connectToDatabase()
        {
            m_dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
            m_dbConnection.Open();
        }

        //在指定数据库中创建一个table
        void createTable()
        {
            string sql = @"create table sys_config (id INTEGER PRIMARY KEY, name varchar(80), char_desc varchar(80), line_desc varchar(80), type_desc varchar(80), color_desc varchar(80))";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //插入一些数据
        void fillTable()
        {
            string sql = @"insert into sys_config (name, char_desc, line_desc, type_desc, color_desc) 
            values ('var1', '1','1.0','Line','44, 123, 182')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = @"insert into sys_config (name, char_desc, line_desc, type_desc, color_desc) 
            values ('var2', '1','1.0','Line','215, 25, 28')";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = @"insert into sys_config (name, char_desc, line_desc, type_desc, color_desc) 
            values ('var3', '1','1.0','Line','245, 163, 84')";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = @"insert into sys_config (name, char_desc, line_desc, type_desc, color_desc) 
            values ('var4', '1','1.0','Line','116, 170, 79')";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            sql = @"insert into sys_config (name, char_desc, line_desc, type_desc, color_desc) 
            values ('var5', '1','1.0','Line','167, 81, 154')";
            command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        //使用sql查询语句，并显示结果
        public List<SysConfig> getAll()
        {
            List<SysConfig> sysConfigs = new List<SysConfig>();
            string sql = "select * from sys_config order by id asc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SysConfig sys = new SysConfig();
                sys.Id = Convert.ToInt32(reader["id"].ToString());
                sys.Name = reader["name"].ToString();
                sys.CharDesc = reader["char_desc"].ToString();
                sys.LineDesc = reader["line_desc"].ToString();
                sys.TypeDesc = reader["type_desc"].ToString();
                sys.ColorDesc = reader["color_desc"].ToString();
                sysConfigs.Add(sys);
            }

            return sysConfigs;
        }

        public void deleteById(int id)
        {
            string sql = "delete from sys_config where id = " + id;
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void updateById(int id, SysConfig config)
        {
            string sql =string.Format( @" update sys_config set 
                name = '{0}',
                char_desc = '{1}',
                line_desc = '{2}',
                type_desc = '{3}',
                color_desc = '{4}' 
            where id = {5} ",config.Name,config.CharDesc,config.LineDesc,config.TypeDesc,config.ColorDesc, id);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void insert(SysConfig config)
        {
            string sql = string.Format(@"insert into sys_config (name, char_desc, line_desc, type_desc, color_desc) 
            values ('{0}', '{1}', '{2}', '{3}', '{4}')", config.Name, config.CharDesc, config.LineDesc, config.TypeDesc, config.ColorDesc);
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

    }

    public class SysConfig
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CharDesc { get; set; }
        public string LineDesc { get; set; }
        public string TypeDesc { get; set; }
        public string ColorDesc { get; set; }
    }
}
