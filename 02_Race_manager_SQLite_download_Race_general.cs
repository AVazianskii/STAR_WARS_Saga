using System.Data.SQLite;
using System.Collections.Generic;
using System;

namespace Races_libs
{
    public partial class Race_manager
    {
        #region инициализация коллекции коллекций общего описания рас
        private List<List<string>> Race_description;
        #endregion
        #region инициализация переменных
        private List<string> General_description;
        private List<string> Personal_properties;
        private List<string> Physical_properties;
        private List<string> Home_world;
        private List<string> Language_1;
        private List<string> Language_2;
        private List<string> Language_3;
        private List<string> Language_4;
        private List<string> Feature_1;
        private List<string> Feature_2;
        private List<string> Feature_3;
        private List<string> Feature_4;
        private List<string> Feature_5;
        private List<string> Feature_6;

        private object temp_object;
        #endregion
        private void Run_download_Race_general()
        {


            //if (SQLite_reader != null)
            //{
            //while (!(SQLite_reader.IsClosed)) {; } // Если обращение к базе еще не закрыто, то паданем в пустой цикл, в котором
            // находимся до тех пор, пока не закроется 

            //}
            //if (SQLite_reader == null) //|| SQLite_reader.IsClosed
            //{
            SQLite_Command_text = "SELECT * FROM Race_general ORDER BY ID";
                SQLite_command = new SQLiteCommand(SQLite_Command_text, SQLite_connection);
                SQLite_reader = SQLite_command.ExecuteReader();
                while (SQLite_reader.Read())
                {
                    temp_object = SQLite_reader["Общее_описание"];
                    if (!(temp_object is System.DBNull)) { General_description.Add((string)SQLite_reader["Общее_описание"]); } else { General_description.Add(""); }
                    temp_object = SQLite_reader["Персональные_свойства"];
                    if (!(temp_object is System.DBNull)) { Personal_properties.Add((string)SQLite_reader["Персональные_свойства"]); } else { Personal_properties.Add(""); }
                    temp_object = SQLite_reader["Физические_данные"];
                    if (!(temp_object is System.DBNull)) { Physical_properties.Add((string)SQLite_reader["Физические_данные"]); } else { Physical_properties.Add(""); }
                    temp_object = SQLite_reader["Родной_мир"];
                    if (!(temp_object is System.DBNull)) { Home_world.Add((string)SQLite_reader["Родной_мир"]); } else { Home_world.Add(""); }
                    temp_object = SQLite_reader["Язык_1"];
                    if (!(temp_object is System.DBNull)) { Language_1.Add((string)SQLite_reader["Язык_1"]); } else { Language_1.Add(""); }
                    temp_object = SQLite_reader["Язык_2"];
                    if (!(temp_object is System.DBNull)) { Language_2.Add((string)SQLite_reader["Язык_2"]); } else { Language_2.Add(""); }
                    temp_object = SQLite_reader["Язык_3"];
                    if (!(temp_object is System.DBNull)) { Language_3.Add((string)SQLite_reader["Язык_3"]); } else { Language_3.Add(""); }
                    temp_object = SQLite_reader["Язык_4"];
                    if (!(temp_object is System.DBNull)) { Language_4.Add((string)SQLite_reader["Язык_4"]); } else { Language_4.Add(""); }
                    temp_object = SQLite_reader["Особенность_1"];
                    if (!(temp_object is System.DBNull)) { Feature_1.Add((string)SQLite_reader["Особенность_1"]); } else { Feature_1.Add(""); }
                    temp_object = SQLite_reader["Особенность_2"];
                    if (!(temp_object is System.DBNull)) { Feature_2.Add((string)SQLite_reader["Особенность_2"]); } else { Feature_2.Add(""); }
                    temp_object = SQLite_reader["Особенность_3"];
                    if (!(temp_object is System.DBNull)) { Feature_3.Add((string)SQLite_reader["Особенность_3"]); } else { Feature_3.Add(""); }
                    temp_object = SQLite_reader["Особенность_4"];
                    if (!(temp_object is System.DBNull)) { Feature_4.Add((string)SQLite_reader["Особенность_4"]); } else { Feature_4.Add(""); }
                    temp_object = SQLite_reader["Особенность_5"];
                    if (!(temp_object is System.DBNull)) { Feature_5.Add((string)SQLite_reader["Особенность_5"]); } else { Feature_5.Add(""); }
                    temp_object = SQLite_reader["Особенность_6"];
                    if (!(temp_object is System.DBNull)) { Feature_6.Add((string)SQLite_reader["Особенность_6"]); } else { Feature_6.Add(""); }
                //}
            }

        }
    }
}
