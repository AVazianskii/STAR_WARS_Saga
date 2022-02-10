namespace Races_libs
{
    public partial class Race_manager
    {
        public void Run_download_and_upload_process()
        {
            SQLite_connection.Open();

            Run_download_Race_general(); // Загружаем данные по общему описанию рас из базы во внутренние массивы
            Run_download_race_languages();  // Загружаем данные по владению расами языками из базы во внутренние массивы



            SQLite_connection.Close();

            Upload_general_info();       // Перекладываем считанные данные в конфигурационные поля объектов рас 
            Upload_languages_info();
        }
    }
}
