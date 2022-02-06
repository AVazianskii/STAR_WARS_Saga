using System.Data.SQLite;
using System.Collections.Generic;
using System;

namespace Races_libs
{
    public partial class Race_manager
    {
        #region инициализация коллекции столбцов в таблице по уровням знания языков у рас
        public List<string> Race_languages_coloumn_name;
        #endregion
        #region инициализация переменных
        private List<int> Galactic_lang;
        private List<int> Botan_lang;
        private List<int> Cerenian_lang;
        private List<int> Duro_lang;
        private List<int> Evok_lang;
        private List<int> Gamor_lang;
        private List<int> Gungan_lang;
        private List<int> Rodian_lang;
        private List<int> Hatt_lang;
        private List<int> Ril_lang;
        private List<int> Leku_lang;
        private List<int> Wooki_lang;
        private List<int> Kel_dor_lang;
        private List<int> Mon_kalamari_lang;
        private List<int> Trando_lang;
        private List<int> Sullu_lang;
        private List<int> Zabrak_lang;
        #endregion

        #region инициализация коллекции различных языков
        public List<List<int>> Languages;
        #endregion

        bool first_run;

        private void Run_download_race_languages()
        {
            SQLite_Command_text = "SELECT * FROM Race_languages ORDER BY ID";
            SQLite_command = new SQLiteCommand(SQLite_Command_text, SQLite_connection);

            //while (!(SQLite_reader.IsClosed)) {; } // Если обращение к базе еще не закрыто, то паданем в пустой цикл, в котором
            // находимся до тех пор, пока не закроется 

            SQLite_reader = SQLite_command.ExecuteReader();

            first_run = true;

            while(SQLite_reader.Read()) 
            {
                if (first_run)
                {
                    for (int i = 0; i < SQLite_reader.FieldCount; i++)
                    {
                        Race_languages_coloumn_name.Add(SQLite_reader.GetName(i));
                    }
                    Race_languages_coloumn_name.RemoveAt(0); // удаояем название столбца ID
                    Race_languages_coloumn_name.RemoveAt(0); // удаояем название столбца Название расы
                    first_run = false;
                }
                int index;
                index = 0;

                // Здесь такая реализация, потому что на каждый столбец идет считывание всех строк, относящихся к этому столбцу
                foreach (string coloumn_name in Race_languages_coloumn_name)
                {
                    temp_object = SQLite_reader[coloumn_name];

                    for (;index < Languages.Capacity;)
                    {
                        if (!(temp_object is DBNull)) { Languages[index].Add(Convert.ToInt32(temp_object)); } else { Languages[index].Add(0); }
                        break;
                    }
                    index = index + 1;
                    if (index == Languages.Capacity)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}
