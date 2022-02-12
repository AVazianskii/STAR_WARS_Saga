using System;

namespace Races_libs
{
    public partial class Race_manager
    {
        public void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            //Run_download_Race_general(); // Загружаем данные по общему описанию рас из базы во внутренние массивы
            //Run_download_race_languages();  // Загружаем данные по владению расами языками из базы во внутренние массивы
            string temp_string;
            int temp_int;

            Run_download_from_SQLite("SELECT * FROM Race_general ORDER BY ID",
                                      SQLite_connection,
                                      Race_general_info_coloumn_name,
                                      Race_description,
                                      (int)Type_of_var.string_type);

            Run_download_from_SQLite("SELECT * FROM Race_languages ORDER BY ID",
                                     SQLite_connection,
                                     Race_languages_coloumn_name,
                                     Languages,
                                     (int)Type_of_var.int_type);

            SQLite_connection.Close();

            Upload_general_info();       // Перекладываем считанные данные в конфигурационные поля объектов рас 
            Upload_languages_info();
        }
    }
}
