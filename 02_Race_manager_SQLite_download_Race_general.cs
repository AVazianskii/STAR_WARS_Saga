using System.Data.SQLite;
using System.Collections.Generic;
using System;

namespace Races_libs
{
    public partial class Race_manager
    {
        #region инициализация коллекции коллекций общего описания рас
        private List<List<string>> Race_description;
        private List<string> Race_general_info_coloumn_name;
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
        private List<string> Feature_7;

        
        #endregion
        private void Run_download_Race_general()
        {
            SQLite_Command_text = "SELECT * FROM Race_general ORDER BY ID";
            SQLite_command = new SQLiteCommand(SQLite_Command_text, SQLite_connection);
            SQLite_reader = SQLite_command.ExecuteReader();

            first_run = true;

            while (SQLite_reader.Read())
            {
                if (first_run)
                {
                    for (int i = 0; i < SQLite_reader.FieldCount; i++)
                    {
                        Race_general_info_coloumn_name.Add(SQLite_reader.GetName(i));
                    }
                    Race_general_info_coloumn_name.RemoveAt(0); // удаояем название столбца ID
                    Race_general_info_coloumn_name.RemoveAt(0); // удаояем название столбца Название расы
                    first_run = false;
                }
                int index;
                object temp_object;

                foreach (string coloumn_name in Race_general_info_coloumn_name)
                {
                    temp_object = SQLite_reader[coloumn_name];
                    index = Race_general_info_coloumn_name.IndexOf(coloumn_name);

                    if (!(temp_object is DBNull)) { Race_description[index].Add(Convert.ToString(temp_object)); } else { Race_description[index].Add(""); }
                }
            }
        }
    }
}
