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
        private string SQLite_Command_text;

        private SQLiteConnection SQLite_connection;
        private SQLiteCommand SQLite_command;
        private SQLiteDataReader SQLite_reader;
        #endregion

        #region
        #endregion
    }
}
