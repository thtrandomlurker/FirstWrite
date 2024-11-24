using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FirstLib.FirstRead;
using FirstLib.IO;

namespace FirstReadPVDBDump
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamWriter pvdb = File.CreateText(args[1]);

            using (XReader reader = new XReader(File.Open(args[0], FileMode.Open)))
            {
                ADCT firstread = new ADCT();
                firstread.Read(reader);

                Console.WriteLine(STRA.GetStringFromArraysById(20801100, firstread.AddonContentContainers[0].StringArrays));

                foreach (var acct in firstread.AddonContentContainers)
                {
                    foreach (var parameterDatabase in acct.ParameterDatabases)
                    {
                        for (int i = 0; i < parameterDatabase.PvTable.PvInfoTable.Count; i++)
                        {
                            // we hope this works
                            var pvInfo = parameterDatabase.PvTable.PvInfoTable[i];
                            var pvData = parameterDatabase.PvTable.PvDataTable.First(x => x.PvID == pvInfo.PvID);
                            var pvSabi = parameterDatabase.PvTable.PvSabiTable.First(x => x.PvID == pvData.PvID);

                            int pvId = pvData.PvID;

                            DateTime curDate = DateTime.Now;

                            if (pvData.MinBPM != pvData.MaxBPM)
                            {
                                pvdb.WriteLine($"pv_{pvId:D3}.bpm={pvData.MinBPM}-{pvData.MaxBPM}");
                            }
                            else
                            {
                                pvdb.WriteLine($"pv_{pvId:D3}.bpm={pvData.MinBPM}");
                            }
                            pvdb.WriteLine($"pv_{pvId:D3}.date={curDate.Year:D4}{curDate.Month:D2}{curDate.Day:D2}");  // nothing wrong with using today

                            if (pvInfo.HasEasy)
                            {
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.0.edition=0");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.0.level=PV_LV_{(pvInfo.EasyDifficulty / 2):D2}_{((pvInfo.EasyDifficulty % 2) == 1 ? 0 : 5)}");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.0.level_sort_index=20");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.0.script_file_name=rom/script/pv_{pvId:D3}_easy.dsc");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.0.script_format=0x43535650");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.0.version=0");
                            }
                            pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.length={(pvInfo.HasEasy ? 0 : 1)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.difficulty.encore.length=0");

                            if (pvInfo.HasExtreme)
                            {
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.0.edition=0");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.0.level=PV_LV_{(pvInfo.ExtremeDifficulty / 2):D2}_{((pvInfo.ExtremeDifficulty % 2) == 1 ? 0 : 5)}");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.0.level_sort_index=20");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.0.script_file_name=rom/script/pv_{pvId:D3}_extreme.dsc");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.0.script_format=0x43535650");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.0.version=0");
                            }
                            pvdb.WriteLine($"pv_{pvId:D3}.difficulty.extreme.length={(pvInfo.HasExtreme ? 0 : 1)}");

                            if (pvInfo.HasHard)
                            {
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.0.edition=0");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.0.level=PV_LV_{(pvInfo.HardDifficulty / 2):D2}_{((pvInfo.HardDifficulty % 2) == 1 ? 0 : 5)}");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.0.level_sort_index=20");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.0.script_file_name=rom/script/pv_{pvId:D3}_hard.dsc");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.0.script_format=0x43535650");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.0.version=0");
                            }
                            pvdb.WriteLine($"pv_{pvId:D3}.difficulty.hard.length={(pvInfo.HasHard ? 0 : 1)}");

                            if (pvInfo.HasNormal)
                            {
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.normal.0.edition=0");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.normal.0.level=PV_LV_{(pvInfo.NormalDifficulty / 2):D2}_{((pvInfo.NormalDifficulty % 2) == 1 ? 0 : 5)}");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.normal.0.level_sort_index=20");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.normal.0.script_file_name=rom/script/pv_{pvId:D3}_normal.dsc");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.normal.0.script_format=0x43535650");
                                pvdb.WriteLine($"pv_{pvId:D3}.difficulty.normal.0.version=0");
                            }
                            pvdb.WriteLine($"pv_{pvId:D3}.difficulty.easy.length={(pvInfo.HasNormal ? 0 : 1)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.disp2d.set_name={pvId:D3}");
                            pvdb.WriteLine($"pv_{pvId:D3}.eyes_xrot_adjust=1");
                            pvdb.WriteLine($"pv_{pvId:D3}.hidden_timing=0.3");
                            pvdb.WriteLine($"pv_{pvId:D3}.high_speed_rate=4");

                            for (int l = 0; l < 500; l++)
                            {
                                string s = STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}{100 + l}"), acct.StringArrays);
                                if (s == "")
                                {
                                    break;
                                }

                                pvdb.WriteLine($"pv_{pvId:D3}.lyric.{(l+1):D3}={s}");
                            }

                            for (int l = 0; l < 500; l++)
                            {
                                string s = STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}{600 + l}"), acct.StringArrays);
                                if (s == "")
                                {
                                    break;
                                }

                                pvdb.WriteLine($"pv_{pvId:D3}.lyric_en.{(l + 1):D3}={s}");
                            }

                            pvdb.WriteLine("# Motions must be manually added as i am not reading the entire structure of X's data just to find what motion exists in a farc.");

                            for (int p = 0; p < pvData.Performers.Count; p++)
                            {
                                // we love whatever this is
                                pvdb.WriteLine($"pv_{pvId:D3}.performer.{p:D1}.chara={new string(pvData.Performers[p].Character.ToString().ToUpper().Take(3).ToArray())}");
                                pvdb.WriteLine($"pv_{pvId:D3}.performer.{p:D1}.costume={pvData.Performers[p].Costume}");
                                pvdb.WriteLine($"pv_{pvId:D3}.performer.{p:D1}.pv_costume={pvData.Performers[p].PvCostume}");
                                pvdb.WriteLine($"pv_{pvId:D3}.performer.{p:D1}.type=VOCAL");
                            }
                            pvdb.WriteLine($"pv_{pvId:D3}.performer.num={pvData.Performers.Count}");
                            pvdb.WriteLine($"pv_{pvId:D3}.sabi.play_time={pvSabi.SabiPlayTime}");
                            pvdb.WriteLine($"pv_{pvId:D3}.sabi.start_time={pvSabi.SabiStartTime}");
                            pvdb.WriteLine($"pv_{pvId:D3}.se_name=41_button9");
                            pvdb.WriteLine($"pv_{pvId:D3}.slide_name=slide_se13");
                            pvdb.WriteLine($"pv_{pvId:D3}.slidertouch_name=slide_windchime");
                            pvdb.WriteLine($"pv_{pvId:D3}.song_file_name=rom/sound/song/pv_{pvId:D3}.ogg");
                            Console.WriteLine($"Getting title from \"20{pvId:D3}000\"");
                            pvdb.WriteLine($"pv_{pvId:D3}.song_name={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}000"), acct.StringArrays)}");
                            Console.WriteLine($"pv_{pvId:D3}.song_name={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}000"), acct.StringArrays)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.song_name_reading={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}000"), acct.StringArrays)}");  // X has no reading
                            pvdb.WriteLine($"pv_{pvId:D3}.songinfo.arranger={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}001"), acct.StringArrays)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.songinfo.illustrator={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}002"), acct.StringArrays)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.songinfo.lyrics={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}003"), acct.StringArrays)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.songinfo.music={STRA.GetStringFromArraysById(int.Parse($"20{pvId:D3}004"), acct.StringArrays)}");
                            pvdb.WriteLine($"pv_{pvId:D3}.sudden_timing=0.6");
                           
                        }
                    }
                }
            }

            pvdb.Close();
        }
    }
}
