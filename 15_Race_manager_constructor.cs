using System.Data.SQLite;
using System.Collections.Generic;

namespace Races_libs
{
    public partial class Race_manager
    {
        public Race_manager()
        {
            #region инициализация рас
            Empty_Race = new Empty_race();
            Human = new Human_race();
            Botan = new Botan_race();
            Cereanin = new Cereanin_race();
            Duro = new Duro_race();
            Evok = new Evok_race();
            Gamor = new Gamor_race();
            Gungan = new Gungan_race();
            Kel_Dor = new Kel_Dor_race();
            Mon_Kalamari = new Mon_Kalamari_race();
            Rodian = new Rodian_race();
            Sullu = new Sullu_race();
            Trando = new Trando_race();
            Tvi_lek = new Tvi_lek_race();
            Wooki = new Wooki_race();
            Zabrak = new Zabrak_race();
            #endregion
            #region инициализация коллекции рас
            _Races = new List<Race_class>();
            _Races.Add(Empty_Race); 
            _Races.Add(Human); 
            _Races.Add(Botan); 
            _Races.Add(Cereanin);
            _Races.Add(Duro); 
            _Races.Add(Evok);
            _Races.Add(Gamor);
            _Races.Add(Gungan);
            _Races.Add(Kel_Dor);
            _Races.Add(Mon_Kalamari);
            _Races.Add(Rodian);
            _Races.Add(Sullu);
            _Races.Add(Trando);
            _Races.Add(Tvi_lek);
            _Races.Add(Wooki);
            _Races.Add(Zabrak);
            #endregion
            #region инициализация полей основного описания рас
            General_description = new List<string>();
            Personal_properties = new List<string>();
            Physical_properties = new List<string>();
            Home_world = new List<string>();
            Language_1 = new List<string>();
            Language_2 = new List<string>();
            Language_3 = new List<string>();
            Language_4 = new List<string>();
            Feature_1 = new List<string>();
            Feature_2 = new List<string>();
            Feature_3 = new List<string>();
            Feature_4 = new List<string>();
            Feature_5 = new List<string>();
            Feature_6 = new List<string>();
            #endregion
            #region инициализация коллекции описаний рас
            Race_description = new List<List<string>>();
            Race_description.Add(General_description);
            Race_description.Add(Personal_properties);
            Race_description.Add(Physical_properties);
            Race_description.Add(Home_world);
            Race_description.Add(Language_1);
            Race_description.Add(Language_2);
            Race_description.Add(Language_3);
            Race_description.Add(Language_4);
            Race_description.Add(Feature_1);
            Race_description.Add(Feature_2);
            Race_description.Add(Feature_3);
            Race_description.Add(Feature_4);
            Race_description.Add(Feature_5);
            Race_description.Add(Feature_6);
            #endregion
            #region инициализация уровней знания языков рас
            Galactic_lang = new List<int>();
            Botan_lang = new List<int>();
            Cerenian_lang = new List<int>();
            Duro_lang = new List<int>();
            Evok_lang = new List<int>();
            Gamor_lang = new List<int>();
            Gungan_lang = new List<int>();
            Rodian_lang = new List<int>();
            Hatt_lang = new List<int>();
            Ril_lang = new List<int>();
            Leku_lang = new List<int>();
            Wooki_lang = new List<int>();
            Kel_dor_lang = new List<int>();
            Mon_kalamari_lang = new List<int>();
            Trando_lang = new List<int>();
            Sullu_lang = new List<int>();
            Zabrak_lang = new List<int>();
            #endregion
            #region инициализация коллекции языков рас
            Languages = new List<List<int>>();
            Languages.Add(Galactic_lang);
            Languages.Add(Botan_lang);
            Languages.Add(Cerenian_lang);
            Languages.Add(Duro_lang);
            Languages.Add(Evok_lang);
            Languages.Add(Gamor_lang);
            Languages.Add(Gungan_lang);
            Languages.Add(Rodian_lang);
            Languages.Add(Hatt_lang);
            Languages.Add(Ril_lang);
            Languages.Add(Leku_lang);
            Languages.Add(Wooki_lang);
            Languages.Add(Kel_dor_lang);
            Languages.Add(Mon_kalamari_lang);
            Languages.Add(Trando_lang);
            Languages.Add(Sullu_lang);
            Languages.Add(Zabrak_lang);
            #endregion

            SQLite_connection_string = @"Data Source=D:\STAR WARS Saga\Character_creation\Races_Libs\SW_Race_manager\Races.db;Version=3;";
            SQLite_connection = new SQLiteConnection(SQLite_connection_string);

            Race_languages_coloumn_name = new List<string>();
        }
    }
}
