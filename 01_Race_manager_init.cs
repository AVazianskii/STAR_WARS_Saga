using System.Collections.Generic;
using System.Data.SQLite;


namespace Races_libs
{
    public partial class Race_manager
    {
        // Сегмент кода, отвечающий за инициализацию различных переменных
        #region Объявление переменной в виде коллекции рас
        public List<Race_class> _Races;
        #endregion
        #region Объявление переменных для каждой из рас
        public Empty_race Empty_Race;
        public Human_race Human;
        public Botan_race Botan;
        public Cereanin_race Cereanin;
        public Duro_race Duro;
        public Evok_race Evok;
        public Gamor_race Gamor;
        public Gungan_race Gungan;
        public Kel_Dor_race Kel_Dor;
        public Mon_Kalamari_race Mon_Kalamari;
        public Rodian_race Rodian;
        public Sullu_race Sullu;
        public Trando_race Trando;
        public Tvi_lek_race Tvi_lek;
        public Wooki_race Wooki;
        public Zabrak_race Zabrak;
        #endregion

        #region переменные для обращения к базе SQLite
        private string SQLite_connection_string;
        private SQLiteConnection SQLite_connection;
        #endregion
        enum Type_of_var
        {
            string_type,
            int_type
        }
        #region инициализация коллекции коллекций общего описания рас
        private List<List<string>> Race_description;
        private List<string> Race_general_info_coloumn_name;
        #endregion
        #region инициализация коллекций общего описания рас
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

        #region инициализация коллекций языков рас
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
        private List<List<int>> Languages; // инициализация коллекции различных языков
        private List<string> Race_languages_coloumn_name; // инициализация коллекции столбцов в таблице по уровням знания языков у рас
        #endregion
    }
}
