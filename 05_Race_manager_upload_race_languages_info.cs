using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races_libs
{
    public partial class Race_manager
    {
        private void Upload_languages_info()
        {
            foreach(Race_class Race in _Races)
            {
                foreach(string language in Language_1)
                {
                    if (language != "")
                    {
                        foreach(string race_language in Race_languages_coloumn_name)
                        {
                            if (language == race_language)
                            {
                                Race.Set_language_1_lvl(Languages[Race_languages_coloumn_name.IndexOf(race_language)][_Races.IndexOf(Race)]);
                            }
                        }
                    }
                }
            }
        }
    }
}
