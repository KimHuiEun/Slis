using Slis.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slis.ConsoleUI
{
    public class PopolulationWriter
    {
        #region singleton 
        private PopolulationWriter()
        {
            _libraries = Dao.Library.ToDictionary(); //생성자에서 필드가 돌아가도록 
        }

        private static PopolulationWriter _instance;

        public static PopolulationWriter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PopolulationWriter();

                return _instance;
            }
        }
        #endregion

        private Dictionary<string, int> _libraries; //필드생성. 

        public void Write(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 4; i < lines.Length; i += 3) //남자, 여자
            {
                for (int j = 1; j <= 2; j++)
                {
                    var list = ParseLine(lines[i + j]);

                    foreach (var population in list)
                        Dao.Population.Insert(population);
                }
            }
        }

        /// <summary>
        /// 엑셀값불러오기 위한 데이터 넣기.
        /// </summary>
        /// <param name="line"></param>
        /// <param name="line2"></param>
        /// <returns></returns>
        private List<Population> ParseLine(string line)
        {
            //Dictionary<string, int> libraries = Dao.Library.ToDictionary
            //사전에 정의를 준다.
            //종로구 , 1                                                                            
            //이 코드를 사용할 경우 25개의 각 구역을 매번 해줘야하므로 필드를 만들어준다. 32nd줄

            string[] tokens = line.Split('\t');
            //종로구	남자	 71,623.50	4,253.00	6,051.50	11,707.50	10,104.00	10,973.50	12,279.50	16,254.50

            
            List<Population> populations = new List<Population>();

            for (int i = 3; i < tokens.Length; i++)
            {
                Population population = new Population();
                population.LibraryId = _libraries[tokens[0]];
                population.IsMale = tokens[1] == "남자";
                population.AgeCode = i - 3;
                population.Value = Convert.ToInt32(tokens[i]);

                populations.Add(population);
            }

            return populations;
        }
    }
}
